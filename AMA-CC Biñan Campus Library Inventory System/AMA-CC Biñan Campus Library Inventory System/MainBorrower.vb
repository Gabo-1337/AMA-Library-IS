Imports System.Data.OleDb
Public Class MainBorrower
    Private Sub MainBorrower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If mname = "N/A" Then
                lblName.Text = "Logged in as " & utype & ": " & fname & " " & lname
            Else
                lblName.Text = "Logged in as " & utype & ": " & fname & " " & mname & " " & lname
            End If
        Catch ex As Exception
            MessageBox.Show("An error has occurred, please contact the creator of this system application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLO_Click(sender As Object, e As EventArgs) Handles btnLO.Click
        Try
            Call connectstart()
            cn.Open()
            Dim cmdelLog As New OleDbCommand("DELETE * FROM OnlineUsers WHERE [ID] = @UID", cn)
            cmdelLog.Parameters.Add(New OleDbParameter("@UID", LOGUID))
            cmdelLog.ExecuteNonQuery()
            LoginInv.Show()
            CUsername = ""
            CPassword = ""
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("An error has occurred, please contact the creator of this system application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSB_Click(sender As Object, e As EventArgs) Handles btnSB.Click
        BookInv.Show()
        Me.Close()
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        procbtnB = "A"
        BookInv.Show()
        Me.Close()
    End Sub

    Private Sub btnMA_Click(sender As Object, e As EventArgs) Handles btnMA.Click
        UID = CUsername
        ViewOwnAccount.Show()
        Me.Close()
    End Sub
End Class