<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_acceso
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frm_acceso))
        txt_usuario = New TextBox()
        txt_clave = New TextBox()
        btn_aceptar = New Button()
        btn_cancelar = New Button()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_usuario
        ' 
        txt_usuario.Location = New Point(290, 44)
        txt_usuario.Name = "txt_usuario"
        txt_usuario.Size = New Size(238, 23)
        txt_usuario.TabIndex = 0
        ' 
        ' txt_clave
        ' 
        txt_clave.Location = New Point(290, 121)
        txt_clave.Name = "txt_clave"
        txt_clave.Size = New Size(238, 23)
        txt_clave.TabIndex = 1
        ' 
        ' btn_aceptar
        ' 
        btn_aceptar.Location = New Point(260, 32)
        btn_aceptar.Name = "btn_aceptar"
        btn_aceptar.Size = New Size(75, 41)
        btn_aceptar.TabIndex = 2
        btn_aceptar.Text = "Aceptar"
        btn_aceptar.UseVisualStyleBackColor = True
        ' 
        ' btn_cancelar
        ' 
        btn_cancelar.Location = New Point(422, 32)
        btn_cancelar.Name = "btn_cancelar"
        btn_cancelar.Size = New Size(75, 41)
        btn_cancelar.TabIndex = 3
        btn_cancelar.Text = "Cancelar"
        btn_cancelar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.AppWorkspace
        GroupBox1.Controls.Add(btn_aceptar)
        GroupBox1.Controls.Add(btn_cancelar)
        GroupBox1.Location = New Point(25, 208)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(551, 91)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(290, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 17)
        Label1.TabIndex = 5
        Label1.Text = "Usuario:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(290, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 17)
        Label2.TabIndex = 6
        Label2.Text = "Clave:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ActiveCaption
        GroupBox2.Controls.Add(PictureBox1)
        GroupBox2.Controls.Add(txt_clave)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(txt_usuario)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Location = New Point(25, 26)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(551, 175)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(20, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(166, 137)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' frm_acceso
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(601, 311)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "frm_acceso"
        Text = "frm_acceso"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_clave As TextBox
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
