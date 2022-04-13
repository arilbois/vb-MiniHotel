<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.kamar = New System.Windows.Forms.ComboBox()
        Me.lama = New System.Windows.Forms.TextBox()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.Biaya = New System.Windows.Forms.TextBox()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.kembali = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'kamar
        '
        Me.kamar.FormattingEnabled = True
        Me.kamar.Items.AddRange(New Object() {"VIP", "Kelas I", "Kelas II", "Kelas III"})
        Me.kamar.Location = New System.Drawing.Point(316, 41)
        Me.kamar.Name = "kamar"
        Me.kamar.Size = New System.Drawing.Size(121, 21)
        Me.kamar.TabIndex = 0
        '
        'lama
        '
        Me.lama.Location = New System.Drawing.Point(316, 80)
        Me.lama.Name = "lama"
        Me.lama.Size = New System.Drawing.Size(121, 20)
        Me.lama.TabIndex = 1
        '
        'harga
        '
        Me.harga.Location = New System.Drawing.Point(316, 119)
        Me.harga.Name = "harga"
        Me.harga.ReadOnly = True
        Me.harga.Size = New System.Drawing.Size(121, 20)
        Me.harga.TabIndex = 2
        '
        'Biaya
        '
        Me.Biaya.Location = New System.Drawing.Point(316, 160)
        Me.Biaya.Name = "Biaya"
        Me.Biaya.ReadOnly = True
        Me.Biaya.Size = New System.Drawing.Size(121, 20)
        Me.Biaya.TabIndex = 3
        '
        'jumlah
        '
        Me.jumlah.Location = New System.Drawing.Point(316, 208)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(121, 20)
        Me.jumlah.TabIndex = 4
        '
        'kembali
        '
        Me.kembali.Location = New System.Drawing.Point(315, 248)
        Me.kembali.Name = "kembali"
        Me.kembali.ReadOnly = True
        Me.kembali.Size = New System.Drawing.Size(121, 20)
        Me.kembali.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(225, 314)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(342, 314)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(221, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Jenis Kamar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Lama Menginap"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Harga Sewa Perhari"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(211, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Biaya Sewa Kamar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Jumlah Bayar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(214, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Kembali"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.kembali)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.Biaya)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.lama)
        Me.Controls.Add(Me.kamar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents kamar As ComboBox
    Friend WithEvents lama As TextBox
    Friend WithEvents harga As TextBox
    Friend WithEvents Biaya As TextBox
    Friend WithEvents jumlah As TextBox
    Friend WithEvents kembali As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
