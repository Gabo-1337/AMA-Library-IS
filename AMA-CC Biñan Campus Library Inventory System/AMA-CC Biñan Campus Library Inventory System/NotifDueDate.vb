Imports System.Data.OleDb
Public Class NotifDueDate
    Private Sub NotifDueDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                qsb = ("SELECT * FROM LibInv WHERE [DueDate] LIKE '%" & curdate & "'")
            End If
        End If
        Me.LibInvTableAdapter.Fill(Me.AMAInvDBDataSet.LibInv)
        dt = New DataTable
        Try
            da = New OleDbDataAdapter(qsb, cn)
            da.Fill(dt)
            dgvBDD.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCloseNotif_Click(sender As Object, e As EventArgs) Handles btnCloseNotif.Click
        MainAdmin.Show()
        Me.Close()
    End Sub

    Private Sub btnOPENVU_Click(sender As Object, e As EventArgs) Handles btnOPENVU.Click
        MainAdmin.Close()
        ViewUser.Show()
        Me.Close()
    End Sub
End Class