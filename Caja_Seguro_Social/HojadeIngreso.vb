Imports System.Diagnostics.Eventing.Reader

Public Class HojadeIngreso

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

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



End Class
