Public Class ThayDoiQD1
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTGBayToiThieu As System.Windows.Forms.TextBox
    Friend WithEvents txtSoSBTGToiDa As System.Windows.Forms.TextBox
    Friend WithEvents txtTGDToiThieu As System.Windows.Forms.TextBox
    Friend WithEvents txtTGDToiDa As System.Windows.Forms.TextBox
    Friend WithEvents bCapNhat As System.Windows.Forms.Button
    Friend WithEvents bThoat As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ThayDoiQD1))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTGBayToiThieu = New System.Windows.Forms.TextBox
        Me.txtSoSBTGToiDa = New System.Windows.Forms.TextBox
        Me.txtTGDToiThieu = New System.Windows.Forms.TextBox
        Me.txtTGDToiDa = New System.Windows.Forms.TextBox
        Me.bCapNhat = New System.Windows.Forms.Button
        Me.bThoat = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(40, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Thời Gian Bay Tối Thiểu"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(40, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(216, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Số Sân Bay Trung Gian Tối Đa"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(40, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Thời Gian Dừng Tối Thiểu"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(40, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(216, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Thời Gian Dừng Tối Đa"
        '
        'txtTGBayToiThieu
        '
        Me.txtTGBayToiThieu.ForeColor = System.Drawing.Color.Blue
        Me.txtTGBayToiThieu.Location = New System.Drawing.Point(264, 120)
        Me.txtTGBayToiThieu.Name = "txtTGBayToiThieu"
        Me.txtTGBayToiThieu.TabIndex = 7
        Me.txtTGBayToiThieu.Text = ""
        '
        'txtSoSBTGToiDa
        '
        Me.txtSoSBTGToiDa.ForeColor = System.Drawing.Color.Blue
        Me.txtSoSBTGToiDa.Location = New System.Drawing.Point(264, 80)
        Me.txtSoSBTGToiDa.Name = "txtSoSBTGToiDa"
        Me.txtSoSBTGToiDa.TabIndex = 8
        Me.txtSoSBTGToiDa.Text = ""
        '
        'txtTGDToiThieu
        '
        Me.txtTGDToiThieu.ForeColor = System.Drawing.Color.Blue
        Me.txtTGDToiThieu.Location = New System.Drawing.Point(264, 160)
        Me.txtTGDToiThieu.Name = "txtTGDToiThieu"
        Me.txtTGDToiThieu.TabIndex = 9
        Me.txtTGDToiThieu.Text = ""
        '
        'txtTGDToiDa
        '
        Me.txtTGDToiDa.ForeColor = System.Drawing.Color.Blue
        Me.txtTGDToiDa.Location = New System.Drawing.Point(264, 200)
        Me.txtTGDToiDa.Name = "txtTGDToiDa"
        Me.txtTGDToiDa.TabIndex = 10
        Me.txtTGDToiDa.Text = ""
        '
        'bCapNhat
        '
        Me.bCapNhat.Location = New System.Drawing.Point(80, 240)
        Me.bCapNhat.Name = "bCapNhat"
        Me.bCapNhat.Size = New System.Drawing.Size(75, 32)
        Me.bCapNhat.TabIndex = 11
        Me.bCapNhat.Text = "Cập nhật"
        '
        'bThoat
        '
        Me.bThoat.Location = New System.Drawing.Point(248, 240)
        Me.bThoat.Name = "bThoat"
        Me.bThoat.Size = New System.Drawing.Size(75, 32)
        Me.bThoat.TabIndex = 12
        Me.bThoat.Text = "Thoát"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(40, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Thời Gian Bay Tối Thiểu"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(104, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(272, 48)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "QUY ĐỊNH MỘT CHUYẾN BAY"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.PictureBox2.Location = New System.Drawing.Point(48, 240)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(216, 240)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 32
        Me.PictureBox3.TabStop = False
        '
        'ThayDoiQD1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 19)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.ClientSize = New System.Drawing.Size(384, 286)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bThoat)
        Me.Controls.Add(Me.bCapNhat)
        Me.Controls.Add(Me.txtTGDToiDa)
        Me.Controls.Add(Me.txtTGDToiThieu)
        Me.Controls.Add(Me.txtSoSBTGToiDa)
        Me.Controls.Add(Me.txtTGBayToiThieu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Name = "ThayDoiQD1"
        Me.Text = "ThayDoiQD1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ThayDoiQD1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ts As New CThamSo
        Dim ds As DataSet
        ds = ts.LayQD1()
        Me.txtTGBayToiThieu.Text = ds.Tables(0).Rows(0)(0)
        Me.txtSoSBTGToiDa.Text = ds.Tables(0).Rows(0)(1)
        Me.txtTGDToiThieu.Text = ds.Tables(0).Rows(0)(2)
        Me.txtTGDToiDa.Text = ds.Tables(0).Rows(0)(3)
    End Sub

   
    Private Sub bCapNhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCapNhat.Click
        If (MsgBox("Bạn muốn cập nhật lại các giá trị này?", MsgBoxStyle.OKCancel) = MsgBoxResult.OK) Then
            Dim ts As New CThamSo
            ts.CapNhatQD1(txtTGBayToiThieu.Text, txtSoSBTGToiDa.Text, txtTGDToiThieu.Text, txtTGDToiDa.Text)
            ts = Nothing
        End If
    End Sub

    Private Sub bThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bThoat.Click
        Me.Close()
    End Sub
End Class
