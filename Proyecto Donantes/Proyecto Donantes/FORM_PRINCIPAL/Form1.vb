Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RegistrarCampañasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarCampañasToolStripMenuItem.Click
        Dim frmcampaña As New campaña
        frmcampaña.Show()
    End Sub

    Private Sub ListaDeDonantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeDonantesToolStripMenuItem.Click
        Dim frmdonanteCamp As New donantes_camp
        frmdonanteCamp.Show()
    End Sub

    Private Sub RegistrarPersonalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarPersonalToolStripMenuItem.Click
        Dim frmpersonal As New personal
        frmpersonal.Show()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        MsgBox("En construccion :)")
    End Sub
End Class
