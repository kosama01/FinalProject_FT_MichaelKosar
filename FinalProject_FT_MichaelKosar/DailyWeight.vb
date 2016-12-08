Public Class DailyWeight
    Private mDay As Date
    Private mWeight As Decimal
    Private mGoalWeigth As Decimal
    Private mDifferential As Decimal

    Public ReadOnly Property Day() As Date
        Get
            Return mDay
        End Get
    End Property

    Public ReadOnly Property Weight() As Decimal
        Get
            Return mWeight
        End Get
    End Property

    Public ReadOnly Property GoalWeight() As Decimal
        Get
            Return mGoalWeigth
        End Get
    End Property

    Public ReadOnly Property Differential() As Decimal
        Get
            Return mDifferential
        End Get
    End Property

    Public Sub New(ByVal pDay As Date, ByVal pWeight As Decimal, ByVal pGoalWeight As Decimal, ByVal pDifferential As Decimal)
        mDay = pDay
        mWeight = pWeight
        mGoalWeigth = pGoalWeight
        mDifferential = pDifferential
    End Sub

    Public Sub New(ByVal pDailyWeight As DailyWeight)
        mDay = pDailyWeight.Day
        mWeight = pDailyWeight.Weight
        mGoalWeigth = pDailyWeight.GoalWeight
        mDifferential = pDailyWeight.Differential
    End Sub
    Public Overrides Function ToString() As String
        Return Day & "," & Weight & "," & GoalWeight & "," & Differential
    End Function
End Class
