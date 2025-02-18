<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NhanSu
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
        Me.btnChoNghi = New System.Windows.Forms.Button()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnThen = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMaNV = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbTenNV = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbSDT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbDiaChi = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.cbbChucVu = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnChoNghi
        '
        Me.btnChoNghi.Location = New System.Drawing.Point(754, 169)
        Me.btnChoNghi.Name = "btnChoNghi"
        Me.btnChoNghi.Size = New System.Drawing.Size(110, 30)
        Me.btnChoNghi.TabIndex = 21
        Me.btnChoNghi.Text = "Xa thải"
        Me.btnChoNghi.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(754, 97)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(110, 30)
        Me.btnLuu.TabIndex = 20
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnThen
        '
        Me.btnThen.Location = New System.Drawing.Point(754, 61)
        Me.btnThen.Name = "btnThen"
        Me.btnThen.Size = New System.Drawing.Size(110, 30)
        Me.btnThen.TabIndex = 19
        Me.btnThen.Text = "Thêm"
        Me.btnThen.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(968, 28)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Danh sách nhân sự"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Mã nhân viên"
        '
        'tbMaNV
        '
        Me.tbMaNV.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMaNV.Location = New System.Drawing.Point(262, 57)
        Me.tbMaNV.Name = "tbMaNV"
        Me.tbMaNV.Size = New System.Drawing.Size(167, 26)
        Me.tbMaNV.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 218)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(968, 230)
        Me.DataGridView1.TabIndex = 15
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(754, 132)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(110, 30)
        Me.btnXoa.TabIndex = 22
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Tên nhân viên"
        '
        'tbTenNV
        '
        Me.tbTenNV.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTenNV.Location = New System.Drawing.Point(262, 93)
        Me.tbTenNV.Name = "tbTenNV"
        Me.tbTenNV.Size = New System.Drawing.Size(167, 26)
        Me.tbTenNV.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(171, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 19)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Số điện thoại"
        '
        'tbSDT
        '
        Me.tbSDT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSDT.Location = New System.Drawing.Point(263, 132)
        Me.tbSDT.Name = "tbSDT"
        Me.tbSDT.Size = New System.Drawing.Size(166, 26)
        Me.tbSDT.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(171, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 19)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Địa chỉ"
        '
        'tbDiaChi
        '
        Me.tbDiaChi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDiaChi.Location = New System.Drawing.Point(263, 175)
        Me.tbDiaChi.Name = "tbDiaChi"
        Me.tbDiaChi.Size = New System.Drawing.Size(465, 26)
        Me.tbDiaChi.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(442, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 19)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Tên đăng nhập"
        '
        'tbUsername
        '
        Me.tbUsername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsername.Location = New System.Drawing.Point(541, 61)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(187, 26)
        Me.tbUsername.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(442, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 19)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Mật khẩu"
        '
        'tbPassword
        '
        Me.tbPassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.Location = New System.Drawing.Point(541, 93)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(187, 26)
        Me.tbPassword.TabIndex = 33
        '
        'cbbChucVu
        '
        Me.cbbChucVu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbChucVu.FormattingEnabled = True
        Me.cbbChucVu.Location = New System.Drawing.Point(541, 132)
        Me.cbbChucVu.Name = "cbbChucVu"
        Me.cbbChucVu.Size = New System.Drawing.Size(187, 27)
        Me.cbbChucVu.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(442, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 19)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Chức vụ"
        '
        'NhanSu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BTL_QuanLiBanHang.My.Resources.Resources._1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(968, 448)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbbChucVu)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbDiaChi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbSDT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbTenNV)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnChoNghi)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnThen)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbMaNV)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "NhanSu"
        Me.Text = "NhanSu"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnChoNghi As Button
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnThen As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbMaNV As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnXoa As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbTenNV As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbSDT As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbDiaChi As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents cbbChucVu As ComboBox
    Friend WithEvents Label9 As Label
End Class
