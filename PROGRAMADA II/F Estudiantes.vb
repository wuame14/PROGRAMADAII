Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration


Public Class F_Estudiantes
    Dim cadena As New OleDbConnection
    Dim comando As New OleDbCommand
    Private Sub EstudiantesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EstudiantesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EstudiantesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Cal_ProyectosDeGraduaciónDataSet)

    End Sub

    Private Sub F_Estudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Cal_ProyectosDeGraduaciónDataSet.Profesores' Puede moverla o quitarla según sea necesario.
        Me.ProfesoresTableAdapter.Fill(Me._Cal_ProyectosDeGraduaciónDataSet.Profesores)
        'TODO: esta línea de código carga datos en la tabla '_Cal_ProyectosDeGraduaciónDataSet.Estudiantes' Puede moverla o quitarla según sea necesario.
        Me.EstudiantesTableAdapter.Fill(Me._Cal_ProyectosDeGraduaciónDataSet.Estudiantes)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Validate()
        Me.EstudiantesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Cal_ProyectosDeGraduaciónDataSet)
        Me.Refresh()
        Tabla_Est.Refresh()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.EstudiantesBindingSource.AddNew()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.EstudiantesBindingSource.MoveNext()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.EstudiantesBindingSource.MovePrevious()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub
End Class