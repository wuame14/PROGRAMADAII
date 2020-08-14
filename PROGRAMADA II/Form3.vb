Public Class Acta_Defensa_Pública
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub EstudiantesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EstudiantesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EstudiantesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Cal_ProyectosDeGraduaciónDataSet)

    End Sub

    Private Sub Acta_Defensa_Pública_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Cal_ProyectosDeGraduaciónDataSet.Estudiantes' table. You can move, or remove it, as needed.
        Me.EstudiantesTableAdapter.Fill(Me._Cal_ProyectosDeGraduaciónDataSet.Estudiantes)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub NombreComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NombreComboBox.SelectedIndexChanged
        Dim v As DataRowView = NombreComboBox.SelectedItem()
        Dim row As _Cal_ProyectosDeGraduaciónDataSet.EstudiantesRow = v.Row


        TextBox2.Text = EstudiantesTableAdapter.sumNotas(row.Carné)
    End Sub

End Class