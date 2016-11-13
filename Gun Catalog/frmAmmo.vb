Imports CatalogLibrary

Public Class frmAmmo
    Dim Ammo As Ammunition

    Dim AmmoList As List(Of Ammunition) 'a list of gun objects

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub frmAmmo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAddAmmo_Click(sender As Object, e As EventArgs) Handles btnAddAmmo.Click
        Dim brand As String
        Dim caliber As String
        Dim grain As Integer
        Dim quantity As Integer
        Dim purchaseDate As DateTime = dtpDatePurchased.Value.Date
        Dim type As String

        If txtBrand.Text.Trim() = "" Then
            lblStatus.Text = "Please provide a Brand"
            txtBrand.Focus()
            Return
        Else
            brand = txtBrand.Text

        End If

        If txtCaliber.Text.Trim() = "" Then
            lblStatus.Text = "Please provide a caliber"
            txtCaliber.Focus()
            Return
        Else
            caliber = txtCaliber.Text

        End If

        If radFMJ.Checked Then
            type = "FMJ"
        ElseIf (radHollowPoint.Checked) Then
            type = "Hollow Point"
        Else
            type = "Shotgun"
        End If

        If Not Integer.TryParse(txtGrain.Text, grain) Then
            lblStatus.Text = "Please provide a bullet grain"
            txtCaliber.Focus()
            Return

        End If
        If grain <= 0 Then
            lblStatus.Text = "Grain should be grater than 0"
        End If

        If Not Integer.TryParse(txtQuantity.Text, quantity) Then
            lblStatus.Text = "Please provide a quantity"
            txtCaliber.Focus()
            Return

        End If
        If quantity < 0 Then
            lblStatus.Text = "You cannot have a negative quantity"
        End If

        Ammo = New Ammunition(brand, caliber, grain, purchaseDate, quantity, type)
        AmmoList.Add(Ammo)
        lblStatus.Text = "Ammo Added to database"
    End Sub
End Class