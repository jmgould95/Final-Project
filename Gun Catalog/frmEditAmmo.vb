Imports CatalogLibrary
''' <summary>
''' Jimmy Gould
''' Final Project
''' 12/5/2016
''' This Form Edits ammo
''' </summary>
Public Class frmEditAmmo
    Dim itemId As Integer
    Dim Gun As New Guns
    Dim Ammo As New Ammunition
    Public Property Id As Integer
    Public Property Brand As String
    Public Property Caliber As String
    Public Property Grain As Integer
    Public Property Quantity As Integer
    Public Property Purchased As String
    Public Property Type As String

    'sets approperiate fields to the sent values for the ammo
    Private Sub frmEditAmmo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtId.Text = Id.ToString
        txtBrand.Text = Brand
        txtCaliber.Text = Caliber
        txtGrain.Text = Grain.ToString
        txtQuantity.Text = Quantity.ToString
        dtpDatePurchased.Value = DateTime.Parse(Purchased)
        If Type = "FMJ" Then
            radFMJ.Checked = True
        ElseIf (Type = "Hollow Point") Then
            radHollowPoint.Checked = True
        Else
            radShotgun.Checked = True
        End If
    End Sub

    'validates and calls Ammunition to update specific ammunition
    Private Sub btnUpdateAmmo_Click(sender As Object, e As EventArgs) Handles btnUpdateAmmo.Click
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

        Ammo.UpdateAmmo(brand, caliber, grain, quantity, purchaseDate, type, Id)
        lblStatus.Text = Ammo.LastStatus
    End Sub

    'this closes it 
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub
End Class