Imports System.IO

Public Class WeightTrackerForm
    Public weight As Decimal
    Private records As New Dictionary(Of Date, DailyWeight)
    Private filename As String = "Weightrecords.txt"
    Private ReadFile As StreamReader
    Private WriteFile As StreamWriter
    Public firstTimeOpening As Boolean
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub WeightTrackerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtWeight.Text = weight
        txtWeightGoal.Text = weight
        dtpDate.Value = DateAndTime.Today
        Dim lineCount As Integer
        Try
            lineCount = File.ReadAllLines(filename).Length
            ReadFile = File.OpenText(filename)
            For counter As Integer = 0 To (lineCount - 1)
                Dim line = ReadFile.ReadLine()
                Dim record() As String = line.Split(","c)
                records.Add(CDate(record(0)), New DailyWeight(CDate(record(0)), CDec(record(1)), CDec(record(2)), CDec(record(3))))
                If firstTimeOpening Then
                    WeightTableAdapter.Insert(CDate(record(0)), CDec(record(1)), CDec(record(2)), CDec(record(3)))
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            ReadFile.Close()
        Catch ex As Exception

        End Try
        WeightTableAdapter.Fill(WeightTrackerDataSet.Weight)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim table As WeightTrackerDataSet.WeightDataTable
            Dim adapter As New WeightTrackerDataSetTableAdapters.WeightTableAdapter
            table = adapter.GetData()
            Dim a As WeightTrackerDataSet.WeightRow = table.FindBy_Date(dtpDate.Value)
            If a Is Nothing Then
                WeightTableAdapter.Insert(dtpDate.Value, CDec(txtWeight.Text), CDec(txtWeightGoal.Text), (CDec(txtWeightGoal.Text) - CDec(txtWeight.Text)))
                WeightTableAdapter.Fill(WeightTrackerDataSet.Weight)
                records.Add(dtpDate.Value, New DailyWeight(dtpDate.Value, CDec(txtWeight.Text), CDec(txtWeightGoal.Text), (CDec(txtWeightGoal.Text) - CDec(txtWeight.Text))))
            Else
                Dim response As MsgBoxResult
                response = MsgBox("Do you want to modify the existing weight for that date?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
                If response = MsgBoxResult.Yes Then
                    a.Weight = CDec(txtWeight.Text)
                    a.Weight_Goal = CDec(txtWeightGoal.Text)
                    a.Difference = CDec(txtWeightGoal.Text) - CDec(txtWeight.Text)
                    WeightTableAdapter.Update(a)
                    records.Item(dtpDate.Value) = New DailyWeight(dtpDate.Value, CDec(txtWeight.Text), CDec(txtWeightGoal.Text), (CDec(txtWeightGoal.Text) - CDec(txtWeight.Text)))
                    WeightTableAdapter.Fill(WeightTrackerDataSet.Weight)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub Form_FromClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        System.IO.File.WriteAllText(filename, "")
        WriteFile = File.AppendText(filename)
        For Each r In records
            WriteFile.WriteLine(r.Value.ToString)
        Next
        WriteFile.Close()
        WeightTrackerDataSet.Clear()
        Me.Dispose()
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        records.Clear()
        WeightTrackerDataSet.Weight.Rows.Clear()
        WeightTableAdapter.DeleteAll()
    End Sub
End Class