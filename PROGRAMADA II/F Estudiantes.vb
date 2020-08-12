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
        Try
            cadena.ConnectionString = ConfigurationManager.ConnectionStrings.Item(1).ConnectionString
            cadena.Open()

            comando = New OleDbCommand("Insert into Estudiantes(Nombre, Carné, NombredelProyecto, ProfesorAsesor)" & "values(NombreTextBox, CarnéTextBox, NombredelProyectoTextBox, ProfesorAsesorComboBox)", cadena)

            comando.Parameters.AddWithValue("@Nombre", NombreTextBox.Text)
            comando.Parameters.AddWithValue("@Carné", CarnéTextBox.Text)
            comando.Parameters.AddWithValue("@NombredelProyecto", Nombre_del_ProyectoTextBox.Text)
            comando.Parameters.AddWithValue("@ProfesorAsesor", Profesor_AsesorComboBox.SelectedItem)
            comando.ExecuteNonQuery()

            MsgBox("Registro Guardado Correctamente", vbInformation, "Aviso")

        Catch ex As Exception

            MsgBox("Registro No se Guardo", vbCritical, "Aviso")

        End Try

        cadena.Close()
    End Sub
End Class