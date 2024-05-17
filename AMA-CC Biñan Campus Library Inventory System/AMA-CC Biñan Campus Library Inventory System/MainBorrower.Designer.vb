<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainBorrower
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainBorrower))
        Me.btnLO = New System.Windows.Forms.Button()
        Me.lblB = New System.Windows.Forms.Label()
        Me.btnB = New System.Windows.Forms.Button()
        Me.lblUU = New System.Windows.Forms.Label()
        Me.btnMA = New System.Windows.Forms.Button()
        Me.lblUI = New System.Windows.Forms.Label()
        Me.btnSB = New System.Windows.Forms.Button()
        Me.lblProgName = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLO
        '
        Me.btnLO.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLO.Font = New System.Drawing.Font("Perpetua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLO.Location = New System.Drawing.Point(344, 321)
        Me.btnLO.Name = "btnLO"
        Me.btnLO.Size = New System.Drawing.Size(60, 29)
        Me.btnLO.TabIndex = 23
        Me.btnLO.Text = "Log Out"
        Me.btnLO.UseVisualStyleBackColor = True
        '
        'lblB
        '
        Me.lblB.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.Location = New System.Drawing.Point(107, 236)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(298, 23)
        Me.lblB.TabIndex = 20
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
        Me.btnB.TabIndex = 19
        Me.btnB.Text = "Borrow"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'lblUU
        '
        Me.lblUU.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUU.Location = New System.Drawing.Point(107, 184)
        Me.lblUU.Name = "lblUU"
        Me.lblUU.Size = New System.Drawing.Size(298, 39)
        Me.lblUU.TabIndex = 18
        Me.lblUU.Text = "View own account and transactions"
        Me.lblUU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMA
        '
        Me.btnMA.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnMA.Font = New System.Drawing.Font("Perpetua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMA.Location = New System.Drawing.Point(25, 184)
        Me.btnMA.Name = "btnMA"
        Me.btnMA.Size = New System.Drawing.Size(75, 39)
        Me.btnMA.TabIndex = 17
        Me.btnMA.Text = "My Account"
        Me.btnMA.UseVisualStyleBackColor = True
        '
        'lblUI
        '
        Me.lblUI.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUI.Location = New System.Drawing.Point(107, 139)
        Me.lblUI.Name = "lblUI"
        Me.lblUI.Size = New System.Drawing.Size(298, 39)
        Me.lblUI.TabIndex = 16
        Me.lblUI.Text = "Search books to locate in the library"
        Me.lblUI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSB
        '
        Me.btnSB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSB.Font = New System.Drawing.Font("Perpetua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSB.Location = New System.Drawing.Point(25, 139)
        Me.btnSB.Name = "btnSB"
        Me.btnSB.Size = New System.Drawing.Size(75, 39)
        Me.btnSB.TabIndex = 15
        Me.btnSB.Text = "Search Books"
        Me.btnSB.UseVisualStyleBackColor = True
        '
        'lblProgName
        '
        Me.lblProgName.Font = New System.Drawing.Font("Perpetua Titling MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgName.Location = New System.Drawing.Point(106, 9)
        Me.lblProgName.Name = "lblProgName"
        Me.lblProgName.Size = New System.Drawing.Size(298, 85)
        Me.lblProgName.TabIndex = 14
        Me.lblProgName.Text = "AMA Computer College Biñan Campus - Library Inventory System"
        Me.lblProgName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(5, 338)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 17)
        Me.lblName.TabIndex = 12
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(88, 83)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 13
        Me.LogoPictureBox.TabStop = False
        '
        'MainBorrower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(416, 362)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLO)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.lblUU)
        Me.Controls.Add(Me.btnMA)
        Me.Controls.Add(Me.lblUI)
        Me.Controls.Add(Me.btnSB)
        Me.Controls.Add(Me.lblProgName)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.lblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainBorrower"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AMA-CC Biñan Campus Library Inventory System"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLO As Button
    Friend WithEvents lblB As Label
    Friend WithEvents btnB As Button
    Friend WithEvents lblUU As Label
    Friend WithEvents btnMA As Button
    Friend WithEvents lblUI As Label
    Friend WithEvents btnSB As Button
    Friend WithEvents lblProgName As Label
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents lblName As Label
End Class
