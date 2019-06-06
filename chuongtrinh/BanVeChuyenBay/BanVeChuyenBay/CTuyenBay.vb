Public Class CTuyenBay
    Inherits CBang
    Public Function ChonTuyenBay(ByVal loai As String, ByVal dk As String) As DataSet
        Dim ds As DataSet
        Dim strSQL As String
        strSQL = "select SanBayDi,SanBayDen from TuyenBay"
        If (dk <> "") Then
            If (loai = True) Then
                strSQL += " where SanBayDi='"
            Else
                strSQL += "where SanBayDen='"
            End If
            strSQL += dk & "'"
        End If
        ds = OpenDataSet(strSQL)
        ChonTuyenBay = ds
    End Function
    Public Function ChonTuyenBayTuTen(ByVal loai As Boolean, ByVal dk As String) As DataSet
        Dim ds As DataSet
        Dim strSQL As String
        strSQL = "select sb1.TenSanBay from SanBay sb1 where sb1.MaSanBay in (select "
        If (loai = True) Then
            strSQL += "tb.SanBayDen"
        Else
            strSQL += "tb.SanBayDi"
        End If
        strSQL += " from SanBay sb2,TuyenBay tb where "
        If (loai = True) Then 'chọn theo sân bay đi
            strSQL += "sb2.MaSanBay=tb.SanBayDi"
        Else 'chọn theo sân bay đến
            strSQL += "sb2.MaSanBay=tb.SanBayDen"
        End If
        strSQL += " and TenSanBay='" & dk & "'" & ")"
        ds = OpenDataSet(strSQL)

        ChonTuyenBayTuTen = ds
    End Function

    Public Function LayMaTuyenBay(ByVal SBDi As String, ByVal SBDen As String) As String
        Dim ma As String
        Dim strSQL As String
        strSQL = "select MaTuyenBay from TuyenBay where SanBayDi='" & SBDi & "' and SanBayDen='" & SBDen & "'"
        ma = LayTen(strSQL)
        LayMaTuyenBay = ma
    End Function

    Public Function LayCacSBDenKoThoa(ByVal SBDi As String) As DataSet
        Dim strSQL As String
        strSQL = "select sb.MaSanBay from SanBay sb where sb.MaSanBay <> '" & SBDi & "'and sb.MaSanBay not in (select tb.SanBayDen from TuyenBay tb where tb.SanBayDi='" & SBDi & "')"
        Dim ds As DataSet
        ds = OpenDataSet(strSQL)
        LayCacSBDenKoThoa = ds
    End Function

    Public Sub ThemTuyenBay(ByVal MaTuyenBay As String, _
                               ByVal SanBayDi As String, _
                               ByVal SanBayDen As String)
        Dim strSQL As String
        strSQL = "Insert into TuyenBay(MaTuyenBay,SanBayDi, SanBayDen) values ('" & MaTuyenBay & "','" & SanBayDi & "','" & SanBayDen & "')"
        ExecuteUpdateSQL(strSQL)
    End Sub

    Public Function LayDSTuyenBay() As DataSet
        Dim strSQL As String
        Dim ds As DataSet
        strSQL = "select tb.MaTuyenBay as [Mã Tuyến Bay],sb1.TenSanBay as [Sân Bay Đi],sb2.TenSanBay as [Sân Bay Đến] from TuyenBay tb,SanBay sb1,SanBay sb2 where tb.SanBayDi=sb1.MaSanBay and tb.SanBayDen=sb2.MaSanBay"
        ds = OpenDataSet(strSQL)
        LayDSTuyenBay = ds
    End Function
End Class
