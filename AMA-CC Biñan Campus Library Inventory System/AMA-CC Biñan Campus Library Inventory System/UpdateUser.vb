Imports System.Data.OleDb
Public Class UpdateUser
    Private Sub UpdateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call connectstart()
            cn.Open()
            Me.UsersTableAdapter.Fill(Me.AMAInvDBDataSet.Users)
        Catch ex As Exception
            MessageBox.Show("An error has occurred, please contact the creator of this system application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub rbAdd_CheckedChanged(sender As Object, e As EventArgs) Handles rbAdd.CheckedChanged
        lblUID.Text = "User ID:*"
        lblFN.Text = "First Name:*"
        lblMN.Text = "Middle Name:*"
        lblLN.Text = "Last Name:*"
        lblA.Text = "Address:*"
        lblCN.Text = "Contact Number:*"
        lblUT.Text = "User Type:*"
        lblPW.Text = "Password:*"
        lblGY.Text = "Grade/Year:*"
        lblSC.Text = "Section/Course:*"
        txtFN.Enabled = True
        txtMN.Enabled = True
        txtLN.Enabled = True
        txtA.Enabled = True
        txtCN.Enabled = True
        cbUType.Enabled = True
        txtPW.Enabled = True
        txtGY.Enabled = True
        txtSC.Enabled = True
    End Sub

    Private Sub rbDel_CheckedChanged(sender As Object, e As EventArgs) Handles rbDel.CheckedChanged
        lblUID.Text = "User ID:*"
        lblFN.Text = "First Name:"
        lblMN.Text = "Middle Name:"
        lblLN.Text = "Last Name:"
        lblA.Text = "Address:"
        lblCN.Text = "Contact Number:"
        lblUT.Text = "User Type:"
        lblPW.Text = "Password:"
        lblGY.Text = "Grade/Year:"
        lblSC.Text = "Section/Course:"
        txtFN.Enabled = False
        txtMN.Enabled = False
        txtLN.Enabled = False
        txtA.Enabled = False
        txtCN.Enabled = False
        cbUType.Enabled = False
        txtPW.Enabled = False
        txtGY.Enabled = False
        txtSC.Enabled = False
    End Sub

    Private Sub rbEd_CheckedChanged(sender As Object, e As EventArgs) Handles rbEd.CheckedChanged
        lblUID.Text = "User ID:*"
        lblFN.Text = "First Name:"
        lblMN.Text = "Middle Name:"
        lblLN.Text = "Last Name:"
        lblA.Text = "Address:"
        lblCN.Text = "Contact Number:"
        lblUT.Text = "User Type:"
        lblPW.Text = "Password:"
        lblGY.Text = "Grade/Year:"
        lblSC.Text = "Section/Course:"
        txtFN.Enabled = True
        txtMN.Enabled = True
        txtLN.Enabled = True
        txtA.Enabled = True
        txtCN.Enabled = True
        cbUType.Enabled = True
        txtPW.Enabled = True
        txtGY.Enabled = True
        txtSC.Enabled = True
    End Sub

    Private Sub btnApp_Click(sender As Object, e As EventArgs) Handles btnApp.Click
        Try
            Dim UID_cm As New OleDbCommand("SELECT ID FROM Users WHERE ID = '" & txtUID.Text & "'", cn)
            Dim UID_sr As String
            UID_sr = CStr(UID_cm.ExecuteScalar)
            If rbAdd.Checked = True Then
                If txtUID.Text = UID_sr Then
                    MessageBox.Show("User ID exists!", "Error adding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf txtFN.Text = "" Or txtLN.Text = "" Or txtA.Text = "" Or txtCN.Text = "" Or txtPW.Text = "" Or txtGY.Text = "" Or txtSC.Text = "" Then
                    MessageBox.Show("Information with * is required", "Error adding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    UID = txtUID.Text
                    FN = txtFN.Text
                    If txtMN.Text = "" Then
                        MN = "N/A"
                    Else
                        MN = txtMN.Text
                    End If
                    LN = txtLN.Text
                    AD = txtA.Text
                    CONU = txtCN.Text
                    UT = cbUType.Text
                    PW = txtPW.Text
                    ITB = 0
                    GY = txtGY.Text
                    SC = txtSC.Text
                    UTags = UID + " " + FN + " " + MN + " " + LN + " " + AD + " " + CONU + " " + UT + " " + GY + " " + SC
                    Call userinf()
                    cmadd.ExecuteNonQuery()
                    MessageBox.Show("User added", "Task Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf rbDel.Checked = True Then
                If txtUID.Text <> UID_sr Then
                    MessageBox.Show("User ID does not exist!", "Error deleting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf txtUID.Text = "" Then
                    MessageBox.Show("Information with * is required", "Error deleting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf txtUID.Text = CUsername Then
                    MessageBox.Show("Cannot delete current User's ID", "Error deleting", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    UID = txtUID.Text
                    Call userinf()
                    cmdel.ExecuteNonQuery()
                    MessageBox.Show("User deleted", "Task Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf rbEd.Checked = True Then
                If txtUID.Text <> UID_sr Then
                    MessageBox.Show("User ID does not exist!", "Error editing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf txtUID.Text = "" Then
                    MessageBox.Show("Information with * is required", "Error editing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    UID = txtUID.Text
                    UT = cbUType.Text
                    Call userinfedit()
                    If txtFN.Text = "" Then
                        FN = CStr(cmfn.ExecuteScalar)
                    Else
                        FN = txtFN.Text
                    End If
                    If txtMN.Text = "" Then
                        MN = CStr(cmmn.ExecuteScalar)
                    Else
                        MN = txtMN.Text
                    End If
                    If txtLN.Text = "" Then
                        LN = CStr(cmln.ExecuteScalar)
                    Else
                        LN = txtLN.Text
                    End If
                    If txtA.Text = "" Then
                        AD = CStr(cmad.ExecuteScalar)
                    Else
                        AD = txtA.Text
                    End If
                    If txtCN.Text = "" Then
                        CONU = CStr(cmconu.ExecuteScalar)
                    Else
                        CONU = txtCN.Text
                    End If
                    If txtPW.Text = "" Then
                        PW = CStr(cmpw.ExecuteScalar)
                    Else
                        PW = txtPW.Text
                    End If
                    If txtGY.Text = "" Then
                        GY = CStr(cmgy.ExecuteScalar)
                    Else
                        GY = txtGY.Text
                    End If
                    If txtSC.Text = "" Then
                        SC = CStr(cmsc.ExecuteScalar)
                    Else
                        SC = txtSC.Text
                    End If
                    UTags = UID + " " + FN + " " + MN + " " + LN + " " + AD + " " + CONU + " " + UT + " " + SC + " " + GY
                    ITB = CInt(cmitb.ExecuteScalar)
                    Call userinf()
                    cmedit.ExecuteNonQuery()
                    MessageBox.Show("User information edited", "Task Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("SELECT * FROM Users", cn)
            da.Fill(ds, "Users")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            dgvUsers.DataSource = view
        Catch ex As Exception
            MessageBox.Show("An error has occurred, please contact the creator of this system application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainAdmin.Show()
        Me.Close()
    End Sub

    Private Sub txtUID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUID.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cbUType_KeyDown(sender As Object, e As KeyEventArgs) Handles cbUType.KeyDown
        e.SuppressKeyPress = True
    End Sub
End Class