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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.rad38 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.rad22 = New System.Windows.Forms.RadioButton()
        Me.rad9 = New System.Windows.Forms.RadioButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.radPistol = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.btnAddGun = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.txtBrand.Size = New System.Drawing.Size(100, 22)
        Me.txtBrand.TabIndex = 2
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(82, 45)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(100, 22)
        Me.txtModel.TabIndex = 3
        '
        'dtpDatePurchased
        '
        Me.dtpDatePurchased.Location = New System.Drawing.Point(128, 87)
        Me.dtpDatePurchased.Name = "dtpDatePurchased"
        Me.dtpDatePurchased.Size = New System.Drawing.Size(200, 22)
        Me.dtpDatePurchased.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Date Purchased"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton8)
        Me.GroupBox1.Controls.Add(Me.RadioButton7)
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.rad38)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.rad22)
        Me.GroupBox1.Controls.Add(Me.rad9)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 193)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Caliber"
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(105, 76)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(89, 21)
        Me.RadioButton8.TabIndex = 7
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "20 guage"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(10, 73)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(89, 21)
        Me.RadioButton7.TabIndex = 6
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "12 guage"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(113, 49)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(49, 21)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = ".50"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(61, 48)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(49, 21)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = ".45"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'rad38
        '
        Me.rad38.AutoSize = True
        Me.rad38.Location = New System.Drawing.Point(108, 21)
        Me.rad38.Name = "rad38"
        Me.rad38.Size = New System.Drawing.Size(49, 21)
        Me.rad38.TabIndex = 3
        Me.rad38.TabStop = True
        Me.rad38.Text = ".38"
        Me.rad38.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 48)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(49, 21)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = ".40"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'rad22
        '
        Me.rad22.AutoSize = True
        Me.rad22.Location = New System.Drawing.Point(6, 21)
        Me.rad22.Name = "rad22"
        Me.rad22.Size = New System.Drawing.Size(49, 21)
        Me.rad22.TabIndex = 1
        Me.rad22.TabStop = True
        Me.rad22.Text = ".22"
        Me.rad22.UseVisualStyleBackColor = True
        '
        'rad9
        '
        Me.rad9.AutoSize = True
        Me.rad9.Location = New System.Drawing.Point(61, 21)
        Me.rad9.Name = "rad9"
        Me.rad9.Size = New System.Drawing.Size(41, 21)
        Me.rad9.TabIndex = 0
        Me.rad9.TabStop = True
        Me.rad9.Text = ".9"
        Me.rad9.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 309)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(598, 22)
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
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.radPistol)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 72)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Type"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(76, 22)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(57, 21)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Rifle"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'radPistol
        '
        Me.radPistol.AutoSize = True
        Me.radPistol.Location = New System.Drawing.Point(7, 22)
        Me.radPistol.Name = "radPistol"
        Me.radPistol.Size = New System.Drawing.Size(63, 21)
        Me.radPistol.TabIndex = 0
        Me.radPistol.TabStop = True
        Me.radPistol.Text = "Pistol"
        Me.radPistol.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(139, 22)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(89, 21)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Shot Gun"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'btnAddGun
        '
        Me.btnAddGun.Location = New System.Drawing.Point(298, 264)
        Me.btnAddGun.Name = "btnAddGun"
        Me.btnAddGun.Size = New System.Drawing.Size(94, 23)
        Me.btnAddGun.TabIndex = 9
        Me.btnAddGun.Text = "Add Gun"
        Me.btnAddGun.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(423, 264)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(94, 23)
        Me.btnReturn.TabIndex = 10
        Me.btnReturn.Text = "Exit Form"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'frmGun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 331)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnAddGun)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpDatePurchased)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtBrand)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmGun"
        Me.Text = "frmGun"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents dtpDatePurchased As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents rad38 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents rad22 As RadioButton
    Friend WithEvents rad9 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents radPistol As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents btnAddGun As Button
    Friend WithEvents btnReturn As Button
End Class
