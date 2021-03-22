<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatHelpForm
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
        Me.statHelpTextBox = New System.Windows.Forms.TextBox()
        Me.statHelpTitleLabel = New System.Windows.Forms.Label()
        Me.closeStatButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'statHelpTextBox
        '
        Me.statHelpTextBox.Location = New System.Drawing.Point(24, 57)
        Me.statHelpTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.statHelpTextBox.Multiline = True
        Me.statHelpTextBox.Name = "statHelpTextBox"
        Me.statHelpTextBox.ReadOnly = True
        Me.statHelpTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.statHelpTextBox.Size = New System.Drawing.Size(478, 189)
        Me.statHelpTextBox.TabIndex = 1
        Me.statHelpTextBox.Text = "It's over anakin! I have the high ground" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "... you underestimate my power" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Don't try it!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Noooooooooooooooooooooo"
        '
        'statHelpTitleLabel
        '
        Me.statHelpTitleLabel.AutoSize = True
        Me.statHelpTitleLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.statHelpTitleLabel.Location = New System.Drawing.Point(75, 16)
        Me.statHelpTitleLabel.Name = "statHelpTitleLabel"
        Me.statHelpTitleLabel.Size = New System.Drawing.Size(293, 32)
        Me.statHelpTitleLabel.TabIndex = 32
        Me.statHelpTitleLabel.Text = "How to Roll Your Dice"
        '
        'closeStatButton
        '
        Me.closeStatButton.Location = New System.Drawing.Point(196, 261)
        Me.closeStatButton.Name = "closeStatButton"
        Me.closeStatButton.Size = New System.Drawing.Size(75, 23)
        Me.closeStatButton.TabIndex = 33
        Me.closeStatButton.TabStop = False
        Me.closeStatButton.Text = "Close"
        Me.closeStatButton.UseVisualStyleBackColor = True
        '
        'StatHelpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 296)
        Me.Controls.Add(Me.closeStatButton)
        Me.Controls.Add(Me.statHelpTitleLabel)
        Me.Controls.Add(Me.statHelpTextBox)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "StatHelpForm"
        Me.Text = "StatHelpForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents statHelpTextBox As TextBox
    Friend WithEvents statHelpTitleLabel As Label
    Friend WithEvents closeStatButton As Button
End Class
