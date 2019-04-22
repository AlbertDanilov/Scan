<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox4 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.Label()
        Me.SGTIN_TextBox = New System.Windows.Forms.Label()
        Me.SN_TextBox = New System.Windows.Forms.Label()
        Me.GTIN_TextBox = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TimerScan = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Esc_Button = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.TextBox5)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.SGTIN_TextBox)
        Me.Panel2.Controls.Add(Me.SN_TextBox)
        Me.Panel2.Controls.Add(Me.GTIN_TextBox)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(7, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(271, 395)
        Me.Panel2.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.DarkRed
        Me.TextBox4.Location = New System.Drawing.Point(13, 314)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(242, 70)
        Me.TextBox4.TabIndex = 31
        Me.TextBox4.Text = "-"
        Me.TextBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox5
        '
        Me.TextBox5.AutoSize = True
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.DarkRed
        Me.TextBox5.Location = New System.Drawing.Point(13, 271)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(13, 16)
        Me.TextBox5.TabIndex = 30
        Me.TextBox5.Text = "-"
        Me.TextBox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox3
        '
        Me.TextBox3.AutoSize = True
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.MediumBlue
        Me.TextBox3.Location = New System.Drawing.Point(13, 228)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(13, 16)
        Me.TextBox3.TabIndex = 29
        Me.TextBox3.Text = "-"
        Me.TextBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.AutoSize = True
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.MediumBlue
        Me.TextBox2.Location = New System.Drawing.Point(13, 187)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(13, 16)
        Me.TextBox2.TabIndex = 28
        Me.TextBox2.Text = "-"
        Me.TextBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.AutoSize = True
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.MediumBlue
        Me.TextBox1.Location = New System.Drawing.Point(13, 139)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(13, 16)
        Me.TextBox1.TabIndex = 27
        Me.TextBox1.Text = "-"
        Me.TextBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SGTIN_TextBox
        '
        Me.SGTIN_TextBox.AutoSize = True
        Me.SGTIN_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SGTIN_TextBox.ForeColor = System.Drawing.Color.MediumBlue
        Me.SGTIN_TextBox.Location = New System.Drawing.Point(13, 99)
        Me.SGTIN_TextBox.Name = "SGTIN_TextBox"
        Me.SGTIN_TextBox.Size = New System.Drawing.Size(13, 16)
        Me.SGTIN_TextBox.TabIndex = 26
        Me.SGTIN_TextBox.Text = "-"
        Me.SGTIN_TextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SN_TextBox
        '
        Me.SN_TextBox.AutoSize = True
        Me.SN_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SN_TextBox.ForeColor = System.Drawing.Color.MediumBlue
        Me.SN_TextBox.Location = New System.Drawing.Point(13, 63)
        Me.SN_TextBox.Name = "SN_TextBox"
        Me.SN_TextBox.Size = New System.Drawing.Size(13, 16)
        Me.SN_TextBox.TabIndex = 25
        Me.SN_TextBox.Text = "-"
        Me.SN_TextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GTIN_TextBox
        '
        Me.GTIN_TextBox.AutoSize = True
        Me.GTIN_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GTIN_TextBox.ForeColor = System.Drawing.Color.MediumBlue
        Me.GTIN_TextBox.Location = New System.Drawing.Point(13, 19)
        Me.GTIN_TextBox.Name = "GTIN_TextBox"
        Me.GTIN_TextBox.Size = New System.Drawing.Size(13, 16)
        Me.GTIN_TextBox.TabIndex = 24
        Me.GTIN_TextBox.Text = "-"
        Me.GTIN_TextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Подпись:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Ключ:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "ТН ВЭД:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Срок годности:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Серия:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "SGTIN:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Серийный номер:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "GTIN:"
        '
        'TimerScan
        '
        Me.TimerScan.Interval = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Просканируйте упаковку"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Esc_Button
        '
        Me.Esc_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Esc_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Esc_Button.Location = New System.Drawing.Point(95, 424)
        Me.Esc_Button.Name = "Esc_Button"
        Me.Esc_Button.Size = New System.Drawing.Size(30, 19)
        Me.Esc_Button.TabIndex = 5
        Me.Esc_Button.Text = "Esc"
        Me.Esc_Button.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(128, 426)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "-  очистка"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 444)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Esc_Button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ScanTimer As Timer
    Friend WithEvents TimerScan As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox4 As Label
    Friend WithEvents TextBox5 As Label
    Friend WithEvents TextBox3 As Label
    Friend WithEvents TextBox2 As Label
    Friend WithEvents TextBox1 As Label
    Friend WithEvents SGTIN_TextBox As Label
    Friend WithEvents SN_TextBox As Label
    Friend WithEvents GTIN_TextBox As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Esc_Button As Button
    Friend WithEvents Label10 As Label
End Class
