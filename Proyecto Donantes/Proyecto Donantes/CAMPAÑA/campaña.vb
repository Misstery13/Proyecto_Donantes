
Public Class campaña
    Private Sub dgv_campañas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_campañas.CellDoubleClick
        Try
            If e.RowIndex > -1 Then
                Dim frm As New frm_campaña
                frm.id = dgv_campañas.Rows(e.RowIndex).Cells(0).Value
                frm.ShowDialog()
                'cargar nuevamente la información
                If Buscarcampañas(txt_buscar.Text) = False Then
                    MsgBox("No existe estudiantes")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function Buscarcampañas(ByVal textobuscar As String) As Boolean
        Try
            Buscarcampañas = False
            Dim consultaSql As String = ""
            dgv_campañas.Rows.Clear()
            consultaSql = " SELECT * FROM campaña where Nombre like '" & textobuscar & "%'"
            If conectar() = True Then
                dr = ejecurar_consultatxt(consultaSql)
                If dr.HasRows = True Then
                    While dr.Read
                        dgv_campañas.Rows.Add(dr("ID_Campaña"), dr("Nombre"), dr("Lugar"), dr("Fecha"), dr("Estado"))
                    End While
                End If
                dr.Close()
            End If
            Buscarcampañas = True
        Catch ex As Exception
            Buscarcampañas = False
        Finally
            desconectar()
        End Try
    End Function

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub campaña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Buscarcampañas(txt_buscar.Text) = False Then
            MsgBox("No existe campaña")
        End If
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            If Buscarcampañas(txt_buscar.Text) = False Then
                MsgBox(" No existe el registro Buscado")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Try
            Dim frm As New frm_campaña
            frm.id = ""
            frm.ShowDialog()
            'cargar nuevamente la información
            If Buscarcampañas(txt_buscar.Text) = False Then
                MsgBox("No existen campañas")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class