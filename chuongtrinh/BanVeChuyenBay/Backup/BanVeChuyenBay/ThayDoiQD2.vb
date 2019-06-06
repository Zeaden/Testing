Public Class ThayDoiQD2
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents bThoat As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgDonGiaVe As System.Windows.Forms.DataGrid
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ThayDoiQD2))
        Me.bThoat = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.dgDonGiaVe = New System.Windows.Forms.DataGrid
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        CType(Me.dgDonGiaVe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bThoat
        '
        Me.bThoat.Location = New System.Drawing.Point(280, 272)
        Me.bThoat.Name = "bThoat"
        Me.bThoat.Size = New System.Drawing.Size(75, 32)
        Me.bThoat.TabIndex = 17
        Me.bThoat.Text = "Thoát"
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.Color.Blue
        Me.TextBox1.Location = New System.Drawing.Point(248, 80)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(112, 26)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(72, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Số Lượng Các Hạng Vé"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(112, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(280, 23)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "QUY ĐỊNH HẠNG VÉ_ĐƠN GIÁ VÉ"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(112, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Cập nhật"
        '
        'dgDonGiaVe
        '
        Me.dgDonGiaVe.BackColor = System.Drawing.SystemColors.Info
        Me.dgDonGiaVe.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.dgDonGiaVe.CaptionBackColor = System.Drawing.Color.Orchid
        Me.dgDonGiaVe.CaptionText = "Bảng Đơn Giá Vé"
        Me.dgDonGiaVe.DataMember = ""
        Me.dgDonGiaVe.ForeColor = System.Drawing.Color.Blue
        Me.dgDonGiaVe.GridLineColor = System.Drawing.Color.Orchid
        Me.dgDonGiaVe.HeaderBackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.dgDonGiaVe.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgDonGiaVe.Location = New System.Drawing.Point(48, 128)
        Me.dgDonGiaVe.Name = "dgDonGiaVe"
        Me.dgDonGiaVe.Size = New System.Drawing.Size(336, 128)
        Me.dgDonGiaVe.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(80, 272)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(248, 272)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 32
        Me.PictureBox3.TabStop = False
        '
        'ThayDoiQD2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 19)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.ClientSize = New System.Drawing.Size(400, 318)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgDonGiaVe)
        Me.Controls.Add(Me.bThoat)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Name = "ThayDoiQD2"
        Me.Text = "ThayDoiQD2"
        CType(Me.dgDonGiaVe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ThayDoiQD2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ts As New CThamSo
        Dim ds As DataSet
        ds = ts.LayBangDonGia()
        dgDonGiaVe.DataSource = ds.Tables(0)
    End Sub

    Private Sub bThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bThoat.Click
        Me.Close()
    End Sub
End Class
