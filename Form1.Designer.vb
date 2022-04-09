<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ZoomInButton = New System.Windows.Forms.Button()
        Me.ZoomOutButton = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.MinimizeButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.RestoreZoomButton = New System.Windows.Forms.Button()
        Me.CreateNewWindow = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ZoomInButton
        '
        Me.ZoomInButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ZoomInButton.Location = New System.Drawing.Point(12, 192)
        Me.ZoomInButton.Name = "ZoomInButton"
        Me.ZoomInButton.Size = New System.Drawing.Size(75, 23)
        Me.ZoomInButton.TabIndex = 0
        Me.ZoomInButton.Text = "Zoom in"
        Me.ZoomInButton.UseVisualStyleBackColor = True
        '
        'ZoomOutButton
        '
        Me.ZoomOutButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ZoomOutButton.Location = New System.Drawing.Point(93, 192)
        Me.ZoomOutButton.Name = "ZoomOutButton"
        Me.ZoomOutButton.Size = New System.Drawing.Size(75, 23)
        Me.ZoomOutButton.TabIndex = 1
        Me.ZoomOutButton.Text = "Zoom out"
        Me.ZoomOutButton.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(431, 164)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'MinimizeButton
        '
        Me.MinimizeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimizeButton.Location = New System.Drawing.Point(391, 192)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(23, 23)
        Me.MinimizeButton.TabIndex = 4
        Me.MinimizeButton.Text = "−"
        Me.MinimizeButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.Location = New System.Drawing.Point(420, 192)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(23, 23)
        Me.CloseButton.TabIndex = 5
        Me.CloseButton.Text = "⨉"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'RestoreZoomButton
        '
        Me.RestoreZoomButton.Location = New System.Drawing.Point(174, 192)
        Me.RestoreZoomButton.Name = "RestoreZoomButton"
        Me.RestoreZoomButton.Size = New System.Drawing.Size(75, 23)
        Me.RestoreZoomButton.TabIndex = 2
        Me.RestoreZoomButton.Text = "Restore"
        Me.RestoreZoomButton.UseVisualStyleBackColor = True
        '
        'CreateNewWindow
        '
        Me.CreateNewWindow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreateNewWindow.Location = New System.Drawing.Point(362, 192)
        Me.CreateNewWindow.Name = "CreateNewWindow"
        Me.CreateNewWindow.Size = New System.Drawing.Size(23, 23)
        Me.CreateNewWindow.TabIndex = 3
        Me.CreateNewWindow.Text = "+"
        Me.CreateNewWindow.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(255, 196)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(74, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Low light"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(455, 227)
        Me.ControlBox = False
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CreateNewWindow)
        Me.Controls.Add(Me.RestoreZoomButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.MinimizeButton)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ZoomOutButton)
        Me.Controls.Add(Me.ZoomInButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "The Lord's Prayer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ZoomInButton As Button
    Friend WithEvents ZoomOutButton As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents MinimizeButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents RestoreZoomButton As Button
    Friend WithEvents CreateNewWindow As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
