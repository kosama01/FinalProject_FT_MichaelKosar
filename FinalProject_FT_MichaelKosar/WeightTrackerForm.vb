Public Class WeightTrackerForm
    Public weight As Decimal
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub WeightTrackerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WeightTrackerDataSet.Weight' table. You can move, or remove it, as needed.
        Me.WeightTableAdapter.Fill(Me.WeightTrackerDataSet.Weight)
        txtWeight.Text = weight
        txtWeightGoal.Text = weight
        dtpDate.Value = DateAndTime.Today
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim table As WeightTrackerDataSet.WeightDataTable
            Dim adapter As New WeightTrackerDataSetTableAdapters.WeightTableAdapter
            table = adapter.GetData()
            Dim a As WeightTrackerDataSet.WeightRow = table.FindBy_Date(dtpDate.Value)
            If a Is Nothing Then
                WeightTableAdapter.Insert(dtpDate.Value, CDec(txtWeight.Text), CDec(txtWeightGoal.Text), (CDec(txtWeightGoal.Text) - CDec(txtWeight.Text)))
                Me.WeightTableAdapter.Fill(Me.WeightTrackerDataSet.Weight)
            Else
                Dim response As MsgBoxResult
                response = MsgBox("Do you want to modify the existing weight for that date?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
                If response = MsgBoxResult.Yes Then
                    a.Weight = CDec(txtWeight.Text)
                    WeightTableAdapter.Update(a)
                    Me.WeightTableAdapter.Fill(Me.WeightTrackerDataSet.Weight)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub
End Class