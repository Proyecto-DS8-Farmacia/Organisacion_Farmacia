﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultarInventario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgvConsultarIn = New System.Windows.Forms.DataGridView()
        Me.txtNombreF = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PanelMenuSmall = New System.Windows.Forms.Panel()
        Me.btnPaciente = New System.Windows.Forms.Button()
        Me.btnFarmaceuta = New System.Windows.Forms.Button()
        Me.btnEncargado = New System.Windows.Forms.Button()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.btnInicioSesion = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.tmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.btnAdministrador = New System.Windows.Forms.Button()
        CType(Me.dgvConsultarIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.PanelMenuSmall.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvConsultarIn
        '
        Me.dgvConsultarIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultarIn.Location = New System.Drawing.Point(257, 191)
        Me.dgvConsultarIn.Name = "dgvConsultarIn"
        Me.dgvConsultarIn.RowTemplate.Height = 25
        Me.dgvConsultarIn.Size = New System.Drawing.Size(776, 214)
        Me.dgvConsultarIn.TabIndex = 0
        '
        'txtNombreF
        '
        Me.txtNombreF.Location = New System.Drawing.Point(257, 126)
        Me.txtNombreF.Name = "txtNombreF"
        Me.txtNombreF.Size = New System.Drawing.Size(247, 23)
        Me.txtNombreF.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(257, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ingrese el nombre de la Farmacia"
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.Transparent
        Me.PanelMenu.Controls.Add(Me.btnAdministrador)
        Me.PanelMenu.Controls.Add(Me.btnSalir)
        Me.PanelMenu.Controls.Add(Me.PanelMenuSmall)
        Me.PanelMenu.Controls.Add(Me.btnMenu)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 561)
        Me.PanelMenu.TabIndex = 13
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
        Me.btnSalir.Location = New System.Drawing.Point(5, 476)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(215, 58)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "    Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PanelMenuSmall
        '
        Me.PanelMenuSmall.BackColor = System.Drawing.Color.Transparent
        Me.PanelMenuSmall.Controls.Add(Me.btnPaciente)
        Me.PanelMenuSmall.Controls.Add(Me.btnFarmaceuta)
        Me.PanelMenuSmall.Controls.Add(Me.btnEncargado)
        Me.PanelMenuSmall.Controls.Add(Me.btnPerfil)
        Me.PanelMenuSmall.Controls.Add(Me.btnInicioSesion)
        Me.PanelMenuSmall.Location = New System.Drawing.Point(3, 80)
        Me.PanelMenuSmall.Name = "PanelMenuSmall"
        Me.PanelMenuSmall.Size = New System.Drawing.Size(214, 334)
        Me.PanelMenuSmall.TabIndex = 1
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
        Me.btnInicioSesion.Location = New System.Drawing.Point(0, 11)
        Me.btnInicioSesion.Name = "btnInicioSesion"
        Me.btnInicioSesion.Size = New System.Drawing.Size(215, 58)
        Me.btnInicioSesion.TabIndex = 8
        Me.btnInicioSesion.Text = "    Inicio Sesion"
        Me.btnInicioSesion.UseVisualStyleBackColor = True
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
        '
        'tmMostrarMenu
        '
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
        Me.btnAdministrador.Location = New System.Drawing.Point(3, 420)
        Me.btnAdministrador.Name = "btnAdministrador"
        Me.btnAdministrador.Size = New System.Drawing.Size(215, 58)
        Me.btnAdministrador.TabIndex = 15
        Me.btnAdministrador.Text = "    Administrador"
        Me.btnAdministrador.UseVisualStyleBackColor = True
        '
        'ConsultarInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(1084, 561)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombreF)
        Me.Controls.Add(Me.dgvConsultarIn)
        Me.Name = "ConsultarInventario"
        Me.Text = "ConsultarInventario"
        CType(Me.dgvConsultarIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenuSmall.ResumeLayout(False)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvConsultarIn As DataGridView
    Friend WithEvents txtNombreF As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents PanelMenuSmall As Panel
    Friend WithEvents btnPaciente As Button
    Friend WithEvents btnFarmaceuta As Button
    Friend WithEvents btnEncargado As Button
    Friend WithEvents btnPerfil As Button
    Friend WithEvents btnInicioSesion As Button
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents tmOcultarMenu As Timer
    Friend WithEvents tmMostrarMenu As Timer
    Friend WithEvents btnAdministrador As Button
End Class
