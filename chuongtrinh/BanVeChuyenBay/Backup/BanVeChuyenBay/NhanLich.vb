Imports BanVeChuyenBay.ThemTuyenBay
Imports BanVeChuyenBay.ThemSanBay

Public Class NhanLich
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMaChuyenBay As System.Windows.Forms.TextBox
    Friend WithEvents gridSanBayTrungGian As System.Windows.Forms.DataGrid
    Friend WithEvents DsSanBayTrungGian1 As BanVeChuyenBay.DsSanBayTrungGian
    Friend WithEvents cbSanBayDi As System.Windows.Forms.ComboBox
    Friend WithEvents cbSanBayDen As System.Windows.Forms.ComboBox
    Friend WithEvents dtpNgayGio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents bThoat As System.Windows.Forms.Button
    Friend WithEvents bThemMoi As System.Windows.Forms.Button
    Friend WithEvents lbTenSBDi As System.Windows.Forms.Label
    Friend WithEvents lbTenSBDen As System.Windows.Forms.Label
    Friend WithEvents bLuu As System.Windows.Forms.Button
    Friend WithEvents txtThoiGianBay As System.Windows.Forms.TextBox
    Friend WithEvents txtSLGH1 As System.Windows.Forms.TextBox
    Friend WithEvents txtSLGH2 As System.Windows.Forms.TextBox
    Friend WithEvents bSanBayDi As System.Windows.Forms.Button
    Friend WithEvents bSanBayDen As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(NhanLich))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMaChuyenBay = New System.Windows.Forms.TextBox
        Me.txtThoiGianBay = New System.Windows.Forms.TextBox
        Me.gridSanBayTrungGian = New System.Windows.Forms.DataGrid
        Me.cbSanBayDi = New System.Windows.Forms.ComboBox
        Me.cbSanBayDen = New System.Windows.Forms.ComboBox
        Me.dtpNgayGio = New System.Windows.Forms.DateTimePicker
        Me.bLuu = New System.Windows.Forms.Button
        Me.txtSLGH1 = New System.Windows.Forms.TextBox
        Me.txtSLGH2 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.bThoat = New System.Windows.Forms.Button
        Me.bThemMoi = New System.Windows.Forms.Button
        Me.lbTenSBDi = New System.Windows.Forms.Label
        Me.lbTenSBDen = New System.Windows.Forms.Label
        Me.bSanBayDi = New System.Windows.Forms.Button
        Me.bSanBayDen = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        CType(Me.gridSanBayTrungGian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(112, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Tag = ""
        Me.Label1.Text = "NHẬN LỊCH CHUYẾN BAY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Chuyến Bay"
        '
        'txtMaChuyenBay
        '
        Me.txtMaChuyenBay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaChuyenBay.ForeColor = System.Drawing.Color.Blue
        Me.txtMaChuyenBay.Location = New System.Drawing.Point(256, 72)
        Me.txtMaChuyenBay.Name = "txtMaChuyenBay"
        Me.txtMaChuyenBay.Size = New System.Drawing.Size(248, 26)
        Me.txtMaChuyenBay.TabIndex = 7
        Me.txtMaChuyenBay.Text = ""
        '
        'txtThoiGianBay
        '
        Me.txtThoiGianBay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThoiGianBay.ForeColor = System.Drawing.Color.Blue
        Me.txtThoiGianBay.Location = New System.Drawing.Point(256, 232)
        Me.txtThoiGianBay.Name = "txtThoiGianBay"
        Me.txtThoiGianBay.Size = New System.Drawing.Size(248, 26)
        Me.txtThoiGianBay.TabIndex = 12
        Me.txtThoiGianBay.Text = ""
        '
        'gridSanBayTrungGian
        '
        Me.gridSanBayTrungGian.BackColor = System.Drawing.SystemColors.Info
        Me.gridSanBayTrungGian.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.gridSanBayTrungGian.CaptionBackColor = System.Drawing.Color.Orchid
        Me.gridSanBayTrungGian.CaptionForeColor = System.Drawing.Color.GhostWhite
        Me.gridSanBayTrungGian.CaptionText = "Các sân bay trung gian"
        Me.gridSanBayTrungGian.DataMember = ""
        Me.gridSanBayTrungGian.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridSanBayTrungGian.ForeColor = System.Drawing.Color.Blue
        Me.gridSanBayTrungGian.GridLineColor = System.Drawing.Color.Orchid
        Me.gridSanBayTrungGian.HeaderBackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.gridSanBayTrungGian.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.gridSanBayTrungGian.Location = New System.Drawing.Point(56, 352)
        Me.gridSanBayTrungGian.Name = "gridSanBayTrungGian"
        Me.gridSanBayTrungGian.ParentRowsBackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.gridSanBayTrungGian.PreferredColumnWidth = 143
        Me.gridSanBayTrungGian.RowHeaderWidth = 30
        Me.gridSanBayTrungGian.Size = New System.Drawing.Size(464, 128)
        Me.gridSanBayTrungGian.TabIndex = 13
        '
        'cbSanBayDi
        '
        Me.cbSanBayDi.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSanBayDi.ForeColor = System.Drawing.Color.Blue
        Me.cbSanBayDi.Location = New System.Drawing.Point(256, 112)
        Me.cbSanBayDi.Name = "cbSanBayDi"
        Me.cbSanBayDi.Size = New System.Drawing.Size(248, 25)
        Me.cbSanBayDi.TabIndex = 14
        '
        'cbSanBayDen
        '
        Me.cbSanBayDen.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSanBayDen.ForeColor = System.Drawing.Color.Blue
        Me.cbSanBayDen.Location = New System.Drawing.Point(256, 152)
        Me.cbSanBayDen.Name = "cbSanBayDen"
        Me.cbSanBayDen.Size = New System.Drawing.Size(248, 25)
        Me.cbSanBayDen.TabIndex = 15
        '
        'dtpNgayGio
        '
        Me.dtpNgayGio.CalendarForeColor = System.Drawing.Color.Blue
        Me.dtpNgayGio.CustomFormat = "HH:mm dd/MM/ yyyy "
        Me.dtpNgayGio.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayGio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayGio.Location = New System.Drawing.Point(256, 192)
        Me.dtpNgayGio.Name = "dtpNgayGio"
        Me.dtpNgayGio.Size = New System.Drawing.Size(248, 26)
        Me.dtpNgayGio.TabIndex = 16
        '
        'bLuu
        '
        Me.bLuu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bLuu.Location = New System.Drawing.Point(80, 488)
        Me.bLuu.Name = "bLuu"
        Me.bLuu.Size = New System.Drawing.Size(75, 32)
        Me.bLuu.TabIndex = 18
        Me.bLuu.Text = "Nhận"
        '
        'txtSLGH1
        '
        Me.txtSLGH1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSLGH1.ForeColor = System.Drawing.Color.Blue
        Me.txtSLGH1.Location = New System.Drawing.Point(256, 272)
        Me.txtSLGH1.Name = "txtSLGH1"
        Me.txtSLGH1.Size = New System.Drawing.Size(248, 26)
        Me.txtSLGH1.TabIndex = 21
        Me.txtSLGH1.Text = ""
        '
        'txtSLGH2
        '
        Me.txtSLGH2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSLGH2.ForeColor = System.Drawing.Color.Blue
        Me.txtSLGH2.Location = New System.Drawing.Point(256, 312)
        Me.txtSLGH2.Name = "txtSLGH2"
        Me.txtSLGH2.Size = New System.Drawing.Size(248, 26)
        Me.txtSLGH2.TabIndex = 22
        Me.txtSLGH2.Text = ""
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(72, 312)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(160, 23)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Số Lượng Ghế Hạng 2"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(72, 272)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(168, 23)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Số Lượng Ghế Hạng 1"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(72, 232)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(136, 23)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Thời Gian Bay"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(72, 192)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(136, 23)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Ngày Giờ"
        '
        'bThoat
        '
        Me.bThoat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bThoat.Location = New System.Drawing.Point(416, 488)
        Me.bThoat.Name = "bThoat"
        Me.bThoat.Size = New System.Drawing.Size(75, 32)
        Me.bThoat.TabIndex = 23
        Me.bThoat.Text = "Thoát"
        '
        'bThemMoi
        '
        Me.bThemMoi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bThemMoi.Location = New System.Drawing.Point(240, 488)
        Me.bThemMoi.Name = "bThemMoi"
        Me.bThemMoi.Size = New System.Drawing.Size(88, 32)
        Me.bThemMoi.TabIndex = 24
        Me.bThemMoi.Text = "Thêm Mới"
        '
        'lbTenSBDi
        '
        Me.lbTenSBDi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTenSBDi.Location = New System.Drawing.Point(512, 112)
        Me.lbTenSBDi.Name = "lbTenSBDi"
        Me.lbTenSBDi.Size = New System.Drawing.Size(120, 23)
        Me.lbTenSBDi.TabIndex = 25
        '
        'lbTenSBDen
        '
        Me.lbTenSBDen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTenSBDen.Location = New System.Drawing.Point(512, 152)
        Me.lbTenSBDen.Name = "lbTenSBDen"
        Me.lbTenSBDen.Size = New System.Drawing.Size(120, 23)
        Me.lbTenSBDen.TabIndex = 26
        '
        'bSanBayDi
        '
        Me.bSanBayDi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSanBayDi.Location = New System.Drawing.Point(72, 112)
        Me.bSanBayDi.Name = "bSanBayDi"
        Me.bSanBayDi.Size = New System.Drawing.Size(128, 32)
        Me.bSanBayDi.TabIndex = 27
        Me.bSanBayDi.Text = "Sân Bay Đi"
        Me.bSanBayDi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bSanBayDen
        '
        Me.bSanBayDen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSanBayDen.Location = New System.Drawing.Point(72, 152)
        Me.bSanBayDen.Name = "bSanBayDen"
        Me.bSanBayDen.Size = New System.Drawing.Size(128, 32)
        Me.bSanBayDen.TabIndex = 28
        Me.bSanBayDen.Text = "Sân Bay Đến"
        Me.bSanBayDen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(32, 112)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(32, 152)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 31
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(40, 488)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.TabIndex = 32
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(200, 488)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.TabIndex = 33
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(376, 488)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox6.TabIndex = 34
        Me.PictureBox6.TabStop = False
        '
        'NhanLich
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 19)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.ClientSize = New System.Drawing.Size(640, 534)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bSanBayDen)
        Me.Controls.Add(Me.bSanBayDi)
        Me.Controls.Add(Me.lbTenSBDen)
        Me.Controls.Add(Me.lbTenSBDi)
        Me.Controls.Add(Me.bThemMoi)
        Me.Controls.Add(Me.bThoat)
        Me.Controls.Add(Me.txtSLGH2)
        Me.Controls.Add(Me.txtSLGH1)
        Me.Controls.Add(Me.txtThoiGianBay)
        Me.Controls.Add(Me.txtMaChuyenBay)
        Me.Controls.Add(Me.bLuu)
        Me.Controls.Add(Me.dtpNgayGio)
        Me.Controls.Add(Me.cbSanBayDen)
        Me.Controls.Add(Me.cbSanBayDi)
        Me.Controls.Add(Me.gridSanBayTrungGian)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Name = "NhanLich"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nhan Lich Chuyen Bay"
        CType(Me.gridSanBayTrungGian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub NhanLich_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'đưa các giá trị vào cbSanBayDi
        Dim dsSanBayDi As DataSet
        Dim sb As New CSanBay
        dsSanBayDi = sb.LayDanhSachSanBay()
        sb = Nothing

        Me.cbSanBayDi.DataSource = dsSanBayDi.Tables(0)
        Me.cbSanBayDi.DisplayMember = "MaSanBay"
        Me.cbSanBayDi.Text = ""

        'điền tiêu đề các cột vào dgSanBayTrungGian
        Dim dsCTChuyenBay As DataSet
        Dim ctcb As New CCTChuyenBay
        dsCTChuyenBay = ctcb.LayTieuDeCTCB()
        Me.gridSanBayTrungGian.DataSource = dsCTChuyenBay.Tables(0)
        ctcb = Nothing

        Me.lbTenSBDen.Text = ""
        Me.lbTenSBDi.Text = ""
    End Sub

    Private Sub cbSanBayDi_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSanBayDi.LostFocus
        Dim dsSanBayDen As DataSet
        Dim tb As New CTuyenBay
        dsSanBayDen = tb.ChonTuyenBay(True, cbSanBayDi.Text)
        tb = Nothing

        Me.cbSanBayDen.DataSource = dsSanBayDen.Tables(0)
        Me.cbSanBayDen.DisplayMember = "SanBayDen"

        Dim sb As New CSanBay
        Me.lbTenSBDen.Text = sb.LayTenSanBay(cbSanBayDen.Text)
        sb = Nothing
    End Sub

    Private Sub bLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bLuu.Click
        If (Me.txtMaChuyenBay.Text = "") Then
            MsgBox("Chưa nhập mã chuyến bay")
            Exit Sub
        End If

        Dim cb1 As New CChuyenBay
        If (cb1.KiemTraChuyenBay(txtMaChuyenBay.Text) = False) Then
            MsgBox("Mã Chuyến Bay đã tồn tại. Chọn mã khác!")
            Exit Sub
        End If
        cb1 = Nothing

        If (Me.cbSanBayDi.Text = "") Then
            MsgBox("Chưa chọn sân bay đi")
            Exit Sub
        End If
        If (Me.cbSanBayDen.Text = "") Then
            MsgBox("Chưa chọn sân bay đến")
            Exit Sub
        End If
        'Luu thong tin chuyen bay
        Dim cb As New CChuyenBay
        Dim tb As New CTuyenBay
        Dim matb As String
        matb = tb.LayMaTuyenBay(cbSanBayDi.Text, cbSanBayDen.Text)
        cb.ThemChuyenBay(txtMaChuyenBay.Text, matb, dtpNgayGio.Value, Val(txtThoiGianBay.Text), Val(txtSLGH1.Text), Val(txtSLGH2.Text))
        cb = Nothing
        tb = Nothing

        'Luu thong tin chi tiet chuyen bay (cac san bay trung gian)
        Dim ct As New CCTChuyenBay
        Dim i As Integer
        i = gridSanBayTrungGian.FirstVisibleColumn
        matb = gridSanBayTrungGian.Text
        While (i < gridSanBayTrungGian.VisibleRowCount - 1)
            ct.ThemCTChuyenBay(txtMaChuyenBay.Text, gridSanBayTrungGian.Item(i, 0), gridSanBayTrungGian.Item(i, 1), gridSanBayTrungGian.Item(i, 2))
            i += 1

        End While
        ct = Nothing

        'them vao bang tinh trang ve
        Dim ttv As New CTinhTrangVe
        ttv.ThemTinhTrangVe(txtMaChuyenBay.Text, Val(txtSLGH1.Text) + Val(txtSLGH2.Text))
    End Sub

    Private Sub cbSanBayDi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSanBayDi.SelectedIndexChanged
        Dim sb As New CSanBay
        lbTenSBDi.Text = sb.LayTenSanBay(cbSanBayDi.Text)
        sb = Nothing
    End Sub

    Private Sub cbSanBayDen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSanBayDen.SelectedIndexChanged
        Dim sb As New CSanBay
        lbTenSBDen.Text = sb.LayTenSanBay(cbSanBayDen.Text)
        sb = Nothing
    End Sub

    Private Sub bThemMoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bThemMoi.Click
        Me.txtMaChuyenBay.Text = ""
        Me.txtSLGH1.Text = ""
        Me.txtSLGH2.Text = ""
        Me.txtThoiGianBay.Text = ""
        Me.cbSanBayDen.Text = ""
        Me.cbSanBayDen.DataSource = Nothing
        Me.gridSanBayTrungGian.DataSource = Nothing
        Me.cbSanBayDi.Text = ""
        Me.lbTenSBDi.Text = ""

        Dim dsCTChuyenBay As DataSet
        Dim ctcb As New CCTChuyenBay
        dsCTChuyenBay = ctcb.LayTieuDeCTCB()
        Me.gridSanBayTrungGian.DataSource = dsCTChuyenBay.Tables(0)
        ctcb = Nothing
    End Sub

    Private Sub bThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bThoat.Click
        Me.Close()
    End Sub

    Private Sub bSanBayDi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSanBayDi.Click
        Dim frm As New ThemSanBay
        frm.ShowDialog()
    End Sub

    Private Sub cbSanBayDi_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSanBayDi.GotFocus
        Me.cbSanBayDen.Text = ""
        Me.lbTenSBDen.Text = ""
    End Sub

    Private Sub bSanBayDen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSanBayDen.Click
        Dim frm As New ThemTuyenBay
        frm.ShowDialog()
    End Sub
End Class
