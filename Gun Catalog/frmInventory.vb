Imports CatalogLibrary

Public Class frmInventory
    Dim gunDb As New Guns
    Dim ammoDb As New Ammunition
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnViewGuns_Click(sender As Object, e As EventArgs) Handles btnViewGuns.Click
        dgvInventory.DataSource = gunDb.DisplayTable
    End Sub

    Private Sub btnViewAmmo_Click(sender As Object, e As EventArgs) Handles btnViewAmmo.Click
        dgvInventory.DataSource = ammoDb.DisplayTable
    End Sub
End Class