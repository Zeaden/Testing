Public Class CPhieuDatCho
    Inherits CBang
    Public Sub ThemPhieuDatCho(ByVal MaChuyenBay As String, _
                               ByVal MaHangVe As String, _
                               ByVal MaHanhKhach As String, _
                               ByVal GiaTien As Double, _
                               ByVal NgayDat As DateTime)
        Dim strSQL As String
        strSQL = "Insert into PhieuDatCho(MaChuyenBay,MaHanhKhach,MaHangVe,GiaTien,NgayDat) values ('" & MaChuyenBay & "','" & MaHanhKhach & "','" & MaHangVe & "'," & GiaTien & ",'" & NgayDat & "')"
        ExecuteUpdateSQL(strSQL)

        'cap nhat tinh trang ve
        strSQL = "update TinhTrangVe set SoGheDat=SoGheDat+1 where MaChuyenBay='" & MaChuyenBay & "'"
        ExecuteUpdateSQL(strSQL)
    End Sub
End Class
