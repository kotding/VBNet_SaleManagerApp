Public Class KhachHang
    Private Sub KhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKhachHang()
        DataGridView1.Columns("DiaChi").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub LoadKhachHang()
        Dim sql = "SELECT * FROM KhachHang"
        Dim db As New DataManager()
        DataGridView1.DataSource = db.ExecuteQuery(sql)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex < 0 Or e.RowIndex >= DataGridView1.Rows.Count Then Return
        Dim row = DataGridView1.Rows(e.RowIndex)
        tbMaKH.Text = row.Cells("MaKH").Value.ToString
        tbTenKH.Text = row.Cells("TenKH").Value.ToString
        tbDiaChi.Text = row.Cells("DiaChi").Value.ToString
        tbSDT.Text = row.Cells("SDT").Value.ToString

    End Sub
    Private Function Check() As Boolean
        If tbMaKH.Text = "" Then Return False
        If tbTenKH.Text = "" Then Return False
        If tbDiaChi.Text = "" Then Return False
        If tbSDT.Text = "" Then Return False
        Return True
    End Function

    Private Sub btnThen_Click(sender As Object, e As EventArgs) Handles btnThen.Click
        If Check() = False Then Return
        Dim sql = "INSERT INTO KhachHang VALUES('{0}',N'{1}','{2}',N'{3}')"
        sql = String.Format(sql, tbMaKH.Text, tbTenKH.Text, tbSDT.Text, tbDiaChi.Text)
        Dim db As New DataManager()
        db.ExecuteNonQuery(sql)
        LoadKhachHang()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If Check() = False Then Return

        Dim sql = "UPDATE KhachHang SET TenKH = N'{0}',SDT = '{1}',DiaChi = N'{2}' WHERE MaKH = '{3}'"
        sql = String.Format(sql, tbTenKH.Text, tbSDT.Text, tbDiaChi.Text, tbMaKH.Text)
        Dim db As New DataManager()
        db.ExecuteNonQuery(sql)
        LoadKhachHang()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If Check() = False Then Return
        If MessageBox.Show("Xác nhận xóa khách hàng này ?", "Chờ một chút!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
            Dim sql = "DELETE FROM KhachHang WHERE MaKH = " & tbMaKH.Text
            Dim db As New DataManager
            db.ExecuteNonQuery(sql)
            LoadKhachHang()
        End If
    End Sub
End Class