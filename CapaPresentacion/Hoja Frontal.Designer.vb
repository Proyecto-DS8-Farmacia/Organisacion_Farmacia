<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hoja_Frontal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxUnidad = New System.Windows.Forms.ComboBox()
        Me.txtCama = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rbtnMasculino = New System.Windows.Forms.RadioButton()
        Me.rbtnFemenino = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbxFactorRH = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpFechaEgreso = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDiagnosticoIn = New System.Windows.Forms.TextBox()
        Me.txtDiagnosticoEg = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.dtpHoraEgreso = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(340, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hoja Frontal"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(17, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 19)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Unidad medica:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(620, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 19)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "No. Cama"
        '
        'cbxUnidad
        '
        Me.cbxUnidad.FormattingEnabled = True
        Me.cbxUnidad.Location = New System.Drawing.Point(17, 44)
        Me.cbxUnidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxUnidad.Name = "cbxUnidad"
        Me.cbxUnidad.Size = New System.Drawing.Size(399, 23)
        Me.cbxUnidad.TabIndex = 27
        '
        'txtCama
        '
        Me.txtCama.Location = New System.Drawing.Point(623, 44)
        Me.txtCama.Name = "txtCama"
        Me.txtCama.Size = New System.Drawing.Size(98, 21)
        Me.txtCama.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(459, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 19)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Género:"
        '
        'rbtnMasculino
        '
        Me.rbtnMasculino.AutoSize = True
        Me.rbtnMasculino.Location = New System.Drawing.Point(462, 112)
        Me.rbtnMasculino.Name = "rbtnMasculino"
        Me.rbtnMasculino.Size = New System.Drawing.Size(34, 19)
        Me.rbtnMasculino.TabIndex = 37
        Me.rbtnMasculino.TabStop = True
        Me.rbtnMasculino.Text = "M"
        Me.rbtnMasculino.UseVisualStyleBackColor = True
        '
        'rbtnFemenino
        '
        Me.rbtnFemenino.AutoSize = True
        Me.rbtnFemenino.Location = New System.Drawing.Point(505, 112)
        Me.rbtnFemenino.Name = "rbtnFemenino"
        Me.rbtnFemenino.Size = New System.Drawing.Size(32, 19)
        Me.rbtnFemenino.TabIndex = 38
        Me.rbtnFemenino.TabStop = True
        Me.rbtnFemenino.Text = "F"
        Me.rbtnFemenino.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(459, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 19)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Factor Rh:"
        '
        'cbxFactorRH
        '
        Me.cbxFactorRH.FormattingEnabled = True
        Me.cbxFactorRH.Location = New System.Drawing.Point(459, 42)
        Me.cbxFactorRH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxFactorRH.Name = "cbxFactorRH"
        Me.cbxFactorRH.Size = New System.Drawing.Size(121, 23)
        Me.cbxFactorRH.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(267, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 19)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Hora de ingreso:"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(31, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(184, 19)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Fecha de ingreso:"
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(31, 40)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(147, 21)
        Me.dtpFechaIngreso.TabIndex = 43
        '
        'dtpHoraIngreso
        '
        Me.dtpHoraIngreso.CustomFormat = "hh:mm tt"
        Me.dtpHoraIngreso.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpHoraIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraIngreso.Location = New System.Drawing.Point(267, 41)
        Me.dtpHoraIngreso.Name = "dtpHoraIngreso"
        Me.dtpHoraIngreso.Size = New System.Drawing.Size(100, 21)
        Me.dtpHoraIngreso.TabIndex = 44
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(25, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(167, 19)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Fecha de egreso:"
        '
        'dtpFechaEgreso
        '
        Me.dtpFechaEgreso.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaEgreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaEgreso.Location = New System.Drawing.Point(31, 91)
        Me.dtpFechaEgreso.Name = "dtpFechaEgreso"
        Me.dtpFechaEgreso.Size = New System.Drawing.Size(147, 21)
        Me.dtpFechaEgreso.TabIndex = 46
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(267, 71)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(169, 19)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Hora de egreso:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(17, 112)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(325, 21)
        Me.txtDireccion.TabIndex = 50
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(17, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 19)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Dirección:"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(17, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(222, 19)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "Diagnóstico de ingreso:"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(383, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(222, 19)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "Diagnóstico de egreso:"
        '
        'txtDiagnosticoIn
        '
        Me.txtDiagnosticoIn.Location = New System.Drawing.Point(17, 52)
        Me.txtDiagnosticoIn.Multiline = True
        Me.txtDiagnosticoIn.Name = "txtDiagnosticoIn"
        Me.txtDiagnosticoIn.Size = New System.Drawing.Size(310, 96)
        Me.txtDiagnosticoIn.TabIndex = 57
        '
        'txtDiagnosticoEg
        '
        Me.txtDiagnosticoEg.Location = New System.Drawing.Point(392, 52)
        Me.txtDiagnosticoEg.Multiline = True
        Me.txtDiagnosticoEg.Name = "txtDiagnosticoEg"
        Me.txtDiagnosticoEg.Size = New System.Drawing.Size(337, 96)
        Me.txtDiagnosticoEg.TabIndex = 58
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(357, 527)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 59
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'dtpHoraEgreso
        '
        Me.dtpHoraEgreso.CustomFormat = "hh:mm tt"
        Me.dtpHoraEgreso.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpHoraEgreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraEgreso.Location = New System.Drawing.Point(267, 93)
        Me.dtpHoraEgreso.Name = "dtpHoraEgreso"
        Me.dtpHoraEgreso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpHoraEgreso.Size = New System.Drawing.Size(100, 21)
        Me.dtpHoraEgreso.TabIndex = 60
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(438, 527)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Siguiente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtDiagnosticoIn)
        Me.GroupBox1.Controls.Add(Me.txtDiagnosticoEg)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 341)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(746, 164)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.dtpFechaIngreso)
        Me.GroupBox2.Controls.Add(Me.dtpHoraEgreso)
        Me.GroupBox2.Controls.Add(Me.dtpHoraIngreso)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.dtpFechaEgreso)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(46, 206)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(750, 130)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbxUnidad)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtDireccion)
        Me.GroupBox3.Controls.Add(Me.txtCama)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.cbxFactorRH)
        Me.GroupBox3.Controls.Add(Me.rbtnMasculino)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.rbtnFemenino)
        Me.GroupBox3.Location = New System.Drawing.Point(46, 52)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(750, 150)
        Me.GroupBox3.TabIndex = 65
        Me.GroupBox3.TabStop = False
        '
        'Hoja_Frontal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 562)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Hoja_Frontal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hoja_Frontal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbxUnidad As ComboBox
    Friend WithEvents txtCama As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents rbtnMasculino As RadioButton
    Friend WithEvents rbtnFemenino As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents cbxFactorRH As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpFechaIngreso As DateTimePicker
    Friend WithEvents dtpHoraIngreso As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents dtpFechaEgreso As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtDiagnosticoIn As TextBox
    Friend WithEvents txtDiagnosticoEg As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents dtpHoraEgreso As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
