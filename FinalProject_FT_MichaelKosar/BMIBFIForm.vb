Public Class BMIBFIForm
    Private userWeight As Decimal
    Private userHeight As Decimal
    Private Sub BMIBFIForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Function NewUser(ByVal pWeight As Decimal, ByVal pHeight As Decimal) As Boolean
        Try
            userWeight = 0.45 * pWeight
            userHeight = 0.025 * pHeight
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim gender As Integer
        Dim metricWieght As Decimal = userWeight
        Dim userBMI
        If radFemale.Checked = 1 Then
            gender = 1
        ElseIf radMale.Checked = 1 Then
            gender = 2
        Else
            lblStatus.Text = "No gender selected"
            Return
        End If


    End Sub
End Class