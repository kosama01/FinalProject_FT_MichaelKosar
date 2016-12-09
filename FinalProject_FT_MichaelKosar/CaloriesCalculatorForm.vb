Public Class CaloriesCalculatorForm
    Public userWeight As Decimal
    Public userHeight As Decimal
    Private excercises As New List(Of Excercise)
    Private foods As New List(Of Food)
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Fills the list boxes
    Private Sub FillListBoxes()
        libFood.Items.Clear()
        libExcercises.Items.Clear()
        If foods.Count > 0 Then
            For Each f In foods
                libFood.Items.Add(f)
            Next
        End If
        If excercises.Count > 0 Then
            For Each e In excercises
                libExcercises.Items.Add(e)
            Next
        End If
        txtName.Text = ""
        txtCalories.Text = ""
    End Sub
    'Add food to list
    Private Sub btnAddFood_Click(sender As Object, e As EventArgs) Handles btnAddFood.Click
        If txtName.Text = "" Then
            MessageBox.Show("There is no name for the food")
            Return
        End If
        Try
            Dim food As Food = New Food(txtName.Text, CDec(txtCalories.Text))
            foods.Add(food)
            FillListBoxes()
        Catch ex As Exception
            MessageBox.Show("Format for calories was entered incorreclty, the value most be a number")
        End Try
    End Sub
    'Add excercise to list
    Private Sub btnAddExcercise_Click(sender As Object, e As EventArgs) Handles btnAddExcercise.Click
        If txtName.Text = "" Then
            MessageBox.Show("There is no name for the excercise")
            Return
        End If
        Try
            Dim excercise As Excercise = New Excercise(txtName.Text, CDec(txtCalories.Text))
            excercises.Add(excercise)
            FillListBoxes()
        Catch ex As Exception
            MessageBox.Show("Format for calories was entered incorreclty, the value most be a number")
        End Try
    End Sub
    'Removes food from list
    Private Sub btnRemoveFood_Click(sender As Object, e As EventArgs) Handles btnRemoveFood.Click
        If libFood.SelectedIndex = -1 Then
            MessageBox.Show("No food was selected")
            Return
        End If
        foods.Remove(libFood.SelectedItem)
        FillListBoxes()
    End Sub
    'Removes excercise from list
    Private Sub btnRemoveExcercise_Click(sender As Object, e As EventArgs) Handles btnRemoveExcercise.Click
        If libExcercises.SelectedIndex = -1 Then
            MessageBox.Show("No excercise was selected")
            Return
        End If
        excercises.Remove(libExcercises.SelectedItem)
        FillListBoxes()
    End Sub

    Private Sub btnCalCalories_Click(sender As Object, e As EventArgs) Handles btnCalCalories.Click
        Dim dailyCalories As Decimal
        Dim metricWeight As Decimal = 0.453 * userWeight
        Dim metricHeight As Decimal = 0.0254 * userHeight
        Dim age As Integer
        Dim calExcercise As Decimal = 0
        Dim calFood As Decimal = 0
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
        If foods.Count > 0 Then
            For Each f In foods
                calFood += f.Calories
            Next
        End If
        If excercises.Count > 0 Then
            For Each exc In excercises
                calExcercise += exc.Calories
            Next
        End If
        dailyCalories = dailyCalories + calExcercise - calFood
        lblRemainingCalories.Text = dailyCalories & " calories left"
    End Sub

    Private Sub CaloriesCalculatorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWeight.Text = userWeight
        lblHeight.Text = CInt(userHeight / 12) & "ft " & (userHeight Mod 12) & "in"
    End Sub
End Class