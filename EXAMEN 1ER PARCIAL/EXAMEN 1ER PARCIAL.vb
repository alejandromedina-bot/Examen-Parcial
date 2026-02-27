Public Class Form1
    Private Sub CALCULAR_Click(sender As Object, e As EventArgs) Handles CALCULAR.Click
        Dim Num1 As Integer = Integer.Parse(TextBox1.Text)
        Dim Num2 As Integer = Integer.Parse(TextBox2.Text)

        Dim Promedio As Integer = (Num1 + Num2) / 2
        Label4.Text = Promedio.ToString()
    End Sub
End Class
