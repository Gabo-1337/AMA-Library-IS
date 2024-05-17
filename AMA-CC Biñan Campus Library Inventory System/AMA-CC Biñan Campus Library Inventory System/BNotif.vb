Imports System.Data.OleDb
Public Class BNotif
    Private Sub BNotif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmbrUID As New OleDbCommand("SELECT UID FROM BRequest WHERE TransID = 'Breq'", cn)
        Dim cmbrPCN As New OleDbCommand("SELECT PCName FROM BRequest WHERE TransID = 'Breq'", cn)
        Dim brUID, brPCN As String
        Call connectstart()
        cn.Open()
        brUID = cmbrUID.ExecuteScalar
        brPCN = cmbrPCN.ExecuteScalar
        lblUser.Text = "From User: " + brUID
        lblPC.Text = "From PC: " + brPCN
    End Sub

    Private Sub lblPC_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick, lblWait.MouseClick, lblUser.MouseClick, lblPC.MouseClick, Label1.MouseClick
        BReceive.Show()
        Me.Close()
    End Sub
End Class