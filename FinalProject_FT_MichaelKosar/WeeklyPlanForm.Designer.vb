<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeeklyPlanForm
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
        Me.radMonday = New System.Windows.Forms.RadioButton()
        Me.radTuesday = New System.Windows.Forms.RadioButton()
        Me.radFriday = New System.Windows.Forms.RadioButton()
        Me.radThursday = New System.Windows.Forms.RadioButton()
        Me.radWednesday = New System.Windows.Forms.RadioButton()
        Me.radSunday = New System.Windows.Forms.RadioButton()
        Me.radSaturday = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.libDailyActivities = New System.Windows.Forms.ListBox()
        Me.btnAddActivity = New System.Windows.Forms.Button()
        Me.btnRemoveActivity = New System.Windows.Forms.Button()
        Me.lblActivityName = New System.Windows.Forms.Label()
        Me.txtActivityName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'radMonday
        '
        Me.radMonday.AutoSize = True
        Me.radMonday.Location = New System.Drawing.Point(12, 40)
        Me.radMonday.Name = "radMonday"
        Me.radMonday.Size = New System.Drawing.Size(79, 21)
        Me.radMonday.TabIndex = 0
        Me.radMonday.TabStop = True
        Me.radMonday.Text = "Monday"
        Me.radMonday.UseVisualStyleBackColor = True
        '
        'radTuesday
        '
        Me.radTuesday.AutoSize = True
        Me.radTuesday.Location = New System.Drawing.Point(7, 79)
        Me.radTuesday.Name = "radTuesday"
        Me.radTuesday.Size = New System.Drawing.Size(84, 21)
        Me.radTuesday.TabIndex = 1
        Me.radTuesday.TabStop = True
        Me.radTuesday.Text = "Tuesday"
        Me.radTuesday.UseVisualStyleBackColor = True
        '
        'radFriday
        '
        Me.radFriday.AutoSize = True
        Me.radFriday.Location = New System.Drawing.Point(183, 46)
        Me.radFriday.Name = "radFriday"
        Me.radFriday.Size = New System.Drawing.Size(68, 21)
        Me.radFriday.TabIndex = 2
        Me.radFriday.TabStop = True
        Me.radFriday.Text = "Friday"
        Me.radFriday.UseVisualStyleBackColor = True
        '
        'radThursday
        '
        Me.radThursday.AutoSize = True
        Me.radThursday.Location = New System.Drawing.Point(183, 13)
        Me.radThursday.Name = "radThursday"
        Me.radThursday.Size = New System.Drawing.Size(89, 21)
        Me.radThursday.TabIndex = 3
        Me.radThursday.TabStop = True
        Me.radThursday.Text = "Thursday"
        Me.radThursday.UseVisualStyleBackColor = True
        '
        'radWednesday
        '
        Me.radWednesday.AutoSize = True
        Me.radWednesday.Location = New System.Drawing.Point(7, 115)
        Me.radWednesday.Name = "radWednesday"
        Me.radWednesday.Size = New System.Drawing.Size(104, 21)
        Me.radWednesday.TabIndex = 4
        Me.radWednesday.TabStop = True
        Me.radWednesday.Text = "Wednesday"
        Me.radWednesday.UseVisualStyleBackColor = True
        '
        'radSunday
        '
        Me.radSunday.AutoSize = True
        Me.radSunday.Location = New System.Drawing.Point(183, 115)
        Me.radSunday.Name = "radSunday"
        Me.radSunday.Size = New System.Drawing.Size(77, 21)
        Me.radSunday.TabIndex = 5
        Me.radSunday.TabStop = True
        Me.radSunday.Text = "Sunday"
        Me.radSunday.UseVisualStyleBackColor = True
        '
        'radSaturday
        '
        Me.radSaturday.AutoSize = True
        Me.radSaturday.Location = New System.Drawing.Point(183, 79)
        Me.radSaturday.Name = "radSaturday"
        Me.radSaturday.Size = New System.Drawing.Size(86, 21)
        Me.radSaturday.TabIndex = 6
        Me.radSaturday.TabStop = True
        Me.radSaturday.Text = "Saturday"
        Me.radSaturday.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(382, 28)
        Me.MenuStrip1.TabIndex = 8
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
        'libDailyActivities
        '
        Me.libDailyActivities.FormattingEnabled = True
        Me.libDailyActivities.ItemHeight = 16
        Me.libDailyActivities.Location = New System.Drawing.Point(32, 300)
        Me.libDailyActivities.Name = "libDailyActivities"
        Me.libDailyActivities.Size = New System.Drawing.Size(306, 116)
        Me.libDailyActivities.TabIndex = 9
        '
        'btnAddActivity
        '
        Me.btnAddActivity.Location = New System.Drawing.Point(54, 234)
        Me.btnAddActivity.Name = "btnAddActivity"
        Me.btnAddActivity.Size = New System.Drawing.Size(106, 47)
        Me.btnAddActivity.TabIndex = 10
        Me.btnAddActivity.Text = "Add Activity"
        Me.btnAddActivity.UseVisualStyleBackColor = True
        '
        'btnRemoveActivity
        '
        Me.btnRemoveActivity.Location = New System.Drawing.Point(207, 234)
        Me.btnRemoveActivity.Name = "btnRemoveActivity"
        Me.btnRemoveActivity.Size = New System.Drawing.Size(131, 47)
        Me.btnRemoveActivity.TabIndex = 11
        Me.btnRemoveActivity.Text = "Remove Activity"
        Me.btnRemoveActivity.UseVisualStyleBackColor = True
        '
        'lblActivityName
        '
        Me.lblActivityName.AutoSize = True
        Me.lblActivityName.Location = New System.Drawing.Point(28, 202)
        Me.lblActivityName.Name = "lblActivityName"
        Me.lblActivityName.Size = New System.Drawing.Size(93, 17)
        Me.lblActivityName.TabIndex = 12
        Me.lblActivityName.Text = "Activity Name"
        '
        'txtActivityName
        '
        Me.txtActivityName.Location = New System.Drawing.Point(127, 199)
        Me.txtActivityName.Name = "txtActivityName"
        Me.txtActivityName.Size = New System.Drawing.Size(211, 22)
        Me.txtActivityName.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSaturday)
        Me.GroupBox1.Controls.Add(Me.radSunday)
        Me.GroupBox1.Controls.Add(Me.radWednesday)
        Me.GroupBox1.Controls.Add(Me.radThursday)
        Me.GroupBox1.Controls.Add(Me.radFriday)
        Me.GroupBox1.Controls.Add(Me.radTuesday)
        Me.GroupBox1.Controls.Add(Me.radMonday)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(289, 146)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Day of The Week"
        '
        'WeeklyPlanForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 427)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtActivityName)
        Me.Controls.Add(Me.lblActivityName)
        Me.Controls.Add(Me.btnRemoveActivity)
        Me.Controls.Add(Me.btnAddActivity)
        Me.Controls.Add(Me.libDailyActivities)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "WeeklyPlanForm"
        Me.Text = "WeeklyPlanForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radMonday As RadioButton
    Friend WithEvents radTuesday As RadioButton
    Friend WithEvents radFriday As RadioButton
    Friend WithEvents radThursday As RadioButton
    Friend WithEvents radWednesday As RadioButton
    Friend WithEvents radSunday As RadioButton
    Friend WithEvents radSaturday As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents libDailyActivities As ListBox
    Friend WithEvents btnAddActivity As Button
    Friend WithEvents btnRemoveActivity As Button
    Friend WithEvents lblActivityName As Label
    Friend WithEvents txtActivityName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
