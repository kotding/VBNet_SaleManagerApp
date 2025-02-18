<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BanHang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.maHH = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tenHH = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.soLuong = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbTenNV = New System.Windows.Forms.TextBox()
        Me.tbThoiGian = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbbHangBan = New System.Windows.Forms.ComboBox()
        Me.tbSoLuong = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbDonGia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbTongTienTamTinh = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbbKhachHang = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbCoTaiKhoan = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbTongTien = New System.Windows.Forms.Label()
        Me.btnThanhToan = New System.Windows.Forms.Button()
        Me.btnThemVaoHoaDon = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbSoLuongCon = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.maHH, Me.tenHH, Me.soLuong})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(641, 77)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(297, 259)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'maHH
        '
        Me.maHH.Text = "Mã Hàng"
        '
        'tenHH
        '
        Me.tenHH.Text = "Tên Hàng"
        Me.tenHH.Width = 160
        '
        'soLuong
        '
        Me.soLuong.Text = "Số lượng"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Lập hóa đơn"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nhân viên bán"
        '
        'tbTenNV
        '
        Me.tbTenNV.Enabled = False
        Me.tbTenNV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTenNV.Location = New System.Drawing.Point(61, 92)
        Me.tbTenNV.Name = "tbTenNV"
        Me.tbTenNV.Size = New System.Drawing.Size(191, 26)
        Me.tbTenNV.TabIndex = 3
        '
        'tbThoiGian
        '
        Me.tbThoiGian.Enabled = False
        Me.tbThoiGian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbThoiGian.Location = New System.Drawing.Point(325, 92)
        Me.tbThoiGian.Name = "tbThoiGian"
        Me.tbThoiGian.Size = New System.Drawing.Size(191, 26)
        Me.tbThoiGian.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(322, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Thời gian"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(641, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(297, 36)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Danh sách hàng hóa"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Hàng bán"
        '
        'cbbHangBan
        '
        Me.cbbHangBan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbHangBan.FormattingEnabled = True
        Me.cbbHangBan.Location = New System.Drawing.Point(60, 149)
        Me.cbbHangBan.Name = "cbbHangBan"
        Me.cbbHangBan.Size = New System.Drawing.Size(191, 28)
        Me.cbbHangBan.TabIndex = 8
        '
        'tbSoLuong
        '
        Me.tbSoLuong.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSoLuong.Location = New System.Drawing.Point(325, 152)
        Me.tbSoLuong.Name = "tbSoLuong"
        Me.tbSoLuong.Size = New System.Drawing.Size(191, 26)
        Me.tbSoLuong.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(322, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Số lượng"
        '
        'tbDonGia
        '
        Me.tbDonGia.Enabled = False
        Me.tbDonGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDonGia.Location = New System.Drawing.Point(325, 213)
        Me.tbDonGia.Name = "tbDonGia"
        Me.tbDonGia.Size = New System.Drawing.Size(191, 26)
        Me.tbDonGia.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(322, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Đơn giá"
        '
        'tbTongTienTamTinh
        '
        Me.tbTongTienTamTinh.Enabled = False
        Me.tbTongTienTamTinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTongTienTamTinh.Location = New System.Drawing.Point(325, 275)
        Me.tbTongTienTamTinh.Name = "tbTongTienTamTinh"
        Me.tbTongTienTamTinh.Size = New System.Drawing.Size(191, 26)
        Me.tbTongTienTamTinh.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(322, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Tổng tiền tạm tính"
        '
        'cbbKhachHang
        '
        Me.cbbKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbKhachHang.FormattingEnabled = True
        Me.cbbKhachHang.Location = New System.Drawing.Point(61, 213)
        Me.cbbKhachHang.Name = "cbbKhachHang"
        Me.cbbKhachHang.Size = New System.Drawing.Size(191, 28)
        Me.cbbKhachHang.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(58, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Khách mua"
        '
        'cbCoTaiKhoan
        '
        Me.cbCoTaiKhoan.AutoSize = True
        Me.cbCoTaiKhoan.BackColor = System.Drawing.Color.Transparent
        Me.cbCoTaiKhoan.Location = New System.Drawing.Point(60, 247)
        Me.cbCoTaiKhoan.Name = "cbCoTaiKhoan"
        Me.cbCoTaiKhoan.Size = New System.Drawing.Size(146, 17)
        Me.cbCoTaiKhoan.TabIndex = 17
        Me.cbCoTaiKhoan.Text = "Khách chưa có tài khoản"
        Me.cbCoTaiKhoan.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(641, 339)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 29)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Tổng: "
        '
        'tbTongTien
        '
        Me.tbTongTien.AutoSize = True
        Me.tbTongTien.BackColor = System.Drawing.Color.Transparent
        Me.tbTongTien.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTongTien.Location = New System.Drawing.Point(711, 339)
        Me.tbTongTien.Name = "tbTongTien"
        Me.tbTongTien.Size = New System.Drawing.Size(75, 29)
        Me.tbTongTien.TabIndex = 19
        Me.tbTongTien.Text = "0 vnd"
        '
        'btnThanhToan
        '
        Me.btnThanhToan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThanhToan.Location = New System.Drawing.Point(716, 394)
        Me.btnThanhToan.Name = "btnThanhToan"
        Me.btnThanhToan.Size = New System.Drawing.Size(171, 42)
        Me.btnThanhToan.TabIndex = 20
        Me.btnThanhToan.Text = "Xác nhận thanh toán"
        Me.btnThanhToan.UseVisualStyleBackColor = True
        '
        'btnThemVaoHoaDon
        '
        Me.btnThemVaoHoaDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemVaoHoaDon.Location = New System.Drawing.Point(336, 320)
        Me.btnThemVaoHoaDon.Name = "btnThemVaoHoaDon"
        Me.btnThemVaoHoaDon.Size = New System.Drawing.Size(157, 31)
        Me.btnThemVaoHoaDon.TabIndex = 21
        Me.btnThemVaoHoaDon.Text = "Thêm vào hóa đơn"
        Me.btnThemVaoHoaDon.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(854, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 31)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Xóa"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbSoLuongCon
        '
        Me.lbSoLuongCon.AutoSize = True
        Me.lbSoLuongCon.BackColor = System.Drawing.Color.Transparent
        Me.lbSoLuongCon.Location = New System.Drawing.Point(411, 135)
        Me.lbSoLuongCon.Name = "lbSoLuongCon"
        Me.lbSoLuongCon.Size = New System.Drawing.Size(95, 13)
        Me.lbSoLuongCon.TabIndex = 23
        Me.lbSoLuongCon.Text = "Trong kho có: 100"
        '
        'BanHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(968, 448)
        Me.Controls.Add(Me.lbSoLuongCon)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnThemVaoHoaDon)
        Me.Controls.Add(Me.btnThanhToan)
        Me.Controls.Add(Me.tbTongTien)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbCoTaiKhoan)
        Me.Controls.Add(Me.cbbKhachHang)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbTongTienTamTinh)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbDonGia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbSoLuong)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbbHangBan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbThoiGian)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbTenNV)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "BanHang"
        Me.Text = "s"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbTenNV As TextBox
    Friend WithEvents tbThoiGian As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbbHangBan As ComboBox
    Friend WithEvents tbSoLuong As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbDonGia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbTongTienTamTinh As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbbKhachHang As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbCoTaiKhoan As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbTongTien As Label
    Friend WithEvents btnThanhToan As Button
    Friend WithEvents btnThemVaoHoaDon As Button
    Friend WithEvents tenHH As ColumnHeader
    Friend WithEvents soLuong As ColumnHeader
    Friend WithEvents maHH As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents lbSoLuongCon As Label
End Class
