
Public Class C_Notas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub C_Notas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EstudiantesTableAdapter.Fill(Me._Cal_ProyectosDeGraduaciónDataSet.Estudiantes)
        Dim row As _Cal_ProyectosDeGraduaciónDataSet.EstudiantesRow = v.Row

        Nota_Pro.te = EstudiantesTableAdapter.sumNotas(row.carne)
    End Sub
End Class