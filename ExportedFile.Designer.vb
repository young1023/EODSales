<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportedFile
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意:  以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExportedFile))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailySalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportedFileTrackingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.From = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Tran_Search_Text1 = New System.Windows.Forms.TextBox()
        Me.Search_Button1 = New System.Windows.Forms.Button()
        Me.Button_Next = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PageNo1 = New System.Windows.Forms.TextBox()
        Me.Button_Previous = New System.Windows.Forms.Button()
        Me.Rows_No = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Check_Missing_File = New System.Windows.Forms.CheckBox()
        Me.Button_First = New System.Windows.Forms.Button()
        Me.Initial_Value = New System.Windows.Forms.Label()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ReportToolStripMenuItem, Me.ExportedFileTrackingToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(989, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.FileToolStripMenuItem.Text = "Data Convertion"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionDetailToolStripMenuItem, Me.SalesToolStripMenuItem, Me.DailySalesToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'TransactionDetailToolStripMenuItem
        '
        Me.TransactionDetailToolStripMenuItem.Name = "TransactionDetailToolStripMenuItem"
        Me.TransactionDetailToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.TransactionDetailToolStripMenuItem.Text = "Transaction Detail"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'DailySalesToolStripMenuItem
        '
        Me.DailySalesToolStripMenuItem.Name = "DailySalesToolStripMenuItem"
        Me.DailySalesToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DailySalesToolStripMenuItem.Text = "Daily Sales"
        '
        'ExportedFileTrackingToolStripMenuItem
        '
        Me.ExportedFileTrackingToolStripMenuItem.Name = "ExportedFileTrackingToolStripMenuItem"
        Me.ExportedFileTrackingToolStripMenuItem.Size = New System.Drawing.Size(145, 20)
        Me.ExportedFileTrackingToolStripMenuItem.Text = "Exported File Tracking"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(877, 28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Padding = New System.Windows.Forms.Padding(12)
        Me.PictureBox1.Size = New System.Drawing.Size(100, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.DataGridView1.Location = New System.Drawing.Point(14, 128)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(837, 388)
        Me.DataGridView1.TabIndex = 9
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(76, 55)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker1.MaxDate = New Date(2031, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(140, 23)
        Me.DateTimePicker1.TabIndex = 10
        Me.DateTimePicker1.Value = New Date(2014, 1, 1, 0, 0, 0, 0)
        '
        'From
        '
        Me.From.AutoSize = True
        Me.From.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.From.Location = New System.Drawing.Point(14, 64)
        Me.From.Name = "From"
        Me.From.Size = New System.Drawing.Size(35, 15)
        Me.From.TabIndex = 11
        Me.From.Text = "From"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "To"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(295, 55)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker2.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker2.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(140, 23)
        Me.DateTimePicker2.TabIndex = 13
        Me.DateTimePicker2.Value = New Date(2014, 4, 2, 0, 0, 0, 0)
        '
        'Tran_Search_Text1
        '
        Me.Tran_Search_Text1.Location = New System.Drawing.Point(455, 52)
        Me.Tran_Search_Text1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Tran_Search_Text1.Name = "Tran_Search_Text1"
        Me.Tran_Search_Text1.Size = New System.Drawing.Size(282, 23)
        Me.Tran_Search_Text1.TabIndex = 14
        '
        'Search_Button1
        '
        Me.Search_Button1.Location = New System.Drawing.Point(758, 50)
        Me.Search_Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Search_Button1.Name = "Search_Button1"
        Me.Search_Button1.Size = New System.Drawing.Size(87, 29)
        Me.Search_Button1.TabIndex = 15
        Me.Search_Button1.Text = "Search"
        Me.Search_Button1.UseVisualStyleBackColor = True
        '
        'Button_Next
        '
        Me.Button_Next.Location = New System.Drawing.Point(533, 90)
        Me.Button_Next.Name = "Button_Next"
        Me.Button_Next.Size = New System.Drawing.Size(34, 23)
        Me.Button_Next.TabIndex = 17
        Me.Button_Next.Text = ">"
        Me.Button_Next.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Page"
        '
        'PageNo1
        '
        Me.PageNo1.Location = New System.Drawing.Point(76, 88)
        Me.PageNo1.Name = "PageNo1"
        Me.PageNo1.ReadOnly = True
        Me.PageNo1.Size = New System.Drawing.Size(39, 23)
        Me.PageNo1.TabIndex = 19
        Me.PageNo1.Text = "1"
        '
        'Button_Previous
        '
        Me.Button_Previous.Location = New System.Drawing.Point(494, 90)
        Me.Button_Previous.Name = "Button_Previous"
        Me.Button_Previous.Size = New System.Drawing.Size(33, 23)
        Me.Button_Previous.TabIndex = 20
        Me.Button_Previous.Text = "<"
        Me.Button_Previous.UseVisualStyleBackColor = True
        '
        'Rows_No
        '
        Me.Rows_No.FormattingEnabled = True
        Me.Rows_No.Items.AddRange(New Object() {"15", "20", "25", "30", "35"})
        Me.Rows_No.Location = New System.Drawing.Point(663, 89)
        Me.Rows_No.Name = "Rows_No"
        Me.Rows_No.Size = New System.Drawing.Size(74, 23)
        Me.Rows_No.TabIndex = 21
        Me.Rows_No.Text = "20"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(761, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Rows Per Page"
        '
        'Check_Missing_File
        '
        Me.Check_Missing_File.AutoSize = True
        Me.Check_Missing_File.Location = New System.Drawing.Point(251, 94)
        Me.Check_Missing_File.Name = "Check_Missing_File"
        Me.Check_Missing_File.Size = New System.Drawing.Size(129, 19)
        Me.Check_Missing_File.TabIndex = 25
        Me.Check_Missing_File.Text = "Check Missing Files"
        Me.Check_Missing_File.UseVisualStyleBackColor = True
        '
        'Button_First
        '
        Me.Button_First.Location = New System.Drawing.Point(455, 90)
        Me.Button_First.Name = "Button_First"
        Me.Button_First.Size = New System.Drawing.Size(33, 23)
        Me.Button_First.TabIndex = 26
        Me.Button_First.Text = "<<"
        Me.Button_First.UseVisualStyleBackColor = True
        '
        'Initial_Value
        '
        Me.Initial_Value.AutoSize = True
        Me.Initial_Value.Location = New System.Drawing.Point(17, 28)
        Me.Initial_Value.Name = "Initial_Value"
        Me.Initial_Value.Size = New System.Drawing.Size(13, 15)
        Me.Initial_Value.TabIndex = 27
        Me.Initial_Value.Text = "0"
        Me.Initial_Value.Visible = False
        '
        'Button_Delete
        '
        Me.Button_Delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Delete.Location = New System.Drawing.Point(897, 477)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(80, 39)
        Me.Button_Delete.TabIndex = 28
        Me.Button_Delete.Text = "Delete "
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'ExportedFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 530)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Initial_Value)
        Me.Controls.Add(Me.Button_First)
        Me.Controls.Add(Me.Check_Missing_File)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Rows_No)
        Me.Controls.Add(Me.Button_Previous)
        Me.Controls.Add(Me.PageNo1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_Next)
        Me.Controls.Add(Me.Search_Button1)
        Me.Controls.Add(Me.Tran_Search_Text1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.From)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ExportedFile"
        Me.Text = "Shell EOD Sales Data Convertion  - Exported File Tracking"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DailySalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents From As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tran_Search_Text1 As System.Windows.Forms.TextBox
    Friend WithEvents Search_Button1 As System.Windows.Forms.Button
    Friend WithEvents Button_Next As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PageNo1 As System.Windows.Forms.TextBox
    Friend WithEvents Button_Previous As System.Windows.Forms.Button
    Friend WithEvents Rows_No As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ExportedFileTrackingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Check_Missing_File As System.Windows.Forms.CheckBox
    Friend WithEvents Button_First As System.Windows.Forms.Button
    Friend WithEvents Initial_Value As System.Windows.Forms.Label
    Friend WithEvents Button_Delete As System.Windows.Forms.Button


End Class
