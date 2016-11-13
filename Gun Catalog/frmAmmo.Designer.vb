<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAmmo
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDatePurchased = New System.Windows.Forms.DateTimePicker()
        Me.txtCaliber = New System.Windows.Forms.TextBox()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BulletType = New System.Windows.Forms.GroupBox()
        Me.radFMJ = New System.Windows.Forms.RadioButton()
        Me.radHollowPoint = New System.Windows.Forms.RadioButton()
        Me.btnAddAmmo = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGrain = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.radShotgun = New System.Windows.Forms.RadioButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BulletType.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Date Purchased"
        '
        'dtpDatePurchased
        '
        Me.dtpDatePurchased.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatePurchased.Location = New System.Drawing.Point(122, 180)
        Me.dtpDatePurchased.Name = "dtpDatePurchased"
        Me.dtpDatePurchased.Size = New System.Drawing.Size(90, 22)
        Me.dtpDatePurchased.TabIndex = 10
        '
        'txtCaliber
        '
        Me.txtCaliber.Location = New System.Drawing.Point(76, 50)
        Me.txtCaliber.Name = "txtCaliber"
        Me.txtCaliber.Size = New System.Drawing.Size(100, 22)
        Me.txtCaliber.TabIndex = 9
        '
        'txtBrand
        '
        Me.txtBrand.Location = New System.Drawing.Point(76, 12)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Size = New System.Drawing.Size(100, 22)
        Me.txtBrand.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Caliber"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Brand"
        '
        'BulletType
        '
        Me.BulletType.Controls.Add(Me.radShotgun)
        Me.BulletType.Controls.Add(Me.radFMJ)
        Me.BulletType.Controls.Add(Me.radHollowPoint)
        Me.BulletType.Location = New System.Drawing.Point(12, 227)
        Me.BulletType.Name = "BulletType"
        Me.BulletType.Size = New System.Drawing.Size(349, 100)
        Me.BulletType.TabIndex = 12
        Me.BulletType.TabStop = False
        Me.BulletType.Text = "Bullet Type"
        '
        'radFMJ
        '
        Me.radFMJ.AutoSize = True
        Me.radFMJ.Location = New System.Drawing.Point(6, 30)
        Me.radFMJ.Name = "radFMJ"
        Me.radFMJ.Size = New System.Drawing.Size(134, 21)
        Me.radFMJ.TabIndex = 1
        Me.radFMJ.TabStop = True
        Me.radFMJ.Text = "Full Metal Jacket"
        Me.radFMJ.UseVisualStyleBackColor = True
        '
        'radHollowPoint
        '
        Me.radHollowPoint.AutoSize = True
        Me.radHollowPoint.Location = New System.Drawing.Point(6, 73)
        Me.radHollowPoint.Name = "radHollowPoint"
        Me.radHollowPoint.Size = New System.Drawing.Size(106, 21)
        Me.radHollowPoint.TabIndex = 0
        Me.radHollowPoint.TabStop = True
        Me.radHollowPoint.Text = "Hollow Point"
        Me.radHollowPoint.UseVisualStyleBackColor = True
        '
        'btnAddAmmo
        '
        Me.btnAddAmmo.Location = New System.Drawing.Point(48, 343)
        Me.btnAddAmmo.Name = "btnAddAmmo"
        Me.btnAddAmmo.Size = New System.Drawing.Size(104, 23)
        Me.btnAddAmmo.TabIndex = 13
        Me.btnAddAmmo.Text = "Add Ammo"
        Me.btnAddAmmo.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(174, 343)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(94, 23)
        Me.btnReturn.TabIndex = 14
        Me.btnReturn.Text = "Exit Form"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(76, 131)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 22)
        Me.txtQuantity.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Quantity"
        '
        'txtGrain
        '
        Me.txtGrain.Location = New System.Drawing.Point(76, 89)
        Me.txtGrain.Name = "txtGrain"
        Me.txtGrain.Size = New System.Drawing.Size(100, 22)
        Me.txtGrain.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Grain"
        '
        'radShotgun
        '
        Me.radShotgun.AutoSize = True
        Me.radShotgun.Location = New System.Drawing.Point(146, 52)
        Me.radShotgun.Name = "radShotgun"
        Me.radShotgun.Size = New System.Drawing.Size(82, 21)
        Me.radShotgun.TabIndex = 2
        Me.radShotgun.TabStop = True
        Me.radShotgun.Text = "Shotgun"
        Me.radShotgun.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 387)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(424, 22)
        Me.StatusStrip1.TabIndex = 19
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'frmAmmo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 409)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtGrain)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnAddAmmo)
        Me.Controls.Add(Me.BulletType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpDatePurchased)
        Me.Controls.Add(Me.txtCaliber)
        Me.Controls.Add(Me.txtBrand)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAmmo"
        Me.Text = "frmAmmo"
        Me.BulletType.ResumeLayout(False)
        Me.BulletType.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDatePurchased As DateTimePicker
    Friend WithEvents txtCaliber As TextBox
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BulletType As GroupBox
    Friend WithEvents radFMJ As RadioButton
    Friend WithEvents radHollowPoint As RadioButton
    Friend WithEvents btnAddAmmo As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGrain As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents radShotgun As RadioButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
End Class
