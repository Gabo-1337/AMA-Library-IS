Imports System.Data.OleDb
Public Class BookInv
    Public daysadded As String = "3"
    Private Sub BookInv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LibInvTableAdapter.Fill(Me.AMAInvDBDataSet.LibInv)
        Call connectstart()
        cn.Open()
        If utype = "Admin" Then
            btnB.Visible = False
            btnB.Enabled = False
            Me.Text = "AMA-CC Biñan Campus Library Inventory System - Borrow Book"
            dgvBooks.Size = New Size(768, 424)
        ElseIf procbtnB = "A" Then
            btnB.Visible = False
            btnB.Enabled = False
            Me.Text = "AMA-CC Biñan Campus Library Inventory System - Borrow Book"
            txtUID.Text = CUsername
            txtUID.ReadOnly = True
            dgvBooks.Size = New Size(768, 424)
        Else
            dgvBooks.Size = New Size(768, 533)
            txtUID.ReadOnly = True
        End If
    End Sub

    Private Sub txtQS_TextChanged(sender As Object, e As EventArgs) Handles txtQS.TextChanged
        qsb = "SELECT * FROM LibInv WHERE [Tags] LIKE '%" & txtQS.Text & "%'"
        dt = New DataTable
        Try
            da = New OleDbDataAdapter(qsb, cn)
            da.Fill(dt)
            dgvBooks.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If utype = "Admin" Then
            MainAdmin.Show()
            Me.Close()
        Else
            procbtnB = ""
            MainBorrower.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        btnB.Visible = False
        btnB.Enabled = False
        Me.Text = "AMA-CC Biñan Campus Library Inventory System - Search Books - Borrow"
        dgvBooks.Size = New Size(768, 424)
        txtUID.Text = CUsername
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            If txtADays.Text = "" Then
                txtADays.Value = 1
            End If
            cmulogin = New OleDbCommand("SELECT * FROM Users WHERE ID = '" & txtUID.Text & "'", cn)
            BID = txtBID.Text
            UID = txtUID.Text
            ulogcon = cmulogin.ExecuteReader
            cmbstatus = New OleDbCommand("SELECT Status FROM LibInv WHERE BookID = " & BID, cn)
            bbstatus = CStr(cmbstatus.ExecuteScalar)
            Call userinfedit()
            cmitb = New OleDbCommand("SELECT ItemsBorrowed FROM Users WHERE ID = '" & UID & "'", cn)
            ITB = CInt(cmitb.ExecuteScalar)
            If txtBID.Text = "" Or txtUID.Text = "" Or txtPW.Text = "" Then
                MessageBox.Show("Information with * is required", "Error confirming", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf ulogcon.HasRows <> True Then
                MessageBox.Show("User ID not found or incorrect", "Error confirming", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf bbstatus <> "Available" Then
                MessageBox.Show("Book is unavailable for borrowing", "Error confirming", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf ITB = 3 Then
                MessageBox.Show("User has exceeded the number of borrowing limits", "Error confirming", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                If utype = "Admin" Then
                    BDeadline = txtDD.Text
                    BDBorrowed = txtDTT.Text
                    Note = "ALLOWED BY: " & CUsername
                    cmbedit = New OleDbCommand("UPDATE LibInv SET [Status] = 'Borrowed', [Note] =  @Note " & ", [BorrowedBy] = '" & UID & "', [DueDate] = '" & BDeadline & "', [DateBorrowed] = '" & BDBorrowed & "'  WHERE BookID = " & BID, cn)
                    cmbedit.Parameters.Add(New OleDbParameter("@Note", Note))
                    cmbedit.ExecuteNonQuery()
                    ITB = ITB + 1
                    Call userinf()
                    cmbitb = New OleDbCommand("UPDATE Users SET [ItemsBorrowed] = " & ITB & " WHERE [ID] = '" & UID & "'", cn)
                    cmbitb.ExecuteNonQuery()
                    MessageBox.Show("Book borrowing success", "Task success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf utype = "Borrower" Then
                    Dim cmcheck As New OleDbCommand("SELECT * FROM BRespond WHERE TransID = 'Breq'", cn)
                    Dim check As OleDbDataReader
                    check = cmcheck.ExecuteReader
                    If check.HasRows = False Then
                        TransID = "Breq"
                        BRUID = txtUID.Text
                        BRStatus = "'Borrowed'"
                        BRDD = txtDD.Text
                        BRBID = txtBID.Text
                        BRBB = BRUID
                        BDeadline = CStr(txtDD.Text)
                        BDBorrowed = CStr(txtDTT.Text)
                        BRPCN = System.Environment.MachineName
                        Dim cmaddBR As New OleDbCommand("INSERT INTO BRequest VALUES (@TRANSID, @BRUID, @BRStatus, @BRDD, @BRBID, @BRBB, @PCN)", cn)
                        cmaddBR.Parameters.Add(New OleDbParameter("@TRANSID", TransID))
                        cmaddBR.Parameters.Add(New OleDbParameter("@BRUID", BRUID))
                        cmaddBR.Parameters.Add(New OleDbParameter("@BRStatus", BRStatus))
                        cmaddBR.Parameters.Add(New OleDbParameter("@BRDD", BRDD))
                        cmaddBR.Parameters.Add(New OleDbParameter("@BRBID", BRBID))
                        cmaddBR.Parameters.Add(New OleDbParameter("BRBB", BRBB))
                        cmaddBR.Parameters.Add(New OleDbParameter("@PCN", PCN))
                        cmaddBR.ExecuteNonQuery()
                        btnConfirm.Enabled = False
                        btnBack.Enabled = False
                        txtADays.Enabled = False
                        txtBID.Enabled = False
                        txtPW.Enabled = False
                        dgvBooks.Enabled = False
                        txtUID.Enabled = False
                        txtQS.Enabled = False
                        WaitBRequest.Show()
                    Else
                        MessageBox.Show("Please wait until Admin is available", "Unable to request approval", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("SELECT * FROM LibInv", cn)
            da.Fill(ds, "LibInv")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            dgvBooks.DataSource = view
        Catch ex As Exception
            MessageBox.Show("An error has occurred, please contact the creator of this system application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtQS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQS.KeyPress
        If Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub
    Private Sub dgvBooks_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellEnter
        txtBID.Text = dgvBooks.Item(0, dgvBooks.CurrentRow.Index).Value
    End Sub
    Private Sub tmrDT_Tick(sender As Object, e As EventArgs) Handles tmrDT.Tick
        daysadded = txtADays.Value
        txtDTT.Text = System.DateTime.Now.ToString("MM/dd/yyyy")
        txtDD.Text = System.DateTime.Now.AddDays(daysadded).ToString("MM/dd/yyyy")
    End Sub
    Private Sub txtADays_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtADays_ValueChanged(sender As Object, e As EventArgs) Handles txtADays.ValueChanged
        If txtADays.Text = "" Then
            txtADays.Text = "1"
        ElseIf txtADays.Text = "1" Then
            lblDay.Text = "Day"
        Else
            lblDay.Text = "Days"
        End If
    End Sub
End Class