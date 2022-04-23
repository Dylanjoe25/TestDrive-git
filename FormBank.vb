Public Class FormBank
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        'CLOSE THE FORM AND RELEASE RAM MEMORY
        Me.Close()
        Me.Dispose()
        Form1.Show()
        Form1.Enabled = True



    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub




    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click

        Me.Hide()
        Me.Dispose()
        FormBankUpdateAccountHolder.Show()

    End Sub

    Private Sub BtnAddNewAccount_Click(sender As Object, e As EventArgs) Handles BtnAddNewAccount.Click

        Me.Hide()
        Me.Dispose()
        FormBankNewAccount.Show()

    End Sub

    Private Sub BtnDeposit_Click(sender As Object, e As EventArgs) Handles BtnDeposit.Click
        Me.Close()
        Me.Dispose()
        'FormDeposit.Show()
        FormBankDeposit.Show()

    End Sub

    Private Sub BtnWithdrawal_Click(sender As Object, e As EventArgs) Handles BtnWithdrawal.Click

        Me.Hide()
        Me.Dispose()
        FormBankWithdrawal.Show()

    End Sub

    Private Sub FormBank_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblBank_Click(sender As Object, e As EventArgs) Handles lblBank.Click

        'CLOSE THE FORM AND RELEASE RAM MEMORY
        Me.Close()
        Me.Dispose()
        Form1.Show()
        Form1.Enabled = True

    End Sub
End Class