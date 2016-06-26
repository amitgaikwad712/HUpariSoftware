<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rate
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RateIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RatetableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SutMashineProductDataSet2 = New SutMashineProduct.SutMashineProductDataSet2()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Rate_tableTableAdapter = New SutMashineProduct.SutMashineProductDataSet2TableAdapters.rate_tableTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtrateId = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RatetableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SutMashineProductDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RateIdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RatetableBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Right
        Me.DataGridView1.Location = New System.Drawing.Point(503, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(336, 462)
        Me.DataGridView1.TabIndex = 0
        '
        'RateIdDataGridViewTextBoxColumn
        '
        Me.RateIdDataGridViewTextBoxColumn.DataPropertyName = "rateId"
        Me.RateIdDataGridViewTextBoxColumn.HeaderText = "rateId"
        Me.RateIdDataGridViewTextBoxColumn.Name = "RateIdDataGridViewTextBoxColumn"
        Me.RateIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RatetableBindingSource
        '
        Me.RatetableBindingSource.DataMember = "rate-table"
        Me.RatetableBindingSource.DataSource = Me.SutMashineProductDataSet2
        '
        'SutMashineProductDataSet2
        '
        Me.SutMashineProductDataSet2.DataSetName = "SutMashineProductDataSet2"
        Me.SutMashineProductDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtname
        '
        Me.txtname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RatetableBindingSource, "name", True))
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(189, 106)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(140, 26)
        Me.txtname.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RatetableBindingSource, "price", True))
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(189, 171)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(140, 26)
        Me.txtPrice.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 107)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 25)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "दराचे प्रकार :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(101, 172)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 25)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "दर :"
        '
        'Rate_tableTableAdapter
        '
        Me.Rate_tableTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(82, 259)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 35)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "बदल करा"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtrateId
        '
        Me.txtrateId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RatetableBindingSource, "rateId", True))
        Me.txtrateId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrateId.Location = New System.Drawing.Point(189, 48)
        Me.txtrateId.Name = "txtrateId"
        Me.txtrateId.Size = New System.Drawing.Size(140, 26)
        Me.txtrateId.TabIndex = 24
        '
        'Rate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 462)
        Me.Controls.Add(Me.txtrateId)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Rate"
        Me.Text = "Rate"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RatetableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SutMashineProductDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SutMashineProductDataSet2 As SutMashineProduct.SutMashineProductDataSet2
    Friend WithEvents RatetableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rate_tableTableAdapter As SutMashineProduct.SutMashineProductDataSet2TableAdapters.rate_tableTableAdapter
    Friend WithEvents RateIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtrateId As System.Windows.Forms.TextBox
End Class
