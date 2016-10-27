Public Class frmGun
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub btnAmmunition_Click(sender As Object, e As EventArgs) Handles btnAmmunition.Click
        frmAmmo.ShowDialog()
    End Sub
End Class