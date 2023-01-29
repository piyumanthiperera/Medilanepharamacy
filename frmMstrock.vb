Imports System.Data.OleDb
Public Class frmMstrock
    Dim adMedi As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim n As Integer
    Dim chrDBCommand As Char
    Private Sub frmMstrock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim cmMedi As New OleDbCommand
        cmMedi.Connection = con
        cmMedi.CommandText = "SELECT * from tblMediStok"
        adMedi.SelectCommand = cmMedi
        adMedi.Fill(ds, "tblMediStok")
        n = ds.Tables("tblMediStok").Rows.Count - 1
        con.Close()
        ShowRecords()
    End Sub
    Sub ShowRecords()
        Dim drMedi As DataRow
        If n >= 0 Then
            drMedi = ds.Tables("tblMediStok").Rows(n)
            With drMedi
                txtMediCode.Text = .Item("Medi_Code")
                txtMediName.Text = .Item("Med_Name")
                txtQuantity.Text = .Item("Quantity")
                txtUnitPrice.Text = .Item("Unit_Price")
                txtDosage.Text = .Item("Dosage")
                txtMDate.Text = .Item("Manufactured_Date")
                txtEDate.Text = .Item("Expire_Date")
            End With
        End If

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        chrDBCommand = "A"
        txtMediCode.Focus()
        Call clearcontrols()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If n >= 0 Then
            chrDBCommand = "E"
            txtMediCode.Focus()
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If n >= 0 Then
            chrDBCommand = "D"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmBuilder As New OleDbCommandBuilder
        cmBuilder.DataAdapter = adMedi
        If chrDBCommand = "A" Then
            If txtMediCode.Text = "" Or txtMediCode.Text = "" Then
                'txtMsg.Text = "Please enter data before saving..."
                MessageBox.Show("Please enter data before saving...", "Messsage...")
            Else
                Dim drMedi As DataRow
                drMedi = ds.Tables("tblMediStok").NewRow
                With drMedi
                    .Item("Medi_Code") = txtMediCode.Text
                    .Item("Med_Name") = txtMediName.Text
                    .Item("Quantity") = txtQuantity.Text
                    .Item("Unit_Price") = txtUnitPrice.Text
                    .Item("Dosage") = txtDosage.Text
                    .Item("Manufactured_Date") = txtMDate.Text
                    .Item("Expire_Date") = txtEDate.Text
                End With
                ds.Tables("tblMediStok").Rows.Add(drMedi)
                adMedi.InsertCommand = cmBuilder.GetInsertCommand
                n = n + 1
                txtMsg.Text = "Data Saved Successfully..."
            End If
        ElseIf chrDBCommand = "E" Then
            Dim tbMstrock As DataTable
            Dim dcPrimarykey(0) As DataColumn
            tbMstrock = ds.Tables("tblMediStok")
            dcPrimarykey(0) = tbMstrock.Columns("Medi_Code")
            tbMstrock.PrimaryKey = dcPrimarykey
            Dim drMedi As DataRow = tbMstrock.Rows.Find(txtMediCode.Text)
            With drMedi
                .Item("Medi_Code") = txtMediCode.Text
                .Item("Med_Name") = txtMediName.Text
                .Item("Quantity") = txtQuantity.Text
                .Item("Unit_Price") = txtUnitPrice.Text
                .Item("Dosage") = txtDosage.Text
                .Item("Manufactured_Date") = txtMDate.Text
                .Item("Expire_Date") = txtEDate.Text
            End With
            adMedi.UpdateCommand = cmBuilder.GetUpdateCommand
            txtMsg.Text = "Data Updated Successfully"
        ElseIf chrDBCommand = "D" Then
            ds.Tables("tblMediStok").Rows(n).Delete()
            adMedi.DeleteCommand = cmBuilder.GetDeleteCommand
            n = n - 1
            txtMsg.Text = "Data Deleted Successfully"
        End If
        con.Open()
        Try
            adMedi.Update(ds, "tblMediStok")
            clearcontrols()
        Catch ex As Exception
            'txtMsg.Text = "You are trying to save data incorrectly..."
            MessageBox.Show("You are trying to save data incorrectly..." & ex.Message)
        End Try
        con.Close()
    End Sub
    Sub clearcontrols()
        txtMediCode.Clear()
        txtMediName.Clear()
        txtQuantity.Clear()
        txtUnitPrice.Clear()
        txtDosage.Clear()
        txtMDate.Clear()
        txtEDate.Clear()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim tbMediStok As DataTable
        Dim dcPrimarykey(0) As DataColumn
        tbMediStok = ds.Tables("tblMediStok")
        dcPrimarykey(0) = tbMediStok.Columns("Med_Name")
        tbMediStok.PrimaryKey = dcPrimarykey

        Dim frmFind As New frmSearch
        Dim strMName As String
        frmFind.ShowDialog()
        strMName = frmFind.strMName
        strMName = frmFind.strMName

        If Not strMName Is Nothing Then
            Dim drPharmacy As DataRow = tbMediStok.Rows.Find(strMName)
            If Not drPharmacy Is Nothing Then
                With drPharmacy
                    txtMediCode.Text = .Item("Medi_Code")
                    txtMediName.Text = .Item("Med_Name")
                    txtQuantity.Text = .Item("Quantity")
                    txtUnitPrice.Text = .Item("Unit_Price")
                    txtDosage.Text = .Item("Dosage")
                    txtMDate.Text = .Item("Manufactured_Date")
                    txtEDate.Text = .Item("Expire_Date")
                End With
            Else
                MessageBox.Show("Medicine is not found...!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        frmReport.ShowDialog()
    End Sub

    Private Sub btncal_Click(sender As Object, e As EventArgs)
        frmBilling.ShowDialog()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        n = 0
        ShowRecords()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If n > 0 Then
            n = n - 1
            ShowRecords()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If n < ds.Tables("tblMediStok").Rows.Count - 1 Then
            n = n + 1
            ShowRecords()
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        n = ds.Tables("tblMediStok").Rows.Count - 1
        ShowRecords()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtMediCode.Clear()
        txtMediName.Clear()
        txtQuantity.Clear()
        txtUnitPrice.Clear()
        txtDosage.Clear()
        txtMDate.Clear()
        txtEDate.Clear()
        txtMsg.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
