Public Class ThemTuyenBay
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
    Friend WithEvents txtMaTuyenBay As System.Windows.Forms.TextBox
    Friend WithEvents lbSanBayDi As System.Windows.Forms.Label
    Friend WithEvents lbSanBayDen As System.Windows.Forms.Label
    Friend WithEvents cbSanBayDi As System.Windows.Forms.ComboBox
    Friend WithEvents cbSanBayDen As System.Windows.Forms.ComboBox
    Friend WithEvents bThem As System.Windows.Forms.Button
    Friend WithEvents bThoat As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ThemTuyenBay))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtMaTuyenBay = New System.Windows.Forms.TextBox
        Me.lbSanBayDi = New System.Windows.Forms.Label
        Me.lbSanBayDen = New System.Windows.Forms.Label
        Me.cbSanBayDi = New System.Windows.Forms.ComboBox
        Me.cbSanBayDen = New System.Windows.Forms.ComboBox
        Me.bThem = New System.Windows.Forms.Button
        Me.bThoat = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "THÊM TUYẾN BAY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(56, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Tuyến Bay"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(56, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sân Bay Ði"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(56, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sân Bay Ðến"
        '
        'txtMaTuyenBay
        '
        Me.txtMaTuyenBay.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtMaTuyenBay.Enabled = False
        Me.txtMaTuyenBay.ForeColor = System.Drawing.Color.Blue
        Me.txtMaTuyenBay.Location = New System.Drawing.Point(192, 88)
        Me.txtMaTuyenBay.Name = "txtMaTuyenBay"
        Me.txtMaTuyenBay.Size = New System.Drawing.Size(152, 26)
        Me.txtMaTuyenBay.TabIndex = 4
        Me.txtMaTuyenBay.Text = ""
        '
        'lbSanBayDi
        '
        Me.lbSanBayDi.Location = New System.Drawing.Point(360, 136)
        Me.lbSanBayDi.Name = "lbSanBayDi"
        Me.lbSanBayDi.TabIndex = 7
        '
        'lbSanBayDen
        '
        Me.lbSanBayDen.Location = New System.Drawing.Point(360, 168)
        Me.lbSanBayDen.Name = "lbSanBayDen"
        Me.lbSanBayDen.TabIndex = 8
        '
        'cbSanBayDi
        '
        Me.cbSanBayDi.ForeColor = System.Drawing.Color.Blue
        Me.cbSanBayDi.Location = New System.Drawing.Point(192, 128)
        Me.cbSanBayDi.Name = "cbSanBayDi"
        Me.cbSanBayDi.Size = New System.Drawing.Size(152, 27)
        Me.cbSanBayDi.TabIndex = 9
        '
        'cbSanBayDen
        '
        Me.cbSanBayDen.ForeColor = System.Drawing.Color.Blue
        Me.cbSanBayDen.Location = New System.Drawing.Point(192, 168)
        Me.cbSanBayDen.Name = "cbSanBayDen"
        Me.cbSanBayDen.Size = New System.Drawing.Size(152, 27)
        Me.cbSanBayDen.TabIndex = 10
        '
        'bThem
        '
        Me.bThem.Location = New System.Drawing.Point(104, 216)
        Me.bThem.Name = "bThem"
        Me.bThem.Size = New System.Drawing.Size(75, 32)
        Me.bThem.TabIndex = 11
        Me.bThem.Text = "Thêm"
        '
        'bThoat
        '
        Me.bThoat.Location = New System.Drawing.Point(272, 216)
        Me.bThoat.Name = "bThoat"
        Me.bThoat.Size = New System.Drawing.Size(75, 32)
        Me.bThoat.TabIndex = 12
        Me.bThoat.Text = "Thoát"
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
        Me.PictureBox2.Location = New System.Drawing.Point(64, 216)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(232, 216)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 32
        Me.PictureBox3.TabStop = False
        '
        'ThemTuyenBay
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 19)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.ClientSize = New System.Drawing.Size(480, 270)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bThoat)
        Me.Controls.Add(Me.bThem)
        Me.Controls.Add(Me.cbSanBayDen)
        Me.Controls.Add(Me.cbSanBayDi)
        Me.Controls.Add(Me.lbSanBayDen)
        Me.Controls.Add(Me.lbSanBayDi)
        Me.Controls.Add(Me.txtMaTuyenBay)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Name = "ThemTuyenBay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ThemTuyenBay"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ThemTuyenBay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsSanBayDi As DataSet
        Dim sb As New CSanBay
        dsSanBayDi = sb.LayDanhSachSanBay()
        sb = Nothing

        Me.cbSanBayDi.DataSource = dsSanBayDi.Tables(0)
        Me.cbSanBayDi.DisplayMember = "MaSanBay"
        Me.cbSanBayDi.Text = ""

        Me.lbSanBayDi.Text = ""
    End Sub

    Private Sub cbSanBayDi_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSanBayDi.LostFocus
        Dim dsSanBayDen As DataSet
        Dim tb As New CTuyenBay
        dsSanBayDen = tb.LayCacSBDenKoThoa(cbSanBayDi.Text)
        tb = Nothing
        Me.cbSanBayDen.DataSource = dsSanBayDen.Tables(0)
        Me.cbSanBayDen.DisplayMember = "MaSanBay"

        Dim sb As New CSanBay
        Me.lbSanBayDi.Text = sb.LayTenSanBay(cbSanBayDi.Text)
        sb = Nothing
    End Sub

    Private Sub cbSanBayDi_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSanBayDi.GotFocus
        cbSanBayDen.Text = ""
        lbSanBayDen.Text = ""
    End Sub

    Private Sub cbSanBayDen_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSanBayDen.LostFocus
        Dim sb As New CSanBay
        Me.lbSanBayDen.Text = sb.LayTenSanBay(cbSanBayDen.Text)
        sb = Nothing
    End Sub

    Private Sub cbSanBayDi_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSanBayDi.SelectedIndexChanged
        Dim sb As New CSanBay
        Me.lbSanBayDi.Text = sb.LayTenSanBay(cbSanBayDi.Text)
        sb = Nothing
        If (cbSanBayDi.Text <> "" And cbSanBayDen.Text <> "") Then
            txtMaTuyenBay.Text = cbSanBayDi.Text & "-" & cbSanBayDen.Text
        Else
            txtMaTuyenBay.Text = ""
        End If
    End Sub

    Private Sub cbSanBayDen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSanBayDen.SelectedIndexChanged
        Dim sb As New CSanBay
        Me.lbSanBayDen.Text = sb.LayTenSanBay(cbSanBayDen.Text)
        sb = Nothing
        If (cbSanBayDi.Text <> "" And cbSanBayDen.Text <> "") Then
            txtMaTuyenBay.Text = cbSanBayDi.Text & "-" & cbSanBayDen.Text
        Else
            txtMaTuyenBay.Text = ""
        End If
    End Sub

    Private Sub bThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bThem.Click
        Dim tb As New CTuyenBay
        tb.ThemTuyenBay(txtMaTuyenBay.Text, cbSanBayDi.Text, cbSanBayDen.Text)
        tb = Nothing
    End Sub

    Private Sub bThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bThoat.Click
        Me.Close()
    End Sub

End Class
