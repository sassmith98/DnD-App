<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class attributeAllocationForm
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
        Me.attributeAllocationHelpTextBox = New System.Windows.Forms.TextBox()
        Me.attributeAllocationHelpTitleLabel = New System.Windows.Forms.Label()
        Me.closeAttributeAllocationButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'attributeAllocationHelpTextBox
        '
        Me.attributeAllocationHelpTextBox.Location = New System.Drawing.Point(24, 57)
        Me.attributeAllocationHelpTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.attributeAllocationHelpTextBox.Multiline = True
        Me.attributeAllocationHelpTextBox.Name = "attributeAllocationHelpTextBox"
        Me.attributeAllocationHelpTextBox.ReadOnly = True
        Me.attributeAllocationHelpTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.attributeAllocationHelpTextBox.Size = New System.Drawing.Size(478, 189)
        Me.attributeAllocationHelpTextBox.TabIndex = 1
        Me.attributeAllocationHelpTextBox.Text = "It's over anakin! I have the high ground" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "... you underestimate my power" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Don't try it!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Noooooooooooooooooooooo"
        '
        'attributeAllocationHelpTitleLabel
        '
        Me.attributeAllocationHelpTitleLabel.AutoSize = True
        Me.attributeAllocationHelpTitleLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.attributeAllocationHelpTitleLabel.Location = New System.Drawing.Point(75, 16)
        Me.attributeAllocationHelpTitleLabel.Name = "attributeAllocationHelpTitleLabel"
        Me.attributeAllocationHelpTitleLabel.Size = New System.Drawing.Size(418, 32)
        Me.attributeAllocationHelpTitleLabel.TabIndex = 32
        Me.attributeAllocationHelpTitleLabel.Text = "How to Allocate Your Attributes"
        '
        'closeAttributeAllocationButton
        '
        Me.closeAttributeAllocationButton.Location = New System.Drawing.Point(196, 261)
        Me.closeAttributeAllocationButton.Name = "closeAttributeAllocationButton"
        Me.closeAttributeAllocationButton.Size = New System.Drawing.Size(75, 23)
        Me.closeAttributeAllocationButton.TabIndex = 33
        Me.closeAttributeAllocationButton.TabStop = False
        Me.closeAttributeAllocationButton.Text = "Close"
        Me.closeAttributeAllocationButton.UseVisualStyleBackColor = True
        '
        'attributeAllocationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 296)
        Me.Controls.Add(Me.closeAttributeAllocationButton)
        Me.Controls.Add(Me.attributeAllocationHelpTitleLabel)
        Me.Controls.Add(Me.attributeAllocationHelpTextBox)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "attributeAllocationForm"
        Me.Text = "AttributAllocationHelpForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents attributeAllocationHelpTextBox As TextBox
    Friend WithEvents attributeAllocationHelpTitleLabel As Label
    Friend WithEvents closeAttributeAllocationButton As Button
End Class
