Imports System.Data.OleDb
Module Module1
    Public con As New OleDbConnection
    Sub main()
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\piumanthi\Pharmacy1.mdb"
        Dim frmLogin As New frmLogin
        frmLogin.ShowDialog()
    End Sub
End Module
