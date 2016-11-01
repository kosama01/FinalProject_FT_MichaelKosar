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
        Me.btnFood = New System.Windows.Forms.Button()
        Me.btnExcercise = New System.Windows.Forms.Button()
        Me.btnCalCalories = New System.Windows.Forms.Button()
        Me.lblRemainingCalories = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'libFood
        '
        Me.libFood.FormattingEnabled = True
        Me.libFood.ItemHeight = 16
        Me.libFood.Location = New System.Drawing.Point(351, 37)
        Me.libFood.Name = "libFood"
        Me.libFood.Size = New System.Drawing.Size(186, 116)
        Me.libFood.TabIndex = 3
        '
        'libExcercises
        '
        Me.libExcercises.FormattingEnabled = True
        Me.libExcercises.ItemHeight = 16
        Me.libExcercises.Location = New System.Drawing.Point(350, 195)
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
        Me.lblCalories.Location = New System.Drawing.Point(23, 91)
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
        Me.txtCalories.Location = New System.Drawing.Point(126, 86)
        Me.txtCalories.Name = "txtCalories"
        Me.txtCalories.Size = New System.Drawing.Size(100, 22)
        Me.txtCalories.TabIndex = 8
        '
        'btnFood
        '
        Me.btnFood.Location = New System.Drawing.Point(34, 142)
        Me.btnFood.Name = "btnFood"
        Me.btnFood.Size = New System.Drawing.Size(86, 23)
        Me.btnFood.TabIndex = 9
        Me.btnFood.Text = "Add Food"
        Me.btnFood.UseVisualStyleBackColor = True
        '
        'btnExcercise
        '
        Me.btnExcercise.Location = New System.Drawing.Point(141, 142)
        Me.btnExcercise.Name = "btnExcercise"
        Me.btnExcercise.Size = New System.Drawing.Size(110, 23)
        Me.btnExcercise.TabIndex = 10
        Me.btnExcercise.Text = "Add Excercise"
        Me.btnExcercise.UseVisualStyleBackColor = True
        '
        'btnCalCalories
        '
        Me.btnCalCalories.Location = New System.Drawing.Point(34, 253)
        Me.btnCalCalories.Name = "btnCalCalories"
        Me.btnCalCalories.Size = New System.Drawing.Size(217, 38)
        Me.btnCalCalories.TabIndex = 11
        Me.btnCalCalories.Text = "Calculate Remaining Calories"
        Me.btnCalCalories.UseVisualStyleBackColor = True
        '
        'lblRemainingCalories
        '
        Me.lblRemainingCalories.AutoSize = True
        Me.lblRemainingCalories.Location = New System.Drawing.Point(87, 303)
        Me.lblRemainingCalories.Name = "lblRemainingCalories"
        Me.lblRemainingCalories.Size = New System.Drawing.Size(0, 17)
        Me.lblRemainingCalories.TabIndex = 12
        '
        'CaloriesCalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 404)
        Me.Controls.Add(Me.lblRemainingCalories)
        Me.Controls.Add(Me.btnCalCalories)
        Me.Controls.Add(Me.btnExcercise)
        Me.Controls.Add(Me.btnFood)
        Me.Controls.Add(Me.txtCalories)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblCalories)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.libExcercises)
        Me.Controls.Add(Me.libFood)
        Me.Name = "CaloriesCalculatorForm"
        Me.Text = "CaloriesCalculatorForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents libFood As ListBox
    Friend WithEvents libExcercises As ListBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblCalories As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCalories As TextBox
    Friend WithEvents btnFood As Button
    Friend WithEvents btnExcercise As Button
    Friend WithEvents btnCalCalories As Button
    Friend WithEvents lblRemainingCalories As Label
End Class
