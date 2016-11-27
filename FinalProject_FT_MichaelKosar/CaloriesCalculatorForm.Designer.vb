<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaloriesCalculatorForm
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
        Me.libFood = New System.Windows.Forms.ListBox()
        Me.libExcercises = New System.Windows.Forms.ListBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCalories = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCalories = New System.Windows.Forms.TextBox()
        Me.btnAddFood = New System.Windows.Forms.Button()
        Me.btnAddExcercise = New System.Windows.Forms.Button()
        Me.btnCalCalories = New System.Windows.Forms.Button()
        Me.lblRemainingCalories = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRemoveFood = New System.Windows.Forms.Button()
        Me.btnRemoveExcercise = New System.Windows.Forms.Button()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'libFood
        '
        Me.libFood.FormattingEnabled = True
        Me.libFood.ItemHeight = 16
        Me.libFood.Location = New System.Drawing.Point(351, 104)
        Me.libFood.Name = "libFood"
        Me.libFood.Size = New System.Drawing.Size(186, 116)
        Me.libFood.TabIndex = 3
        '
        'libExcercises
        '
        Me.libExcercises.FormattingEnabled = True
        Me.libExcercises.ItemHeight = 16
        Me.libExcercises.Location = New System.Drawing.Point(351, 236)
        Me.libExcercises.Name = "libExcercises"
        Me.libExcercises.Size = New System.Drawing.Size(187, 132)
        Me.libExcercises.TabIndex = 4
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(23, 44)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 17)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Name"
        '
        'lblCalories
        '
        Me.lblCalories.AutoSize = True
        Me.lblCalories.Location = New System.Drawing.Point(23, 83)
        Me.lblCalories.Name = "lblCalories"
        Me.lblCalories.Size = New System.Drawing.Size(59, 17)
        Me.lblCalories.TabIndex = 6
        Me.lblCalories.Text = "Calories"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(126, 41)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 22)
        Me.txtName.TabIndex = 7
        '
        'txtCalories
        '
        Me.txtCalories.Location = New System.Drawing.Point(126, 78)
        Me.txtCalories.Name = "txtCalories"
        Me.txtCalories.Size = New System.Drawing.Size(100, 22)
        Me.txtCalories.TabIndex = 8
        '
        'btnAddFood
        '
        Me.btnAddFood.Location = New System.Drawing.Point(26, 130)
        Me.btnAddFood.Name = "btnAddFood"
        Me.btnAddFood.Size = New System.Drawing.Size(86, 23)
        Me.btnAddFood.TabIndex = 9
        Me.btnAddFood.Text = "Add Food"
        Me.btnAddFood.UseVisualStyleBackColor = True
        '
        'btnAddExcercise
        '
        Me.btnAddExcercise.Location = New System.Drawing.Point(133, 130)
        Me.btnAddExcercise.Name = "btnAddExcercise"
        Me.btnAddExcercise.Size = New System.Drawing.Size(129, 23)
        Me.btnAddExcercise.TabIndex = 10
        Me.btnAddExcercise.Text = "Add Excercise"
        Me.btnAddExcercise.UseVisualStyleBackColor = True
        '
        'btnCalCalories
        '
        Me.btnCalCalories.Location = New System.Drawing.Point(26, 289)
        Me.btnCalCalories.Name = "btnCalCalories"
        Me.btnCalCalories.Size = New System.Drawing.Size(217, 38)
        Me.btnCalCalories.TabIndex = 11
        Me.btnCalCalories.Text = "Calculate Remaining Calories"
        Me.btnCalCalories.UseVisualStyleBackColor = True
        '
        'lblRemainingCalories
        '
        Me.lblRemainingCalories.AutoSize = True
        Me.lblRemainingCalories.Location = New System.Drawing.Point(205, 351)
        Me.lblRemainingCalories.Name = "lblRemainingCalories"
        Me.lblRemainingCalories.Size = New System.Drawing.Size(0, 17)
        Me.lblRemainingCalories.TabIndex = 12
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(591, 28)
        Me.MenuStrip1.TabIndex = 13
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
        'btnRemoveFood
        '
        Me.btnRemoveFood.Location = New System.Drawing.Point(26, 159)
        Me.btnRemoveFood.Name = "btnRemoveFood"
        Me.btnRemoveFood.Size = New System.Drawing.Size(86, 45)
        Me.btnRemoveFood.TabIndex = 14
        Me.btnRemoveFood.Text = "Remove Food"
        Me.btnRemoveFood.UseVisualStyleBackColor = True
        '
        'btnRemoveExcercise
        '
        Me.btnRemoveExcercise.Location = New System.Drawing.Point(133, 159)
        Me.btnRemoveExcercise.Name = "btnRemoveExcercise"
        Me.btnRemoveExcercise.Size = New System.Drawing.Size(129, 45)
        Me.btnRemoveExcercise.TabIndex = 15
        Me.btnRemoveExcercise.Text = "Remove Excercise"
        Me.btnRemoveExcercise.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(43, 255)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(59, 21)
        Me.radMale.TabIndex = 16
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(141, 255)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(75, 21)
        Me.radFemale.TabIndex = 17
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(40, 230)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(37, 17)
        Me.lblAge.TabIndex = 18
        Me.lblAge.Text = "Age:"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(133, 227)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 22)
        Me.txtAge.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 351)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Remaining calories:"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(348, 67)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(0, 17)
        Me.lblWeight.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(348, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Weight"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(454, 67)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(0, 17)
        Me.lblHeight.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(454, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Height"
        '
        'CaloriesCalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 404)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.radFemale)
        Me.Controls.Add(Me.radMale)
        Me.Controls.Add(Me.btnRemoveExcercise)
        Me.Controls.Add(Me.btnRemoveFood)
        Me.Controls.Add(Me.lblRemainingCalories)
        Me.Controls.Add(Me.btnCalCalories)
        Me.Controls.Add(Me.btnAddExcercise)
        Me.Controls.Add(Me.btnAddFood)
        Me.Controls.Add(Me.txtCalories)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblCalories)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.libExcercises)
        Me.Controls.Add(Me.libFood)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CaloriesCalculatorForm"
        Me.Text = "CaloriesCalculatorForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents libFood As ListBox
    Friend WithEvents libExcercises As ListBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblCalories As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCalories As TextBox
    Friend WithEvents btnAddFood As Button
    Friend WithEvents btnAddExcercise As Button
    Friend WithEvents btnCalCalories As Button
    Friend WithEvents lblRemainingCalories As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnRemoveFood As Button
    Friend WithEvents btnRemoveExcercise As Button
    Friend WithEvents radMale As RadioButton
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents lblAge As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents Label5 As Label
End Class
