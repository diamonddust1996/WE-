Public Class Gen_Select

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
        Me.Close()
    End Sub

    Private Sub Gen_ComboBox_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gen_ComboBox.DropDown

    End Sub
End Class
