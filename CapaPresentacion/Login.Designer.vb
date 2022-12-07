<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(136, 384)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(136, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Correo"
        '
        'txtContraseña
        '
        Me.txtContraseña.BackColor = System.Drawing.Color.White
        Me.txtContraseña.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtContraseña.Location = New System.Drawing.Point(136, 411)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(258, 31)
        Me.txtContraseña.TabIndex = 8
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.Color.White
        Me.txtCorreo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCorreo.Location = New System.Drawing.Point(136, 302)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(258, 31)
        Me.txtCorreo.TabIndex = 7
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.Black
        Me.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnIngresar.FlatAppearance.BorderSize = 2
        Me.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnIngresar.ForeColor = System.Drawing.Color.White
        Me.btnIngresar.Location = New System.Drawing.Point(173, 468)
        Me.btnIngresar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(191, 47)
        Me.btnIngresar.TabIndex = 11
        Me.btnIngresar.Text = "INGRESAR"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.CapaPresentacion.My.Resources.Resources.clientes
        Me.PictureBox1.Location = New System.Drawing.Point(136, 3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 213)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 612)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtCorreo)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
