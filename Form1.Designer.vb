<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FORM2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblDateAndTime = New System.Windows.Forms.Label()
        Me.DateAndTime = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.ForestGreen
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1194, 45)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EXITToolStripMenuItem, Me.FORM2ToolStripMenuItem})
        Me.FILEToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FILEToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(71, 41)
        Me.FILEToolStripMenuItem.Text = "File"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.BackColor = System.Drawing.Color.ForestGreen
        Me.EXITToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(180, 42)
        Me.EXITToolStripMenuItem.Text = "Exit"
        '
        'FORM2ToolStripMenuItem
        '
        Me.FORM2ToolStripMenuItem.BackColor = System.Drawing.Color.ForestGreen
        Me.FORM2ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.FORM2ToolStripMenuItem.Name = "FORM2ToolStripMenuItem"
        Me.FORM2ToolStripMenuItem.Size = New System.Drawing.Size(180, 42)
        Me.FORM2ToolStripMenuItem.Text = "Bank"
        '
        'lblDateAndTime
        '
        Me.lblDateAndTime.AutoSize = True
        Me.lblDateAndTime.BackColor = System.Drawing.Color.ForestGreen
        Me.lblDateAndTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateAndTime.ForeColor = System.Drawing.Color.White
        Me.lblDateAndTime.Location = New System.Drawing.Point(732, 9)
        Me.lblDateAndTime.Name = "lblDateAndTime"
        Me.lblDateAndTime.Size = New System.Drawing.Size(204, 31)
        Me.lblDateAndTime.TabIndex = 4
        Me.lblDateAndTime.Text = "Date and Time"
        '
        'DateAndTime
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DashBoard.My.Resources.Resources.FALLS
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1194, 794)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblDateAndTime)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FORM2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblDateAndTime As Label
    Friend WithEvents DateAndTime As Timer
End Class
