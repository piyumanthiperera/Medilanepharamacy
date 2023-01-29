<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Me.btnBilling = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMStock = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBilling
        '
        Me.btnBilling.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnBilling.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBilling.ForeColor = System.Drawing.Color.Transparent
        Me.btnBilling.Location = New System.Drawing.Point(223, 174)
        Me.btnBilling.Name = "btnBilling"
        Me.btnBilling.Size = New System.Drawing.Size(187, 124)
        Me.btnBilling.TabIndex = 7
        Me.btnBilling.Text = "Billing Form"
        Me.btnBilling.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.Transparent
        Me.btnSettings.Location = New System.Drawing.Point(435, 174)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(187, 124)
        Me.btnSettings.TabIndex = 6
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Transparent
        Me.btnExit.Location = New System.Drawing.Point(640, 174)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(187, 124)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnMStock
        '
        Me.btnMStock.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnMStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMStock.ForeColor = System.Drawing.Color.Transparent
        Me.btnMStock.Location = New System.Drawing.Point(12, 174)
        Me.btnMStock.Name = "btnMStock"
        Me.btnMStock.Size = New System.Drawing.Size(187, 124)
        Me.btnMStock.TabIndex = 4
        Me.btnMStock.Text = "Medicine Stock"
        Me.btnMStock.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(33, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(794, 48)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Medilane Pharmacy Management System"
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.BackgroundImage = Global.pramacy.My.Resources.Resources._74824961
        Me.ClientSize = New System.Drawing.Size(876, 445)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBilling)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMStock)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBilling As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMStock As Button
    Friend WithEvents Label1 As Label
End Class
