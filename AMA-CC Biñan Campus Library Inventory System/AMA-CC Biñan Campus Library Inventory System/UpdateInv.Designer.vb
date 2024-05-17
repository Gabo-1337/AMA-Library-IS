<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateInv
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateInv))
        Me.dgvLibInv = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibInvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AMAInvDBDataSet = New AMA_CC_Biñan_Campus_Library_Inventory_System.AMAInvDBDataSet()
        Me.lblBID = New System.Windows.Forms.Label()
        Me.lblBN = New System.Windows.Forms.Label()
        Me.txtBN = New System.Windows.Forms.TextBox()
        Me.lblBA = New System.Windows.Forms.Label()
        Me.txtBA = New System.Windows.Forms.TextBox()
        Me.lblBG = New System.Windows.Forms.Label()
        Me.txtBG = New System.Windows.Forms.TextBox()
        Me.lblBY = New System.Windows.Forms.Label()
        Me.txtBY = New System.Windows.Forms.TextBox()
        Me.lblPB = New System.Windows.Forms.Label()
        Me.txtPB = New System.Windows.Forms.TextBox()
        Me.lblS = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.lblBD = New System.Windows.Forms.Label()
        Me.txtBD = New System.Windows.Forms.TextBox()
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.lblN = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbDel = New System.Windows.Forms.RadioButton()
        Me.rbEd = New System.Windows.Forms.RadioButton()
        Me.rbAdd = New System.Windows.Forms.RadioButton()
        Me.btnApp = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtBID = New System.Windows.Forms.TextBox()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.lblLoc = New System.Windows.Forms.Label()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.LibInvTableAdapter = New AMA_CC_Biñan_Campus_Library_Inventory_System.AMAInvDBDataSetTableAdapters.LibInvTableAdapter()
        CType(Me.dgvLibInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibInvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AMAInvDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvLibInv
        '
        Me.dgvLibInv.AllowUserToAddRows = False
        Me.dgvLibInv.AllowUserToDeleteRows = False
        Me.dgvLibInv.AutoGenerateColumns = False
        Me.dgvLibInv.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLibInv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLibInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLibInv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.StatusDataGridViewTextBoxColumn, Me.BorrowedBy, Me.DataGridViewTextBoxColumn7, Me.Location, Me.NoteDataGridViewTextBoxColumn, Me.DueDate})
        Me.dgvLibInv.DataSource = Me.LibInvBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLibInv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLibInv.Location = New System.Drawing.Point(12, 12)
        Me.dgvLibInv.MultiSelect = False
        Me.dgvLibInv.Name = "dgvLibInv"
        Me.dgvLibInv.ReadOnly = True
        Me.dgvLibInv.Size = New System.Drawing.Size(755, 399)
        Me.dgvLibInv.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "BookID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Book ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "BookName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Book Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BookAuthor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Book Author"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "BookGenre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Book Genre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "BookYear"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Book Year"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PublishedBy"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Published By"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BorrowedBy
        '
        Me.BorrowedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.BorrowedBy.DataPropertyName = "BorrowedBy"
        Me.BorrowedBy.HeaderText = "BorrowedBy"
        Me.BorrowedBy.Name = "BorrowedBy"
        Me.BorrowedBy.ReadOnly = True
        Me.BorrowedBy.Width = 89
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "BookDamage"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Book Damage"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'Location
        '
        Me.Location.DataPropertyName = "Location"
        Me.Location.HeaderText = "Location"
        Me.Location.Name = "Location"
        Me.Location.ReadOnly = True
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
        'DueDate
        '
        Me.DueDate.DataPropertyName = "DueDate"
        Me.DueDate.HeaderText = "DueDate"
        Me.DueDate.Name = "DueDate"
        Me.DueDate.ReadOnly = True
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
        'lblBID
        '
        Me.lblBID.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBID.Location = New System.Drawing.Point(12, 417)
        Me.lblBID.Name = "lblBID"
        Me.lblBID.Size = New System.Drawing.Size(98, 20)
        Me.lblBID.TabIndex = 5
        Me.lblBID.Text = "Book ID:"
        Me.lblBID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBN
        '
        Me.lblBN.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBN.Location = New System.Drawing.Point(12, 443)
        Me.lblBN.Name = "lblBN"
        Me.lblBN.Size = New System.Drawing.Size(98, 20)
        Me.lblBN.TabIndex = 7
        Me.lblBN.Text = "Book Name:"
        Me.lblBN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBN
        '
        Me.txtBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBN.Location = New System.Drawing.Point(116, 443)
        Me.txtBN.Name = "txtBN"
        Me.txtBN.Size = New System.Drawing.Size(149, 22)
        Me.txtBN.TabIndex = 6
        '
        'lblBA
        '
        Me.lblBA.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBA.Location = New System.Drawing.Point(12, 469)
        Me.lblBA.Name = "lblBA"
        Me.lblBA.Size = New System.Drawing.Size(98, 20)
        Me.lblBA.TabIndex = 9
        Me.lblBA.Text = "Book Author:"
        Me.lblBA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBA
        '
        Me.txtBA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBA.Location = New System.Drawing.Point(116, 469)
        Me.txtBA.Name = "txtBA"
        Me.txtBA.Size = New System.Drawing.Size(149, 22)
        Me.txtBA.TabIndex = 8
        '
        'lblBG
        '
        Me.lblBG.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBG.Location = New System.Drawing.Point(12, 495)
        Me.lblBG.Name = "lblBG"
        Me.lblBG.Size = New System.Drawing.Size(98, 20)
        Me.lblBG.TabIndex = 11
        Me.lblBG.Text = "Book Genre:"
        Me.lblBG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBG
        '
        Me.txtBG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBG.Location = New System.Drawing.Point(116, 495)
        Me.txtBG.Name = "txtBG"
        Me.txtBG.Size = New System.Drawing.Size(149, 22)
        Me.txtBG.TabIndex = 10
        '
        'lblBY
        '
        Me.lblBY.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBY.Location = New System.Drawing.Point(12, 521)
        Me.lblBY.Name = "lblBY"
        Me.lblBY.Size = New System.Drawing.Size(98, 20)
        Me.lblBY.TabIndex = 13
        Me.lblBY.Text = "Book Year:"
        Me.lblBY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBY
        '
        Me.txtBY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBY.Location = New System.Drawing.Point(116, 521)
        Me.txtBY.Name = "txtBY"
        Me.txtBY.Size = New System.Drawing.Size(149, 22)
        Me.txtBY.TabIndex = 12
        '
        'lblPB
        '
        Me.lblPB.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPB.Location = New System.Drawing.Point(12, 547)
        Me.lblPB.Name = "lblPB"
        Me.lblPB.Size = New System.Drawing.Size(98, 20)
        Me.lblPB.TabIndex = 15
        Me.lblPB.Text = "Published By:"
        Me.lblPB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPB
        '
        Me.txtPB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPB.Location = New System.Drawing.Point(116, 547)
        Me.txtPB.Name = "txtPB"
        Me.txtPB.Size = New System.Drawing.Size(149, 22)
        Me.txtPB.TabIndex = 14
        '
        'lblS
        '
        Me.lblS.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS.Location = New System.Drawing.Point(271, 417)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(89, 20)
        Me.lblS.TabIndex = 17
        Me.lblS.Text = "Status:"
        Me.lblS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbStatus
        '
        Me.cbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatus.Items.AddRange(New Object() {"Available", "Damaged"})
        Me.cbStatus.Location = New System.Drawing.Point(366, 417)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbStatus.Size = New System.Drawing.Size(149, 24)
        Me.cbStatus.TabIndex = 18
        Me.cbStatus.Text = "Available"
        '
        'lblBD
        '
        Me.lblBD.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBD.Location = New System.Drawing.Point(271, 444)
        Me.lblBD.Name = "lblBD"
        Me.lblBD.Size = New System.Drawing.Size(100, 20)
        Me.lblBD.TabIndex = 19
        Me.lblBD.Text = "Book Damage:"
        Me.lblBD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBD
        '
        Me.txtBD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBD.Location = New System.Drawing.Point(366, 444)
        Me.txtBD.Name = "txtBD"
        Me.txtBD.Size = New System.Drawing.Size(149, 22)
        Me.txtBD.TabIndex = 20
        '
        'txtN
        '
        Me.txtN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtN.Location = New System.Drawing.Point(310, 495)
        Me.txtN.Multiline = True
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(205, 74)
        Me.txtN.TabIndex = 22
        '
        'lblN
        '
        Me.lblN.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblN.Location = New System.Drawing.Point(271, 495)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(40, 20)
        Me.lblN.TabIndex = 21
        Me.lblN.Text = "Note:"
        Me.lblN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.rbDel)
        Me.GroupBox1.Controls.Add(Me.rbEd)
        Me.GroupBox1.Controls.Add(Me.rbAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(558, 417)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 49)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Actions"
        '
        'rbDel
        '
        Me.rbDel.AutoSize = True
        Me.rbDel.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDel.Location = New System.Drawing.Point(115, 19)
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
        Me.rbEd.Location = New System.Drawing.Point(61, 19)
        Me.rbEd.Name = "rbEd"
        Me.rbEd.Size = New System.Drawing.Size(48, 21)
        Me.rbEd.TabIndex = 27
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
        Me.rbAdd.TabIndex = 26
        Me.rbAdd.TabStop = True
        Me.rbAdd.Text = "Add"
        Me.rbAdd.UseVisualStyleBackColor = True
        '
        'btnApp
        '
        Me.btnApp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnApp.Font = New System.Drawing.Font("Perpetua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApp.Location = New System.Drawing.Point(535, 525)
        Me.btnApp.Name = "btnApp"
        Me.btnApp.Size = New System.Drawing.Size(75, 39)
        Me.btnApp.TabIndex = 26
        Me.btnApp.Text = "Apply"
        Me.btnApp.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBack.Font = New System.Drawing.Font("Perpetua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(697, 525)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 39)
        Me.btnBack.TabIndex = 27
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtBID
        '
        Me.txtBID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBID.Location = New System.Drawing.Point(116, 417)
        Me.txtBID.Name = "txtBID"
        Me.txtBID.Size = New System.Drawing.Size(149, 22)
        Me.txtBID.TabIndex = 28
        '
        'txtLoc
        '
        Me.txtLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoc.Location = New System.Drawing.Point(366, 469)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(149, 22)
        Me.txtLoc.TabIndex = 30
        '
        'lblLoc
        '
        Me.lblLoc.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoc.Location = New System.Drawing.Point(271, 469)
        Me.lblLoc.Name = "lblLoc"
        Me.lblLoc.Size = New System.Drawing.Size(100, 20)
        Me.lblLoc.TabIndex = 29
        Me.lblLoc.Text = "Location:"
        Me.lblLoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnHistory
        '
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnHistory.Font = New System.Drawing.Font("Perpetua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.Location = New System.Drawing.Point(616, 525)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(75, 39)
        Me.btnHistory.TabIndex = 31
        Me.btnHistory.Text = "History"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'LibInvTableAdapter
        '
        Me.LibInvTableAdapter.ClearBeforeFill = True
        '
        'UpdateInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(784, 576)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.txtLoc)
        Me.Controls.Add(Me.lblLoc)
        Me.Controls.Add(Me.txtBID)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnApp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtN)
        Me.Controls.Add(Me.lblN)
        Me.Controls.Add(Me.txtBD)
        Me.Controls.Add(Me.lblBD)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.lblS)
        Me.Controls.Add(Me.lblPB)
        Me.Controls.Add(Me.txtPB)
        Me.Controls.Add(Me.lblBY)
        Me.Controls.Add(Me.txtBY)
        Me.Controls.Add(Me.lblBG)
        Me.Controls.Add(Me.txtBG)
        Me.Controls.Add(Me.lblBA)
        Me.Controls.Add(Me.txtBA)
        Me.Controls.Add(Me.lblBN)
        Me.Controls.Add(Me.txtBN)
        Me.Controls.Add(Me.lblBID)
        Me.Controls.Add(Me.dgvLibInv)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "UpdateInv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AMA-CC Biñan Campus Library Inventory System - Update Inventory"
        CType(Me.dgvLibInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibInvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AMAInvDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvLibInv As DataGridView
    Friend WithEvents AMAInvDBDataSet As AMAInvDBDataSet
    Friend WithEvents LibInvBindingSource As BindingSource
    Friend WithEvents LibInvTableAdapter As AMAInvDBDataSetTableAdapters.LibInvTableAdapter
    Friend WithEvents BookIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookAuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookGenreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PublishedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookDamageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblBID As Label
    Friend WithEvents lblBN As Label
    Friend WithEvents txtBN As TextBox
    Friend WithEvents lblBA As Label
    Friend WithEvents txtBA As TextBox
    Friend WithEvents lblBG As Label
    Friend WithEvents txtBG As TextBox
    Friend WithEvents lblBY As Label
    Friend WithEvents txtBY As TextBox
    Friend WithEvents lblPB As Label
    Friend WithEvents txtPB As TextBox
    Friend WithEvents lblS As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents lblBD As Label
    Friend WithEvents txtBD As TextBox
    Friend WithEvents txtN As TextBox
    Friend WithEvents lblN As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbDel As RadioButton
    Friend WithEvents rbEd As RadioButton
    Friend WithEvents rbAdd As RadioButton
    Friend WithEvents btnApp As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtBID As TextBox
    Friend WithEvents txtLoc As TextBox
    Friend WithEvents lblLoc As Label
    Friend WithEvents btnHistory As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrowedBy As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Location As DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DueDate As DataGridViewTextBoxColumn
End Class
