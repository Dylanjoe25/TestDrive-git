Public Class FormBankUpdateAccountHolder
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        'Me.AgainTableAdapter.Fill(Me.TryDataSet.Again)

        Me.Hide()
        Me.Dispose()
        FormBank.Show()

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Me.Hide()
        Me.Dispose()
        FormBank.Show()

    End Sub

    Private Sub FormBankUpdateAccountHolder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankingDataSet.MasterBank' table. You can move, or remove it, as needed.
        Me.MasterBankTableAdapter.Fill(Me.BankingDataSet.MasterBank)
        'TODO: This line of code loads data into the 'BankingDataSet.MasterBank' table. You can move, or remove it, as needed.
        'Me.MasterBankTableAdapter.Fill(Me.BankingDataSet.MasterBank)

    End Sub
End Class