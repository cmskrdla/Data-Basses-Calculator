Imports System.CodeDom
Imports System.Diagnostics.CodeAnalysis
Imports System.Globalization
Imports System.Security.Cryptography.Xml
Imports System.Text

Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        btnequalto = False

    End Sub
    Dim btnequalto As New Boolean

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        TextBox1.AppendText("0")
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        TextBox1.AppendText("1")
    End Sub

    Private Sub btnPi_Click(sender As Object, e As EventArgs) Handles btnPi.Click
        TextBox1.AppendText("3.14159")
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

    Dim number4 As Double
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If TextBox1.Text.Length = 0 Then
            Exit Sub
        Else TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        add()
        number3 = number4
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
        TextBox1.Text = number3
    End Sub

    Private Function add()
        getnumber1()
        TextBox1.Clear()
        'read line
        getNumber2()
        TextBox1.Clear()
        number4 = number1 + number2
        Return number4
    End Function

    'numbers inserted and named by Clare, Appended and linked by Bern. 


    ''button1 will be the 0 button
    ''button2 will be the 1 btn
    ''button3 will be 23
    ''button4 will be 4

    ''When we're done with this, it will be a calculator 

End Class
