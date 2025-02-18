Imports System.Windows.Forms.DataVisualization.Charting

Public Class BaoCao
    Private Sub BaoCao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load("SELECT * FROM HangHoa", "HangHoa", "SoLuong")
    End Sub
    Private Sub Load(sql As String, x As String, y As String)
        Dim db As New DataManager()
        Dim tb = db.ExecuteQuery(sql)
        ShowChart(tb, x, y)
    End Sub
    Private Sub ShowChart(tb As DataTable, xCol As String, yCol As String)
        Chart1.Titles.Clear()
        Chart1.Titles.Add(New Title("Báo cáo"))
        Chart1.Series(0).AxisLabel = "Biểu đồ hàng hóa"
        Chart1.Series(0).ChartType = SeriesChartType.Column
        Chart1.Series(0).Points.DataBind(tb.DefaultView, xCol, yCol, "")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Load("SELECT * FROM HangHoa", "TenHH", "SoLuong")
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim sql = "SELECT TenHH, SUM(HoaDonChiTiet.SoLuong) As Tong FROM HangHoa, HoaDonChiTiet WHERE HoaDonChiTiet.MaHH = HangHoa.MaHH GROUP BY HangHoa.TenHH"
        Load(sql, "TenHH", "Tong")
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Dim sql = "SELECT NhanVien.TenNV, SUM(HoaDonChiTiet.SoLuong * HangHoa.DonGia) AS TongDoanhSo
           FROM HoaDonChiTiet
           INNER JOIN HangHoa ON HoaDonChiTiet.MaHH = HangHoa.MaHH
           INNER JOIN HoaDon ON HoaDonChiTiet.MaHD = HoaDon.MaHD
           INNER JOIN NhanVien ON HoaDon.MaNV = NhanVien.MaNV
           GROUP BY NhanVien.TenNV"

        Load(sql, "TenNV", "TongDoanhSo")
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Dim sql = "SELECT TenKH, SUM(HoaDon.TongTien) AS TongTien
                    FROM KhachHang, HoaDon
                    WHERE HoaDon.MaKH = KhachHang.MaKH
                    GROUP BY KhachHang.TenKH"
        Load(sql, "TenKH", "TongTien")
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        Dim sql = "SELECT TenHH, SUM(HoaDonChiTiet.SoLuong) * HangHoa.DonGia As Tong 
                    FROM HangHoa, HoaDonChiTiet 
                    WHERE HoaDonChiTiet.MaHH = HangHoa.MaHH 
                    GROUP BY HangHoa.TenHH , HangHoa.DonGia"
        Load(sql, "TenHH", "Tong")
    End Sub
End Class