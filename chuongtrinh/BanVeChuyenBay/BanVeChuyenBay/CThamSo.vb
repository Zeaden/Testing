Public Class CThamSo
    Inherits CBang

    Public Function LayQD1() As DataSet
        Dim ds As DataSet
        Dim strSQL As String
        strSQL = "select ThoiGianBayToiThieu,SoSanBayTrungGianToiDa,ThoiGianDungToiThieu,ThoiGianDungToiDa from Thamso"
        ds = OpenDataSet(strSQL)
        LayQD1 = ds
    End Function

    Public Sub CapNhatQD1(ByVal ThoiGianBayToiThieu As Integer, _
                          ByVal SoSanBayTrungGianToiDa As Integer, _
                          ByVal ThoiGianDungToiThieu As Integer, _
                          ByVal ThoiGianDungToiDa As Integer)
        Dim strSQL As String
        strSQL = "update ThamSo set ThoiGianBayToiThieu=" & ThoiGianBayToiThieu & ",SoSanBayTrungGianToiDa=" & SoSanBayTrungGianToiDa & ",ThoiGianDungToiThieu=" & ThoiGianDungToiThieu & ",ThoiGianDungToiDa=" & ThoiGianDungToiDa
        ExecuteUpdateSQL(strSQL)
    End Sub

    Public Function LayBangDonGia() As DataSet
        Dim ds As DataSet
        Dim strSQL As String
        'strSQL = "select sb1.TenSanBay,sb2.TenSanBay,hv.TenHangVe,dg.DonGia from SanBay sb1, SanBay sb2, HangVe hv1, HangVe hv2, DonGia dg, TuyenBay tb where sb1.MaSanBay=tb.SanBayDen and sb2.MaSanBay=tb.SanBayDi and dg.MaHangVe=hv.MaHangVe and dg.MaTuyenBay=tb.MaTuyenBay"
        strSQL = "select cb.MaChuyenBay as [Sân Bay Ði],cb.MaTuyenBay as [Sân Bay Ð?n],cb.NgayGio as [H?ng Vé],cb.ThoiGianBay as [Ðon Giá] from ChuyenBay cb"
        ds = OpenDataSet(strSQL)
        ds.Clear()
        LayBangDonGia = ds
    End Function
End Class
