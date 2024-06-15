Public Class frm_personal
    Public ID As String
    Private Sub frm_personal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_IDpersonal.ReadOnly = True
        fun_recuperarCampañas()
        cbo_campaña.DropDownStyle = ComboBoxStyle.DropDownList
        Try
            If ID <> "" Then
                'editar
                txt_IDpersonal.Enabled = False
                If fun_recuperarPersonal(ID) = False Then
                    MsgBox("La campaña no se puede recuperar")
                End If
            Else
                'crear un nuevo
                txt_IDpersonal.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function fun_recuperarCampañas() As Boolean
        Try
            Dim cadenaSql As String = ""
            cadenaSql = cadenaSql & " select Nombre from campaña; "
            'cadenaSql = cadenaSql & " where Nombre " & CInt(cbo_campaña.Text)

            If conectar() = False Then
                Return False
            End If

            cbo_campaña.Items.Clear()
            dr = ejecurar_consultatxt(cadenaSql)

            If dr.HasRows Then
                While dr.Read
                    cbo_campaña.Items.Add(dr("Nombre"))
                End While
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            dr.Close()
            desconectar()
        End Try
    End Function
    Private Function fun_recuperarPersonal(ByVal nombres As String) As Boolean
        Try
            Dim consultaSql As String = ""

            consultaSql = " SELECT p.ID_Personal, p.Cedula, p.Apellidos_Nombres, p.Fecha_Nacimiento, p.Direccion, p.Telefono, p.Correo_Electronico, p.Usuario, p.Clave, c.Nombre AS NombreCampaña FROM personal AS p INNER JOIN campaña AS c ON p.ID_Campaña = c.ID_Campaña WHERE c.Nombre LIKE '%" & nombres & "%';"
            If conectar() = True Then
                dr = ejecurar_consultatxt(consultaSql)
                If dr.HasRows = True Then
                    While dr.Read
                        cbo_campaña.Text = dr("NombreCampaña")
                        txt_IDpersonal.Text = dr("ID_Personal")
                        txt_cedula.Text = dr("Cedula")
                        txt_nombres.Text = dr("Apellidos_Nombres")
                        txt_fechanac.Text = dr("Fecha_Nacimiento")
                        txt_direccion.Text = dr("Direccion")
                        txt_telefono.Text = dr("Telefono")
                        txt_correo.Text = dr("Correo_Electronico")
                        txt_user.Text = dr("Usuario")
                        txt_clave.Text = dr("Clave")
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
        If Trim(cbo_campaña.Text) = "" Then
            MsgBox("Seleccione la campaña")
            Return False
        End If
        If Trim(txt_cedula.Text) = "" Then
            MsgBox("Registre el número de cédula")
            Return False
        End If
        If Trim(txt_nombres.Text) = "" Then
            MsgBox("Registre el nombre")
            Return False
        End If
        Return True
    End Function
    Private Function fun_grabar() As Boolean

        Try
            Dim cadenaSql As String = ""

            If ID = "" Then
                'inserte
                'cadenaSql = cadenaSql & " insert into personal (NombreCampaña,Cedula,Apellidos_Nombres,Fecha_Nacimiento,Direccion,Telefono,Correo_Electronico,Usuario,Clave) "

                cadenaSql &= "INSERT INTO personal (Cedula, Apellidos_Nombres, Fecha_Nacimiento, Direccion, Telefono, Correo_Electronico, Usuario, Clave, ID_Campaña) "
                cadenaSql &= "SELECT '" & txt_cedula.Text & "', "
                cadenaSql &= "'" & txt_nombres.Text & "', "
                cadenaSql &= "'" & txt_fechanac.Text & "', "
                cadenaSql &= "'" & txt_direccion.Text & "', "
                cadenaSql &= "'" & txt_telefono.Text & "', "
                cadenaSql &= "'" & txt_correo.Text & "', "
                cadenaSql &= "'" & txt_user.Text & "', "
                cadenaSql &= "'" & txt_clave.Text & "', "
                cadenaSql &= "c.ID_Campaña "
                cadenaSql &= "FROM campaña AS c "
                cadenaSql &= "WHERE c.Nombre LIKE '%" & cbo_campaña.Text & "%';"
            Else
                cadenaSql &= "UPDATE personal SET "
                cadenaSql &= "Cedula = '" & txt_cedula.Text & "', "
                cadenaSql &= "Apellidos_Nombres = '" & txt_nombres.Text & "', "
                cadenaSql &= "Fecha_Nacimiento = '" & txt_fechanac.Text & "', "
                cadenaSql &= "Direccion = '" & txt_direccion.Text & "', "
                cadenaSql &= "Telefono = '" & txt_telefono.Text & "', "
                cadenaSql &= "Correo_Electronico = '" & txt_correo.Text & "', "
                cadenaSql &= "Usuario = '" & txt_user.Text & "', "
                cadenaSql &= "Clave = '" & txt_clave.Text & "', "
                cadenaSql &= "ID_Campaña = (SELECT ID_Campaña FROM campaña WHERE Nombre LIKE '%" & cbo_campaña.Text & "%') "
                cadenaSql &= "WHERE ID_Personal = '" & txt_IDpersonal.Text & "'"
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
    Private Sub btn_cancelar_Click_1(sender As Object, e As EventArgs) Handles btn_cancelr.Click
        Me.Close()
    End Sub

    Private Sub txt_IDpersonal_TextChanged(sender As Object, e As EventArgs) Handles txt_IDpersonal.TextChanged

    End Sub
End Class