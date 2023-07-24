Imports System.Drawing.Imaging
Imports System.IO
Imports MySql.Data.MySqlClient
Module MODconexion
    Dim servidor As String = "localhost"
    Dim basededatos As String = "distrito_24d02"
    Dim usuario As String = "root"
    Dim clave As String = ""
    Dim puerto As String = "3306"
    Public cadenaConexion As String = "server=" & servidor & ";database=" & basededatos & ";user id=" & usuario & ";password=" & clave & ";port=" & puerto & ";"
    'Dim cadenaConexion As String = "server=localhost;database=ejemplobd;user id=root;password=;port=3306;"
    Dim conn As New MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As New MySqlDataAdapter
    Public dtabla As New DataTable

    Public Function conectar()
        Try
            conectar = False
            conn = New MySqlConnection

            conn.ConnectionString = cadenaConexion
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                conectar = True
            End If

        Catch ex As Exception
            conectar = False
        End Try
    End Function

    Public Sub desconectar()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function ejecurar_consultatxt(ByVal cadenasql As String) As MySqlDataReader
        Try

            cmd = New MySqlCommand
            cmd.CommandText = cadenasql
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            'dr = cmd.ExecuteReader()
            Return cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function ejecurar_consulta(ByVal procedimiento As String) As MySqlDataReader
        Try
            'grabar pasando procedimiento
            cmd = New MySqlCommand
            cmd.CommandText = procedimiento
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            dr = cmd.ExecuteReader()
            Return dr
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function ejecurar_consulta(ByVal procedimiento As String, ByVal ParamArray parametro() As String) As MySqlDataReader
        Dim i As Integer
        Try
            cmd = New MySqlCommand
            cmd.CommandText = procedimiento
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            'cargar los parametros
            MySqlCommandBuilder.DeriveParameters(cmd) 'trae los parametros
            For i = 1 To parametro.Length
                CType(cmd.Parameters(i), MySqlParameter).Value = parametro(i - 1)
            Next
            dr = cmd.ExecuteReader()
            Return dr
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    'para insertar , Actualizar, eliminar

    Public Function ejecutar_sqltxt(ByVal procedimiento As String) As Boolean
        Try
            'graba o actualiza solo texto
            cmd = New MySqlCommand
            cmd.CommandText = procedimiento
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function ejecutar_sql(ByVal procedimiento As String, ByVal ParamArray parametro() As String) As Boolean
        Dim i As Integer
        Try
            'graba o actualiza
            cmd = New MySqlCommand
            cmd.CommandText = procedimiento
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            'cargar los parametros
            MySqlCommandBuilder.DeriveParameters(cmd) 'trae los parametros
            For i = 1 To parametro.Length
                CType(cmd.Parameters(i), MySqlParameter).Value = parametro(i - 1)
            Next
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Public Function fun_ExecuteReader(ByVal cadenasql As String, Optional i As Integer = 0) As MySqlDataReader
        Try
            cmd = New MySqlCommand
            cmd.CommandText = cadenasql
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Return cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'convertir binario a imágen
    Public Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    'convertir imagen a binario
    Public Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo)
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function
End Module
