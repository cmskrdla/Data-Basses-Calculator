Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        TextBox1.Text.Append("1")
        'Bern&Clare
    End Sub

    Private Sub btnPi_Click(sender As Object, e As EventArgs) Handles btnPi.Click

    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        TextBox1.Text = "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        TextBox1.Text = "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        TextBox1.Text = "4"

    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        TextBox1.Text = "5"

    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        TextBox1.Text = "6"

    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        TextBox1.Text = "7"

    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        TextBox1.Text = "8"

    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        TextBox1.Text = "9"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBox1.Text = ""
    End Sub

    ''button1 will be the 0 button
    ''button2 will be the 1 btn
    ''button3 will be 23
    ''button4 will be 4

    ''When we're done with this, it will be a calculator 

End Class
