<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        RegistrarCampañasToolStripMenuItem = New ToolStripMenuItem()
        RegistrarPersonalToolStripMenuItem = New ToolStripMenuItem()
        RegistrarDonacionesToolStripMenuItem = New ToolStripMenuItem()
        ListaDeDonantesToolStripMenuItem = New ToolStripMenuItem()
        BuscarDonantesToolStripMenuItem = New ToolStripMenuItem()
        AyudaToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {RegistrarCampañasToolStripMenuItem, RegistrarPersonalToolStripMenuItem, RegistrarDonacionesToolStripMenuItem, ListaDeDonantesToolStripMenuItem, BuscarDonantesToolStripMenuItem, AyudaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' RegistrarCampañasToolStripMenuItem
        ' 
        RegistrarCampañasToolStripMenuItem.Name = "RegistrarCampañasToolStripMenuItem"
        RegistrarCampañasToolStripMenuItem.Size = New Size(124, 20)
        RegistrarCampañasToolStripMenuItem.Text = "Registrar Campañas"
        ' 
        ' RegistrarPersonalToolStripMenuItem
        ' 
        RegistrarPersonalToolStripMenuItem.Name = "RegistrarPersonalToolStripMenuItem"
        RegistrarPersonalToolStripMenuItem.Size = New Size(113, 20)
        RegistrarPersonalToolStripMenuItem.Text = "Registrar Personal"
        ' 
        ' RegistrarDonacionesToolStripMenuItem
        ' 
        RegistrarDonacionesToolStripMenuItem.Name = "RegistrarDonacionesToolStripMenuItem"
        RegistrarDonacionesToolStripMenuItem.Size = New Size(130, 20)
        RegistrarDonacionesToolStripMenuItem.Text = "Registrar Donaciones"
        ' 
        ' ListaDeDonantesToolStripMenuItem
        ' 
        ListaDeDonantesToolStripMenuItem.Name = "ListaDeDonantesToolStripMenuItem"
        ListaDeDonantesToolStripMenuItem.Size = New Size(112, 20)
        ListaDeDonantesToolStripMenuItem.Text = "Lista de Donantes"
        ' 
        ' BuscarDonantesToolStripMenuItem
        ' 
        BuscarDonantesToolStripMenuItem.Name = "BuscarDonantesToolStripMenuItem"
        BuscarDonantesToolStripMenuItem.Size = New Size(107, 20)
        BuscarDonantesToolStripMenuItem.Text = "Buscar Donantes"
        ' 
        ' AyudaToolStripMenuItem
        ' 
        AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        AyudaToolStripMenuItem.Size = New Size(53, 20)
        AyudaToolStripMenuItem.Text = "Ayuda"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegistrarCampañasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarPersonalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarDonacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeDonantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarDonantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
End Class
