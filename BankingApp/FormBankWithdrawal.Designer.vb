<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBankWithdrawal
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.MasterBankBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankingDataSet = New DashBoard.BankingDataSet()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbAccountType = New System.Windows.Forms.ComboBox()
        Me.TxtAccountName = New System.Windows.Forms.TextBox()
        Me.TxtAccountNumber = New System.Windows.Forms.TextBox()
        Me.TxtWithdraw = New System.Windows.Forms.TextBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MasterBankTableAdapter = New DashBoard.BankingDataSetTableAdapters.MasterBankTableAdapter()
        Me.TableAdapterManager1 = New DashBoard.BankingDataSetTableAdapters.TableAdapterManager()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        CType(Me.MasterBankBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Location = New System.Drawing.Point(0, 81)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1167, 413)
        Me.Panel3.TabIndex = 6
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.BackColor = System.Drawing.SystemColors.Control
        Me.lblBalance.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "balance", True))
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.ForeColor = System.Drawing.Color.Black
        Me.lblBalance.Location = New System.Drawing.Point(393, 517)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(39, 42)
        Me.lblBalance.TabIndex = 11
        Me.lblBalance.Text = "0"
        Me.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MasterBankBindingSource
        '
        Me.MasterBankBindingSource.DataMember = "MasterBank"
        Me.MasterBankBindingSource.DataSource = Me.BankingDataSet
        '
        'BankingDataSet
        '
        Me.BankingDataSet.DataSetName = "BankingDataSet"
        Me.BankingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(12, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1143, 408)
        Me.Panel2.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbAccountType)
        Me.GroupBox1.Controls.Add(Me.TxtAccountName)
        Me.GroupBox1.Controls.Add(Me.TxtAccountNumber)
        Me.GroupBox1.Controls.Add(Me.TxtWithdraw)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1133, 391)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Particulars"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(13, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(351, 42)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Date of transaction :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Control
        Me.DateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "date", True))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(457, 327)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(586, 49)
        Me.DateTimePicker1.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(255, 42)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Account type :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(344, 42)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Amount withdrawn :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(316, 42)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Account Number :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(383, 42)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Account Holder Name"
        '
        'cmbAccountType
        '
        Me.cmbAccountType.BackColor = System.Drawing.SystemColors.Control
        Me.cmbAccountType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "cashin", True))
        Me.cmbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccountType.Enabled = False
        Me.cmbAccountType.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccountType.FormattingEnabled = True
        Me.cmbAccountType.Items.AddRange(New Object() {"SAVINGS", "CURRENT", "FCA", "LOCAL NOSTRO"})
        Me.cmbAccountType.Location = New System.Drawing.Point(457, 252)
        Me.cmbAccountType.Name = "cmbAccountType"
        Me.cmbAccountType.Size = New System.Drawing.Size(586, 50)
        Me.cmbAccountType.TabIndex = 6
        '
        'TxtAccountName
        '
        Me.TxtAccountName.BackColor = System.Drawing.SystemColors.Control
        Me.TxtAccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAccountName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAccountName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtAccountName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "name", True))
        Me.TxtAccountName.Enabled = False
        Me.TxtAccountName.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAccountName.Location = New System.Drawing.Point(457, 30)
        Me.TxtAccountName.Name = "TxtAccountName"
        Me.TxtAccountName.Size = New System.Drawing.Size(647, 49)
        Me.TxtAccountName.TabIndex = 5
        Me.TxtAccountName.Text = "NAME"
        '
        'TxtAccountNumber
        '
        Me.TxtAccountNumber.BackColor = System.Drawing.SystemColors.Control
        Me.TxtAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAccountNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAccountNumber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtAccountNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "number", True))
        Me.TxtAccountNumber.Enabled = False
        Me.TxtAccountNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAccountNumber.Location = New System.Drawing.Point(457, 104)
        Me.TxtAccountNumber.Name = "TxtAccountNumber"
        Me.TxtAccountNumber.Size = New System.Drawing.Size(586, 49)
        Me.TxtAccountNumber.TabIndex = 4
        Me.TxtAccountNumber.Text = "NUMBER"
        '
        'TxtWithdraw
        '
        Me.TxtWithdraw.BackColor = System.Drawing.SystemColors.Control
        Me.TxtWithdraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtWithdraw.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtWithdraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtWithdraw.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "withdraw", True))
        Me.TxtWithdraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWithdraw.Location = New System.Drawing.Point(457, 178)
        Me.TxtWithdraw.Name = "TxtWithdraw"
        Me.TxtWithdraw.Size = New System.Drawing.Size(375, 49)
        Me.TxtWithdraw.TabIndex = 3
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBalance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBalance.Enabled = False
        Me.txtBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.Location = New System.Drawing.Point(484, 524)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(220, 35)
        Me.txtBalance.TabIndex = 13
        Me.txtBalance.Text = "0"
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBalance.Visible = False
        '
        'BtnBack
        '
        Me.BtnBack.AutoSize = True
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.ForeColor = System.Drawing.Color.White
        Me.BtnBack.Location = New System.Drawing.Point(1060, 517)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(103, 42)
        Me.BtnBack.TabIndex = 0
        Me.BtnBack.Text = "&Back"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.AutoSize = True
        Me.BtnSave.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(0, 517)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(110, 42)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(877, -4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bank Withdrawal"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(181, 517)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(176, 42)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Balance:-"
        '
        'MasterBankTableAdapter
        '
        Me.MasterBankTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.MasterBankTableAdapter = Me.MasterBankTableAdapter
        Me.TableAdapterManager1.UpdateOrder = DashBoard.BankingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Blue
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSearch.Location = New System.Drawing.Point(710, 26)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(131, 38)
        Me.btnSearch.TabIndex = 19
        Me.btnSearch.Text = "S&earch"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'cmbSearch
        '
        Me.cmbSearch.BackColor = System.Drawing.SystemColors.Control
        Me.cmbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Items.AddRange(New Object() {"name", "number"})
        Me.cmbSearch.Location = New System.Drawing.Point(441, 24)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(263, 39)
        Me.cmbSearch.TabIndex = 18
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TextBoxSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(0, 24)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(432, 38)
        Me.TextBoxSearch.TabIndex = 17
        Me.TextBoxSearch.Text = "type here"
        Me.TextBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormBankWithdrawal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 561)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormBankWithdrawal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBankWithdrawal"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.MasterBankBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbAccountType As ComboBox
    Friend WithEvents TxtAccountName As TextBox
    Friend WithEvents TxtAccountNumber As TextBox
    Friend WithEvents TxtWithdraw As TextBox
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents BankingDataSet As BankingDataSet
    Friend WithEvents MasterBankBindingSource As BindingSource
    Friend WithEvents MasterBankTableAdapter As BankingDataSetTableAdapters.MasterBankTableAdapter
    Friend WithEvents lblBalance As Label
    Friend WithEvents TableAdapterManager1 As BankingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnSearch As Button
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents TextBoxSearch As TextBox
End Class
