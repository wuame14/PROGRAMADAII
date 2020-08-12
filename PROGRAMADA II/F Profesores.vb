Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration
Public Class F_Profesores
    Dim cadena As New OleDbConnection
    Dim comando As New OleDbCommand
    Private Sub ProfesoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProfesoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProfesoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Cal_ProyectosDeGraduaciónDataSet)

    End Sub

    Private Sub F_Profesores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Cal_ProyectosDeGraduaciónDataSet.Profesores' Puede moverla o quitarla según sea necesario.
        Me.ProfesoresTableAdapter.Fill(Me._Cal_ProyectosDeGraduaciónDataSet.Profesores)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Validate()
        Me.ProfesoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Cal_ProyectosDeGraduaciónDataSet)
        Me.Refresh()
        Tabla_Pro.Refresh()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.ProfesoresBindingSource.AddNew()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.ProfesoresBindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.ProfesoresBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.ProfesoresBindingSource.RemoveCurrent()
        ProfesoresTableAdapter.Update(_Cal_ProyectosDeGraduaciónDataSet)

    End Sub
End Class