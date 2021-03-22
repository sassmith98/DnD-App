Public Class ClassHelpForm
    Private Sub closeClassButton_Click(sender As Object, e As EventArgs) Handles closeClassButton.Click
        classHelpFormCount -= 1
        Me.Close()
    End Sub
End Class