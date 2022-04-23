Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Me.Close()

    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click

        Application.Exit()
    End Sub

    Private Sub FORM2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FORM2ToolStripMenuItem.Click

        'Me.Close()
        'Me.Dispose()
        Me.Enabled = False
        FormBank.Show()
        'Me.TopMost = False
        'Me.Hide()




    End Sub

    Private Sub lblDateAndTime_Click(sender As Object, e As EventArgs) Handles lblDateAndTime.Click


    End Sub

    Private Sub DateAndTime_Tick(sender As Object, e As EventArgs) Handles DateAndTime.Tick

        lblDateAndTime.Text = Date.Now.ToString("dd MMM yyyy     hh:mm:ss")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DateAndTime.Start()
        WindowState = FormWindowState.Maximized

    End Sub
End Class
