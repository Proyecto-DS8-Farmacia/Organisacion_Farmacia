﻿Public Class Farmaceuta

    Private Sub PanelMenu_Paint(sender As Object, e As PaintEventArgs) Handles PanelMenu.Paint
        PanelMenu.BackColor = Color.FromArgb(100, 0, 35, 0)
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If PanelMenu.Width = 220 Then
            tmOcultarMenu.Enabled = True
        ElseIf PanelMenu.Width = 60 Then
            tmMostrarMenu.Enabled = True
        End If
    End Sub

    Private Sub tmOcultarMenu_Tick(sender As Object, e As EventArgs) Handles tmOcultarMenu.Tick
        If PanelMenu.Width <= 60 Then
            Me.tmOcultarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 20
        End If
    End Sub

    Private Sub tmMostrarMenu_Tick(sender As Object, e As EventArgs) Handles tmMostrarMenu.Tick
        If PanelMenu.Width >= 220 Then
            Me.tmMostrarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 20
        End If
    End Sub

    Private Sub btnInicioSesion_Click(sender As Object, e As EventArgs) Handles btnInicioSesion.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnPerfil_Click(sender As Object, e As EventArgs) Handles btnPerfil.Click
        Perfil.Show()
        Me.Hide()
    End Sub

    Private Sub btnFarmaceuta_Click(sender As Object, e As EventArgs) Handles btnFarmaceuta.Click
        Me.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Form1.Close()
    End Sub


    Private Sub btnConsultarIn_Click(sender As Object, e As EventArgs) Handles btnConsultarIn.Click
        ConsultarInventario.Show()
    End Sub

    Private Sub btnRegistrarReceta_Click(sender As Object, e As EventArgs) Handles btnRegistrarReceta.Click
        RegistrarReceta.Show()
        Me.Hide()
    End Sub


End Class