Public Class Food
    Private mName As String
    Private mCalories As Decimal
    Public ReadOnly Property Name() As String
        Get
            Return mName
        End Get
    End Property
    Public ReadOnly Property Calories() As Integer
        Get
            Return mCalories
        End Get
    End Property
    Public Sub New(ByVal pName As String, ByVal pCalories As Decimal)
        mName = pName
        mCalories = pCalories
    End Sub

    Public Overrides Function ToString() As String
        Return Name & ", " & Calories & " calories"
    End Function

End Class
