Public Class notas_enfermeras
    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim cedula, evolucion As String
        cedula = txtCedulaP.Text
        evolucion = txtEvolucion.Text
        Try
            CapaDatos.Metodos.AgregarNotasEnfermeria(cedula, evolucion)
            MessageBox.Show("Se ha agregado la Nota correctamente")

        Catch ex As Exception
            MessageBox.Show("No se ha agregado la nota")
        End Try



    End Sub

    Private Sub btnNotas_Click(sender As Object, e As EventArgs) Handles btnNotas.Click
        Me.Hide()
        Panel.Show()
    End Sub
End Class