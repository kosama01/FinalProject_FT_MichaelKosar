Public Class CaloriesCalculatorForm
    Public userWeight As Decimal
    Public userHeight As Decimal
    Private excercises As List(Of Excercise)
    Private foods As New List(Of Food)
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Fills the list boxes
    Private Sub FillListBoxes()
        libFood.Items.Clear()
        libExcercises.Items.Clear()
        For Each f In foods
            libFood.Items.Add(f)
        Next
        For Each e In excercises
            libExcercises.Items.Add(e)
        Next
        txtName.Text = ""
        txtCalories.Text = ""
    End Sub
    'Add food to list
    Private Sub btnAddFood_Click(sender As Object, e As EventArgs) Handles btnAddFood.Click
        Dim food As Food = New Food(txtName.Text, CDec(txtCalories.Text))
        foods.Add(food)
        FillListBoxes()
    End Sub
    'Add excercise to list
    Private Sub btnAddExcercise_Click(sender As Object, e As EventArgs) Handles btnAddExcercise.Click
        Dim excercise As Excercise = New Excercise(txtName.Text, CDec(txtCalories.Text))
        excercises.Add(excercise)
        FillListBoxes()
    End Sub
    'Removes food from list
    Private Sub btnRemoveFood_Click(sender As Object, e As EventArgs) Handles btnRemoveFood.Click
        libFood.Items.Remove(libFood.SelectedItem)
        FillListBoxes()
    End Sub
    'Removes excercise from list
    Private Sub btnRemoveExcercise_Click(sender As Object, e As EventArgs) Handles btnRemoveExcercise.Click
        libExcercises.Items.Remove(libExcercises.SelectedItem)
        FillListBoxes()
    End Sub

    Private Sub btnCalCalories_Click(sender As Object, e As EventArgs) Handles btnCalCalories.Click
        Dim dailyCalories As Decimal
        Dim metricWeight As Decimal = 0.453 * userWeight
        Dim metricHeight As Decimal = 0.0254 * userHeight
        Dim age As Integer
        Try
            age = CInt(txtAge.Text)
        Catch ex As Exception
            MessageBox.Show("Incorrect format for age")
            Return
        End Try
        If radMale.Checked() Then
            dailyCalories = 10 * metricWeight + 6.25 * metricHeight * 100 - 5 * age + 5
        ElseIf radFemale.Checked() Then
            dailyCalories = 10 * metricWeight + 6.25 * metricHeight * 100 - 5 * age - 161
        Else
            MessageBox.Show("Gender must be selected")
            Return
        End If
        lblRemainingCalories.Text = dailyCalories & " calories left"
    End Sub
End Class