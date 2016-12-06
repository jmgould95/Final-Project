Imports CatalogLibrary

Public Class frmEditGun
    Dim itemId As Integer
    Dim Gun As New Guns
    Dim Ammo As New Ammunition
    Public Property Id As Integer
    Public Property Purchased As String
    Public Property Make As String
    Public Property Model As String
    Public Property Type As String
    Public Property SerialNum As String


    Private Sub frmEditGun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStatus.Text = ""
        txtId.Text = Id.ToString()
        dgvAmmo.DataSource = Ammo.DisplayTable
        txtBrand.Text = Make
        txtModel.Text = Model
        txtSN.Text = SerialNum
        dtpDatePurchased.Value = DateTime.Parse(Purchased)

        If Type = "Pistol" Then
            radPistol.Checked = True

        ElseIf (Type = "Rifle") Then
            radRifle.Checked = True
        Else
            radShotGun.Checked = True
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
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
        Gun.UpdateGun(make, model, type, purchaseDate, serialNum, ammoID, Id)
        If Gun.LastStatus = "Succeed" Then
            lblStatus.Text = "Your gun was Updated"
        Else
            lblStatus.Text = "Failed to update gun in database"
        End If

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub
End Class