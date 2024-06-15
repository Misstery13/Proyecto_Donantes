Public Class personal
    Private Sub dgv_personal_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_personal.CellDoubleClick
        Try
            If e.RowIndex > -1 Then
                Dim frm As New frm_personal
                frm.ID = dgv_personal.Rows(e.RowIndex).Cells(0).Value
                frm.ShowDialog()
                'cargar nuevamente la información
                If Buscarpersonal(txt_buscar.Text) = False Then
                    MsgBox("No existe personal")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Buscarpersonal(ByVal textobuscar As String) As Boolean
        Try
            Buscarpersonal = False
            Dim consultaSql As String = ""
            dgv_personal.Rows.Clear()
            consultaSql = " SELECT p.ID_Personal, p.Cedula, p.Apellidos_Nombres, p.Fecha_Nacimiento, p.Direccion, p.Telefono, p.Correo_Electronico, p.Usuario, p.Clave, c.Nombre AS NombreCampaña FROM personal AS p INNER JOIN campaña AS c ON p.ID_Campaña = c.ID_Campaña WHERE p.Apellidos_Nombres LIKE '%" & textobuscar & "%';"
            If conectar() = True Then
                dr = ejecurar_consultatxt(consultaSql)
                If dr.HasRows = True Then
                    While dr.Read
                        dgv_personal.Rows.Add(dr("NombreCampaña"), dr("ID_Personal"), dr("Cedula"), dr("Apellidos_Nombres"), dr("Fecha_Nacimiento"), dr("Direccion"), dr("Telefono"), dr("Correo_Electronico"), dr("Usuario"), dr("Clave"))
                    End While
                End If
                dr.Close()
            End If
            Buscarpersonal = True
        Catch ex As Exception
            Buscarpersonal = False
        Finally
            desconectar()
        End Try
    End Function

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Try
            Dim frm As New frm_personal
            frm.ID = ""
            frm.ShowDialog()
            'cargar nuevamente la información
            If Buscarpersonal(txt_buscar.Text) = False Then
                MsgBox("No existe personal")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub dgv_personal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_personal.CellContentClick

    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            If Buscarpersonal(txt_buscar.Text) = False Then
                MsgBox(" No existe el registro Buscado")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub personal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Buscarpersonal(txt_buscar.Text) = False Then
            MsgBox("No existe personal")
        End If
    End Sub
End Class