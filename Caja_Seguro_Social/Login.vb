Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load





    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim regex As Regex = New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        Dim validocorreo As Boolean = regex.IsMatch(txtCorreo.Text.Trim)

        'correo_e = txtCorreo.Text
        'contraseña = txtContraseña.Text

        If (txtCorreo.Text.Equals("") Or txtContraseña.Text.Equals("")) Then
            MessageBox.Show("Ingrese sus datos correctamente.", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If Not validocorreo Then
                MessageBox.Show("Ingrese un correo valido.", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else


                If (True) Then
                    Try
                        Datos.Metodos.INICIAR_SESION("guillermo@gmail.com", "1234", "Doctor")
                        '   Datos.Metodos.INICIAR_SESION(txtCorreo.Text.ToString, txtContraseña.Text.ToString, "Doctor")
                        'Administrador.Show()
                        MessageBox.Show("ERES UN DOCTOR", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.Hide()
                    Catch ex As Exception
                        MsgBox("Error: " & ex.ToString)
                    End Try

                Else
                    MessageBox.Show("No se inicio sesion. Revise sus credenciales.", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If


                'Administrador.Show()
                'Me.Hide()
            End If

            'If (optAdmin.Checked) Then
            'Administrador.Show()
            'End If
        End If
        txtCorreo.Text = ""
        txtContraseña.Text = ""
    End Sub


End Class