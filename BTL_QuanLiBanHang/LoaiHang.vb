Public Class LoaiHang
    Dim dataTable As DataTable
    Private Sub LoaiHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLoaiHang()
        DataGridView1.Columns("TenLoaiHang").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub LoadLoaiHang()
        Dim sql = "SELECT * FROM LoaiHang"
        Dim db As New DataManager()
        DataGridView1.DataSource = db.ExecuteQuery(sql)
        DataTable = DataGridView1.DataSource
    End Sub

    Private Function Check() As Boolean
        If tbMaLH.Text = "" Then Return False
        If tbTenLoaiHang.Text = "" Then Return False
        Return True
    End Function

    Private Sub btnThen_Click(sender As Object, e As EventArgs) Handles btnThen.Click
        If Check() = False Then Return
        Dim sql = "INSERT INTO LoaiHang VALUES('{0}',N'{1}')"
        sql = String.Format(sql, tbMaLH.Text, tbTenLoaiHang.Text)
        Dim db As New DataManager()
        db.ExecuteNonQuery(sql)
        LoadLoaiHang()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If Check() = False Then Return
        Dim sql = "UPDATE LoaiHang SET TenLoaiHang = N'{0}' WHERE MaLH = '{1}'"
        sql = String.Format(sql, tbTenLoaiHang.Text, tbMaLH.Text)
        Dim db As New DataManager()
        db.ExecuteNonQuery(sql)
        LoadLoaiHang()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If Check() = False Then Return
        If MessageBox.Show("Xác nhận xóa nhà cung cấp này ?", "Chờ một chút!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
            Dim sql = "DELETE FROM LoaiHang WHERE MaLH = " & tbMaLH.Text
            Dim db As New DataManager
            db.ExecuteNonQuery(sql)
            LoadLoaiHang()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex < 0 Or e.RowIndex >= dataTable.Rows.Count Then Return
        Dim row = dataTable.Rows(e.RowIndex)
        tbMaLH.Text = row("MaLH").ToString()
        tbTenLoaiHang.Text = row("TenLoaiHang").ToString()
    End Sub
End Class