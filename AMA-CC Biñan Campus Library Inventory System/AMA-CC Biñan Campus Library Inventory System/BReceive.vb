Imports System.Data.OleDb
Public Class BReceive
    Dim cmbrUID, cmbrPCN, cmbrS, cmbrDD, cmbrBID, cmbrBB, cmbredit, cmbrdel, cmbradd As New OleDbCommand
    Dim BRUID, BRPCN, BRS, BRDD, BRBID, BRBB As String
    Private Sub tmrPB_Tick(sender As Object, e As EventArgs) Handles tmrPB.Tick
        If pbWait.Value < pbWait.Maximum Then
            pbWait.Value += 1
        Else
            pbWait.Value = pbWait.Minimum
        End If
        lblTime.Text = pbWait.Maximum - pbWait.Value
        If pbWait.Value = pbWait.Maximum Then
            MainAdmin.btnLO.Enabled = True
            Dim cmdelbr As New OleDb.OleDbCommand("DELETE * FROM BRequest WHERE TransID = '" & TransID & "'", cn)
            cmdelbr.ExecuteNonQuery()
            cmbradd = New OleDbCommand("INSERT INTO BRespond VALUES ('Breq', No, 'N/A')", cn)
            cmbradd.ExecuteNonQuery()
            MainAdmin.tmrWait.Enabled = True
            MessageBox.Show("Request timed out, request rejected", "Admin respond time out", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tmrPB.Enabled = False
            Me.Close()
        End If
    End Sub
    Private Sub BReceive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrPB.Enabled = True
        cmbrUID = New OleDbCommand("SELECT [UID] FROM BRequest WHERE TransID = 'Breq'", cn)
        cmbrPCN = New OleDbCommand("SELECT [PCName] FROM BRequest WHERE TransID = 'Breq'", cn)
        cmbrS = New OleDbCommand("SELECT [BRStatus] FROM BRequest WHERE TransID = 'Breq'", cn)
        cmbrDD = New OleDbCommand("SELECT [BRDueDate] FROM BRequest WHERE TransID = 'Breq'", cn)
        cmbrBID = New OleDbCommand("SELECT [BRBID] FROM BRequest WHERE TransID = 'Breq'", cn)
        cmbrBB = New OleDbCommand("SELECT [BRBB] FROM BRequest WHERE TransID = 'Breq'", cn)
        BRUID = CStr(cmbrUID.ExecuteScalar)
        BRPCN = CStr(cmbrPCN.ExecuteScalar)
        BRS = CStr(cmbrS.ExecuteScalar)
        BRDD = CStr(cmbrDD.ExecuteScalar)
        BRBID = CStr(cmbrBID.ExecuteScalar)
        BRBB = CStr(cmbrBB.ExecuteScalar)
        lblMsg.Text = "Allow user " & BRUID & " to borrow book " & BRBID & " from " & System.DateTime.Now.ToString("MM/dd/yyyy") & " until " & BRDD & " ?"

    End Sub

    Private Sub btnNO_Click(sender As Object, e As EventArgs) Handles btnNO.Click
        cmbradd = New OleDbCommand("INSERT INTO BRespond VALUES ('Breq', No, 'N/A')", cn)
        cmbradd.ExecuteNonQuery()
        MainAdmin.tmrWait.Enabled = True
        MainAdmin.btnLO.Enabled = True
        Me.Close()
    End Sub
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Dim AID As String
        AID = CUsername
        cmbradd = New OleDbCommand("INSERT INTO BRespond VALUES ('Breq', Yes, '" & AID & "')", cn)
        cmbradd.ExecuteNonQuery()
        MainAdmin.tmrWait.Enabled = True
        MainAdmin.btnLO.Enabled = True
        Me.Close()
    End Sub
End Class