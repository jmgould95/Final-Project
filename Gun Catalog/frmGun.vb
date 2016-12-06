Imports CatalogLibrary
''' <summary>
''' Jimmy Gould
''' Final Project
''' 12/5/1016
''' Add a Gun to the database
''' </summary>
Public Class frmGun
    'The list and the gun object might be taken out when the database is created
    Dim Gun As New Guns
    Dim Ammo As New Ammunition
    Dim AmmoFrm As New frmAmmo
    'Public Sub DataS()
    '    dgvAmmo.DataSource = Ammo.DisplayTable
    'End Sub




    Dim gunList As List(Of Guns) 'a list of gun objects

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    'shows ammo dialog and refreshes the data grid view when ammo form is closed
    Private Sub btnAmmunition_Click(sender As Object, e As EventArgs) Handles btnAmmunition.Click
        AmmoFrm.ShowDialog()
        dgvAmmo.DataSource = Ammo.DisplayTable

    End Sub

    'add button validates inputs and does sql to insert gun into database
    Private Sub btnAddGun_Click(sender As Object, e As EventArgs) Handles btnAddGun.Click
        Dim purchased As DateTime = dtpDatePurchased.Value.Date
        Dim make As String = ""
        Dim model As String = ""
        Dim type As String = ""
        Dim purchaseDate As String = dtpDatePurchased.Value.Date.ToString()

        Dim serialNum As String = txtSN.Text
        Dim ammoID As Integer = 0
        Dim ammoIndex As Integer = dgvAmmo.CurrentCell.RowIndex
        Dim selectedAmmo As String = dgvAmmo.Rows(ammoIndex).Cells(0).Value.ToString
        'MessageBox.Show(dgvAmmo.Rows(ammoIndex).Cells(0).Value.ToString)
        'validates input
        ammoID = Gun.AmmoId(selectedAmmo)
        'MessageBox.Show(ammoID.ToString)
        If txtBrand.Text.Trim() = "" Then
            lblStatus.Text = "You must input a brand"
            txtBrand.Focus()
            Return
        Else
            make = txtBrand.Text
        End If
        If txtModel.Text.Trim() = "" Then
            lblStatus.Text = "You must input a Model"
            txtModel.Focus()
            Return
        Else
            model = txtModel.Text
        End If

        If txtSN.Text.Trim() = "" Then
            lblStatus.Text = "You must input a serial number"
            txtModel.Focus()
            Return
        Else
            serialNum = txtSN.Text
        End If

        'gets ammo type and ID
        'If lstAmmo.SelectedIndex < 0 Then
        '    lblStatus.Text = "You must select an ammunition"
        '    Return
        'Else
        '    ammoID = lstAmmo.SelectedIndex
        'End If

        'checks for gun type
        If radPistol.Checked Then
            type = "Pistol"
        ElseIf (radRifle.Checked) Then
            type = "Rifle"
        Else
            type = "Shot Gun"
        End If


        'string to add gun to database
        'Dim sql As String = "INSERT INTO Gun (Make, Model, Type, SerialNumber, DatePurchased, AmmoId) Values( '" + make + "','" + model + "','" + type + "','" + serialNum + "','" + purchaseDate + "','" + ammoID.ToString + "')"

        'Gun.ExecuteQuery(sql)
        Gun.AddGun(make, model, type, purchaseDate, serialNum, ammoID)
        If Gun.LastStatus = "Succeed" Then
            lblStatus.Text = "Your gun was added"
        Else
            lblStatus.Text = "Failed to add gun to database"
        End If

    End Sub

    Private Sub frmGun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set the data source of the list box to the database of ammo
        dgvAmmo.DataSource = Ammo.DisplayTable
    End Sub


    Private Sub dgvAmmo_DataMemberChanged(sender As Object, e As EventArgs) Handles dgvAmmo.DataMemberChanged
        MessageBox.Show("Wroking")
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        dgvAmmo.DataSource = Ammo.DisplayTable
    End Sub
End Class