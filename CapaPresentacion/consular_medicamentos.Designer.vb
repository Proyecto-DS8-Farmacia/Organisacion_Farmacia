<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consular_medicamentos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomSustancia = New System.Windows.Forms.TextBox()
        Me.cbxVia = New System.Windows.Forms.ComboBox()
        Me.dgvMedicamentos = New System.Windows.Forms.DataGridView()
        CType(Me.dgvMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(309, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 22)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Medicamentos"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(82, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(191, 19)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Nombre de Sustancia:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(510, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 19)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Via de administración:"
        '
        'txtNomSustancia
        '
        Me.txtNomSustancia.Location = New System.Drawing.Point(82, 130)
        Me.txtNomSustancia.Name = "txtNomSustancia"
        Me.txtNomSustancia.Size = New System.Drawing.Size(224, 21)
        Me.txtNomSustancia.TabIndex = 44
        '
        'cbxVia
        '
        Me.cbxVia.FormattingEnabled = True
        Me.cbxVia.Location = New System.Drawing.Point(510, 128)
        Me.cbxVia.Name = "cbxVia"
        Me.cbxVia.Size = New System.Drawing.Size(191, 23)
        Me.cbxVia.TabIndex = 45
        '
        'dgvMedicamentos
        '
        Me.dgvMedicamentos.AllowUserToAddRows = False
        Me.dgvMedicamentos.AllowUserToDeleteRows = False
        Me.dgvMedicamentos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvMedicamentos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMedicamentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedicamentos.Location = New System.Drawing.Point(134, 211)
        Me.dgvMedicamentos.Name = "dgvMedicamentos"
        Me.dgvMedicamentos.RowTemplate.Height = 23
        Me.dgvMedicamentos.Size = New System.Drawing.Size(510, 150)
        Me.dgvMedicamentos.TabIndex = 46
        '
        'consular_medicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvMedicamentos)
        Me.Controls.Add(Me.cbxVia)
        Me.Controls.Add(Me.txtNomSustancia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Name = "consular_medicamentos"
        Me.Text = "consular_medicamentos"
        CType(Me.dgvMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNomSustancia As TextBox
    Friend WithEvents cbxVia As ComboBox
    Friend WithEvents dgvMedicamentos As DataGridView
End Class
