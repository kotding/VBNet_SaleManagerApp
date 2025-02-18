Imports System.Drawing.Printing

Public Class HoaDon
    Dim hoaDonTable As DataTable
    Dim hoaDonChiTietTable As DataTable
    Dim WithEvents printer As New PrintDocument
    Private Sub HoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DataManager()
        hoaDonTable = db.ExecuteQuery("SELECT HoaDon.MaHD,NhanVien.TenNV,KhachHang.TenKH,HoaDon.TongTien, HoaDon.NgayBan FROM HoaDon,NhanVien,KhachHang WHERE HoaDon.MaNV = NhanVien.MaNV AND HoaDon.MaKH = KhachHang.MaKH")
        hoaDonChiTietTable = db.ExecuteQuery("SELECT * FROM HoaDonChiTiet")

        DataGridView2.DataSource = hoaDonTable
    End Sub
    Dim table As DataTable
    Dim rowSelected As Int32
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If e.RowIndex < 0 Or e.RowIndex >= hoaDonTable.Rows.Count Then Return
        rowSelected = e.RowIndex
        Dim maHD = DataGridView2.Rows(e.RowIndex).Cells("MaHD").Value
        Dim db As New DataManager()
        table = db.ExecuteQuery("SELECT TenHH,HoaDonChiTiet.SoLuong,HoaDonChiTiet.SoLuong * HangHoa.DonGia As ThanhTien FROM HoaDonChiTiet,HangHoa WHERE MaHD=" & maHD & " AND HangHoa.MaHH=HoaDonChiTiet.MaHH")
        Panel1.Invalidate()
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        DrawBill(e.Graphics)
    End Sub
    Private Sub DrawBill(g As Graphics)
        If table Is Nothing OrElse table.Rows.Count = 0 Then Return
        Dim font As New Font("Arial", 10)
        Dim boldFont As New Font("Arial", 10, FontStyle.Bold)
        Dim brush As New SolidBrush(Color.Black)
        Dim startX As Integer = 10
        Dim startY As Integer = 10
        Dim lineHeight As Integer = 25

        g.DrawString("HÓA ĐƠN BÁN HÀNG", boldFont, brush, startX + 70, startY)
        g.DrawString("Ngày: " & hoaDonTable.Rows(rowSelected)("NgayBan"), font, brush, startX, startY + lineHeight)

        Dim yPos As Integer = startY + lineHeight * 3
        g.DrawString("Tên hàng hóa", boldFont, brush, startX, yPos)
        g.DrawString("Số lượng", boldFont, brush, startX + 130, yPos)
        g.DrawString("Thành tiền", boldFont, brush, startX + 220, yPos)
        yPos += lineHeight

        For Each row As DataRow In table.Rows
            g.DrawString(row("TenHH").ToString(), font, brush, startX, yPos)
            g.DrawString(row("SoLuong").ToString(), font, brush, startX + 130, yPos)
            g.DrawString(row("ThanhTien").ToString(), font, brush, startX + 220, yPos)
            yPos += lineHeight
        Next

        g.DrawString("--------------------------------------------------------", font, brush, startX, yPos)
        g.DrawString("Tổng tiền: " & hoaDonTable.Rows(DataGridView2.CurrentRow.Index)("TongTien").ToString(), boldFont, brush, startX, yPos + lineHeight)
    End Sub
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btn_In_Click(sender As Object, e As EventArgs) Handles btn_In.Click
        printer.Print()
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles printer.PrintPage
        DrawBill(e.Graphics)
    End Sub
End Class