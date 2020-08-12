<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Estudiantes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NombreLabel As System.Windows.Forms.Label
        Dim CarnéLabel As System.Windows.Forms.Label
        Dim Nombre_del_ProyectoLabel As System.Windows.Forms.Label
        Dim Profesor_AsesorLabel As System.Windows.Forms.Label
        Dim Lector_1Label As System.Windows.Forms.Label
        Dim Nota_Lector_1Label As System.Windows.Forms.Label
        Dim Lector_2Label As System.Windows.Forms.Label
        Dim Nota_Lector_2Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Estudiantes))
        Me._Cal_ProyectosDeGraduaciónDataSet = New PROGRAMADA_II._Cal_ProyectosDeGraduaciónDataSet()
        Me.EstudiantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstudiantesTableAdapter = New PROGRAMADA_II._Cal_ProyectosDeGraduaciónDataSetTableAdapters.EstudiantesTableAdapter()
        Me.TableAdapterManager = New PROGRAMADA_II._Cal_ProyectosDeGraduaciónDataSetTableAdapters.TableAdapterManager()
        Me.EstudiantesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.CarnéTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_del_ProyectoTextBox = New System.Windows.Forms.TextBox()
        Me.Profesor_AsesorComboBox = New System.Windows.Forms.ComboBox()
        Me.ProfesoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lector_1TextBox = New System.Windows.Forms.TextBox()
        Me.Nota_Lector_1TextBox = New System.Windows.Forms.TextBox()
        Me.Lector_2TextBox = New System.Windows.Forms.TextBox()
        Me.Nota_Lector_2TextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProfesoresTableAdapter = New PROGRAMADA_II._Cal_ProyectosDeGraduaciónDataSetTableAdapters.ProfesoresTableAdapter()
        Me.EstudiantesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        NombreLabel = New System.Windows.Forms.Label()
        CarnéLabel = New System.Windows.Forms.Label()
        Nombre_del_ProyectoLabel = New System.Windows.Forms.Label()
        Profesor_AsesorLabel = New System.Windows.Forms.Label()
        Lector_1Label = New System.Windows.Forms.Label()
        Nota_Lector_1Label = New System.Windows.Forms.Label()
        Lector_2Label = New System.Windows.Forms.Label()
        Nota_Lector_2Label = New System.Windows.Forms.Label()
        CType(Me._Cal_ProyectosDeGraduaciónDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudiantesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EstudiantesBindingNavigator.SuspendLayout()
        CType(Me.ProfesoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(171, 69)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 1
        NombreLabel.Text = "Nombre:"
        '
        'CarnéLabel
        '
        CarnéLabel.AutoSize = True
        CarnéLabel.Location = New System.Drawing.Point(171, 95)
        CarnéLabel.Name = "CarnéLabel"
        CarnéLabel.Size = New System.Drawing.Size(38, 13)
        CarnéLabel.TabIndex = 3
        CarnéLabel.Text = "Carné:"
        '
        'Nombre_del_ProyectoLabel
        '
        Nombre_del_ProyectoLabel.AutoSize = True
        Nombre_del_ProyectoLabel.Location = New System.Drawing.Point(171, 121)
        Nombre_del_ProyectoLabel.Name = "Nombre_del_ProyectoLabel"
        Nombre_del_ProyectoLabel.Size = New System.Drawing.Size(109, 13)
        Nombre_del_ProyectoLabel.TabIndex = 5
        Nombre_del_ProyectoLabel.Text = "Nombre del Proyecto:"
        '
        'Profesor_AsesorLabel
        '
        Profesor_AsesorLabel.AutoSize = True
        Profesor_AsesorLabel.Location = New System.Drawing.Point(171, 147)
        Profesor_AsesorLabel.Name = "Profesor_AsesorLabel"
        Profesor_AsesorLabel.Size = New System.Drawing.Size(84, 13)
        Profesor_AsesorLabel.TabIndex = 7
        Profesor_AsesorLabel.Text = "Profesor Asesor:"
        '
        'Lector_1Label
        '
        Lector_1Label.AutoSize = True
        Lector_1Label.Location = New System.Drawing.Point(171, 174)
        Lector_1Label.Name = "Lector_1Label"
        Lector_1Label.Size = New System.Drawing.Size(49, 13)
        Lector_1Label.TabIndex = 9
        Lector_1Label.Text = "Lector 1:"
        '
        'Nota_Lector_1Label
        '
        Nota_Lector_1Label.AutoSize = True
        Nota_Lector_1Label.Location = New System.Drawing.Point(171, 200)
        Nota_Lector_1Label.Name = "Nota_Lector_1Label"
        Nota_Lector_1Label.Size = New System.Drawing.Size(75, 13)
        Nota_Lector_1Label.TabIndex = 11
        Nota_Lector_1Label.Text = "Nota Lector 1:"
        '
        'Lector_2Label
        '
        Lector_2Label.AutoSize = True
        Lector_2Label.Location = New System.Drawing.Point(171, 226)
        Lector_2Label.Name = "Lector_2Label"
        Lector_2Label.Size = New System.Drawing.Size(49, 13)
        Lector_2Label.TabIndex = 13
        Lector_2Label.Text = "Lector 2:"
        '
        'Nota_Lector_2Label
        '
        Nota_Lector_2Label.AutoSize = True
        Nota_Lector_2Label.Location = New System.Drawing.Point(171, 252)
        Nota_Lector_2Label.Name = "Nota_Lector_2Label"
        Nota_Lector_2Label.Size = New System.Drawing.Size(75, 13)
        Nota_Lector_2Label.TabIndex = 15
        Nota_Lector_2Label.Text = "Nota Lector 2:"
        '
        '_Cal_ProyectosDeGraduaciónDataSet
        '
        Me._Cal_ProyectosDeGraduaciónDataSet.DataSetName = "_Cal_ProyectosDeGraduaciónDataSet"
        Me._Cal_ProyectosDeGraduaciónDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstudiantesBindingSource
        '
        Me.EstudiantesBindingSource.DataMember = "Estudiantes"
        Me.EstudiantesBindingSource.DataSource = Me._Cal_ProyectosDeGraduaciónDataSet
        '
        'EstudiantesTableAdapter
        '
        Me.EstudiantesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EstudiantesTableAdapter = Me.EstudiantesTableAdapter
        Me.TableAdapterManager.ProfesoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PROGRAMADA_II._Cal_ProyectosDeGraduaciónDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EstudiantesBindingNavigator
        '
        Me.EstudiantesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EstudiantesBindingNavigator.BindingSource = Me.EstudiantesBindingSource
        Me.EstudiantesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EstudiantesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EstudiantesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EstudiantesBindingNavigatorSaveItem})
        Me.EstudiantesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EstudiantesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EstudiantesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EstudiantesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EstudiantesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EstudiantesBindingNavigator.Name = "EstudiantesBindingNavigator"
        Me.EstudiantesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EstudiantesBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.EstudiantesBindingNavigator.TabIndex = 0
        Me.EstudiantesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudiantesBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(286, 66)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(121, 20)
        Me.NombreTextBox.TabIndex = 2
        '
        'CarnéTextBox
        '
        Me.CarnéTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudiantesBindingSource, "Carné", True))
        Me.CarnéTextBox.Location = New System.Drawing.Point(286, 92)
        Me.CarnéTextBox.Name = "CarnéTextBox"
        Me.CarnéTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CarnéTextBox.TabIndex = 4
        '
        'Nombre_del_ProyectoTextBox
        '
        Me.Nombre_del_ProyectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudiantesBindingSource, "Nombre del Proyecto", True))
        Me.Nombre_del_ProyectoTextBox.Location = New System.Drawing.Point(286, 118)
        Me.Nombre_del_ProyectoTextBox.Name = "Nombre_del_ProyectoTextBox"
        Me.Nombre_del_ProyectoTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Nombre_del_ProyectoTextBox.TabIndex = 6
        '
        'Profesor_AsesorComboBox
        '
        Me.Profesor_AsesorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudiantesBindingSource, "Profesor Asesor", True))
        Me.Profesor_AsesorComboBox.DataSource = Me.ProfesoresBindingSource
        Me.Profesor_AsesorComboBox.DisplayMember = "Nombre"
        Me.Profesor_AsesorComboBox.FormattingEnabled = True
        Me.Profesor_AsesorComboBox.Location = New System.Drawing.Point(286, 144)
        Me.Profesor_AsesorComboBox.Name = "Profesor_AsesorComboBox"
        Me.Profesor_AsesorComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Profesor_AsesorComboBox.TabIndex = 8
        '
        'ProfesoresBindingSource
        '
        Me.ProfesoresBindingSource.DataMember = "Profesores"
        Me.ProfesoresBindingSource.DataSource = Me._Cal_ProyectosDeGraduaciónDataSet
        '
        'Lector_1TextBox
        '
        Me.Lector_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudiantesBindingSource, "Lector 1", True))
        Me.Lector_1TextBox.Location = New System.Drawing.Point(286, 171)
        Me.Lector_1TextBox.Name = "Lector_1TextBox"
        Me.Lector_1TextBox.Size = New System.Drawing.Size(121, 20)
        Me.Lector_1TextBox.TabIndex = 10
        '
        'Nota_Lector_1TextBox
        '
        Me.Nota_Lector_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudiantesBindingSource, "Nota Lector 1", True))
        Me.Nota_Lector_1TextBox.Location = New System.Drawing.Point(286, 197)
        Me.Nota_Lector_1TextBox.Name = "Nota_Lector_1TextBox"
        Me.Nota_Lector_1TextBox.Size = New System.Drawing.Size(121, 20)
        Me.Nota_Lector_1TextBox.TabIndex = 12
        '
        'Lector_2TextBox
        '
        Me.Lector_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudiantesBindingSource, "Lector 2", True))
        Me.Lector_2TextBox.Location = New System.Drawing.Point(286, 223)
        Me.Lector_2TextBox.Name = "Lector_2TextBox"
        Me.Lector_2TextBox.Size = New System.Drawing.Size(121, 20)
        Me.Lector_2TextBox.TabIndex = 14
        '
        'Nota_Lector_2TextBox
        '
        Me.Nota_Lector_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudiantesBindingSource, "Nota Lector 2", True))
        Me.Nota_Lector_2TextBox.Location = New System.Drawing.Point(286, 249)
        Me.Nota_Lector_2TextBox.Name = "Nota_Lector_2TextBox"
        Me.Nota_Lector_2TextBox.Size = New System.Drawing.Size(121, 20)
        Me.Nota_Lector_2TextBox.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(455, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Regresar al Menú"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(511, 143)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ProfesoresTableAdapter
        '
        Me.ProfesoresTableAdapter.ClearBeforeFill = True
        '
        'EstudiantesBindingNavigatorSaveItem
        '
        Me.EstudiantesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EstudiantesBindingNavigatorSaveItem.Image = CType(resources.GetObject("EstudiantesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EstudiantesBindingNavigatorSaveItem.Name = "EstudiantesBindingNavigatorSaveItem"
        Me.EstudiantesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EstudiantesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'F_Estudiantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(CarnéLabel)
        Me.Controls.Add(Me.CarnéTextBox)
        Me.Controls.Add(Nombre_del_ProyectoLabel)
        Me.Controls.Add(Me.Nombre_del_ProyectoTextBox)
        Me.Controls.Add(Profesor_AsesorLabel)
        Me.Controls.Add(Me.Profesor_AsesorComboBox)
        Me.Controls.Add(Lector_1Label)
        Me.Controls.Add(Me.Lector_1TextBox)
        Me.Controls.Add(Nota_Lector_1Label)
        Me.Controls.Add(Me.Nota_Lector_1TextBox)
        Me.Controls.Add(Lector_2Label)
        Me.Controls.Add(Me.Lector_2TextBox)
        Me.Controls.Add(Nota_Lector_2Label)
        Me.Controls.Add(Me.Nota_Lector_2TextBox)
        Me.Controls.Add(Me.EstudiantesBindingNavigator)
        Me.Name = "F_Estudiantes"
        Me.Text = "F_Estudiantes"
        CType(Me._Cal_ProyectosDeGraduaciónDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudiantesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EstudiantesBindingNavigator.ResumeLayout(False)
        Me.EstudiantesBindingNavigator.PerformLayout()
        CType(Me.ProfesoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _Cal_ProyectosDeGraduaciónDataSet As _Cal_ProyectosDeGraduaciónDataSet
    Friend WithEvents EstudiantesBindingSource As BindingSource
    Friend WithEvents EstudiantesTableAdapter As _Cal_ProyectosDeGraduaciónDataSetTableAdapters.EstudiantesTableAdapter
    Friend WithEvents TableAdapterManager As _Cal_ProyectosDeGraduaciónDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EstudiantesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents CarnéTextBox As TextBox
    Friend WithEvents Nombre_del_ProyectoTextBox As TextBox
    Friend WithEvents Profesor_AsesorComboBox As ComboBox
    Friend WithEvents Lector_1TextBox As TextBox
    Friend WithEvents Nota_Lector_1TextBox As TextBox
    Friend WithEvents Lector_2TextBox As TextBox
    Friend WithEvents Nota_Lector_2TextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ProfesoresBindingSource As BindingSource
    Friend WithEvents ProfesoresTableAdapter As _Cal_ProyectosDeGraduaciónDataSetTableAdapters.ProfesoresTableAdapter
    Friend WithEvents EstudiantesBindingNavigatorSaveItem As ToolStripButton
End Class
