<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class campaña
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
        dgv_campañas = New DataGridView()
        ID_Campaña = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        Lugar = New DataGridViewTextBoxColumn()
        Fecha = New DataGridViewTextBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        GroupBox1 = New GroupBox()
        btn_cancelar = New Button()
        btn_nuevo = New Button()
        txt_buscar = New TextBox()
        GroupBox2 = New GroupBox()
        CType(dgv_campañas, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgv_campañas
        ' 
        dgv_campañas.AllowUserToAddRows = False
        dgv_campañas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_campañas.Columns.AddRange(New DataGridViewColumn() {ID_Campaña, Nombre, Lugar, Fecha, Estado})
        dgv_campañas.Location = New Point(57, 128)
        dgv_campañas.Name = "dgv_campañas"
        dgv_campañas.ReadOnly = True
        dgv_campañas.RowTemplate.Height = 25
        dgv_campañas.Size = New Size(541, 190)
        dgv_campañas.TabIndex = 0
        ' 
        ' ID_Campaña
        ' 
        ID_Campaña.HeaderText = "ID"
        ID_Campaña.Name = "ID_Campaña"
        ID_Campaña.ReadOnly = True
        ID_Campaña.Width = 50
        ' 
        ' Nombre
        ' 
        Nombre.HeaderText = "NOMBRE"
        Nombre.Name = "Nombre"
        Nombre.ReadOnly = True
        ' 
        ' Lugar
        ' 
        Lugar.HeaderText = "LUGAR"
        Lugar.Name = "Lugar"
        Lugar.ReadOnly = True
        ' 
        ' Fecha
        ' 
        Fecha.HeaderText = "FECHA YYYY-MM-DD"
        Fecha.Name = "Fecha"
        Fecha.ReadOnly = True
        Fecha.Width = 147
        ' 
        ' Estado
        ' 
        Estado.HeaderText = "ESTADO"
        Estado.Name = "Estado"
        Estado.ReadOnly = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btn_cancelar)
        GroupBox1.Controls.Add(btn_nuevo)
        GroupBox1.Location = New Point(12, 338)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(639, 100)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' btn_cancelar
        ' 
        btn_cancelar.Location = New Point(329, 34)
        btn_cancelar.Name = "btn_cancelar"
        btn_cancelar.Size = New Size(108, 38)
        btn_cancelar.TabIndex = 1
        btn_cancelar.Text = "Cancelar"
        btn_cancelar.UseVisualStyleBackColor = True
        ' 
        ' btn_nuevo
        ' 
        btn_nuevo.Location = New Point(139, 34)
        btn_nuevo.Name = "btn_nuevo"
        btn_nuevo.Size = New Size(99, 38)
        btn_nuevo.TabIndex = 0
        btn_nuevo.Text = "Nuevo"
        btn_nuevo.UseVisualStyleBackColor = True
        ' 
        ' txt_buscar
        ' 
        txt_buscar.Location = New Point(39, 42)
        txt_buscar.Name = "txt_buscar"
        txt_buscar.Size = New Size(278, 23)
        txt_buscar.TabIndex = 2
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txt_buscar)
        GroupBox2.Location = New Point(132, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(363, 100)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Buscar por Nombre"
        ' 
        ' campaña
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(664, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(dgv_campañas)
        Name = "campaña"
        Text = "campaña"
        CType(dgv_campañas, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgv_campañas As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ID_Campaña As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Lugar As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
End Class
