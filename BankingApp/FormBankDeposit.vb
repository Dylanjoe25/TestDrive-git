Public Class FormBankDeposit
    Dim GrantBal As Double
    Dim GrantDep As Double
    Dim GrantWit As Double

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        Me.Dispose()
        FormBank.Show()

    End Sub


    Private Sub BtnExit_Click(sender As Object, e As EventArgs)

        Application.Exit()

    End Sub





    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        'Dim cont As Double
        On Error Resume Next

        GrantDep += (Val(TxtDeposit.Text))
        TxtBalance.Text = GrantDep

        GrantBal += GrantDep



        lblBalance.Text = (GrantBal + lblBalance.Text)

        Me.Validate()
        Me.MasterBankBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.BankingDataSet)


        If (lblBalance.Text < 0) Then

            MsgBox("Account overdrawn", MsgBoxStyle.Information, "Bank")

            lblBalance.ForeColor = Color.Red

        End If

        If (lblBalance.Text > 0) Then

            'MsgBox("Account overdrawn", MsgBoxStyle.Information, "Bank")

            lblBalance.ForeColor = Color.Black

        End If
        'Me.Close()
        'FormBank.Show()
        'SEND CONFIRMATION

        'Exit Sub

        'FormBank.Show()
        MsgBox("Data saved", MsgBoxStyle.Information, "Bank")
        Me.Close()
        FormBank.Show()




    End Sub

    Private Sub FormBankDeposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankingDataSet.MasterBank' table. You can move, or remove it, as needed.
        Me.MasterBankTableAdapter.Fill(Me.BankingDataSet.MasterBank)

        'DEFAULT VALUES ON THE FORM ON LOAD
        TxtDeposit.Text = 0
        TextBoxSearch.Focus()
        TxtBalance.Text = 0
        TextBoxSearch.Text = "type here"
        TextBoxName.Text = ""
        TextBoxNumber.Text = ""
        cmbAccountType.Text = "acc. type"
        lblBalance.Text = 0

        ' DTP1.Value = ""
        'cmbSearch.Enabled = False

        'btnSearch.Enabled = False


        cmbSearch.Items.Add("name")
        cmbSearch.Items.Add("number")


    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.MasterBankTableAdapter.FillBy(Me.BankingDataSet.MasterBank)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNumber.TextChanged

    End Sub

    Private Sub TxtDeposit_MouseDown(sender As Object, e As MouseEventArgs) Handles TxtDeposit.MouseDown

        TxtDeposit.Text = ""
        TxtDeposit.Focus()

    End Sub

    Private Sub TextBoxSearch_MouseDown(sender As Object, e As MouseEventArgs) Handles TextBoxSearch.MouseDown

        TextBoxSearch.Text = ""
        TextBoxSearch.Focus()


    End Sub

    Private Sub TextBoxSearch_Validated(sender As Object, e As EventArgs) Handles TextBoxSearch.Validated

        If (TextBoxSearch.Text = "") Then

            MsgBox("Error")

        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        On Error GoTo errX
        TxtDeposit.Text = ""
        TxtDeposit.Focus()


        'btnSearch.PerformClick()

        Dim searchEntry As String
        searchEntry = cmbSearch.Text

        Select Case searchEntry
            Case "name"
                Me.MasterBankBindingSource.Filter = "name = '" & TextBoxSearch.Text & "'"
                TxtDeposit.Text = ""
                Exit Sub

            Case "number"
                Me.MasterBankBindingSource.Filter = "number = '" & TextBoxSearch.Text & "'"
                TxtDeposit.Text = ""
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

    Private Sub TxtDeposit_TextChanged(sender As Object, e As EventArgs) Handles TxtDeposit.TextChanged

        If Not IsNumeric(TxtDeposit.Text) Then
            TxtDeposit.Text = ""

        End If

    End Sub

    Private Sub TextBoxSearch_MouseHover(sender As Object, e As EventArgs) Handles TextBoxSearch.MouseHover


        TextBoxSearch.Text = ""
        TextBoxSearch.Focus()
        TextBoxSearch.ForeColor = Color.Red

    End Sub

    Private Sub TextBoxSearch_MouseLeave(sender As Object, e As EventArgs) Handles TextBoxSearch.MouseLeave

        TextBoxSearch.ForeColor = Color.Black

    End Sub

    Private Sub TxtDeposit_MouseHover(sender As Object, e As EventArgs) Handles TxtDeposit.MouseHover

        TxtDeposit.Text = ""
        TextBoxSearch.ForeColor = Color.Red

    End Sub

    Private Sub TxtDeposit_MouseLeave(sender As Object, e As EventArgs) Handles TxtDeposit.MouseLeave

        If (TxtDeposit.Text = "") Then

            TxtDeposit.Focus()
            BtnSave.Enabled = False

        Else

            BtnSave.Enabled = True

        End If

        TextBoxSearch.ForeColor = Color.Black

    End Sub
End Class