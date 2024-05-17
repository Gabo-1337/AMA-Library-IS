<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HistoryForm))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AMAInvDBDataSet = New AMA_CC_Biñan_Campus_Library_Inventory_System.AMAInvDBDataSet()
        Me.HistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HistoryTableAdapter = New AMA_CC_Biñan_Campus_Library_Inventory_System.AMAInvDBDataSetTableAdapters.HistoryTableAdapter()
        Me.BookIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookGenreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookAuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublishedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateReturnedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AMAInvDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBack.Font = New System.Drawing.Font("Perpetua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(701, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 27)
        Me.btnBack.TabIndex = 28
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookIDDataGridViewTextBoxColumn, Me.BookNameDataGridViewTextBoxColumn, Me.BookGenreDataGridViewTextBoxColumn, Me.BookAuthorDataGridViewTextBoxColumn, Me.BookYearDataGridViewTextBoxColumn, Me.PublishedByDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.DateDueDataGridViewTextBoxColumn, Me.BorrowedByDataGridViewTextBoxColumn, Me.DateReturnedDataGridViewTextBoxColumn, Me.TransactionIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HistoryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(764, 523)
        Me.DataGridView1.TabIndex = 29
        '
        'AMAInvDBDataSet
        '
        Me.AMAInvDBDataSet.DataSetName = "AMAInvDBDataSet"
        Me.AMAInvDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HistoryBindingSource
        '
        Me.HistoryBindingSource.DataMember = "History"
        Me.HistoryBindingSource.DataSource = Me.AMAInvDBDataSet
        '
        'HistoryTableAdapter
        '
        Me.HistoryTableAdapter.ClearBeforeFill = True
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
        'BookGenreDataGridViewTextBoxColumn
        '
        Me.BookGenreDataGridViewTextBoxColumn.DataPropertyName = "BookGenre"
        Me.BookGenreDataGridViewTextBoxColumn.HeaderText = "Book Genre"
        Me.BookGenreDataGridViewTextBoxColumn.Name = "BookGenreDataGridViewTextBoxColumn"
        Me.BookGenreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookAuthorDataGridViewTextBoxColumn
        '
        Me.BookAuthorDataGridViewTextBoxColumn.DataPropertyName = "BookAuthor"
        Me.BookAuthorDataGridViewTextBoxColumn.HeaderText = "Book Author"
        Me.BookAuthorDataGridViewTextBoxColumn.Name = "BookAuthorDataGridViewTextBoxColumn"
        Me.BookAuthorDataGridViewTextBoxColumn.ReadOnly = True
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
        'DateDueDataGridViewTextBoxColumn
        '
        Me.DateDueDataGridViewTextBoxColumn.DataPropertyName = "DateDue"
        Me.DateDueDataGridViewTextBoxColumn.HeaderText = "Date Due"
        Me.DateDueDataGridViewTextBoxColumn.Name = "DateDueDataGridViewTextBoxColumn"
        Me.DateDueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BorrowedByDataGridViewTextBoxColumn
        '
        Me.BorrowedByDataGridViewTextBoxColumn.DataPropertyName = "BorrowedBy"
        Me.BorrowedByDataGridViewTextBoxColumn.HeaderText = "Borrowed By"
        Me.BorrowedByDataGridViewTextBoxColumn.Name = "BorrowedByDataGridViewTextBoxColumn"
        Me.BorrowedByDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateReturnedDataGridViewTextBoxColumn
        '
        Me.DateReturnedDataGridViewTextBoxColumn.DataPropertyName = "DateReturned"
        Me.DateReturnedDataGridViewTextBoxColumn.HeaderText = "Date Returned"
        Me.DateReturnedDataGridViewTextBoxColumn.Name = "DateReturnedDataGridViewTextBoxColumn"
        Me.DateReturnedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransactionIDDataGridViewTextBoxColumn
        '
        Me.TransactionIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionID"
        Me.TransactionIDDataGridViewTextBoxColumn.HeaderText = "Transaction ID"
        Me.TransactionIDDataGridViewTextBoxColumn.Name = "TransactionIDDataGridViewTextBoxColumn"
        Me.TransactionIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(788, 580)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "HistoryForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "History Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AMAInvDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AMAInvDBDataSet As AMAInvDBDataSet
    Friend WithEvents HistoryBindingSource As BindingSource
    Friend WithEvents HistoryTableAdapter As AMAInvDBDataSetTableAdapters.HistoryTableAdapter
    Friend WithEvents BookIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookGenreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookAuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PublishedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrowedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateReturnedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransactionIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
