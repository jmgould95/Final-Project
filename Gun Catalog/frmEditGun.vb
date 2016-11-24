Imports CatalogLibrary
Public Class frmEditGun

    Dim gunDb As New Guns
    Private Sub frmEditGun_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvGuns.DataSource = gunDb.DisplayTable
    End Sub
End Class