﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_personal
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
        txt_user = New TextBox()
        Label2 = New Label()
        CLAVE = New Label()
        txt_clave = New TextBox()
        txt_IDpersonal = New TextBox()
        txt_id = New Label()
        btn_cancelr = New Button()
        btn_grabar = New Button()
        cbo_campaña = New ComboBox()
        txt_telefono = New TextBox()
        Label6 = New Label()
        txt_cedula = New TextBox()
        Label7 = New Label()
        txt_nombres = New TextBox()
        Label1 = New Label()
        Label8 = New Label()
        txt_fechanac = New TextBox()
        Label9 = New Label()
        txt_direccion = New TextBox()
        txt_correo = New TextBox()
        Label10 = New Label()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txt_user)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(CLAVE)
        GroupBox2.Controls.Add(txt_clave)
        GroupBox2.Controls.Add(txt_IDpersonal)
        GroupBox2.Controls.Add(txt_id)
        GroupBox2.Controls.Add(btn_cancelr)
        GroupBox2.Controls.Add(btn_grabar)
        GroupBox2.Controls.Add(cbo_campaña)
        GroupBox2.Controls.Add(txt_telefono)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(txt_cedula)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(txt_nombres)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(txt_fechanac)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(txt_direccion)
        GroupBox2.Controls.Add(txt_correo)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Location = New Point(94, 40)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(612, 398)
        GroupBox2.TabIndex = 31
        GroupBox2.TabStop = False
        GroupBox2.Text = "Registro de Personal"
        ' 
        ' txt_user
        ' 
        txt_user.Location = New Point(234, 246)
        txt_user.Name = "txt_user"
        txt_user.Size = New Size(167, 23)
        txt_user.TabIndex = 37
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(234, 228)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 38
        Label2.Text = "USUARIO"
        ' 
        ' CLAVE
        ' 
        CLAVE.AutoSize = True
        CLAVE.Location = New Point(234, 285)
        CLAVE.Name = "CLAVE"
        CLAVE.Size = New Size(41, 15)
        CLAVE.TabIndex = 36
        CLAVE.Text = "CLAVE"
        ' 
        ' txt_clave
        ' 
        txt_clave.Location = New Point(234, 301)
        txt_clave.Name = "txt_clave"
        txt_clave.Size = New Size(167, 23)
        txt_clave.TabIndex = 35
        ' 
        ' txt_IDpersonal
        ' 
        txt_IDpersonal.Location = New Point(29, 133)
        txt_IDpersonal.Name = "txt_IDpersonal"
        txt_IDpersonal.Size = New Size(167, 23)
        txt_IDpersonal.TabIndex = 33
        ' 
        ' txt_id
        ' 
        txt_id.AutoSize = True
        txt_id.Location = New Point(29, 115)
        txt_id.Name = "txt_id"
        txt_id.Size = New Size(18, 15)
        txt_id.TabIndex = 34
        txt_id.Text = "ID"
        ' 
        ' btn_cancelr
        ' 
        btn_cancelr.Location = New Point(494, 213)
        btn_cancelr.Name = "btn_cancelr"
        btn_cancelr.Size = New Size(75, 40)
        btn_cancelr.TabIndex = 32
        btn_cancelr.Text = "Cancelar"
        btn_cancelr.UseVisualStyleBackColor = True
        ' 
        ' btn_grabar
        ' 
        btn_grabar.Location = New Point(494, 133)
        btn_grabar.Name = "btn_grabar"
        btn_grabar.Size = New Size(75, 40)
        btn_grabar.TabIndex = 31
        btn_grabar.Text = "Grabar"
        btn_grabar.UseVisualStyleBackColor = True
        ' 
        ' cbo_campaña
        ' 
        cbo_campaña.FormattingEnabled = True
        cbo_campaña.Location = New Point(29, 65)
        cbo_campaña.Name = "cbo_campaña"
        cbo_campaña.Size = New Size(167, 23)
        cbo_campaña.TabIndex = 30
        ' 
        ' txt_telefono
        ' 
        txt_telefono.Location = New Point(234, 133)
        txt_telefono.Name = "txt_telefono"
        txt_telefono.Size = New Size(167, 23)
        txt_telefono.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(234, 115)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 15)
        Label6.TabIndex = 29
        Label6.Text = "TELEFONO"
        ' 
        ' txt_cedula
        ' 
        txt_cedula.Location = New Point(29, 190)
        txt_cedula.Name = "txt_cedula"
        txt_cedula.Size = New Size(167, 23)
        txt_cedula.TabIndex = 20
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(29, 338)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 15)
        Label7.TabIndex = 28
        Label7.Text = "DIRECCION"
        ' 
        ' txt_nombres
        ' 
        txt_nombres.Location = New Point(29, 246)
        txt_nombres.Name = "txt_nombres"
        txt_nombres.Size = New Size(167, 23)
        txt_nombres.TabIndex = 21
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(234, 172)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 15)
        Label1.TabIndex = 15
        Label1.Text = "CORREO ELECTRONICO"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(29, 283)
        Label8.Name = "Label8"
        Label8.Size = New Size(135, 15)
        Label8.TabIndex = 27
        Label8.Text = "FECHA DE NACIMIENTO"
        ' 
        ' txt_fechanac
        ' 
        txt_fechanac.Location = New Point(29, 301)
        txt_fechanac.Name = "txt_fechanac"
        txt_fechanac.Size = New Size(167, 23)
        txt_fechanac.TabIndex = 22
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(29, 228)
        Label9.Name = "Label9"
        Label9.Size = New Size(124, 15)
        Label9.TabIndex = 26
        Label9.Text = "APELLIDOS NOMBRES"
        ' 
        ' txt_direccion
        ' 
        txt_direccion.Location = New Point(29, 356)
        txt_direccion.Name = "txt_direccion"
        txt_direccion.Size = New Size(167, 23)
        txt_direccion.TabIndex = 23
        ' 
        ' txt_correo
        ' 
        txt_correo.Location = New Point(234, 190)
        txt_correo.Name = "txt_correo"
        txt_correo.Size = New Size(167, 23)
        txt_correo.TabIndex = 10
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(29, 172)
        Label10.Name = "Label10"
        Label10.Size = New Size(51, 15)
        Label10.TabIndex = 25
        Label10.Text = "CEDULA"
        ' 
        ' frm_personal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Name = "frm_personal"
        Text = "frm_personal"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_cancelr As Button
    Friend WithEvents btn_grabar As Button
    Friend WithEvents cbo_campaña As ComboBox
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_nombres As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_fechanac As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CLAVE As Label
    Friend WithEvents txt_clave As TextBox
    Friend WithEvents txt_IDpersonal As TextBox
    Friend WithEvents txt_id As Label
End Class
