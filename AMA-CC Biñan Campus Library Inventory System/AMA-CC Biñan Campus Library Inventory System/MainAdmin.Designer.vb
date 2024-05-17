<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainAdmin))
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblProgName = New System.Windows.Forms.Label()
        Me.btnUI = New System.Windows.Forms.Button()
        Me.lblUI = New System.Windows.Forms.Label()
        Me.lblUU = New System.Windows.Forms.Label()
        Me.btnUU = New System.Windows.Forms.Button()
        Me.lblB = New System.Windows.Forms.Label()
        Me.btnB = New System.Windows.Forms.Button()
        Me.lblUA = New System.Windows.Forms.Label()
        Me.btnUA = New System.Windows.Forms.Button()
        Me.btnLO = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.tmrReceive = New System.Windows.Forms.Timer(Me.components)
        Me.tmrWait = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDeadlineGet = New System.Windows.Forms.Timer(Me.components)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(5, 338)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 17)
        Me.lblName.TabIndex = 0
        '
        'lblProgName
        '
        Me.lblProgName.Font = New System.Drawing.Font("Perpetua Titling MT", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgName.Location = New System.Drawing.Point(136, 9)
        Me.lblProgName.Name = "lblProgName"
        Me.lblProgName.Size = New System.Drawing.Size(268, 74)
        Me.lblProgName.TabIndex = 2
        Me.lblProgName.Text = "AMA Computer College Biñan Campus" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Library Inventory System"
        Me.lblProgName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUI
        '
        Me.btnUI.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUI.Font = New System.Drawing.Font("Perpetua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUI.Location = New System.Drawing.Point(25, 139)
        Me.btnUI.Name = "btnUI"
        Me.btnUI.Size = New System.Drawing.Size(75, 39)
        Me.btnUI.TabIndex = 3
        Me.btnUI.Text = "Update Inventory"
        Me.btnUI.UseVisualStyleBackColor = True
        '
        'lblUI
        '
        Me.lblUI.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUI.Location = New System.Drawing.Point(107, 139)
        Me.lblUI.Name = "lblUI"
        Me.lblUI.Size = New System.Drawing.Size(298, 39)
        Me.lblUI.TabIndex = 4
        Me.lblUI.Text = "Add, edit or delete library information from the system" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblUI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUU
        '
        Me.lblUU.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUU.Location = New System.Drawing.Point(107, 184)
        Me.lblUU.Name = "lblUU"
        Me.lblUU.Size = New System.Drawing.Size(298, 39)
        Me.lblUU.TabIndex = 6
        Me.lblUU.Text = "View, add, edit or delete user information from the system" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblUU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUU
        '
        Me.btnUU.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUU.Font = New System.Drawing.Font("Perpetua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUU.Location = New System.Drawing.Point(25, 184)
        Me.btnUU.Name = "btnUU"
        Me.btnUU.Size = New System.Drawing.Size(75, 39)
        Me.btnUU.TabIndex = 5
        Me.btnUU.Text = "Update Users"
        Me.btnUU.UseVisualStyleBackColor = True
        '
        'lblB
        '
        Me.lblB.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.Location = New System.Drawing.Point(107, 236)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(298, 23)
        Me.lblB.TabIndex = 8
        Me.lblB.Text = "Borrow books"
        Me.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnB
        '
        Me.btnB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnB.Font = New System.Drawing.Font("Perpetua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnB.Location = New System.Drawing.Point(25, 229)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(75, 39)
        Me.btnB.TabIndex = 7
        Me.btnB.Text = "Borrow"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'lblUA
        '
        Me.lblUA.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUA.Location = New System.Drawing.Point(107, 281)
        Me.lblUA.Name = "lblUA"
        Me.lblUA.Size = New System.Drawing.Size(298, 23)
        Me.lblUA.TabIndex = 10
        Me.lblUA.Text = "View list of books borrowed by users"
        Me.lblUA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUA
        '
        Me.btnUA.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUA.Font = New System.Drawing.Font("Perpetua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUA.Location = New System.Drawing.Point(25, 274)
        Me.btnUA.Name = "btnUA"
        Me.btnUA.Size = New System.Drawing.Size(75, 39)
        Me.btnUA.TabIndex = 9
        Me.btnUA.Text = "User Account"
        Me.btnUA.UseVisualStyleBackColor = True
        '
        'btnLO
        '
        Me.btnLO.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLO.Font = New System.Drawing.Font("Perpetua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLO.Location = New System.Drawing.Point(344, 321)
        Me.btnLO.Name = "btnLO"
        Me.btnLO.Size = New System.Drawing.Size(60, 29)
        Me.btnLO.TabIndex = 11
        Me.btnLO.Text = "Log Out"
        Me.btnLO.UseVisualStyleBackColor = True
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(12, 9)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(118, 111)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 1
        Me.LogoPictureBox.TabStop = False
        '
        'tmrReceive
        '
        Me.tmrReceive.Interval = 10
        '
        'tmrWait
        '
        Me.tmrWait.Interval = 7500
        '
        'tmrDeadlineGet
        '
        '
        'MainAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(416, 362)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLO)
        Me.Controls.Add(Me.lblUA)
        Me.Controls.Add(Me.btnUA)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.lblUU)
        Me.Controls.Add(Me.btnUU)
        Me.Controls.Add(Me.lblUI)
        Me.Controls.Add(Me.btnUI)
        Me.Controls.Add(Me.lblProgName)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.lblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainAdmin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AMA-CC Biñan Campus Library Inventory System"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents lblProgName As Label
    Friend WithEvents btnUI As Button
    Friend WithEvents lblUI As Label
    Friend WithEvents lblUU As Label
    Friend WithEvents btnUU As Button
    Friend WithEvents lblB As Label
    Friend WithEvents btnB As Button
    Friend WithEvents lblUA As Label
    Friend WithEvents btnUA As Button
    Friend WithEvents btnLO As Button
    Friend WithEvents tmrReceive As Timer
    Friend WithEvents tmrWait As Timer
    Friend WithEvents tmrDeadlineGet As Timer
End Class
