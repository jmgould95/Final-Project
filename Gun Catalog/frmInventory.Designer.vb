<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.btnViewAmmo = New System.Windows.Forms.Button()
        Me.btnViewGuns = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvInventory
        '
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Location = New System.Drawing.Point(12, 12)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.RowTemplate.Height = 24
        Me.dgvInventory.Size = New System.Drawing.Size(685, 292)
        Me.dgvInventory.TabIndex = 0
        '
        'btnViewAmmo
        '
        Me.btnViewAmmo.Location = New System.Drawing.Point(180, 336)
        Me.btnViewAmmo.Name = "btnViewAmmo"
        Me.btnViewAmmo.Size = New System.Drawing.Size(91, 23)
        Me.btnViewAmmo.TabIndex = 1
        Me.btnViewAmmo.Text = "View Ammo"
        Me.btnViewAmmo.UseVisualStyleBackColor = True
        '
        'btnViewGuns
        '
        Me.btnViewGuns.Location = New System.Drawing.Point(309, 336)
        Me.btnViewGuns.Name = "btnViewGuns"
        Me.btnViewGuns.Size = New System.Drawing.Size(97, 23)
        Me.btnViewGuns.TabIndex = 2
        Me.btnViewGuns.Text = "View Guns"
        Me.btnViewGuns.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(447, 336)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Edit Inventory"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(565, 336)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 380)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnViewGuns)
        Me.Controls.Add(Me.btnViewAmmo)
        Me.Controls.Add(Me.dgvInventory)
        Me.Name = "frmInventory"
        Me.Text = "frmInventory"
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents btnViewAmmo As Button
    Friend WithEvents btnViewGuns As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnExit As Button
End Class
