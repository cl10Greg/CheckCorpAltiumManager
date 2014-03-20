Public Class Main

    Private Sub toolExitBtn_Click(sender As Object, e As EventArgs) Handles toolExitBtn.Click
        Dispose()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dispose()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tempControl As New idleLogo
        'Configure panels
        actionPanel.Width = (Me.Width / 2) / 2 - actionPanel.Left
        actionPanel.Height = Me.Height / 2 - actionPanel.Top
        contentPanel.Left = (Me.Width / 2) / 2 + actionPanel.Left
        contentPanel.Width = (Me.Width / 2) * 1.5 - 50
        contentPanel.Height = Me.Height / 2 - contentPanel.Top
        optionsPanel.Top = actionPanel.Top + actionPanel.Height + 20
        optionsPanel.Width = actionPanel.Width + contentPanel.Width + 16
        optionsPanel.Height = Me.Height / 2 - 70
        'Update buttons
        contentPanel.Controls.Add(tempControl)
        'Configure default settings
        'File location
    End Sub
End Class
