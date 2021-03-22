Public Class NameHelpForm
    Private Sub closeNameButton_Click(sender As Object, e As EventArgs) Handles closeNameButton.Click
        nameHelpFormCount -= 1
        Me.Close()
    End Sub
End Class