﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrarReceta
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
        Me.components = New System.ComponentModel.Container()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PanelMenuSmall = New System.Windows.Forms.Panel()
        Me.btnAdministrador = New System.Windows.Forms.Button()
        Me.btnInicioSesion = New System.Windows.Forms.Button()
        Me.btnPaciente = New System.Windows.Forms.Button()
        Me.btnFarmaceuta = New System.Windows.Forms.Button()
        Me.btnEncargado = New System.Windows.Forms.Button()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.tmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cbxFarmacia = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lvAgregados = New System.Windows.Forms.ListView()
        Me.id = New System.Windows.Forms.ColumnHeader()
        Me.nombre = New System.Windows.Forms.ColumnHeader()
        Me.cantidad = New System.Windows.Forms.ColumnHeader()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxSustancia = New System.Windows.Forms.ComboBox()
        Me.nudCant = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMedico = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.PanelMenu.SuspendLayout()
        Me.PanelMenuSmall.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.nudCant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.Transparent
        Me.PanelMenu.Controls.Add(Me.btnSalir)
        Me.PanelMenu.Controls.Add(Me.PanelMenuSmall)
        Me.PanelMenu.Controls.Add(Me.btnMenu)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 561)
        Me.PanelMenu.TabIndex = 18
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = Global.CapaPresentacion.My.Resources.Resources.logout1
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(3, 464)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(215, 58)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "    Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PanelMenuSmall
        '
        Me.PanelMenuSmall.BackColor = System.Drawing.Color.Transparent
        Me.PanelMenuSmall.Controls.Add(Me.btnAdministrador)
        Me.PanelMenuSmall.Controls.Add(Me.btnInicioSesion)
        Me.PanelMenuSmall.Controls.Add(Me.btnPaciente)
        Me.PanelMenuSmall.Controls.Add(Me.btnFarmaceuta)
        Me.PanelMenuSmall.Controls.Add(Me.btnEncargado)
        Me.PanelMenuSmall.Controls.Add(Me.btnPerfil)
        Me.PanelMenuSmall.Location = New System.Drawing.Point(3, 80)
        Me.PanelMenuSmall.Name = "PanelMenuSmall"
        Me.PanelMenuSmall.Size = New System.Drawing.Size(214, 378)
        Me.PanelMenuSmall.TabIndex = 1
        '
        'btnAdministrador
        '
        Me.btnAdministrador.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdministrador.FlatAppearance.BorderSize = 0
        Me.btnAdministrador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnAdministrador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdministrador.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAdministrador.ForeColor = System.Drawing.Color.White
        Me.btnAdministrador.Image = Global.CapaPresentacion.My.Resources.Resources.empleados
        Me.btnAdministrador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdministrador.Location = New System.Drawing.Point(-1, 320)
        Me.btnAdministrador.Name = "btnAdministrador"
        Me.btnAdministrador.Size = New System.Drawing.Size(215, 58)
        Me.btnAdministrador.TabIndex = 15
        Me.btnAdministrador.Text = "    Administrador"
        Me.btnAdministrador.UseVisualStyleBackColor = True
        '
        'btnInicioSesion
        '
        Me.btnInicioSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInicioSesion.FlatAppearance.BorderSize = 0
        Me.btnInicioSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnInicioSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicioSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnInicioSesion.ForeColor = System.Drawing.Color.White
        Me.btnInicioSesion.Image = Global.CapaPresentacion.My.Resources.Resources.logologin1
        Me.btnInicioSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicioSesion.Location = New System.Drawing.Point(-1, 11)
        Me.btnInicioSesion.Name = "btnInicioSesion"
        Me.btnInicioSesion.Size = New System.Drawing.Size(215, 58)
        Me.btnInicioSesion.TabIndex = 10
        Me.btnInicioSesion.Text = "    Inicio Sesion"
        Me.btnInicioSesion.UseVisualStyleBackColor = True
        '
        'btnPaciente
        '
        Me.btnPaciente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPaciente.FlatAppearance.BorderSize = 0
        Me.btnPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPaciente.ForeColor = System.Drawing.Color.White
        Me.btnPaciente.Image = Global.CapaPresentacion.My.Resources.Resources.clientes
        Me.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPaciente.Location = New System.Drawing.Point(0, 267)
        Me.btnPaciente.Name = "btnPaciente"
        Me.btnPaciente.Size = New System.Drawing.Size(215, 58)
        Me.btnPaciente.TabIndex = 12
        Me.btnPaciente.Text = "    Paciente"
        Me.btnPaciente.UseVisualStyleBackColor = True
        '
        'btnFarmaceuta
        '
        Me.btnFarmaceuta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFarmaceuta.FlatAppearance.BorderSize = 0
        Me.btnFarmaceuta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnFarmaceuta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnFarmaceuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFarmaceuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFarmaceuta.ForeColor = System.Drawing.Color.White
        Me.btnFarmaceuta.Image = Global.CapaPresentacion.My.Resources.Resources.clientes
        Me.btnFarmaceuta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFarmaceuta.Location = New System.Drawing.Point(3, 203)
        Me.btnFarmaceuta.Name = "btnFarmaceuta"
        Me.btnFarmaceuta.Size = New System.Drawing.Size(215, 58)
        Me.btnFarmaceuta.TabIndex = 11
        Me.btnFarmaceuta.Text = "    Farmaceuta"
        Me.btnFarmaceuta.UseVisualStyleBackColor = True
        '
        'btnEncargado
        '
        Me.btnEncargado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEncargado.FlatAppearance.BorderSize = 0
        Me.btnEncargado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnEncargado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnEncargado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEncargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEncargado.ForeColor = System.Drawing.Color.White
        Me.btnEncargado.Image = Global.CapaPresentacion.My.Resources.Resources.logofile1
        Me.btnEncargado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEncargado.Location = New System.Drawing.Point(3, 139)
        Me.btnEncargado.Name = "btnEncargado"
        Me.btnEncargado.Size = New System.Drawing.Size(215, 58)
        Me.btnEncargado.TabIndex = 10
        Me.btnEncargado.Text = "    Encargado"
        Me.btnEncargado.UseVisualStyleBackColor = True
        '
        'btnPerfil
        '
        Me.btnPerfil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPerfil.FlatAppearance.BorderSize = 0
        Me.btnPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPerfil.ForeColor = System.Drawing.Color.White
        Me.btnPerfil.Image = Global.CapaPresentacion.My.Resources.Resources.logouser
        Me.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPerfil.Location = New System.Drawing.Point(0, 75)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(215, 58)
        Me.btnPerfil.TabIndex = 9
        Me.btnPerfil.Text = "    Perfil"
        Me.btnPerfil.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.Image = Global.CapaPresentacion.My.Resources.Resources.Mobile_Menu_Icon
        Me.btnMenu.Location = New System.Drawing.Point(168, 3)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(49, 33)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.TabStop = False
        '
        'tmOcultarMenu
        '
        Me.tmOcultarMenu.Interval = 50
        '
        'tmMostrarMenu
        '
        Me.tmMostrarMenu.Interval = 50
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnRegistrar)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.cbxFarmacia)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lvAgregados)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cbxSustancia)
        Me.Panel1.Controls.Add(Me.nudCant)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dtpFecha)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtMedico)
        Me.Panel1.Controls.Add(Me.txtCedula)
        Me.Panel1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(338, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(682, 431)
        Me.Panel1.TabIndex = 19
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.Black
        Me.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRegistrar.FlatAppearance.BorderSize = 2
        Me.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Location = New System.Drawing.Point(320, 384)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(112, 30)
        Me.btnRegistrar.TabIndex = 28
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Black
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAgregar.FlatAppearance.BorderSize = 2
        Me.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(150, 340)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 30)
        Me.btnAgregar.TabIndex = 27
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'cbxFarmacia
        '
        Me.cbxFarmacia.FormattingEnabled = True
        Me.cbxFarmacia.Items.AddRange(New Object() {"Panadol", "Omeprasol", "Tabcin", "Perico"})
        Me.cbxFarmacia.Location = New System.Drawing.Point(150, 88)
        Me.cbxFarmacia.Name = "cbxFarmacia"
        Me.cbxFarmacia.Size = New System.Drawing.Size(145, 26)
        Me.cbxFarmacia.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(64, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 18)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Farmacia"
        '
        'lvAgregados
        '
        Me.lvAgregados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.nombre, Me.cantidad})
        Me.lvAgregados.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvAgregados.HideSelection = True
        Me.lvAgregados.Location = New System.Drawing.Point(357, 203)
        Me.lvAgregados.Name = "lvAgregados"
        Me.lvAgregados.Size = New System.Drawing.Size(277, 147)
        Me.lvAgregados.TabIndex = 17
        Me.lvAgregados.UseCompatibleStateImageBehavior = False
        Me.lvAgregados.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "Id"
        Me.id.Width = 40
        '
        'nombre
        '
        Me.nombre.Text = "Nombre"
        Me.nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nombre.Width = 150
        '
        'cantidad
        '
        Me.cantidad.Text = "Cantidad"
        Me.cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cantidad.Width = 80
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(238, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Cantidad"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(112, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Sustancia"
        '
        'cbxSustancia
        '
        Me.cbxSustancia.FormattingEnabled = True
        Me.cbxSustancia.Items.AddRange(New Object() {"Panadol", "Omeprasol", "Tabcin", "Perico"})
        Me.cbxSustancia.Location = New System.Drawing.Point(91, 265)
        Me.cbxSustancia.Name = "cbxSustancia"
        Me.cbxSustancia.Size = New System.Drawing.Size(121, 26)
        Me.cbxSustancia.TabIndex = 13
        '
        'nudCant
        '
        Me.nudCant.Location = New System.Drawing.Point(238, 267)
        Me.nudCant.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudCant.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCant.Name = "nudCant"
        Me.nudCant.Size = New System.Drawing.Size(57, 26)
        Me.nudCant.TabIndex = 12
        Me.nudCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudCant.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(254, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "REGISTRAR RECETA"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "yyyy-MM-dd"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(466, 139)
        Me.dtpFecha.MaxDate = New Date(2023, 11, 30, 0, 0, 0, 0)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(145, 26)
        Me.dtpFecha.TabIndex = 9
        Me.dtpFecha.Value = New Date(2022, 11, 18, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(382, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(382, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Medico:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(64, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cedula:"
        '
        'txtMedico
        '
        Me.txtMedico.Location = New System.Drawing.Point(466, 93)
        Me.txtMedico.Name = "txtMedico"
        Me.txtMedico.Size = New System.Drawing.Size(145, 26)
        Me.txtMedico.TabIndex = 3
        Me.txtMedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(150, 139)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(145, 26)
        Me.txtCedula.TabIndex = 2
        Me.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RegistrarReceta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(1084, 561)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "RegistrarReceta"
        Me.Text = "RegistrarReceta"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenuSmall.ResumeLayout(False)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudCant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents PanelMenuSmall As Panel
    Friend WithEvents btnAdministrador As Button
    Friend WithEvents btnInicioSesion As Button
    Friend WithEvents btnPaciente As Button
    Friend WithEvents btnFarmaceuta As Button
    Friend WithEvents btnEncargado As Button
    Friend WithEvents btnPerfil As Button
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents tmOcultarMenu As Timer
    Friend WithEvents tmMostrarMenu As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtMedico As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nudCant As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxSustancia As ComboBox
    Friend WithEvents lvAgregados As ListView
    Friend WithEvents id As ColumnHeader
    Friend WithEvents nombre As ColumnHeader
    Friend WithEvents cantidad As ColumnHeader
    Friend WithEvents Label8 As Label
    Friend WithEvents cbxFarmacia As ComboBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnRegistrar As Button
End Class
