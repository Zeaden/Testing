Public Class ThemHanhKhach
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMaHanhKhach As System.Windows.Forms.TextBox
    Friend WithEvents txtTenHanhKhach As System.Windows.Forms.TextBox
    Friend WithEvents txtCMND As System.Windows.Forms.TextBox
    Friend WithEvents txtDienThoai As System.Windows.Forms.TextBox
    Friend WithEvents bThem As System.Windows.Forms.Button
    Friend WithEvents bThoat As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ThemHanhKhach))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMaHanhKhach = New System.Windows.Forms.TextBox
        Me.txtTenHanhKhach = New System.Windows.Forms.TextBox
        Me.txtCMND = New System.Windows.Forms.TextBox
        Me.txtDienThoai = New System.Windows.Forms.TextBox
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
        Me.Label1.Location = New System.Drawing.Point(112, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HÀNH KHÁCH MỚI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(56, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Hành Khách"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(56, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên Hành Khách"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(56, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CMND"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(56, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Điện Thoại"
        '
        'txtMaHanhKhach
        '
        Me.txtMaHanhKhach.ForeColor = System.Drawing.Color.Blue
        Me.txtMaHanhKhach.Location = New System.Drawing.Point(208, 88)
        Me.txtMaHanhKhach.Name = "txtMaHanhKhach"
        Me.txtMaHanhKhach.Size = New System.Drawing.Size(144, 26)
        Me.txtMaHanhKhach.TabIndex = 5
        Me.txtMaHanhKhach.Text = ""
        '
        'txtTenHanhKhach
        '
        Me.txtTenHanhKhach.ForeColor = System.Drawing.Color.Blue
        Me.txtTenHanhKhach.Location = New System.Drawing.Point(208, 128)
        Me.txtTenHanhKhach.Name = "txtTenHanhKhach"
        Me.txtTenHanhKhach.Size = New System.Drawing.Size(144, 26)
        Me.txtTenHanhKhach.TabIndex = 6
        Me.txtTenHanhKhach.Text = ""
        '
        'txtCMND
        '
        Me.txtCMND.ForeColor = System.Drawing.Color.Blue
        Me.txtCMND.Location = New System.Drawing.Point(208, 168)
        Me.txtCMND.Name = "txtCMND"
        Me.txtCMND.Size = New System.Drawing.Size(144, 26)
        Me.txtCMND.TabIndex = 7
        Me.txtCMND.Text = ""
        '
        'txtDienThoai
        '
        Me.txtDienThoai.ForeColor = System.Drawing.Color.Blue
        Me.txtDienThoai.Location = New System.Drawing.Point(208, 208)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Size = New System.Drawing.Size(144, 26)
        Me.txtDienThoai.TabIndex = 8
        Me.txtDienThoai.Text = ""
        '
        'bThem
        '
        Me.bThem.Location = New System.Drawing.Point(96, 256)
        Me.bThem.Name = "bThem"
        Me.bThem.Size = New System.Drawing.Size(75, 32)
        Me.bThem.TabIndex = 9
        Me.bThem.Text = "Thêm"
        '
        'bThoat
        '
        Me.bThoat.Location = New System.Drawing.Point(280, 256)
        Me.bThoat.Name = "bThoat"
        Me.bThoat.Size = New System.Drawing.Size(75, 32)
        Me.bThoat.TabIndex = 10
        Me.bThoat.Text = "Thoát"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(56, 256)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(240, 256)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 40
        Me.PictureBox3.TabStop = False
        '
        'ThemHanhKhach
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 19)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.ClientSize = New System.Drawing.Size(400, 326)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bThoat)
        Me.Controls.Add(Me.bThem)
        Me.Controls.Add(Me.txtDienThoai)
        Me.Controls.Add(Me.txtCMND)
        Me.Controls.Add(Me.txtTenHanhKhach)
        Me.Controls.Add(Me.txtMaHanhKhach)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Name = "ThemHanhKhach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ThemHanhKhach"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub bThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bThem.Click
        If txtMaHanhKhach.Text = "" Then
            MsgBox("Hành khách chưa có mã")
            Exit Sub
        End If
        Dim hk As New CHanhKhach
        hk.ThemHanhKhachMoi(txtMaHanhKhach.Text, txtTenHanhKhach.Text, txtCMND.Text, txtDienThoai.Text)
        hk = Nothing
    End Sub

    Private Sub bThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bThoat.Click
        Me.Close()
    End Sub

    Private Sub txtMaHanhKhach_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMaHanhKhach.LostFocus
        Dim hk As New CHanhKhach

        hk = Nothing
    End Sub
End Class
