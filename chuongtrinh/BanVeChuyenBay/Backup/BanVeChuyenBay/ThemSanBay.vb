Public Class ThemSanBay
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
    Friend WithEvents txtMaSanBay As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSanBay As System.Windows.Forms.TextBox
    Friend WithEvents bThem As System.Windows.Forms.Button
    Friend WithEvents bTaoMoi As System.Windows.Forms.Button
    Friend WithEvents bThoat As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ThemSanBay))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtMaSanBay = New System.Windows.Forms.TextBox
        Me.txtTenSanBay = New System.Windows.Forms.TextBox
        Me.bThem = New System.Windows.Forms.Button
        Me.bTaoMoi = New System.Windows.Forms.Button
        Me.bThoat = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "THÊM SÂN BAY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(64, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Sân Bay"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(64, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên Sân Bay"
        '
        'txtMaSanBay
        '
        Me.txtMaSanBay.ForeColor = System.Drawing.Color.Blue
        Me.txtMaSanBay.Location = New System.Drawing.Point(176, 80)
        Me.txtMaSanBay.Name = "txtMaSanBay"
        Me.txtMaSanBay.Size = New System.Drawing.Size(216, 26)
        Me.txtMaSanBay.TabIndex = 3
        Me.txtMaSanBay.Text = ""
        '
        'txtTenSanBay
        '
        Me.txtTenSanBay.ForeColor = System.Drawing.Color.Blue
        Me.txtTenSanBay.Location = New System.Drawing.Point(176, 120)
        Me.txtTenSanBay.Name = "txtTenSanBay"
        Me.txtTenSanBay.Size = New System.Drawing.Size(216, 26)
        Me.txtTenSanBay.TabIndex = 4
        Me.txtTenSanBay.Text = ""
        '
        'bThem
        '
        Me.bThem.Location = New System.Drawing.Point(64, 168)
        Me.bThem.Name = "bThem"
        Me.bThem.Size = New System.Drawing.Size(75, 32)
        Me.bThem.TabIndex = 5
        Me.bThem.Text = "Thêm"
        '
        'bTaoMoi
        '
        Me.bTaoMoi.Location = New System.Drawing.Point(192, 168)
        Me.bTaoMoi.Name = "bTaoMoi"
        Me.bTaoMoi.Size = New System.Drawing.Size(75, 32)
        Me.bTaoMoi.TabIndex = 6
        Me.bTaoMoi.Text = "Tạo Mới"
        '
        'bThoat
        '
        Me.bThoat.Location = New System.Drawing.Point(320, 168)
        Me.bThoat.Name = "bThoat"
        Me.bThoat.Size = New System.Drawing.Size(75, 32)
        Me.bThoat.TabIndex = 7
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
        Me.PictureBox2.Location = New System.Drawing.Point(24, 168)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(152, 168)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 32
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(280, 168)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.TabIndex = 33
        Me.PictureBox4.TabStop = False
        '
        'ThemSanBay
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 19)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.ClientSize = New System.Drawing.Size(464, 230)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bThoat)
        Me.Controls.Add(Me.bTaoMoi)
        Me.Controls.Add(Me.bThem)
        Me.Controls.Add(Me.txtTenSanBay)
        Me.Controls.Add(Me.txtMaSanBay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Name = "ThemSanBay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ThemSanBay"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub bThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bThoat.Click
        Me.Close()
    End Sub

    Private Sub bThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bThem.Click
        Dim sb As New CSanBay
        sb.ThemSanBay(txtMaSanBay.Text, txtTenSanBay.Text)
        sb = Nothing
    End Sub

    Private Sub bTaoMoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bTaoMoi.Click
        txtMaSanBay.Text = ""
        txtTenSanBay.Text = ""
    End Sub
End Class
