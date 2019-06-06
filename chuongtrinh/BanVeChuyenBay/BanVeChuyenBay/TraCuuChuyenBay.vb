Public Class TraCuuChuyenBay
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbSanBayDi As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbSanBayDen As System.Windows.Forms.ComboBox
    Friend WithEvents dtpTuNgay As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDenNgay As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgDSChuyenBay As System.Windows.Forms.DataGrid
    Friend WithEvents bTim As System.Windows.Forms.Button
    Friend WithEvents bThoat As System.Windows.Forms.Button
    Friend WithEvents lbTenSBDi As System.Windows.Forms.Label
    Friend WithEvents lbTenSBDen As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TraCuuChuyenBay))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbSanBayDi = New System.Windows.Forms.ComboBox
        Me.cbSanBayDen = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpTuNgay = New System.Windows.Forms.DateTimePicker
        Me.dtpDenNgay = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.dgDSChuyenBay = New System.Windows.Forms.DataGrid
        Me.bTim = New System.Windows.Forms.Button
        Me.bThoat = New System.Windows.Forms.Button
        Me.lbTenSBDi = New System.Windows.Forms.Label
        Me.lbTenSBDen = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.dgDSChuyenBay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(136, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(480, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TRA CỨU CHUYẾN BAY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(56, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sân Bay Đi"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(56, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sân Bay Đến"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(56, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ngày Khởi Hành"
        '
        'cbSanBayDi
        '
        Me.cbSanBayDi.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSanBayDi.ForeColor = System.Drawing.Color.Blue
        Me.cbSanBayDi.Location = New System.Drawing.Point(184, 72)
        Me.cbSanBayDi.Name = "cbSanBayDi"
        Me.cbSanBayDi.Size = New System.Drawing.Size(232, 25)
        Me.cbSanBayDi.TabIndex = 15
        '
        'cbSanBayDen
        '
        Me.cbSanBayDen.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSanBayDen.ForeColor = System.Drawing.Color.Blue
        Me.cbSanBayDen.Location = New System.Drawing.Point(184, 112)
        Me.cbSanBayDen.Name = "cbSanBayDen"
        Me.cbSanBayDen.Size = New System.Drawing.Size(232, 25)
        Me.cbSanBayDen.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(136, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 23)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Từ"
        '
        'dtpTuNgay
        '
        Me.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpTuNgay.Location = New System.Drawing.Point(184, 184)
        Me.dtpTuNgay.Name = "dtpTuNgay"
        Me.dtpTuNgay.Size = New System.Drawing.Size(232, 26)
        Me.dtpTuNgay.TabIndex = 18
        '
        'dtpDenNgay
        '
        Me.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpDenNgay.Location = New System.Drawing.Point(488, 184)
        Me.dtpDenNgay.Name = "dtpDenNgay"
        Me.dtpDenNgay.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(440, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 23)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Đến"
        '
        'dgDSChuyenBay
        '
        Me.dgDSChuyenBay.BackColor = System.Drawing.SystemColors.Info
        Me.dgDSChuyenBay.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.dgDSChuyenBay.CaptionBackColor = System.Drawing.Color.Orchid
        Me.dgDSChuyenBay.CaptionText = "Danh sách chuyến bay"
        Me.dgDSChuyenBay.DataMember = ""
        Me.dgDSChuyenBay.GridLineColor = System.Drawing.Color.Orchid
        Me.dgDSChuyenBay.HeaderBackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.dgDSChuyenBay.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgDSChuyenBay.Location = New System.Drawing.Point(56, 272)
        Me.dgDSChuyenBay.Name = "dgDSChuyenBay"
        Me.dgDSChuyenBay.PreferredColumnWidth = 99
        Me.dgDSChuyenBay.RowHeaderWidth = 40
        Me.dgDSChuyenBay.Size = New System.Drawing.Size(640, 136)
        Me.dgDSChuyenBay.TabIndex = 21
        '
        'bTim
        '
        Me.bTim.Location = New System.Drawing.Point(96, 224)
        Me.bTim.Name = "bTim"
        Me.bTim.Size = New System.Drawing.Size(75, 32)
        Me.bTim.TabIndex = 22
        Me.bTim.Text = "Tìm"
        '
        'bThoat
        '
        Me.bThoat.Location = New System.Drawing.Point(96, 424)
        Me.bThoat.Name = "bThoat"
        Me.bThoat.Size = New System.Drawing.Size(75, 32)
        Me.bThoat.TabIndex = 23
        Me.bThoat.Text = "Thoát"
        '
        'lbTenSBDi
        '
        Me.lbTenSBDi.Location = New System.Drawing.Point(448, 72)
        Me.lbTenSBDi.Name = "lbTenSBDi"
        Me.lbTenSBDi.Size = New System.Drawing.Size(168, 23)
        Me.lbTenSBDi.TabIndex = 24
        '
        'lbTenSBDen
        '
        Me.lbTenSBDen.Location = New System.Drawing.Point(448, 112)
        Me.lbTenSBDen.Name = "lbTenSBDen"
        Me.lbTenSBDen.Size = New System.Drawing.Size(168, 23)
        Me.lbTenSBDen.TabIndex = 25
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(56, 224)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 33
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(56, 424)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'TraCuuChuyenBay
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 19)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.ClientSize = New System.Drawing.Size(712, 462)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lbTenSBDen)
        Me.Controls.Add(Me.lbTenSBDi)
        Me.Controls.Add(Me.bThoat)
        Me.Controls.Add(Me.bTim)
        Me.Controls.Add(Me.dgDSChuyenBay)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpDenNgay)
        Me.Controls.Add(Me.dtpTuNgay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbSanBayDen)
        Me.Controls.Add(Me.cbSanBayDi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Name = "TraCuuChuyenBay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TraCuuChuyenBay"
        CType(Me.dgDSChuyenBay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub TraCuuChuyenBay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'đưa các giá trị vào cbSanBayDi
        Dim dsSanBayDi As DataSet
        Dim sb As New CSanBay
        dsSanBayDi = sb.LayDanhSachSanBay()
        sb = Nothing

        Me.cbSanBayDi.DataSource = dsSanBayDi.Tables(0)
        Me.cbSanBayDi.DisplayMember = "MaSanBay"

        Me.cbSanBayDi.Text = dsSanBayDi.Tables(0).Rows(0)(0)

        Dim cb As New CChuyenBay
        Dim ds As DataSet
        ds = cb.LayTDTraCuu(True)
        cb = Nothing

        Me.dgDSChuyenBay.DataSource = ds.Tables(0)
    End Sub

    Private Sub cbSanBayDi_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSanBayDi.LostFocus
        'Dim dsSanBayDen As DataSet
        'Dim tb As New CTuyenBay
        'dsSanBayDen = tb.ChonTuyenBay(True, cbSanBayDi.Text)
        'tb = Nothing

        'Me.cbSanBayDen.DataSource = dsSanBayDen.Tables(0)
        'Me.cbSanBayDen.DisplayMember = "SanBayDen"

        'Dim sb As New CSanBay
        'Me.lbTenSBDen.Text = sb.LayTenSanBay(cbSanBayDen.Text)
        'sb = Nothing
    End Sub

    Private Sub cbSanBayDi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSanBayDi.SelectedIndexChanged
        Dim dsSanBayDen As DataSet
        Dim tb As New CTuyenBay
        dsSanBayDen = tb.ChonTuyenBay(True, cbSanBayDi.Text)
        tb = Nothing

        Me.cbSanBayDen.DataSource = dsSanBayDen.Tables(0)
        Me.cbSanBayDen.DisplayMember = "SanBayDen"

        Dim sb As New CSanBay
        Me.lbTenSBDen.Text = sb.LayTenSanBay(cbSanBayDen.Text)

        lbTenSBDi.Text = sb.LayTenSanBay(cbSanBayDi.Text)
        sb = Nothing
    End Sub

    Private Sub cbSanBayDen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSanBayDen.SelectedIndexChanged
        Dim sb As New CSanBay
        lbTenSBDen.Text = sb.LayTenSanBay(cbSanBayDen.Text)
        sb = Nothing
    End Sub

    Private Sub bThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bThoat.Click
        Me.Close()
    End Sub

    Private Sub bTim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bTim.Click
        Dim cb As New CChuyenBay
        Dim dscb As DataSet
        dscb = cb.TimChuyenBay(cbSanBayDi.Text, cbSanBayDen.Text, dtpTuNgay.Value, dtpDenNgay.Value)
        cb = Nothing
        dgDSChuyenBay.DataSource = dscb.Tables(0)
    End Sub

   
End Class
