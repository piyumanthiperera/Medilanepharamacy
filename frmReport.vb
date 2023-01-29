Public Class frmReport
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pharmacy1DataSet1.tblMediStok' table. You can move, or remove it, as needed.
        Me.tblMediStokTableAdapter.Fill(Me.Pharmacy1DataSet1.tblMediStok)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class