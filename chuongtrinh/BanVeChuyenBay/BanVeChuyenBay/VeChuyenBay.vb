Public Class VeChuyenBay
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSanBayDi As System.Windows.Forms.TextBox
    Friend WithEvents txtSanBayDen As System.Windows.Forms.TextBox
    Friend WithEvents txtTinhTrangVe As System.Windows.Forms.TextBox
    Friend WithEvents txtNgayGio As System.Windows.Forms.TextBox
    Friend WithEvents txtHanhKhach As System.Windows.Forms.TextBox
    Friend WithEvents txtDienThoai As System.Windows.Forms.TextBox
    Friend WithEvents txtCMND As System.Windows.Forms.TextBox
    Friend WithEvents txtGiaTien As System.Windows.Forms.TextBox
    Friend WithEvents bLuu As System.Windows.Forms.Button
    Friend WithEvents bTaoMoi As System.Windows.Forms.Button
    Friend WithEvents bThoat As System.Windows.Forms.Button
    Friend WithEvents cbHangVe As System.Windows.Forms.ComboBox
    Friend WithEvents txtMaHanhKhach As System.Windows.Forms.TextBox
    Friend WithEvents cbMaChuyenBay As System.Windows.Forms.ComboBox
    Friend WithEvents bMaHanhKhach As System.Windows.Forms.Button
    Friend WithEvents txtTenHangVe As System.Windows.Forms.TextBox
    Friend WithEvents bHangVe As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(VeChuyenBay))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSanBayDi = New System.Windows.Forms.TextBox
        Me.txtSanBayDen = New System.Windows.Forms.TextBox
        Me.txtTinhTrangVe = New System.Windows.Forms.TextBox
        Me.txtNgayGio = New System.Windows.Forms.TextBox
        Me.txtHanhKhach = New System.Windows.Forms.TextBox
        Me.txtDienThoai = New System.Windows.Forms.TextBox
        Me.txtCMND = New System.Windows.Forms.TextBox
        Me.txtGiaTien = New System.Windows.Forms.TextBox
        Me.bLuu = New System.Windows.Forms.Button
        Me.bTaoMoi = New System.Windows.Forms.Button
        Me.bThoat = New System.Windows.Forms.Button
        Me.cbHangVe = New System.Windows.Forms.ComboBox
        Me.txtMaHanhKhach = New System.Windows.Forms.TextBox
        Me.cbMaChuyenBay = New System.Windows.Forms.ComboBox
        Me.bMaHanhKhach = New System.Windows.Forms.Button
        Me.txtTenHangVe = New System.Windows.Forms.TextBox
        Me.bHangVe = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(504, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VÉ CHUYẾN BAY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(56, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hành Khách"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(360, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CMND"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(360, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Điện Thoại"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(56, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Giá Tiền"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(360, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 23)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Tình Trạng Vé"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(56, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 23)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Ngày Giờ"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(360, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 23)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Sân Bay Đến"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(56, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 23)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Sân Bay Đi"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Chuyến Bay"
        '
        'txtSanBayDi
        '
        Me.txtSanBayDi.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtSanBayDi.Enabled = False
        Me.txtSanBayDi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSanBayDi.ForeColor = System.Drawing.Color.Blue
        Me.txtSanBayDi.Location = New System.Drawing.Point(200, 120)
        Me.txtSanBayDi.Name = "txtSanBayDi"
        Me.txtSanBayDi.Size = New System.Drawing.Size(144, 26)
        Me.txtSanBayDi.TabIndex = 12
        Me.txtSanBayDi.Text = ""
        '
        'txtSanBayDen
        '
        Me.txtSanBayDen.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtSanBayDen.Enabled = False
        Me.txtSanBayDen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSanBayDen.Location = New System.Drawing.Point(480, 120)
        Me.txtSanBayDen.Name = "txtSanBayDen"
        Me.txtSanBayDen.Size = New System.Drawing.Size(144, 26)
        Me.txtSanBayDen.TabIndex = 13
        Me.txtSanBayDen.Text = ""
        '
        'txtTinhTrangVe
        '
        Me.txtTinhTrangVe.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtTinhTrangVe.Enabled = False
        Me.txtTinhTrangVe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTinhTrangVe.Location = New System.Drawing.Point(480, 160)
        Me.txtTinhTrangVe.Name = "txtTinhTrangVe"
        Me.txtTinhTrangVe.Size = New System.Drawing.Size(144, 26)
        Me.txtTinhTrangVe.TabIndex = 14
        Me.txtTinhTrangVe.Text = ""
        '
        'txtNgayGio
        '
        Me.txtNgayGio.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtNgayGio.Enabled = False
        Me.txtNgayGio.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNgayGio.Location = New System.Drawing.Point(200, 160)
        Me.txtNgayGio.Name = "txtNgayGio"
        Me.txtNgayGio.Size = New System.Drawing.Size(144, 26)
        Me.txtNgayGio.TabIndex = 15
        Me.txtNgayGio.Text = ""
        '
        'txtHanhKhach
        '
        Me.txtHanhKhach.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtHanhKhach.Enabled = False
        Me.txtHanhKhach.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHanhKhach.Location = New System.Drawing.Point(200, 248)
        Me.txtHanhKhach.Name = "txtHanhKhach"
        Me.txtHanhKhach.Size = New System.Drawing.Size(144, 26)
        Me.txtHanhKhach.TabIndex = 16
        Me.txtHanhKhach.Text = ""
        '
        'txtDienThoai
        '
        Me.txtDienThoai.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtDienThoai.Enabled = False
        Me.txtDienThoai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDienThoai.Location = New System.Drawing.Point(480, 248)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Size = New System.Drawing.Size(144, 26)
        Me.txtDienThoai.TabIndex = 17
        Me.txtDienThoai.Text = ""
        '
        'txtCMND
        '
        Me.txtCMND.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtCMND.Enabled = False
        Me.txtCMND.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCMND.Location = New System.Drawing.Point(480, 208)
        Me.txtCMND.Name = "txtCMND"
        Me.txtCMND.Size = New System.Drawing.Size(144, 26)
        Me.txtCMND.TabIndex = 18
        Me.txtCMND.Text = ""
        '
        'txtGiaTien
        '
        Me.txtGiaTien.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtGiaTien.Enabled = False
        Me.txtGiaTien.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGiaTien.ForeColor = System.Drawing.Color.Blue
        Me.txtGiaTien.Location = New System.Drawing.Point(200, 344)
        Me.txtGiaTien.Name = "txtGiaTien"
        Me.txtGiaTien.Size = New System.Drawing.Size(144, 26)
        Me.txtGiaTien.TabIndex = 20
        Me.txtGiaTien.Text = ""
        '
        'bLuu
        '
        Me.bLuu.Location = New System.Drawing.Point(144, 392)
        Me.bLuu.Name = "bLuu"
        Me.bLuu.Size = New System.Drawing.Size(75, 32)
        Me.bLuu.TabIndex = 21
        Me.bLuu.Text = "Lưu"
        '
        'bTaoMoi
        '
        Me.bTaoMoi.Location = New System.Drawing.Point(304, 392)
        Me.bTaoMoi.Name = "bTaoMoi"
        Me.bTaoMoi.Size = New System.Drawing.Size(75, 32)
        Me.bTaoMoi.TabIndex = 22
        Me.bTaoMoi.Text = "Tạo Mới"
        '
        'bThoat
        '
        Me.bThoat.Location = New System.Drawing.Point(464, 392)
        Me.bThoat.Name = "bThoat"
        Me.bThoat.Size = New System.Drawing.Size(75, 32)
        Me.bThoat.TabIndex = 23
        Me.bThoat.Text = "Thoát"
        '
        'cbHangVe
        '
        Me.cbHangVe.ForeColor = System.Drawing.Color.Blue
        Me.cbHangVe.Location = New System.Drawing.Point(200, 304)
        Me.cbHangVe.Name = "cbHangVe"
        Me.cbHangVe.Size = New System.Drawing.Size(144, 27)
        Me.cbHangVe.TabIndex = 24
        '
        'txtMaHanhKhach
        '
        Me.txtMaHanhKhach.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaHanhKhach.ForeColor = System.Drawing.Color.Blue
        Me.txtMaHanhKhach.Location = New System.Drawing.Point(200, 208)
        Me.txtMaHanhKhach.Name = "txtMaHanhKhach"
        Me.txtMaHanhKhach.Size = New System.Drawing.Size(144, 26)
        Me.txtMaHanhKhach.TabIndex = 26
        Me.txtMaHanhKhach.Text = ""
        '
        'cbMaChuyenBay
        '
        Me.cbMaChuyenBay.ForeColor = System.Drawing.Color.Blue
        Me.cbMaChuyenBay.Location = New System.Drawing.Point(200, 80)
        Me.cbMaChuyenBay.Name = "cbMaChuyenBay"
        Me.cbMaChuyenBay.Size = New System.Drawing.Size(144, 27)
        Me.cbMaChuyenBay.TabIndex = 27
        '
        'bMaHanhKhach
        '
        Me.bMaHanhKhach.Location = New System.Drawing.Point(56, 208)
        Me.bMaHanhKhach.Name = "bMaHanhKhach"
        Me.bMaHanhKhach.Size = New System.Drawing.Size(128, 32)
        Me.bMaHanhKhach.TabIndex = 28
        Me.bMaHanhKhach.Text = "Mã Hành Khách"
        Me.bMaHanhKhach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTenHangVe
        '
        Me.txtTenHangVe.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtTenHangVe.Enabled = False
        Me.txtTenHangVe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenHangVe.ForeColor = System.Drawing.Color.Blue
        Me.txtTenHangVe.Location = New System.Drawing.Point(360, 304)
        Me.txtTenHangVe.Name = "txtTenHangVe"
        Me.txtTenHangVe.Size = New System.Drawing.Size(120, 26)
        Me.txtTenHangVe.TabIndex = 29
        Me.txtTenHangVe.Text = ""
        '
        'bHangVe
        '
        Me.bHangVe.Location = New System.Drawing.Point(56, 304)
        Me.bHangVe.Name = "bHangVe"
        Me.bHangVe.Size = New System.Drawing.Size(128, 32)
        Me.bHangVe.TabIndex = 30
        Me.bHangVe.Text = "Hạng Vé"
        Me.bHangVe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(16, 208)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(16, 304)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 33
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(96, 392)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.TabIndex = 34
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(264, 392)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.TabIndex = 35
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(424, 392)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox6.TabIndex = 36
        Me.PictureBox6.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'VeChuyenBay
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 19)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.ClientSize = New System.Drawing.Size(640, 438)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.bHangVe)
        Me.Controls.Add(Me.txtTenHangVe)
        Me.Controls.Add(Me.bMaHanhKhach)
        Me.Controls.Add(Me.cbMaChuyenBay)
        Me.Controls.Add(Me.txtMaHanhKhach)
        Me.Controls.Add(Me.cbHangVe)
        Me.Controls.Add(Me.bThoat)
        Me.Controls.Add(Me.bTaoMoi)
        Me.Controls.Add(Me.bLuu)
        Me.Controls.Add(Me.txtGiaTien)
        Me.Controls.Add(Me.txtCMND)
        Me.Controls.Add(Me.txtDienThoai)
        Me.Controls.Add(Me.txtHanhKhach)
        Me.Controls.Add(Me.txtNgayGio)
        Me.Controls.Add(Me.txtTinhTrangVe)
        Me.Controls.Add(Me.txtSanBayDen)
        Me.Controls.Add(Me.txtSanBayDi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Name = "VeChuyenBay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VeChuyenBay"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim matuyenbay As String
    Private Sub bThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bThoat.Click
        Me.Close()
    End Sub

    Private Sub VeChuyenBay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load du lieu vao combobox cbMaChuyenBay
        Dim cb As New CChuyenBay
        Dim ds As DataSet
        ds = cb.LayMaCBSauNgay(Now)
        cb = Nothing
        Me.cbMaChuyenBay.DataSource = ds.Tables(0)
        Me.cbMaChuyenBay.DisplayMember = "MaChuyenBay"

        Me.cbMaChuyenBay.Text = ""
        Me.txtSanBayDen.Text = ""
        Me.txtSanBayDi.Text = ""
        Me.txtNgayGio.Text = ""
        Me.txtTinhTrangVe.Text = ""

        'load cac hang ve
        Dim hv As New CHangVe
        Dim dsHangVe As DataSet
        dsHangVe = hv.LayDSHangVe()
        hv = Nothing
        Me.cbHangVe.DataSource = dsHangVe.Tables(0)
        Me.cbHangVe.DisplayMember = "MaHangVe"
        Me.cbHangVe.Text = dsHangVe.Tables(0).Rows(0)(0)
        Me.txtTenHangVe.Text = dsHangVe.Tables(0).Rows(0)(1)
        Me.txtGiaTien.Text = ""

    End Sub

    Private Sub cbMaChuyenBay_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMaChuyenBay.SelectedIndexChanged
        If (Me.cbMaChuyenBay.Text = "") Then
            Exit Sub
        End If
        Dim cb As New CChuyenBay
        Dim ds As DataSet
        ds = cb.LayDSChuyenBayTheoMa(cbMaChuyenBay.Text)
        cb = Nothing

        txtSanBayDi.Text = ds.Tables(0).Rows(0)(0)
        txtSanBayDen.Text = ds.Tables(0).Rows(0)(1)
        txtNgayGio.Text = ds.Tables(0).Rows(0)(2)
        matuyenbay = ds.Tables(0).Rows(0)(3)

        Dim ttv As New CTinhTrangVe
        txtTinhTrangVe.Text = ttv.LayTinhTrangVe(cbMaChuyenBay.Text)
        ttv = Nothing

        If (cbMaChuyenBay.Text = "" Or cbHangVe.Text = "") Then
            txtGiaTien.Text = ""
            Exit Sub
        End If

        Dim dg As New CDonGia
        Dim gia As Double
        gia = dg.LayDonGia(matuyenbay, cbHangVe.Text)
        txtGiaTien.Text = gia.ToString
    End Sub

    Private Sub bMaHanhKhach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bMaHanhKhach.Click
        Dim frm As New ThemHanhKhach
        frm.ShowDialog()
        txtMaHanhKhach.Text = frm.txtMaHanhKhach.Text
        txtCMND.Text = frm.txtCMND.Text
        txtDienThoai.Text = frm.txtDienThoai.Text
        txtHanhKhach.Text = frm.txtTenHanhKhach.Text
    End Sub

    Private Sub txtMaHanhKhach_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMaHanhKhach.LostFocus
        If (txtMaHanhKhach.Text = "") Then
            txtDienThoai.Text = ""
            txtCMND.Text = ""
            txtHanhKhach.Text = ""
            Exit Sub
        End If
        Dim hk As New CHanhKhach
        Dim ds As DataSet
        ds = hk.LayHanhKhachTuMa(txtMaHanhKhach.Text)
        hk = Nothing

        If (ds.Tables(0).Rows.Count = 0) Then
            Exit Sub
        End If
        txtHanhKhach.Text = ds.Tables(0).Rows(0)(0)
        txtCMND.Text = ds.Tables(0).Rows(0)(1)
        txtDienThoai.Text = ds.Tables(0).Rows(0)(2)

        If (cbMaChuyenBay.Text = "" Or cbHangVe.Text = "") Then
            txtGiaTien.Text = ""
            Exit Sub
        End If

        Dim dg As New CDonGia
        Dim gia As Double
        gia = dg.LayDonGia(matuyenbay, cbHangVe.Text)
        txtGiaTien.Text = gia.ToString
    End Sub

    Private Sub cbHangVe_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbHangVe.SelectedIndexChanged
        If (cbHangVe.Text = "") Then
            txtTenHangVe.Text = ""
            Exit Sub
        End If
        Dim hv As New CHangVe
        txtTenHangVe.Text = hv.LayTenHangVe(cbHangVe.Text)
        hv = Nothing

        If (cbMaChuyenBay.Text = "" or cbHangVe.Text="") Then
            txtGiaTien.Text = ""
            Exit Sub
        End If

        Dim dg As New CDonGia
        Dim gia As Double
        gia = dg.LayDonGia(matuyenbay, cbHangVe.Text)
        dg = Nothing
        txtGiaTien.Text = gia.ToString
    End Sub

    Private Sub bHangVe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bHangVe.Click
        Dim frm As New ThemHangVe
        frm.ShowDialog()
        Dim cb As New CChuyenBay
        Dim ds As DataSet
        ds = cb.LayMaCBSauNgay(Now)
        cb = Nothing
        Me.cbMaChuyenBay.DataSource = ds.Tables(0)
        Me.cbMaChuyenBay.DisplayMember = "MaChuyenBay"
    End Sub

    Private Sub bLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bLuu.Click
        If (txtSanBayDi.Text = "") Then
            MsgBox("Chưa chọn chuyến bay")
            Exit Sub
        End If

        If (txtMaHanhKhach.Text = "") Then
            MsgBox("Chưa có hành khách")
            Exit Sub
        End If

        Dim vcb As New CVeChuyenBay
        Dim dg As New CDonGia
        Dim gia As Double
        gia = dg.LayDonGia(matuyenbay, cbHangVe.Text)
        dg = Nothing
        vcb.ThemVeChuyenBay(cbMaChuyenBay.Text, cbHangVe.Text, txtMaHanhKhach.Text, gia)
        vcb = Nothing
        'cap nhat lai tinh trang ve
        Dim ttv As New CTinhTrangVe
        ttv.CapNhatTinhTrangVe(cbMaChuyenBay.Text, True)
    End Sub

    Private Sub bTaoMoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bTaoMoi.Click
        Me.txtSanBayDen.Text = ""
        Me.txtSanBayDi.Text = ""
        Me.txtNgayGio.Text = ""
        Me.txtTinhTrangVe.Text = ""
        Me.txtGiaTien.Text = ""
        Me.txtMaHanhKhach.Text = ""
        Me.txtHanhKhach.Text = ""
        Me.txtCMND.Text = ""
        Me.txtGiaTien.Text = ""
        Me.cbMaChuyenBay.Text = ""
    End Sub


End Class
