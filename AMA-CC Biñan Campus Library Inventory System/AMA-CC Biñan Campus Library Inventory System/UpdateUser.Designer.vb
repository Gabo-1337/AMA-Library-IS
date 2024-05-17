<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateUser
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateUser))
        Me.txtUID = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnApp = New System.Windows.Forms.Button()
        Me.gboxActions = New System.Windows.Forms.GroupBox()
        Me.rbDel = New System.Windows.Forms.RadioButton()
        Me.rbEd = New System.Windows.Forms.RadioButton()
        Me.rbAdd = New System.Windows.Forms.RadioButton()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.lblA = New System.Windows.Forms.Label()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.lblPW = New System.Windows.Forms.Label()
        Me.cbUType = New System.Windows.Forms.ComboBox()
        Me.lblUT = New System.Windows.Forms.Label()
        Me.lblCN = New System.Windows.Forms.Label()
        Me.txtCN = New System.Windows.Forms.TextBox()
        Me.lblLN = New System.Windows.Forms.Label()
        Me.txtLN = New System.Windows.Forms.TextBox()
        Me.lblMN = New System.Windows.Forms.Label()
        Me.txtMN = New System.Windows.Forms.TextBox()
        Me.lblFN = New System.Windows.Forms.Label()
        Me.txtFN = New System.Windows.Forms.TextBox()
        Me.lblUID = New System.Windows.Forms.Label()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemsBorrowed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AMAInvDBDataSet = New AMA_CC_Biñan_Campus_Library_Inventory_System.AMAInvDBDataSet()
        Me.UsersTableAdapter = New AMA_CC_Biñan_Campus_Library_Inventory_System.AMAInvDBDataSetTableAdapters.UsersTableAdapter()
        Me.txtGY = New System.Windows.Forms.TextBox()
        Me.lblGY = New System.Windows.Forms.Label()
        Me.txtSC = New System.Windows.Forms.TextBox()
        Me.lblSC = New System.Windows.Forms.Label()
        Me.gboxActions.SuspendLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AMAInvDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUID
        '
        Me.txtUID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUID.Location = New System.Drawing.Point(120, 440)
        Me.txtUID.Name = "txtUID"
        Me.txtUID.Size = New System.Drawing.Size(149, 22)
        Me.txtUID.TabIndex = 1
        '
        'btnBack
        '
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBack.Font = New System.Drawing.Font("Perpetua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(701, 542)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 26)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnApp
        '
        Me.btnApp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnApp.Font = New System.Drawing.Font("Perpetua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApp.Location = New System.Drawing.Point(617, 542)
        Me.btnApp.Name = "btnApp"
        Me.btnApp.Size = New System.Drawing.Size(75, 26)
        Me.btnApp.TabIndex = 10
        Me.btnApp.Text = "Apply"
        Me.btnApp.UseVisualStyleBackColor = True
        '
        'gboxActions
        '
        Me.gboxActions.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gboxActions.Controls.Add(Me.rbDel)
        Me.gboxActions.Controls.Add(Me.rbEd)
        Me.gboxActions.Controls.Add(Me.rbAdd)
        Me.gboxActions.Location = New System.Drawing.Point(701, 442)
        Me.gboxActions.Name = "gboxActions"
        Me.gboxActions.Size = New System.Drawing.Size(75, 98)
        Me.gboxActions.TabIndex = 47
        Me.gboxActions.TabStop = False
        Me.gboxActions.Text = "Actions"
        '
        'rbDel
        '
        Me.rbDel.AutoSize = True
        Me.rbDel.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDel.Location = New System.Drawing.Point(6, 73)
        Me.rbDel.Name = "rbDel"
        Me.rbDel.Size = New System.Drawing.Size(62, 21)
        Me.rbDel.TabIndex = 28
        Me.rbDel.Text = "Delete"
        Me.rbDel.UseVisualStyleBackColor = True
        '
        'rbEd
        '
        Me.rbEd.AutoSize = True
        Me.rbEd.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEd.Location = New System.Drawing.Point(6, 46)
        Me.rbEd.Name = "rbEd"
        Me.rbEd.Size = New System.Drawing.Size(48, 21)
        Me.rbEd.TabIndex = 13
        Me.rbEd.Text = "Edit"
        Me.rbEd.UseVisualStyleBackColor = True
        '
        'rbAdd
        '
        Me.rbAdd.AutoSize = True
        Me.rbAdd.Checked = True
        Me.rbAdd.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAdd.Location = New System.Drawing.Point(6, 19)
        Me.rbAdd.Name = "rbAdd"
        Me.rbAdd.Size = New System.Drawing.Size(49, 21)
        Me.rbAdd.TabIndex = 12
        Me.rbAdd.TabStop = True
        Me.rbAdd.Text = "Add"
        Me.rbAdd.UseVisualStyleBackColor = True
        '
        'txtA
        '
        Me.txtA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.Location = New System.Drawing.Point(355, 496)
        Me.txtA.Multiline = True
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(258, 72)
        Me.txtA.TabIndex = 7
        '
        'lblA
        '
        Me.lblA.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.Location = New System.Drawing.Point(275, 494)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(89, 20)
        Me.lblA.TabIndex = 45
        Me.lblA.Text = "Address:*"
        Me.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPW
        '
        Me.txtPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPW.Location = New System.Drawing.Point(355, 469)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Size = New System.Drawing.Size(155, 22)
        Me.txtPW.TabIndex = 6
        Me.txtPW.UseSystemPasswordChar = True
        '
        'lblPW
        '
        Me.lblPW.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPW.Location = New System.Drawing.Point(275, 468)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(100, 20)
        Me.lblPW.TabIndex = 43
        Me.lblPW.Text = "Password:*"
        Me.lblPW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbUType
        '
        Me.cbUType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUType.Items.AddRange(New Object() {"Admin", "Borrower", "Faculty"})
        Me.cbUType.Location = New System.Drawing.Point(355, 440)
        Me.cbUType.Name = "cbUType"
        Me.cbUType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbUType.Size = New System.Drawing.Size(155, 24)
        Me.cbUType.TabIndex = 5
        Me.cbUType.Text = "Borrower"
        '
        'lblUT
        '
        Me.lblUT.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUT.Location = New System.Drawing.Point(275, 442)
        Me.lblUT.Name = "lblUT"
        Me.lblUT.Size = New System.Drawing.Size(89, 20)
        Me.lblUT.TabIndex = 41
        Me.lblUT.Text = "User Type:*"
        Me.lblUT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCN
        '
        Me.lblCN.BackColor = System.Drawing.Color.Transparent
        Me.lblCN.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCN.Location = New System.Drawing.Point(12, 548)
        Me.lblCN.Name = "lblCN"
        Me.lblCN.Size = New System.Drawing.Size(113, 20)
        Me.lblCN.TabIndex = 40
        Me.lblCN.Text = "Contact Number:*"
        Me.lblCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCN
        '
        Me.txtCN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCN.Location = New System.Drawing.Point(120, 546)
        Me.txtCN.Name = "txtCN"
        Me.txtCN.Size = New System.Drawing.Size(149, 22)
        Me.txtCN.TabIndex = 5
        '
        'lblLN
        '
        Me.lblLN.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLN.Location = New System.Drawing.Point(12, 520)
        Me.lblLN.Name = "lblLN"
        Me.lblLN.Size = New System.Drawing.Size(98, 20)
        Me.lblLN.TabIndex = 36
        Me.lblLN.Text = "Last Name:*"
        Me.lblLN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLN
        '
        Me.txtLN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLN.Location = New System.Drawing.Point(120, 518)
        Me.txtLN.Name = "txtLN"
        Me.txtLN.Size = New System.Drawing.Size(149, 22)
        Me.txtLN.TabIndex = 4
        '
        'lblMN
        '
        Me.lblMN.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMN.Location = New System.Drawing.Point(12, 494)
        Me.lblMN.Name = "lblMN"
        Me.lblMN.Size = New System.Drawing.Size(98, 20)
        Me.lblMN.TabIndex = 34
        Me.lblMN.Text = "Middle Name:"
        Me.lblMN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMN
        '
        Me.txtMN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMN.Location = New System.Drawing.Point(120, 492)
        Me.txtMN.Name = "txtMN"
        Me.txtMN.Size = New System.Drawing.Size(149, 22)
        Me.txtMN.TabIndex = 3
        '
        'lblFN
        '
        Me.lblFN.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFN.Location = New System.Drawing.Point(12, 468)
        Me.lblFN.Name = "lblFN"
        Me.lblFN.Size = New System.Drawing.Size(98, 20)
        Me.lblFN.TabIndex = 32
        Me.lblFN.Text = "First Name:*"
        Me.lblFN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFN
        '
        Me.txtFN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFN.Location = New System.Drawing.Point(120, 466)
        Me.txtFN.Name = "txtFN"
        Me.txtFN.Size = New System.Drawing.Size(149, 22)
        Me.txtFN.TabIndex = 2
        '
        'lblUID
        '
        Me.lblUID.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUID.Location = New System.Drawing.Point(12, 442)
        Me.lblUID.Name = "lblUID"
        Me.lblUID.Size = New System.Drawing.Size(98, 20)
        Me.lblUID.TabIndex = 30
        Me.lblUID.Text = "User ID:*"
        Me.lblUID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.AllowUserToDeleteRows = False
        Me.dgvUsers.AutoGenerateColumns = False
        Me.dgvUsers.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FNameDataGridViewTextBoxColumn, Me.MNameDataGridViewTextBoxColumn, Me.LNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.UserTypeDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.ItemsBorrowed})
        Me.dgvUsers.DataSource = Me.UsersBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUsers.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUsers.Location = New System.Drawing.Point(12, 12)
        Me.dgvUsers.MultiSelect = False
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.ReadOnly = True
        Me.dgvUsers.Size = New System.Drawing.Size(764, 422)
        Me.dgvUsers.TabIndex = 51
        Me.dgvUsers.TabStop = False
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "User ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FNameDataGridViewTextBoxColumn
        '
        Me.FNameDataGridViewTextBoxColumn.DataPropertyName = "F_Name"
        Me.FNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FNameDataGridViewTextBoxColumn.Name = "FNameDataGridViewTextBoxColumn"
        Me.FNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MNameDataGridViewTextBoxColumn
        '
        Me.MNameDataGridViewTextBoxColumn.DataPropertyName = "M_Name"
        Me.MNameDataGridViewTextBoxColumn.HeaderText = "Middle Name"
        Me.MNameDataGridViewTextBoxColumn.Name = "MNameDataGridViewTextBoxColumn"
        Me.MNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LNameDataGridViewTextBoxColumn
        '
        Me.LNameDataGridViewTextBoxColumn.DataPropertyName = "L_Name"
        Me.LNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LNameDataGridViewTextBoxColumn.Name = "LNameDataGridViewTextBoxColumn"
        Me.LNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "Contact Number"
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        Me.ContactNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserTypeDataGridViewTextBoxColumn
        '
        Me.UserTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType"
        Me.UserTypeDataGridViewTextBoxColumn.HeaderText = "User Type"
        Me.UserTypeDataGridViewTextBoxColumn.Name = "UserTypeDataGridViewTextBoxColumn"
        Me.UserTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemsBorrowed
        '
        Me.ItemsBorrowed.DataPropertyName = "ItemsBorrowed"
        Me.ItemsBorrowed.HeaderText = "Items Borrowed"
        Me.ItemsBorrowed.Name = "ItemsBorrowed"
        Me.ItemsBorrowed.ReadOnly = True
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.AMAInvDBDataSet
        '
        'AMAInvDBDataSet
        '
        Me.AMAInvDBDataSet.DataSetName = "AMAInvDBDataSet"
        Me.AMAInvDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'txtGY
        '
        Me.txtGY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGY.Location = New System.Drawing.Point(617, 442)
        Me.txtGY.Name = "txtGY"
        Me.txtGY.Size = New System.Drawing.Size(75, 22)
        Me.txtGY.TabIndex = 8
        '
        'lblGY
        '
        Me.lblGY.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGY.Location = New System.Drawing.Point(513, 442)
        Me.lblGY.Name = "lblGY"
        Me.lblGY.Size = New System.Drawing.Size(100, 20)
        Me.lblGY.TabIndex = 52
        Me.lblGY.Text = "Grade/Year:*"
        Me.lblGY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSC
        '
        Me.txtSC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSC.Location = New System.Drawing.Point(617, 471)
        Me.txtSC.Name = "txtSC"
        Me.txtSC.Size = New System.Drawing.Size(75, 22)
        Me.txtSC.TabIndex = 9
        '
        'lblSC
        '
        Me.lblSC.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSC.Location = New System.Drawing.Point(513, 471)
        Me.lblSC.Name = "lblSC"
        Me.lblSC.Size = New System.Drawing.Size(113, 20)
        Me.lblSC.TabIndex = 54
        Me.lblSC.Text = "Section/Course:*"
        Me.lblSC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UpdateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(788, 580)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtSC)
        Me.Controls.Add(Me.lblSC)
        Me.Controls.Add(Me.txtGY)
        Me.Controls.Add(Me.lblGY)
        Me.Controls.Add(Me.txtCN)
        Me.Controls.Add(Me.txtUID)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnApp)
        Me.Controls.Add(Me.gboxActions)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.lblPW)
        Me.Controls.Add(Me.cbUType)
        Me.Controls.Add(Me.lblUT)
        Me.Controls.Add(Me.lblCN)
        Me.Controls.Add(Me.lblLN)
        Me.Controls.Add(Me.txtLN)
        Me.Controls.Add(Me.lblMN)
        Me.Controls.Add(Me.txtMN)
        Me.Controls.Add(Me.lblFN)
        Me.Controls.Add(Me.txtFN)
        Me.Controls.Add(Me.lblUID)
        Me.Controls.Add(Me.dgvUsers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "UpdateUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AMA-CC Biñan Campus Library Inventory System - Update Users"
        Me.gboxActions.ResumeLayout(False)
        Me.gboxActions.PerformLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AMAInvDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUID As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnApp As Button
    Friend WithEvents gboxActions As GroupBox
    Friend WithEvents rbDel As RadioButton
    Friend WithEvents rbEd As RadioButton
    Friend WithEvents rbAdd As RadioButton
    Friend WithEvents txtA As TextBox
    Friend WithEvents lblA As Label
    Friend WithEvents txtPW As TextBox
    Friend WithEvents lblPW As Label
    Friend WithEvents cbUType As ComboBox
    Friend WithEvents lblUT As Label
    Friend WithEvents lblCN As Label
    Friend WithEvents txtCN As TextBox
    Friend WithEvents lblLN As Label
    Friend WithEvents txtLN As TextBox
    Friend WithEvents lblMN As Label
    Friend WithEvents txtMN As TextBox
    Friend WithEvents lblFN As Label
    Friend WithEvents txtFN As TextBox
    Friend WithEvents lblUID As Label
    Friend WithEvents AMAInvDBDataSet As AMAInvDBDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As AMAInvDBDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemsBorrowed As DataGridViewTextBoxColumn
    Friend WithEvents txtGY As TextBox
    Friend WithEvents lblGY As Label
    Friend WithEvents txtSC As TextBox
    Friend WithEvents lblSC As Label
End Class
