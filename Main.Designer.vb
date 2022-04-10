<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.MenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Settings_btn = New System.Windows.Forms.ToolStripMenuItem
        Me.AllProcess_btn = New System.Windows.Forms.Button
        Me.dmp2tmf_btn = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.dmp2tmf_Address = New System.Windows.Forms.Label
        Me.Label2_Address = New System.Windows.Forms.Label
        Me.Label3_Address = New System.Windows.Forms.Label
        Me.Label4_Address = New System.Windows.Forms.Label
        Me.DumpFolder = New System.Windows.Forms.TextBox
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.MenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(434, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "Menu"
        '
        'MenuItem
        '
        Me.MenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Settings_btn})
        Me.MenuItem.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.MenuItem.Name = "MenuItem"
        Me.MenuItem.Size = New System.Drawing.Size(52, 20)
        Me.MenuItem.Text = "メニュー"
        '
        'Settings_btn
        '
        Me.Settings_btn.Name = "Settings_btn"
        Me.Settings_btn.Size = New System.Drawing.Size(152, 22)
        Me.Settings_btn.Text = "設定..."
        '
        'AllProcess_btn
        '
        Me.AllProcess_btn.BackColor = System.Drawing.SystemColors.Highlight
        Me.AllProcess_btn.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.AllProcess_btn.ForeColor = System.Drawing.SystemColors.Window
        Me.AllProcess_btn.Location = New System.Drawing.Point(7, 23)
        Me.AllProcess_btn.Name = "AllProcess_btn"
        Me.AllProcess_btn.Size = New System.Drawing.Size(86, 32)
        Me.AllProcess_btn.TabIndex = 1
        Me.AllProcess_btn.Text = "一括処理"
        Me.AllProcess_btn.UseCompatibleTextRendering = True
        Me.AllProcess_btn.UseVisualStyleBackColor = False
        '
        'dmp2tmf_btn
        '
        Me.dmp2tmf_btn.Location = New System.Drawing.Point(12, 60)
        Me.dmp2tmf_btn.Name = "dmp2tmf_btn"
        Me.dmp2tmf_btn.Size = New System.Drawing.Size(74, 22)
        Me.dmp2tmf_btn.TabIndex = 2
        Me.dmp2tmf_btn.Text = "dmp2tmf"
        Me.dmp2tmf_btn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 22)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 116)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 22)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 144)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(74, 22)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'dmp2tmf_Address
        '
        Me.dmp2tmf_Address.AutoSize = True
        Me.dmp2tmf_Address.Location = New System.Drawing.Point(93, 65)
        Me.dmp2tmf_Address.Name = "dmp2tmf_Address"
        Me.dmp2tmf_Address.Size = New System.Drawing.Size(0, 12)
        Me.dmp2tmf_Address.TabIndex = 6
        '
        'Label2_Address
        '
        Me.Label2_Address.AutoSize = True
        Me.Label2_Address.Location = New System.Drawing.Point(93, 93)
        Me.Label2_Address.Name = "Label2_Address"
        Me.Label2_Address.Size = New System.Drawing.Size(0, 12)
        Me.Label2_Address.TabIndex = 7
        '
        'Label3_Address
        '
        Me.Label3_Address.AutoSize = True
        Me.Label3_Address.Location = New System.Drawing.Point(93, 121)
        Me.Label3_Address.Name = "Label3_Address"
        Me.Label3_Address.Size = New System.Drawing.Size(0, 12)
        Me.Label3_Address.TabIndex = 8
        '
        'Label4_Address
        '
        Me.Label4_Address.AutoSize = True
        Me.Label4_Address.Location = New System.Drawing.Point(93, 149)
        Me.Label4_Address.Name = "Label4_Address"
        Me.Label4_Address.Size = New System.Drawing.Size(0, 12)
        Me.Label4_Address.TabIndex = 9
        '
        'DumpFolder
        '
        Me.DumpFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DumpFolder.Location = New System.Drawing.Point(100, 29)
        Me.DumpFolder.Name = "DumpFolder"
        Me.DumpFolder.Size = New System.Drawing.Size(322, 19)
        Me.DumpFolder.TabIndex = 10
        Me.DumpFolder.Text = "ここにdmpファイルが保存されているフォルダを入力してください"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(434, 175)
        Me.Controls.Add(Me.DumpFolder)
        Me.Controls.Add(Me.Label4_Address)
        Me.Controls.Add(Me.Label3_Address)
        Me.Controls.Add(Me.Label2_Address)
        Me.Controls.Add(Me.dmp2tmf_Address)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dmp2tmf_btn)
        Me.Controls.Add(Me.AllProcess_btn)
        Me.Controls.Add(Me.MenuStrip)
        Me.MinimumSize = New System.Drawing.Size(450, 214)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WE自動まとめソフト"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Settings_btn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllProcess_btn As System.Windows.Forms.Button
    Friend WithEvents dmp2tmf_btn As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents dmp2tmf_Address As System.Windows.Forms.Label
    Friend WithEvents Label2_Address As System.Windows.Forms.Label
    Friend WithEvents Label3_Address As System.Windows.Forms.Label
    Friend WithEvents Label4_Address As System.Windows.Forms.Label
    Friend WithEvents DumpFolder As System.Windows.Forms.TextBox

End Class
