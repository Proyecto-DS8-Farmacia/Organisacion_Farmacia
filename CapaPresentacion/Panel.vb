Public Class Panel
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OrdenMedica.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Reporte.Show()
    End Sub

    Private Sub Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HojadeIngreso.Show()

    End Sub
End Class