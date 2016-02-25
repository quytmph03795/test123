Public Class Form2

    Private _DBAccess As New DataBaseAccess
    Private _is As Boolean = False

    Public Sub New(edit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _is = edit
    End Sub

    Private Function insertkh() As Boolean
        Dim sqlquery As String = "Insert into KhachHang ( MAKH, TENKH, DIACHI, SDT )"
        sqlquery += String.Format("values('{0}','{1}','{2}','{3}')", txtmakh.Text, txttenkh.Text, txtdiachi.Text, txtsdt.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlquery)

    End Function

    Private Function UPDATEKH() As Boolean
        Dim sqlquery As String = String.Format("UPDATE KhachHang SET TENKH = '{0}' , DIACHI = '{1}', SDT = '{2}' where MAKH = '{3}'", Me.txttenkh.Text, Me.txtdiachi.Text, Me.txtsdt.Text, Me.txtmakh.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlquery)
    End Function

    Private Function kie() As Boolean
        Return (String.IsNullOrEmpty(txtmakh.Text) OrElse String.IsNullOrEmpty(txttenkh.Text) _
            OrElse String.IsNullOrEmpty(txtdiachi.Text) OrElse String.IsNullOrEmpty(txtsdt.Text))
    End Function

    Private Sub ok_Click(sender As Object, e As EventArgs) Handles ok.Click
        If kie() Then
            MessageBox.Show("nhap gia tri", "erro", MessageBoxButtons.OK)
        Else
            If _is Then
                If UPDATEKH() Then
                    MessageBox.Show("thanh cong", "thong bao", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("loi update", "thong bao", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            Else
                If insertkh() Then
                    MessageBox.Show("thanh cong", "thong bao", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("loi", "thong bao", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            End If
            Me.Close()
        End If
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

End Class