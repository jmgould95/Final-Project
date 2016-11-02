Public Class frmGun
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub btnAmmunition_Click(sender As Object, e As EventArgs) Handles btnAmmunition.Click
        frmAmmo.ShowDialog()
    End Sub

    Private Sub btnAddGun_Click(sender As Object, e As EventArgs) Handles btnAddGun.Click
        If txtBrand.Text.Trim() = "" Then
            lblStatus.Text = "You must input a brand"
            txtBrand.Focus()
            Return
        End If
        If txtModel.Text.Trim() = "" Then
            lblStatus.Text = "You must input a Model"
            txtModel.Focus()
            Return
        End If
        If lstAmmo.SelectedIndex < 0 Then
            lblStatus.Text = "You must select an ammunition"
            Return
        End If

        lblStatus.Text = "Your gun was added"
    End Sub
End Class