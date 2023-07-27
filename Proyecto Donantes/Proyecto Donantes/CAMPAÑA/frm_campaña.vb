Public Class frm_campaña
    Public id As String

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub frm_campaña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If id <> "" Then
                'editar
                txt_id.Enabled = False
                If fun_recuperarCampañas(id) = False Then
                    MsgBox("La campaña no se puede recuperar")
                End If
            Else
                'crear un nuevo
                txt_id.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function fun_recuperarCampañas(ByVal idc As String) As Boolean
        Try
            Dim consultaSql As String = ""

            consultaSql = " SELECT * FROM campaña where ID_campaña like '" & idc & "%'"
            If conectar() = True Then
                dr = ejecurar_consultatxt(consultaSql)
                If dr.HasRows = True Then
                    While dr.Read
                        txt_id.Text = dr("ID_campaña")
                        txt_nombre.Text = dr("Nombre")
                        txt_lugar.Text = dr("Lugar")
                        txt_fecha.Text = dr("Fecha")
                        txt_estado.Text = dr("Estado")
                    End While
                End If
                dr.Close()
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectar()
        End Try

    End Function

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            If fun_validar() = True Then
                If fun_grabar() = True Then
                    MsgBox("Se registró con éxito")
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function fun_validar() As Boolean
        If Trim(txt_id.Text) = "" Then
            MsgBox("Registre el número de cédula")
            Return False
        End If
        If Trim(txt_nombre.Text) = "" Then
            MsgBox("Registre el nombre")
            Return False
        End If
        Return True
    End Function
    Private Function fun_grabar() As Boolean

        Try
            Dim cadenaSql As String = ""

            If id = "" Then
                'inserte
                cadenaSql = cadenaSql & " insert into campaña (ID_campaña,Nombre,Lugar,Fecha,Estado) "
                cadenaSql = cadenaSql & " values ( "
                cadenaSql = cadenaSql & " '" & txt_id.Text & "',"
                cadenaSql = cadenaSql & "  '" & txt_nombre.Text & "',"
                cadenaSql = cadenaSql & "  '" & txt_lugar.Text & "',"
                cadenaSql = cadenaSql & "  '" & txt_fecha.Text & "',"
                cadenaSql = cadenaSql & "  '" & txt_estado.Text & "'"
                cadenaSql = cadenaSql & " )"

            Else
                'update
                cadenaSql = cadenaSql & " update campaña set "
                cadenaSql = cadenaSql & " Nombre='" & txt_nombre.Text & "',"
                cadenaSql = cadenaSql & " Lugar='" & txt_lugar.Text & "',"
                cadenaSql = cadenaSql & " Fecha='" & txt_fecha.Text & "',"
                cadenaSql = cadenaSql & " Estado='" & txt_estado.Text & "'"
                cadenaSql = cadenaSql & " where ID_campaña= '" & txt_id.Text & "'"

            End If
            ' conectar a la BD
            If conectar() = False Then
                Return False
            End If
            If ejecutar_sqltxt(cadenaSql) = False Then
                Return False
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Private Sub btn_cancelar_Click_1(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class