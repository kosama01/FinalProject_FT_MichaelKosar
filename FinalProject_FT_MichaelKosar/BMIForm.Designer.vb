<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BMIForm
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
        Me.lblBMI = New System.Windows.Forms.Label()
        Me.lblCurrBMI = New System.Windows.Forms.Label()
        Me.lblIdealBMI = New System.Windows.Forms.Label()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.lblIdeal = New System.Windows.Forms.Label()
        Me.lblIdealWeight = New System.Windows.Forms.Label()
        Me.lblCurrentWeight = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cboNormalBMI = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBMI
        '
        Me.lblBMI.AutoSize = True
        Me.lblBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBMI.Location = New System.Drawing.Point(243, 117)
        Me.lblBMI.Name = "lblBMI"
        Me.lblBMI.Size = New System.Drawing.Size(47, 25)
        Me.lblBMI.TabIndex = 2
        Me.lblBMI.Text = "BMI"
        '
        'lblCurrBMI
        '
        Me.lblCurrBMI.AutoSize = True
        Me.lblCurrBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrBMI.Location = New System.Drawing.Point(243, 160)
        Me.lblCurrBMI.Name = "lblCurrBMI"
        Me.lblCurrBMI.Size = New System.Drawing.Size(0, 25)
        Me.lblCurrBMI.TabIndex = 4
        '
        'lblIdealBMI
        '
        Me.lblIdealBMI.AutoSize = True
        Me.lblIdealBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdealBMI.Location = New System.Drawing.Point(243, 198)
        Me.lblIdealBMI.Name = "lblIdealBMI"
        Me.lblIdealBMI.Size = New System.Drawing.Size(0, 25)
        Me.lblIdealBMI.TabIndex = 5
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrent.Location = New System.Drawing.Point(24, 160)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(77, 25)
        Me.lblCurrent.TabIndex = 10
        Me.lblCurrent.Text = "Current"
        '
        'lblIdeal
        '
        Me.lblIdeal.AutoSize = True
        Me.lblIdeal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdeal.Location = New System.Drawing.Point(24, 198)
        Me.lblIdeal.Name = "lblIdeal"
        Me.lblIdeal.Size = New System.Drawing.Size(54, 25)
        Me.lblIdeal.TabIndex = 11
        Me.lblIdeal.Text = "Ideal"
        '
        'lblIdealWeight
        '
        Me.lblIdealWeight.AutoSize = True
        Me.lblIdealWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdealWeight.Location = New System.Drawing.Point(118, 198)
        Me.lblIdealWeight.Name = "lblIdealWeight"
        Me.lblIdealWeight.Size = New System.Drawing.Size(0, 25)
        Me.lblIdealWeight.TabIndex = 14
        '
        'lblCurrentWeight
        '
        Me.lblCurrentWeight.AutoSize = True
        Me.lblCurrentWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentWeight.Location = New System.Drawing.Point(118, 160)
        Me.lblCurrentWeight.Name = "lblCurrentWeight"
        Me.lblCurrentWeight.Size = New System.Drawing.Size(0, 25)
        Me.lblCurrentWeight.TabIndex = 13
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(118, 117)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(74, 25)
        Me.lblWeight.TabIndex = 12
        Me.lblWeight.Text = "Weight"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(359, 28)
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
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(200, 51)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(107, 37)
        Me.btnShow.TabIndex = 16
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 273)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(359, 22)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'cboNormalBMI
        '
        Me.cboNormalBMI.AutoSize = True
        Me.cboNormalBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNormalBMI.Location = New System.Drawing.Point(38, 59)
        Me.cboNormalBMI.Name = "cboNormalBMI"
        Me.cboNormalBMI.Size = New System.Drawing.Size(136, 29)
        Me.cboNormalBMI.TabIndex = 18
        Me.cboNormalBMI.Text = "Normal BMI"
        Me.cboNormalBMI.UseVisualStyleBackColor = True
        '
        'BMIForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 295)
        Me.Controls.Add(Me.cboNormalBMI)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lblIdealWeight)
        Me.Controls.Add(Me.lblCurrentWeight)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblIdeal)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.lblIdealBMI)
        Me.Controls.Add(Me.lblCurrBMI)
        Me.Controls.Add(Me.lblBMI)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "BMIForm"
        Me.Text = "BMIBFIForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBMI As Label
    Friend WithEvents lblCurrBMI As Label
    Friend WithEvents lblIdealBMI As Label
    Friend WithEvents lblCurrent As Label
    Friend WithEvents lblIdeal As Label
    Friend WithEvents lblIdealWeight As Label
    Friend WithEvents lblCurrentWeight As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnShow As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents cboNormalBMI As CheckBox
End Class
