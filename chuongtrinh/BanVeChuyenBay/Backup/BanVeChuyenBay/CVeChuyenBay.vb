Public Class CVeChuyenBay
    Inherits CBang
    Public Sub ThemVeChuyenBay(ByVal MaChuyenBay As String, _
                               ByVal MaHangVe As String, _
                               ByVal MaHanhKhach As String, _
                               ByVal GiaTien As Double)
        Dim strSQL As String
        strSQL = "Insert into VeChuyenBay(MaChuyenBay,MaHangVe,MaHanhKhach,GiaTien) values ('" & MaChuyenBay & "','" & MaHangVe & "','" & MaHanhKhach & "'," & GiaTien & ")"
        ExecuteUpdateSQL(strSQL)
    End Sub
End Class
