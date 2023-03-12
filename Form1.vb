Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Lp1, r1, r2 As Double
        Lp1 = TxtLp1.Text
        r1 = TxtR1.Text
        r2 = TxtR2.Text
        Dim d As Double = r2 / r1
        PointSourceTxt.Text = Lp1 - 20 * Math.Log10(d)
        LineSourceTxt.Text = Lp1 - 10 * Math.Log10(d)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        PointSourceTxt.Clear()
        LineSourceTxt.Clear()
        TxtR1.Clear()
        TxtR2.Clear()
        TxtLp1.Clear()
    End Sub
End Class
