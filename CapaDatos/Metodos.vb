Imports System.Data.SqlClient
Public Class Metodos
    Public Shared Sub GuardarHojaDeIngreso(id_paciente As String, nombre As String, apellido As String, correo As String, telefono As String, tipo_sangre As String, estado As String, previsio As String, edad As Integer, n_hijos As Integer)

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("sp_RegHojaDeIngreso", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@id_paciente", id_paciente)
                CMD.Parameters.AddWithValue("@nombre", nombre)
                CMD.Parameters.AddWithValue("@apellido", apellido)
                CMD.Parameters.AddWithValue("@correo", correo)
                CMD.Parameters.AddWithValue("@telefono", telefono)
                CMD.Parameters.AddWithValue("@edad", edad)
                CMD.Parameters.AddWithValue("@tipo_sangre", tipo_sangre)
                CMD.Parameters.AddWithValue("@n_hijos", n_hijos)
                CMD.Parameters.AddWithValue("@estado", estado)
                CMD.Parameters.AddWithValue("@previsio", previsio)
                Try
                    If CN.State = ConnectionState.Closed Then
                        CN.Open()
                    End If

                    CMD.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Console.WriteLine(ex.Message)
                End Try
                CN.Close()
            End Using
        End Using
    End Sub

    Public Shared Sub GuardarHojaFrontal(id_paciente As String, unidad_medica As String, numero_cama As String, factorrh As String, fecha_ingreso As String, fecha_egreso As String, hora_ingreso As String, hora_egreso As String, diagnostico_ingreso As String, diagnostico_egreso As String)
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("sp_RegHojaFrontal", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@id_paciente", id_paciente)
                CMD.Parameters.AddWithValue("@unidad_medica", unidad_medica)
                CMD.Parameters.AddWithValue("@numero_cama", numero_cama)
                CMD.Parameters.AddWithValue("@factorrh", factorrh)
                CMD.Parameters.AddWithValue("@fecha_ingreso", fecha_ingreso)
                CMD.Parameters.AddWithValue("@fecha_egreso", fecha_egreso)
                CMD.Parameters.AddWithValue("@hora_ingreso", hora_ingreso)
                CMD.Parameters.AddWithValue("@hora_egreso", hora_egreso)
                CMD.Parameters.AddWithValue("@diagnostico_ingreso", diagnostico_ingreso)
                CMD.Parameters.AddWithValue("@diagnostico_egreso", diagnostico_egreso)
                Try
                    If CN.State = ConnectionState.Closed Then
                        CN.Open()
                    End If

                    CMD.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                    MsgBox(ex.Message)
                End Try
                CN.Close()
            End Using
        End Using
    End Sub

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
    Public Shared Function ListarMedicamentos() As Object
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("Select * from medicamentos", CN)
                Using Datos As New DataTable
                    DA.Fill(Datos)
                    Return Datos
                End Using
            End Using
        End Using
    End Function

    Public Shared Function ListarVias() As Object
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("Select DISTINCT via from medicamentos", CN)
                Using Datos As New DataTable
                    DA.Fill(Datos)
                    Return Datos
                End Using
            End Using
        End Using
    End Function

    Public Shared Sub Historia_Clinico(id_paciente As String, unidad_medica As String, apellido As String, correo As Double, telefono As Double, tipo_sangre As String, edad As Integer, n_hijos As Integer)

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("hs_historialClinico", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@id_paciente", id_paciente)
                CMD.Parameters.AddWithValue("@unidad_medica", unidad_medica)
                CMD.Parameters.AddWithValue("@amanesis_consulta", apellido)
                CMD.Parameters.AddWithValue("@peso", correo)
                CMD.Parameters.AddWithValue("@estatura ", telefono)
                CMD.Parameters.AddWithValue("@presion", edad)
                CMD.Parameters.AddWithValue("@pulso", tipo_sangre)
                CMD.Parameters.AddWithValue("@examen_fisico", n_hijos)

                Try
                    If CN.State = ConnectionState.Closed Then
                        CN.Open()
                    End If
                    CMD.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Console.WriteLine(ex.Message)
                End Try
                CN.Close()
            End Using
        End Using
    End Sub

    Public Shared Sub AgregarNotasEnfermeria(cedula As String, evolucion As String)
        Using CN As New SqlConnection(My.Settings.Conexion)

            Using CMD As New SqlCommand("sp_AddNotasEnfermeria", CN)

                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@id_paciente", cedula)
                CMD.Parameters.AddWithValue("@evolucion", evolucion)
                Try
                    If CN.State = ConnectionState.Closed Then
                        CN.Open()
                    End If
                    CMD.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Console.WriteLine(ex.Message)
                End Try
                CN.Close()
            End Using
        End Using
    End Sub
End Class
