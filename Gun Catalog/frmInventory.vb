Imports CatalogLibrary

Public Class frmInventory
    Dim gunDb As New Guns
    Dim ammoDb As New Ammunition
    Dim Showing As String = ""
    Dim EditAmmo As New frmEditAmmo
    Dim EditGun As New frmEditGun()

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnViewGuns_Click(sender As Object, e As EventArgs) Handles btnViewGuns.Click
        dgvInventory.DataSource = gunDb.DisplayTable
        Showing = "g"
    End Sub

    Private Sub btnViewAmmo_Click(sender As Object, e As EventArgs) Handles btnViewAmmo.Click
        dgvInventory.DataSource = ammoDb.DisplayAll
        Showing = "a"
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim ItemIndex As Integer
        Try
            ItemIndex = dgvInventory.CurrentCell.RowIndex
        Catch ex As Exception
            lblStatus.Text = "Please select an Item"
            Return
        End Try
        Dim selectedItem As String = dgvInventory.Rows(ItemIndex).Cells(0).Value.ToString
        MessageBox.Show(selectedItem)
        Dim selectedId As Integer
        If Not Integer.TryParse(selectedItem, selectedId) Then
            lblStatus.Text = "Please select an Item"
        End If
        Dim item As Boolean
        If Showing = "g" Then
            item = gunDb.DeleteGun(selectedId)
            If item Then
                lblStatus.Text = "Gun Sucessfully Deleted"
                dgvInventory.DataSource = gunDb.DisplayTable
            End If

        ElseIf Showing = "a" Then
            item = ammoDb.DeleteAmmo(selectedId)
            If item Then
                lblStatus.Text = "Ammo Successfully Deleted"
                dgvInventory.DataSource = ammoDb.DisplayAll
            End If
        Else
            lblStatus.Text = "Please Select an item"
        End If




    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim ItemIndex As Integer
        Try
            ItemIndex = dgvInventory.CurrentCell.RowIndex
        Catch ex As Exception
            lblStatus.Text = "Please select an Item"
            Return
        End Try
        Dim selectedAmmo As String = dgvInventory.Rows(ItemIndex).Cells(0).Value.ToString
        MessageBox.Show(selectedAmmo)
        Dim selectedId As Integer
        If Not Integer.TryParse(selectedAmmo, selectedId) Then
            lblStatus.Text = "Please select an Item"
        End If
        Dim item As Boolean
        If Showing = "g" Then
            EditGun.Id = selectedId
            EditGun.ShowDialog()
            dgvInventory.DataSource = gunDb.DisplayTable


        ElseIf Showing = "a" Then
            EditAmmo.Id = selectedId
            EditAmmo.ShowDialog()
            dgvInventory.DataSource = ammoDb.DisplayAll


        Else
            lblStatus.Text = "Please Select an item"
        End If
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        If Showing = "g" Then
            dgvInventory.DataSource = gunDb.FindByName(txtFind.Text)
            lblStatus.Text = gunDb.LastStatus
        ElseIf (Showing = "a") Then
            dgvInventory.DataSource = ammoDb.FindAmmo(txtFind.Text)

        Else
            lblStatus.Text = "Please Select dispaly an inventory item"

        End If

    End Sub
End Class