Public Class BMIBFIForm
    Public userWeight As Decimal
    Public userHeight As Decimal
    Public Const filenameBMI As String = "BMI.txt"
    Private Sub BMIBFIForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWeight.Text = userWeight
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim gender As Integer
        Dim metricWeight As Decimal = 0.45 * userWeight
        Dim metricHeight As Decimal = 0.025 * userHeight
        Dim BMI As Decimal
        If radFemale.Checked = 1 Then
            gender = 1
        ElseIf radMale.Checked = 1 Then
            gender = 2
        Else
            lblStatus.Text = "No gender selected"
            Return
        End If
        BMI = metricWeight / (metricHeight * metricHeight)
        lblCurrBMI.Text = BMI
    End Sub
End Class