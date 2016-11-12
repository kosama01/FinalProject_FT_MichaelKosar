<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BMIBFIForm
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
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.lblBMI = New System.Windows.Forms.Label()
        Me.lblBFP = New System.Windows.Forms.Label()
        Me.lblCurrBMI = New System.Windows.Forms.Label()
        Me.lblIdealBMI = New System.Windows.Forms.Label()
        Me.lblCurrBFP = New System.Windows.Forms.Label()
        Me.lblIdealBFP = New System.Windows.Forms.Label()
        Me.cboIdeal = New System.Windows.Forms.CheckBox()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.lblIdeal = New System.Windows.Forms.Label()
        Me.lblIdealWeight = New System.Windows.Forms.Label()
        Me.lblCurrentWeight = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(36, 35)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(59, 21)
        Me.radMale.TabIndex = 0
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(159, 35)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(75, 21)
        Me.radFemale.TabIndex = 1
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'lblBMI
        '
        Me.lblBMI.AutoSize = True
        Me.lblBMI.Location = New System.Drawing.Point(33, 208)
        Me.lblBMI.Name = "lblBMI"
        Me.lblBMI.Size = New System.Drawing.Size(31, 17)
        Me.lblBMI.TabIndex = 2
        Me.lblBMI.Text = "BMI"
        '
        'lblBFP
        '
        Me.lblBFP.AutoSize = True
        Me.lblBFP.Location = New System.Drawing.Point(33, 241)
        Me.lblBFP.Name = "lblBFP"
        Me.lblBFP.Size = New System.Drawing.Size(34, 17)
        Me.lblBFP.TabIndex = 3
        Me.lblBFP.Text = "BFP"
        '
        'lblCurrBMI
        '
        Me.lblCurrBMI.AutoSize = True
        Me.lblCurrBMI.Location = New System.Drawing.Point(116, 208)
        Me.lblCurrBMI.Name = "lblCurrBMI"
        Me.lblCurrBMI.Size = New System.Drawing.Size(0, 17)
        Me.lblCurrBMI.TabIndex = 4
        '
        'lblIdealBMI
        '
        Me.lblIdealBMI.AutoSize = True
        Me.lblIdealBMI.Location = New System.Drawing.Point(224, 208)
        Me.lblIdealBMI.Name = "lblIdealBMI"
        Me.lblIdealBMI.Size = New System.Drawing.Size(0, 17)
        Me.lblIdealBMI.TabIndex = 5
        '
        'lblCurrBFP
        '
        Me.lblCurrBFP.AutoSize = True
        Me.lblCurrBFP.Location = New System.Drawing.Point(116, 238)
        Me.lblCurrBFP.Name = "lblCurrBFP"
        Me.lblCurrBFP.Size = New System.Drawing.Size(0, 17)
        Me.lblCurrBFP.TabIndex = 6
        '
        'lblIdealBFP
        '
        Me.lblIdealBFP.AutoSize = True
        Me.lblIdealBFP.Location = New System.Drawing.Point(224, 238)
        Me.lblIdealBFP.Name = "lblIdealBFP"
        Me.lblIdealBFP.Size = New System.Drawing.Size(0, 17)
        Me.lblIdealBFP.TabIndex = 7
        '
        'cboIdeal
        '
        Me.cboIdeal.AutoSize = True
        Me.cboIdeal.Location = New System.Drawing.Point(36, 74)
        Me.cboIdeal.Name = "cboIdeal"
        Me.cboIdeal.Size = New System.Drawing.Size(60, 21)
        Me.cboIdeal.TabIndex = 9
        Me.cboIdeal.Text = "Ideal"
        Me.cboIdeal.UseVisualStyleBackColor = True
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(104, 127)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(55, 17)
        Me.lblCurrent.TabIndex = 10
        Me.lblCurrent.Text = "Current"
        '
        'lblIdeal
        '
        Me.lblIdeal.AutoSize = True
        Me.lblIdeal.Location = New System.Drawing.Point(221, 127)
        Me.lblIdeal.Name = "lblIdeal"
        Me.lblIdeal.Size = New System.Drawing.Size(38, 17)
        Me.lblIdeal.TabIndex = 11
        Me.lblIdeal.Text = "Ideal"
        '
        'lblIdealWeight
        '
        Me.lblIdealWeight.AutoSize = True
        Me.lblIdealWeight.Location = New System.Drawing.Point(224, 170)
        Me.lblIdealWeight.Name = "lblIdealWeight"
        Me.lblIdealWeight.Size = New System.Drawing.Size(0, 17)
        Me.lblIdealWeight.TabIndex = 14
        '
        'lblCurrentWeight
        '
        Me.lblCurrentWeight.AutoSize = True
        Me.lblCurrentWeight.Location = New System.Drawing.Point(116, 170)
        Me.lblCurrentWeight.Name = "lblCurrentWeight"
        Me.lblCurrentWeight.Size = New System.Drawing.Size(0, 17)
        Me.lblCurrentWeight.TabIndex = 13
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(33, 170)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(52, 17)
        Me.lblWeight.TabIndex = 12
        Me.lblWeight.Text = "Weight"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(328, 28)
        Me.MenuStrip1.TabIndex = 15
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
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(175, 75)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 16
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'BMIBFIForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 294)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lblIdealWeight)
        Me.Controls.Add(Me.lblCurrentWeight)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblIdeal)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.cboIdeal)
        Me.Controls.Add(Me.lblIdealBFP)
        Me.Controls.Add(Me.lblCurrBFP)
        Me.Controls.Add(Me.lblIdealBMI)
        Me.Controls.Add(Me.lblCurrBMI)
        Me.Controls.Add(Me.lblBFP)
        Me.Controls.Add(Me.lblBMI)
        Me.Controls.Add(Me.radFemale)
        Me.Controls.Add(Me.radMale)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "BMIBFIForm"
        Me.Text = "BMIBFIForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radMale As RadioButton
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents lblBMI As Label
    Friend WithEvents lblBFP As Label
    Friend WithEvents lblCurrBMI As Label
    Friend WithEvents lblIdealBMI As Label
    Friend WithEvents lblCurrBFP As Label
    Friend WithEvents lblIdealBFP As Label
    Friend WithEvents cboIdeal As CheckBox
    Friend WithEvents lblCurrent As Label
    Friend WithEvents lblIdeal As Label
    Friend WithEvents lblIdealWeight As Label
    Friend WithEvents lblCurrentWeight As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnShow As Button
End Class
