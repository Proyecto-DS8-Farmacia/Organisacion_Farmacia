<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class notas_enfermeras
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEvolucion = New System.Windows.Forms.TextBox()
        Me.txtCedulaP = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNotas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(305, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Notas de enfermeria"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(79, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(191, 19)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Cedula del paciente:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(79, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 19)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Evolucion:"
        '
        'txtEvolucion
        '
        Me.txtEvolucion.Location = New System.Drawing.Point(79, 220)
        Me.txtEvolucion.Multiline = True
        Me.txtEvolucion.Name = "txtEvolucion"
        Me.txtEvolucion.Size = New System.Drawing.Size(601, 75)
        Me.txtEvolucion.TabIndex = 45
        '
        'txtCedulaP
        '
        Me.txtCedulaP.Location = New System.Drawing.Point(262, 107)
        Me.txtCedulaP.Name = "txtCedulaP"
        Me.txtCedulaP.Size = New System.Drawing.Size(195, 21)
        Me.txtCedulaP.TabIndex = 46
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(368, 362)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 47
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNotas
        '
        Me.btnNotas.Location = New System.Drawing.Point(477, 362)
        Me.btnNotas.Name = "btnNotas"
        Me.btnNotas.Size = New System.Drawing.Size(75, 23)
        Me.btnNotas.TabIndex = 48
        Me.btnNotas.Text = "Regresar"
        Me.btnNotas.UseVisualStyleBackColor = True
        '
        'notas_enfermeras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 434)
        Me.Controls.Add(Me.btnNotas)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtCedulaP)
        Me.Controls.Add(Me.txtEvolucion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "notas_enfermeras"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEvolucion As TextBox
    Friend WithEvents txtCedulaP As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNotas As Button
End Class
