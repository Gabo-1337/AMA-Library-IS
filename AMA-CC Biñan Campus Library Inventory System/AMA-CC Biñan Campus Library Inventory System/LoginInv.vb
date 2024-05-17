Imports System.Data.OleDb
Public Class LoginInv
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Call connectstart()
            cn.Open()
            If txtUser.Text = "" Or txtPw.Text = "" Then
                MessageBox.Show("Please insert required information", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                cmutype = New OleDbCommand("SELECT [UserType] FROM Users WHERE [ID] = @UID AND [Password] = @PW", cn)
                cmutype.Parameters.Add(New OleDbParameter("@UID", txtUser.Text))
                cmutype.Parameters.Add(New OleDbParameter("@PW", txtPw.Text))
                cmlogin = New OleDbCommand("SELECT * FROM Users WHERE [ID] = @UID AND [Password] = @PW", cn)
                cmlogin.Parameters.Add(New OleDbParameter("@UID", txtUser.Text))
                cmlogin.Parameters.Add(New OleDbParameter("@PW", txtPw.Text))
                cmfname = New OleDbCommand("SELECT [F_Name] FROM Users WHERE [ID] = @UID", cn)
                cmfname.Parameters.Add(New OleDbParameter("@UID", txtUser.Text))
                cmmname = New OleDbCommand("SELECT [M_Name] FROM Users WHERE [ID] = @UID", cn)
                cmmname.Parameters.Add(New OleDbParameter("@UID", txtUser.Text))
                cmlname = New OleDbCommand("SELECT [L_Name] FROM Users WHERE [ID] = @UID", cn)
                cmlname.Parameters.Add(New OleDbParameter("@UID", txtUser.Text))
                login = cmlogin.ExecuteReader
                If login.HasRows Then
                    utype = CStr(cmutype.ExecuteScalar)
                    fname = CStr(cmfname.ExecuteScalar)
                    mname = CStr(cmmname.ExecuteScalar)
                    lname = CStr(cmlname.ExecuteScalar)
                    LOGUID = txtUser.Text
                    PCN = System.Environment.MachineName
                    Try
                        Dim cmaddO As New OleDbCommand("INSERT INTO OnlineUsers VALUES (@UID, @FN, @MN, @LN, @PCN, @Utype)", cn)
                        cmaddO.Parameters.Add(New OleDbParameter("@UID", LOGUID))
                        cmaddO.Parameters.Add(New OleDbParameter("@FN", fname))
                        cmaddO.Parameters.Add(New OleDbParameter("@MN", mname))
                        cmaddO.Parameters.Add(New OleDbParameter("@LN", lname))
                        cmaddO.Parameters.Add(New OleDbParameter("@PCN", PCN))
                        cmaddO.Parameters.Add(New OleDbParameter("@UType", utype))
                        cmaddO.ExecuteNonQuery()
                    Catch ex As Exception
                        Dim cmpcn As New OleDbCommand("SELECT PCName FROM OnlineUsers WHERE [ID] = @UID", cn)
                        cmpcn.Parameters.Add(New OleDbParameter("@UID", LOGUID))
                        Dim PCNCheck As String
                        PCNCheck = CStr(cmpcn.ExecuteScalar)
                        If PCNCheck <> System.Environment.MachineName Then
                            MessageBox.Show("You were logged in last time on computer name: " + PCNCheck + vbNewLine + "Please logout next time before you close the application.", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Else
                            MessageBox.Show("Please logout next time you use your account.", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        End If
                    End Try
                    If utype = "Admin" Then
                        CUsername = txtUser.Text
                        CPassword = txtPw.Text
                        MainAdmin.Show()
                        Me.Close()
                    Else
                        CUsername = txtUser.Text
                        CPassword = txtPw.Text
                        MainBorrower.Show()
                        cn.Close()
                        Me.Close()
                    End If
                Else
                    MessageBox.Show("Incorrect Username/Password", "User not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error has occurred, please contact the creator of this system application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        cn.Close()
        Me.Close()
    End Sub

    Private Sub LoginInv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call connectstart()
            cn.Open()
            Dim cmcheck As New OleDbCommand("SELECT * FROM BRequest WHERE TransID = 'Breq'", cn)
            Dim cmcheckbres As New OleDbCommand("SELECT * FROM BRespond WHERE TransID = 'Breq'", cn)
            Dim checkbres As OleDbDataReader
            Dim check As OleDbDataReader
            check = cmcheck.ExecuteReader
            If check.HasRows = True Then
                Dim result As DialogResult = MessageBox.Show("If there is an ongoing book borrowing, press Yes to continue logging in, press No to stop the book borrowing", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If result = DialogResult.No Then
                    Dim cmdelbr As New OleDbCommand("DELETE * FROM BRequest WHERE TransID = 'Breq'", cn)
                    cmdelbr.ExecuteNonQuery()
                    checkbres = cmcheckbres.ExecuteReader
                    If checkbres.HasRows = True Then
                        Dim cmdelbres As New OleDbCommand("DELETE * FROM BRespond WHERE TransID = 'Breq'", cn)
                        cmdelbres.ExecuteNonQuery()
                    End If
                Else
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error has occurred, please contact the creator of this system application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class