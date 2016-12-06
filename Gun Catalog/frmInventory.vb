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
        btnAvailAmmo.Enabled = True
        btnAvailAmmo.Visible = True
        btnAvailGuns.Enabled = False
        btnAvailGuns.Visible = False
        dgvInventory.DataSource = gunDb.DisplayTable
        Showing = "g"
    End Sub

    Private Sub btnViewAmmo_Click(sender As Object, e As EventArgs) Handles btnViewAmmo.Click
        btnAvailAmmo.Enabled = False
        btnAvailAmmo.Visible = False
        btnAvailGuns.Enabled = True
        btnAvailGuns.Visible = True
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

        Dim selectedId As Integer
        If Not Integer.TryParse(selectedAmmo, selectedId) Then
            lblStatus.Text = "Please select an Item"
        End If
        Dim item As Boolean

        If Showing = "g" Then

            Dim selectedMake As String = dgvInventory.Rows(ItemIndex).Cells(1).Value.ToString
            Dim selectedModel As String = dgvInventory.Rows(ItemIndex).Cells(2).Value.ToString
            Dim selectedType As String = dgvInventory.Rows(ItemIndex).Cells(3).Value.ToString
            Dim selectedSerialNum As String = dgvInventory.Rows(ItemIndex).Cells(5).Value.ToString
            Dim selectedDate As String = dgvInventory.Rows(ItemIndex).Cells(6).Value.ToString

            'Edit Gun is a form object Here I send the selected guns information to the edit gun form
            EditGun.Id = selectedId
            EditGun.Make = selectedMake
            EditGun.Model = selectedModel
            EditGun.Type = selectedType
            EditGun.SerialNum = selectedSerialNum
            EditGun.Purchased = selectedDate

            EditGun.ShowDialog() 'shows gun form
            dgvInventory.DataSource = gunDb.DisplayTable 'refreshes the data table


        ElseIf Showing = "a" Then
            Dim brand As String = dgvInventory.Rows(ItemIndex).Cells(1).Value.ToString
            Dim caliber As String = dgvInventory.Rows(ItemIndex).Cells(3).Value.ToString
            Dim grain As Integer = Integer.Parse(dgvInventory.Rows(ItemIndex).Cells(2).Value.ToString)
            Dim quantity As Integer = Integer.Parse(dgvInventory.Rows(ItemIndex).Cells(5).Value.ToString)
            Dim purchaseDate As String = dgvInventory.Rows(ItemIndex).Cells(4).Value.ToString
            Dim type As String = dgvInventory.Rows(ItemIndex).Cells(6).Value.ToString

            EditAmmo.Id = selectedId
            EditAmmo.Brand = brand
            EditAmmo.Caliber = caliber
            EditAmmo.Grain = grain
            EditAmmo.Quantity = quantity
            EditAmmo.Purchased = purchaseDate
            EditAmmo.Type = type

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

    Private Sub btnAvailAmmo_Click(sender As Object, e As EventArgs) Handles btnAvailAmmo.Click
        Dim ItemIndex As Integer
        Try
            ItemIndex = dgvInventory.CurrentCell.RowIndex
        Catch ex As Exception
            lblStatus.Text = "Please select an Item"
            Return
        End Try
        Dim caliber As String = dgvInventory.Rows(ItemIndex).Cells(4).Value.ToString


        dgvInventory.DataSource = ammoDb.AvailableAmmo(caliber)
        lblStatus.Text = "Total Compatable Ammo is: " + ammoDb.TotalAmmo(caliber)
    End Sub

    Private Sub btnAvailGuns_Click(sender As Object, e As EventArgs) Handles btnAvailGuns.Click
        Dim ItemIndex As Integer
        Try
            ItemIndex = dgvInventory.CurrentCell.RowIndex
        Catch ex As Exception
            lblStatus.Text = "Please select an Item"
            Return
        End Try
        Dim selectedAmmo As String = dgvInventory.Rows(ItemIndex).Cells(0).Value.ToString

        Dim selectedId As Integer
        If Not Integer.TryParse(selectedAmmo, selectedId) Then
            lblStatus.Text = "Please select an Item"
        End If
        Dim item As Boolean

        dgvInventory.DataSource = gunDb.FindCompatableGuns(selectedId)
        lblStatus.Text = "Total of " + gunDb.TotalCompatableGuns(selectedId) + " Guns can use this ammo"
    End Sub
End Class