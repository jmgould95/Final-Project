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
        Me.txtType = New System.Windows.Forms.TextBox()
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
        Me.BulletType.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Date Purchased"
        '
        'dtpDatePurchased
        '
        Me.dtpDatePurchased.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatePurchased.Location = New System.Drawing.Point(122, 142)
        Me.dtpDatePurchased.Name = "dtpDatePurchased"
        Me.dtpDatePurchased.Size = New System.Drawing.Size(90, 22)
        Me.dtpDatePurchased.TabIndex = 10
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(76, 50)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(100, 22)
        Me.txtType.TabIndex = 9
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
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Type"
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
        Me.BulletType.Controls.Add(Me.radFMJ)
        Me.BulletType.Controls.Add(Me.radHollowPoint)
        Me.BulletType.Location = New System.Drawing.Point(12, 189)
        Me.BulletType.Name = "BulletType"
        Me.BulletType.Size = New System.Drawing.Size(200, 100)
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
        Me.txtQuantity.Location = New System.Drawing.Point(76, 97)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 22)
        Me.txtQuantity.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Quantity"
        '
        'frmAmmo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 385)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnAddAmmo)
        Me.Controls.Add(Me.BulletType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpDatePurchased)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtBrand)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAmmo"
        Me.Text = "frmAmmo"
        Me.BulletType.ResumeLayout(False)
        Me.BulletType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDatePurchased As DateTimePicker
    Friend WithEvents txtType As TextBox
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
End Class
