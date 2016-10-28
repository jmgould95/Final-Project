Public Class frmMain
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAddGun.Click
        frmGun.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAddAmmo.Click
        frmAmmo.ShowDialog()
    End Sub

    Private Sub btnViewInventory_Click(sender As Object, e As EventArgs) Handles btnViewInventory.Click
        frmInventory.ShowDialog()
    End Sub
End Class
