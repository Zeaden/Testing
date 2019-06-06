Public Class QuanLyChuyenBay
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
    Friend WithEvents gridChuyenBay As System.Windows.Forms.DataGrid
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents bCapNhat As System.Windows.Forms.Button
    Friend WithEvents bThoat As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(QuanLyChuyenBay))
        Me.gridChuyenBay = New System.Windows.Forms.DataGrid
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.bCapNhat = New System.Windows.Forms.Button
        Me.bThoat = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.gridChuyenBay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridChuyenBay
        '
        Me.gridChuyenBay.BackColor = System.Drawing.SystemColors.Info
        Me.gridChuyenBay.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.gridChuyenBay.CaptionBackColor = System.Drawing.Color.Orchid
        Me.gridChuyenBay.CaptionText = "Danh sách chuyến bay"
        Me.gridChuyenBay.DataMember = ""
        Me.gridChuyenBay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridChuyenBay.ForeColor = System.Drawing.Color.Blue
        Me.gridChuyenBay.GridLineColor = System.Drawing.Color.Orchid
        Me.gridChuyenBay.HeaderBackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.gridChuyenBay.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.gridChuyenBay.Location = New System.Drawing.Point(24, 80)
        Me.gridChuyenBay.Name = "gridChuyenBay"
        Me.gridChuyenBay.PreferredColumnWidth = 99
        Me.gridChuyenBay.RowHeaderWidth = 40
        Me.gridChuyenBay.Size = New System.Drawing.Size(640, 240)
        Me.gridChuyenBay.TabIndex = 22
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(392, 336)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 43
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(176, 336)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'bCapNhat
        '
        Me.bCapNhat.Enabled = False
        Me.bCapNhat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCapNhat.ForeColor = System.Drawing.Color.Blue
        Me.bCapNhat.Location = New System.Drawing.Point(216, 336)
        Me.bCapNhat.Name = "bCapNhat"
        Me.bCapNhat.Size = New System.Drawing.Size(75, 32)
        Me.bCapNhat.TabIndex = 41
        Me.bCapNhat.Text = "Cập nhật"
        '
        'bThoat
        '
        Me.bThoat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bThoat.ForeColor = System.Drawing.Color.Blue
        Me.bThoat.Location = New System.Drawing.Point(432, 336)
        Me.bThoat.Name = "bThoat"
        Me.bThoat.Size = New System.Drawing.Size(75, 32)
        Me.bThoat.TabIndex = 40
        Me.bThoat.Text = "Thoát"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(104, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(560, 56)
        Me.Label1.TabIndex = 44
        Me.Label1.Tag = ""
        Me.Label1.Text = "QUẢN LÝ CHUYẾN BAY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QuanLyChuyenBay
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 19)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.ClientSize = New System.Drawing.Size(680, 382)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.bCapNhat)
        Me.Controls.Add(Me.bThoat)
        Me.Controls.Add(Me.gridChuyenBay)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "QuanLyChuyenBay"
        Me.Text = "QuanLyChuyenBay"
        CType(Me.gridChuyenBay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub QuanLyChuyenBay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cb As New CChuyenBay
        Dim ds As New DataSet
        ds = cb.LayTDTraCuu(False)
        gridChuyenBay.DataSource = ds.Tables(0)
        cb = Nothing
    End Sub
End Class
