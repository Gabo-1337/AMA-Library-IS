<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BReceive
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
        Me.components = New System.ComponentModel.Container()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.lblWait = New System.Windows.Forms.Label()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNO = New System.Windows.Forms.Button()
        Me.pbWait = New System.Windows.Forms.ProgressBar()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.tmrPB = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMsg.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.Red
        Me.lblMsg.Location = New System.Drawing.Point(12, 40)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(435, 80)
        Me.lblMsg.TabIndex = 32
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWait
        '
        Me.lblWait.Font = New System.Drawing.Font("Perpetua Titling MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWait.Location = New System.Drawing.Point(87, 9)
        Me.lblWait.Name = "lblWait"
        Me.lblWait.Size = New System.Drawing.Size(285, 31)
        Me.lblWait.TabIndex = 33
        Me.lblWait.Text = "Borrowing Request"
        Me.lblWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnYes
        '
        Me.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnYes.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.Location = New System.Drawing.Point(119, 178)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(75, 44)
        Me.btnYes.TabIndex = 34
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'btnNO
        '
        Me.btnNO.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnNO.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNO.Location = New System.Drawing.Point(266, 178)
        Me.btnNO.Name = "btnNO"
        Me.btnNO.Size = New System.Drawing.Size(75, 44)
        Me.btnNO.TabIndex = 35
        Me.btnNO.Text = "No"
        Me.btnNO.UseVisualStyleBackColor = True
        '
        'pbWait
        '
        Me.pbWait.Location = New System.Drawing.Point(12, 149)
        Me.pbWait.Maximum = 60
        Me.pbWait.Name = "pbWait"
        Me.pbWait.Size = New System.Drawing.Size(435, 23)
        Me.pbWait.TabIndex = 36
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTime.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Red
        Me.lblTime.Location = New System.Drawing.Point(200, 186)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(61, 28)
        Me.lblTime.TabIndex = 37
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrPB
        '
        Me.tmrPB.Enabled = True
        Me.tmrPB.Interval = 1000
        '
        'BReceive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(459, 234)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.pbWait)
        Me.Controls.Add(Me.btnNO)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.lblWait)
        Me.Controls.Add(Me.lblMsg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "BReceive"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BReceive"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblMsg As Label
    Friend WithEvents lblWait As Label
    Friend WithEvents btnYes As Button
    Friend WithEvents btnNO As Button
    Friend WithEvents pbWait As ProgressBar
    Friend WithEvents lblTime As Label
    Friend WithEvents tmrPB As Timer
End Class
