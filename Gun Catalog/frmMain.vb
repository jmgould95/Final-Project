Imports CatalogLibrary
''' <summary>
''' Jimmy Gould
''' Final Project
''' 12/5/2016
''' This Form Adds ammo
''' </summary>
Public Class frmMain
    'shows the gun form
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAddGun.Click
        Dim gunForm As New frmGun()
        gunForm.ShowDialog()
    End Sub
    'shows the ammo form
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAddAmmo.Click
        Dim ammoForm As New frmAmmo()
        ammoForm.ShowDialog()
    End Sub

    'shows the inventory form
    Private Sub btnViewInventory_Click(sender As Object, e As EventArgs) Handles btnViewInventory.Click
        Dim inventoryForm As New frmInventory()
        inventoryForm.ShowDialog()
    End Sub
End Class
