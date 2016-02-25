<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.MAKH = New System.Windows.Forms.Label()
        Me.TENKH = New System.Windows.Forms.Label()
        Me.DIACHI = New System.Windows.Forms.Label()
        Me.SDT = New System.Windows.Forms.Label()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.ok = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MAKH
        '
        Me.MAKH.AutoSize = True
        Me.MAKH.Location = New System.Drawing.Point(23, 34)
        Me.MAKH.Name = "MAKH"
        Me.MAKH.Size = New System.Drawing.Size(38, 13)
        Me.MAKH.TabIndex = 0
        Me.MAKH.Text = "MAKH"
        '
        'TENKH
        '
        Me.TENKH.AutoSize = True
        Me.TENKH.Location = New System.Drawing.Point(23, 87)
        Me.TENKH.Name = "TENKH"
        Me.TENKH.Size = New System.Drawing.Size(44, 13)
        Me.TENKH.TabIndex = 1
        Me.TENKH.Text = "TENKH"
        '
        'DIACHI
        '
        Me.DIACHI.AutoSize = True
        Me.DIACHI.Location = New System.Drawing.Point(23, 129)
        Me.DIACHI.Name = "DIACHI"
        Me.DIACHI.Size = New System.Drawing.Size(43, 13)
        Me.DIACHI.TabIndex = 2
        Me.DIACHI.Text = "DIACHI"
        '
        'SDT
        '
        Me.SDT.AutoSize = True
        Me.SDT.Location = New System.Drawing.Point(23, 176)
        Me.SDT.Name = "SDT"
        Me.SDT.Size = New System.Drawing.Size(29, 13)
        Me.SDT.TabIndex = 3
        Me.SDT.Text = "SDT"
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(138, 31)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(100, 20)
        Me.txtmakh.TabIndex = 4
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(138, 84)
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(100, 20)
        Me.txttenkh.TabIndex = 5
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(138, 126)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(100, 20)
        Me.txtdiachi.TabIndex = 6
        '
        'txtsdt
        '
        Me.txtsdt.Location = New System.Drawing.Point(138, 173)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(100, 20)
        Me.txtsdt.TabIndex = 7
        '
        'ok
        '
        Me.ok.Location = New System.Drawing.Point(26, 217)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(75, 23)
        Me.ok.TabIndex = 8
        Me.ok.Text = "OK"
        Me.ok.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(163, 217)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 23)
        Me.cancel.TabIndex = 9
        Me.cancel.Text = "CANCEL"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.txttenkh)
        Me.Controls.Add(Me.txtmakh)
        Me.Controls.Add(Me.SDT)
        Me.Controls.Add(Me.DIACHI)
        Me.Controls.Add(Me.TENKH)
        Me.Controls.Add(Me.MAKH)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MAKH As System.Windows.Forms.Label
    Friend WithEvents TENKH As System.Windows.Forms.Label
    Friend WithEvents DIACHI As System.Windows.Forms.Label
    Friend WithEvents SDT As System.Windows.Forms.Label
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents txttenkh As System.Windows.Forms.TextBox
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents ok As System.Windows.Forms.Button
    Friend WithEvents cancel As System.Windows.Forms.Button
End Class
