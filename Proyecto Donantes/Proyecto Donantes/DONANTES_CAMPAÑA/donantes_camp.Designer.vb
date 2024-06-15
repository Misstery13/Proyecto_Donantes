<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class donantes_camp
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GroupBox2 = New GroupBox()
        txt_buscar = New TextBox()
        dgv_donanCamp = New DataGridView()
        Cedula = New DataGridViewTextBoxColumn()
        Apellidos_Nombres = New DataGridViewTextBoxColumn()
        Tipo_Sangre = New DataGridViewTextBoxColumn()
        Fecha_Donacion = New DataGridViewTextBoxColumn()
        NombreCampaña = New DataGridViewTextBoxColumn()
        GroupBox2.SuspendLayout()
        CType(dgv_donanCamp, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txt_buscar)
        GroupBox2.Location = New Point(182, 24)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(363, 100)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Buscar por Nombre de Campaña"
        ' 
        ' txt_buscar
        ' 
        txt_buscar.Location = New Point(39, 42)
        txt_buscar.Name = "txt_buscar"
        txt_buscar.Size = New Size(278, 23)
        txt_buscar.TabIndex = 2
        ' 
        ' dgv_donanCamp
        ' 
        dgv_donanCamp.AllowUserToAddRows = False
        dgv_donanCamp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_donanCamp.Columns.AddRange(New DataGridViewColumn() {Cedula, Apellidos_Nombres, Tipo_Sangre, Fecha_Donacion, NombreCampaña})
        dgv_donanCamp.Location = New Point(12, 147)
        dgv_donanCamp.Name = "dgv_donanCamp"
        dgv_donanCamp.ReadOnly = True
        dgv_donanCamp.RowTemplate.Height = 25
        dgv_donanCamp.Size = New Size(701, 190)
        dgv_donanCamp.TabIndex = 4
        ' 
        ' Cedula
        ' 
        Cedula.HeaderText = "CEDULA"
        Cedula.Name = "Cedula"
        Cedula.ReadOnly = True
        Cedula.Width = 120
        ' 
        ' Apellidos_Nombres
        ' 
        Apellidos_Nombres.HeaderText = "NOMBRES"
        Apellidos_Nombres.Name = "Apellidos_Nombres"
        Apellidos_Nombres.ReadOnly = True
        Apellidos_Nombres.Width = 150
        ' 
        ' Tipo_Sangre
        ' 
        Tipo_Sangre.HeaderText = "TIPO DE SANGRE"
        Tipo_Sangre.Name = "Tipo_Sangre"
        Tipo_Sangre.ReadOnly = True
        ' 
        ' Fecha_Donacion
        ' 
        Fecha_Donacion.HeaderText = "FECHA DONACION"
        Fecha_Donacion.Name = "Fecha_Donacion"
        Fecha_Donacion.ReadOnly = True
        Fecha_Donacion.Width = 147
        ' 
        ' NombreCampaña
        ' 
        NombreCampaña.HeaderText = "NOMBRE DE CAMPAÑA"
        NombreCampaña.Name = "NombreCampaña"
        NombreCampaña.ReadOnly = True
        NombreCampaña.Width = 140
        ' 
        ' donantes_camp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(726, 360)
        Controls.Add(GroupBox2)
        Controls.Add(dgv_donanCamp)
        Name = "donantes_camp"
        Text = "donantes_camp"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(dgv_donanCamp, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents dgv_donanCamp As DataGridView
    Friend WithEvents Cedula As DataGridViewTextBoxColumn
    Friend WithEvents Apellidos_Nombres As DataGridViewTextBoxColumn
    Friend WithEvents Tipo_Sangre As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Donacion As DataGridViewTextBoxColumn
    Friend WithEvents NombreCampaña As DataGridViewTextBoxColumn
End Class
