Public Class frmBilling
    Private Sub btnc_Click(sender As Object, e As EventArgs) Handles btnc.Click
        Dim x, y, ans As Integer
        x = Val(txtUPrice.Text)
        y = Val(txtQty.Text)
        ans = x * y
        txtAmount.Text = ans


    End Sub
End Class