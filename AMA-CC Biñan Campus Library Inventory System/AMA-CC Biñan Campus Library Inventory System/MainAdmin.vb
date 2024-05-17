Imports System.Data.OleDb
Public Class MainAdmin
    Private Sub MainAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connectstart()
        cn.Open()
        tmrReceive.Enabled = True
        tmrDeadlineGet.Enabled = True
        If mname = "N/A" Then
            lblName.Text = "Logged in as " & utype & ": " & fname & " " & lname
        Else
            lblName.Text = "Logged in as " & utype & ": " & fname & " " & mname & " " & lname
        End If
    End Sub
    Private Sub btnUI_Click(sender As Object, e As EventArgs) Handles btnUI.Click
        UpdateInv.Show()
        Me.Hide()
    End Sub
    Private Sub btnUU_Click(sender As Object, e As EventArgs) Handles btnUU.Click
        UpdateUser.Show()
        Me.Hide()
    End Sub
    Private Sub btnLO_Click(sender As Object, e As EventArgs) Handles btnLO.Click
        Dim cmdelLog As New OleDbCommand("DELETE * FROM OnlineUsers WHERE [ID] = @UID", cn)
        cmdelLog.Parameters.Add(New OleDbParameter("@UID", LOGUID))
        cmdelLog.ExecuteNonQuery()
        LoginInv.Show()
        CUsername = ""
        CPassword = ""
        cn.Close()
        Me.Close()
    End Sub
    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        BookInv.Show()
        Me.Hide()
    End Sub
    Private Sub btnUA_Click(sender As Object, e As EventArgs) Handles btnUA.Click
        ViewUser.Show()
        Me.Hide()
    End Sub
    Dim cmdrbreq As OleDbDataReader
    Dim cmdrbres As OleDbDataReader
    Private Sub tmrReceive_Tick(sender As Object, e As EventArgs) Handles tmrReceive.Tick
        Try
            Dim cmreadbreq As New OleDbCommand("SELECT * FROM BRequest WHERE TransID = 'Breq'", cn)
            cmdrbreq = cmreadbreq.ExecuteReader
            If cmdrbreq.HasRows = True Then
                BNotif.Show()
                btnLO.Enabled = False
                tmrReceive.Enabled = False
                cmdrbreq.Close()
            Else
                cmdrbreq.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tmrWait_Tick(sender As Object, e As EventArgs) Handles tmrWait.Tick
        Try
            cn.Open()
        Catch ex As Exception
            cn.Close()
            cn.Open()
        End Try
        Dim cmreadbreq As New OleDbCommand("SELECT * FROM BRequest WHERE TransID = 'Breq'", cn)
        Dim cmreadbres As New OleDbCommand("SELECT * FROM BRespond WHERE TransID = 'Breq'", cn)
        cmdrbreq = cmreadbreq.ExecuteReader
        cmdrbres = cmreadbres.ExecuteReader
        If cmdrbreq.HasRows = False Then
            tmrReceive.Enabled = True
        ElseIf cmdrbreq.HasRows = True Then
            Try
                Dim cmdelbr As New OleDb.OleDbCommand("DELETE * FROM BRequest WHERE TransID = 'Breq'", cn)
                cmdelbr.ExecuteNonQuery()
                tmrReceive.Enabled = True
            Catch ex As Exception
                MessageBox.Show("An error has occurred, please contact the creator of this system application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If cmdrbres.HasRows = False Then
            tmrReceive.Enabled = True
        ElseIf cmdrbres.HasRows = True Then
            Try
                Dim cmdelbrec As New OleDb.OleDbCommand("DELETE * FROM BRespond WHERE TransID = 'Breq'", cn)
                cmdelbrec.ExecuteNonQuery()
                tmrReceive.Enabled = True
            Catch ex As Exception
                MessageBox.Show("An error has occurred, please contact the creator of this system application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        tmrWait.Enabled = False
    End Sub

    Private Sub tmrDeadlineGet_Tick(sender As Object, e As EventArgs) Handles tmrDeadlineGet.Tick
        Call connectstart()
        cn.Open()
        Dim curdate As String
        curdate = System.DateTime.Now.ToString("MM/dd/yyyy")
        Dim cmgetBDD As New OleDbCommand("SELECT DueDate FROM LibInv WHERE Status = 'Borrowed'", cn)
        Dim cmreadBDD As OleDbDataReader
        Dim count As Integer
        cmreadBDD = cmgetBDD.ExecuteReader
        If cmreadBDD.HasRows = True Then
            Dim cmcountBDD As New OleDbCommand("SELECT COUNT(*)FROM LibInv WHERE DueDate = '" & curdate & "'", cn)
            count = CInt(cmcountBDD.ExecuteScalar)
            If count > 0 Then
                NotifDueDate.Show()
                tmrDeadlineGet.Enabled = False
                Me.Hide()
            Else
                tmrDeadlineGet.Enabled = False
            End If
        Else
            tmrDeadlineGet.Enabled = False
        End If
    End Sub
End Class
