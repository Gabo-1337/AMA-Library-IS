<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewOwnAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewOwnAccount))
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.BookIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibInvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AMAInvDBDataSet = New AMA_CC_Biñan_Campus_Library_Inventory_System.AMAInvDBDataSet()
        Me.LibInvTableAdapter = New AMA_CC_Biñan_Campus_Library_Inventory_System.AMAInvDBDataSetTableAdapters.LibInvTableAdapter()
        Me.txtITB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUT = New System.Windows.Forms.TextBox()
        Me.lblUT = New System.Windows.Forms.Label()
        Me.txtCN = New System.Windows.Forms.TextBox()
        Me.lblCN = New System.Windows.Forms.Label()
        Me.txtAD = New System.Windows.Forms.TextBox()
        Me.lblAD = New System.Windows.Forms.Label()
        Me.txtSC = New System.Windows.Forms.TextBox()
        Me.lblCS = New System.Windows.Forms.Label()
        Me.txtGY = New System.Windows.Forms.TextBox()
        Me.lblGY = New System.Windows.Forms.Label()
        Me.txtFN = New System.Windows.Forms.TextBox()
        Me.lblFN = New System.Windows.Forms.Label()
        Me.txtUID = New System.Windows.Forms.TextBox()
        Me.lblUID = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.lblPW = New System.Windows.Forms.Label()
        Me.cboxPW = New System.Windows.Forms.CheckBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibInvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AMAInvDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBooks
        '
        Me.dgvBooks.AllowUserToAddRows = False
        Me.dgvBooks.AllowUserToDeleteRows = False
        Me.dgvBooks.AutoGenerateColumns = False
        Me.dgvBooks.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookIDDataGridViewTextBoxColumn, Me.BookName, Me.Note})
        Me.dgvBooks.DataSource = Me.LibInvBindingSource
        Me.dgvBooks.Location = New System.Drawing.Point(12, 227)
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.ReadOnly = True
        Me.dgvBooks.Size = New System.Drawing.Size(533, 193)
        Me.dgvBooks.TabIndex = 79
        '
        'BookIDDataGridViewTextBoxColumn
        '
        Me.BookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID"
        Me.BookIDDataGridViewTextBoxColumn.HeaderText = "Book ID"
        Me.BookIDDataGridViewTextBoxColumn.Name = "BookIDDataGridViewTextBoxColumn"
        Me.BookIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookName
        '
        Me.BookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.BookName.DataPropertyName = "BookName"
        Me.BookName.HeaderText = "Book Name"
        Me.BookName.Name = "BookName"
        Me.BookName.ReadOnly = True
        Me.BookName.Width = 88
        '
        'Note
        '
        Me.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Note.DataPropertyName = "Note"
        Me.Note.HeaderText = "Note"
        Me.Note.Name = "Note"
        Me.Note.ReadOnly = True
        '
        'LibInvBindingSource
        '
        Me.LibInvBindingSource.DataMember = "LibInv"
        Me.LibInvBindingSource.DataSource = Me.AMAInvDBDataSet
        '
        'AMAInvDBDataSet
        '
        Me.AMAInvDBDataSet.DataSetName = "AMAInvDBDataSet"
        Me.AMAInvDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LibInvTableAdapter
        '
        Me.LibInvTableAdapter.ClearBeforeFill = True
        '
        'txtITB
        '
        Me.txtITB.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtITB.ForeColor = System.Drawing.Color.Black
        Me.txtITB.Location = New System.Drawing.Point(124, 195)
        Me.txtITB.Name = "txtITB"
        Me.txtITB.ReadOnly = True
        Me.txtITB.ShortcutsEnabled = False
        Me.txtITB.Size = New System.Drawing.Size(63, 26)
        Me.txtITB.TabIndex = 95
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 20)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Items Borrowed:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUT
        '
        Me.txtUT.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUT.Location = New System.Drawing.Point(12, 111)
        Me.txtUT.Name = "txtUT"
        Me.txtUT.ReadOnly = True
        Me.txtUT.ShortcutsEnabled = False
        Me.txtUT.Size = New System.Drawing.Size(175, 26)
        Me.txtUT.TabIndex = 93
        '
        'lblUT
        '
        Me.lblUT.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUT.Location = New System.Drawing.Point(12, 88)
        Me.lblUT.Name = "lblUT"
        Me.lblUT.Size = New System.Drawing.Size(98, 20)
        Me.lblUT.TabIndex = 92
        Me.lblUT.Text = "User Type:"
        Me.lblUT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCN
        '
        Me.txtCN.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCN.Location = New System.Drawing.Point(12, 163)
        Me.txtCN.Name = "txtCN"
        Me.txtCN.ReadOnly = True
        Me.txtCN.ShortcutsEnabled = False
        Me.txtCN.Size = New System.Drawing.Size(175, 26)
        Me.txtCN.TabIndex = 91
        '
        'lblCN
        '
        Me.lblCN.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCN.Location = New System.Drawing.Point(9, 140)
        Me.lblCN.Name = "lblCN"
        Me.lblCN.Size = New System.Drawing.Size(124, 20)
        Me.lblCN.TabIndex = 90
        Me.lblCN.Text = "Contact Number:"
        Me.lblCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAD
        '
        Me.txtAD.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAD.Location = New System.Drawing.Point(193, 111)
        Me.txtAD.Multiline = True
        Me.txtAD.Name = "txtAD"
        Me.txtAD.ReadOnly = True
        Me.txtAD.ShortcutsEnabled = False
        Me.txtAD.Size = New System.Drawing.Size(352, 110)
        Me.txtAD.TabIndex = 89
        '
        'lblAD
        '
        Me.lblAD.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAD.Location = New System.Drawing.Point(190, 88)
        Me.lblAD.Name = "lblAD"
        Me.lblAD.Size = New System.Drawing.Size(98, 20)
        Me.lblAD.TabIndex = 88
        Me.lblAD.Text = "Address:"
        Me.lblAD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSC
        '
        Me.txtSC.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSC.Location = New System.Drawing.Point(374, 59)
        Me.txtSC.Name = "txtSC"
        Me.txtSC.ReadOnly = True
        Me.txtSC.ShortcutsEnabled = False
        Me.txtSC.Size = New System.Drawing.Size(171, 26)
        Me.txtSC.TabIndex = 87
        '
        'lblCS
        '
        Me.lblCS.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCS.Location = New System.Drawing.Point(371, 36)
        Me.lblCS.Name = "lblCS"
        Me.lblCS.Size = New System.Drawing.Size(98, 20)
        Me.lblCS.TabIndex = 86
        Me.lblCS.Text = "Section/Course:"
        Me.lblCS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGY
        '
        Me.txtGY.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGY.Location = New System.Drawing.Point(193, 59)
        Me.txtGY.Name = "txtGY"
        Me.txtGY.ReadOnly = True
        Me.txtGY.ShortcutsEnabled = False
        Me.txtGY.Size = New System.Drawing.Size(175, 26)
        Me.txtGY.TabIndex = 85
        '
        'lblGY
        '
        Me.lblGY.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGY.Location = New System.Drawing.Point(190, 36)
        Me.lblGY.Name = "lblGY"
        Me.lblGY.Size = New System.Drawing.Size(98, 20)
        Me.lblGY.TabIndex = 84
        Me.lblGY.Text = "Grade/Year:"
        Me.lblGY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFN
        '
        Me.txtFN.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFN.Location = New System.Drawing.Point(12, 59)
        Me.txtFN.Name = "txtFN"
        Me.txtFN.ReadOnly = True
        Me.txtFN.ShortcutsEnabled = False
        Me.txtFN.Size = New System.Drawing.Size(175, 26)
        Me.txtFN.TabIndex = 83
        '
        'lblFN
        '
        Me.lblFN.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFN.Location = New System.Drawing.Point(12, 36)
        Me.lblFN.Name = "lblFN"
        Me.lblFN.Size = New System.Drawing.Size(98, 20)
        Me.lblFN.TabIndex = 82
        Me.lblFN.Text = "Full Name:"
        Me.lblFN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUID
        '
        Me.txtUID.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUID.Location = New System.Drawing.Point(75, 7)
        Me.txtUID.Name = "txtUID"
        Me.txtUID.ReadOnly = True
        Me.txtUID.ShortcutsEnabled = False
        Me.txtUID.Size = New System.Drawing.Size(112, 26)
        Me.txtUID.TabIndex = 81
        '
        'lblUID
        '
        Me.lblUID.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUID.Location = New System.Drawing.Point(12, 9)
        Me.lblUID.Name = "lblUID"
        Me.lblUID.Size = New System.Drawing.Size(98, 20)
        Me.lblUID.TabIndex = 80
        Me.lblUID.Text = "User ID:"
        Me.lblUID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBack
        '
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBack.Font = New System.Drawing.Font("Perpetua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(470, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 33)
        Me.btnBack.TabIndex = 96
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtPW
        '
        Me.txtPW.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPW.Location = New System.Drawing.Point(262, 8)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.ReadOnly = True
        Me.txtPW.ShortcutsEnabled = False
        Me.txtPW.Size = New System.Drawing.Size(106, 25)
        Me.txtPW.TabIndex = 98
        Me.txtPW.UseSystemPasswordChar = True
        '
        'lblPW
        '
        Me.lblPW.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPW.Location = New System.Drawing.Point(190, 9)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(98, 20)
        Me.lblPW.TabIndex = 97
        Me.lblPW.Text = "Password:"
        Me.lblPW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboxPW
        '
        Me.cboxPW.AutoSize = True
        Me.cboxPW.Location = New System.Drawing.Point(374, 11)
        Me.cboxPW.Name = "cboxPW"
        Me.cboxPW.Size = New System.Drawing.Size(53, 17)
        Me.cboxPW.TabIndex = 99
        Me.cboxPW.Text = "Show"
        Me.cboxPW.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.Font = New System.Drawing.Font("Perpetua", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(171, 281)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(228, 97)
        Me.lblMsg.TabIndex = 100
        Me.lblMsg.Text = "Nothing to see here!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can borrow up to 3 books maximum!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMsg.Visible = False
        '
        'ViewOwnAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(557, 428)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboxPW)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.lblPW)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtITB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtUT)
        Me.Controls.Add(Me.lblUT)
        Me.Controls.Add(Me.txtCN)
        Me.Controls.Add(Me.lblCN)
        Me.Controls.Add(Me.txtAD)
        Me.Controls.Add(Me.lblAD)
        Me.Controls.Add(Me.txtSC)
        Me.Controls.Add(Me.lblCS)
        Me.Controls.Add(Me.txtGY)
        Me.Controls.Add(Me.lblGY)
        Me.Controls.Add(Me.txtFN)
        Me.Controls.Add(Me.lblFN)
        Me.Controls.Add(Me.txtUID)
        Me.Controls.Add(Me.lblUID)
        Me.Controls.Add(Me.dgvBooks)
        Me.Controls.Add(Me.lblMsg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ViewOwnAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AMA-CC Biñan Campus Library Inventory System - My Account"
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibInvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AMAInvDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents AMAInvDBDataSet As AMAInvDBDataSet
    Friend WithEvents LibInvBindingSource As BindingSource
    Friend WithEvents LibInvTableAdapter As AMAInvDBDataSetTableAdapters.LibInvTableAdapter
    Friend WithEvents txtITB As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUT As TextBox
    Friend WithEvents lblUT As Label
    Friend WithEvents txtCN As TextBox
    Friend WithEvents lblCN As Label
    Friend WithEvents txtAD As TextBox
    Friend WithEvents lblAD As Label
    Friend WithEvents txtSC As TextBox
    Friend WithEvents lblCS As Label
    Friend WithEvents txtGY As TextBox
    Friend WithEvents lblGY As Label
    Friend WithEvents txtFN As TextBox
    Friend WithEvents lblFN As Label
    Friend WithEvents txtUID As TextBox
    Friend WithEvents lblUID As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents txtPW As TextBox
    Friend WithEvents lblPW As Label
    Friend WithEvents cboxPW As CheckBox
    Friend WithEvents lblMsg As Label
    Friend WithEvents BookIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookName As DataGridViewTextBoxColumn
    Friend WithEvents Note As DataGridViewTextBoxColumn
End Class
