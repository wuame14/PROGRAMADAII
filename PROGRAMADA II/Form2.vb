
Public Class C_Notas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub C_Notas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Cal_ProyectosDeGraduaciónDataSet.NotaPromedioEstudiantes' table. You can move, or remove it, as needed.
        Me.NotaPromedioEstudiantesTableAdapter.Fill(Me._Cal_ProyectosDeGraduaciónDataSet.NotaPromedioEstudiantes)
        'Me.EstudiantesTableAdapter.Fill(Me._Cal_ProyectosDeGraduaciónDataSet.Estudiantes)
    End Sub

    Private Sub RefreshData_Click(sender As Object, e As EventArgs) Handles RefreshData.Click
        NotaPromedioEstudiantesTableAdapter.Fill(_Cal_ProyectosDeGraduaciónDataSet.NotaPromedioEstudiantes)
        ActiveForm.Refresh()
    End Sub

    Private Sub EstudiantesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EstudiantesDataGridView.CellContentClick

    End Sub
End Class