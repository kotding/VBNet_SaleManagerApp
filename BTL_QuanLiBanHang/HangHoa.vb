Public Class HangHoa
    Dim table As DataTable
    Private Sub HangHoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbbNhaCungCap.DisplayMember = "TenNCC"
        cbbNhaCungCap.ValueMember = "MaNCC"
        cbbLoaiHang.DisplayMember = "TenLoaiHang"
        cbbLoaiHang.ValueMember = "MaLH"
        LoadHangHoa()
        Dim dbManager As New DataManager()
        cbbNhaCungCap.DataSource = dbManager.ExecuteQuery("SELECT * FROM NhaCungCap")
        cbbLoaiHang.DataSource = dbManager.ExecuteQuery("SELECT * FROM LoaiHang")
    End Sub
    Private Sub LoadHangHoa()
        Dim dbManager As New DataManager()
        DataGridView1.DataSource = dbManager.ExecuteQuery("SELECT MaHH,TenHH,MoTa,DVT,DonGia,SoLuong,LoaiHang.TenLoaiHang,NhaCungCap.TenNCC  FROM HangHoa,LoaiHang,NhaCungCap WHERE HangHoa.MaLH = LoaiHang.MaLH AND HangHoa.MaNCC = NhaCungCap.MaNCC")
        table = DataGridView1.DataSource
        DataGridView1.Columns("TenNCC").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex < 0 Or e.RowIndex >= table.Rows.Count Then Return

        Dim dataRow = table.Rows(e.RowIndex)
        tbTenHang.Text = dataRow("TenHH").ToString()
        tbMoTa.Text = dataRow("MoTa").ToString()
        tbDVT.Text = dataRow("DVT").ToString()
        tbDonGia.Text = dataRow("DonGia").ToString()
        tbSoLuong.Text = dataRow("SoLuong").ToString()
        tbMaHang.Text = dataRow("MaHH").ToString()

        Dim tenLH As String = dataRow("TenLoaiHang").ToString()
        Dim tenNCC As String = dataRow("TenNCC").ToString()

        For Each item As DataRowView In cbbLoaiHang.Items
            If item(cbbLoaiHang.DisplayMember) = tenLH Then
                cbbLoaiHang.SelectedItem = item
                Exit For
            End If
        Next

        For Each item As DataRowView In cbbNhaCungCap.Items
            If item(cbbNhaCungCap.DisplayMember) = tenNCC Then
                cbbNhaCungCap.SelectedItem = item
                Exit For
            End If
        Next
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If ValidateInput() = False Then Return
        Dim sql = "INSERT INTO HangHoa VALUES('{0}',N'{1}',N'{2}',N'{3}',{4},{5},'{6}','{7}')"
        sql = String.Format(sql, tbMaHang.Text, tbTenHang.Text, tbMoTa.Text, tbDVT.Text, tbDonGia.Text, tbSoLuong.Text, cbbNhaCungCap.SelectedValue, cbbLoaiHang.SelectedValue)
        Dim dbManager = New DataManager()
        dbManager.ExecuteQuery(sql)
        LoadHangHoa()
    End Sub
    Private Function ValidateInput() As Boolean
        If tbMaHang.Text = "" Then Return False
        If tbTenHang.Text = "" Then Return False
        If tbDonGia.Text = "" Then Return False
        If tbSoLuong.Text = "" Then Return False
        If tbDVT.Text = "" Then Return False
        Return True
    End Function

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If ValidateInput() = False Then Return
        If MessageBox.Show("Xác nhận xóa ?:)", "Chờ một chút!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
            Dim sql = "DELETE FROM HangHoa WHERE MaHH = " & tbMaHang.Text
            Dim db As New DataManager()
            db.ExecuteNonQuery(sql)
            LoadHangHoa()
        End If
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If ValidateInput() = False Then Return
        Dim sql = "UPDATE HangHoa SET TenHH = N'{0}', MoTa = N'{1}',DVT = N'{2}',DonGia = '{3}',SoLuong = '{4}',MaNCC = '{5}', MaLH = '{6}' WHERE MaHH = '{7}'"
        sql = String.Format(sql, tbTenHang.Text, tbMoTa.Text, tbDVT.Text, tbDonGia.Text, tbSoLuong.Text, cbbNhaCungCap.SelectedValue, cbbLoaiHang.SelectedValue, tbMaHang.Text)
        Dim dbManager = New DataManager()
        dbManager.ExecuteQuery(sql)
        LoadHangHoa()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class