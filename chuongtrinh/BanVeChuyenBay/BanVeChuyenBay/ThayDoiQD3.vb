Public Class ThayDoiQD3
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
    Friend WithEvents bCapNhat As System.Windows.Forms.Button
    Friend WithEvents txtSoSBTGToiDa As System.Windows.Forms.TextBox
    Friend WithEvents txtTGBayToiThieu As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ThayDoiQD3))
        Me.bThoat = New System.Windows.Forms.Button
        Me.bCapNhat = New System.Windows.Forms.Button
        Me.txtSoSBTGToiDa = New System.Windows.Forms.TextBox
        Me.txtTGBayToiThieu = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'bThoat
        '
        Me.bThoat.Location = New System.Drawing.Point(312, 160)
        Me.bThoat.Name = "bThoat"
        Me.bThoat.Size = New System.Drawing.Size(75, 32)
        Me.bThoat.TabIndex = 19
        Me.bThoat.Text = "Thoát"
        '
        'bCapNhat
        '
        Me.bCapNhat.Location = New System.Drawing.Point(144, 160)
        Me.bCapNhat.Name = "bCapNhat"
        Me.bCapNhat.Size = New System.Drawing.Size(75, 32)
        Me.bCapNhat.TabIndex = 18
        Me.bCapNhat.Text = "Cập nhật"
        '
        'txtSoSBTGToiDa
        '
        Me.txtSoSBTGToiDa.ForeColor = System.Drawing.Color.Blue
        Me.txtSoSBTGToiDa.Location = New System.Drawing.Point(352, 112)
        Me.txtSoSBTGToiDa.Name = "txtSoSBTGToiDa"
        Me.txtSoSBTGToiDa.TabIndex = 17
        Me.txtSoSBTGToiDa.Text = ""
        '
        'txtTGBayToiThieu
        '
        Me.txtTGBayToiThieu.ForeColor = System.Drawing.Color.Blue
        Me.txtTGBayToiThieu.Location = New System.Drawing.Point(352, 72)
        Me.txtTGBayToiThieu.Name = "txtTGBayToiThieu"
        Me.txtTGBayToiThieu.TabIndex = 16
        Me.txtTGBayToiThieu.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(56, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(280, 23)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Thời Gian Chậm Nhất Khi Hủy Đặt Vé"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(56, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(280, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Thời Gian Chậm Nhất Khi Đặt Vé"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 40)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "QUY ĐỊNH HẠN ĐẶT VÉ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(104, 160)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(272, 160)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 33
        Me.PictureBox3.TabStop = False
        '
        'ThayDoiQD3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 19)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.ClientSize = New System.Drawing.Size(480, 206)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bThoat)
        Me.Controls.Add(Me.bCapNhat)
        Me.Controls.Add(Me.txtSoSBTGToiDa)
        Me.Controls.Add(Me.txtTGBayToiThieu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Name = "ThayDoiQD3"
        Me.Text = "ThayDoiQD3"
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
