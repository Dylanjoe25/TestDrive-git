Public Class FormBankWithdrawal
    Dim GrantBal As Double
    Dim GrantDep As Double
    Dim GrantWit As Double
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub





    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click


        Me.Hide()
        Me.Dispose()
        FormBank.Show()

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        On Error Resume Next

        GrantWit += (Val(TxtWithdraw.Text))
        txtBalance.Text = GrantWit

        GrantBal += GrantWit



        lblBalance.Text = (lblBalance.Text - GrantBal)

        Me.Validate()
        Me.MasterBankBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.BankingDataSet)
        'Me.Close()
        'FormBank.Show()
        'SEND CONFIRMATION

        'Exit Sub

        'FormBank.Show()

        If (lblBalance.Text < 0) Then

            MsgBox("Account overdrawn", MsgBoxStyle.Information, "Bank")

            lblBalance.ForeColor = Color.Red

        End If

        If (lblBalance.Text > 0) Then

            'MsgBox("Account overdrawn", MsgBoxStyle.Information, "Bank")

            lblBalance.ForeColor = Color.Black

        End If
        MsgBox("Data saved", MsgBoxStyle.Information, "Bank")
        Me.Close()
        FormBank.Show()


    End Sub

    Private Sub MasterBankBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        '


    End Sub

    Private Sub FormBankWithdrawal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankingDataSet.MasterBank' table. You can move, or remove it, as needed.
        Me.MasterBankTableAdapter.Fill(Me.BankingDataSet.MasterBank)
        'TODO: This line of code loads data into the 'BankingDataSet.MasterBank' table. You can move, or remove it, as needed.


        TxtWithdraw.Text = ""
        txtBalance.Text = 0
        TxtAccountName.Text = ""
        TxtAccountNumber.Text = ""
        lblBalance.Text = 0
        cmbAccountType.Text = ""




        'If' (lblBalance.Text < 0) Then

        'MsgBox("Account is overdrawn. Transaction barred", MsgBoxStyle.Critical, "Bank")

        'lblBalance.ForeColor = Color.Red
        'BtnSave.Enabled = False

        'End If



    End Sub

    Private Sub TxtWithdraw_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtWithdraw.KeyDown

    End Sub

    Private Sub TxtWithdraw_TextChanged(sender As Object, e As EventArgs) Handles TxtWithdraw.TextChanged

        If Not IsNumeric(TxtWithdraw.Text) Then

            TxtWithdraw.Text = ""
            TxtWithdraw.Focus()

        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click


        On Error GoTo errX
        TxtWithdraw.Text = ""
        TxtWithdraw.Focus()

        'btnSearch.PerformClick()

        Dim searchEntry As String
        searchEntry = cmbSearch.Text

        Select Case searchEntry
            Case "name"
                Me.MasterBankBindingSource.Filter = "name = '" & TextBoxSearch.Text & "'"
                TxtWithdraw.Text = ""
                Exit Sub

            Case "number"
                Me.MasterBankBindingSource.Filter = "number = '" & TextBoxSearch.Text & "'"
                TxtWithdraw.Text = ""
                Exit Sub

            Case Else
                MsgBox("Your entry was not found", MsgBoxStyle.Exclamation, "Error")
                Exit Sub

        End Select
errX:
        ' MsgBox("Error", MsgBoxStyle.Critical, "Bank")
        Me.Close()
        FormBank.Show()

    End Sub

    Private Sub TextBoxSearch_MouseDown(sender As Object, e As MouseEventArgs) Handles TextBoxSearch.MouseDown

        TextBoxSearch.Text = ""
        TextBoxSearch.Focus()

    End Sub

    Private Sub TextBoxSearch_MouseHover(sender As Object, e As EventArgs) Handles TextBoxSearch.MouseHover


        TextBoxSearch.Text = ""
        TextBoxSearch.Focus()
        TextBoxSearch.ForeColor = Color.Red


    End Sub

    Private Sub TextBoxSearch_MouseLeave(sender As Object, e As EventArgs) Handles TextBoxSearch.MouseLeave

        TextBoxSearch.ForeColor = Color.Black


    End Sub

    Private Sub TxtWithdraw_MouseHover(sender As Object, e As EventArgs) Handles TxtWithdraw.MouseHover

        TxtWithdraw.Text = ""
        TxtWithdraw.Focus()
        TxtWithdraw.ForeColor = Color.Red

    End Sub

    Private Sub TxtWithdraw_MouseLeave(sender As Object, e As EventArgs) Handles TxtWithdraw.MouseLeave

        If (TxtWithdraw.Text = "") Then

            TxtWithdraw.Focus()
            BtnSave.Enabled = False

        Else

            BtnSave.Enabled = True

        End If

        TextBoxSearch.ForeColor = Color.Black

    End Sub
End Class