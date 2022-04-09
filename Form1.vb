Public Class Form1
    Private Sub ZoomInButton_Click(sender As Object, e As EventArgs) Handles ZoomInButton.Click
        RichTextBox1.ZoomFactor += 0.5
        If RichTextBox1.ZoomFactor = 1 Then
            ZoomOutButton.Enabled = True
        End If
    End Sub
    Private Sub ZoomOutButton_Click(sender As Object, e As EventArgs) Handles ZoomOutButton.Click
        RichTextBox1.ZoomFactor -= 0.5
        If RichTextBox1.ZoomFactor = 0.5 Then
            ZoomOutButton.Enabled = False
        End If
    End Sub
    Private Sub RestoreZoomButton_Click(sender As Object, e As EventArgs) Handles RestoreZoomButton.Click
        RichTextBox1.ZoomFactor = 1
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.BackColor = Color.DimGray
            RichTextBox1.BackColor = Color.DimGray
            RichTextBox1.ForeColor = Color.White
        End If
        If CheckBox1.Checked = False Then
            Me.BackColor = Color.WhiteSmoke
            RichTextBox1.BackColor = Color.WhiteSmoke
            RichTextBox1.ForeColor = Color.Black
        End If
    End Sub
    Private Sub CreateNewWindow_Click(sender As Object, e As EventArgs) Handles CreateNewWindow.Click
        Dim NW As New Form1
        NW.Show()
    End Sub
    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = 1
    End Sub
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
#Region " Move Form "
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub
    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub
    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub
#End Region
End Class