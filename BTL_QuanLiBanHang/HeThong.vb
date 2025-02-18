Imports System.Windows.Forms

Public Class HeThong

    Dim currForm As Form
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub QuảnLíHàngHóaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíHàngHóaToolStripMenuItem.Click
        ShowFormInside(New HangHoa())
    End Sub

    Private Sub ShowFormInside(frm As Form)
        Panel1.SuspendLayout()
        If currForm IsNot Nothing Then
            currForm.Close()
            currForm.Dispose()
        End If
        currForm = frm
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        frm.TopLevel = False
        frm.Hide()
        Panel1.Visible = False
        frm.Visible = False
        Panel1.Controls.Clear()
        Panel1.Controls.Add(frm)
        frm.Show()
        Panel1.ResumeLayout()
        Panel1.Visible = True
    End Sub

    Private Sub HeThong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowFormInside(New BanHang())
    End Sub

    Private Sub QuảnLíNhàCungCấpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíNhàCungCấpToolStripMenuItem.Click
        ShowFormInside(New NhaCungCap())
    End Sub

    Private Sub PhânLoạiSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhânLoạiSảnPhẩmToolStripMenuItem.Click
        ShowFormInside(New LoaiHang())
    End Sub

    Private Sub QuảnLíNhânSựToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíNhânSựToolStripMenuItem.Click
        ShowFormInside(New NhanSu())
    End Sub

    Private Sub QuảnLíKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíKháchHàngToolStripMenuItem.Click
        ShowFormInside(New KhachHang())
    End Sub

    Private Sub HóaĐơnXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HóaĐơnXuấtToolStripMenuItem.Click
        ShowFormInside(New HoaDon())
    End Sub

    Private Sub TrangBánHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrangBánHàngToolStripMenuItem.Click
        ShowFormInside(New BanHang())
    End Sub

    Private Sub ToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip.ItemClicked

    End Sub

    Private Sub MenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub XemBáoCáoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemBáoCáoToolStripMenuItem.Click
        ShowFormInside(New BaoCao())
    End Sub
End Class
