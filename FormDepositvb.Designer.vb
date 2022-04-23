<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDeposit
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
        Me.EcobillDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashoutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasterBankBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankingDataSet = New DashBoard.BankingDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TxtDeposit = New System.Windows.Forms.TextBox()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TxtBalance = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.MasterBankTableAdapter = New DashBoard.BankingDataSetTableAdapters.MasterBankTableAdapter()
        Me.EcopaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.EcoairtimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankMasterDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZesaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EcocashDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DstvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BanktoecocashDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecipentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiptbankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiptacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalecocashDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EcotobankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.TableAdapterManager1 = New DashBoard.BankingDataSetTableAdapters.TableAdapterManager()
        CType(Me.MasterBankBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.FillByToolStrip.SuspendLayout()
        CType(Me.BankMasterDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'EcobillDataGridViewTextBoxColumn
        '
        Me.EcobillDataGridViewTextBoxColumn.DataPropertyName = "ecobill"
        Me.EcobillDataGridViewTextBoxColumn.HeaderText = "ecobill"
        Me.EcobillDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EcobillDataGridViewTextBoxColumn.Name = "EcobillDataGridViewTextBoxColumn"
        Me.EcobillDataGridViewTextBoxColumn.Width = 125
        '
        'CashoutDataGridViewTextBoxColumn
        '
        Me.CashoutDataGridViewTextBoxColumn.DataPropertyName = "cashout"
        Me.CashoutDataGridViewTextBoxColumn.HeaderText = "cashout"
        Me.CashoutDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CashoutDataGridViewTextBoxColumn.Name = "CashoutDataGridViewTextBoxColumn"
        Me.CashoutDataGridViewTextBoxColumn.Width = 125
        '
        'CashinDataGridViewTextBoxColumn
        '
        Me.CashinDataGridViewTextBoxColumn.DataPropertyName = "cashin"
        Me.CashinDataGridViewTextBoxColumn.HeaderText = "cashin"
        Me.CashinDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CashinDataGridViewTextBoxColumn.Name = "CashinDataGridViewTextBoxColumn"
        Me.CashinDataGridViewTextBoxColumn.Width = 125
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TxtDeposit)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 20)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1008, 372)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Particulars"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(53, 266)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(279, 31)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Date of transaction :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "date", True))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(448, 266)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(503, 41)
        Me.DateTimePicker1.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(53, 208)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 31)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Account type :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(53, 154)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(265, 31)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Amount deposited :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(53, 87)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 31)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Account Number :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(53, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Account Holder Name"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "bill", True))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"SAVINGS", "CURRENT", "FCA", "LOCAL NOSTRO"})
        Me.ComboBox1.Location = New System.Drawing.Point(452, 208)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(499, 48)
        Me.ComboBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "name", True))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(448, 31)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(503, 41)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "number", True))
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(448, 87)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(503, 41)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDeposit
        '
        Me.TxtDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDeposit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDeposit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "deposit", True))
        Me.TxtDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDeposit.Location = New System.Drawing.Point(452, 154)
        Me.TxtDeposit.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDeposit.Name = "TxtDeposit"
        Me.TxtDeposit.Size = New System.Drawing.Size(499, 41)
        Me.TxtDeposit.TabIndex = 3
        Me.TxtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1759, 27)
        Me.FillByToolStrip.TabIndex = 20
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(48, 28)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'TxtBalance
        '
        Me.TxtBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBalance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBalance.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "balance", True))
        Me.TxtBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBalance.Location = New System.Drawing.Point(1133, 777)
        Me.TxtBalance.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBalance.Name = "TxtBalance"
        Me.TxtBalance.Size = New System.Drawing.Size(255, 41)
        Me.TxtBalance.TabIndex = 19
        Me.TxtBalance.Text = "0"
        Me.TxtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtBalance.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(789, 781)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 39)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Balance:-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(765, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 39)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Bank Deposit"
        '
        'BtnSave
        '
        Me.BtnSave.AutoSize = True
        Me.BtnSave.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(0, 770)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(132, 50)
        Me.BtnSave.TabIndex = 16
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'MasterBankTableAdapter
        '
        Me.MasterBankTableAdapter.ClearBeforeFill = True
        '
        'EcopaymentDataGridViewTextBoxColumn
        '
        Me.EcopaymentDataGridViewTextBoxColumn.DataPropertyName = "ecopayment"
        Me.EcopaymentDataGridViewTextBoxColumn.HeaderText = "ecopayment"
        Me.EcopaymentDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EcopaymentDataGridViewTextBoxColumn.Name = "EcopaymentDataGridViewTextBoxColumn"
        Me.EcopaymentDataGridViewTextBoxColumn.Width = 125
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "balance", True))
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(1126, 780)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(35, 38)
        Me.lblBalance.TabIndex = 21
        Me.lblBalance.Text = "0"
        Me.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EcoairtimeDataGridViewTextBoxColumn
        '
        Me.EcoairtimeDataGridViewTextBoxColumn.DataPropertyName = "ecoairtime"
        Me.EcoairtimeDataGridViewTextBoxColumn.HeaderText = "ecoairtime"
        Me.EcoairtimeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EcoairtimeDataGridViewTextBoxColumn.Name = "EcoairtimeDataGridViewTextBoxColumn"
        Me.EcoairtimeDataGridViewTextBoxColumn.Width = 125
        '
        'BankMasterDataGridView
        '
        Me.BankMasterDataGridView.AllowUserToOrderColumns = True
        Me.BankMasterDataGridView.AutoGenerateColumns = False
        Me.BankMasterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BankMasterDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.AddressDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.TopupDataGridViewTextBoxColumn, Me.PaymentsDataGridViewTextBoxColumn, Me.ZesaDataGridViewTextBoxColumn, Me.EcocashDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn6, Me.BillDataGridViewTextBoxColumn, Me.DstvDataGridViewTextBoxColumn, Me.BanktoecocashDataGridViewTextBoxColumn, Me.RecipentDataGridViewTextBoxColumn, Me.ReceiptbankDataGridViewTextBoxColumn, Me.ReceiptacDataGridViewTextBoxColumn, Me.BalecocashDataGridViewTextBoxColumn, Me.EcotobankDataGridViewTextBoxColumn, Me.EcoairtimeDataGridViewTextBoxColumn, Me.EcobillDataGridViewTextBoxColumn, Me.EcopaymentDataGridViewTextBoxColumn, Me.CashoutDataGridViewTextBoxColumn, Me.CashinDataGridViewTextBoxColumn})
        Me.BankMasterDataGridView.DataSource = Me.MasterBankBindingSource
        Me.BankMasterDataGridView.Location = New System.Drawing.Point(4, 354)
        Me.BankMasterDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.BankMasterDataGridView.Name = "BankMasterDataGridView"
        Me.BankMasterDataGridView.RowHeadersWidth = 51
        Me.BankMasterDataGridView.Size = New System.Drawing.Size(1008, 121)
        Me.BankMasterDataGridView.TabIndex = 12
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "name"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "number"
        Me.DataGridViewTextBoxColumn2.HeaderText = "number"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "deposit"
        Me.DataGridViewTextBoxColumn3.HeaderText = "deposit"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "withdraw"
        Me.DataGridViewTextBoxColumn4.HeaderText = "withdraw"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "balance"
        Me.DataGridViewTextBoxColumn5.HeaderText = "balance"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'TopupDataGridViewTextBoxColumn
        '
        Me.TopupDataGridViewTextBoxColumn.DataPropertyName = "topup"
        Me.TopupDataGridViewTextBoxColumn.HeaderText = "topup"
        Me.TopupDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TopupDataGridViewTextBoxColumn.Name = "TopupDataGridViewTextBoxColumn"
        Me.TopupDataGridViewTextBoxColumn.Width = 125
        '
        'PaymentsDataGridViewTextBoxColumn
        '
        Me.PaymentsDataGridViewTextBoxColumn.DataPropertyName = "payments"
        Me.PaymentsDataGridViewTextBoxColumn.HeaderText = "payments"
        Me.PaymentsDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PaymentsDataGridViewTextBoxColumn.Name = "PaymentsDataGridViewTextBoxColumn"
        Me.PaymentsDataGridViewTextBoxColumn.Width = 125
        '
        'ZesaDataGridViewTextBoxColumn
        '
        Me.ZesaDataGridViewTextBoxColumn.DataPropertyName = "zesa"
        Me.ZesaDataGridViewTextBoxColumn.HeaderText = "zesa"
        Me.ZesaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ZesaDataGridViewTextBoxColumn.Name = "ZesaDataGridViewTextBoxColumn"
        Me.ZesaDataGridViewTextBoxColumn.Width = 125
        '
        'EcocashDataGridViewTextBoxColumn
        '
        Me.EcocashDataGridViewTextBoxColumn.DataPropertyName = "ecocash"
        Me.EcocashDataGridViewTextBoxColumn.HeaderText = "ecocash"
        Me.EcocashDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EcocashDataGridViewTextBoxColumn.Name = "EcocashDataGridViewTextBoxColumn"
        Me.EcocashDataGridViewTextBoxColumn.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "date"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'BillDataGridViewTextBoxColumn
        '
        Me.BillDataGridViewTextBoxColumn.DataPropertyName = "bill"
        Me.BillDataGridViewTextBoxColumn.HeaderText = "bill"
        Me.BillDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BillDataGridViewTextBoxColumn.Name = "BillDataGridViewTextBoxColumn"
        Me.BillDataGridViewTextBoxColumn.Width = 125
        '
        'DstvDataGridViewTextBoxColumn
        '
        Me.DstvDataGridViewTextBoxColumn.DataPropertyName = "dstv"
        Me.DstvDataGridViewTextBoxColumn.HeaderText = "dstv"
        Me.DstvDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DstvDataGridViewTextBoxColumn.Name = "DstvDataGridViewTextBoxColumn"
        Me.DstvDataGridViewTextBoxColumn.Width = 125
        '
        'BanktoecocashDataGridViewTextBoxColumn
        '
        Me.BanktoecocashDataGridViewTextBoxColumn.DataPropertyName = "banktoecocash"
        Me.BanktoecocashDataGridViewTextBoxColumn.HeaderText = "banktoecocash"
        Me.BanktoecocashDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BanktoecocashDataGridViewTextBoxColumn.Name = "BanktoecocashDataGridViewTextBoxColumn"
        Me.BanktoecocashDataGridViewTextBoxColumn.Width = 125
        '
        'RecipentDataGridViewTextBoxColumn
        '
        Me.RecipentDataGridViewTextBoxColumn.DataPropertyName = "recipent"
        Me.RecipentDataGridViewTextBoxColumn.HeaderText = "recipent"
        Me.RecipentDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RecipentDataGridViewTextBoxColumn.Name = "RecipentDataGridViewTextBoxColumn"
        Me.RecipentDataGridViewTextBoxColumn.Width = 125
        '
        'ReceiptbankDataGridViewTextBoxColumn
        '
        Me.ReceiptbankDataGridViewTextBoxColumn.DataPropertyName = "receiptbank"
        Me.ReceiptbankDataGridViewTextBoxColumn.HeaderText = "receiptbank"
        Me.ReceiptbankDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ReceiptbankDataGridViewTextBoxColumn.Name = "ReceiptbankDataGridViewTextBoxColumn"
        Me.ReceiptbankDataGridViewTextBoxColumn.Width = 125
        '
        'ReceiptacDataGridViewTextBoxColumn
        '
        Me.ReceiptacDataGridViewTextBoxColumn.DataPropertyName = "receiptac"
        Me.ReceiptacDataGridViewTextBoxColumn.HeaderText = "receiptac"
        Me.ReceiptacDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ReceiptacDataGridViewTextBoxColumn.Name = "ReceiptacDataGridViewTextBoxColumn"
        Me.ReceiptacDataGridViewTextBoxColumn.Width = 125
        '
        'BalecocashDataGridViewTextBoxColumn
        '
        Me.BalecocashDataGridViewTextBoxColumn.DataPropertyName = "balecocash"
        Me.BalecocashDataGridViewTextBoxColumn.HeaderText = "balecocash"
        Me.BalecocashDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BalecocashDataGridViewTextBoxColumn.Name = "BalecocashDataGridViewTextBoxColumn"
        Me.BalecocashDataGridViewTextBoxColumn.Width = 125
        '
        'EcotobankDataGridViewTextBoxColumn
        '
        Me.EcotobankDataGridViewTextBoxColumn.DataPropertyName = "ecotobank"
        Me.EcotobankDataGridViewTextBoxColumn.HeaderText = "ecotobank"
        Me.EcotobankDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EcotobankDataGridViewTextBoxColumn.Name = "EcotobankDataGridViewTextBoxColumn"
        Me.EcotobankDataGridViewTextBoxColumn.Width = 125
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.BankMasterDataGridView)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Location = New System.Drawing.Point(4, 92)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1551, 495)
        Me.Panel3.TabIndex = 17
        '
        'BtnBack
        '
        Me.BtnBack.AutoSize = True
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.ForeColor = System.Drawing.Color.White
        Me.BtnBack.Location = New System.Drawing.Point(549, 620)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(159, 50)
        Me.BtnBack.TabIndex = 14
        Me.BtnBack.Text = "&Back"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.MasterBankTableAdapter = Me.MasterBankTableAdapter
        Me.TableAdapterManager1.UpdateOrder = DashBoard.BankingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FormDeposit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1759, 834)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.TxtBalance)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.BtnBack)
        Me.Name = "FormDeposit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDepositvb"
        CType(Me.MasterBankBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        CType(Me.BankMasterDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EcobillDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CashoutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CashinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MasterBankBindingSource As BindingSource
    Friend WithEvents BankingDataSet As BankingDataSet
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TxtDeposit As TextBox
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents TxtBalance As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents MasterBankTableAdapter As BankingDataSetTableAdapters.MasterBankTableAdapter
    Friend WithEvents EcopaymentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblBalance As Label
    Friend WithEvents EcoairtimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BankMasterDataGridView As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents TopupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZesaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EcocashDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents BillDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DstvDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BanktoecocashDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecipentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReceiptbankDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReceiptacDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BalecocashDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EcotobankDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnBack As Button
    Friend WithEvents TableAdapterManager1 As BankingDataSetTableAdapters.TableAdapterManager
End Class
