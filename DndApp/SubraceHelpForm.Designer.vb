<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubraceHelpForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.subraceHelpTextBox = New System.Windows.Forms.TextBox()T
        Me.subraceHelpTitleLabel = New System.Windows.Forms.Label()
        Me.closeSubraceButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'classHelpTextBox
        '
        Me.subraceHelpTextBox.Location = New System.Drawing.Point(24, 57)
        Me.subraceHelpTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.subraceHelpTextBox.Multiline = True
        Me.subraceHelpTextBox.Name = "subraceHelpTextBox"
        Me.subraceHelpTextBox.ReadOnly = True
        Me.subraceHelpTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.subraceHelpTextBox.Size = New System.Drawing.Size(478, 189)
        Me.subraceHelpTextBox.TabIndex = 1
        Me.subraceHelpTextBox.Text = "It's over anakin! I have the high ground" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "... you underestimate my power" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Don't try it!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Noooooooooooooooooooooo"
        '
        'classHelpTitleLabel
        '
        Me.subraceHelpTitleLabel.AutoSize = True
        Me.subraceHelpTitleLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.subraceHelpTitleLabel.Location = New System.Drawing.Point(75, 16)
        Me.subraceHelpTitleLabel.Name = "subraceHelpTitleLabel"
        Me.subraceHelpTitleLabel.Size = New System.Drawing.Size(269, 32)
        Me.subraceHelpTitleLabel.TabIndex = 32
        Me.subraceHelpTitleLabel.Text = "How to Pick a Subrace"
        '
        'closeClassButton
        '
        Me.closeSubraceButton.Location = New System.Drawing.Point(196, 261)
        Me.closeSubraceButton.Name = "subraceClassButton"
        Me.closeSubraceButton.Size = New System.Drawing.Size(75, 23)
        Me.closeSubraceButton.TabIndex = 33
        Me.closeSubraceButton.TabStop = False
        Me.closeSubraceButton.Text = "Close"
        Me.closeSubraceButton.UseVisualStyleBackColor = True
        '
        'ClassHelpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 296)
        Me.Controls.Add(Me.closeSubraceButton)
        Me.Controls.Add(Me.subraceHelpTitleLabel)
        Me.Controls.Add(Me.subraceHelpTextBox)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "SubraceHelpForm"
        Me.Text = "SubraceHelpForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents subraceHelpTextBox As TextBox
    Friend WithEvents subraceHelpTitleLabel As Label
    Friend WithEvents closeSubraceButton As Button
End Class

