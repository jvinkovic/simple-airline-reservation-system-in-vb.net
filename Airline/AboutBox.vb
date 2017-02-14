Public NotInheritable Class AboutBox

    Private Sub AboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub TextBoxDescription_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDescription.TextChanged

    End Sub
End Class
