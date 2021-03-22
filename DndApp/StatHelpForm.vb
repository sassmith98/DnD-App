Public Class StatHelpForm
    Private Sub closeStatButton_Click(sender As Object, e As EventArgs) Handles closeStatButton.Click
        statHelpFormCount -= 1
        Me.Close()
    End Sub
End Class