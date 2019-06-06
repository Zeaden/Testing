Public Class CTinhTrangVe
    Inherits CBang

    Public Sub ThemTinhTrangVe(ByVal MaChuyenBay As String, _
                               ByVal SoGheTrong As Integer)
        Dim strSQL As String
        strSQL = "Insert into TinhTrangVe(MaChuyenBay,SoGheTrong) values ('" & MaChuyenBay & "'," & SoGheTrong & ")"
        ExecuteUpdateSQL(strSQL)
    End Sub

    Public Sub CapNhatTinhTrangVe(ByVal MaChuyenBay As String, _
                                  ByVal Loai As Boolean)
        Dim strSQL As String
        Dim ds As DataSet
        strSQL = "select SoGheTrong from TinhTrangVe where MaChuyenBay='" & MaChuyenBay & "'"
        ds = OpenDataSet(strSQL)
        Dim SoGheTrong As Integer
        Dim SoGheDat As Integer
        SoGheTrong = ds.Tables(0).Rows(0)(0) - 1

        If (Loai = True) Then 'cap nhat khi co nguoi mua ve
            strSQL = "update TinhTrangVe set SoGheTrong=" & SoGheTrong & " where MaChuyenBay='" & MaChuyenBay & "'"
            ExecuteUpdateSQL(strSQL)
        Else
            strSQL = "update TinhTrangVe set SoGheTrong=" & SoGheTrong & " and SoGheDat=" & SoGheDat & "where MaChuyenBay='" & MaChuyenBay & "'"
            ExecuteUpdateSQL(strSQL)
        End If
    End Sub

    Public Function LayTinhTrangVe(ByVal MaChuyenBay As String) As String
        Dim tt As String
        Dim soghetrong As Integer
        Dim strSQL As String
        strSQL = "select SoGheTrong from TinhTrangVe where MaChuyenBay='" & MaChuyenBay & "'"
        soghetrong = LaySo(strSQL)
        If (soghetrong > 0) Then
            tt = "Còn chỗ"
        Else
            tt = "Đã hết chỗ"
        End If
        LayTinhTrangVe = tt
    End Function
End Class
