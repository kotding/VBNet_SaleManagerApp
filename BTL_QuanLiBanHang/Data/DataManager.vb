Imports Microsoft.Data.SqlClient
Public Class DataManager
    Public Sub ExecuteNonQuery(sql As String)
        Dim connectString = My.Settings.ConnectString
        Dim conn As New SqlConnection(connectString)
        conn.Open()
        Dim cmd As New SqlCommand(sql, conn)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message & sql, "Thao tác không hợp lệ")
        End Try
        conn.Close()
    End Sub
    Public Function ExecuteQuery(sql As String) As DataTable
        Dim connectString = My.Settings.ConnectString
        Dim conn As New SqlConnection(connectString)
        conn.Open()
        Dim cmd As New SqlCommand(sql, conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        Try
            adapter.Fill(table)
        Catch ex As Exception
            MessageBox.Show(ex.Message & sql, "Thông tin nhập không chính xác")
        End Try
        conn.Close()
        Return table
    End Function
    Public Function ExecuteScalar(sql As String) As Int16
        Dim connectString = My.Settings.ConnectString
        Dim conn As New SqlConnection(connectString)
        conn.Open()
        Dim cmd As New SqlCommand(sql, conn)
        Try
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message & sql, "Thao tác không hợp lệ")
        End Try
        conn.Close()
        Return -1
    End Function
End Class
