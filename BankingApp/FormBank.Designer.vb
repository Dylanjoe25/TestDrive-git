<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBank
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
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnDeposit = New System.Windows.Forms.Button()
        Me.BtnAddNewAccount = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnWithdrawal = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.AutoSize = True
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.ForeColor = System.Drawing.Color.White
        Me.BtnBack.Location = New System.Drawing.Point(1141, 3)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 35)
        Me.BtnBack.TabIndex = 0
        Me.BtnBack.Text = "&Back"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'lblBank
        '
        Me.lblBank.AutoSize = True
        Me.lblBank.BackColor = System.Drawing.Color.Transparent
        Me.lblBank.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBank.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBank.Location = New System.Drawing.Point(1134, 9)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(92, 32)
        Me.lblBank.TabIndex = 0
        Me.lblBank.Text = "Bank"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.BtnBack)
        Me.Panel3.Controls.Add(Me.BtnDeposit)
        Me.Panel3.Controls.Add(Me.BtnAddNewAccount)
        Me.Panel3.Controls.Add(Me.BtnEdit)
        Me.Panel3.Controls.Add(Me.BtnWithdrawal)
        Me.Panel3.Location = New System.Drawing.Point(-1, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1227, 39)
        Me.Panel3.TabIndex = 3
        '
        'BtnDeposit
        '
        Me.BtnDeposit.AutoSize = True
        Me.BtnDeposit.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeposit.ForeColor = System.Drawing.Color.White
        Me.BtnDeposit.Location = New System.Drawing.Point(229, 0)
        Me.BtnDeposit.Name = "BtnDeposit"
        Me.BtnDeposit.Size = New System.Drawing.Size(102, 35)
        Me.BtnDeposit.TabIndex = 0
        Me.BtnDeposit.Text = "&Deposit"
        Me.BtnDeposit.UseVisualStyleBackColor = False
        '
        'BtnAddNewAccount
        '
        Me.BtnAddNewAccount.AutoSize = True
        Me.BtnAddNewAccount.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnAddNewAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddNewAccount.ForeColor = System.Drawing.Color.White
        Me.BtnAddNewAccount.Location = New System.Drawing.Point(13, 0)
        Me.BtnAddNewAccount.Name = "BtnAddNewAccount"
        Me.BtnAddNewAccount.Size = New System.Drawing.Size(207, 35)
        Me.BtnAddNewAccount.TabIndex = 0
        Me.BtnAddNewAccount.Text = "&Add New Account"
        Me.BtnAddNewAccount.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.AutoSize = True
        Me.BtnEdit.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.Color.White
        Me.BtnEdit.Location = New System.Drawing.Point(468, 3)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(119, 35)
        Me.BtnEdit.TabIndex = 0
        Me.BtnEdit.Text = "&Update"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnWithdrawal
        '
        Me.BtnWithdrawal.AutoSize = True
        Me.BtnWithdrawal.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnWithdrawal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithdrawal.ForeColor = System.Drawing.Color.White
        Me.BtnWithdrawal.Location = New System.Drawing.Point(340, 0)
        Me.BtnWithdrawal.Name = "BtnWithdrawal"
        Me.BtnWithdrawal.Size = New System.Drawing.Size(119, 35)
        Me.BtnWithdrawal.TabIndex = 0
        Me.BtnWithdrawal.Text = "&Withdraw"
        Me.BtnWithdrawal.UseVisualStyleBackColor = False
        '
        'FormBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(1227, 88)
        Me.Controls.Add(Me.lblBank)
        Me.Controls.Add(Me.Panel3)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormBank"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnDeposit As Button
    Friend WithEvents BtnWithdrawal As Button
    Friend WithEvents BtnAddNewAccount As Button
    Friend WithEvents lblBank As Label
    Friend WithEvents BtnEdit As Button
End Class
