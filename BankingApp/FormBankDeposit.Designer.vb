<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBankDeposit
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.MasterBankBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankingDataSet = New DashBoard.BankingDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbAccountType = New System.Windows.Forms.ComboBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxNumber = New System.Windows.Forms.TextBox()
        Me.TxtDeposit = New System.Windows.Forms.TextBox()
        Me.BankMasterDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtBalance = New System.Windows.Forms.TextBox()
        Me.MasterBankTableAdapter = New DashBoard.BankingDataSetTableAdapters.MasterBankTableAdapter()
        Me.TableAdapterManager1 = New DashBoard.BankingDataSetTableAdapters.TableAdapterManager()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MasterBankBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankMasterDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.AutoSize = True
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.ForeColor = System.Drawing.Color.White
        Me.BtnBack.Location = New System.Drawing.Point(1047, 521)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(119, 41)
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
        Me.Panel3.Location = New System.Drawing.Point(3, 58)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1163, 402)
        Me.Panel3.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DTP1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbAccountType)
        Me.GroupBox1.Controls.Add(Me.TextBoxName)
        Me.GroupBox1.Controls.Add(Me.TextBoxNumber)
        Me.GroupBox1.Controls.Add(Me.TxtDeposit)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1148, 383)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Particulars"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(40, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(372, 42)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Date of transaction :"
        '
        'DTP1
        '
        Me.DTP1.CalendarMonthBackground = System.Drawing.SystemColors.Control
        Me.DTP1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "date", True))
        Me.DTP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP1.Location = New System.Drawing.Point(512, 305)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(599, 49)
        Me.DTP1.TabIndex = 11
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(40, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(269, 42)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Account type :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(40, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(357, 42)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Amount deposited :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(40, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(332, 42)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Account Number :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(40, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 42)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Account Holder Name"
        '
        'cmbAccountType
        '
        Me.cmbAccountType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "cashin", True))
        Me.cmbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccountType.Enabled = False
        Me.cmbAccountType.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccountType.FormattingEnabled = True
        Me.cmbAccountType.Items.AddRange(New Object() {"SAVINGS", "CURRENT", "FCA", "LOCAL NOSTRO"})
        Me.cmbAccountType.Location = New System.Drawing.Point(667, 241)
        Me.cmbAccountType.Name = "cmbAccountType"
        Me.cmbAccountType.Size = New System.Drawing.Size(444, 41)
        Me.cmbAccountType.TabIndex = 6
        '
        'TextBoxName
        '
        Me.TextBoxName.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBoxName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "name", True))
        Me.TextBoxName.Enabled = False
        Me.TextBoxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxName.Location = New System.Drawing.Point(512, 25)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(599, 49)
        Me.TextBoxName.TabIndex = 5
        Me.TextBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxNumber
        '
        Me.TextBoxNumber.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxNumber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBoxNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "number", True))
        Me.TextBoxNumber.Enabled = False
        Me.TextBoxNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNumber.Location = New System.Drawing.Point(512, 97)
        Me.TextBoxNumber.Name = "TextBoxNumber"
        Me.TextBoxNumber.Size = New System.Drawing.Size(599, 49)
        Me.TextBoxNumber.TabIndex = 4
        Me.TextBoxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDeposit
        '
        Me.TxtDeposit.BackColor = System.Drawing.SystemColors.Control
        Me.TxtDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDeposit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtDeposit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "deposit", True))
        Me.TxtDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDeposit.Location = New System.Drawing.Point(733, 169)
        Me.TxtDeposit.Name = "TxtDeposit"
        Me.TxtDeposit.Size = New System.Drawing.Size(378, 49)
        Me.TxtDeposit.TabIndex = 3
        Me.TxtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BankMasterDataGridView
        '
        Me.BankMasterDataGridView.AllowUserToAddRows = False
        Me.BankMasterDataGridView.AllowUserToDeleteRows = False
        Me.BankMasterDataGridView.AutoGenerateColumns = False
        Me.BankMasterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BankMasterDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.BankMasterDataGridView.DataSource = Me.MasterBankBindingSource
        Me.BankMasterDataGridView.Location = New System.Drawing.Point(9, 466)
        Me.BankMasterDataGridView.Name = "BankMasterDataGridView"
        Me.BankMasterDataGridView.ReadOnly = True
        Me.BankMasterDataGridView.RowHeadersWidth = 51
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BankMasterDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.BankMasterDataGridView.Size = New System.Drawing.Size(1148, 45)
        Me.BankMasterDataGridView.TabIndex = 12
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
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "name"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "number"
        Me.DataGridViewTextBoxColumn2.HeaderText = "number"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "deposit"
        Me.DataGridViewTextBoxColumn3.HeaderText = "deposit"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "balance"
        Me.DataGridViewTextBoxColumn5.HeaderText = "balance"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "date"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'BtnSave
        '
        Me.BtnSave.AutoSize = True
        Me.BtnSave.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(3, 521)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(99, 41)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(949, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bank Deposit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(173, 523)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 42)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Balance:-"
        '
        'TxtBalance
        '
        Me.TxtBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBalance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBalance.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "balance", True))
        Me.TxtBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBalance.Location = New System.Drawing.Point(839, 523)
        Me.TxtBalance.Name = "TxtBalance"
        Me.TxtBalance.Size = New System.Drawing.Size(192, 35)
        Me.TxtBalance.TabIndex = 8
        Me.TxtBalance.Text = "0"
        Me.TxtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtBalance.Visible = False
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
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.BackColor = System.Drawing.SystemColors.Control
        Me.lblBalance.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasterBankBindingSource, "balance", True))
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.ForeColor = System.Drawing.Color.Black
        Me.lblBalance.Location = New System.Drawing.Point(444, 523)
        Me.lblBalance.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(39, 42)
        Me.lblBalance.TabIndex = 13
        Me.lblBalance.Text = "0"
        Me.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TextBoxSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(3, 14)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(432, 38)
        Me.TextBoxSearch.TabIndex = 14
        Me.TextBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbSearch
        '
        Me.cmbSearch.BackColor = System.Drawing.SystemColors.Control
        Me.cmbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Location = New System.Drawing.Point(451, 14)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(263, 39)
        Me.cmbSearch.TabIndex = 15
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Blue
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSearch.Location = New System.Drawing.Point(720, 15)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(131, 38)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "S&earch"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'FormBankDeposit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1163, 561)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.BankMasterDataGridView)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.TxtBalance)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.BtnBack)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormBankDeposit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBankDeposit"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MasterBankBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankMasterDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBack As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DTP1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbAccountType As ComboBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxNumber As TextBox
    Friend WithEvents TxtDeposit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtBalance As TextBox
    Friend WithEvents NAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NUMBERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DEPOSITDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WITHDRAWDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BALANCEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OVERDRAFTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BankMasterDataGridView As DataGridView
    Friend WithEvents BankingDataSet As BankingDataSet
    Friend WithEvents MasterBankBindingSource As BindingSource
    Friend WithEvents MasterBankTableAdapter As BankingDataSetTableAdapters.MasterBankTableAdapter
    Friend WithEvents TableAdapterManager1 As BankingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblBalance As Label
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents btnSearch As Button
End Class
