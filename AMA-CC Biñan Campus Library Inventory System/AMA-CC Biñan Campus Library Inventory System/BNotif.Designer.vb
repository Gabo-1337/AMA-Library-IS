<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BNotif
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblWait = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPC = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblWait
        '
        Me.lblWait.Font = New System.Drawing.Font("Perpetua Titling MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWait.Location = New System.Drawing.Point(35, 9)
        Me.lblWait.Name = "lblWait"
        Me.lblWait.Size = New System.Drawing.Size(285, 31)
        Me.lblWait.TabIndex = 19
        Me.lblWait.Text = "Borrowing Request"
        Me.lblWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(35, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 31)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Click anywhere to respond"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUser
        '
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUser.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(40, 71)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(280, 23)
        Me.lblUser.TabIndex = 31
        Me.lblUser.Text = "From User:"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPC
        '
        Me.lblPC.BackColor = System.Drawing.Color.Transparent
        Me.lblPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPC.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPC.Location = New System.Drawing.Point(40, 94)
        Me.lblPC.Name = "lblPC"
        Me.lblPC.Size = New System.Drawing.Size(280, 23)
        Me.lblPC.TabIndex = 32
        Me.lblPC.Text = "From PC:"
        Me.lblPC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BNotif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(354, 187)
        Me.Controls.Add(Me.lblPC)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWait)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "BNotif"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblWait As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPC As Label
End Class
