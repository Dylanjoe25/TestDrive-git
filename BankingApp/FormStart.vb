Public Class FormStart
    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

        Me.Hide()
        FormBank.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub FormStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankingDataSet.MasterBank' table. You can move, or remove it, as needed.
        Me.MasterBankTableAdapter.Fill(Me.BankingDataSet.MasterBank)
        btnExit.Top = 950
        btnExit.Left = 15

        'btnSave.Top = 700
        'btnSave.Left = 1465

        'txtBalance.Top = 700
        'txtBalance.Left = 700


        'lblBalance.Top = 715
        'lblBalance.Left = 180

        'cmbSearch.Top = 30
        'cmbSearch.Left = 1000

        'lblCaption.Top = 30
        'lblCaption.Left = 180

        'btnSearch.Top = 30
        'btnSearch.Left = 1650

        'lblName.Top = 150
        'lblName.Left = 180

        txtName.Top = 120
        txtName.Left = 700


        'lblAccountNumber.Top = 325
        'lblAccountNumber.Left = 180

        txtAccountNumber.Top = 310
        txtAccountNumber.Left = 1020




        'lblAmountDeposited.Top = 500
        'lblAmountDeposited.Left = 180

        txtDeposit.Top = 485
        txtDeposit.Left = 1020







    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub TabPage1_Click_1(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub MasterBankBindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles MasterBankBindingSource1.CurrentChanged

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        Me.Hide()
        FormBank.Show()

    End Sub

    Private Sub MasterBankBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles MasterBankBindingSource.CurrentChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged, txtDeposit.TextChanged, txtAccountNumber.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtBalance.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub

    Private Sub cmbSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearch.SelectedIndexChanged

    End Sub

    Private Sub Label_Click(sender As Object, e As EventArgs) Handles lblName.Click, lblAmountDeposited.Click, lblAccountNumber.Click, lblCaption.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblBalance.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub
End Class