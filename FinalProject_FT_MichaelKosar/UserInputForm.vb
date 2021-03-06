﻿Public Class UserInputForm
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub btnBMIBFP_Click(sender As Object, e As EventArgs) Handles btnBMI.Click
        Try
            BMIForm.userHeight = CDec(txtHeightft.Text) * 12 + CDec(txtHeightin.Text)
            BMIForm.userWeight = CDec(txtWeight.Text)
        Catch ex As Exception
            MessageBox.Show("Height or Weight not correctly entered")
            Return
        End Try
        BMIForm.ShowDialog()
    End Sub

    Private Sub btnWeightTracker_Click(sender As Object, e As EventArgs) Handles btnWeightTracker.Click
        Try
            WeightTrackerForm.weight = CDec(txtWeight.Text)
        Catch ex As Exception
            MessageBox.Show("Incorrect format for weight")
        End Try
        WeightTrackerForm.ShowDialog()
        WeightTrackerForm.firstTimeOpening = False
    End Sub

    Private Sub btnCalories_Click(sender As Object, e As EventArgs) Handles btnCalories.Click
        Try
            CaloriesCalculatorForm.userHeight = CDec(txtHeightft.Text) * 12 + CDec(txtHeightin.Text)
            CaloriesCalculatorForm.userWeight = CDec(txtWeight.Text)
        Catch ex As Exception
            MessageBox.Show("Height or Weight not correctly entered")
            Return
        End Try
        CaloriesCalculatorForm.ShowDialog()
    End Sub

    Private Sub btnWeekPlan_Click(sender As Object, e As EventArgs) Handles btnWeekPlan.Click
        WeeklyPlanForm.ShowDialog()
    End Sub

    Private Sub UserInputForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WeightTrackerForm.firstTimeOpening = True
    End Sub
End Class
