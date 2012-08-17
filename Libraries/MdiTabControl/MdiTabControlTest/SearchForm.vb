Public Class SearchForm

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Dim d As New Detail
        d.Owner = Me
        d.TopLevel = True
        d.Show()
    End Sub

    Private Sub SearchForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    End Sub

    Private Sub SearchForm_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        txtSearch.Focus()
    End Sub

    Private Sub SearchForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = MsgBox("Close this form?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.No
    End Sub

End Class
