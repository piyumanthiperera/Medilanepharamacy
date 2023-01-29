Public Class frmsearch
    Public strMName As String
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        strMName = TxtSearch.Text
        Me.Close()
    End Sub

    Private Sub frmsearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtSearch.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class