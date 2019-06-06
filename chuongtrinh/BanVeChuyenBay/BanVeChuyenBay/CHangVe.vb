Public Class CHangVe
    Inherits CBang

    Public Sub ThemHangVe(ByVal MaHangVe As String, _
                          ByVal TenHangVe As String)
        Dim strSQL As String
        strSQL = "Insert into HangVe(MaHangVe,TenHangVe) values ('" & MaHangVe & "','" & TenHangVe & "')"
        ExecuteUpdateSQL(strSQL)
    End Sub

    Public Function LayDSHangVe() As DataSet
        Dim strSQL As String
        strSQL = "select MaHangVe,TenHangVe from HangVe"
        Dim ds As DataSet
        ds = OpenDataSet(strSQL)
        LayDSHangVe = ds
    End Function

    Public Function LayTenHangVe(ByVal ma As String) As String
        Dim strSQL As String
        strSQL = "select TenHangVe from HangVe where MaHangVe='" & ma & "'"
        Dim ten As String
        ten = LayTen(strSQL)
        LayTenHangVe = ten
    End Function
End Class
