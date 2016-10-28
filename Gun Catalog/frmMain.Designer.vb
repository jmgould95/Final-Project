<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnViewInventory = New System.Windows.Forms.Button()
        Me.btnAddAmmo = New System.Windows.Forms.Button()
        Me.btnAddGun = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnViewInventory
        '
        Me.btnViewInventory.Location = New System.Drawing.Point(117, 213)
        Me.btnViewInventory.Name = "btnViewInventory"
        Me.btnViewInventory.Size = New System.Drawing.Size(125, 31)
        Me.btnViewInventory.TabIndex = 0
        Me.btnViewInventory.Text = "View Inventory"
        Me.btnViewInventory.UseVisualStyleBackColor = True
        '
        'btnAddAmmo
        '
        Me.btnAddAmmo.Location = New System.Drawing.Point(227, 114)
        Me.btnAddAmmo.Name = "btnAddAmmo"
        Me.btnAddAmmo.Size = New System.Drawing.Size(97, 23)
        Me.btnAddAmmo.TabIndex = 1
        Me.btnAddAmmo.Text = "Add Ammo"
        Me.btnAddAmmo.UseVisualStyleBackColor = True
        '
        'btnAddGun
        '
        Me.btnAddGun.Location = New System.Drawing.Point(47, 114)
        Me.btnAddGun.Name = "btnAddGun"
        Me.btnAddGun.Size = New System.Drawing.Size(94, 23)
        Me.btnAddGun.TabIndex = 2
        Me.btnAddGun.Text = "Add Gun"
        Me.btnAddGun.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Gould Gun Catalog"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 320)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddGun)
        Me.Controls.Add(Me.btnAddAmmo)
        Me.Controls.Add(Me.btnViewInventory)
        Me.Name = "frmMain"
        Me.Text = "Gould Gun Catalog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnViewInventory As Button
    Friend WithEvents btnAddAmmo As Button
    Friend WithEvents btnAddGun As Button
    Friend WithEvents Label1 As Label
End Class
