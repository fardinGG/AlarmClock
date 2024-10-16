Public Class DigitLED
    Private maxNumber As Integer
    Private currentNumber As Integer
    Private _digit As Integer


    Public Sub New()
        maxNumber = 9
        ' Initialize component (including label1)
        InitializeComponent()
    End Sub
    Public Property CurrentDigit As Integer
        Get
            Return currentNumber
        End Get
        Set(value As Integer)
            currentNumber = value
            SetDigit(value)
        End Set
    End Property


    Public Property MaxDigit As Integer
        Get
            Return maxNumber
        End Get
        Set(value As Integer)
            maxNumber = value
        End Set
    End Property

    Public Property Digit As Integer
        Get
            Return _digit
        End Get
        Set(value As Integer)
            If value >= 0 AndAlso value <= maxNumber Then
                _digit = value
                Label1.Text = _digit.ToString()
            Else
                Throw New ArgumentOutOfRangeException($"Digit must be between 0 and {MaxDigit}.")
            End If
        End Set
    End Property

    Public Sub SetDigit(value As Integer)

        Me.Digit = value
        currentNumber = Me.Digit
    End Sub
    Public Sub ColorDigit(value As Integer)

    End Sub

    Public Function GetDigit() As Integer
        Return currentNumber
    End Function
End Class



