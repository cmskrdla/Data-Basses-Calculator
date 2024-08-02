Imports System.CodeDom
Imports System.ComponentModel.DataAnnotations
Imports System.Diagnostics.CodeAnalysis
Imports System.Globalization
Imports System.Security.Cryptography.Xml
Imports System.Text

Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


    End Sub


    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        TextBox1.AppendText("0")
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        TextBox1.AppendText("1")
    End Sub

    Private Sub btnPi_Click(sender As Object, e As EventArgs) Handles btnPi.Click
        Dim srt As String = TextBox1.Text
        If srt.Contains("3.14159") = True Then
            MessageBox.Show("No seconds on pie!")
        ElseIf srt.Contains(".") = True Then
            Exit Sub
        Else
            TextBox1.AppendText("3.14159")
        End If
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        TextBox1.AppendText("2")
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        TextBox1.AppendText("3")
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        TextBox1.AppendText("4")

    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        TextBox1.AppendText("5")

    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        TextBox1.AppendText("6")

    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        TextBox1.AppendText("7")

    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        TextBox1.AppendText("8")

    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        TextBox1.AppendText("9")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBox1.Clear()
    End Sub
    Dim number1 As Double

    Dim number2 As Double

    Dim number3 As Double

    Dim operation As String
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If TextBox1.Text.Length = 0 Then
            Exit Sub
        Else TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)
        End If
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        getnumber1()
        TextBox1.Clear()
        operation = "add"
    End Sub
    Private Function getnumber1()
        number1 = TextBox1.Text
        Return number1
    End Function
    Private Function getNumber2()
        number2 = TextBox1.Text
        Return number2
    End Function

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        getNumber2()

        Select Case operation
            Case "add"

                TextBox1.Text = number1 + number2
            Case "subtract"

                TextBox1.Text = number1 - number2
            Case "make like a rabbit"

                TextBox1.Text = number1 * number2
            Case "With great power"
                Dim uncleben As Double = number1 ^ number2
                TextBox1.Text = uncleben

            Case "divide and conquer"
                If number2 = 0 Then
                    Panel1.BackColor = Color.Red
                    MessageBox.Show("You can't divide by 0")
                    MessageBox.Show("Self desctruct sequence initiated")
                    Beep()
                    MessageBox.Show("three")
                    Beep()
                    MessageBox.Show("two")
                    Beep()
                    MessageBox.Show("one")
                    Beep()
                    MessageBox.Show("KABOOM!!!")
                    Beep()
                    MessageBox.Show("Just kidding. But seriously, don't divide by 0")
                Else TextBox1.Text = number1 \ number2
                End If
        End Select

    End Sub
    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        getnumber1()
        TextBox1.Clear()
        operation = "subtract"
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        getnumber1()
        TextBox1.Clear()
        operation = "make like a rabbit"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        getnumber1()
        TextBox1.Clear()
        operation = "divide and conquer"
    End Sub
    Private Sub btnDPoint_Click(sender As Object, e As EventArgs) Handles btnDPoint.Click
        Dim s As String = TextBox1.Text
        If s.Contains(".") = True Then
            Exit Sub
        Else
            TextBox1.AppendText(".")
        End If

    End Sub

    Private Sub btnSquared_Click(sender As Object, e As EventArgs) Handles btnSquared.Click
        getnumber1()
        TextBox1.Text = number1 * number1
    End Sub

    Private Sub btnRecip_Click(sender As Object, e As EventArgs) Handles btnRecip.Click
        getnumber1()
        TextBox1.Text = 1 / number1
    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        getnumber1()
        TextBox1.Clear()
        operation = "With great power"
    End Sub





    'numbers inserted and named by Clare, Appended and linked by Bern. 


    ''button1 will be the 0 button
    ''button2 will be the 1 btn
    ''button3 will be 23
    ''button4 will be 4

    ''When we're done with this, it will be a calculator 

End Class
