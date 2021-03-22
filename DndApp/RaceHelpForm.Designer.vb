<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RaceHelpForm
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
        Me.raceHelpTextBox = New System.Windows.Forms.TextBox()
        Me.raceHelpTitleLabel = New System.Windows.Forms.Label()
        Me.closeRaceButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'raceHelpTextBox
        '
        Me.raceHelpTextBox.Location = New System.Drawing.Point(24, 57)
        Me.raceHelpTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.raceHelpTextBox.Multiline = True
        Me.raceHelpTextBox.Name = "raceHelpTextBox"
        Me.raceHelpTextBox.ReadOnly = True
        Me.raceHelpTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.raceHelpTextBox.Size = New System.Drawing.Size(478, 189)
        Me.raceHelpTextBox.TabIndex = 1
        Me.raceHelpTextBox.Text = "It's over anakin! I have the high ground" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "... you underestimate my power" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Don't try it!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Noooooooooooooooooooooo"
        '
        'raceHelpTitleLabel
        '
        Me.raceHelpTitleLabel.AutoSize = True
        Me.raceHelpTitleLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.raceHelpTitleLabel.Location = New System.Drawing.Point(75, 16)
        Me.raceHelpTitleLabel.Name = "raceHelpTitleLabel"
        Me.raceHelpTitleLabel.Size = New System.Drawing.Size(262, 32)
        Me.raceHelpTitleLabel.TabIndex = 32
        Me.raceHelpTitleLabel.Text = "How to Pick a Race"
        '
        'closeRaceButton
        '
        Me.closeRaceButton.Location = New System.Drawing.Point(196, 261)
        Me.closeRaceButton.Name = "closeRaceButton"
        Me.closeRaceButton.Size = New System.Drawing.Size(75, 23)
        Me.closeRaceButton.TabIndex = 33
        Me.closeRaceButton.TabStop = False
        Me.closeRaceButton.Text = "Close"
        Me.closeRaceButton.UseVisualStyleBackColor = True
        '
        'RaceHelpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 296)
        Me.Controls.Add(Me.closeRaceButton)
        Me.Controls.Add(Me.raceHelpTitleLabel)
        Me.Controls.Add(Me.raceHelpTextBox)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "RaceHelpForm"
        Me.Text = "RaceHelpForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents raceHelpTextBox As TextBox
    Friend WithEvents raceHelpTitleLabel As Label
    Friend WithEvents closeRaceButton As Button
End Class

