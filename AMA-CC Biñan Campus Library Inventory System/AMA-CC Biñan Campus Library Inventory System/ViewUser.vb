Imports System.Data.OleDb
Public Class ViewUser
    Dim sql As String
    Private Sub ViewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AMAInvDBDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.AMAInvDBDataSet.Users)
        Me.LibInvTableAdapter.Fill(Me.AMAInvDBDataSet.LibInv)
        Me.UsersTableAdapter.Fill(Me.AMAInvDBDataSet.Users)
        sql = "SELECT * FROM LibInv WHERE Status = 'N/A'"
        dt = New DataTable
        Try
            da = New OleDbDataAdapter(sql, cn)
            da.Fill(dt)
            dgvBooks.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgvUsers_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellEnter
        If dgvUsers.Item(2, dgvUsers.CurrentRow.Index).Value = "N/A" Then
            txtFN.Text = dgvUsers.Item(1, dgvUsers.CurrentRow.Index).Value + " " + dgvUsers.Item(3, dgvUsers.CurrentRow.Index).Value
        Else
            txtFN.Text = dgvUsers.Item(1, dgvUsers.CurrentRow.Index).Value + " " + dgvUsers.Item(2, dgvUsers.CurrentRow.Index).Value + " " + dgvUsers.Item(3, dgvUsers.CurrentRow.Index).Value
        End If
        txtUID.Text = dgvUsers.Item(0, dgvUsers.CurrentRow.Index).Value
        txtGY.Text = dgvUsers.Item(8, dgvUsers.CurrentRow.Index).Value
        txtSC.Text = dgvUsers.Item(9, dgvUsers.CurrentRow.Index).Value
        txtAD.Text = dgvUsers.Item(4, dgvUsers.CurrentRow.Index).Value
        txtCN.Text = dgvUsers.Item(5, dgvUsers.CurrentRow.Index).Value
        txtUT.Text = dgvUsers.Item(6, dgvUsers.CurrentRow.Index).Value
        txtITB.Text = dgvUsers.Item(7, dgvUsers.CurrentRow.Index).Value
        If Val(txtITB.Text) > 0 Then
            sql = "SELECT * FROM LibInv WHERE BorrowedBy = '" & txtUID.Text & "'"
            dt = New DataTable
            Try
                da = New OleDbDataAdapter(sql, cn)
                da.Fill(dt)
                dgvBooks.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            sql = "SELECT * FROM LibInv WHERE Status = 'Borrowed'"
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainAdmin.Show()
        Me.Close()
    End Sub

    Private Sub txtQS_TextChanged(sender As Object, e As EventArgs) Handles txtQS.TextChanged
        qsb = "SELECT * FROM Users WHERE [Tags] LIKE '%" & txtQS.Text & "%'"
        dt = New DataTable
        Try
            da = New OleDbDataAdapter(qsb, cn)
            da.Fill(dt)
            dgvUsers.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtQS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQS.KeyPress
        If Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtITB_TextChanged(sender As Object, e As EventArgs) Handles txtITB.TextChanged
        If txtITB.Text = 3 Then
            txtITB.ForeColor = Color.Red
        ElseIf txtITB.Text = 2 Then
            txtITB.ForeColor = Color.Yellow
        ElseIf txtITB.Text = 1 Then
            txtITB.ForeColor = Color.Green
        Else
            txtITB.ForeColor = Color.Black
        End If
    End Sub
End Class