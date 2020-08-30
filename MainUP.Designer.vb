<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainUP
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainUP))
        Me.lbl_tip = New System.Windows.Forms.Label()
        Me.lbl_url = New System.Windows.Forms.Label()
        Me.link_url = New System.Windows.Forms.LinkLabel()
        Me.txt_log = New System.Windows.Forms.TextBox()
        Me.downloadButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.progressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_tip
        '
        Me.lbl_tip.AutoSize = True
        Me.lbl_tip.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tip.Location = New System.Drawing.Point(16, 68)
        Me.lbl_tip.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_tip.Name = "lbl_tip"
        Me.lbl_tip.Size = New System.Drawing.Size(82, 15)
        Me.lbl_tip.TabIndex = 0
        Me.lbl_tip.Text = "检测新版本"
        '
        'lbl_url
        '
        Me.lbl_url.AutoSize = True
        Me.lbl_url.Location = New System.Drawing.Point(16, 271)
        Me.lbl_url.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_url.Name = "lbl_url"
        Me.lbl_url.Size = New System.Drawing.Size(82, 15)
        Me.lbl_url.TabIndex = 1
        Me.lbl_url.Text = "下载地址："
        '
        'link_url
        '
        Me.link_url.AutoSize = True
        Me.link_url.Location = New System.Drawing.Point(99, 271)
        Me.link_url.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.link_url.Name = "link_url"
        Me.link_url.Size = New System.Drawing.Size(112, 15)
        Me.link_url.TabIndex = 3
        Me.link_url.TabStop = True
        Me.link_url.Text = "点击下载完整版"
        '
        'txt_log
        '
        Me.txt_log.BackColor = System.Drawing.SystemColors.Window
        Me.txt_log.Enabled = False
        Me.txt_log.Location = New System.Drawing.Point(19, 91)
        Me.txt_log.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_log.Multiline = True
        Me.txt_log.Name = "txt_log"
        Me.txt_log.ReadOnly = True
        Me.txt_log.ShortcutsEnabled = False
        Me.txt_log.Size = New System.Drawing.Size(421, 149)
        Me.txt_log.TabIndex = 4
        Me.txt_log.Text = "正在获取最新版本，请稍候..."
        '
        'downloadButton
        '
        Me.downloadButton.Location = New System.Drawing.Point(289, 265)
        Me.downloadButton.Margin = New System.Windows.Forms.Padding(4)
        Me.downloadButton.Name = "downloadButton"
        Me.downloadButton.Size = New System.Drawing.Size(73, 28)
        Me.downloadButton.TabIndex = 5
        Me.downloadButton.Text = "升级"
        Me.downloadButton.UseVisualStyleBackColor = True
        '
        'closeButton
        '
        Me.closeButton.Location = New System.Drawing.Point(371, 265)
        Me.closeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(71, 28)
        Me.closeButton.TabIndex = 6
        Me.closeButton.Text = "关闭"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'progressBar1
        '
        Me.progressBar1.Location = New System.Drawing.Point(19, 249)
        Me.progressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(423, 12)
        Me.progressBar1.TabIndex = 7
        '
        'lbl_title
        '
        Me.lbl_title.AutoEllipsis = True
        Me.lbl_title.Font = New System.Drawing.Font("宋体", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(13, 9)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(431, 48)
        Me.lbl_title.TabIndex = 8
        Me.lbl_title.Text = "Welcom"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 298)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.progressBar1)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.downloadButton)
        Me.Controls.Add(Me.txt_log)
        Me.Controls.Add(Me.link_url)
        Me.Controls.Add(Me.lbl_url)
        Me.Controls.Add(Me.lbl_tip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainUP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "在线升级"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_tip As System.Windows.Forms.Label
    Friend WithEvents lbl_url As System.Windows.Forms.Label
    Friend WithEvents link_url As System.Windows.Forms.LinkLabel
    Friend WithEvents txt_log As System.Windows.Forms.TextBox
    Friend WithEvents downloadButton As System.Windows.Forms.Button
    Friend WithEvents closeButton As System.Windows.Forms.Button
    Friend WithEvents progressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_title As System.Windows.Forms.Label
End Class
