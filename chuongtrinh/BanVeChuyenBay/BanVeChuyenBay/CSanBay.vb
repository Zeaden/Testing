Public Class CSanBay
    Inherits CBang

    Public Sub ThemSanBay(ByVal MaSanBay As String, _
                                ByVal TenSanBay As String)
        Dim strSQL As String
        strSQL = "Insert into SanBay(MaSanBay,TenSanBay) values ('" & MaSanBay & "','" & TenSanBay & "')"
        ExecuteUpdateSQL(strSQL)
    End Sub

    Public Sub XoaSanBay(ByVal MaSanBay As String)
        Dim strSQL As String
        strSQL = "delete from SanBay where MaSanBay=" & MaSanBay & ""
        ExecuteUpdateSQL(strSQL)
    End Sub

    Public Sub SuaSanBay(ByVal MaSanBay As String, _
                            ByVal TenSanBay As String)
        Dim strSQL As String
        strSQL = "update SanBay(MaSanBay,TenSanBay) values('" & MaSanBay & "','" & TenSanBay & "')"
        ExecuteUpdateSQL(strSQL)
    End Sub

    Public Function LayDanhSachSanBay() As DataSet
        Dim strSQL As String
        Dim ds As DataSet
        strSQL = "select MaSanBay ,TenSanBay from SanBay"
        ds = OpenDataSet(strSQL)
        LayDanhSachSanBay = ds
    End Function

    Public Function LayTieuDeSanBay() As DataSet
        Dim ds As DataSet
        ds = LayDanhSachSanBay()
        ds.Clear()
        LayTieuDeSanBay = ds
    End Function

    Public Sub CapNhatBangSanBay(ByVal ds As DataSet)
        'Dim dsChange As DataSet
        'dsChange = ds.GetChanges()
        'If (dsChange Is Nothing) Then
        '    Exit Sub
        'End If
        'Dim modifiedRows As Integer
        'modifiedRows = da.Update(dsChange)
        'ds.AcceptChanges()
    End Sub
    Public Function LayTenSanBay(ByVal ma As String) As String
        Dim ten As String
        Dim strSQL As String
        strSQL = "select TenSanBay from SanBay where MaSanBay='" & ma & "'"
        ten = LayTen(strSQL)
        LayTenSanBay = ten
    End Function

    Public Function LayDanhSachSanBay1() As DataSet
        Dim strSQL As String
        Dim ds As DataSet
        strSQL = "select MaSanBay as [Mã Sân Bay] ,TenSanBay as [Tên Sân Bay] from SanBay"
        ds = OpenDataSet(strSQL)
        LayDanhSachSanBay1 = ds
    End Function
End Class
