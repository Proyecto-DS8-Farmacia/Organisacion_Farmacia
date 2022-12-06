Imports System.Data.SqlClient
Public Class Metodos

    Public Shared Function INICIAR_SESION(CORREO As String, CONTRASEÑA As String, TIPO As String) As String
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("inicio_sesionB", CN)
                CMD.CommandType = CommandType.StoredProcedure
                'CMD.Parameters.AddWithValue("@ENSQLSERVER", ENVISUALSTUDIO)
                CMD.Parameters.AddWithValue("@CORREO_E", CORREO)
                CMD.Parameters.AddWithValue("@CONTRASEÑA", CONTRASEÑA)
                CMD.Parameters.AddWithValue("@TIPO", TIPO)
                CN.Open()

                Try
                    Return CMD.ExecuteReader().HasRows.ToString
                Catch ex As Exception

                    MsgBox("Error: " & ex.ToString)

                End Try



            End Using
        End Using

    End Function


End Class
