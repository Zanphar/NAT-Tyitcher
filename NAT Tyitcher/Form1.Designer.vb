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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TheEmpireThemeContainer1 = New NAT_Tyitcher.TheEmpireThemeContainer()
        Me.drpSetting = New NAT_Tyitcher.TheEmpireDropdownButton()
        Me.btnReset = New NAT_Tyitcher.TheEmpireButton()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btnStatus = New NAT_Tyitcher.TheEmpireButton()
        Me.txtCpyR = New NAT_Tyitcher.TheEmpireStatusLabel()
        Me.TheEmpireStatusLabel4 = New NAT_Tyitcher.TheEmpireStatusLabel()
        Me.chkReset = New NAT_Tyitcher.TheEmpireCheckbox()
        Me.btnConfig = New NAT_Tyitcher.TheEmpireButton()
        Me.btnClose = New NAT_Tyitcher.TheEmpireButton()
        Me.TheEmpireGroupBox1 = New NAT_Tyitcher.TheEmpireGroupBox()
        Me.Textbox = New NAT_Tyitcher.TheEmpireTextBox()
        Me.TheEmpireButton1 = New NAT_Tyitcher.TheEmpireButton()
        Me.TheEmpireThemeContainer1.SuspendLayout()
        Me.TheEmpireGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TheEmpireThemeContainer1
        '
        Me.TheEmpireThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TheEmpireThemeContainer1.Controls.Add(Me.TheEmpireButton1)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.drpSetting)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.btnReset)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.RichTextBox1)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.btnStatus)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.txtCpyR)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.TheEmpireStatusLabel4)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.chkReset)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.btnConfig)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.btnClose)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.TheEmpireGroupBox1)
        Me.TheEmpireThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TheEmpireThemeContainer1.ForeColor = System.Drawing.Color.White
        Me.TheEmpireThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.TheEmpireThemeContainer1.Name = "TheEmpireThemeContainer1"
        Me.TheEmpireThemeContainer1.Size = New System.Drawing.Size(809, 503)
        Me.TheEmpireThemeContainer1.TabIndex = 0
        Me.TheEmpireThemeContainer1.Text = "NAT Tyitcher"
        '
        'drpSetting
        '
        Me.drpSetting.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.drpSetting.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.drpSetting.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.drpSetting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpSetting.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.drpSetting.ForeColor = System.Drawing.Color.White
        Me.drpSetting.FormattingEnabled = True
        Me.drpSetting.ItemHeight = 23
        Me.drpSetting.Items.AddRange(New Object() {"Client #: 1", "Client #: 2", "Client #: 3", "Client #: 4", "Client #: 5", "Enterprise #: 1", "Enterprise #: 2", "Enterprise #: 3", "Enterprise #: 4", "Enterprise #: 5", "EnterpriseClient #: 1", "EnterpriseClient #: 2", "EnterpriseClient #: 3", "EnterpriseClient #: 4", "EnterpriseClient #: 5", "NATAwareClient #: 1", "NATAwareClient #: 2", "NATAwareClient #: 3", "NATAwareClient #: 4", "NATAwareClient #: 5"})
        Me.drpSetting.Location = New System.Drawing.Point(641, 340)
        Me.drpSetting.Name = "drpSetting"
        Me.drpSetting.Size = New System.Drawing.Size(156, 29)
        Me.drpSetting.Sorted = True
        Me.drpSetting.TabIndex = 20
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.BackColor = System.Drawing.Color.Transparent
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReset.Image = Nothing
        Me.btnReset.ImageAlignment = NAT_Tyitcher.TheEmpireButton.ImageAlignments.Left
        Me.btnReset.Location = New System.Drawing.Point(641, 460)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 31)
        Me.btnReset.TabIndex = 19
        Me.btnReset.Text = "Reset"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(520, 76)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(277, 240)
        Me.RichTextBox1.TabIndex = 18
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'btnStatus
        '
        Me.btnStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStatus.BackColor = System.Drawing.Color.Transparent
        Me.btnStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnStatus.Image = Nothing
        Me.btnStatus.ImageAlignment = NAT_Tyitcher.TheEmpireButton.ImageAlignments.Left
        Me.btnStatus.Location = New System.Drawing.Point(523, 375)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(75, 31)
        Me.btnStatus.TabIndex = 17
        Me.btnStatus.Text = "Status"
        '
        'txtCpyR
        '
        Me.txtCpyR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCpyR.AutoSize = True
        Me.txtCpyR.BackColor = System.Drawing.Color.Transparent
        Me.txtCpyR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCpyR.ForeColor = System.Drawing.Color.White
        Me.txtCpyR.Location = New System.Drawing.Point(493, 9)
        Me.txtCpyR.Name = "txtCpyR"
        Me.txtCpyR.Size = New System.Drawing.Size(304, 15)
        Me.txtCpyR.TabIndex = 16
        Me.txtCpyR.Text = "Copyright © 2022 Charles McDonald. All rights reserved."
        '
        'TheEmpireStatusLabel4
        '
        Me.TheEmpireStatusLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TheEmpireStatusLabel4.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireStatusLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TheEmpireStatusLabel4.ForeColor = System.Drawing.Color.White
        Me.TheEmpireStatusLabel4.Location = New System.Drawing.Point(520, 340)
        Me.TheEmpireStatusLabel4.Name = "TheEmpireStatusLabel4"
        Me.TheEmpireStatusLabel4.Size = New System.Drawing.Size(104, 23)
        Me.TheEmpireStatusLabel4.TabIndex = 15
        Me.TheEmpireStatusLabel4.Text = "Server:"
        '
        'chkReset
        '
        Me.chkReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkReset.BackColor = System.Drawing.Color.Transparent
        Me.chkReset.Checked = False
        Me.chkReset.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReset.ForeColor = System.Drawing.Color.Black
        Me.chkReset.Location = New System.Drawing.Point(523, 460)
        Me.chkReset.Name = "chkReset"
        Me.chkReset.Size = New System.Drawing.Size(112, 31)
        Me.chkReset.SliderLocation = NAT_Tyitcher.TheEmpireCheckbox.SliderLocations.Right
        Me.chkReset.TabIndex = 3
        Me.chkReset.Text = "Restore Settings"
        '
        'btnConfig
        '
        Me.btnConfig.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfig.BackColor = System.Drawing.Color.Transparent
        Me.btnConfig.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnConfig.Image = Nothing
        Me.btnConfig.ImageAlignment = NAT_Tyitcher.TheEmpireButton.ImageAlignments.Left
        Me.btnConfig.Location = New System.Drawing.Point(722, 375)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(75, 31)
        Me.btnConfig.TabIndex = 1
        Me.btnConfig.Text = "Configure"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.Image = Nothing
        Me.btnClose.ImageAlignment = NAT_Tyitcher.TheEmpireButton.ImageAlignments.Left
        Me.btnClose.Location = New System.Drawing.Point(722, 460)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 31)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        '
        'TheEmpireGroupBox1
        '
        Me.TheEmpireGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireGroupBox1.Controls.Add(Me.Textbox)
        Me.TheEmpireGroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TheEmpireGroupBox1.ForeColor = System.Drawing.Color.Black
        Me.TheEmpireGroupBox1.Location = New System.Drawing.Point(15, 51)
        Me.TheEmpireGroupBox1.Name = "TheEmpireGroupBox1"
        Me.TheEmpireGroupBox1.Size = New System.Drawing.Size(499, 440)
        Me.TheEmpireGroupBox1.TabIndex = 21
        Me.TheEmpireGroupBox1.Text = "Status"
        '
        'Textbox
        '
        Me.Textbox.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.Textbox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Textbox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Textbox.Location = New System.Drawing.Point(3, 25)
        Me.Textbox.MaxLength = 32767
        Me.Textbox.Multiline = True
        Me.Textbox.Name = "Textbox"
        Me.Textbox.ReadOnly = True
        Me.Textbox.SelectionLength = 0
        Me.Textbox.SelectionStart = 0
        Me.Textbox.Size = New System.Drawing.Size(493, 412)
        Me.Textbox.TabIndex = 2
        Me.Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Textbox.UseSystemPasswordChar = False
        '
        'TheEmpireButton1
        '
        Me.TheEmpireButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TheEmpireButton1.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TheEmpireButton1.Image = Nothing
        Me.TheEmpireButton1.ImageAlignment = NAT_Tyitcher.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton1.Location = New System.Drawing.Point(722, 412)
        Me.TheEmpireButton1.Name = "TheEmpireButton1"
        Me.TheEmpireButton1.Size = New System.Drawing.Size(75, 31)
        Me.TheEmpireButton1.TabIndex = 22
        Me.TheEmpireButton1.Text = "TweakTCP"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(809, 503)
        Me.Controls.Add(Me.TheEmpireThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NAT Tyitcher"
        Me.TheEmpireThemeContainer1.ResumeLayout(False)
        Me.TheEmpireThemeContainer1.PerformLayout()
        Me.TheEmpireGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TheEmpireThemeContainer1 As TheEmpireThemeContainer
    Friend WithEvents btnClose As TheEmpireButton
    Friend WithEvents btnConfig As TheEmpireButton
    Friend WithEvents Textbox As TheEmpireTextBox
    Friend WithEvents chkReset As TheEmpireCheckbox
    Friend WithEvents TheEmpireStatusLabel4 As TheEmpireStatusLabel
    Friend WithEvents txtCpyR As TheEmpireStatusLabel
    Friend WithEvents btnStatus As TheEmpireButton
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents btnReset As TheEmpireButton
    Friend WithEvents drpSetting As TheEmpireDropdownButton
    Friend WithEvents TheEmpireGroupBox1 As TheEmpireGroupBox
    Friend WithEvents TheEmpireButton1 As TheEmpireButton
End Class
