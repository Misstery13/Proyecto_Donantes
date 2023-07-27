Public Class frm_personal
    Public cedula As String
    Private Sub frm_personal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fun_recuperarCampañas()
        cbo_campaña.DropDownStyle = ComboBoxStyle.DropDownList
        Try
            If cedula <> "" Then
                'editar
                txt_cedula.Enabled = False
                If fun_recuperarPersonal(cedula) = False Then
                    MsgBox("La campaña no se puede recuperar")
                End If
            Else
                'crear un nuevo
                txt_cedula.Enabled = True
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

            consultaSql = " SELECT * FROM personal where Apellidos_Nombres like '" & nombres & "%'"
            If conectar() = True Then
                dr = ejecurar_consultatxt(consultaSql)
                If dr.HasRows = True Then
                    While dr.Read
                        txt_cedula.Text = dr("Cedula")
                        txt_nombres.Text = dr("Apellidos_Nombres")
                        txt_fechanac.Text = dr("Fecha_Nacimiento")
                        txt_direccion.Text = dr("Direccion")
                        txt_telefono.Text = dr("Telefono")
                        txt_correo.Text = dr("Correo_Electronico")
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

            If cedula = "" Then
                'inserte
                cadenaSql = cadenaSql & " insert into personal (Cedula,Apellidos_Nombres,Fecha_Nacimiento,Direccion,Telefono,Correo_Electronico) "
                cadenaSql = cadenaSql & " values ( "
                cadenaSql = cadenaSql & " '" & txt_cedula.Text & "',"
                cadenaSql = cadenaSql & "  '" & txt_nombres.Text & "',"
                cadenaSql = cadenaSql & "  '" & txt_fechanac.Text & "',"
                cadenaSql = cadenaSql & "  '" & txt_direccion.Text & "',"
                cadenaSql = cadenaSql & "  '" & txt_telefono.Text & "'"
                cadenaSql = cadenaSql & "  '" & txt_correo.Text & "'"
                cadenaSql = cadenaSql & " )"

            Else
                'update
                cadenaSql = cadenaSql & " update personal set "
                cadenaSql = cadenaSql & " Apellidos_Nombres='" & txt_nombres.Text & "',"
                cadenaSql = cadenaSql & " Fecha_Nacimiento='" & txt_fechanac.Text & "',"
                cadenaSql = cadenaSql & " Direccion='" & txt_direccion.Text & "',"
                cadenaSql = cadenaSql & " Telefono='" & txt_telefono.Text & "'"
                cadenaSql = cadenaSql & " Correo_Electronico='" & txt_correo.Text & "'"
                cadenaSql = cadenaSql & " where cedula= '" & txt_cedula.Text & "'"

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
End Class