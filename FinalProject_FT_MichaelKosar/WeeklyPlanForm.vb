Imports System.IO

Public Class WeeklyPlanForm
    Private activityMon As New List(Of String)
    Private activityTue As New List(Of String)
    Private activityWed As New List(Of String)
    Private activityThu As New List(Of String)
    Private activityFri As New List(Of String)
    Private activitySat As New List(Of String)
    Private activitySun As New List(Of String)
    Private fileMonday As String = "Monday.txt"
    Private fileTuesday As String = "Tuesday.txt"
    Private fileWednesday As String = "Wednesday.txt"
    Private fileThursday As String = "Thursday.txt"
    Private fileFriday As String = "Friday.txt"
    Private fileSaturday As String = "Saturday.txt"
    Private fileSunday As String = "Sunday.txt"
    Dim activityReadFile As StreamReader
    Dim activityWriteFile As StreamWriter

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

    Private Sub WeeklyPlanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lineCount As Integer
        Try
            lineCount = File.ReadAllLines(fileMonday).Length
            activityReadFile = File.OpenText(fileMonday)
            For counter As Integer = 0 To (lineCount - 1)
                activityMon.Add(activityReadFile.ReadLine())
            Next
            activityReadFile.Close()
        Catch ex As Exception

        End Try
        Try
            lineCount = File.ReadAllLines(fileTuesday).Length
            activityReadFile = File.OpenText(fileTuesday)
            For counter As Integer = 0 To (lineCount - 1)
                activityTue.Add(activityReadFile.ReadLine())
            Next
            activityReadFile.Close()
        Catch ex As Exception

        End Try
        Try
            lineCount = File.ReadAllLines(fileWednesday).Length
            activityReadFile = File.OpenText(fileWednesday)
            For counter As Integer = 0 To (lineCount - 1)
                activityWed.Add(activityReadFile.ReadLine())
            Next
            activityReadFile.Close()
        Catch ex As Exception

        End Try
        Try
            lineCount = File.ReadAllLines(fileThursday).Length
            activityReadFile = File.OpenText(fileThursday)
            For counter As Integer = 0 To (lineCount - 1)
                activityThu.Add(activityReadFile.ReadLine())
            Next
            activityReadFile.Close()
        Catch ex As Exception

        End Try
        Try
            lineCount = File.ReadAllLines(fileFriday).Length
            activityReadFile = File.OpenText(fileFriday)
            For counter As Integer = 0 To (lineCount - 1)
                activityFri.Add(activityReadFile.ReadLine())
            Next
            activityReadFile.Close()
        Catch ex As Exception

        End Try
        Try
            lineCount = File.ReadAllLines(fileSaturday).Length
            activityReadFile = File.OpenText(fileSaturday)
            For counter As Integer = 0 To (lineCount - 1)
                activitySat.Add(activityReadFile.ReadLine())
            Next
            activityReadFile.Close()
        Catch ex As Exception

        End Try
        Try
            lineCount = File.ReadAllLines(fileSunday).Length
            activityReadFile = File.OpenText(fileSunday)
            For counter As Integer = 0 To (lineCount - 1)
                activitySun.Add(activityReadFile.ReadLine())
            Next
            activityReadFile.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form_FromClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        System.IO.File.WriteAllText(fileMonday, "")
        activityWriteFile = File.AppendText(fileMonday)
        For Each ac In activityMon
            activityWriteFile.WriteLine(ac)
        Next
        activityWriteFile.Close()
        System.IO.File.WriteAllText(fileTuesday, "")
        activityWriteFile = File.AppendText(fileTuesday)
        For Each ac In activityTue
            activityWriteFile.WriteLine(ac)
        Next
        activityWriteFile.Close()
        System.IO.File.WriteAllText(fileWednesday, "")
        activityWriteFile = File.AppendText(fileWednesday)
        For Each ac In activityWed
            activityWriteFile.WriteLine(ac)
        Next
        activityWriteFile.Close()
        System.IO.File.WriteAllText(fileThursday, "")
        activityWriteFile = File.AppendText(fileThursday)
        For Each ac In activityThu
            activityWriteFile.WriteLine(ac)
        Next
        activityWriteFile.Close()
        System.IO.File.WriteAllText(fileFriday, "")
        activityWriteFile = File.AppendText(fileFriday)
        For Each ac In activityFri
            activityWriteFile.WriteLine(ac)
        Next
        activityWriteFile.Close()
        System.IO.File.WriteAllText(fileSaturday, "")
        activityWriteFile = File.AppendText(fileSaturday)
        For Each ac In activitySat
            activityWriteFile.WriteLine(ac)
        Next
        activityWriteFile.Close()
        System.IO.File.WriteAllText(fileSunday, "")
        activityWriteFile = File.AppendText(fileSunday)
        For Each ac In activitySun
            activityWriteFile.WriteLine(ac)
        Next
        activityWriteFile.Close()
        Me.Dispose()
    End Sub

End Class