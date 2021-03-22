Public Class attributeAllocationForm
    Private Sub closeAttributeAllocationButton_Click(sender As Object, e As EventArgs) Handles closeAttributeAllocationButton.Click
        attributeAllocationHelpFormCount -= 1
        Me.Close()
    End Sub
End Class