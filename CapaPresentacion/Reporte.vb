Imports System.Data.SqlClient

Public Class Reporte
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim con As New CapaDatos.connect
        con.Conectar()
        Dim conex As New SqlConnection("Data Source=DESKTOP-TO7JHQK;Initial Catalog=Caja_Social;Integrated Security=True")


        Dim sql As String = "Select nombre,apellido,edad,tipaje
                                from paciente 
                                where id_paciente=" + txtCedula.Text()

        'Creamos el Transporte
        Dim cmd As New SqlCommand(sql, conex)

        Try
            'Creamos el puente entre SQL Y DB Virtual
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet

            'Traemos los datos
            da.Fill(ds, "paciente")

            'Atravez de DataGridView podemos mostrar este equivalente DataColumn y DataRow
            Me.DataGridView1.DataSource = ds.Tables("paciente")
            DataGridView1.Columns(0).Width = 100

            sql = "Select peso,estatura,presion,pulso
                                from historial_clinico 
                                where id_paciente=" + txtCedula.Text()

            Dim cmd1 As New SqlCommand(sql, conex)
            Dim da1 As New SqlDataAdapter(cmd1)

            da1.Fill(ds, "historial_clinico")
            Me.DataGridView2.DataSource = ds.Tables("historial_clinico")
            DataGridView2.Columns(0).Width = 100

            sql = "Select medicamento, cantidad, via, observacion
                                from orden_medica
                                where id_paciente=" + txtCedula.Text()

            Dim cmd4 As New SqlCommand(sql, conex)
            Dim da4 As New SqlDataAdapter(cmd4)

            da4.Fill(ds, "orden_medica")
            Me.DataGridView3.DataSource = ds.Tables("orden_medica")
            DataGridView3.Columns(0).Width = 100

            sql = "Select evolucion
                                from notas_enfermeria 
                                where numero_orden=1"

            Dim cmd2 As New SqlCommand(sql, conex)
            Dim da2 As New SqlDataAdapter(cmd2)

            da2.Fill(ds, "notas_enfermeria")
            Me.lblEvolucion.Text = ds.Tables("notas_enfermeria").Rows(0).Item(0)

            sql = "Select unidad_medica, numero_cama, fecha_ingreso, hora_ingreso, diagnostico_ingreso
                                from hoja_frontal 
                                where id_paciente=" + txtCedula.Text()

            Dim cmd3 As New SqlCommand(sql, conex)
            Dim da3 As New SqlDataAdapter(cmd3)

            da3.Fill(ds, "hoja_frontal")
            Me.lblUM.Text = ds.Tables("hoja_frontal").Rows(0).Item(0)
            Me.lblNCama.Text = ds.Tables("hoja_frontal").Rows(0).Item(1)
            Me.lblFIngreso.Text = ds.Tables("hoja_frontal").Rows(0).Item(2)
            Me.lblHIngreso.Text = ds.Tables("hoja_frontal").Rows(0).Item(3)
            Me.lblDIngreso.Text = ds.Tables("hoja_frontal").Rows(0).Item(4)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conex.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
