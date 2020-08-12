<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tabla_Est
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tabla_Est))
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
        Me.EstudiantesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EstudiantesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me._Cal_ProyectosDeGraduaciónDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudiantesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EstudiantesBindingNavigator.SuspendLayout()
        CType(Me.EstudiantesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.EstudiantesBindingNavigator.Size = New System.Drawing.Size(884, 25)
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
        'EstudiantesBindingNavigatorSaveItem
        '
        Me.EstudiantesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EstudiantesBindingNavigatorSaveItem.Image = CType(resources.GetObject("EstudiantesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EstudiantesBindingNavigatorSaveItem.Name = "EstudiantesBindingNavigatorSaveItem"
        Me.EstudiantesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EstudiantesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'EstudiantesDataGridView
        '
        Me.EstudiantesDataGridView.AutoGenerateColumns = False
        Me.EstudiantesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EstudiantesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.EstudiantesDataGridView.DataSource = Me.EstudiantesBindingSource
        Me.EstudiantesDataGridView.Location = New System.Drawing.Point(12, 44)
        Me.EstudiantesDataGridView.Name = "EstudiantesDataGridView"
        Me.EstudiantesDataGridView.Size = New System.Drawing.Size(841, 279)
        Me.EstudiantesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Carné"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Carné"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nombre del Proyecto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre del Proyecto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Profesor Asesor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Profesor Asesor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Lector 1"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Lector 1"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Nota Lector 1"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nota Lector 1"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Lector 2"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Lector 2"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Nota Lector 2"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Nota Lector 2"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(133, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Regresar al Menú"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Tabla_Est
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.EstudiantesDataGridView)
        Me.Controls.Add(Me.EstudiantesBindingNavigator)
        Me.Name = "Tabla_Est"
        Me.Text = "Tabla_Est"
        CType(Me._Cal_ProyectosDeGraduaciónDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudiantesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EstudiantesBindingNavigator.ResumeLayout(False)
        Me.EstudiantesBindingNavigator.PerformLayout()
        CType(Me.EstudiantesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents EstudiantesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents EstudiantesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
