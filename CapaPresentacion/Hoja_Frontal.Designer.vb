<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hoja_Frontal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.txtDiagnosticoIn = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.dtpHoraEgreso = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LblCedula = New System.Windows.Forms.Label()
        Me.txtPrevision = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNhijos = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPerfilapellido = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPerfilNombre = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(646, 7)
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
        Me.Label5.Location = New System.Drawing.Point(435, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 19)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "No. Cama"
        '
        'cbxUnidad
        '
        Me.cbxUnidad.FormattingEnabled = True
        Me.cbxUnidad.Items.AddRange(New Object() {"Unidad de Hematología/Oncología e Inmunología", "Unidad Quirúrgica/Ortopédica Pediátrica", "Unidad de Psiquiatría", "Unidad de Neurología y Neurocirugía", "Unidad de Nefrología/Gastroenterología/Endocrinología", "Unidad Respiratoria", "Unidad Quirúrgica Médica Cardíaca", "Unidad de Cuidado Infantil", "Unidad de Cuidados Intensivos"})
        Me.cbxUnidad.Location = New System.Drawing.Point(17, 51)
        Me.cbxUnidad.Name = "cbxUnidad"
        Me.cbxUnidad.Size = New System.Drawing.Size(399, 23)
        Me.cbxUnidad.TabIndex = 27
        '
        'txtCama
        '
        Me.txtCama.Location = New System.Drawing.Point(438, 51)
        Me.txtCama.Name = "txtCama"
        Me.txtCama.Size = New System.Drawing.Size(98, 21)
        Me.txtCama.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(627, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 19)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Género:"
        '
        'rbtnMasculino
        '
        Me.rbtnMasculino.AutoSize = True
        Me.rbtnMasculino.Location = New System.Drawing.Point(630, 112)
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
        Me.rbtnFemenino.Location = New System.Drawing.Point(673, 112)
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
        Me.Label10.Location = New System.Drawing.Point(438, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 19)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Factor Rh:"
        '
        'cbxFactorRH
        '
        Me.cbxFactorRH.FormattingEnabled = True
        Me.cbxFactorRH.Items.AddRange(New Object() {"Positivo", "Negativo"})
        Me.cbxFactorRH.Location = New System.Drawing.Point(438, 112)
        Me.cbxFactorRH.Name = "cbxFactorRH"
        Me.cbxFactorRH.Size = New System.Drawing.Size(121, 23)
        Me.cbxFactorRH.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(233, 17)
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
        Me.Label11.Size = New System.Drawing.Size(228, 19)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Fecha de ingreso:"
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(42, 40)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(147, 21)
        Me.dtpFechaIngreso.TabIndex = 43
        '
        'dtpHoraIngreso
        '
        Me.dtpHoraIngreso.CustomFormat = "hh:mm tt"
        Me.dtpHoraIngreso.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpHoraIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraIngreso.Location = New System.Drawing.Point(242, 40)
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
        Me.Label12.Size = New System.Drawing.Size(188, 19)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Fecha de egreso:"
        '
        'dtpFechaEgreso
        '
        Me.dtpFechaEgreso.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaEgreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaEgreso.Location = New System.Drawing.Point(42, 91)
        Me.dtpFechaEgreso.Name = "dtpFechaEgreso"
        Me.dtpFechaEgreso.Size = New System.Drawing.Size(147, 21)
        Me.dtpFechaEgreso.TabIndex = 46
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(233, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(193, 19)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Hora de egreso:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(17, 118)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(325, 21)
        Me.txtDireccion.TabIndex = 50
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(17, 88)
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
        'txtDiagnosticoIn
        '
        Me.txtDiagnosticoIn.Location = New System.Drawing.Point(17, 52)
        Me.txtDiagnosticoIn.Multiline = True
        Me.txtDiagnosticoIn.Name = "txtDiagnosticoIn"
        Me.txtDiagnosticoIn.Size = New System.Drawing.Size(310, 96)
        Me.txtDiagnosticoIn.TabIndex = 57
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(696, 530)
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
        Me.dtpHoraEgreso.Location = New System.Drawing.Point(248, 91)
        Me.dtpHoraEgreso.Name = "dtpHoraEgreso"
        Me.dtpHoraEgreso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpHoraEgreso.Size = New System.Drawing.Size(100, 21)
        Me.dtpHoraEgreso.TabIndex = 60
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(776, 530)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Siguiente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtDiagnosticoIn)
        Me.GroupBox1.Location = New System.Drawing.Point(361, 341)
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
        Me.GroupBox2.Location = New System.Drawing.Point(357, 206)
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
        Me.GroupBox3.Location = New System.Drawing.Point(357, 52)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(750, 150)
        Me.GroupBox3.TabIndex = 65
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LblCedula)
        Me.GroupBox4.Controls.Add(Me.txtPrevision)
        Me.GroupBox4.Controls.Add(Me.txtEstado)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtNhijos)
        Me.GroupBox4.Controls.Add(Me.txtEdad)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.txtPerfilapellido)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.txtPerfilNombre)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.txtTelefono)
        Me.GroupBox4.Controls.Add(Me.txtCorreo)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 43)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(319, 425)
        Me.GroupBox4.TabIndex = 66
        Me.GroupBox4.TabStop = False
        '
        'LblCedula
        '
        Me.LblCedula.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblCedula.ForeColor = System.Drawing.Color.Black
        Me.LblCedula.Location = New System.Drawing.Point(94, 110)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(82, 19)
        Me.LblCedula.TabIndex = 32
        Me.LblCedula.Text = "0-000-0000"
        '
        'txtPrevision
        '
        Me.txtPrevision.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrevision.Location = New System.Drawing.Point(106, 392)
        Me.txtPrevision.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrevision.Name = "txtPrevision"
        Me.txtPrevision.Size = New System.Drawing.Size(197, 14)
        Me.txtPrevision.TabIndex = 31
        '
        'txtEstado
        '
        Me.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEstado.Location = New System.Drawing.Point(106, 358)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(197, 14)
        Me.txtEstado.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 19)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Estado Civil:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(8, 392)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 19)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Prevision: "
        '
        'txtNhijos
        '
        Me.txtNhijos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNhijos.Location = New System.Drawing.Point(106, 323)
        Me.txtNhijos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNhijos.Name = "txtNhijos"
        Me.txtNhijos.Size = New System.Drawing.Size(197, 14)
        Me.txtNhijos.TabIndex = 27
        '
        'txtEdad
        '
        Me.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEdad.Location = New System.Drawing.Point(106, 289)
        Me.txtEdad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(197, 14)
        Me.txtEdad.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(15, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 19)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Edad:"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(8, 323)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 19)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "N° Hijos: "
        '
        'txtPerfilapellido
        '
        Me.txtPerfilapellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPerfilapellido.Location = New System.Drawing.Point(106, 185)
        Me.txtPerfilapellido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPerfilapellido.Name = "txtPerfilapellido"
        Me.txtPerfilapellido.Size = New System.Drawing.Size(197, 14)
        Me.txtPerfilapellido.TabIndex = 23
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(11, 185)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 19)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Apellido: "
        '
        'txtPerfilNombre
        '
        Me.txtPerfilNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPerfilNombre.Location = New System.Drawing.Point(106, 149)
        Me.txtPerfilNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPerfilNombre.Name = "txtPerfilNombre"
        Me.txtPerfilNombre.Size = New System.Drawing.Size(197, 14)
        Me.txtPerfilNombre.TabIndex = 21
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(15, 153)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 19)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Nombre: "
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTelefono.Location = New System.Drawing.Point(106, 254)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(197, 14)
        Me.txtTelefono.TabIndex = 19
        '
        'txtCorreo
        '
        Me.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCorreo.Location = New System.Drawing.Point(106, 220)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(197, 14)
        Me.txtCorreo.TabIndex = 18
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(15, 220)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 19)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "Correo:"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(8, 254)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(86, 19)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "Telefono: "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.CapaPresentacion.My.Resources.Resources.clientes
        Me.PictureBox1.Location = New System.Drawing.Point(40, 8)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Hoja_Frontal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 562)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Hoja_Frontal"
        Me.Text = "Hoja_Frontal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtDiagnosticoIn As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents dtpHoraEgreso As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents LblCedula As Label
    Friend WithEvents txtPrevision As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNhijos As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtPerfilapellido As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtPerfilNombre As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
