<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeightTrackerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWeightGoal = New System.Windows.Forms.TextBox()
        Me.dgvWeightTracker = New System.Windows.Forms.DataGridView()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightGoalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DifferenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WeightTrackerDataSet = New FinalProject_FT_MichaelKosar.WeightTrackerDataSet()
        Me.WeightTableAdapter = New FinalProject_FT_MichaelKosar.WeightTrackerDataSetTableAdapters.WeightTableAdapter()
        Me.btnDeleteAll = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvWeightTracker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeightBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeightTrackerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(115, 115)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(122, 22)
        Me.dtpDate.TabIndex = 1
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(22, 120)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(38, 17)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(22, 81)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(52, 17)
        Me.lblWeight.TabIndex = 3
        Me.lblWeight.Text = "Weight"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(115, 76)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 22)
        Me.txtWeight.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(499, 28)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(108, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(316, 117)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(103, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(262, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Weight Goal"
        '
        'txtWeightGoal
        '
        Me.txtWeightGoal.Location = New System.Drawing.Point(375, 71)
        Me.txtWeightGoal.Name = "txtWeightGoal"
        Me.txtWeightGoal.Size = New System.Drawing.Size(100, 22)
        Me.txtWeightGoal.TabIndex = 8
        '
        'dgvWeightTracker
        '
        Me.dgvWeightTracker.AutoGenerateColumns = False
        Me.dgvWeightTracker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWeightTracker.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.WeightGoalDataGridViewTextBoxColumn, Me.DifferenceDataGridViewTextBoxColumn})
        Me.dgvWeightTracker.DataSource = Me.WeightBindingSource
        Me.dgvWeightTracker.Location = New System.Drawing.Point(25, 217)
        Me.dgvWeightTracker.Name = "dgvWeightTracker"
        Me.dgvWeightTracker.RowTemplate.Height = 24
        Me.dgvWeightTracker.Size = New System.Drawing.Size(449, 215)
        Me.dgvWeightTracker.TabIndex = 9
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "Weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "Weight"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        '
        'WeightGoalDataGridViewTextBoxColumn
        '
        Me.WeightGoalDataGridViewTextBoxColumn.DataPropertyName = "Weight Goal"
        Me.WeightGoalDataGridViewTextBoxColumn.HeaderText = "Weight Goal"
        Me.WeightGoalDataGridViewTextBoxColumn.Name = "WeightGoalDataGridViewTextBoxColumn"
        '
        'DifferenceDataGridViewTextBoxColumn
        '
        Me.DifferenceDataGridViewTextBoxColumn.DataPropertyName = "Difference"
        Me.DifferenceDataGridViewTextBoxColumn.HeaderText = "Difference"
        Me.DifferenceDataGridViewTextBoxColumn.Name = "DifferenceDataGridViewTextBoxColumn"
        '
        'WeightBindingSource
        '
        Me.WeightBindingSource.DataMember = "Weight"
        Me.WeightBindingSource.DataSource = Me.WeightTrackerDataSet
        '
        'WeightTrackerDataSet
        '
        Me.WeightTrackerDataSet.DataSetName = "WeightTrackerDataSet"
        Me.WeightTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WeightTableAdapter
        '
        Me.WeightTableAdapter.ClearBeforeFill = True
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.Location = New System.Drawing.Point(316, 169)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(103, 23)
        Me.btnDeleteAll.TabIndex = 11
        Me.btnDeleteAll.Text = "Delete All"
        Me.btnDeleteAll.UseVisualStyleBackColor = True
        '
        'WeightTrackerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 444)
        Me.Controls.Add(Me.btnDeleteAll)
        Me.Controls.Add(Me.dgvWeightTracker)
        Me.Controls.Add(Me.txtWeightGoal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "WeightTrackerForm"
        Me.Text = "WeightTrackerForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvWeightTracker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeightBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeightTrackerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblDate As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtWeightGoal As TextBox
    Friend WithEvents dgvWeightTracker As DataGridView
    Friend WithEvents WeightTrackerDataSet As WeightTrackerDataSet
    Friend WithEvents WeightBindingSource As BindingSource
    Friend WithEvents WeightTableAdapter As WeightTrackerDataSetTableAdapters.WeightTableAdapter
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightGoalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DifferenceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnDeleteAll As Button
End Class
