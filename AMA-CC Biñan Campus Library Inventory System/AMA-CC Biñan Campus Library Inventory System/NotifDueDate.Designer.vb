<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotifDueDate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotifDueDate))
        Me.dgvBDD = New System.Windows.Forms.DataGridView()
        Me.lblWait = New System.Windows.Forms.Label()
        Me.btnOPENVU = New System.Windows.Forms.Button()
        Me.btnCloseNotif = New System.Windows.Forms.Button()
        Me.BookIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookAuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookGenreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublishedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibInvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AMAInvDBDataSet = New AMA_CC_Biñan_Campus_Library_Inventory_System.AMAInvDBDataSet()
        Me.LibInvTableAdapter = New AMA_CC_Biñan_Campus_Library_Inventory_System.AMAInvDBDataSetTableAdapters.LibInvTableAdapter()
        CType(Me.dgvBDD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibInvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AMAInvDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBDD
        '
        Me.dgvBDD.AllowUserToAddRows = False
        Me.dgvBDD.AllowUserToDeleteRows = False
        Me.dgvBDD.AutoGenerateColumns = False
        Me.dgvBDD.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.dgvBDD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBDD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookIDDataGridViewTextBoxColumn, Me.BookNameDataGridViewTextBoxColumn, Me.BookAuthorDataGridViewTextBoxColumn, Me.BookGenreDataGridViewTextBoxColumn, Me.BookYearDataGridViewTextBoxColumn, Me.PublishedByDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.NoteDataGridViewTextBoxColumn, Me.BorrowedByDataGridViewTextBoxColumn, Me.DueDateDataGridViewTextBoxColumn})
        Me.dgvBDD.DataSource = Me.LibInvBindingSource
        Me.dgvBDD.Location = New System.Drawing.Point(12, 12)
        Me.dgvBDD.Name = "dgvBDD"
        Me.dgvBDD.ReadOnly = True
        Me.dgvBDD.Size = New System.Drawing.Size(346, 369)
        Me.dgvBDD.TabIndex = 0
        '
        'lblWait
        '
        Me.lblWait.Font = New System.Drawing.Font("Perpetua Titling MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWait.Location = New System.Drawing.Point(364, 9)
        Me.lblWait.Name = "lblWait"
        Me.lblWait.Size = New System.Drawing.Size(285, 116)
        Me.lblWait.TabIndex = 19
        Me.lblWait.Text = "THE FOLLOWING BOOKS THAT HAVE BEEN BORROWED IS OVERDUE"
        Me.lblWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOPENVU
        '
        Me.btnOPENVU.Font = New System.Drawing.Font("Perpetua", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOPENVU.Location = New System.Drawing.Point(395, 329)
        Me.btnOPENVU.Name = "btnOPENVU"
        Me.btnOPENVU.Size = New System.Drawing.Size(117, 58)
        Me.btnOPENVU.TabIndex = 20
        Me.btnOPENVU.Text = "View Users"
        Me.btnOPENVU.UseVisualStyleBackColor = True
        '
        'btnCloseNotif
        '
        Me.btnCloseNotif.BackColor = System.Drawing.Color.Red
        Me.btnCloseNotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseNotif.Font = New System.Drawing.Font("Perpetua", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseNotif.Location = New System.Drawing.Point(518, 332)
        Me.btnCloseNotif.Name = "btnCloseNotif"
        Me.btnCloseNotif.Size = New System.Drawing.Size(117, 53)
        Me.btnCloseNotif.TabIndex = 21
        Me.btnCloseNotif.Text = "Ignore"
        Me.btnCloseNotif.UseVisualStyleBackColor = False
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
        'NoteDataGridViewTextBoxColumn
        '
        Me.NoteDataGridViewTextBoxColumn.DataPropertyName = "Note"
        Me.NoteDataGridViewTextBoxColumn.HeaderText = "Note"
        Me.NoteDataGridViewTextBoxColumn.Name = "NoteDataGridViewTextBoxColumn"
        Me.NoteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BorrowedByDataGridViewTextBoxColumn
        '
        Me.BorrowedByDataGridViewTextBoxColumn.DataPropertyName = "BorrowedBy"
        Me.BorrowedByDataGridViewTextBoxColumn.HeaderText = "Borrowed By"
        Me.BorrowedByDataGridViewTextBoxColumn.Name = "BorrowedByDataGridViewTextBoxColumn"
        Me.BorrowedByDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DueDateDataGridViewTextBoxColumn
        '
        Me.DueDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate"
        Me.DueDateDataGridViewTextBoxColumn.HeaderText = "Due Date"
        Me.DueDateDataGridViewTextBoxColumn.Name = "DueDateDataGridViewTextBoxColumn"
        Me.DueDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.DueDateDataGridViewTextBoxColumn.Width = 78
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
        'NotifDueDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(660, 397)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCloseNotif)
        Me.Controls.Add(Me.btnOPENVU)
        Me.Controls.Add(Me.lblWait)
        Me.Controls.Add(Me.dgvBDD)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NotifDueDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AMA-CC Biñan Campus Library Inventory System"
        CType(Me.dgvBDD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibInvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AMAInvDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvBDD As DataGridView
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
    Friend WithEvents NoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrowedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DueDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblWait As Label
    Friend WithEvents btnOPENVU As Button
    Friend WithEvents btnCloseNotif As Button
End Class
