<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClassHelpForm
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
        Me.classHelpTextBox = New System.Windows.Forms.TextBox()
        Me.classHelpTitleLabel = New System.Windows.Forms.Label()
        Me.closeClassButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'classHelpTextBox
        '
        Me.classHelpTextBox.Location = New System.Drawing.Point(24, 57)
        Me.classHelpTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.classHelpTextBox.Multiline = True
        Me.classHelpTextBox.Name = "classHelpTextBox"
        Me.classHelpTextBox.ReadOnly = True
        Me.classHelpTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.classHelpTextBox.Size = New System.Drawing.Size(478, 189)
        Me.classHelpTextBox.TabIndex = 1
        Me.classHelpTextBox.Text = "It's over anakin! I have the high ground" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "... you underestimate my power" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Don't try it!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Noooooooooooooooooooooo"
        '
        'classHelpTitleLabel
        '
        Me.classHelpTitleLabel.AutoSize = True
        Me.classHelpTitleLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.classHelpTitleLabel.Location = New System.Drawing.Point(75, 16)
        Me.classHelpTitleLabel.Name = "classHelpTitleLabel"
        Me.classHelpTitleLabel.Size = New System.Drawing.Size(269, 32)
        Me.classHelpTitleLabel.TabIndex = 32
        Me.classHelpTitleLabel.Text = "How to Pick a Class"
        '
        'closeClassButton
        '
        Me.closeClassButton.Location = New System.Drawing.Point(196, 261)
        Me.closeClassButton.Name = "closeClassButton"
        Me.closeClassButton.Size = New System.Drawing.Size(75, 23)
        Me.closeClassButton.TabIndex = 33
        Me.closeClassButton.TabStop = False
        Me.closeClassButton.Text = "Close"
        Me.closeClassButton.UseVisualStyleBackColor = True
        '
        'ClassHelpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 296)
        Me.Controls.Add(Me.closeClassButton)
        Me.Controls.Add(Me.classHelpTitleLabel)
        Me.Controls.Add(Me.classHelpTextBox)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ClassHelpForm"
        Me.Text = "ClassHelpForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents classHelpTextBox As TextBox
    Friend WithEvents classHelpTitleLabel As Label
    Friend WithEvents closeClassButton As Button
End Class
