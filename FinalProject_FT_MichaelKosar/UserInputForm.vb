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
End Class
