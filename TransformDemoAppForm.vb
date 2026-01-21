Public Class TransformDemoAppForm
    Private Sub PutNameButton_Click(sender As Object, e As EventArgs) Handles PutNameButton.Click
        ResultNameLabel.Text = "Welcome, " & NameInputForm.Text
    End Sub
End Class
