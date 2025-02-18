Public Class NhaCungCap
    Dim dataTable As DataTable
    Private Sub NhaCungCap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNhaCungCap()
        DataGridView1.Columns("Email").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub LoadNhaCungCap()
        Dim sql = "SELECT * FROM NhaCungCap"
        Dim db As New DataManager()
        DataGridView1.DataSource = db.ExecuteQuery(sql)
        dataTable = DataGridView1.DataSource
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellClick
        If e.RowIndex < 0 Or e.RowIndex >= dataTable.Rows.Count Then Return

        Dim row = DataGridView1.Rows(e.RowIndex)
        tbMaNCC.Text = row.Cells("MaNCC").Value.ToString()
        tbEmail.Text = row.Cells("Email").Value.ToString()
        tbSDT.Text = row.Cells("SDT").Value.ToString()
        tbTenNCC.Text = row.Cells("TenNCC").Value.ToString()
        tbDiaChi.Text = row.Cells("DiaChi").Value.ToString()
    End Sub

    Private Sub btnThen_Click(sender As Object, e As EventArgs) Handles btnThen.Click
        If Check() = False Then Return
        Dim sql = "INSERT INTO NhaCungCap VALUES('{0}',N'{1}',N'{2}',N'{3}',N'{4}')"
        sql = String.Format(sql, tbMaNCC.Text, tbTenNCC.Text, tbDiaChi.Text, tbSDT.Text, tbEmail.Text)
        Dim db As New DataManager()
        db.ExecuteNonQuery(sql)
        LoadNhaCungCap()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If Check() = False Then Return

        Dim sql = "UPDATE NhaCungCap SET TenNCC = N'{0}',DiaChi = N'{1}',SDT = '{2}',Email = '{3}' WHERE MaNCC = '{4}'"
        sql = String.Format(sql, tbTenNCC.Text, tbDiaChi.Text, tbSDT.Text, tbEmail.Text, tbMaNCC.Text)
        Dim db As New DataManager()
        db.ExecuteNonQuery(sql)
        LoadNhaCungCap()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If Check() = False Then Return
        If MessageBox.Show("Xác nhận xóa nhà cung cấp này ?", "Chờ một chút!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
            Dim sql = "DELETE FROM NhaCungCap WHERE MaNCC = " & tbMaNCC.Text
            Dim db As New DataManager
            db.ExecuteNonQuery(sql)
            LoadNhaCungCap()
        End If
    End Sub

    Private Function Check() As Boolean
        If tbMaNCC.Text = "" Then Return False
        If tbDiaChi.Text = "" Then Return False
        If tbSDT.Text = "" Then Return False
        If tbTenNCC.Text = "" Then Return False
        If tbEmail.Text = "" Then Return False
        Return True
    End Function

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub tbSDT_TextChanged(sender As Object, e As EventArgs) Handles tbSDT.TextChanged

    End Sub

    Private Sub tbEmail_TextChanged(sender As Object, e As EventArgs) Handles tbEmail.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class