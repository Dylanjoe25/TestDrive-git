<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBankNewAccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepositDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasterBankBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankingDataSet = New DashBoard.BankingDataSet()
        Me.CashoutComboBox = New System.Windows.Forms.ComboBox()
        Me.DateDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.DepositTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.NumberTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.MasterBankTableAdapter = New DashBoard.BankingDataSetTableAdapters.MasterBankTableAdapter()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New DashBoard.BankingDataSetTableAdapters.TableAdapterManager()
        Me.BalanceLabel1 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterBankBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.AutoSize = True
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.ForeColor = System.Drawing.Color.White
        Me.BtnBack.Location = New System.Drawing.Point(1170, 626)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(89, 41)
        Me.BtnBack.TabIndex = 0
        Me.BtnBack.Text = "&Back"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1259, 575)
        Me.Panel3.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.CashoutComboBox)
        Me.GroupBox1.Controls.Add(Me.DateDateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.BalanceTextBox)
        Me.GroupBox1.Controls.Add(Me.DepositTextBox)
        Me.GroupBox1.Controls.Add(Me.AddressTextBox)
        Me.GroupBox1.Controls.Add(Me.NumberTextBox)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1222, 564)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Particulars"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.NumberDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.DepositDataGridViewTextBoxColumn, Me.BalanceDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.CashinDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MasterBankBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(-22, 498)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1256, 74)
        Me.DataGridView1.TabIndex = 40
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'NumberDataGridViewTextBoxColumn
        '
        Me.NumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NumberDataGridViewTextBoxColumn.DataPropertyName = "number"
        Me.NumberDataGridViewTextBoxColumn.HeaderText = "number"
        Me.NumberDataGridViewTextBoxColumn.Name = "NumberDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'DepositDataGridViewTextBoxColumn
        '
        Me.DepositDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DepositDataGridViewTextBoxColumn.DataPropertyName = "deposit"
        Me.DepositDataGridViewTextBoxColumn.HeaderText = "deposit"
        Me.DepositDataGridViewTextBoxColumn.Name = "DepositDataGridViewTextBoxColumn"
        '
        'BalanceDataGridViewTextBoxColumn
        '
        Me.BalanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BalanceDataGridViewTextBoxColumn.DataPropertyName = "balance"
        Me.BalanceDataGridViewTextBoxColumn.HeaderText = "balance"
        Me.BalanceDataGridViewTextBoxColumn.Name = "BalanceDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'CashinDataGridViewTextBoxColumn
        '
        Me.CashinDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CashinDataGridViewTextBoxColumn.DataPropertyName = "cashin"
        Me.CashinDataGridViewTextBoxColumn.HeaderText = "cashin"
        Me.CashinDataGridViewTextBoxColumn.Name = "CashinDataGridViewTextBoxColumn"
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
        'CashoutComboBox
        '
        Me.CashoutComboBox.BackColor = System.Drawing.SystemColors.Control
        Me.CashoutComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CashoutComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MasterBankBindingSource, "cashin", True))
        Me.CashoutComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "cashin", True))
        Me.CashoutComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CashoutComboBox.FormattingEnabled = True
        Me.CashoutComboBox.Items.AddRange(New Object() {"SAVINGS", "CURRENT", "FCA", "LOCAL NOSTRO"})
        Me.CashoutComboBox.Location = New System.Drawing.Point(320, 446)
        Me.CashoutComboBox.Name = "CashoutComboBox"
        Me.CashoutComboBox.Size = New System.Drawing.Size(611, 50)
        Me.CashoutComboBox.TabIndex = 39
        Me.CashoutComboBox.Text = "SAVINGS"
        '
        'DateDateTimePicker1
        '
        Me.DateDateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Control
        Me.DateDateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.DateDateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MasterBankBindingSource, "date", True))
        Me.DateDateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDateTimePicker1.Location = New System.Drawing.Point(320, 367)
        Me.DateDateTimePicker1.Name = "DateDateTimePicker1"
        Me.DateDateTimePicker1.Size = New System.Drawing.Size(611, 49)
        Me.DateDateTimePicker1.TabIndex = 38
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.BalanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BalanceTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "balance", True))
        Me.BalanceTextBox.Enabled = False
        Me.BalanceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BalanceTextBox.Location = New System.Drawing.Point(320, 305)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.Size = New System.Drawing.Size(529, 49)
        Me.BalanceTextBox.TabIndex = 37
        Me.BalanceTextBox.Text = "0"
        '
        'DepositTextBox
        '
        Me.DepositTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.DepositTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DepositTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DepositTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "deposit", True))
        Me.DepositTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepositTextBox.Location = New System.Drawing.Point(320, 236)
        Me.DepositTextBox.Name = "DepositTextBox"
        Me.DepositTextBox.Size = New System.Drawing.Size(529, 49)
        Me.DepositTextBox.TabIndex = 36
        Me.DepositTextBox.Text = "0"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.AddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddressTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AddressTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(320, 161)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(529, 69)
        Me.AddressTextBox.TabIndex = 35
        Me.AddressTextBox.Text = "ADDRESS"
        '
        'NumberTextBox
        '
        Me.NumberTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.NumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NumberTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "number", True))
        Me.NumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberTextBox.Location = New System.Drawing.Point(320, 99)
        Me.NumberTextBox.MaxLength = 20
        Me.NumberTextBox.Name = "NumberTextBox"
        Me.NumberTextBox.Size = New System.Drawing.Size(529, 49)
        Me.NumberTextBox.TabIndex = 34
        Me.NumberTextBox.Text = "NUMBER"
        '
        'NameTextBox
        '
        Me.NameTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NameTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "name", True))
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(320, 37)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(864, 49)
        Me.NameTextBox.TabIndex = 33
        Me.NameTextBox.Text = "NAME"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.SystemColors.Control
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(25, 171)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(99, 42)
        Me.Label26.TabIndex = 17
        Me.Label26.Text = "Add:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(25, 238)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(163, 42)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = "Deposit:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(25, 372)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(112, 42)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "Date:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(25, 439)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(194, 42)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "Acc Type:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(25, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 42)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Balance :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(25, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 42)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Acc No :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(25, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 42)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Name:"
        '
        'BtnSave
        '
        Me.BtnSave.AutoSize = True
        Me.BtnSave.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(0, 631)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(119, 41)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Stencil", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(782, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(477, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bank Add New Account"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBalance.Location = New System.Drawing.Point(358, 628)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(185, 42)
        Me.lblBalance.TabIndex = 7
        Me.lblBalance.Text = "Balance:-"
        '
        'MasterBankTableAdapter
        '
        Me.MasterBankTableAdapter.ClearBeforeFill = True
        '
        'btnAddNew
        '
        Me.btnAddNew.AutoSize = True
        Me.btnAddNew.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.ForeColor = System.Drawing.Color.White
        Me.btnAddNew.Location = New System.Drawing.Point(156, 631)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(136, 41)
        Me.btnAddNew.TabIndex = 0
        Me.btnAddNew.Text = "&Add new"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MasterBankTableAdapter = Me.MasterBankTableAdapter
        Me.TableAdapterManager.UpdateOrder = DashBoard.BankingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BalanceLabel1
        '
        Me.BalanceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "balance", True))
        Me.BalanceLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BalanceLabel1.Location = New System.Drawing.Point(578, 631)
        Me.BalanceLabel1.Name = "BalanceLabel1"
        Me.BalanceLabel1.Size = New System.Drawing.Size(100, 36)
        Me.BalanceLabel1.TabIndex = 32
        Me.BalanceLabel1.Text = "0"
        Me.BalanceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormBankNewAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 671)
        Me.Controls.Add(Me.BalanceLabel1)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.BtnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormBankNewAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBankNewAccount"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterBankBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents BankingDataSet As BankingDataSet
    Friend WithEvents MasterBankBindingSource As BindingSource
    Friend WithEvents MasterBankTableAdapter As BankingDataSetTableAdapters.MasterBankTableAdapter
    Friend WithEvents btnAddNew As Button
    Friend WithEvents BalanceTextBox As TextBox
    Friend WithEvents DepositTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents NumberTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents TableAdapterManager As BankingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DateDateTimePicker1 As DateTimePicker
    Friend WithEvents CashoutComboBox As ComboBox
    Friend WithEvents BalanceLabel1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepositDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CashinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
