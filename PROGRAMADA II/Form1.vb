Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration


Public Class Form1
    Dim cadena As New OleDbConnection
    Dim comando As New OleDbCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cadena.ConnectionString = ConfigurationManager.ConnectionStrings.Item(1).ConnectionString
            cadena.Open()
            'Mostrar()
            MsgBox("Usted ha entrado a la aplicación 'cálculadora de notas de graduación'", vbInformation, "Aviso")
        Catch ex As Exception
            MsgBox("No se pudo conectar con la cálculadora", vbCritical, "Aviso")
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Tabla_Est.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Tabla_Pro.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        F_Estudiantes.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        F_Profesores.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Evaluación_de_Defensa_Pública_1.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        C_Notas.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Acta_Defensa_Pública.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Evaluación_de_Defensa_Pública_2.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        End
    End Sub