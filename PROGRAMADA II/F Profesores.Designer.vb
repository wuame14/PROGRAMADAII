<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Profesores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Profesores))
        Dim NombreLabel As System.Windows.Forms.Label
        Me._Cal_ProyectosDeGraduaciónDataSet = New PROGRAMADA_II._Cal_ProyectosDeGraduaciónDataSet()
        Me.ProfesoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfesoresTableAdapter = New PROGRAMADA_II._Cal_ProyectosDeGraduaciónDataSetTableAdapters.ProfesoresTableAdapter()
        Me.TableAdapterManager = New PROGRAMADA_II._Cal_ProyectosDeGraduaciónDataSetTableAdapters.TableAdapterManager()
        Me.ProfesoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ProfesoresBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        NombreLabel = New System.Windows.Forms.Label()
        CType(Me._Cal_ProyectosDeGraduaciónDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfesoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfesoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProfesoresBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Cal_ProyectosDeGraduaciónDataSet
        '
        Me._Cal_ProyectosDeGraduaciónDataSet.DataSetName = "_Cal_ProyectosDeGraduaciónDataSet"
        Me._Cal_ProyectosDeGraduaciónDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProfesoresBindingSource
        '
        Me.ProfesoresBindingSource.DataMember = "Profesores"
        Me.ProfesoresBindingSource.DataSource = Me._Cal_ProyectosDeGraduaciónDataSet
        '
        'ProfesoresTableAdapter
        '
        Me.ProfesoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EstudiantesTableAdapter = Nothing
        Me.TableAdapterManager.ProfesoresTableAdapter = Me.ProfesoresTableAdapter
        Me.TableAdapterManager.UpdateOrder = PROGRAMADA_II._Cal_ProyectosDeGraduaciónDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProfesoresBindingNavigator
        '
        Me.ProfesoresBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProfesoresBindingNavigator.BindingSource = Me.ProfesoresBindingSource
        Me.ProfesoresBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProfesoresBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProfesoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProfesoresBindingNavigatorSaveItem})
        Me.ProfesoresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProfesoresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProfesoresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProfesoresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProfesoresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProfesoresBindingNavigator.Name = "ProfesoresBindingNavigator"
        Me.ProfesoresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProfesoresBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.ProfesoresBindingNavigator.TabIndex = 0
        Me.ProfesoresBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'ProfesoresBindingNavigatorSaveItem
        '
        Me.ProfesoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProfesoresBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProfesoresBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProfesoresBindingNavigatorSaveItem.Name = "ProfesoresBindingNavigatorSaveItem"
        Me.ProfesoresBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ProfesoresBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(183, 40)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 1
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfesoresBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(236, 37)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(443, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Regresar al Menú"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'F_Profesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.ProfesoresBindingNavigator)
        Me.Name = "F_Profesores"
        Me.Text = "F_Profesores"
        CType(Me._Cal_ProyectosDeGraduaciónDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfesoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfesoresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProfesoresBindingNavigator.ResumeLayout(False)
        Me.ProfesoresBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _Cal_ProyectosDeGraduaciónDataSet As _Cal_ProyectosDeGraduaciónDataSet
    Friend WithEvents ProfesoresBindingSource As BindingSource
    Friend WithEvents ProfesoresTableAdapter As _Cal_ProyectosDeGraduaciónDataSetTableAdapters.ProfesoresTableAdapter
    Friend WithEvents TableAdapterManager As _Cal_ProyectosDeGraduaciónDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProfesoresBindingNavigator As BindingNavigator
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
    Friend WithEvents ProfesoresBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
