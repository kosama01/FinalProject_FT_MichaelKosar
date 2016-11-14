Public Class UserInputForm
    Private userWeight As Decimal
    Private userHeight As Decimal
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnBMIBFP_Click(sender As Object, e As EventArgs) Handles btnBMIBFP.Click
        Try
            userHeight = CDec(txtHeight.Text)
            userWeight = CDec(txtWeight.Text)
            BMIBFIForm.
            BMIBFIForm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Height oe Weight not correctly entered")
        End Try


    End Sub
End Class
