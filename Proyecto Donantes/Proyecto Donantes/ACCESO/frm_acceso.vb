Public Class frm_acceso
    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Try
            If fun_validar() = True Then
                If fun_validarAcceso(txt_usuario.Text, txt_clave.Text) = True Then
                    'acceder al formulario principal
                    Dim frm As New Form1
                    Me.Hide()
                    frm.Show()
                Else
                    MsgBox("Usuario o clave incorrecta", MsgBoxStyle.Information)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function fun_validar() As Boolean
        If Trim(txt_usuario.Text) = "" Then
            MsgBox("Registre el usuario", MsgBoxStyle.Information)
            txt_usuario.Focus()
            Return False
        End If
        If Trim(txt_clave.Text) = "" Then
            MsgBox("Registre la clave", MsgBoxStyle.Information)
            txt_clave.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function fun_validarAcceso(ByVal usuario As String, ByVal clave As String) As Boolean
        Try
            Dim cadenaSql As String = ""
            cadenaSql = "select p.ID_Cargo from personal as p where p.Usuario = '" & txt_usuario.Text & "' and p.Clave = '" & txt_clave.Text & "';"

            'conectar con la BD
            If conectar() = False Then
                Return False
            End If
            dr = ejecurar_consultatxt(cadenaSql)
            While dr.Read()
                If dr(0) > 0 Then
                    Return True
                Else
                    Return False
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectar()
        End Try

    End Function

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged

    End Sub
End Class