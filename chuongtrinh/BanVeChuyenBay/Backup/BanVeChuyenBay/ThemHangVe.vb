Public Class ThemHangVe
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
    Friend WithEvents bThoat As System.Windows.Forms.Button
    Friend WithEvents bTaoMoi As System.Windows.Forms.Button
    Friend WithEvents bThem As System.Windows.Forms.Button
    Friend WithEvents txtTenHangVe As System.Windows.Forms.TextBox
    Friend WithEvents txtMaHangVe As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ThemHangVe))
        Me.Label1 = New System.Windows.Forms.Label
        Me.bThoat = New System.Windows.Forms.Button
        Me.bTaoMoi = New System.Windows.Forms.Button
        Me.bThem = New System.Windows.Forms.Button
        Me.txtTenHangVe = New System.Windows.Forms.TextBox
        Me.txtMaHangVe = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "THÊM HẠNG VÉ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bThoat
        '
        Me.bThoat.Location = New System.Drawing.Point(304, 168)
        Me.bThoat.Name = "bThoat"
        Me.bThoat.Size = New System.Drawing.Size(75, 32)
        Me.bThoat.TabIndex = 14
        Me.bThoat.Text = "Thoát"
        '
        'bTaoMoi
        '
        Me.bTaoMoi.Location = New System.Drawing.Point(176, 168)
        Me.bTaoMoi.Name = "bTaoMoi"
        Me.bTaoMoi.Size = New System.Drawing.Size(75, 32)
        Me.bTaoMoi.TabIndex = 13
        Me.bTaoMoi.Text = "Tạo Mới"
        '
        'bThem
        '
        Me.bThem.Location = New System.Drawing.Point(56, 168)
        Me.bThem.Name = "bThem"
        Me.bThem.Size = New System.Drawing.Size(75, 32)
        Me.bThem.TabIndex = 12
        Me.bThem.Text = "Thêm"
        '
        'txtTenHangVe
        '
        Me.txtTenHangVe.ForeColor = System.Drawing.Color.Blue
        Me.txtTenHangVe.Location = New System.Drawing.Point(200, 120)
        Me.txtTenHangVe.Name = "txtTenHangVe"
        Me.txtTenHangVe.Size = New System.Drawing.Size(176, 26)
        Me.txtTenHangVe.TabIndex = 11
        Me.txtTenHangVe.Text = ""
        '
        'txtMaHangVe
        '
        Me.txtMaHangVe.ForeColor = System.Drawing.Color.Blue
        Me.txtMaHangVe.Location = New System.Drawing.Point(200, 80)
        Me.txtMaHangVe.Name = "txtMaHangVe"
        Me.txtMaHangVe.Size = New System.Drawing.Size(176, 26)
        Me.txtMaHangVe.TabIndex = 10
        Me.txtMaHangVe.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(56, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Tên Hạng Vé"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(56, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Mã Hạng Vé"
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
        Me.PictureBox3.Location = New System.Drawing.Point(144, 168)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 32
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(272, 168)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.TabIndex = 33
        Me.PictureBox4.TabStop = False
        '
        'ThemHangVe
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 19)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.ClientSize = New System.Drawing.Size(408, 230)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bThoat)
        Me.Controls.Add(Me.bTaoMoi)
        Me.Controls.Add(Me.bThem)
        Me.Controls.Add(Me.txtTenHangVe)
        Me.Controls.Add(Me.txtMaHangVe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Name = "ThemHangVe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ThemHangVe"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub bThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bThem.Click
        Dim hv As New CHangVe
        hv.ThemHangVe(txtMaHangVe.Text, txtTenHangVe.Text)
    End Sub

    Private Sub bThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bThoat.Click
        Me.Close()
    End Sub

    Private Sub bTaoMoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bTaoMoi.Click
        txtTenHangVe.Text = ""
        txtMaHangVe.Text = ""
    End Sub
End Class
