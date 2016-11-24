Public Class BMIForm
    Public userWeight As Decimal
    Public userHeight As Decimal
    Private Sub BMIBFIForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim metricWeight As Decimal = 0.453 * userWeight
        Dim metricHeight As Decimal = 0.0254 * userHeight
        Dim BMI As Decimal
        Dim idealWeight As Decimal
        BMI = metricWeight / (metricHeight * metricHeight)
        lblCurrBMI.Text = (BMI / 100).ToString("P")
        lblCurrentWeight.Text = userWeight & " lbs"
        If cboNormalBMI.Checked Then
            If BMI > 24.9 Then
                idealWeight = 24.9 * metricHeight * metricHeight / 0.45
                lblIdealWeight.Text = idealWeight.ToString("d") & " lbs"
                lblIdealBMI.Text = "24.9%"
                lblStatus.Text = "You are overweight"
            ElseIf BMI < 18.5 Then
                idealWeight = 24.9 * metricHeight * metricHeight / 0.45
                lblIdealWeight.Text = idealWeight.ToString("d") & " lbs"
                lblIdealBMI.Text = "18.5%"
                lblStatus.Text = "You are underweight"
            Else
                idealWeight = userWeight
                lblIdealWeight.Text = idealWeight.ToString("d") & " lbs"
                lblIdealBMI.Text = (BMI / 100).ToString("p")
                lblStatus.Text = "Your weight is normal"
            End If
        Else
            If BMI > 24.9 Then
                lblStatus.Text = "You are overweight"
            ElseIf BMI < 18.5 Then
                lblStatus.Text = "You are underweight"
            Else
                lblStatus.Text = "Your weight is normal"
            End If
            lblIdealBMI.Text = ""
            lblIdealWeight.Text = ""
        End If

    End Sub

End Class