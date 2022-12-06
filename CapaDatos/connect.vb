Imports System.Data.SqlClient

Public Class connect
    Public Function Conectar()
        Try
            Dim conexion As New SqlConnection("Data Source=DESKTOP-TO7JHQK;Initial Catalog=Caja_Social;Integrated Security=True")
            conexion.Open()
            MsgBox("Conexion exitosa")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return 0
    End Function
End Class
