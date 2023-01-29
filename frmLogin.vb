Imports System.Data.OleDb
Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        con.Open()
        Dim cmuser As New OleDbCommand
        Dim aduser As New OleDbDataAdapter
        Dim ds As New DataSet
        Dim n As Integer = 0
        cmuser.Connection = con
        cmuser.CommandText =
            "SELECT*from tbluser where username like '%" _
            & txtUserName.Text.ToString & "%' AND  password like '%" _
            & txtpassword.Text.ToString & "%'"
        aduser.SelectCommand = cmuser
        aduser.Fill(ds, "tbluser")
        n = ds.Tables("tbluser").Rows.Count
        con.Close()
        If n = 1 Then
            Dim frmHome As New frmHome
            frmHome.ShowDialog()
            Me.Close()
        Else
            MessageBox.Show("User name Or Password is Incorrect")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtUserName.Clear()
        txtpassword.Clear()
        txtMsg.Clear()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class