Public Class NhanSu
    Dim dataTable As DataTable
    Private Sub NhanSu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNhanVien()
        cbbChucVu.DisplayMember = "TenCV"
        cbbChucVu.ValueMember = "MaCV"
        cbbChucVu.DataSource = New DataManager().ExecuteQuery("SELECT * FROM ChucVu")
        'DataGridView1.Columns("Email").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub LoadNhanVien()
        Dim sql = "SELECT NhanVien.*,ChucVu.TenCV FROM NhanVien,ChucVu WHERE NhanVien.MaCV = ChucVu.MaCV"
        Dim db As New DataManager()
        DataGridView1.DataSource = db.ExecuteQuery(sql)
        dataTable = DataGridView1.DataSource
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex < 0 Or e.RowIndex >= dataTable.Rows.Count Then Return

        Dim row = DataGridView1.Rows(e.RowIndex)
        tbMaNV.Text = row.Cells("MaNV").Value.ToString()
        tbTenNV.Text = row.Cells("TenNV").Value.ToString()
        tbSDT.Text = row.Cells("SDT").Value.ToString()
        tbDiaChi.Text = row.Cells("DiaChi").Value.ToString()
        tbUsername.Text = row.Cells("Username").Value.ToString()
        tbPassword.Text = row.Cells("Password").Value.ToString()
        cbbChucVu.SelectedValue = row.Cells("MaCV").Value
    End Sub

    Private Sub btnThen_Click(sender As Object, e As EventArgs) Handles btnThen.Click
        If Check() = False Then Return
        Dim sql = "INSERT INTO NhanVien VALUES('{0}',N'{1}',N'{2}',N'{3}',N'{4}','{5}','{6}','{7}')"
        sql = String.Format(sql, tbMaNV.Text, tbTenNV.Text, tbSDT.Text, tbDiaChi.Text, tbUsername.Text, tbPassword.Text, cbbChucVu.SelectedValue, "1")

        Dim db As New DataManager()
        db.ExecuteNonQuery(sql)
        LoadNhanVien()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If Check() = False Then Return

        Dim sql = "UPDATE NhanVien SET TenNV = N'{0}',SDT = '{1}', DiaChi = N'{2}',Username = '{3}',Password = '{4}',MaCV = '{5}',TrangThai = '{6}' WHERE MaNV = '{7}'"
        sql = String.Format(sql, tbTenNV.Text, tbSDT.Text, tbDiaChi.Text, tbUsername.Text, tbPassword.Text, cbbChucVu.SelectedValue, "1", tbMaNV.Text)
        Dim db As New DataManager()
        db.ExecuteNonQuery(sql)
        LoadNhanVien()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If Check() = False Then Return
        If MessageBox.Show("Xác nhận xóa nhân viên này ?", "Chờ một chút!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
            Dim sql = "DELETE FROM NhanVien WHERE MaNV = " & tbMaNV.Text
            Dim db As New DataManager
            db.ExecuteNonQuery(sql)
            LoadNhanVien()
        End If
    End Sub

    Private Sub btnChoNghi_Click(sender As Object, e As EventArgs) Handles btnChoNghi.Click
        If Check() = False Then Return
        If MessageBox.Show("Tính đuổi việc culi này à ?", "Chờ một chút!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
            Dim sql = "UPDATE NhanVien SET TrangThai = '0' WHERE MaNV = '{0}'"
            sql = String.Format(sql, tbMaNV.Text)
            Dim db As New DataManager()
            db.ExecuteNonQuery(sql)
            LoadNhanVien()
        End If

    End Sub

    Private Function Check() As Boolean
        If tbTenNV.Text = "" Then Return False
        If tbMaNV.Text = "" Then Return False
        If tbSDT.Text = "" Then Return False
        If tbDiaChi.Text = "" Then Return False
        If tbUsername.Text = "" Then Return False
        If tbPassword.Text = "" Then Return False
        Return True
    End Function

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class