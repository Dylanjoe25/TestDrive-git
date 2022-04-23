Public Class SignUp
    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LogInDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.LogInDataSet.Users)


    End Sub

    Private Sub ButtonSignUp_Click(sender As Object, e As EventArgs) Handles ButtonSignUp.Click

        Try
            My.Settings.Username = TextBoxUsername.Text
            My.Settings.Password = TextBoxPassword.Text
            My.Settings.Retype = TextBoxRetype.Text
            My.Settings.Save()
            MsgBox("Your account has been created")
            Application.Restart()



        Catch ex As Exception

            MsgBox("Your account was not created")

        End Try
    End Sub

    Private Sub TextBoxRetype_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRetype.TextChanged

        If Not TextBoxRetype.Text = TextBoxPassword.Text Then
            Label4.Text = "Password does not match"

        Else
            Label4.Text = ""

        End If
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click

        Me.Close()
        Form1.Show()

    End Sub
End Class