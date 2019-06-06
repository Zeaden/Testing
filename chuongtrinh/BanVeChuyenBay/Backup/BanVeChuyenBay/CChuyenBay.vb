Public Class CChuyenBay
    Inherits CBang
    Public Sub ThemChuyenBay(ByVal MaChuyenBay As String, _
                             ByVal MaTuyenBay As String, _
                             ByVal NgayGio As DateTime, _
                             ByVal ThoiGianBay As Integer, _
                             ByVal SoLuongGheHang1 As Integer, _
                             ByVal SoLuongGheHang2 As Integer)
        Dim strSQL As String
        strSQL = "Insert into ChuyenBay(MaChuyenBay,MaTuyenBay,NgayGio,ThoiGianBay,SoLuongGheHang1,SoLuongGheHang2) values ('" & MaChuyenBay & "','" & MaTuyenBay & "','" & NgayGio & "'," & ThoiGianBay & "," & SoLuongGheHang1 & "," & SoLuongGheHang2 & ")"
        ExecuteUpdateSQL(strSQL)
    End Sub

    Public Function LayMaCBSauNgay(ByVal NgayGio As DateTime) As DataSet
        Dim ds As DataSet
        Dim strSQL As String
        strSQL = "select MaChuyenBay from ChuyenBay" ' where NgayGio>='" & NgayGio & "'"
        ds = OpenDataSet(strSQL)
        LayMaCBSauNgay = ds
    End Function

    Public Function LayDSChuyenBayTheoMa(ByVal ma As String) As DataSet
        Dim ds As DataSet
        Dim strSQL As String
        strSQL = "select sb1.TenSanBay,sb2.TenSanBay,cb.NgayGio,tb.MaTuyenBay from ChuyenBay cb,TuyenBay tb,SanBay sb1,SanBay sb2 where sb1.MaSanBay=tb.SanBayDi and sb2.MaSanBay=tb.SanBayDen and cb.MaTuyenBay=tb.MaTuyenBay and MaChuyenBay='" & ma & "'"
        ds = OpenDataSet(strSQL)
        LayDSChuyenBayTheoMa = ds
    End Function

    Public Function LayTDTraCuu(ByVal loai As Boolean) As DataSet
        Dim ds As DataSet
        Dim strSQL As String
        strSQL = "select sb1.TenSanBay as [Sân Bay Đi],sb2.TenSanBay as [Sân Bay Đến],cb.NgayGio as [Khởi Hành],cb.ThoiGianBay as [Thời Gian],ttv.SoGheTrong as [Số Ghế Trống],ttv.SoGheDat as [Số Ghế Đặt] from ChuyenBay cb, SanBay sb1, SanBay sb2, TinhTrangVe ttv, TuyenBay tb where tb.MaTuyenBay=cb.MaTuyenBay and tb.SanBayDi=sb1.MaSanBay and tb.SanBayDen=sb2.MaSanBay and ttv.MaChuyenBay=cb.MaChuyenBay"
        ds = OpenDataSet(strSQL)
        If (loai = True) Then 'chi lay tieu de
            ds.Clear()
        End If
        LayTDTraCuu = ds
    End Function

    Public Function TimChuyenBay(ByVal SanBayDi As String, _
                                 ByVal SanBayDen As String, _
                                 ByVal TuNgay As DateTime, _
                                 ByVal DenNgay As DateTime) As DataSet
        Dim strSQL As String
        Dim ds As DataSet
        strSQL = "select sb1.TenSanBay as [Sân Bay Đi],sb2.TenSanBay as [Sân Bay Đến],cb.NgayGio as [Khởi Hành],cb.ThoiGianBay as [Thời Gian],ttv.SoGheTrong as [Số Ghế Trống],ttv.SoGheDat as [Số Ghế Đặt] from SanBay sb1,SanBay sb2, ChuyenBay cb, TinhTrangVe ttv, TuyenBay tb where tb.SanBayDi=sb1.MaSanBay and tb.SanBayDen=sb2.MaSanBay and tb.MaTuyenBay=cb.MaTuyenBay and sb1.MaSanBay='" & SanBayDi & "' and sb2.MaSanBay='" & SanBayDen & "' and cb.MaChuyenBay=ttv.MaChuyenBay" ' and (cb.NgayGio between '" & TuNgay & "' and '" & DenNgay & "')"
        ds = OpenDataSet(strSQL)
        TimChuyenBay = ds
    End Function

    Public Function KiemTraChuyenBay(ByVal MaChuyenBay As String) As Boolean
        Dim strSQL As String
        Dim kq As Integer
        strSQL = "select count(*) from ChuyenBay where MaChuyenBay='" & MaChuyenBay & "'"
        kq = LaySo(strSQL)
        If (kq = 1) Then
            KiemTraChuyenBay = False
        Else
            KiemTraChuyenBay = True
        End If
    End Function
End Class
