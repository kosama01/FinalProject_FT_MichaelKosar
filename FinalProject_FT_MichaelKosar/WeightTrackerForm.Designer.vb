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
        Me.dgvWeightTracker = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvWeightTracker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvWeightTracker
        '
        Me.dgvWeightTracker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvWeightTracker.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvWeightTracker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWeightTracker.Location = New System.Drawing.Point(25, 168)
        Me.dgvWeightTracker.Name = "dgvWeightTracker"
        Me.dgvWeightTracker.RowTemplate.Height = 24
        Me.dgvWeightTracker.Size = New System.Drawing.Size(450, 200)
        Me.dgvWeightTracker.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(156, 119)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(122, 22)
        Me.DateTimePicker1.TabIndex = 1
        '
        'WeightTrackerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 393)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.dgvWeightTracker)
        Me.Name = "WeightTrackerForm"
        Me.Text = "WeightTrackerForm"
        CType(Me.dgvWeightTracker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvWeightTracker As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
