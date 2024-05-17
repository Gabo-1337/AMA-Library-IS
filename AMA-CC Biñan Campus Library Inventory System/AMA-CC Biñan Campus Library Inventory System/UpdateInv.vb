Imports System.Data.OleDb
Public Class UpdateInv
    Private Sub UpdateInv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.LibInvTableAdapter.Fill(Me.AMAInvDBDataSet.LibInv)
        Catch ex As Exception
            MessageBox.Show("An error has occurred, please contact the creator of this system application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub rbAdd_CheckedChanged(sender As Object, e As EventArgs) Handles rbAdd.CheckedChanged
        lblBID.Text = "Book ID:*"
        lblBN.Text = "Book Name:*"
        lblBA.Text = "Book Author:*"
        lblBG.Text = "Book Genre:*"
        lblBY.Text = "Book Year:*"
        lblPB.Text = "Published By:*"
        lblS.Text = "Status:*"
        lblN.Text = "Note:"
        lblLoc.Text = "Location:*"
        cbStatus.Enabled = True
        cbStatus.Text = "Available"
        txtBN.Enabled = True
        txtBA.Enabled = True
        txtBG.Enabled = True
        txtBY.Enabled = True
        txtPB.Enabled = True
        cbStatus.Enabled = True
        txtN.Enabled = True
        txtLoc.Enabled = True
    End Sub

    Private Sub cbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatus.SelectedIndexChanged
        If cbStatus.Enabled = True Then
            If cbStatus.Text = "Available" Then
                lblBD.Text = "Book Damage:"
                txtBD.Enabled = False
                txtBD.Text = ""
            Else
                lblBD.Text = "Book Damage:*"
                txtBD.Enabled = True
                lblN.Text = "Note:*"
            End If
        Else
            txtBD.Enabled = False
        End If
    End Sub

    Private Sub rbEd_CheckedChanged(sender As Object, e As EventArgs) Handles rbEd.CheckedChanged
        lblBID.Text = "Book ID:*"
        lblBN.Text = "Book Name:"
        lblBA.Text = "Book Author:"
        lblBG.Text = "Book Genre:"
        lblBY.Text = "Book Year:"
        lblPB.Text = "Published By:"
        lblS.Text = "Status:"
        lblN.Text = "Note:"
        lblLoc.Text = "Location:"
        txtBN.Enabled = True
        txtBA.Enabled = True
        txtBG.Enabled = True
        txtBY.Enabled = True
        txtPB.Enabled = True
        cbStatus.Enabled = True
        txtN.Enabled = True
        txtLoc.Enabled = True
    End Sub

    Private Sub rbDel_CheckedChanged(sender As Object, e As EventArgs) Handles rbDel.CheckedChanged
        lblBID.Text = "Book ID:*"
        lblBN.Text = "Book Name:"
        lblBA.Text = "Book Author:"
        lblBG.Text = "Book Genre:"
        lblBY.Text = "Book Year:"
        lblPB.Text = "Published By:"
        lblS.Text = "Status:"
        lblN.Text = "Note:"
        lblLoc.Text = "Location:"
        cbStatus.Text = "Available"
        txtBN.Enabled = False
        txtBA.Enabled = False
        txtBG.Enabled = False
        txtBY.Enabled = False
        txtPB.Enabled = False
        cbStatus.Enabled = False
        txtN.Enabled = False
        txtLoc.Enabled = False
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If utype = "Admin" Then
            MainAdmin.Show()
            Me.Close()
        Else
            MainBorrower.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnApp_Click(sender As Object, e As EventArgs) Handles btnApp.Click
        Try
            Call connectstart()
            cn.Open()
            Dim BID_cm As New OleDbCommand("SELECT BookID FROM LibInv WHERE BookID = " & txtBID.Text, cn)
            Dim BID_sr As Integer = CInt(BID_cm.ExecuteScalar)
            If rbAdd.Checked = True Then
                If txtBID.Text = BID_sr Then
                    MessageBox.Show("Book ID exists!", "Error adding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf txtBID.Text = "" Or txtBN.Text = "" Or txtBA.Text = "" Or txtBG.Text = "" Or txtBY.Text = "" Or txtPB.Text = "" Or cbStatus.Text = "" Or txtLoc.Text = "" Then
                    MessageBox.Show("Information with * is required", "Error adding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    BID = Val(txtBID.Text)
                    BN = txtBN.Text
                    BA = txtBA.Text
                    BG = txtBG.Text
                    BY = txtBY.Text
                    PB = txtPB.Text
                    Status = cbStatus.Text
                    BD = txtBD.Text
                    Note = txtN.Text
                    BB = "N/A"
                    If Note = "" Then
                        Note = "N/A"
                    End If
                    If BD = "" Then
                        BD = "N/A"
                    End If
                    LOC = txtLoc.Text
                    If Tags = "" Then
                        Tags = BID & " " & BN & " " & BA & " " & BG & " " & BY & " " & PB & " " & Status & " " & BD & " " & Note & " " & BB & " " & LOC
                    End If
                    BDeadline = "N/A"
                    BDBorrowed = "N/A"
                    Call libinf()
                    cmadd.ExecuteNonQuery()
                    MessageBox.Show("Book added", "Task Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf rbDel.Checked = True Then
                If txtBID.Text <> BID_sr Then
                    MessageBox.Show("Book ID does not exist!", "Error deleting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf txtBID.Text = "" Then
                    MessageBox.Show("Information with * is required", "Error deleting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    BID = Val(txtBID.Text)
                    Call libinf()
                    cmdel.ExecuteNonQuery()
                    MessageBox.Show("Book deleted", "Task Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf rbEd.Checked = True Then
                If txtBID.Text <> BID_sr Then
                    MessageBox.Show("Book ID does not exist!", "Error editing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf txtBID.Text = "" Then
                    MessageBox.Show("Information with * is required", "Error editing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf cbStatus.Text = "Damaged" And txtBD.Text = "" Then
                    MessageBox.Show("Information with * is required", "Error editing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    BID = Val(txtBID.Text)
                    Call libinfedit()
                    BStatus = CStr(cmstatus.ExecuteScalar)
                    bBB = CStr(cmbb.ExecuteScalar)
                    If txtBN.Text = "" Then
                        BN = CStr(cmbn.ExecuteScalar)
                    Else
                        BN = txtBN.Text
                    End If
                    If txtBA.Text = "" Then
                        BA = CStr(cmba.ExecuteScalar)
                    Else
                        BA = txtBA.Text
                    End If
                    If txtBG.Text = "" Then
                        BG = CStr(cmbg.ExecuteScalar)
                    Else
                        BG = txtBG.Text
                    End If
                    If txtBY.Text = "" Then
                        BY = CStr(cmby.ExecuteScalar)
                    Else
                        BY = txtBY.Text
                    End If
                    If txtPB.Text = "" Then
                        PB = CStr(cmpb.ExecuteScalar)
                    Else
                        PB = txtPB.Text
                    End If
                    If cbStatus.Text = "" Then
                        Status = CStr(cmstatus.ExecuteScalar)
                    Else
                        Status = cbStatus.Text
                    End If
                    If txtBD.Text = "" Then
                        BD = "N/A"
                    Else
                        BD = txtBD.Text
                    End If
                    If cbStatus.Text <> "Borrowed" Then
                        BB = "N/A"
                    Else
                        BB = CStr(cmbb.ExecuteScalar)
                    End If
                    If txtN.Text <> "" Then
                        Note = txtN.Text
                    Else
                        Note = "N/A"
                    End If
                    If txtLoc.Text = "" Then
                        LOC = CStr(cmloc.ExecuteScalar)
                    Else
                        LOC = txtLoc.Text
                    End If
                    BDeadline = "N/A"
                    BDBorrowed = "N/A"
                    Tags = BID & " " & BN & " " & BA & " " & BG & " " & BY & " " & PB & " " & Status & " " & BD & " " & Note & " " & BB & " " & LOC
                    If btnApp.Text = "Clear" Then
                        hBID = BID
                        hBN = BN
                        hBG = BG
                        hBA = BA
                        hBY = BY
                        hPB = PB
                        hStatus = Status
                        hDD = Note
                        hBB = BB
                        hDR = System.DateTime.Now.ToString("MM/dd/yyyy")
                        Status = "Available"
                        BB = "N/A"
                        hTID = Date.Now.ToString("yyyyMM")
                        Try
                            cmhstid = New OleDbCommand("SELECT COUNT(*) FROM History WHERE TransactionID LIKE '%" & hTID & "%'", cn)
                            Dim count As Integer = CInt(cmhstid.ExecuteScalar)
                            hTID += "0000"
                            While count > 0
                                hTID += 1
                                count -= 1
                            End While
                            cmhsadd = New OleDbCommand("INSERT INTO History VALUES (@hBID, @hBN, @hBG, @hBA, @hBY, @hPB, @hStatus, @hDD, @hBB, @hDR, @hTID)", cn)
                            cmhsadd.Parameters.Add(New OleDbParameter("@hBID", hBID))
                            cmhsadd.Parameters.Add(New OleDbParameter("@hBN", hBN))
                            cmhsadd.Parameters.Add(New OleDbParameter("@hBG", hBG))
                            cmhsadd.Parameters.Add(New OleDbParameter("@hBA", hBA))
                            cmhsadd.Parameters.Add(New OleDbParameter("@hBY", hBY))
                            cmhsadd.Parameters.Add(New OleDbParameter("@hPB", hPB))
                            cmhsadd.Parameters.Add(New OleDbParameter("@hStatus", hStatus))
                            cmhsadd.Parameters.Add(New OleDbParameter("@hDD", hDD))
                            cmhsadd.Parameters.Add(New OleDbParameter("@hBB", hBB))
                            cmhsadd.Parameters.Add(New OleDbParameter("@hDR", hDR))
                            cmhsadd.Parameters.Add(New OleDbParameter("@hTID", hTID))
                            cmhsadd.ExecuteNonQuery()
                        Catch ex As Exception
                            MessageBox.Show("An error has occurred, please contact the creator of this system application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                    If BStatus = "Borrowed" Then
                        Try
                            Note = "N/A"
                            Call libinf()
                            cmedit.ExecuteNonQuery()
                            MessageBox.Show("Book information edited", "Task Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Call userinfedit()
                            cmitb = New OleDbCommand("SELECT ItemsBorrowed FROM Users WHERE ID = '" & bBB & "'", cn)
                            ITB = CInt(cmitb.ExecuteScalar)
                            ITB = Val(ITB) - 1
                            Call userinf()
                            cmedit = New OleDbCommand("UPDATE Users SET [ItemsBorrowed] = " & ITB & " WHERE [ID] = '" & bBB & "'", cn)
                            cmedit.ExecuteNonQuery()
                        Catch ex As Exception
                            MessageBox.Show("An error has occurred, please contact the creator of this system application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    ElseIf BStatus <> "Borrowed" Then
                        Try
                            Call libinf()
                            cmedit.ExecuteNonQuery()
                            MessageBox.Show("Book information edited", "Task Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Catch ex As Exception
                            MessageBox.Show("An error has occurred, please contact the creator of this system application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                End If
            End If
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("SELECT * FROM LibInv", cn)
            da.Fill(ds, "LibInv")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            dgvLibInv.DataSource = view
        Catch ex As Exception
            MessageBox.Show("An error has occurred, please contact the creator of this system application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtBID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBID.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub cbStatus_TextChanged(sender As Object, e As EventArgs) Handles cbStatus.TextChanged
        If cbStatus.Text = "Borrowed" Then
            btnApp.Text = "Clear"
            cbStatus.Enabled = False
        Else
            btnApp.Text = "Apply"
            cbStatus.Enabled = True
        End If
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        HistoryForm.Show()
        Me.Hide()
    End Sub

    Private Sub dgvLibInv_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLibInv.CellEnter
        If rbEd.Checked = True Then
            txtBID.Text = dgvLibInv.Item(0, dgvLibInv.CurrentRow.Index).Value
            cbStatus.Text = dgvLibInv.Item(6, dgvLibInv.CurrentRow.Index).Value
            txtN.Text = dgvLibInv.Item(10, dgvLibInv.CurrentRow.Index).Value
        ElseIf rbDel.Checked = True Then
            txtBID.Text = dgvLibInv.Item(0, dgvLibInv.CurrentRow.Index).Value
        End If
    End Sub
End Class