Public Class Calculator
    Implements ICalculator

    Public Sub New()

    End Sub

    Public Function Add(number1 As Double, number2 As Double) As Double Implements ICalculator.Add
        ''Clare''
        Return number2 + number1
    End Function

    Public Function Divide(number1 As Double, number2 As Double) As Double Implements ICalculator.Divide
        Throw New NotImplementedException()
    End Function

    Public Function Multiply(number1 As Double, number2 As Double) As Double Implements ICalculator.Multiply
        Throw New NotImplementedException()
    End Function

    Public Function Squared(number1 As Double) As Double Implements ICalculator.Squared
        Throw New NotImplementedException()
    End Function

    Public Function SquareRoot(number1 As Double) As Double Implements ICalculator.SquareRoot
        Throw New NotImplementedException()
    End Function

    Public Function Subtract(number1 As Double, number2 As Double) As Double Implements ICalculator.Subtract
        Throw New NotImplementedException()
    End Function
End Class
