<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tblMediStokBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pharmacy1DataSet1 = New pramacy.Pharmacy1DataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tblMediStokTableAdapter = New pramacy.Pharmacy1DataSet1TableAdapters.tblMediStokTableAdapter()
        CType(Me.tblMediStokBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pharmacy1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblMediStokBindingSource
        '
        Me.tblMediStokBindingSource.DataMember = "tblMediStok"
        Me.tblMediStokBindingSource.DataSource = Me.Pharmacy1DataSet1
        '
        'Pharmacy1DataSet1
        '
        Me.Pharmacy1DataSet1.DataSetName = "Pharmacy1DataSet1"
        Me.Pharmacy1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblMediStokBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "pramacy.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1020, 430)
        Me.ReportViewer1.TabIndex = 0
        '
        'tblMediStokTableAdapter
        '
        Me.tblMediStokTableAdapter.ClearBeforeFill = True
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 463)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReport"
        Me.Text = "Report"
        CType(Me.tblMediStokBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pharmacy1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblMediStokBindingSource As BindingSource
    Friend WithEvents Pharmacy1DataSet1 As Pharmacy1DataSet1
    Friend WithEvents tblMediStokTableAdapter As Pharmacy1DataSet1TableAdapters.tblMediStokTableAdapter
End Class
