Public Class Evaluación_de_Defensa_Pública_2
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Evaluación_de_Defensa_Pública_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Cal_ProyectosDeGraduaciónDataSet.Profesores' Puede moverla o quitarla según sea necesario.
        Me.ProfesoresTableAdapter.Fill(Me._Cal_ProyectosDeGraduaciónDataSet.Profesores)
        'TODO: esta línea de código carga datos en la tabla '_Cal_ProyectosDeGraduaciónDataSet.Estudiantes' Puede moverla o quitarla según sea necesario.
        Me.EstudiantesTableAdapter.Fill(Me._Cal_ProyectosDeGraduaciónDataSet.Estudiantes)

    End Sub

    Private Sub EstudiantesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EstudiantesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EstudiantesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Cal_ProyectosDeGraduaciónDataSet)

        EstudiantesTableAdapter.Update()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox18.Text = (Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text)) / 3 * 0.05
        TextBox19.Text = (Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox9.Text) + Val(TextBox10.Text) + Val(TextBox11.Text) + Val(TextBox12.Text) + Val(TextBox13.Text)) / 8 * 0.2
        TextBox20.Text = (Val(TextBox14.Text) + Val(TextBox15.Text)) / 2 * 0.05
        TextBox21.Text = Val(TextBox16.Text) * 0.1
        TextBox22.Text = Val(TextBox18.Text) + Val(TextBox19.Text) + Val(TextBox20.Text) + Val(TextBox21.Text)
        TextBox23.Text = Val(TextBox22.Text) / 0.4
        Nota_Lector_1TextBox.Text = Val(TextBox23.Text)
    End Sub

    Private Sub NombreComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NombreComboBox2.SelectedIndexChanged

    End Sub

    Private Sub TextBox23_TextChanged(sender As Object, e As EventArgs) Handles TextBox23.TextChanged

    End Sub
End Class