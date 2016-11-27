﻿Public Class WeeklyPlanForm
    Private activityMon As New List(Of String)
    Private activityTue As New List(Of String)
    Private activityWed As New List(Of String)
    Private activityThu As New List(Of String)
    Private activityFri As New List(Of String)
    Private activitySat As New List(Of String)
    Private activitySun As New List(Of String)
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CheckChanges(sender As Object, e As EventArgs) Handles radMonday.CheckedChanged, radTuesday.CheckedChanged, radWednesday.CheckedChanged, radThursday.CheckedChanged, radFriday.CheckedChanged, radSaturday.CheckedChanged, radSunday.CheckedChanged
        libDailyActivities.Items.Clear()
        If radMonday.Checked Then
            If activityMon.Count > 0 Then
                For Each ac In activityMon
                    libDailyActivities.Items.Add(ac)
                Next
            End If
        ElseIf radTuesday.Checked Then
            If activityTue.Count > 0 Then
                For Each ac In activityTue
                    libDailyActivities.Items.Add(ac)
                Next
            End If
        ElseIf radWednesday.Checked Then
            If activityWed.Count > 0 Then
                For Each ac In activityWed
                    libDailyActivities.Items.Add(ac)
                Next
            End If
        ElseIf radThursday.Checked Then
            If activityThu.Count > 0 Then
                For Each ac In activityThu
                    libDailyActivities.Items.Add(ac)
                Next
            End If
        ElseIf radFriday.Checked Then
            If activityFri.Count > 0 Then
                For Each ac In activityFri
                    libDailyActivities.Items.Add(ac)
                Next
            End If
        ElseIf radSaturday.Checked Then
            If activitySat.Count > 0 Then
                For Each ac In activitySat
                    libDailyActivities.Items.Add(ac)
                Next
            End If
        ElseIf radSunday.Checked Then
            If activitySun.Count > 0 Then
                For Each ac In activitySun
                    libDailyActivities.Items.Add(ac)
                Next
            End If
        End If
    End Sub

    Private Sub btnAddActivity_Click(sender As Object, e As EventArgs) Handles btnAddActivity.Click
        If txtActivityName.Text = "" Then
            MessageBox.Show("Activity Name was not entered")
            Return
        End If
        libDailyActivities.Items.Add(txtActivityName.Text)
        If radMonday.Checked Then
            activityMon.Add(txtActivityName.Text)
        ElseIf radTuesday.Checked Then
            activityTue.Add(txtActivityName.Text)
        ElseIf radWednesday.Checked Then
            activityWed.Add(txtActivityName.Text)
        ElseIf radThursday.Checked Then
            activityThu.Add(txtActivityName.Text)
        ElseIf radFriday.Checked Then
            activityFri.Add(txtActivityName.Text)
        ElseIf radSaturday.Checked Then
            activitySat.Add(txtActivityName.Text)
        ElseIf radSunday.Checked Then
            activitySun.Add(txtActivityName.Text)
        End If
        txtActivityName.Text = ""
    End Sub

    Private Sub btnRemoveActivity_Click(sender As Object, e As EventArgs) Handles btnRemoveActivity.Click
        If libDailyActivities.SelectedIndex = -1 Then
            MessageBox.Show("No activity has been chosen")
            Return
        End If
        If radMonday.Checked Then
            activityMon.Remove(libDailyActivities.SelectedItem)
        ElseIf radTuesday.Checked Then
            activityTue.Remove(libDailyActivities.SelectedItem)
        ElseIf radWednesday.Checked Then
            activityWed.Remove(libDailyActivities.SelectedItem)
        ElseIf radThursday.Checked Then
            activityThu.Remove(libDailyActivities.SelectedItem)
        ElseIf radFriday.Checked Then
            activityFri.Remove(libDailyActivities.SelectedItem)
        ElseIf radSaturday.Checked Then
            activitySat.Remove(libDailyActivities.SelectedItem)
        ElseIf radSunday.Checked Then
            activitySun.Remove(libDailyActivities.SelectedItem)
        End If
        libDailyActivities.Items.Remove(libDailyActivities.SelectedItem)
    End Sub
End Class