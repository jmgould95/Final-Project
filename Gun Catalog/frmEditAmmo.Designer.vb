<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditAmmo
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtGrain = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnUpdateAmmo = New System.Windows.Forms.Button()
        Me.BulletType = New System.Windows.Forms.GroupBox()
        Me.radShotgun = New System.Windows.Forms.RadioButton()
        Me.radFMJ = New System.Windows.Forms.RadioButton()
        Me.radHollowPoint = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDatePurchased = New System.Windows.Forms.DateTimePicker()
        Me.txtCaliber = New System.Windows.Forms.TextBox()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.BulletType.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 434)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(458, 22)
        Me.StatusStrip1.TabIndex = 33
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'txtGrain
        '
        Me.txtGrain.Location = New System.Drawing.Point(144, 147)
        Me.txtGrain.Name = "txtGrain"
        Me.txtGrain.Size = New System.Drawing.Size(100, 22)
        Me.txtGrain.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Grain"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(144, 189)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 22)
        Me.txtQuantity.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Quantity"
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(242, 401)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(94, 23)
        Me.btnReturn.TabIndex = 28
        Me.btnReturn.Text = "Exit Form"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnUpdateAmmo
        '
        Me.btnUpdateAmmo.Location = New System.Drawing.Point(116, 401)
        Me.btnUpdateAmmo.Name = "btnUpdateAmmo"
        Me.btnUpdateAmmo.Size = New System.Drawing.Size(104, 23)
        Me.btnUpdateAmmo.TabIndex = 27
        Me.btnUpdateAmmo.Text = "Update Ammo"
        Me.btnUpdateAmmo.UseVisualStyleBackColor = True
        '
        'BulletType
        '
        Me.BulletType.Controls.Add(Me.radShotgun)
        Me.BulletType.Controls.Add(Me.radFMJ)
        Me.BulletType.Controls.Add(Me.radHollowPoint)
        Me.BulletType.Location = New System.Drawing.Point(80, 285)
        Me.BulletType.Name = "BulletType"
        Me.BulletType.Size = New System.Drawing.Size(349, 100)
        Me.BulletType.TabIndex = 26
        Me.BulletType.TabStop = False
        Me.BulletType.Text = "Bullet Type"
        '
        'radShotgun
        '
        Me.radShotgun.AutoSize = True
        Me.radShotgun.Location = New System.Drawing.Point(146, 52)
        Me.radShotgun.Name = "radShotgun"
        Me.radShotgun.Size = New System.Drawing.Size(82, 21)
        Me.radShotgun.TabIndex = 2
        Me.radShotgun.Text = "Shotgun"
        Me.radShotgun.UseVisualStyleBackColor = True
        '
        'radFMJ
        '
        Me.radFMJ.AutoSize = True
        Me.radFMJ.Checked = True
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
        Me.radHollowPoint.Text = "Hollow Point"
        Me.radHollowPoint.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Date Purchased"
        '
        'dtpDatePurchased
        '
        Me.dtpDatePurchased.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatePurchased.Location = New System.Drawing.Point(190, 238)
        Me.dtpDatePurchased.Name = "dtpDatePurchased"
        Me.dtpDatePurchased.Size = New System.Drawing.Size(105, 22)
        Me.dtpDatePurchased.TabIndex = 24
        '
        'txtCaliber
        '
        Me.txtCaliber.Location = New System.Drawing.Point(144, 108)
        Me.txtCaliber.Name = "txtCaliber"
        Me.txtCaliber.Size = New System.Drawing.Size(100, 22)
        Me.txtCaliber.TabIndex = 23
        '
        'txtBrand
        '
        Me.txtBrand.Location = New System.Drawing.Point(144, 70)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Size = New System.Drawing.Size(100, 22)
        Me.txtBrand.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Caliber"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Brand"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(144, 33)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 22)
        Me.txtId.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 17)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Current Gun ID"
        '
        'frmEditAmmo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 456)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtGrain)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnUpdateAmmo)
        Me.Controls.Add(Me.BulletType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpDatePurchased)
        Me.Controls.Add(Me.txtCaliber)
        Me.Controls.Add(Me.txtBrand)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEditAmmo"
        Me.Text = "frmEditAmmo"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.BulletType.ResumeLayout(False)
        Me.BulletType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents txtGrain As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnUpdateAmmo As Button
    Friend WithEvents BulletType As GroupBox
    Friend WithEvents radShotgun As RadioButton
    Friend WithEvents radFMJ As RadioButton
    Friend WithEvents radHollowPoint As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDatePurchased As DateTimePicker
    Friend WithEvents txtCaliber As TextBox
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label6 As Label
End Class
