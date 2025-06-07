Public Class frmFactorial

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim number As Integer = CInt(txtNumber.Text)
        Dim n As Integer = 1
        Dim factorial As Long = 1

        While n <= number
            factorial *= n
            n += 1
        End While
        txtFactorial.Text = factorial.ToString("n0")


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
