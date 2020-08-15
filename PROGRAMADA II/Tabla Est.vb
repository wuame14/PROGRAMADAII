Public Class Tabla_Est
    Private Sub EstudiantesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EstudiantesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EstudiantesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Cal_ProyectosDeGraduaciónDataSet)

    End Sub

    Private Sub Tabla_Est_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Cal_ProyectosDeGraduaciónDataSet.Estudiantes' Puede moverla o quitarla según sea necesario.
        Me.EstudiantesTableAdapter.Fill(Me._Cal_ProyectosDeGraduaciónDataSet.Estudiantes)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub EstudiantesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EstudiantesDataGridView.CellContentClick

    End Sub

    Private Sub EstudiantesBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles EstudiantesBindingSource.CurrentChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EstudiantesTableAdapter.Fill(_Cal_ProyectosDeGraduaciónDataSet.Estudiantes)
        ActiveForm.Refresh()

    End Sub
End Class