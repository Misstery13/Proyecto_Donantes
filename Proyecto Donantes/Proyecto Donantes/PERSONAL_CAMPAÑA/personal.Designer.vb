<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class personal
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
        GroupBox1 = New GroupBox()
        btn_cancelar = New Button()
        btn_nuevo = New Button()
        dgv_personal = New DataGridView()
        Cedula = New DataGridViewTextBoxColumn()
        Apellidos_Nombres = New DataGridViewTextBoxColumn()
        Fecha_Nacimiento = New DataGridViewTextBoxColumn()
        Direccion = New DataGridViewTextBoxColumn()
        Telefono = New DataGridViewTextBoxColumn()
        Correo_Electronico = New DataGridViewTextBoxColumn()
        GroupBox3 = New GroupBox()
        txt_buscar = New TextBox()
        GroupBox1.SuspendLayout()
        CType(dgv_personal, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btn_cancelar)
        GroupBox1.Controls.Add(btn_nuevo)
        GroupBox1.Location = New Point(48, 318)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(715, 82)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        ' 
        ' btn_cancelar
        ' 
        btn_cancelar.Location = New Point(432, 22)
        btn_cancelar.Name = "btn_cancelar"
        btn_cancelar.Size = New Size(108, 38)
        btn_cancelar.TabIndex = 1
        btn_cancelar.Text = "Cancelar"
        btn_cancelar.UseVisualStyleBackColor = True
        ' 
        ' btn_nuevo
        ' 
        btn_nuevo.Location = New Point(193, 22)
        btn_nuevo.Name = "btn_nuevo"
        btn_nuevo.Size = New Size(99, 38)
        btn_nuevo.TabIndex = 0
        btn_nuevo.Text = "Nuevo"
        btn_nuevo.UseVisualStyleBackColor = True
        ' 
        ' dgv_personal
        ' 
        dgv_personal.AllowUserToAddRows = False
        dgv_personal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_personal.Columns.AddRange(New DataGridViewColumn() {Cedula, Apellidos_Nombres, Fecha_Nacimiento, Direccion, Telefono, Correo_Electronico})
        dgv_personal.Location = New Point(11, 122)
        dgv_personal.Name = "dgv_personal"
        dgv_personal.ReadOnly = True
        dgv_personal.RowTemplate.Height = 25
        dgv_personal.Size = New Size(770, 190)
        dgv_personal.TabIndex = 2
        ' 
        ' Cedula
        ' 
        Cedula.HeaderText = "CEDULA"
        Cedula.Name = "Cedula"
        Cedula.ReadOnly = True
        ' 
        ' Apellidos_Nombres
        ' 
        Apellidos_Nombres.HeaderText = "APELLIDOS NOMBRES"
        Apellidos_Nombres.Name = "Apellidos_Nombres"
        Apellidos_Nombres.ReadOnly = True
        ' 
        ' Fecha_Nacimiento
        ' 
        Fecha_Nacimiento.HeaderText = "FECHA NACIMIENTO"
        Fecha_Nacimiento.Name = "Fecha_Nacimiento"
        Fecha_Nacimiento.ReadOnly = True
        ' 
        ' Direccion
        ' 
        Direccion.HeaderText = "DIRECCION"
        Direccion.Name = "Direccion"
        Direccion.ReadOnly = True
        Direccion.Width = 147
        ' 
        ' Telefono
        ' 
        Telefono.HeaderText = "TELEFONO"
        Telefono.Name = "Telefono"
        Telefono.ReadOnly = True
        ' 
        ' Correo_Electronico
        ' 
        Correo_Electronico.HeaderText = "CORREO ELECTRONICO"
        Correo_Electronico.Name = "Correo_Electronico"
        Correo_Electronico.ReadOnly = True
        Correo_Electronico.Width = 180
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txt_buscar)
        GroupBox3.Location = New Point(215, 40)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(363, 75)
        GroupBox3.TabIndex = 31
        GroupBox3.TabStop = False
        GroupBox3.Text = "Buscar por Nombre"
        ' 
        ' txt_buscar
        ' 
        txt_buscar.Location = New Point(42, 33)
        txt_buscar.Name = "txt_buscar"
        txt_buscar.Size = New Size(278, 23)
        txt_buscar.TabIndex = 2
        ' 
        ' personal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(793, 433)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Controls.Add(dgv_personal)
        Name = "personal"
        Text = "personal"
        GroupBox1.ResumeLayout(False)
        CType(dgv_personal, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents dgv_personal As DataGridView
    Friend WithEvents Cedula As DataGridViewTextBoxColumn
    Friend WithEvents Apellidos_Nombres As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Nacimiento As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Correo_Electronico As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_buscar As TextBox
End Class
