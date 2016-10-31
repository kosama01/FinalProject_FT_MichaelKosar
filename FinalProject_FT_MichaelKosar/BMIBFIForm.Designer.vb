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
        Me.lblBMI.Location = New System.Drawing.Point(30, 173)
        Me.lblBMI.Name = "lblBMI"
        Me.lblBMI.Size = New System.Drawing.Size(31, 17)
        Me.lblBMI.TabIndex = 2
        Me.lblBMI.Text = "BMI"
        '
        'lblBFP
        '
        Me.lblBFP.AutoSize = True
        Me.lblBFP.Location = New System.Drawing.Point(30, 222)
        Me.lblBFP.Name = "lblBFP"
        Me.lblBFP.Size = New System.Drawing.Size(34, 17)
        Me.lblBFP.TabIndex = 3
        Me.lblBFP.Text = "BFP"
        '
        'lblCurrBMI
        '
        Me.lblCurrBMI.AutoSize = True
        Me.lblCurrBMI.Location = New System.Drawing.Point(113, 173)
        Me.lblCurrBMI.Name = "lblCurrBMI"
        Me.lblCurrBMI.Size = New System.Drawing.Size(0, 17)
        Me.lblCurrBMI.TabIndex = 4
        '
        'lblIdealBMI
        '
        Me.lblIdealBMI.AutoSize = True
        Me.lblIdealBMI.Location = New System.Drawing.Point(221, 173)
        Me.lblIdealBMI.Name = "lblIdealBMI"
        Me.lblIdealBMI.Size = New System.Drawing.Size(0, 17)
        Me.lblIdealBMI.TabIndex = 5
        '
        'lblCurrBFP
        '
        Me.lblCurrBFP.AutoSize = True
        Me.lblCurrBFP.Location = New System.Drawing.Point(113, 219)
        Me.lblCurrBFP.Name = "lblCurrBFP"
        Me.lblCurrBFP.Size = New System.Drawing.Size(0, 17)
        Me.lblCurrBFP.TabIndex = 6
        '
        'lblIdealBFP
        '
        Me.lblIdealBFP.AutoSize = True
        Me.lblIdealBFP.Location = New System.Drawing.Point(221, 219)
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
        Me.lblCurrent.Location = New System.Drawing.Point(113, 127)
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
        'BMIBFIForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 294)
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
        Me.Name = "BMIBFIForm"
        Me.Text = "BMIBFIForm"
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
End Class
