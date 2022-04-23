<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxRetype = New System.Windows.Forms.TextBox()
        Me.ButtonSignUp = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LogInDataSet = New Administrator.LogInDataSet()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New Administrator.LogInDataSetTableAdapters.UsersTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LogInDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.ButtonClose)
        Me.GroupBox1.Controls.Add(Me.ButtonSignUp)
        Me.GroupBox1.Controls.Add(Me.TextBoxRetype)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxPassword)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxUsername)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(0, -70)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(652, 406)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sign In Form"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(145, 377)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(652, 48)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 100)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "Username", True))
        Me.TextBoxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsername.Location = New System.Drawing.Point(311, 100)
        Me.TextBoxUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(238, 37)
        Me.TextBoxUsername.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 164)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Password"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "Pass", True))
        Me.TextBoxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.Location = New System.Drawing.Point(311, 164)
        Me.TextBoxPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(238, 37)
        Me.TextBoxPassword.TabIndex = 1
        Me.TextBoxPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 234)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 31)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Retype"
        '
        'TextBoxRetype
        '
        Me.TextBoxRetype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxRetype.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "Retype", True))
        Me.TextBoxRetype.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRetype.Location = New System.Drawing.Point(311, 234)
        Me.TextBoxRetype.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxRetype.Name = "TextBoxRetype"
        Me.TextBoxRetype.Size = New System.Drawing.Size(238, 37)
        Me.TextBoxRetype.TabIndex = 1
        Me.TextBoxRetype.UseSystemPasswordChar = True
        '
        'ButtonSignUp
        '
        Me.ButtonSignUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSignUp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonSignUp.Location = New System.Drawing.Point(125, 315)
        Me.ButtonSignUp.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSignUp.Name = "ButtonSignUp"
        Me.ButtonSignUp.Size = New System.Drawing.Size(121, 47)
        Me.ButtonSignUp.TabIndex = 2
        Me.ButtonSignUp.Text = "Sign Up"
        Me.ButtonSignUp.UseVisualStyleBackColor = False
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonClose.Location = New System.Drawing.Point(311, 315)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(121, 47)
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(512, 315)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(109, 17)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Log In as Admin"
        '
        'LogInDataSet
        '
        Me.LogInDataSet.DataSetName = "LogInDataSet"
        Me.LogInDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.LogInDataSet
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 336)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SignUp"
        Me.Text = "SignUp"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LogInDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ButtonClose As Button
    Friend WithEvents ButtonSignUp As Button
    Friend WithEvents TextBoxRetype As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LogInDataSet As LogInDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As LogInDataSetTableAdapters.UsersTableAdapter
End Class
