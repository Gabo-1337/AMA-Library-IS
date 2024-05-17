<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewUser))
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AMAInvDBDataSet = New AMA_CC_Biñan_Campus_Library_Inventory_System.AMAInvDBDataSet()
        Me.lblUID = New System.Windows.Forms.Label()
        Me.txtQS = New System.Windows.Forms.TextBox()
        Me.lblQS = New System.Windows.Forms.Label()
        Me.txtUID = New System.Windows.Forms.TextBox()
        Me.txtFN = New System.Windows.Forms.TextBox()
        Me.lblFN = New System.Windows.Forms.Label()
        Me.txtGY = New System.Windows.Forms.TextBox()
        Me.lblGY = New System.Windows.Forms.Label()
        Me.txtSC = New System.Windows.Forms.TextBox()
        Me.lblSC = New System.Windows.Forms.Label()
        Me.txtAD = New System.Windows.Forms.TextBox()
        Me.lblAD = New System.Windows.Forms.Label()
        Me.txtCN = New System.Windows.Forms.TextBox()
        Me.lblCN = New System.Windows.Forms.Label()
        Me.txtUT = New System.Windows.Forms.TextBox()
        Me.lblUT = New System.Windows.Forms.Label()
        Me.txtITB = New System.Windows.Forms.TextBox()
        Me.lblITB = New System.Windows.Forms.Label()
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.LibInvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibInvTableAdapter = New AMA_CC_Biñan_Campus_Library_Inventory_System.AMAInvDBDataSetTableAdapters.LibInvTableAdapter()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.L_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemsBorrowed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsersTableAdapter = New AMA_CC_Biñan_Campus_Library_Inventory_System.AMAInvDBDataSetTableAdapters.UsersTableAdapter()
        Me.BookIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateBorrowed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemsBorrowedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectionCourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AMAInvDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibInvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.AllowUserToDeleteRows = False
        Me.dgvUsers.AutoGenerateColumns = False
        Me.dgvUsers.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.FNameDataGridViewTextBoxColumn, Me.MNameDataGridViewTextBoxColumn, Me.LNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.UserTypeDataGridViewTextBoxColumn, Me.ItemsBorrowedDataGridViewTextBoxColumn, Me.GradeYearDataGridViewTextBoxColumn, Me.SectionCourseDataGridViewTextBoxColumn})
        Me.dgvUsers.DataSource = Me.UsersBindingSource
        Me.dgvUsers.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvUsers.Location = New System.Drawing.Point(322, 61)
        Me.dgvUsers.MultiSelect = False
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.ReadOnly = True
        Me.dgvUsers.Size = New System.Drawing.Size(223, 199)
        Me.dgvUsers.TabIndex = 0
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
        'lblUID
        '
        Me.lblUID.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUID.Location = New System.Drawing.Point(12, 5)
        Me.lblUID.Name = "lblUID"
        Me.lblUID.Size = New System.Drawing.Size(98, 20)
        Me.lblUID.TabIndex = 58
        Me.lblUID.Text = "User ID:"
        Me.lblUID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtQS
        '
        Me.txtQS.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQS.Location = New System.Drawing.Point(322, 30)
        Me.txtQS.Name = "txtQS"
        Me.txtQS.ShortcutsEnabled = False
        Me.txtQS.Size = New System.Drawing.Size(137, 26)
        Me.txtQS.TabIndex = 60
        '
        'lblQS
        '
        Me.lblQS.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQS.Location = New System.Drawing.Point(319, 5)
        Me.lblQS.Name = "lblQS"
        Me.lblQS.Size = New System.Drawing.Size(98, 20)
        Me.lblQS.TabIndex = 59
        Me.lblQS.Text = "Quick Search"
        Me.lblQS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUID
        '
        Me.txtUID.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUID.Location = New System.Drawing.Point(12, 30)
        Me.txtUID.Name = "txtUID"
        Me.txtUID.ReadOnly = True
        Me.txtUID.ShortcutsEnabled = False
        Me.txtUID.Size = New System.Drawing.Size(149, 26)
        Me.txtUID.TabIndex = 61
        '
        'txtFN
        '
        Me.txtFN.Font = New System.Drawing.Font("Perpetua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFN.Location = New System.Drawing.Point(12, 80)
        Me.txtFN.Name = "txtFN"
        Me.txtFN.ReadOnly = True
        Me.txtFN.ShortcutsEnabled = False
        Me.txtFN.Size = New System.Drawing.Size(149, 22)
        Me.txtFN.TabIndex = 63
        '
        'lblFN
        '
        Me.lblFN.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFN.Location = New System.Drawing.Point(12, 57)
        Me.lblFN.Name = "lblFN"
        Me.lblFN.Size = New System.Drawing.Size(98, 20)
        Me.lblFN.TabIndex = 62
        Me.lblFN.Text = "Full Name:"
        Me.lblFN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGY
        '
        Me.txtGY.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGY.Location = New System.Drawing.Point(167, 80)
        Me.txtGY.Name = "txtGY"
        Me.txtGY.ReadOnly = True
        Me.txtGY.ShortcutsEnabled = False
        Me.txtGY.Size = New System.Drawing.Size(149, 26)
        Me.txtGY.TabIndex = 65
        '
        'lblGY
        '
        Me.lblGY.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGY.Location = New System.Drawing.Point(167, 57)
        Me.lblGY.Name = "lblGY"
        Me.lblGY.Size = New System.Drawing.Size(98, 20)
        Me.lblGY.TabIndex = 64
        Me.lblGY.Text = "Grade/Year:"
        Me.lblGY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSC
        '
        Me.txtSC.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSC.Location = New System.Drawing.Point(167, 130)
        Me.txtSC.Name = "txtSC"
        Me.txtSC.ReadOnly = True
        Me.txtSC.ShortcutsEnabled = False
        Me.txtSC.Size = New System.Drawing.Size(149, 26)
        Me.txtSC.TabIndex = 67
        '
        'lblSC
        '
        Me.lblSC.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSC.Location = New System.Drawing.Point(167, 109)
        Me.lblSC.Name = "lblSC"
        Me.lblSC.Size = New System.Drawing.Size(98, 20)
        Me.lblSC.TabIndex = 66
        Me.lblSC.Text = "Section/Course:"
        Me.lblSC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAD
        '
        Me.txtAD.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAD.Location = New System.Drawing.Point(12, 195)
        Me.txtAD.Multiline = True
        Me.txtAD.Name = "txtAD"
        Me.txtAD.ReadOnly = True
        Me.txtAD.ShortcutsEnabled = False
        Me.txtAD.Size = New System.Drawing.Size(304, 65)
        Me.txtAD.TabIndex = 69
        '
        'lblAD
        '
        Me.lblAD.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAD.Location = New System.Drawing.Point(12, 167)
        Me.lblAD.Name = "lblAD"
        Me.lblAD.Size = New System.Drawing.Size(98, 20)
        Me.lblAD.TabIndex = 68
        Me.lblAD.Text = "Address:"
        Me.lblAD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCN
        '
        Me.txtCN.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCN.Location = New System.Drawing.Point(12, 130)
        Me.txtCN.Name = "txtCN"
        Me.txtCN.ReadOnly = True
        Me.txtCN.ShortcutsEnabled = False
        Me.txtCN.Size = New System.Drawing.Size(149, 26)
        Me.txtCN.TabIndex = 71
        '
        'lblCN
        '
        Me.lblCN.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCN.Location = New System.Drawing.Point(12, 109)
        Me.lblCN.Name = "lblCN"
        Me.lblCN.Size = New System.Drawing.Size(124, 20)
        Me.lblCN.TabIndex = 70
        Me.lblCN.Text = "Contact Number:"
        Me.lblCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUT
        '
        Me.txtUT.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUT.Location = New System.Drawing.Point(167, 30)
        Me.txtUT.Name = "txtUT"
        Me.txtUT.ReadOnly = True
        Me.txtUT.ShortcutsEnabled = False
        Me.txtUT.Size = New System.Drawing.Size(149, 26)
        Me.txtUT.TabIndex = 73
        '
        'lblUT
        '
        Me.lblUT.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUT.Location = New System.Drawing.Point(167, 5)
        Me.lblUT.Name = "lblUT"
        Me.lblUT.Size = New System.Drawing.Size(98, 20)
        Me.lblUT.TabIndex = 72
        Me.lblUT.Text = "User Type:"
        Me.lblUT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtITB
        '
        Me.txtITB.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtITB.Location = New System.Drawing.Point(279, 165)
        Me.txtITB.Name = "txtITB"
        Me.txtITB.ReadOnly = True
        Me.txtITB.ShortcutsEnabled = False
        Me.txtITB.Size = New System.Drawing.Size(37, 26)
        Me.txtITB.TabIndex = 77
        '
        'lblITB
        '
        Me.lblITB.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblITB.Location = New System.Drawing.Point(116, 167)
        Me.lblITB.Name = "lblITB"
        Me.lblITB.Size = New System.Drawing.Size(186, 20)
        Me.lblITB.TabIndex = 76
        Me.lblITB.Text = "Number of Items Borrowed:"
        Me.lblITB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvBooks
        '
        Me.dgvBooks.AllowUserToAddRows = False
        Me.dgvBooks.AllowUserToDeleteRows = False
        Me.dgvBooks.AutoGenerateColumns = False
        Me.dgvBooks.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookIDDataGridViewTextBoxColumn, Me.BorrowedBy, Me.BookNameDataGridViewTextBoxColumn, Me.DateBorrowed, Me.DueDate, Me.NoteDataGridViewTextBoxColumn})
        Me.dgvBooks.DataSource = Me.LibInvBindingSource
        Me.dgvBooks.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvBooks.Location = New System.Drawing.Point(12, 266)
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.ReadOnly = True
        Me.dgvBooks.Size = New System.Drawing.Size(533, 150)
        Me.dgvBooks.TabIndex = 78
        '
        'LibInvBindingSource
        '
        Me.LibInvBindingSource.DataMember = "LibInv"
        Me.LibInvBindingSource.DataSource = Me.AMAInvDBDataSet
        '
        'LibInvTableAdapter
        '
        Me.LibInvTableAdapter.ClearBeforeFill = True
        '
        'btnBack
        '
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBack.Font = New System.Drawing.Font("Perpetua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(470, 10)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 46)
        Me.btnBack.TabIndex = 79
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'F_Name
        '
        Me.F_Name.DataPropertyName = "F_Name"
        Me.F_Name.HeaderText = "F_Name"
        Me.F_Name.Name = "F_Name"
        Me.F_Name.Visible = False
        '
        'M_Name
        '
        Me.M_Name.DataPropertyName = "M_Name"
        Me.M_Name.HeaderText = "M_Name"
        Me.M_Name.Name = "M_Name"
        Me.M_Name.Visible = False
        '
        'L_Name
        '
        Me.L_Name.DataPropertyName = "L_Name"
        Me.L_Name.HeaderText = "Last Name"
        Me.L_Name.Name = "L_Name"
        '
        'Address
        '
        Me.Address.DataPropertyName = "Address"
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.Visible = False
        '
        'ContactNumber
        '
        Me.ContactNumber.DataPropertyName = "ContactNumber"
        Me.ContactNumber.HeaderText = "ContactNumber"
        Me.ContactNumber.Name = "ContactNumber"
        Me.ContactNumber.Visible = False
        '
        'UserType
        '
        Me.UserType.DataPropertyName = "UserType"
        Me.UserType.HeaderText = "UserType"
        Me.UserType.Name = "UserType"
        Me.UserType.Visible = False
        '
        'ItemsBorrowed
        '
        Me.ItemsBorrowed.DataPropertyName = "ItemsBorrowed"
        Me.ItemsBorrowed.HeaderText = "ItemsBorrowed"
        Me.ItemsBorrowed.Name = "ItemsBorrowed"
        Me.ItemsBorrowed.Visible = False
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'BookIDDataGridViewTextBoxColumn
        '
        Me.BookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID"
        Me.BookIDDataGridViewTextBoxColumn.HeaderText = "Book ID"
        Me.BookIDDataGridViewTextBoxColumn.Name = "BookIDDataGridViewTextBoxColumn"
        Me.BookIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BorrowedBy
        '
        Me.BorrowedBy.DataPropertyName = "BorrowedBy"
        Me.BorrowedBy.HeaderText = "Borrowed By"
        Me.BorrowedBy.Name = "BorrowedBy"
        Me.BorrowedBy.ReadOnly = True
        '
        'BookNameDataGridViewTextBoxColumn
        '
        Me.BookNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.BookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName"
        Me.BookNameDataGridViewTextBoxColumn.HeaderText = "Book Name"
        Me.BookNameDataGridViewTextBoxColumn.Name = "BookNameDataGridViewTextBoxColumn"
        Me.BookNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.BookNameDataGridViewTextBoxColumn.Width = 88
        '
        'DateBorrowed
        '
        Me.DateBorrowed.DataPropertyName = "DateBorrowed"
        Me.DateBorrowed.HeaderText = "Date Borrowed"
        Me.DateBorrowed.Name = "DateBorrowed"
        Me.DateBorrowed.ReadOnly = True
        '
        'DueDate
        '
        Me.DueDate.DataPropertyName = "DueDate"
        Me.DueDate.HeaderText = "Due Date"
        Me.DueDate.Name = "DueDate"
        Me.DueDate.ReadOnly = True
        '
        'NoteDataGridViewTextBoxColumn
        '
        Me.NoteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NoteDataGridViewTextBoxColumn.DataPropertyName = "Note"
        Me.NoteDataGridViewTextBoxColumn.HeaderText = "Note"
        Me.NoteDataGridViewTextBoxColumn.Name = "NoteDataGridViewTextBoxColumn"
        Me.NoteDataGridViewTextBoxColumn.ReadOnly = True
        Me.NoteDataGridViewTextBoxColumn.Width = 55
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FNameDataGridViewTextBoxColumn
        '
        Me.FNameDataGridViewTextBoxColumn.DataPropertyName = "F_Name"
        Me.FNameDataGridViewTextBoxColumn.HeaderText = "F_Name"
        Me.FNameDataGridViewTextBoxColumn.Name = "FNameDataGridViewTextBoxColumn"
        Me.FNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FNameDataGridViewTextBoxColumn.Visible = False
        '
        'MNameDataGridViewTextBoxColumn
        '
        Me.MNameDataGridViewTextBoxColumn.DataPropertyName = "M_Name"
        Me.MNameDataGridViewTextBoxColumn.HeaderText = "M_Name"
        Me.MNameDataGridViewTextBoxColumn.Name = "MNameDataGridViewTextBoxColumn"
        Me.MNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.MNameDataGridViewTextBoxColumn.Visible = False
        '
        'LNameDataGridViewTextBoxColumn
        '
        Me.LNameDataGridViewTextBoxColumn.DataPropertyName = "L_Name"
        Me.LNameDataGridViewTextBoxColumn.HeaderText = "L_Name"
        Me.LNameDataGridViewTextBoxColumn.Name = "LNameDataGridViewTextBoxColumn"
        Me.LNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LNameDataGridViewTextBoxColumn.Visible = False
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.AddressDataGridViewTextBoxColumn.Visible = False
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        Me.ContactNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.ContactNumberDataGridViewTextBoxColumn.Visible = False
        '
        'UserTypeDataGridViewTextBoxColumn
        '
        Me.UserTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType"
        Me.UserTypeDataGridViewTextBoxColumn.HeaderText = "UserType"
        Me.UserTypeDataGridViewTextBoxColumn.Name = "UserTypeDataGridViewTextBoxColumn"
        Me.UserTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserTypeDataGridViewTextBoxColumn.Visible = False
        '
        'ItemsBorrowedDataGridViewTextBoxColumn
        '
        Me.ItemsBorrowedDataGridViewTextBoxColumn.DataPropertyName = "ItemsBorrowed"
        Me.ItemsBorrowedDataGridViewTextBoxColumn.HeaderText = "ItemsBorrowed"
        Me.ItemsBorrowedDataGridViewTextBoxColumn.Name = "ItemsBorrowedDataGridViewTextBoxColumn"
        Me.ItemsBorrowedDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemsBorrowedDataGridViewTextBoxColumn.Visible = False
        '
        'GradeYearDataGridViewTextBoxColumn
        '
        Me.GradeYearDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GradeYearDataGridViewTextBoxColumn.DataPropertyName = "Grade/Year"
        Me.GradeYearDataGridViewTextBoxColumn.HeaderText = "Grade/Year"
        Me.GradeYearDataGridViewTextBoxColumn.Name = "GradeYearDataGridViewTextBoxColumn"
        Me.GradeYearDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SectionCourseDataGridViewTextBoxColumn
        '
        Me.SectionCourseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SectionCourseDataGridViewTextBoxColumn.DataPropertyName = "Section/Course"
        Me.SectionCourseDataGridViewTextBoxColumn.HeaderText = "Section/Course"
        Me.SectionCourseDataGridViewTextBoxColumn.Name = "SectionCourseDataGridViewTextBoxColumn"
        Me.SectionCourseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ViewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(557, 428)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvBooks)
        Me.Controls.Add(Me.txtITB)
        Me.Controls.Add(Me.lblITB)
        Me.Controls.Add(Me.txtUT)
        Me.Controls.Add(Me.lblUT)
        Me.Controls.Add(Me.txtCN)
        Me.Controls.Add(Me.lblCN)
        Me.Controls.Add(Me.txtAD)
        Me.Controls.Add(Me.lblAD)
        Me.Controls.Add(Me.txtSC)
        Me.Controls.Add(Me.lblSC)
        Me.Controls.Add(Me.txtGY)
        Me.Controls.Add(Me.lblGY)
        Me.Controls.Add(Me.txtFN)
        Me.Controls.Add(Me.lblFN)
        Me.Controls.Add(Me.txtUID)
        Me.Controls.Add(Me.txtQS)
        Me.Controls.Add(Me.lblQS)
        Me.Controls.Add(Me.lblUID)
        Me.Controls.Add(Me.dgvUsers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ViewUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AMA-CC Biñan Campus Library Inventory System - View Users"
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AMAInvDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibInvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents AMAInvDBDataSet As AMAInvDBDataSet
    Friend WithEvents lblUID As Label
    Friend WithEvents txtQS As TextBox
    Friend WithEvents lblQS As Label
    Friend WithEvents txtUID As TextBox
    Friend WithEvents txtFN As TextBox
    Friend WithEvents lblFN As Label
    Friend WithEvents txtGY As TextBox
    Friend WithEvents lblGY As Label
    Friend WithEvents txtSC As TextBox
    Friend WithEvents lblSC As Label
    Friend WithEvents txtAD As TextBox
    Friend WithEvents lblAD As Label
    Friend WithEvents txtCN As TextBox
    Friend WithEvents lblCN As Label
    Friend WithEvents txtUT As TextBox
    Friend WithEvents lblUT As Label
    Friend WithEvents txtITB As TextBox
    Friend WithEvents lblITB As Label
    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents LibInvBindingSource As BindingSource
    Friend WithEvents LibInvTableAdapter As AMAInvDBDataSetTableAdapters.LibInvTableAdapter
    Friend WithEvents btnBack As Button
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents F_Name As DataGridViewTextBoxColumn
    Friend WithEvents M_Name As DataGridViewTextBoxColumn
    Friend WithEvents L_Name As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumber As DataGridViewTextBoxColumn
    Friend WithEvents UserType As DataGridViewTextBoxColumn
    Friend WithEvents ItemsBorrowed As DataGridViewTextBoxColumn
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As AMAInvDBDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents BookIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrowedBy As DataGridViewTextBoxColumn
    Friend WithEvents BookNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateBorrowed As DataGridViewTextBoxColumn
    Friend WithEvents DueDate As DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemsBorrowedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GradeYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SectionCourseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
