Public Class CDonGia
    Inherits CBang
    Public Function LayDonGia(ByVal MaTuyenBay As String, _
                              ByVal MaHangVe As String) As Double
        Dim strSQL As String
        strSQL = "select DonGia from DonGia where MaTuyenBay='" & MaTuyenBay & "' and MaHangVe='" & MaHangVe & "'"
        Dim gia As Double
        gia = LaySo(strSQL)
        LayDonGia = gia
    End Function
End Class
