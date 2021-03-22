Public Class RaceHelpForm
    Private Sub closeRaceButton_Click(sender As Object, e As EventArgs) Handles closeRaceButton.Click
        raceHelpFormCount -= 1
        Me.Close()
    End Sub
End Class