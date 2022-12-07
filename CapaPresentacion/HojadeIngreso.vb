Imports System.Diagnostics.Eventing.Reader

Public Class HojadeIngreso
    Private Sub HojadeIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxEstado.Items.Add("Unido(a)")
        cbxEstado.Items.Add("Soltero(a)")
        cbxEstado.Items.Add("Casado(a)")
        cbxEstado.Items.Add("Divorciado(a)")
        cbxEstado.Items.Add("Separado(a)")
        cbxEstado.Items.Add("Viudo(a)")

        cbxTipoSangre.Items.Add("A")
        cbxTipoSangre.Items.Add("B")
        cbxTipoSangre.Items.Add("AB")
        cbxTipoSangre.Items.Add("O")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnSi.CheckedChanged
        If (rbtnSi.Checked) Then
            txtNumHijos.Enabled = True
            lblNumHijos.Enabled = True
        Else
            txtNumHijos.Enabled = False
            lblNumHijos.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        hoja_historia_clínica.txtPerfilNombre.Text = txtNombre.Text
        hoja_historia_clínica.txtPerfilapellido.Text = txtApellido.Text
        hoja_historia_clínica.txtCorreo.Text = txtCorreo.Text
        hoja_historia_clínica.txtTelefono.Text = txtTelefono.Text
        hoja_historia_clínica.txtEdad.Text = txtEdad.Text
        hoja_historia_clínica.txtEstado.Text = cbxEstado.Text
        hoja_historia_clínica.txtNhijos.Text = txtNumHijos.Text
        hoja_historia_clínica.txtPrevision.Text = txtObservaciones.Text
        Hoja_Frontal.Show()
        Me.Hide()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id_paciente, nombre, apellido, correo, telefono, tipo_sangre, estado, previsio As String
        Dim edad, n_hijos As Integer

        id_paciente = txtCedula.Text
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        correo = txtCorreo.Text
        telefono = txtTelefono.Text
        tipo_sangre = cbxTipoSangre.SelectedItem
        estado = cbxEstado.SelectedItem
        previsio = txtObservaciones.Text

        Try
            edad = CInt(txtEdad.Text)
            If (rbtnSi.Checked) Then
                n_hijos = CInt(txtNumHijos.Text)
            Else
                n_hijos = 0
            End If
            CapaDatos.Metodos.GuardarHojaDeIngreso(id_paciente, nombre, apellido, correo, telefono, tipo_sangre, estado, previsio, edad, n_hijos)
        Catch ex As Exception
            MessageBox.Show("Los Campos edad e hijos deben ser valores numericos", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class
