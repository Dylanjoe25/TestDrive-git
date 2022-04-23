Public Class FormBankNewAccount
    Dim GrantBal As Double
    Dim GrantDep As Double
    Dim GrantWit As Double

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click


        Me.Hide()
        Me.Dispose()
        FormBank.Show()

    End Sub


    Private Sub FormBankNewAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BtnSave.Enabled = False
        btnAddNew.PerformClick()
        CashoutComboBox.Text = "SAVINGS"


    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click

        On Error Resume Next
        Me.Validate()
        'Me.GwandaDistrictTableAdapter.Update(Me.GwandaDataSet.GwandaDistrict)
        Me.MasterBankBindingSource.AddNew()

        BtnSave.Enabled = True
        NameTextBox.Text = "name"
        NumberTextBox.Text = "number"
        AddressTextBox.Text = "address"
        DepositTextBox.Text = 0
        BalanceTextBox.Text = 0
        BalanceLabel1.Text = 0

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Dim flag As Integer = 0


        'On Error Resume Next
        Try

            Do Until (flag = 4)

                Me.Validate()
                Me.TableAdapterManager.UpdateAll(Me.BankingDataSet)
                Me.MasterBankBindingSource.EndEdit()

                flag += 1

            Loop

            MsgBox("New customer successfully added.", MsgBoxStyle.Information, "Bank ^_^")
            Me.Close()
            FormBank.Show()

        Catch ex As Exception
            MsgBox("Error")

        End Try
        'Do Until (flag = 4)

        '    Me.Validate()
        '    Me.TableAdapterManager.UpdateAll(Me.BankingDataSet)
        '    Me.MasterBankBindingSource.EndEdit()

        '    flag += 1

        'Loop

        'MsgBox("New customer successfully added.", MsgBoxStyle.Information, "Bank ^_^")
        'Me.Close()
        'FormBank.Show()





    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub NameTextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles NameTextBox.MouseDown

        NameTextBox.Text = ""

    End Sub

    Private Sub NumberTextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles NumberTextBox.MouseDown

        NumberTextBox.Text = ""

    End Sub

    Private Sub AddressTextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles AddressTextBox.MouseDown

        AddressTextBox.Text = ""

    End Sub

    Private Sub DepositTextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles DepositTextBox.MouseDown

        DepositTextBox.Text = ""

    End Sub

    Private Sub BalanceTextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles BalanceTextBox.MouseDown

        BalanceTextBox.Text = ""

    End Sub

    Private Sub DepositTextBox_TextChanged(sender As Object, e As EventArgs) Handles DepositTextBox.TextChanged

        On Error Resume Next


        'GrantDep += (Val(DepositTextBox.Text))
        'BalanceTextBox.Text = GrantDep

        'GrantBal += GrantDep



        'BalanceLabel1.Text = (GrantBal + BalanceLabel1.Text)

        If Not IsNumeric(DepositTextBox.Text) Then

            DepositTextBox.Text = ""
            DepositTextBox.Focus()

        End If

        BalanceLabel1.Text = Val(DepositTextBox.Text)
        BalanceTextBox.Text = Val(DepositTextBox.Text)


    End Sub

    Private Sub BalanceTextBox_TextChanged(sender As Object, e As EventArgs) Handles BalanceTextBox.TextChanged

        If Not IsNumeric(BalanceTextBox.Text) Then
            BalanceTextBox.Text = ""

        End If

    End Sub

    Private Sub NameTextBox_MouseHover(sender As Object, e As EventArgs) Handles NameTextBox.MouseHover

        NameTextBox.ForeColor = Color.Red
        NameTextBox.Text = ""
        NameTextBox.Focus()


    End Sub

    Private Sub NameTextBox_MouseLeave(sender As Object, e As EventArgs) Handles NameTextBox.MouseLeave

        If (NameTextBox.Text = "") Then

            BtnSave.Enabled = False

        Else
            BtnSave.Enabled = True

        End If

    End Sub

    Private Sub NumberTextBox_MouseLeave(sender As Object, e As EventArgs) Handles NumberTextBox.MouseLeave

        If (NumberTextBox.Text = "") Then

            BtnSave.Enabled = False

        Else
            BtnSave.Enabled = True

        End If


    End Sub

    Private Sub NumberTextBox_MouseHover(sender As Object, e As EventArgs) Handles NumberTextBox.MouseHover

        NumberTextBox.ForeColor = Color.Red
        NumberTextBox.Text = ""
        NumberTextBox.Focus()


    End Sub

    Private Sub AddressTextBox_MouseHover(sender As Object, e As EventArgs) Handles AddressTextBox.MouseHover

        AddressTextBox.ForeColor = Color.Red
        AddressTextBox.Text = ""
        AddressTextBox.Focus()

    End Sub

    Private Sub AddressTextBox_MouseLeave(sender As Object, e As EventArgs) Handles AddressTextBox.MouseLeave

        If (AddressTextBox.Text = "") Then

            BtnSave.Enabled = False

        Else
            BtnSave.Enabled = True

        End If

    End Sub

    Private Sub DepositTextBox_MouseHover(sender As Object, e As EventArgs) Handles DepositTextBox.MouseHover

        DepositTextBox.ForeColor = Color.Red
        DepositTextBox.Text = ""
        DepositTextBox.Focus()


    End Sub


End Class