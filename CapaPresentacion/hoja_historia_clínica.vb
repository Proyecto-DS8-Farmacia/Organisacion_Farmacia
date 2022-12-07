Public Class hoja_historia_clínica
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim id_paciente, amanesis, medicamento, presion, pulso, examen As String
        Dim estatura, pres As Double
        Dim id

        id_paciente = HojadeIngreso.txtCedula.Text
        amanesis = RichTextBox1.Text
        medicamento = "none"
        presion = TextBox4.Text
        pulso = TextBox5.Text
        examen = TextBox6.Text
        pres = TextBox2.Text
        estatura = TextBox3.Text



        Try

            CapaDatos.Metodos.Historia_Clinico(id_paciente, medicamento, amanesis, pres, estatura, presion, pulso, examen)
            MessageBox.Show("Datos Insertados", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

            MessageBox.Show("Los Campos edad e hijos deben ser valores numericos", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub


End Class
