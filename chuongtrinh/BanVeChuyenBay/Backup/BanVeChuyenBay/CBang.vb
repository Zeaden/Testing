Imports System.Data.OleDb
Public Class CBang
    Protected strConnectionString = _
    "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" _
    + System.Windows.Forms.Application.StartupPath + "\qlcb.mdb"

    Protected Sub ExecuteUpdateSQL(ByVal strSQL As String)

        Dim cn As OleDbConnection = New OleDbConnection(strConnectionString)
        Dim cmd As OleDbCommand = New OleDbCommand(strSQL, cn)
        cmd.CommandType = CommandType.Text

        cn.Open()
        If (cn.State = ConnectionState.Open) Then
            cmd.ExecuteNonQuery()
        End If
        cn.Close()
    End Sub

    Protected Function OpenDataSet(ByVal strSQL As String) As DataSet
        Dim cn As New OleDbConnection(strConnectionString)
        cn.Open()
        Dim da As New OleDbDataAdapter(strSQL, cn)
        Dim ds As New DataSet
        ds.Clear()
        da.Fill(ds)
        cn.Close()
        OpenDataSet = ds
    End Function

    Public Sub UpdateTable(ByVal ds As DataSet)

    End Sub

    Public Function LayTen(ByVal strSQL As String) As String
        Dim cn As OleDbConnection = New OleDbConnection(strConnectionString)
        Dim cmd As OleDbCommand = New OleDbCommand(strSQL, cn)
        Dim ten As String
        cmd.CommandType = CommandType.Text
        cn.Open()
        If (cn.State = ConnectionState.Open) Then
            ten = cmd.ExecuteScalar()
        End If
        cn.Close()
        LayTen = ten
    End Function

    Public Function LaySo(ByVal strSQL As String) As Integer
        Dim cn As OleDbConnection = New OleDbConnection(strConnectionString)
        Dim cmd As OleDbCommand = New OleDbCommand(strSQL, cn)
        Dim so As Integer
        cmd.CommandType = CommandType.Text
        cn.Open()
        If (cn.State = ConnectionState.Open) Then
            so = cmd.ExecuteScalar()
        End If
        cn.Close()
        LaySo = so
    End Function
End Class
