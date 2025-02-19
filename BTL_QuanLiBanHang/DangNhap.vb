Imports System.Data.SqlClient

Public Class DangNhap
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If ValidateInput() = False Then Return

        Dim username = tbUsername.Text
        Dim password = tbPassword.Text
        Dim dbManager As New DataManager
        Dim sql As String = String.Format("SELECT * FROM NhanVien WHERE Username = '{0}' AND Password = '{1}'", username, password)
        Dim table = dbManager.ExecuteQuery(sql)
        If table.Rows.Count > 0 Then
            QuanLiTaiKhoan.NhanVien = New NhanVien
            QuanLiTaiKhoan.NhanVien.MaNV = table.Rows(0)("MaNV")
            QuanLiTaiKhoan.NhanVien.TenNV = table.Rows(0)("TenNV")
            QuanLiTaiKhoan.NhanVien.DiaChi = table.Rows(0)("DiaChi")
            QuanLiTaiKhoan.NhanVien.SDT = table.Rows(0)("SDT")
            Dim frmHeThong As New HeThong
            frmHeThong.Show()
            Me.Close()

        Else
            MessageBox.Show("Đăng nhập thất bại")
        End If
    End Sub
    Private Function ValidateInput() As Boolean
        Dim username = tbUsername.Text
        Dim password = tbPassword.Text
        If username = "" Or password = "" Then
            MessageBox.Show("Nhập đủ username và password")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub DangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub tbPassword_TextChanged(sender As Object, e As EventArgs) Handles tbPassword.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class