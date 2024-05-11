Imports System
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Double = Double.Parse(TextBox1.Text)
        Dim num2 As Double = Double.Parse(TextBox2.Text)
        Dim num3 As Double = Double.Parse(TextBox3.Text)

        If RadioButton1.Checked Then
            Label1.Text = CalculateMinimum(num1, num2, num3)
        ElseIf RadioButton2.Checked Then
            Label1.Text = CalculateMaximum(num1, num2, num3)
        ElseIf RadioButton3.Checked Then
            Label1.Text = CalculateAverage(num1, num2, num3)
        End If
    End Sub

    Private Function CalculateMinimum(num1 As Double, num2 As Double, num3 As Double) As String
        Return Math.Min(num1, Math.Min(num2, num3)).ToString()
    End Function

    Private Function CalculateMaximum(num1 As Double, num2 As Double, num3 As Double) As String
        Return Math.Max(num1, Math.Max(num2, num3)).ToString()
    End Function

    Private Function CalculateAverage(num1 As Double, num2 As Double, num3 As Double) As String
        Return (num1 + num2 + num3) / 3.0.ToString()
    End Function
End Class
