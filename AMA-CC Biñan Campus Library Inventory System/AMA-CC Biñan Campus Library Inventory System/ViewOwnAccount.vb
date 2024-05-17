Imports System.Data.OleDb
Public Class ViewOwnAccount
    Dim sql As String
    Private Sub ViewOwnAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LibInvTableAdapter.Fill(Me.AMAInvDBDataSet.LibInv)
        Call connectstart()
        cn.Open()
        Call userinfedit()
        cmutype = New OleDbCommand("SELECT UserType FROM Users WHERE ID = '" & UID & "'", cn)
        If CStr(cmmn.ExecuteScalar) = "N/A" Then
            txtFN.Text = CStr(cmfn.ExecuteScalar) + " " + CStr(cmln.ExecuteScalar)
        Else
            txtFN.Text = CStr(cmfn.ExecuteScalar) + " " + CStr(cmmn.ExecuteScalar) + " " + CStr(cmln.ExecuteScalar)
        End If
        txtGY.Text = CStr(cmgy.ExecuteScalar)
        txtSC.Text = CStr(cmsc.ExecuteScalar)
        txtPW.Text = CPassword
        txtUID.Text = CUsername
        txtUT.Text = CStr(cmutype.ExecuteScalar)
        txtAD.Text = CStr(cmad.ExecuteScalar)
        txtCN.Text = CStr(cmconu.ExecuteScalar)
        txtITB.Text = CInt(cmitb.ExecuteScalar)
        If txtITB.Text = 0 Then
            dgvBooks.Enabled = False
            dgvBooks.Visible = False
            lblMsg.Visible = True
        Else
            dgvBooks.Enabled = True
            dgvBooks.Visible = True
            sql = "SELECT * FROM LibInv WHERE BorrowedBy = '" & txtUID.Text & "'"
            dt = New DataTable
            Try
                da = New OleDbDataAdapter(sql, cn)
                da.Fill(dt)
                dgvBooks.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cboxPW_CheckedChanged(sender As Object, e As EventArgs) Handles cboxPW.CheckedChanged
        If cboxPW.Checked = True Then
            txtPW.UseSystemPasswordChar = False
        Else
            txtPW.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainBorrower.Show()
        Me.Close()
    End Sub
End Class