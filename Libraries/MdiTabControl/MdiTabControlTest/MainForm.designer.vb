<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim ToolStripProfessionalRenderer1 As System.Windows.Forms.ToolStripProfessionalRenderer = New System.Windows.Forms.ToolStripProfessionalRenderer
        Dim ToolStripProfessionalRenderer2 As System.Windows.Forms.ToolStripProfessionalRenderer = New System.Windows.Forms.ToolStripProfessionalRenderer
        Dim ToolStripProfessionalRenderer3 As System.Windows.Forms.ToolStripProfessionalRenderer = New System.Windows.Forms.ToolStripProfessionalRenderer
        Dim ToolStripProfessionalRenderer4 As System.Windows.Forms.ToolStripProfessionalRenderer = New System.Windows.Forms.ToolStripProfessionalRenderer
        Dim ToolStripSystemRenderer1 As System.Windows.Forms.ToolStripSystemRenderer = New System.Windows.Forms.ToolStripSystemRenderer
        Dim ToolStripProfessionalRenderer5 As System.Windows.Forms.ToolStripProfessionalRenderer = New System.Windows.Forms.ToolStripProfessionalRenderer
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangePropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AnimateIconToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Option1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl7 = New MdiTabControl.TabControl
        Me.TabControl6 = New MdiTabControl.TabControl
        Me.TabControl5 = New MdiTabControl.TabControl
        Me.TabControl4 = New MdiTabControl.TabControl
        Me.TabControl3 = New MdiTabControl.TabControl
        Me.TabControl2 = New MdiTabControl.TabControl
        Me.TabControl1 = New MdiTabControl.TabControl
        Me.UntabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.RemoveToolStripMenuItem, Me.ChangePropertiesToolStripMenuItem, Me.AnimateIconToolStripMenuItem, Me.UntabToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(592, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.RemoveToolStripMenuItem.Text = "Remove Selected"
        '
        'ChangePropertiesToolStripMenuItem
        '
        Me.ChangePropertiesToolStripMenuItem.Name = "ChangePropertiesToolStripMenuItem"
        Me.ChangePropertiesToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.ChangePropertiesToolStripMenuItem.Text = "Change Properties"
        '
        'AnimateIconToolStripMenuItem
        '
        Me.AnimateIconToolStripMenuItem.Name = "AnimateIconToolStripMenuItem"
        Me.AnimateIconToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.AnimateIconToolStripMenuItem.Text = "Animate Icon"
        '
        'Option1ToolStripMenuItem
        '
        Me.Option1ToolStripMenuItem.Name = "Option1ToolStripMenuItem"
        Me.Option1ToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.Option1ToolStripMenuItem.Text = "option 1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 438)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(592, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Timer1
        '
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "8.ico")
        Me.ImageList1.Images.SetKeyName(1, "1.ico")
        Me.ImageList1.Images.SetKeyName(2, "2.ico")
        Me.ImageList1.Images.SetKeyName(3, "3.ico")
        Me.ImageList1.Images.SetKeyName(4, "4.ico")
        Me.ImageList1.Images.SetKeyName(5, "5.ico")
        Me.ImageList1.Images.SetKeyName(6, "6.ico")
        Me.ImageList1.Images.SetKeyName(7, "7.ico")
        '
        'TabControl7
        '
        Me.TabControl7.Alignment = MdiTabControl.TabControl.TabAlignment.Top
        Me.TabControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl7.Location = New System.Drawing.Point(0, 387)
        Me.TabControl7.MenuRenderer = Nothing
        Me.TabControl7.Name = "TabControl7"
        Me.TabControl7.Size = New System.Drawing.Size(592, 51)
        Me.TabControl7.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        Me.TabControl7.TabBorderEnhanceWeight = MdiTabControl.TabControl.Weight.Soft
        Me.TabControl7.TabCloseButtonImage = Nothing
        Me.TabControl7.TabCloseButtonImageDisabled = Nothing
        Me.TabControl7.TabCloseButtonImageHot = Nothing
        Me.TabControl7.TabIndex = 10
        Me.TabControl7.TabsDirection = MdiTabControl.TabControl.FlowDirection.LeftToRight
        '
        'TabControl6
        '
        Me.TabControl6.Alignment = MdiTabControl.TabControl.TabAlignment.Top
        Me.TabControl6.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl6.Location = New System.Drawing.Point(0, 343)
        ToolStripProfessionalRenderer1.RoundedEdges = True
        Me.TabControl6.MenuRenderer = ToolStripProfessionalRenderer1
        Me.TabControl6.Name = "TabControl6"
        Me.TabControl6.Size = New System.Drawing.Size(592, 44)
        Me.TabControl6.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        Me.TabControl6.TabBorderEnhanced = True
        Me.TabControl6.TabBorderEnhanceWeight = MdiTabControl.TabControl.Weight.Soft
        Me.TabControl6.TabCloseButtonImage = Global.MdiTabControlTest.My.Resources.Resources.Close
        Me.TabControl6.TabCloseButtonImageDisabled = Global.MdiTabControlTest.My.Resources.Resources.CloseDisabled
        Me.TabControl6.TabCloseButtonImageHot = Global.MdiTabControlTest.My.Resources.Resources.CloseHot
        Me.TabControl6.TabCloseButtonSize = New System.Drawing.Size(14, 14)
        Me.TabControl6.TabIndex = 9
        Me.TabControl6.TabsDirection = MdiTabControl.TabControl.FlowDirection.LeftToRight
        '
        'TabControl5
        '
        Me.TabControl5.Alignment = MdiTabControl.TabControl.TabAlignment.Top
        Me.TabControl5.BackHighColor = System.Drawing.Color.PaleGoldenrod
        Me.TabControl5.BackLowColor = System.Drawing.Color.PaleGoldenrod
        Me.TabControl5.CloseButtonVisible = True
        Me.TabControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl5.DropButtonVisible = False
        Me.TabControl5.Location = New System.Drawing.Point(0, 280)
        ToolStripProfessionalRenderer2.RoundedEdges = True
        Me.TabControl5.MenuRenderer = ToolStripProfessionalRenderer2
        Me.TabControl5.Name = "TabControl5"
        Me.TabControl5.Size = New System.Drawing.Size(592, 63)
        Me.TabControl5.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.TabControl5.TabBorderEnhanced = True
        Me.TabControl5.TabBorderEnhanceWeight = MdiTabControl.TabControl.Weight.Soft
        Me.TabControl5.TabCloseButtonImage = Nothing
        Me.TabControl5.TabCloseButtonImageDisabled = Nothing
        Me.TabControl5.TabCloseButtonImageHot = Nothing
        Me.TabControl5.TabCloseButtonVisible = False
        Me.TabControl5.TabHeight = 16
        Me.TabControl5.TabIconSize = New System.Drawing.Size(14, 14)
        Me.TabControl5.TabIndex = 7
        Me.TabControl5.TabMaximumWidth = 80
        Me.TabControl5.TabMinimumWidth = 80
        Me.TabControl5.TabOffset = -2
        Me.TabControl5.TabPadLeft = 15
        Me.TabControl5.TabsDirection = MdiTabControl.TabControl.FlowDirection.LeftToRight
        Me.TabControl5.TabTop = 1
        '
        'TabControl4
        '
        Me.TabControl4.Alignment = MdiTabControl.TabControl.TabAlignment.Top
        Me.TabControl4.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.TabControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl4.Location = New System.Drawing.Point(0, 168)
        ToolStripProfessionalRenderer3.RoundedEdges = True
        Me.TabControl4.MenuRenderer = ToolStripProfessionalRenderer3
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.TabControl4.Size = New System.Drawing.Size(592, 112)
        Me.TabControl4.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.TabControl4.TabBorderEnhanced = True
        Me.TabControl4.TabBorderEnhanceWeight = MdiTabControl.TabControl.Weight.Medium
        Me.TabControl4.TabCloseButtonImage = Nothing
        Me.TabControl4.TabCloseButtonImageDisabled = Nothing
        Me.TabControl4.TabCloseButtonImageHot = Nothing
        Me.TabControl4.TabGlassGradient = True
        Me.TabControl4.TabIndex = 8
        Me.TabControl4.TabOffset = 1
        Me.TabControl4.TabsDirection = MdiTabControl.TabControl.FlowDirection.LeftToRight
        '
        'TabControl3
        '
        Me.TabControl3.Alignment = MdiTabControl.TabControl.TabAlignment.Bottom
        Me.TabControl3.AllowTabReorder = False
        Me.TabControl3.BackHighColor = System.Drawing.SystemColors.ControlDark
        Me.TabControl3.BackLowColor = System.Drawing.SystemColors.ControlDark
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl3.DropButtonVisible = False
        Me.TabControl3.FontBoldOnSelect = False
        Me.TabControl3.ForeColorDisabled = System.Drawing.SystemColors.ControlDarkDark
        Me.TabControl3.HotTrack = False
        Me.TabControl3.Location = New System.Drawing.Point(0, 126)
        ToolStripProfessionalRenderer4.RoundedEdges = True
        Me.TabControl3.MenuRenderer = ToolStripProfessionalRenderer4
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.Size = New System.Drawing.Size(592, 42)
        Me.TabControl3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        Me.TabControl3.TabBackHighColorDisabled = System.Drawing.Color.Transparent
        Me.TabControl3.TabBackLowColor = System.Drawing.SystemColors.Window
        Me.TabControl3.TabBackLowColorDisabled = System.Drawing.Color.Transparent
        Me.TabControl3.TabBorderEnhanceWeight = MdiTabControl.TabControl.Weight.Soft
        Me.TabControl3.TabCloseButtonImage = Nothing
        Me.TabControl3.TabCloseButtonImageDisabled = Nothing
        Me.TabControl3.TabCloseButtonImageHot = Nothing
        Me.TabControl3.TabCloseButtonVisible = False
        Me.TabControl3.TabHeight = 18
        Me.TabControl3.TabIconSize = New System.Drawing.Size(12, 12)
        Me.TabControl3.TabIndex = 6
        Me.TabControl3.TabOffset = -1
        Me.TabControl3.TabsDirection = MdiTabControl.TabControl.FlowDirection.LeftToRight
        '
        'TabControl2
        '
        Me.TabControl2.Alignment = MdiTabControl.TabControl.TabAlignment.Top
        Me.TabControl2.BackHighColor = System.Drawing.Color.Transparent
        Me.TabControl2.BackLowColor = System.Drawing.Color.Transparent
        Me.TabControl2.CloseButtonVisible = True
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl2.Location = New System.Drawing.Point(0, 70)
        Me.TabControl2.MenuRenderer = ToolStripSystemRenderer1
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.Size = New System.Drawing.Size(592, 56)
        Me.TabControl2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        Me.TabControl2.TabBorderEnhanced = True
        Me.TabControl2.TabBorderEnhanceWeight = MdiTabControl.TabControl.Weight.Soft
        Me.TabControl2.TabCloseButtonImage = Nothing
        Me.TabControl2.TabCloseButtonImageDisabled = Nothing
        Me.TabControl2.TabCloseButtonImageHot = Nothing
        Me.TabControl2.TabCloseButtonSize = New System.Drawing.Size(14, 14)
        Me.TabControl2.TabCloseButtonVisible = False
        Me.TabControl2.TabHeight = 18
        Me.TabControl2.TabIndex = 5
        Me.TabControl2.TabOffset = -8
        Me.TabControl2.TabPadLeft = 20
        Me.TabControl2.TabsDirection = MdiTabControl.TabControl.FlowDirection.LeftToRight
        Me.TabControl2.TabTop = 1
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = MdiTabControl.TabControl.TabAlignment.Top
        Me.TabControl1.BackHighColor = System.Drawing.Color.Transparent
        Me.TabControl1.BackLowColor = System.Drawing.Color.Transparent
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.ForeColor = System.Drawing.Color.Maroon
        Me.TabControl1.ForeColorDisabled = System.Drawing.Color.IndianRed
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        ToolStripProfessionalRenderer5.RoundedEdges = True
        Me.TabControl1.MenuRenderer = ToolStripProfessionalRenderer5
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = New System.Drawing.Size(592, 46)
        Me.TabControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        Me.TabControl1.TabBackHighColor = System.Drawing.SystemColors.Control
        Me.TabControl1.TabBackLowColorDisabled = System.Drawing.SystemColors.Control
        Me.TabControl1.TabBorderEnhanceWeight = MdiTabControl.TabControl.Weight.Soft
        Me.TabControl1.TabCloseButtonBackHighColor = System.Drawing.Color.Transparent
        Me.TabControl1.TabCloseButtonBackHighColorDisabled = System.Drawing.Color.Transparent
        Me.TabControl1.TabCloseButtonBackHighColorHot = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabControl1.TabCloseButtonBackLowColor = System.Drawing.Color.Transparent
        Me.TabControl1.TabCloseButtonBackLowColorDisabled = System.Drawing.Color.Transparent
        Me.TabControl1.TabCloseButtonBackLowColorHot = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabControl1.TabCloseButtonBorderColor = System.Drawing.SystemColors.ControlDark
        Me.TabControl1.TabCloseButtonBorderColorDisabled = System.Drawing.SystemColors.GrayText
        Me.TabControl1.TabCloseButtonBorderColorHot = System.Drawing.SystemColors.HotTrack
        Me.TabControl1.TabCloseButtonForeColor = System.Drawing.SystemColors.ControlText
        Me.TabControl1.TabCloseButtonForeColorDisabled = System.Drawing.SystemColors.GrayText
        Me.TabControl1.TabCloseButtonForeColorHot = System.Drawing.SystemColors.ControlText
        Me.TabControl1.TabCloseButtonImage = Nothing
        Me.TabControl1.TabCloseButtonImageDisabled = Nothing
        Me.TabControl1.TabCloseButtonImageHot = Nothing
        Me.TabControl1.TabIconSize = New System.Drawing.Size(24, 24)
        Me.TabControl1.TabIndex = 4
        Me.TabControl1.TabOffset = 0
        Me.TabControl1.TabsDirection = MdiTabControl.TabControl.FlowDirection.LeftToRight
        '
        'UntabToolStripMenuItem
        '
        Me.UntabToolStripMenuItem.Name = "UntabToolStripMenuItem"
        Me.UntabToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.UntabToolStripMenuItem.Text = "untab"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 460)
        Me.Controls.Add(Me.TabControl7)
        Me.Controls.Add(Me.TabControl6)
        Me.Controls.Add(Me.TabControl5)
        Me.Controls.Add(Me.TabControl4)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDI Tab Control Test"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Option1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TabControl1 As MdiTabControl.TabControl
    Friend WithEvents TabControl2 As MdiTabControl.TabControl
    Friend WithEvents TabControl3 As MdiTabControl.TabControl
    Friend WithEvents TabControl5 As MdiTabControl.TabControl
    Friend WithEvents TabControl4 As MdiTabControl.TabControl
    Friend WithEvents ChangePropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl6 As MdiTabControl.TabControl
    Friend WithEvents AnimateIconToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TabControl7 As MdiTabControl.TabControl
    Friend WithEvents UntabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
