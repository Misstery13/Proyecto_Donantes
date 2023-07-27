<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_campaña
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
        txt_id = New TextBox()
        txt_nombre = New TextBox()
        txt_lugar = New TextBox()
        txt_fecha = New TextBox()
        txt_estado = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        GroupBox1 = New GroupBox()
        btn_cancelar = New Button()
        btn_grabar = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txt_id
        ' 
        txt_id.Location = New Point(85, 47)
        txt_id.Name = "txt_id"
        txt_id.Size = New Size(167, 23)
        txt_id.TabIndex = 0
        ' 
        ' txt_nombre
        ' 
        txt_nombre.Location = New Point(85, 103)
        txt_nombre.Name = "txt_nombre"
        txt_nombre.Size = New Size(167, 23)
        txt_nombre.TabIndex = 1
        ' 
        ' txt_lugar
        ' 
        txt_lugar.Location = New Point(85, 158)
        txt_lugar.Name = "txt_lugar"
        txt_lugar.Size = New Size(167, 23)
        txt_lugar.TabIndex = 2
        ' 
        ' txt_fecha
        ' 
        txt_fecha.Location = New Point(85, 219)
        txt_fecha.Name = "txt_fecha"
        txt_fecha.Size = New Size(167, 23)
        txt_fecha.TabIndex = 3
        ' 
        ' txt_estado
        ' 
        txt_estado.Location = New Point(85, 281)
        txt_estado.Name = "txt_estado"
        txt_estado.Size = New Size(167, 23)
        txt_estado.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(85, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(18, 15)
        Label1.TabIndex = 5
        Label1.Text = "ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(85, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 6
        Label2.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(85, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 15)
        Label3.TabIndex = 7
        Label3.Text = "Lugar"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(85, 201)
        Label4.Name = "Label4"
        Label4.Size = New Size(38, 15)
        Label4.TabIndex = 8
        Label4.Text = "Fecha"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(85, 263)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 15)
        Label5.TabIndex = 9
        Label5.Text = "Estado"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btn_cancelar)
        GroupBox1.Controls.Add(btn_grabar)
        GroupBox1.Location = New Point(12, 323)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(323, 94)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        ' 
        ' btn_cancelar
        ' 
        btn_cancelar.Location = New Point(186, 31)
        btn_cancelar.Name = "btn_cancelar"
        btn_cancelar.Size = New Size(75, 40)
        btn_cancelar.TabIndex = 1
        btn_cancelar.Text = "Cancelar"
        btn_cancelar.UseVisualStyleBackColor = True
        ' 
        ' btn_grabar
        ' 
        btn_grabar.Location = New Point(49, 31)
        btn_grabar.Name = "btn_grabar"
        btn_grabar.Size = New Size(75, 40)
        btn_grabar.TabIndex = 0
        btn_grabar.Text = "Grabar"
        btn_grabar.UseVisualStyleBackColor = True
        ' 
        ' frm_campaña
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(347, 429)
        Controls.Add(GroupBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txt_estado)
        Controls.Add(txt_fecha)
        Controls.Add(txt_lugar)
        Controls.Add(txt_nombre)
        Controls.Add(txt_id)
        Name = "frm_campaña"
        Text = "frm_campaña"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_lugar As TextBox
    Friend WithEvents txt_fecha As TextBox
    Friend WithEvents txt_estado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_grabar As Button
End Class
