Imports CatalogLibrary

Public Class frmMain
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAddGun.Click
        Dim gunForm As New frmGun()
        gunForm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAddAmmo.Click
        Dim ammoForm As New frmAmmo()
        ammoForm.ShowDialog()
    End Sub

    Private Sub btnViewInventory_Click(sender As Object, e As EventArgs) Handles btnViewInventory.Click
        Dim inventoryForm As New frmInventory()
        inventoryForm.ShowDialog()
    End Sub
End Class
