Public Class F_Profesores
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
End Class