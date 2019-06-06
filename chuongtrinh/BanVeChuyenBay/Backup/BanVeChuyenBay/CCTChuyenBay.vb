Public Class CCTChuyenBay
    Inherits CBang
    Public Sub ThemCTChuyenBay(ByVal MaChuyenBay As String, _
                               ByVal SanBayTrungGian As String, _
                               ByVal ThoiGianDung As Integer, _
                               ByVal GhiChu As String)
        Dim strSQL As String
        strSQL = "insert into ChiTietChuyenBay(MaChuyenBay,SanBayTrungGian,ThoiGianDung,GhiChu) values('" & MaChuyenBay & "','" & SanBayTrungGian & "','" & ThoiGianDung & "','" & GhiChu & "')"
        ExecuteUpdateSQL(strSQL)
    End Sub

    Public Function LayTieuDeCTCB() As DataSet
        Dim strSQL As String
        Dim ds As DataSet
        strSQL = "select SanBayTrungGian as [Sân Bay Trung Gian],ThoiGianDung as [Thời Gian Dừng],GhiChu as [Ghi Chú] from ChiTietChuyenBay"
        ds = OpenDataSet(strSQL)
        ds.Clear()
        LayTieuDeCTCB = ds
    End Function
End Class
