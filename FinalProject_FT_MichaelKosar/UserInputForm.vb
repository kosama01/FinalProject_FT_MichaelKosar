Public Class UserInputForm
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub btnBMIBFP_Click(sender As Object, e As EventArgs) Handles btnBMI.Click
        Try
            BMIForm.userHeight = CDec(txtHeightft.Text) * 12 + CDec(txtHeightin.Text)
            BMIForm.userWeight = CDec(txtWeight.Text)
            BMIForm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Height or Weight not correctly entered")
        End Try
    End Sub

    Private Sub btnWeightTracker_Click(sender As Object, e As EventArgs) Handles btnWeightTracker.Click
        WeightTrackerForm.ShowDialog()
    End Sub

    Private Sub btnCalories_Click(sender As Object, e As EventArgs) Handles btnCalories.Click
        Try
            CaloriesCalculatorForm.userHeight = CDec(txtHeightft.Text) * 12 + CDec(txtHeightin.Text)
            CaloriesCalculatorForm.userWeight = CDec(txtWeight.Text)
            CaloriesCalculatorForm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Height or Weight not correctly entered")
        End Try
    End Sub

    Private Sub btnWeekPlan_Click(sender As Object, e As EventArgs) Handles btnWeekPlan.Click
        WeeklyPlanForm.ShowDialog()
    End Sub
End Class
