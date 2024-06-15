Public Class donantes_camp
    Private Sub dgv_donanCamp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_donanCamp.CellContentClick

    End Sub
    Private Function Buscardonantes_camp(ByVal textobuscar As String) As Boolean
        Try
            Buscardonantes_camp = False
            Dim consultaSql As String = ""
            dgv_donanCamp.Rows.Clear()
            '" SELECT * FROM campaña where Nombre like '" & textobuscar & "%'"
            consultaSql = "SELECT d.Cedula, d.Apellidos_Nombres, d.Tipo_Sangre, d.Fecha_Donacion, c.Nombre AS NombreCampaña FROM donante AS d INNER JOIN campaña AS c ON d.ID_Campaña = c.ID_Campaña WHERE c.Nombre LIKE '%" & textobuscar & "%';"

            If conectar() = True Then
                dr = ejecurar_consultatxt(consultaSql)
                If dr.HasRows = True Then
                    While dr.Read
                        dgv_donanCamp.Rows.Add(dr("Cedula"), dr("Apellidos_Nombres"), dr("Tipo_Sangre"), dr("Fecha_Donacion"), dr("NombreCampaña"))
                    End While
                End If
                dr.Close()
            End If
            Buscardonantes_camp = True
        Catch ex As Exception
            Buscardonantes_camp = False
        Finally
            desconectar()
        End Try
    End Function

    Private Sub donantes_camp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Buscardonantes_camp(txt_buscar.Text) = False Then
            MsgBox("No existe donante")
        End If
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            If Buscardonantes_camp(txt_buscar.Text) = False Then
                MsgBox(" No existe el registro Buscado")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class