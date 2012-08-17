<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.lvwSearch = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.UpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.EditToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.DeleteToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.SelectAllToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.UpToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.DownToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.ToolStrip2.SuspendLayout()
        CType(Me.lvwSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripButton})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 33)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.ToolStrip2.Size = New System.Drawing.Size(537, 33)
        Me.ToolStrip2.Stretch = True
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'SearchToolStripButton
        '
        Me.SearchToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SearchToolStripButton.Image = CType(resources.GetObject("SearchToolStripButton.Image"), System.Drawing.Image)
        Me.SearchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchToolStripButton.Name = "SearchToolStripButton"
        Me.SearchToolStripButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.SearchToolStripButton.Size = New System.Drawing.Size(65, 30)
        Me.SearchToolStripButton.Text = "&Search"
        '
        'lvwSearch
        '
        Me.lvwSearch.AllowUserToAddRows = False
        Me.lvwSearch.AllowUserToDeleteRows = False
        Me.lvwSearch.AllowUserToOrderColumns = True
        Me.lvwSearch.AllowUserToResizeRows = False
        Me.lvwSearch.BackgroundColor = System.Drawing.SystemColors.Window
        Me.lvwSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvwSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.lvwSearch.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.lvwSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.lvwSearch.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.lvwSearch.DefaultCellStyle = DataGridViewCellStyle2
        Me.lvwSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwSearch.GridColor = System.Drawing.SystemColors.ControlLight
        Me.lvwSearch.Location = New System.Drawing.Point(0, 66)
        Me.lvwSearch.Name = "lvwSearch"
        Me.lvwSearch.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.lvwSearch.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.lvwSearch.RowHeadersVisible = False
        Me.lvwSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.lvwSearch.RowTemplate.Height = 17
        Me.lvwSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.lvwSearch.Size = New System.Drawing.Size(537, 197)
        Me.lvwSearch.TabIndex = 3
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripMenuSeparator1, Me.PrintToolStripMenuItem, Me.ToolStripMenuSeparator2, Me.SelectAllToolStripMenuItem, Me.CopyToolStripMenuItem, Me.ToolStripMenuSeparator3, Me.UpToolStripMenuItem, Me.DownToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(129, 198)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = CType(resources.GetObject("EditToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = CType(resources.GetObject("DeleteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'ToolStripMenuSeparator1
        '
        Me.ToolStripMenuSeparator1.Name = "ToolStripMenuSeparator1"
        Me.ToolStripMenuSeparator1.Size = New System.Drawing.Size(125, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'ToolStripMenuSeparator2
        '
        Me.ToolStripMenuSeparator2.Name = "ToolStripMenuSeparator2"
        Me.ToolStripMenuSeparator2.Size = New System.Drawing.Size(125, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.SelectAllToolStripMenuItem.Text = "&Select All"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'ToolStripMenuSeparator3
        '
        Me.ToolStripMenuSeparator3.Name = "ToolStripMenuSeparator3"
        Me.ToolStripMenuSeparator3.Size = New System.Drawing.Size(125, 6)
        '
        'UpToolStripMenuItem
        '
        Me.UpToolStripMenuItem.Image = CType(resources.GetObject("UpToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UpToolStripMenuItem.Name = "UpToolStripMenuItem"
        Me.UpToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.UpToolStripMenuItem.Text = "&Up"
        '
        'DownToolStripMenuItem
        '
        Me.DownToolStripMenuItem.Image = CType(resources.GetObject("DownToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DownToolStripMenuItem.Name = "DownToolStripMenuItem"
        Me.DownToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.DownToolStripMenuItem.Text = "&Down"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.EditToolStripButton, Me.DeleteToolStripButton, Me.ToolStripSeparator1, Me.PrintToolStripButton, Me.ToolStripSeparator2, Me.SelectAllToolStripButton, Me.CopyToolStripButton, Me.ToolStripSeparator3, Me.UpToolStripButton, Me.DownToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(6, 0, 1, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(537, 33)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "0"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.NewToolStripButton.Size = New System.Drawing.Size(38, 30)
        Me.NewToolStripButton.Text = "&New"
        '
        'EditToolStripButton
        '
        Me.EditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditToolStripButton.Image = CType(resources.GetObject("EditToolStripButton.Image"), System.Drawing.Image)
        Me.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditToolStripButton.Name = "EditToolStripButton"
        Me.EditToolStripButton.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.EditToolStripButton.Size = New System.Drawing.Size(38, 30)
        Me.EditToolStripButton.Text = "&Edit"
        '
        'DeleteToolStripButton
        '
        Me.DeleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeleteToolStripButton.Image = CType(resources.GetObject("DeleteToolStripButton.Image"), System.Drawing.Image)
        Me.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteToolStripButton.Name = "DeleteToolStripButton"
        Me.DeleteToolStripButton.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.DeleteToolStripButton.Size = New System.Drawing.Size(38, 30)
        Me.DeleteToolStripButton.Text = "&Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.PrintToolStripButton.Size = New System.Drawing.Size(38, 30)
        Me.PrintToolStripButton.Text = "Print"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'SelectAllToolStripButton
        '
        Me.SelectAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SelectAllToolStripButton.Image = CType(resources.GetObject("SelectAllToolStripButton.Image"), System.Drawing.Image)
        Me.SelectAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SelectAllToolStripButton.Name = "SelectAllToolStripButton"
        Me.SelectAllToolStripButton.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.SelectAllToolStripButton.Size = New System.Drawing.Size(64, 30)
        Me.SelectAllToolStripButton.Text = "&Select All"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.CopyToolStripButton.Size = New System.Drawing.Size(38, 30)
        Me.CopyToolStripButton.Text = "&Copy"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 33)
        '
        'UpToolStripButton
        '
        Me.UpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UpToolStripButton.Image = CType(resources.GetObject("UpToolStripButton.Image"), System.Drawing.Image)
        Me.UpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UpToolStripButton.Name = "UpToolStripButton"
        Me.UpToolStripButton.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.UpToolStripButton.Size = New System.Drawing.Size(38, 30)
        Me.UpToolStripButton.Text = "&Up"
        '
        'DownToolStripButton
        '
        Me.DownToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DownToolStripButton.Image = CType(resources.GetObject("DownToolStripButton.Image"), System.Drawing.Image)
        Me.DownToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DownToolStripButton.Name = "DownToolStripButton"
        Me.DownToolStripButton.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.DownToolStripButton.Size = New System.Drawing.Size(38, 30)
        Me.DownToolStripButton.Text = "&Down"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BackColor = System.Drawing.SystemColors.Window
        Me.txtSearch.Location = New System.Drawing.Point(6, 39)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(456, 20)
        Me.txtSearch.TabIndex = 0
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(474, 8)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(51, 20)
        Me.txtTotal.TabIndex = 4
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SearchForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(537, 263)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lvwSearch)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(545, 0)
        Me.Name = "SearchForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SearchForm"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.lvwSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents SearchToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents lvwSearch As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents DeleteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents UpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DownToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
End Class
