﻿Imports CatalogLibrary

Public Class frmGun
    'The list and the gun object might be taken out when the database is created
    Dim Gun As Gun

    Dim gunList As List(Of Gun) 'a list of gun objects

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub btnAmmunition_Click(sender As Object, e As EventArgs) Handles btnAmmunition.Click
        frmAmmo.ShowDialog()
    End Sub

    Private Sub btnAddGun_Click(sender As Object, e As EventArgs) Handles btnAddGun.Click
        Dim purchased As DateTime = dtpDatePurchased.Value.Date
        Dim make As String = ""
        Dim model As String = ""
        Dim type As String = ""
        Dim serialNum As String = txtSN.Text
        Dim ammoID As Integer = 0

        'validates input
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
        If lstAmmo.SelectedIndex < 0 Then
            lblStatus.Text = "You must select an ammunition"
            Return
        Else
            ammoID = lstAmmo.SelectedIndex
        End If

        'checks for gun type
        If radPistol.Checked Then
            Type = "Pistol"
        ElseIf (radRifle.Checked) Then
            Type = "Rifle"
        Else
            Type = "Shot Gun"
        End If

        'create a new gun object
        Gun = New Gun(make, model, serialNum, type, purchased, ammoID)
        gunList.Add(Gun)


        lblStatus.Text = "Your gun was added"
    End Sub

    Private Sub frmGun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set the data source of the list box to the database of ammo
    End Sub
End Class