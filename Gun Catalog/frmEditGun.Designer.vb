<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditGun
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
        Me.txtSN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvAmmo = New System.Windows.Forms.DataGridView()
        Me.btnAmmunition = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radShotGun = New System.Windows.Forms.RadioButton()
        Me.radRifle = New System.Windows.Forms.RadioButton()
        Me.radPistol = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDatePurchased = New System.Windows.Forms.DateTimePicker()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvAmmo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSN
        '
        Me.txtSN.Location = New System.Drawing.Point(149, 129)
        Me.txtSN.Name = "txtSN"
        Me.txtSN.Size = New System.Drawing.Size(161, 22)
        Me.txtSN.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Serial #"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.dgvAmmo)
        Me.GroupBox1.Controls.Add(Me.btnAmmunition)
        Me.GroupBox1.Location = New System.Drawing.Point(82, 263)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 268)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Ammunition"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(177, 241)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(105, 23)
        Me.btnRefresh.TabIndex = 15
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dgvAmmo
        '
        Me.dgvAmmo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAmmo.Location = New System.Drawing.Point(7, 21)
        Me.dgvAmmo.Name = "dgvAmmo"
        Me.dgvAmmo.RowTemplate.Height = 24
        Me.dgvAmmo.Size = New System.Drawing.Size(346, 214)
        Me.dgvAmmo.TabIndex = 0
        '
        'btnAmmunition
        '
        Me.btnAmmunition.Location = New System.Drawing.Point(28, 241)
        Me.btnAmmunition.Name = "btnAmmunition"
        Me.btnAmmunition.Size = New System.Drawing.Size(127, 23)
        Me.btnAmmunition.TabIndex = 13
        Me.btnAmmunition.Text = "Add Ammunition"
        Me.btnAmmunition.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(554, 525)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(94, 23)
        Me.btnReturn.TabIndex = 7
        Me.btnReturn.Text = "Exit Form"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(454, 525)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(94, 23)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update Gun"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radShotGun)
        Me.GroupBox2.Controls.Add(Me.radRifle)
        Me.GroupBox2.Controls.Add(Me.radPistol)
        Me.GroupBox2.Location = New System.Drawing.Point(82, 185)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 72)
        Me.GroupBox2.TabIndex = 4
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Date Purchased"
        '
        'dtpDatePurchased
        '
        Me.dtpDatePurchased.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatePurchased.Location = New System.Drawing.Point(195, 157)
        Me.dtpDatePurchased.Name = "dtpDatePurchased"
        Me.dtpDatePurchased.Size = New System.Drawing.Size(115, 22)
        Me.dtpDatePurchased.TabIndex = 3
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(149, 92)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(161, 22)
        Me.txtModel.TabIndex = 1
        '
        'txtBrand
        '
        Me.txtBrand.Location = New System.Drawing.Point(149, 54)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Size = New System.Drawing.Size(161, 22)
        Me.txtBrand.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Model"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Brand"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 577)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(725, 22)
        Me.StatusStrip1.TabIndex = 27
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Current Gun ID"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(149, 20)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(161, 22)
        Me.txtId.TabIndex = 14
        '
        'frmEditGun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 599)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtSN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpDatePurchased)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtBrand)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEditGun"
        Me.Text = "Edit Gun"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvAmmo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgvAmmo As DataGridView
    Friend WithEvents btnAmmunition As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radShotGun As RadioButton
    Friend WithEvents radRifle As RadioButton
    Friend WithEvents radPistol As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDatePurchased As DateTimePicker
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtId As TextBox
End Class
