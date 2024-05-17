Imports System.Data.OleDb
Public Class WaitBRequest
    Private Sub tmrPB_Tick(sender As Object, e As EventArgs) Handles tmrPB.Tick
        Try
            If pbWait.Value < pbWait.Maximum Then
                pbWait.Value += 1
            Else
                pbWait.Value = pbWait.Minimum
            End If
            lblTime.Text = pbWait.Maximum - pbWait.Value
            If pbWait.Value = pbWait.Maximum Then
                tmrPB.Enabled = False
                pbWait.BackColor = Color.Red
                Dim cmdelbr As New OleDb.OleDbCommand("DELETE * FROM BRequest WHERE TransID = '" & TransID & "'", cn)
                cmdelbr.ExecuteNonQuery()
                MessageBox.Show("Request timed out, try again later", "Admin did not respond", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BookInv.btnConfirm.Enabled = True
                BookInv.btnBack.Enabled = True
                BookInv.txtADays.Enabled = True
                BookInv.txtBID.Enabled = True
                BookInv.txtPW.Enabled = True
                BookInv.dgvBooks.Enabled = True
                BookInv.txtUID.Enabled = True
                BookInv.txtQS.Enabled = True
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("An error has occurred, please contact the creator of this system application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub WaitBRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrPB.Enabled = True
        tmrReq.Enabled = True
        Call connectstart()
        cn.Open()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim cmdelbr As New OleDb.OleDbCommand("DELETE * FROM BRequest WHERE TransID = '" & TransID & "'", cn)
        cmdelbr.ExecuteNonQuery()
        BookInv.btnConfirm.Enabled = True
        BookInv.btnBack.Enabled = True
        BookInv.txtADays.Enabled = True
        BookInv.txtBID.Enabled = True
        BookInv.txtPW.Enabled = True
        BookInv.dgvBooks.Enabled = True
        BookInv.txtUID.Enabled = True
        BookInv.txtQS.Enabled = True
        Me.Close()
    End Sub

    Private Sub tmrReq_Tick(sender As Object, e As EventArgs) Handles tmrReq.Tick
        Try
            Dim cmbrec As New OleDbCommand("SELECT * FROM BRespond WHERE TransID = 'Breq'", cn)
            Dim cmbrecres As New OleDbCommand("SELECT [Answer] FROM BRespond WHERE TransID = 'Breq'", cn)
            Dim cmbrecaid As New OleDbCommand("SELECT [AID] FROM BRespond WHERE TransID = 'Breq'", cn)
            Dim cmreadbrec As OleDbDataReader
            Dim brec As Boolean
            Dim AID As String
            cmreadbrec = cmbrec.ExecuteReader
            If cmreadbrec.HasRows = True Then
                cmreadbrec.Close()
                brec = CBool(cmbrecres.ExecuteScalar)
                AID = CStr(cmbrecaid.ExecuteScalar)
                If brec = True Then
                    tmrPB.Enabled = False
                    tmrReq.Enabled = False
                    lblWait.Text = "Admin Approved"
                    btnCancel.Enabled = False
                    pbWait.Value = 300
                    BDeadline = CStr(BDeadline)
                    BDBorrowed = BDBorrowed
                    Note = "ALLOWED BY: " & AID
                    cmbedit = New OleDbCommand("UPDATE LibInv SET [Status] = 'Borrowed', [Note] =  @Note " & ", [BorrowedBy] = '" & BRUID & "', [DueDate] = '" & BDeadline & "', [DateBorrowed] = '" & BDBorrowed & "' WHERE BookID = " & BRBID, cn)
                    cmbedit.Parameters.Add(New OleDbParameter("@Note", Note))
                    cmbedit.ExecuteNonQuery()
                    ITB = ITB + 1
                    Call userinf()
                    cmbitb = New OleDbCommand("UPDATE Users SET [ItemsBorrowed] = " & ITB & " WHERE [ID] = '" & BRUID & "'", cn)
                    cmbitb.ExecuteNonQuery()
                    Dim cmdelbr As New OleDb.OleDbCommand("DELETE * FROM BRequest WHERE TransID = 'Breq'", cn)
                    cmdelbr.ExecuteNonQuery()
                    Dim cmdelbrec As New OleDb.OleDbCommand("DELETE * FROM BRespond WHERE TransID = 'Breq'", cn)
                    cmdelbrec.ExecuteNonQuery()
                    pbWait.ForeColor = Color.Green
                    MessageBox.Show("Book borrowing success", "Task success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BookInv.btnConfirm.Enabled = True
                    BookInv.btnBack.Enabled = True
                    BookInv.txtADays.Enabled = True
                    BookInv.txtBID.Enabled = True
                    BookInv.txtPW.Enabled = True
                    BookInv.dgvBooks.Enabled = True
                    BookInv.txtUID.Enabled = True
                    BookInv.txtQS.Enabled = True
                    Me.Close()
                ElseIf brec = False Then
                    tmrPB.Enabled = False
                    tmrReq.Enabled = False
                    lblWait.Text = "Admin Denied"
                    btnCancel.Enabled = False
                    pbWait.Value = 300
                    pbWait.ForeColor = Color.Red
                    Dim cmdelbr As New OleDb.OleDbCommand("DELETE * FROM BRequest WHERE TransID = 'Breq'", cn)
                    cmdelbr.ExecuteNonQuery()
                    Dim cmdelbrec As New OleDb.OleDbCommand("DELETE * FROM BRespond WHERE TransID = 'Breq'", cn)
                    cmdelbrec.ExecuteNonQuery()
                    MessageBox.Show("Admin responded No", "Cannot borrow", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    BookInv.btnConfirm.Enabled = True
                    BookInv.btnBack.Enabled = True
                    BookInv.txtADays.Enabled = True
                    BookInv.txtBID.Enabled = True
                    BookInv.txtPW.Enabled = True
                    BookInv.dgvBooks.Enabled = True
                    BookInv.txtUID.Enabled = True
                    BookInv.txtQS.Enabled = True
                    Me.Close()
                End If
            Else
                cmreadbrec.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("An error has occurred, please contact the creator of this system application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class