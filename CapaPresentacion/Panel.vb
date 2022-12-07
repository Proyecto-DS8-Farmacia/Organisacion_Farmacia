Imports System.Data.SqlClient
Public Class Panel
    Dim Correo As String

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OrdenMedica.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Reporte.Show()
    End Sub

    Private Sub Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Correo = lblCorreo.Text
        Dim con As New CapaDatos.connect
        con.Conectar()
        Dim conex As New SqlConnection("Data Source=DESKTOP-TO7JHQK;Initial Catalog=Caja_Social;Integrated Security=True")
        Dim sql As String = "SELECT  a.id_usuario,[nombre],[apellido],[telefono],[id_hospital],correo 
                               
                      FROM [Caja_Social].[dbo].[doctor] as a,[Caja_Social].[dbo].[usuario] where correo = '" + Correo + "'"
        Dim cmd As New SqlCommand(sql, conex)

        Try
            'Creamos el puente entre SQL Y DB Virtual
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet

            da.Fill(ds, "usuario")

            Me.DataGridView1.DataSource = ds.Tables("usuario")
            DataGridView1.Columns(0).Width = 100

            sql = "SELECT  a.id_usuario,[nombre],[apellido],[telefono],[id_hospital],correo 
                               
                                FROM [Caja_Social].[dbo].[doctor] as a,[Caja_Social].[dbo].[usuario] where correo = '" + Correo + "'"
            Me.lblnombre.Text = ds.Tables("usuario").Rows(0).Item(1)
            Me.lblapellido.Text = ds.Tables("usuario").Rows(0).Item(2)
            Me.lbltelefono.Text = ds.Tables("usuario").Rows(0).Item(3)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HojadeIngreso.Show()

    End Sub
End Class