<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookInv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookInv))
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.BookIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookAuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookGenreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublishedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibInvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AMAInvDBDataSet = New AMA_CC_Biñan_Campus_Library_Inventory_System.AMAInvDBDataSet()
        Me.LibInvTableAdapter = New AMA_CC_Biñan_Campus_Library_Inventory_System.AMAInvDBDataSetTableAdapters.LibInvTableAdapter()
        Me.txtQS = New System.Windows.Forms.TextBox()
        Me.lblQS = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.txtBID = New System.Windows.Forms.TextBox()
        Me.lblBID = New System.Windows.Forms.Label()
        Me.txtUID = New System.Windows.Forms.TextBox()
        Me.lblUID = New System.Windows.Forms.Label()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.lblPW = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblDTToday = New System.Windows.Forms.Label()
        Me.txtDTT = New System.Windows.Forms.Label()
        Me.lblDD = New System.Windows.Forms.Label()
        Me.txtDD = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblAddDays = New System.Windows.Forms.Label()
        Me.tmrDT = New System.Windows.Forms.Timer(Me.components)
        Me.txtADays = New System.Windows.Forms.NumericUpDown()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibInvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AMAInvDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtADays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBooks
        '
        Me.dgvBooks.AllowUserToAddRows = False
        Me.dgvBooks.AllowUserToDeleteRows = False
        Me.dgvBooks.AutoGenerateColumns = False
        Me.dgvBooks.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookIDDataGridViewTextBoxColumn, Me.BookNameDataGridViewTextBoxColumn, Me.BookAuthorDataGridViewTextBoxColumn, Me.BookGenreDataGridViewTextBoxColumn, Me.BookYearDataGridViewTextBoxColumn, Me.PublishedByDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn})
        Me.dgvBooks.DataSource = Me.LibInvBindingSource
        Me.dgvBooks.Location = New System.Drawing.Point(12, 39)
        Me.dgvBooks.MultiSelect = False
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.ReadOnly = True
        Me.dgvBooks.Size = New System.Drawing.Size(768, 424)
        Me.dgvBooks.TabIndex = 0
        '
        'BookIDDataGridViewTextBoxColumn
        '
        Me.BookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID"
        Me.BookIDDataGridViewTextBoxColumn.HeaderText = "Book ID"
        Me.BookIDDataGridViewTextBoxColumn.Name = "BookIDDataGridViewTextBoxColumn"
        Me.BookIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookNameDataGridViewTextBoxColumn
        '
        Me.BookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName"
        Me.BookNameDataGridViewTextBoxColumn.HeaderText = "Book Name"
        Me.BookNameDataGridViewTextBoxColumn.Name = "BookNameDataGridViewTextBoxColumn"
        Me.BookNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookAuthorDataGridViewTextBoxColumn
        '
        Me.BookAuthorDataGridViewTextBoxColumn.DataPropertyName = "BookAuthor"
        Me.BookAuthorDataGridViewTextBoxColumn.HeaderText = "Book Author"
        Me.BookAuthorDataGridViewTextBoxColumn.Name = "BookAuthorDataGridViewTextBoxColumn"
        Me.BookAuthorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookGenreDataGridViewTextBoxColumn
        '
        Me.BookGenreDataGridViewTextBoxColumn.DataPropertyName = "BookGenre"
        Me.BookGenreDataGridViewTextBoxColumn.HeaderText = "Book Genre"
        Me.BookGenreDataGridViewTextBoxColumn.Name = "BookGenreDataGridViewTextBoxColumn"
        Me.BookGenreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookYearDataGridViewTextBoxColumn
        '
        Me.BookYearDataGridViewTextBoxColumn.DataPropertyName = "BookYear"
        Me.BookYearDataGridViewTextBoxColumn.HeaderText = "Book Year"
        Me.BookYearDataGridViewTextBoxColumn.Name = "BookYearDataGridViewTextBoxColumn"
        Me.BookYearDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PublishedByDataGridViewTextBoxColumn
        '
        Me.PublishedByDataGridViewTextBoxColumn.DataPropertyName = "PublishedBy"
        Me.PublishedByDataGridViewTextBoxColumn.HeaderText = "Published By"
        Me.PublishedByDataGridViewTextBoxColumn.Name = "PublishedByDataGridViewTextBoxColumn"
        Me.PublishedByDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        Me.LocationDataGridViewTextBoxColumn.ReadOnly = True
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
        'txtQS
        '
        Me.txtQS.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQS.Location = New System.Drawing.Point(106, 7)
        Me.txtQS.Name = "txtQS"
        Me.txtQS.ShortcutsEnabled = False
        Me.txtQS.Size = New System.Drawing.Size(149, 26)
        Me.txtQS.TabIndex = 52
        '
        'lblQS
        '
        Me.lblQS.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQS.Location = New System.Drawing.Point(12, 9)
        Me.lblQS.Name = "lblQS"
        Me.lblQS.Size = New System.Drawing.Size(98, 20)
        Me.lblQS.TabIndex = 51
        Me.lblQS.Text = "Quick Search:"
        Me.lblQS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBack
        '
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBack.Font = New System.Drawing.Font("Perpetua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(705, 7)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 26)
        Me.btnBack.TabIndex = 53
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnB.Font = New System.Drawing.Font("Perpetua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnB.Location = New System.Drawing.Point(624, 7)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(75, 26)
        Me.btnB.TabIndex = 54
        Me.btnB.Text = "Borrow"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'txtBID
        '
        Me.txtBID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBID.Location = New System.Drawing.Point(132, 466)
        Me.txtBID.Name = "txtBID"
        Me.txtBID.Size = New System.Drawing.Size(149, 22)
        Me.txtBID.TabIndex = 56
        '
        'lblBID
        '
        Me.lblBID.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBID.Location = New System.Drawing.Point(15, 466)
        Me.lblBID.Name = "lblBID"
        Me.lblBID.Size = New System.Drawing.Size(98, 20)
        Me.lblBID.TabIndex = 55
        Me.lblBID.Text = "Book ID:*"
        Me.lblBID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUID
        '
        Me.txtUID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUID.Location = New System.Drawing.Point(132, 494)
        Me.txtUID.Name = "txtUID"
        Me.txtUID.Size = New System.Drawing.Size(149, 22)
        Me.txtUID.TabIndex = 58
        '
        'lblUID
        '
        Me.lblUID.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUID.Location = New System.Drawing.Point(15, 496)
        Me.lblUID.Name = "lblUID"
        Me.lblUID.Size = New System.Drawing.Size(98, 20)
        Me.lblUID.TabIndex = 57
        Me.lblUID.Text = "User ID:*"
        Me.lblUID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPW
        '
        Me.txtPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPW.Location = New System.Drawing.Point(132, 522)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Size = New System.Drawing.Size(149, 22)
        Me.txtPW.TabIndex = 60
        Me.txtPW.UseSystemPasswordChar = True
        '
        'lblPW
        '
        Me.lblPW.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPW.Location = New System.Drawing.Point(15, 524)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(98, 20)
        Me.lblPW.TabIndex = 59
        Me.lblPW.Text = "Password:*"
        Me.lblPW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnConfirm
        '
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnConfirm.Font = New System.Drawing.Font("Perpetua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(642, 496)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(116, 48)
        Me.btnConfirm.TabIndex = 65
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblDTToday
        '
        Me.lblDTToday.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDTToday.Location = New System.Drawing.Point(287, 466)
        Me.lblDTToday.Name = "lblDTToday"
        Me.lblDTToday.Size = New System.Drawing.Size(98, 20)
        Me.lblDTToday.TabIndex = 66
        Me.lblDTToday.Text = "Date and Time:"
        Me.lblDTToday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDTT
        '
        Me.txtDTT.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDTT.Location = New System.Drawing.Point(381, 466)
        Me.txtDTT.Name = "txtDTT"
        Me.txtDTT.Size = New System.Drawing.Size(186, 20)
        Me.txtDTT.TabIndex = 67
        Me.txtDTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDD
        '
        Me.lblDD.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDD.Location = New System.Drawing.Point(287, 524)
        Me.lblDD.Name = "lblDD"
        Me.lblDD.Size = New System.Drawing.Size(98, 20)
        Me.lblDD.TabIndex = 68
        Me.lblDD.Text = "Due Date:"
        Me.lblDD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDD
        '
        Me.txtDD.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDD.Location = New System.Drawing.Point(381, 524)
        Me.txtDD.Name = "txtDD"
        Me.txtDD.Size = New System.Drawing.Size(186, 20)
        Me.txtDD.TabIndex = 69
        Me.txtDD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDay
        '
        Me.lblDay.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(425, 494)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(39, 20)
        Me.lblDay.TabIndex = 72
        Me.lblDay.Text = "Days"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAddDays
        '
        Me.lblAddDays.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddDays.Location = New System.Drawing.Point(287, 494)
        Me.lblAddDays.Name = "lblAddDays"
        Me.lblAddDays.Size = New System.Drawing.Size(98, 20)
        Me.lblAddDays.TabIndex = 73
        Me.lblAddDays.Text = "Add days:"
        Me.lblAddDays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrDT
        '
        Me.tmrDT.Enabled = True
        '
        'txtADays
        '
        Me.txtADays.Location = New System.Drawing.Point(384, 495)
        Me.txtADays.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.txtADays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtADays.Name = "txtADays"
        Me.txtADays.Size = New System.Drawing.Size(35, 20)
        Me.txtADays.TabIndex = 74
        Me.txtADays.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'BookInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(792, 584)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtQS)
        Me.Controls.Add(Me.lblQS)
        Me.Controls.Add(Me.dgvBooks)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.lblPW)
        Me.Controls.Add(Me.txtUID)
        Me.Controls.Add(Me.lblUID)
        Me.Controls.Add(Me.txtBID)
        Me.Controls.Add(Me.lblBID)
        Me.Controls.Add(Me.lblAddDays)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.txtDD)
        Me.Controls.Add(Me.lblDD)
        Me.Controls.Add(Me.txtDTT)
        Me.Controls.Add(Me.lblDTToday)
        Me.Controls.Add(Me.txtADays)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "BookInv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AMA-CC Biñan Campus Library Inventory System - Search Books"
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibInvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AMAInvDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtADays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents AMAInvDBDataSet As AMAInvDBDataSet
    Friend WithEvents LibInvBindingSource As BindingSource
    Friend WithEvents LibInvTableAdapter As AMAInvDBDataSetTableAdapters.LibInvTableAdapter
    Friend WithEvents BookIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookAuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookGenreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PublishedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtQS As TextBox
    Friend WithEvents lblQS As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnB As Button
    Friend WithEvents txtBID As TextBox
    Friend WithEvents lblBID As Label
    Friend WithEvents txtUID As TextBox
    Friend WithEvents lblUID As Label
    Friend WithEvents txtPW As TextBox
    Friend WithEvents lblPW As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblDTToday As Label
    Friend WithEvents txtDTT As Label
    Friend WithEvents lblDD As Label
    Friend WithEvents txtDD As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents lblAddDays As Label
    Friend WithEvents tmrDT As Timer
    Friend WithEvents txtADays As NumericUpDown
End Class
