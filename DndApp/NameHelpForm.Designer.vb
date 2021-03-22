<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NameHelpForm
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
        Me.nameHelpTextBox = New System.Windows.Forms.TextBox()
        Me.nameHelpTitleLabel = New System.Windows.Forms.Label()
        Me.closeNameButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'nameHelpTextBox
        '
        Me.nameHelpTextBox.Location = New System.Drawing.Point(24, 57)
        Me.nameHelpTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nameHelpTextBox.Multiline = True
        Me.nameHelpTextBox.Name = "nameHelpTextBox"
        Me.nameHelpTextBox.ReadOnly = True
        Me.nameHelpTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.nameHelpTextBox.Size = New System.Drawing.Size(478, 189)
        Me.nameHelpTextBox.TabIndex = 1
        Me.nameHelpTextBox.Text = "It's over anakin! I have the high ground" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "... you underestimate my power" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Don't try it!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Noooooooooooooooooooooo"
        '
        'nameHelpTitleLabel
        '
        Me.nameHelpTitleLabel.AutoSize = True
        Me.nameHelpTitleLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.nameHelpTitleLabel.Location = New System.Drawing.Point(75, 16)
        Me.nameHelpTitleLabel.Name = "nameHelpTitleLabel"
        Me.nameHelpTitleLabel.Size = New System.Drawing.Size(329, 32)
        Me.nameHelpTitleLabel.TabIndex = 32
        Me.nameHelpTitleLabel.Text = "How to Type Your Name"
        '
        'closeNameButton
        '
        Me.closeNameButton.Location = New System.Drawing.Point(196, 261)
        Me.closeNameButton.Name = "closeNameButton"
        Me.closeNameButton.Size = New System.Drawing.Size(75, 23)
        Me.closeNameButton.TabIndex = 33
        Me.closeNameButton.TabStop = False
        Me.closeNameButton.Text = "Close"
        Me.closeNameButton.UseVisualStyleBackColor = True
        '
        'NameHelpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 296)
        Me.Controls.Add(Me.closeNameButton)
        Me.Controls.Add(Me.nameHelpTitleLabel)
        Me.Controls.Add(Me.nameHelpTextBox)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "NameHelpForm"
        Me.Text = "NameHelpForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nameHelpTextBox As TextBox
    Friend WithEvents nameHelpTitleLabel As Label
    Friend WithEvents closeNameButton As Button
End Class

