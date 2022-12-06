<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HojadeIngreso
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
        Dim cbxTipoSangre As System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxEstado = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rbtnSi = New System.Windows.Forms.RadioButton()
        Me.rbtnNo = New System.Windows.Forms.RadioButton()
        Me.lblNumHijos = New System.Windows.Forms.Label()
        Me.txtNumHijos = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        cbxTipoSangre = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxTipoSangre
        '
        cbxTipoSangre.FormattingEnabled = True
        cbxTipoSangre.Items.AddRange(New Object() {"A", "AB", "B", "O"})
        cbxTipoSangre.Location = New System.Drawing.Point(601, 237)
        cbxTipoSangre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        cbxTipoSangre.Name = "cbxTipoSangre"
        cbxTipoSangre.Size = New System.Drawing.Size(82, 28)
        cbxTipoSangre.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(cbxTipoSangre)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbxEstado)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 68)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(800, 305)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(545, 175)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(138, 27)
        Me.txtTelefono.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(432, 175)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 25)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Telefono:"
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(161, 235)
        Me.txtEdad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(71, 27)
        Me.txtEdad.TabIndex = 35
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(545, 119)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(138, 27)
        Me.txtCorreo.TabIndex = 34
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(161, 172)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(141, 27)
        Me.txtApellido.TabIndex = 33
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(161, 119)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(141, 27)
        Me.txtNombre.TabIndex = 32
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(161, 56)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(141, 27)
        Me.txtCedula.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(432, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(162, 25)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Tipo de Sangre:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(51, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 25)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Edad:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(432, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 25)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Correo:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(432, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Estado civil:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(51, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 25)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Apellido:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(51, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 25)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(51, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 25)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Cedula:"
        '
        'cbxEstado
        '
        Me.cbxEstado.FormattingEnabled = True
        Me.cbxEstado.Items.AddRange(New Object() {"Unido(a)", "Soltero(a)", "Casado(a)", "Divorciado(a)", "Separado(a)", "Viudo(a)"})
        Me.cbxEstado.Location = New System.Drawing.Point(563, 59)
        Me.cbxEstado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.Size = New System.Drawing.Size(138, 28)
        Me.cbxEstado.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(374, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 27)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Hoja de Ingreso"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(109, 421)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 25)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "¿Tiene hijos?"
        '
        'rbtnSi
        '
        Me.rbtnSi.AutoSize = True
        Me.rbtnSi.Location = New System.Drawing.Point(321, 421)
        Me.rbtnSi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbtnSi.Name = "rbtnSi"
        Me.rbtnSi.Size = New System.Drawing.Size(42, 24)
        Me.rbtnSi.TabIndex = 31
        Me.rbtnSi.Text = "Si"
        Me.rbtnSi.UseVisualStyleBackColor = True
        '
        'rbtnNo
        '
        Me.rbtnNo.AutoSize = True
        Me.rbtnNo.Checked = True
        Me.rbtnNo.Location = New System.Drawing.Point(255, 421)
        Me.rbtnNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbtnNo.Name = "rbtnNo"
        Me.rbtnNo.Size = New System.Drawing.Size(50, 24)
        Me.rbtnNo.TabIndex = 32
        Me.rbtnNo.TabStop = True
        Me.rbtnNo.Text = "No"
        Me.rbtnNo.UseVisualStyleBackColor = True
        '
        'lblNumHijos
        '
        Me.lblNumHijos.Enabled = False
        Me.lblNumHijos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNumHijos.ForeColor = System.Drawing.Color.Black
        Me.lblNumHijos.Location = New System.Drawing.Point(109, 480)
        Me.lblNumHijos.Name = "lblNumHijos"
        Me.lblNumHijos.Size = New System.Drawing.Size(139, 25)
        Me.lblNumHijos.TabIndex = 33
        Me.lblNumHijos.Text = "Cuantos hijos tiene?"
        '
        'txtNumHijos
        '
        Me.txtNumHijos.Enabled = False
        Me.txtNumHijos.Location = New System.Drawing.Point(255, 477)
        Me.txtNumHijos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNumHijos.Name = "txtNumHijos"
        Me.txtNumHijos.Size = New System.Drawing.Size(79, 27)
        Me.txtNumHijos.TabIndex = 36
        Me.txtNumHijos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(550, 403)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(167, 25)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Observaciones:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(494, 432)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(267, 84)
        Me.txtObservaciones.TabIndex = 38
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(410, 579)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 31)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(502, 579)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 31)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Siguiente"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'HojadeIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 655)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtNumHijos)
        Me.Controls.Add(Me.lblNumHijos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rbtnNo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rbtnSi)
        Me.Controls.Add(Me.Label8)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "HojadeIngreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hoja de Ingreso"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbxEstado As ComboBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents cbxTipoSangre As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents rbtnSi As RadioButton
    Friend WithEvents rbtnNo As RadioButton
    Friend WithEvents lblNumHijos As Label
    Friend WithEvents txtNumHijos As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
