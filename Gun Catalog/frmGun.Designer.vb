<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGun
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.dtpDatePurchased = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radShotGun = New System.Windows.Forms.RadioButton()
        Me.radRifle = New System.Windows.Forms.RadioButton()
        Me.radPistol = New System.Windows.Forms.RadioButton()
        Me.btnAddGun = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lstAmmo = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAmmunition = New System.Windows.Forms.Button()
        Me.txtSN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Brand"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Model"
        '
        'txtBrand
        '
        Me.txtBrand.Location = New System.Drawing.Point(82, 7)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Size = New System.Drawing.Size(161, 22)
        Me.txtBrand.TabIndex = 2
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(82, 45)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(161, 22)
        Me.txtModel.TabIndex = 3
        '
        'dtpDatePurchased
        '
        Me.dtpDatePurchased.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatePurchased.Location = New System.Drawing.Point(128, 110)
        Me.dtpDatePurchased.Name = "dtpDatePurchased"
        Me.dtpDatePurchased.Size = New System.Drawing.Size(115, 22)
        Me.dtpDatePurchased.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Date Purchased"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 516)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(616, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radShotGun)
        Me.GroupBox2.Controls.Add(Me.radRifle)
        Me.GroupBox2.Controls.Add(Me.radPistol)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 138)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 72)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Type"
        '
        'radShotGun
        '
        Me.radShotGun.AutoSize = True
        Me.radShotGun.Location = New System.Drawing.Point(139, 22)
        Me.radShotGun.Name = "radShotGun"
        Me.radShotGun.Size = New System.Drawing.Size(89, 21)
        Me.radShotGun.TabIndex = 2
        Me.radShotGun.TabStop = True
        Me.radShotGun.Text = "Shot Gun"
        Me.radShotGun.UseVisualStyleBackColor = True
        '
        'radRifle
        '
        Me.radRifle.AutoSize = True
        Me.radRifle.Location = New System.Drawing.Point(76, 22)
        Me.radRifle.Name = "radRifle"
        Me.radRifle.Size = New System.Drawing.Size(57, 21)
        Me.radRifle.TabIndex = 1
        Me.radRifle.TabStop = True
        Me.radRifle.Text = "Rifle"
        Me.radRifle.UseVisualStyleBackColor = True
        '
        'radPistol
        '
        Me.radPistol.AutoSize = True
        Me.radPistol.Checked = True
        Me.radPistol.Location = New System.Drawing.Point(7, 22)
        Me.radPistol.Name = "radPistol"
        Me.radPistol.Size = New System.Drawing.Size(63, 21)
        Me.radPistol.TabIndex = 0
        Me.radPistol.TabStop = True
        Me.radPistol.Text = "Pistol"
        Me.radPistol.UseVisualStyleBackColor = True
        '
        'btnAddGun
        '
        Me.btnAddGun.Location = New System.Drawing.Point(410, 480)
        Me.btnAddGun.Name = "btnAddGun"
        Me.btnAddGun.Size = New System.Drawing.Size(94, 23)
        Me.btnAddGun.TabIndex = 9
        Me.btnAddGun.Text = "Add Gun"
        Me.btnAddGun.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(510, 480)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(94, 23)
        Me.btnReturn.TabIndex = 10
        Me.btnReturn.Text = "Exit Form"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'lstAmmo
        '
        Me.lstAmmo.FormattingEnabled = True
        Me.lstAmmo.ItemHeight = 16
        Me.lstAmmo.Items.AddRange(New Object() {"9MM"})
        Me.lstAmmo.Location = New System.Drawing.Point(7, 29)
        Me.lstAmmo.Name = "lstAmmo"
        Me.lstAmmo.Size = New System.Drawing.Size(356, 196)
        Me.lstAmmo.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAmmunition)
        Me.GroupBox1.Controls.Add(Me.lstAmmo)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 268)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Ammunition"
        '
        'btnAmmunition
        '
        Me.btnAmmunition.Location = New System.Drawing.Point(113, 239)
        Me.btnAmmunition.Name = "btnAmmunition"
        Me.btnAmmunition.Size = New System.Drawing.Size(127, 23)
        Me.btnAmmunition.TabIndex = 13
        Me.btnAmmunition.Text = "Add Ammunition"
        Me.btnAmmunition.UseVisualStyleBackColor = True
        '
        'txtSN
        '
        Me.txtSN.Location = New System.Drawing.Point(82, 82)
        Me.txtSN.Name = "txtSN"
        Me.txtSN.Size = New System.Drawing.Size(161, 22)
        Me.txtSN.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Serial #"
        '
        'frmGun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 538)
        Me.Controls.Add(Me.txtSN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnAddGun)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpDatePurchased)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtBrand)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmGun"
        Me.Text = "frmGun"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents dtpDatePurchased As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radRifle As RadioButton
    Friend WithEvents radPistol As RadioButton
    Friend WithEvents radShotGun As RadioButton
    Friend WithEvents btnAddGun As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents lstAmmo As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAmmunition As Button
    Friend WithEvents txtSN As TextBox
    Friend WithEvents Label4 As Label
End Class
