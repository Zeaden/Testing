Public Class CHanhKhach
    Inherits CBang

    Public Sub ThemHanhKhachMoi(ByVal MaHanhKhach As String, _
                                ByVal TenHanhKhach As String, _
                                ByVal CMND As String, _
                                ByVal DienThoai As String)
        If (TenHanhKhach = "") Then
            TenHanhKhach = " "
        End If
        If (CMND = "") Then
            CMND = " "
        End If
        If (DienThoai = "") Then
            DienThoai = " "
        End If

        Dim strSQL As String
        strSQL = "Insert into HanhKhach(MaHanhKhach,TenHanhKhach,CMND,DienThoai) values ('" & MaHanhKhach & "','" & TenHanhKhach & "','" & CMND & "','" & DienThoai & "')"
        ExecuteUpdateSQL(strSQL)
    End Sub

    Public Function LayHanhKhachTuMa(ByVal ma As String) As DataSet
        Dim ds As DataSet
        Dim strSQL As String
        strSQL = "select TenHanhKhach,CMND,DienThoai from HanhKhach where MaHanhKhach='" & ma & "'"
        ds = OpenDataSet(strSQL)
        LayHanhKhachTuMa = ds
    End Function
End Class
