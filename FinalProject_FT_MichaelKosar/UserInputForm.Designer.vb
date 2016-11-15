<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserInputForm
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
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.btnBMI = New System.Windows.Forms.Button()
        Me.btnCalories = New System.Windows.Forms.Button()
        Me.txtHeightft = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.btnWeightTracker = New System.Windows.Forms.Button()
        Me.btnWeekPlan = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtHeightin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(31, 36)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(49, 17)
        Me.lblHeight.TabIndex = 0
        Me.lblHeight.Text = "Height"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(31, 79)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(52, 17)
        Me.lblWeight.TabIndex = 1
        Me.lblWeight.Text = "Weight"
        '
        'btnBMI
        '
        Me.btnBMI.Location = New System.Drawing.Point(34, 139)
        Me.btnBMI.Name = "btnBMI"
        Me.btnBMI.Size = New System.Drawing.Size(222, 36)
        Me.btnBMI.TabIndex = 4
        Me.btnBMI.Text = "Calculate BMI"
        Me.btnBMI.UseVisualStyleBackColor = True
        '
        'btnCalories
        '
        Me.btnCalories.Location = New System.Drawing.Point(34, 181)
        Me.btnCalories.Name = "btnCalories"
        Me.btnCalories.Size = New System.Drawing.Size(222, 36)
        Me.btnCalories.TabIndex = 5
        Me.btnCalories.Text = "Calculate Calories"
        Me.btnCalories.UseVisualStyleBackColor = True
        '
        'txtHeightft
        '
        Me.txtHeightft.Location = New System.Drawing.Point(134, 36)
        Me.txtHeightft.Name = "txtHeightft"
        Me.txtHeightft.Size = New System.Drawing.Size(34, 22)
        Me.txtHeightft.TabIndex = 6
        Me.txtHeightft.Text = "0"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(134, 79)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 22)
        Me.txtWeight.TabIndex = 7
        Me.txtWeight.Text = "0"
        '
        'btnWeightTracker
        '
        Me.btnWeightTracker.Location = New System.Drawing.Point(34, 223)
        Me.btnWeightTracker.Name = "btnWeightTracker"
        Me.btnWeightTracker.Size = New System.Drawing.Size(222, 36)
        Me.btnWeightTracker.TabIndex = 8
        Me.btnWeightTracker.Text = "Weight Tracker"
        Me.btnWeightTracker.UseVisualStyleBackColor = True
        '
        'btnWeekPlan
        '
        Me.btnWeekPlan.Location = New System.Drawing.Point(34, 265)
        Me.btnWeekPlan.Name = "btnWeekPlan"
        Me.btnWeekPlan.Size = New System.Drawing.Size(222, 36)
        Me.btnWeekPlan.TabIndex = 9
        Me.btnWeekPlan.Text = "Weekly Plan"
        Me.btnWeekPlan.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(305, 28)
        Me.MenuStrip1.TabIndex = 10
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
        'txtHeightin
        '
        Me.txtHeightin.Location = New System.Drawing.Point(202, 36)
        Me.txtHeightin.Name = "txtHeightin"
        Me.txtHeightin.Size = New System.Drawing.Size(29, 22)
        Me.txtHeightin.TabIndex = 11
        Me.txtHeightin.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ft."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "in"
        '
        'UserInputForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 326)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHeightin)
        Me.Controls.Add(Me.btnWeekPlan)
        Me.Controls.Add(Me.btnWeightTracker)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtHeightft)
        Me.Controls.Add(Me.btnCalories)
        Me.Controls.Add(Me.btnBMI)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "UserInputForm"
        Me.Text = "User Input"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeight As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents btnBMI As Button
    Friend WithEvents btnCalories As Button
    Friend WithEvents txtHeightft As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents btnWeightTracker As Button
    Friend WithEvents btnWeekPlan As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtHeightin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
