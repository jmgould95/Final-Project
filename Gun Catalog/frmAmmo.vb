Imports CatalogLibrary
''' <summary>
''' Jimmy Gould
''' Final Project
''' 12/5/2016
''' This Form Adds ammo
''' </summary>
Public Class frmAmmo
    Dim Ammo As New Ammunition

    'this button closes the form
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub frmAmmo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'takes form information and vailidates then sends to be added to database
    Private Sub btnAddAmmo_Click(sender As Object, e As EventArgs) Handles btnAddAmmo.Click
        Dim brand As String
        Dim caliber As String
        Dim grain As Integer
        Dim quantity As Integer
        Dim purchaseDate As String = dtpDatePurchased.Value.Date.ToString
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

        'Dim sql As String = "INSERT INTO Ammo (Brand, Grain, Caliber, PurchaseDate, Quantity, Type) Values('test'," + grain.ToString + ",'" + caliber + "','" + purchaseDate + "'," + quantity.ToString + ",'" + type + "')"

        Ammo.ExecuteQuery(brand, caliber, grain, quantity, purchaseDate, type)
        lblStatus.Text = Ammo.LastStatus
    End Sub
End Class