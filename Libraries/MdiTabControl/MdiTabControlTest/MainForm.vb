Public Class MainForm

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        Static i As Integer = 0
        Static count As Integer = 0
        Dim f As Form
        f = New Form
        f.Text = "Tab " & i
        TabControl5.TabPages.Add(f)
        f = New SearchForm
        i += 1
        f.Text = "My MDI Form #" & i
        If i = 2 Then f.Text += f.Text
        TabControl4.TabPages.Add(f)
        f = New Form
        f.Text = "Tab " & i
        TabControl3.TabPages.Add(f)
        f = New Form
        f.Text = "Tab " & i
        Dim x As MdiTabControl.TabPage = TabControl2.TabPages.Add(f)
        AddHandler x.MouseClick, AddressOf TabMouseClick
        count += 1
        If count = 5 Then count = 1
        If count = 1 Then
            x.BackLowColorDisabled = Color.Red
            x.BackLowColor = Color.Red
        ElseIf count = 2 Then
            x.BackLowColorDisabled = Color.Yellow
            x.BackLowColor = Color.Yellow
        ElseIf count = 3 Then
            x.BackLowColorDisabled = Color.Green
            x.BackLowColor = Color.Green
        Else
            x.BackLowColorDisabled = Color.Blue
            x.BackLowColor = Color.Blue
        End If
        f.BackColor = x.BackLowColor
        f = New Form
        f.Text = "Tab " & i & " has a long text and uses elipses"
        TabControl1.TabPages.Add(f)
        f = New Form
        f.Text = "Tab " & i
        TabControl6.TabPages.Add(f)
        f = New Form
        f.Text = "Tab " & i
        TabControl7.TabPages.Add(f)
    End Sub

    Sub TabMouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim x As New ContextMenuStrip
            Dim t As ToolStripItem = x.Items.Add("Close it", Nothing, AddressOf Closeit)
            t.Tag = sender
            x.Show(sender, e.Location)
        End If
    End Sub

    Sub Closeit(ByVal sender As Object, ByVal e As EventArgs)
        sender.tag.Form.close()
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click
        If TabControl7.TabPages.Count > 0 Then TabControl7.TabPages.Remove(TabControl7.TabPages.SelectedTab)
        If TabControl6.TabPages.Count > 0 Then TabControl6.TabPages.Remove(TabControl6.TabPages.SelectedTab)
        If TabControl5.TabPages.Count > 0 Then TabControl5.TabPages.Remove(TabControl5.TabPages.SelectedTab)
        If TabControl4.TabPages.Count > 0 Then TabControl4.TabPages.Remove(TabControl4.TabPages.SelectedTab)
        If TabControl3.TabPages.Count > 0 Then TabControl3.TabPages.Remove(TabControl3.TabPages.SelectedTab)
        If TabControl2.TabPages.Count > 0 Then TabControl2.TabPages.Remove(TabControl2.TabPages.SelectedTab)
        If TabControl1.TabPages.Count > 0 Then TabControl1.TabPages.Remove(TabControl1.TabPages.SelectedTab)
    End Sub

    Private Sub TabControl1_GetTabRegion(ByVal sender As Object, ByVal e As MdiTabControl.TabControl.GetTabRegionEventArgs) Handles TabControl1.GetTabRegion
        Array.Resize(e.Points, 4)
        If e.Selected Then
            e.Points(0) = New Point(0, e.TabHeight)
            e.Points(1) = New Point(0, 0)
            e.Points(2) = New Point(e.TabWidth, 0)
            e.Points(3) = New Point(e.TabWidth, e.TabHeight)
        Else
            e.Points(0) = New Point(0, e.TabHeight - 2)
            e.Points(1) = New Point(0, -1)
            e.Points(2) = New Point(e.TabWidth, -1)
            e.Points(3) = New Point(e.TabWidth, e.TabHeight - 2)
        End If
    End Sub

    Private Sub TabControl2_GetTabRegion(ByVal sender As Object, ByVal e As MdiTabControl.TabControl.GetTabRegionEventArgs) Handles TabControl2.GetTabRegion
        e.Points(1) = New Point(e.TabHeight - 2, 2)
        e.Points(2) = New Point(e.TabHeight + 2, 0)
    End Sub

    Private Sub TabControl5_GetTabRegion(ByVal sender As Object, ByVal e As MdiTabControl.TabControl.GetTabRegionEventArgs) Handles TabControl5.GetTabRegion
        Array.Resize(e.Points, 8)
        e.Points(0) = New Point(0, 19)
        e.Points(1) = New Point(7, 5)
        e.Points(2) = New Point(10, 2)
        e.Points(3) = New Point(13, 0)
        e.Points(4) = New Point(e.TabWidth - 13, 0)
        e.Points(5) = New Point(e.TabWidth - 10, 2)
        e.Points(6) = New Point(e.TabWidth - 7, 5)
        e.Points(7) = New Point(e.TabWidth, 19)
    End Sub

    Private Sub TabControl7_GetTabRegion(ByVal sender As Object, ByVal e As MdiTabControl.TabControl.GetTabRegionEventArgs) Handles TabControl7.GetTabRegion
        Dim x As New Drawing2D.GraphicsPath
        x.AddArc(New Rectangle(0, 0, e.TabWidth, e.TabHeight * 2 / 3), 0, -180)
        x.Flatten()
        Array.Resize(e.Points, x.PointCount)
        For i As Integer = 0 To x.PointCount - 1
            e.Points(i) = New Point(x.PathPoints(i).X, x.PathPoints(i).Y)
        Next
    End Sub

    Private Sub TabControl3_TabPaintBorder(ByVal sender As Object, ByVal e As MdiTabControl.TabControl.TabPaintEventArgs) Handles TabControl3.TabPaintBorder
        If Not e.Selected Then
            e.Handled = True
            e.Graphics.DrawLine(Pens.Azure, e.ClipRectangle.Width - 1, 2, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 3)
        End If
    End Sub

    Private Sub TabControl6_TabPaintBorder(ByVal sender As Object, ByVal e As MdiTabControl.TabControl.TabPaintEventArgs) Handles TabControl6.TabPaintBorder
        If e.Selected Or e.Hot Then
            e.Handled = False
            e.Graphics.FillRectangle(Brushes.Orange, 0, 0, e.TabWidth, 3)
        End If
    End Sub

    Private Sub ChangePropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePropertiesToolStripMenuItem.Click
        TabControl1.ForeColor = Color.Green
        TabControl1.ForeColorDisabled = Color.GreenYellow
        TabControl1.BackHighColor = Color.Bisque
        TabControl1.TabCloseButtonVisible = False
        TabControl1.TabPadLeft = 1
        TabControl1.TabPadRight = 1
        TabControl1.TabTop = 0
        TabControl2.TopSeparator = False
        TabControl2.Alignment = MdiTabControl.TabControl.TabAlignment.Bottom
        TabControl2.BackHighColor = Color.Gray
        TabControl2.BackLowColor = Color.AliceBlue
        TabControl2.TabCloseButtonVisible = True
        TabControl3.BorderColor = Color.Aquamarine
        TabControl4.CloseButtonVisible = True
        TabControl4.TabCloseButtonImage = TabControl1.TabCloseButtonImage
        TabControl4.TabCloseButtonImageDisabled = TabControl1.TabCloseButtonImageDisabled
        TabControl4.TabCloseButtonImageHot = TabControl1.TabCloseButtonImageHot
        TabControl4.TabCloseButtonSize = New Size(10, 10)
        TabControl4.TabHeight = 12
        TabControl4.TabIconSize = New Size(10, 10)
        TabControl4.TabOffset = 10
        TabControl5.BorderColorDisabled = Color.BlueViolet
        TabControl5.ControlButtonBackHighColor = Color.RosyBrown
        TabControl5.ControlButtonBackHighColor = Color.RosyBrown
        TabControl5.ControlButtonBorderColor = Color.Red
        TabControl5.DropButtonVisible = True
        TabControl5.Font = New Font(FontFamily.GenericSerif, 12)
        TabControl5.FontBoldOnSelect = False
        TabControl5.HotTrack = False
        TabControl5.BackColor = Color.Crimson
        TabControl5.Padding = New Padding(5, 5, 5, 5)
        TabControl5.SmoothingMode = Drawing2D.SmoothingMode.Default
        TabControl5.TabBackHighColor = Color.Coral
        TabControl5.TabBackLowColor = Color.Red
        TabControl5.TabBackHighColorDisabled = Color.Aqua
        TabControl5.TabBackLowColorDisabled = Color.Yellow
        TabControl5.TabMaximumWidth = 350
        TabControl5.TabMinimumWidth = 100
        TabControl5.ControlButtonForeColor = Color.Red
    End Sub

    Private Icons(7) As Icon

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'ToolStripManager.VisualStylesEnabled = False
        For i As Integer = 0 To 7
            Dim b As Bitmap = ImageList1.Images(i)
            Icons(i) = Drawing.Icon.FromHandle(b.GetHicon)
            b.Dispose()
            b = Nothing
        Next
        TabControl7.SetColors(New ProfessionalColorTable)
    End Sub

    Private Sub AnimateIconToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnimateIconToolStripMenuItem.Click
        If AnimateIconToolStripMenuItem.Checked Then
            Timer1.Stop()
            AnimateIconToolStripMenuItem.Checked = False
            AnimateIconToolStripMenuItem.Text = "Animate Icon"
        Else
            Timer1.Start()
            AnimateIconToolStripMenuItem.Checked = True
            AnimateIconToolStripMenuItem.Text = "Stop Animation"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static Loading As Boolean = False
        Try
            If Loading Then Exit Sub
            Loading = True
            Static i As Integer = 0
            For Each t As MdiTabControl.TabPage In TabControl4.TabPages
                t.Icon = Icons(i)
            Next
            i = i + 1
            If i >= 8 Then i = 0
        Catch ex As Exception
        Finally
            Loading = False
        End Try
    End Sub

    Private Sub UntabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UntabToolStripMenuItem.Click
        TabControl4.TabPages.TearOff(TabControl4.TabPages.SelectedTab)
        

        'Dim f As Form = TabControl4.TabPages.SelectedTab.Form
        'f.Parent.Controls.Remove(f)
        'f.TopLevel = True
        'f.Dock = DockStyle.None
        'f.Top = 10
        'f.Left = 10
        'f.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        'f.ShowInTaskbar = True
        'f.Show()
        'Dim T As MdiTabControl.TabPage = TabControl4.TabPages.SelectedTab
        'T.Dispose()
        'TabControl4.TabPages.Remove(TabControl4.TabPages.SelectedTab)
    End Sub
End Class