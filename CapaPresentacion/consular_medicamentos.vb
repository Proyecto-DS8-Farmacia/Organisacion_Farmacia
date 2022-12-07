Public Class consular_medicamentos
    Private Sub consular_medicamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvMedicamentos.DataSource = CapaDatos.Metodos.ListarMedicamentos
        dgvMedicamentos.Columns.Item(0).HeaderText = "Id"
        dgvMedicamentos.Columns.Item(0).Width = 80
        dgvMedicamentos.Columns.Item(1).Width = 150

        cbxVia.ValueMember = "via"
        cbxVia.DisplayMember = "via"
        cbxVia.DataSource = CapaDatos.Metodos.ListarVias


    End Sub

    Private Sub txtNomSustancia_TextChanged(sender As Object, e As EventArgs) Handles txtNomSustancia.TextChanged
        Dim Datos As New DataView(CapaDatos.Metodos.ListarMedicamentos)
        Datos.RowFilter = "nombre like '" & txtNomSustancia.Text & "%' and via = '" & cbxVia.SelectedValue & "'"
        dgvMedicamentos.DataSource = Datos
    End Sub

    Private Sub cbxVia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxVia.SelectedIndexChanged
        If (cbxVia.SelectedValue IsNot Nothing) Then
            Dim Datos As New DataView(CapaDatos.Metodos.ListarMedicamentos)
            Datos.RowFilter = "nombre like '" & txtNomSustancia.Text & "%' and via like '" & cbxVia.SelectedValue & "'"
            dgvMedicamentos.DataSource = Datos
        End If
    End Sub
End Class