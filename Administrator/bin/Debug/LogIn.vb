Public Class LogIn
    Private Sub ButtonLogIn_Click(sender As Object, e As EventArgs) Handles ButtonLogIn.Click

        If TextBoxUsername.Text = My.Settings.Username And TextBoxPassword.Text = My.Settings.Password Then

            Me.Close()
            AllUsers.Show()

        End If
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click

        Me.Close()
        Form1.Show()

    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LogInDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.LogInDataSet.Users)

    End Sub
End Class