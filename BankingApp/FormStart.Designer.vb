<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStart
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblAmountDeposited = New System.Windows.Forms.Label()
        Me.lblAccountNumber = New System.Windows.Forms.Label()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.MasterBankBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankingDataSet = New DashBoard.BankingDataSet()
        Me.txtAccountNumber = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepositDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasterBankBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MasterBankTableAdapter = New DashBoard.BankingDataSetTableAdapters.MasterBankTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.MasterBankBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterBankBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1339, 696)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImage = Global.DashBoard.My.Resources.Resources.FALLS
        Me.TabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage3.Controls.Add(Me.btnExit)
        Me.TabPage3.Location = New System.Drawing.Point(4, 42)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1331, 650)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Home Page"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(2, 648)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 60)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.lblBalance)
        Me.TabPage1.Controls.Add(Me.lblAmountDeposited)
        Me.TabPage1.Controls.Add(Me.lblAccountNumber)
        Me.TabPage1.Controls.Add(Me.lblCaption)
        Me.TabPage1.Controls.Add(Me.lblName)
        Me.TabPage1.Controls.Add(Me.cmbSearch)
        Me.TabPage1.Controls.Add(Me.txtBalance)
        Me.TabPage1.Controls.Add(Me.txtDeposit)
        Me.TabPage1.Controls.Add(Me.txtAccountNumber)
        Me.TabPage1.Controls.Add(Me.txtName)
        Me.TabPage1.Controls.Add(Me.btnSearch)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 42)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(1331, 650)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Deposit"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(10, 378)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(219, 55)
        Me.lblBalance.TabIndex = 4
        Me.lblBalance.Text = "Balance:"
        '
        'lblAmountDeposited
        '
        Me.lblAmountDeposited.AutoSize = True
        Me.lblAmountDeposited.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountDeposited.Location = New System.Drawing.Point(10, 311)
        Me.lblAmountDeposited.Name = "lblAmountDeposited"
        Me.lblAmountDeposited.Size = New System.Drawing.Size(450, 55)
        Me.lblAmountDeposited.TabIndex = 4
        Me.lblAmountDeposited.Text = "Amount Deposited:"
        '
        'lblAccountNumber
        '
        Me.lblAccountNumber.AutoSize = True
        Me.lblAccountNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountNumber.Location = New System.Drawing.Point(10, 218)
        Me.lblAccountNumber.Name = "lblAccountNumber"
        Me.lblAccountNumber.Size = New System.Drawing.Size(411, 55)
        Me.lblAccountNumber.TabIndex = 4
        Me.lblAccountNumber.Text = "Account Number:"
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Font = New System.Drawing.Font("Old English Text MT", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption.ForeColor = System.Drawing.Color.Green
        Me.lblCaption.Location = New System.Drawing.Point(7, 6)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(389, 77)
        Me.lblCaption.TabIndex = 4
        Me.lblCaption.Text = "Cash Deposit"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(10, 118)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(265, 55)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Full Name:"
        '
        'cmbSearch
        '
        Me.cmbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Location = New System.Drawing.Point(607, 14)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(470, 63)
        Me.cmbSearch.TabIndex = 3
        '
        'txtBalance
        '
        Me.txtBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.Location = New System.Drawing.Point(532, 341)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(408, 116)
        Me.txtBalance.TabIndex = 2
        '
        'txtDeposit
        '
        Me.txtDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDeposit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "deposit", True))
        Me.txtDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeposit.Location = New System.Drawing.Point(709, 283)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.ReadOnly = True
        Me.txtDeposit.Size = New System.Drawing.Size(613, 116)
        Me.txtDeposit.TabIndex = 2
        Me.txtDeposit.Text = "0"
        Me.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'txtAccountNumber
        '
        Me.txtAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAccountNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "number", True))
        Me.txtAccountNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountNumber.Location = New System.Drawing.Point(884, 187)
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.ReadOnly = True
        Me.txtAccountNumber.Size = New System.Drawing.Size(613, 109)
        Me.txtAccountNumber.TabIndex = 2
        Me.txtAccountNumber.Text = "Ac Number"
        Me.txtAccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "name", True))
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(532, 83)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(994, 109)
        Me.txtName.TabIndex = 2
        Me.txtName.Text = "Name"
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSearch.Location = New System.Drawing.Point(1255, 14)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(242, 57)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "S&earch"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.NumberDataGridViewTextBoxColumn, Me.DepositDataGridViewTextBoxColumn, Me.BalanceDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.MasterBankBindingSource1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(2, 448)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1325, 198)
        Me.DataGridView1.TabIndex = 1
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumberDataGridViewTextBoxColumn
        '
        Me.NumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NumberDataGridViewTextBoxColumn.DataPropertyName = "number"
        Me.NumberDataGridViewTextBoxColumn.HeaderText = "number"
        Me.NumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumberDataGridViewTextBoxColumn.Name = "NumberDataGridViewTextBoxColumn"
        Me.NumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DepositDataGridViewTextBoxColumn
        '
        Me.DepositDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DepositDataGridViewTextBoxColumn.DataPropertyName = "deposit"
        Me.DepositDataGridViewTextBoxColumn.HeaderText = "deposit"
        Me.DepositDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DepositDataGridViewTextBoxColumn.Name = "DepositDataGridViewTextBoxColumn"
        Me.DepositDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BalanceDataGridViewTextBoxColumn
        '
        Me.BalanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BalanceDataGridViewTextBoxColumn.DataPropertyName = "balance"
        Me.BalanceDataGridViewTextBoxColumn.HeaderText = "balance"
        Me.BalanceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BalanceDataGridViewTextBoxColumn.Name = "BalanceDataGridViewTextBoxColumn"
        Me.BalanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "date"
        Me.DateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MasterBankBindingSource1
        '
        Me.MasterBankBindingSource1.DataMember = "MasterBank"
        Me.MasterBankBindingSource1.DataSource = Me.BankingDataSet
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Lime
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSave.Location = New System.Drawing.Point(1255, 341)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(318, 113)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 42)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(1331, 650)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Withdrawals"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MasterBankTableAdapter
        '
        Me.MasterBankTableAdapter.ClearBeforeFill = True
        '
        'FormStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 696)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormStart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormStart"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.MasterBankBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterBankBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnExit As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents BankingDataSet As BankingDataSet
    Friend WithEvents MasterBankBindingSource As BindingSource
    Friend WithEvents MasterBankTableAdapter As BankingDataSetTableAdapters.MasterBankTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepositDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MasterBankBindingSource1 As BindingSource
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents lblBalance As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblAmountDeposited As Label
    Friend WithEvents lblAccountNumber As Label
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents txtAccountNumber As TextBox
    Friend WithEvents lblCaption As Label
End Class
