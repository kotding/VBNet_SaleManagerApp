Public Class BanHang
    Dim hanghoaTable As DataTable
    Dim khachhangTable As DataTable
    Private Sub BanHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbbKhachHang.DisplayMember = "TenKH"
        cbbKhachHang.ValueMember = "MaKH"
        cbbHangBan.DisplayMember = "TenHH"
        cbbHangBan.ValueMember = "MaHH"
        tbTenNV.Text = QuanLiTaiKhoan.NhanVien.TenNV
        tbThoiGian.Text = DateTime.Now.ToString
        ListView1.View = View.Details
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim db As New DataManager
        hanghoaTable = db.ExecuteQuery("SELECT * FROM HangHoa")
        cbbHangBan.DataSource = hanghoaTable
        khachhangTable = db.ExecuteQuery("SELECT * FROM KhachHang")
        cbbKhachHang.DataSource = khachhangTable
        ListView1.Items.Clear()
        lbSoLuongCon.Text = "Sẵn có: " & hanghoaTable.Select("MaHH=" & cbbHangBan.SelectedValue)(0)("SoLuong")
    End Sub

    Private Sub cbCoTaiKhoan_CheckedChanged(sender As Object, e As EventArgs) Handles cbCoTaiKhoan.CheckedChanged
        cbbKhachHang.Visible = cbCoTaiKhoan.Checked = False
    End Sub

    Private Sub cbbHangBan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbHangBan.SelectedIndexChanged
        TinhTienHang()
        lbSoLuongCon.Text = "Sẵn có: " & hanghoaTable.Select("MaHH=" & cbbHangBan.SelectedValue)(0)("SoLuong")
    End Sub
    Private Sub TinhTienHang()
        Dim donGia = hanghoaTable.Rows(cbbHangBan.SelectedIndex)("DonGia")
        tbDonGia.Text = donGia.ToString
        Dim soLuong = 0
        Int32.TryParse(tbSoLuong.Text, soLuong)
        tbTongTienTamTinh.Text = (soLuong * donGia) & " VND"
    End Sub

    Private Sub tbSoLuong_TextChanged(sender As Object, e As EventArgs) Handles tbSoLuong.TextChanged
        TinhTienHang()
    End Sub

    Private Sub btnThemVaoHoaDon_Click(sender As Object, e As EventArgs) Handles btnThemVaoHoaDon.Click
        If CheckThongTin() = False Then
            MessageBox.Show("Nhập số lượng đầy đủ")
            Return
        End If
        Dim soLuongCon = 0
        soLuongCon = Int32.Parse(hanghoaTable.Select("MaHH=" & cbbHangBan.SelectedValue)(0)("SoLuong"))
        Dim soLuongNhap = 0
        soLuongNhap = Int32.Parse(tbSoLuong.Text)
        If soLuongNhap > soLuongCon Then
            MessageBox.Show("Không đủ mặt hàng này")
        End If
        For Each Item As ListViewItem In ListView1.Items
            If Item.Text = hanghoaTable(cbbHangBan.SelectedIndex)("MaHH") Then
                Dim sl As Int32
                sl = Int32.Parse(Item.SubItems(2).Text)
                sl += Int32.Parse(tbSoLuong.Text)
                If sl > soLuongCon Then
                    MessageBox.Show("Không đủ mặt hàng này")
                    Return
                End If
                Item.SubItems(2).Text = sl
                Return
            End If
        Next
        Dim listViewItem = New ListViewItem

        listViewItem.Text = cbbHangBan.SelectedValue

        listViewItem.SubItems.Add(cbbHangBan.Text)
        listViewItem.SubItems.Add(tbSoLuong.Text)

        ListView1.Items.Add(listViewItem)
        Dim tongTien = 0
        For Each Item As ListViewItem In ListView1.Items
            Dim sl = Int32.Parse(Item.SubItems(2).Text)
            Dim donGia = Int32.Parse((hanghoaTable.Select("MaHH=" & Item.Text)(0)("DonGia")))
            tongTien += donGia * sl
        Next
        tbTongTien.Text = tongTien & " VND"
    End Sub
    Private Function CheckThongTin() As Boolean
        Dim sl As Int32
        If tbSoLuong.Text = "" Or Int32.TryParse(tbSoLuong.Text, sl) = False Or sl = 0 Then
            Return False
        End If
        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListView1.CheckedItems.Count = 0 Then Return

        If MessageBox.Show("Muốn xóa hàng này ?") = DialogResult.OK Then
            For Each selectedItem In ListView1.CheckedItems
                ListView1.Items.Remove(selectedItem)
            Next

            Dim tongTien = 0
            For Each Item As ListViewItem In ListView1.Items
                Dim sl = Int32.Parse(Item.SubItems(2).Text)
                Dim donGia = Int32.Parse((hanghoaTable.Select("MaHH=" & Item.Text)(0)("DonGia")))
                tongTien += donGia * sl
            Next
            tbTongTien.Text = tongTien & " VND"
        End If

    End Sub

    Private Sub btnThanhToan_Click(sender As Object, e As EventArgs) Handles btnThanhToan.Click
        If ListView1.Items.Count = 0 Then Return
        If MessageBox.Show("Xác nhận thanh toán ?") = DialogResult.OK Then
            Dim db As New DataManager
            Dim maKH As String
            If cbCoTaiKhoan.Checked Then
                maKH = cbbKhachHang.SelectedValue
            Else
                maKH = "003"
            End If
            Dim maNV = QuanLiTaiKhoan.NhanVien.MaNV
            Dim dateTime As DateTime = DateTime.Now
            Dim tongTien As Int32 = tbTongTien.Text.Replace(" VND", "")
            Dim maHD As Int16 = db.ExecuteScalar(String.Format("INSERT INTO HoaDon OUTPUT INSERTED.MaHD VALUES('{0}','{1}','{2}','{3}')", dateTime.ToString(), maNV, maKH, tongTien))
            For Each Item As ListViewItem In ListView1.Items
                Dim sl = Int32.Parse(Item.SubItems(2).Text)
                db.ExecuteNonQuery(String.Format("INSERT INTO HoaDonChiTiet VALUES('{0}','{1}',{2})", maHD, Item.Text, sl))
                db.ExecuteNonQuery(String.Format("UPDATE HangHoa SET SoLuong = SoLuong - {0} WHERE MaHH = {1}", sl, Item.Text))
            Next
            LoadData()
            MessageBox.Show("Đã thanh toán")
        End If
    End Sub

    Private Sub tbTenNV_TextChanged(sender As Object, e As EventArgs) Handles tbTenNV.TextChanged

    End Sub

    Private Sub tbThoiGian_TextChanged(sender As Object, e As EventArgs) Handles tbThoiGian.TextChanged

    End Sub

    Private Sub tbTongTienTamTinh_TextChanged(sender As Object, e As EventArgs) Handles tbTongTienTamTinh.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub lbSoLuongCon_Click(sender As Object, e As EventArgs) Handles lbSoLuongCon.Click

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class