<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHitungNilai
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
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.lblTatapMuka = New System.Windows.Forms.Label()
        Me.lblMidTest = New System.Windows.Forms.Label()
        Me.lblFnlTst = New System.Windows.Forms.Label()
        Me.txtTatapMuka = New System.Windows.Forms.TextBox()
        Me.txtMidTest = New System.Windows.Forms.TextBox()
        Me.txtFnlTst = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.lblHasil = New System.Windows.Forms.Label()
        Me.txtHasil = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblJudul
        '
        Me.lblJudul.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.Location = New System.Drawing.Point(146, 49)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(173, 24)
        Me.lblJudul.TabIndex = 0
        Me.lblJudul.Text = "Program Hitung Nilai"
        '
        'lblTatapMuka
        '
        Me.lblTatapMuka.AutoSize = True
        Me.lblTatapMuka.Location = New System.Drawing.Point(112, 124)
        Me.lblTatapMuka.Name = "lblTatapMuka"
        Me.lblTatapMuka.Size = New System.Drawing.Size(65, 13)
        Me.lblTatapMuka.TabIndex = 1
        Me.lblTatapMuka.Text = "Tatap Muka"
        '
        'lblMidTest
        '
        Me.lblMidTest.AutoSize = True
        Me.lblMidTest.Location = New System.Drawing.Point(112, 157)
        Me.lblMidTest.Name = "lblMidTest"
        Me.lblMidTest.Size = New System.Drawing.Size(48, 13)
        Me.lblMidTest.TabIndex = 2
        Me.lblMidTest.Text = "Mid Test"
        '
        'lblFnlTst
        '
        Me.lblFnlTst.AutoSize = True
        Me.lblFnlTst.Location = New System.Drawing.Point(112, 192)
        Me.lblFnlTst.Name = "lblFnlTst"
        Me.lblFnlTst.Size = New System.Drawing.Size(53, 13)
        Me.lblFnlTst.TabIndex = 3
        Me.lblFnlTst.Text = "Final Test"
        '
        'txtTatapMuka
        '
        Me.txtTatapMuka.Location = New System.Drawing.Point(190, 121)
        Me.txtTatapMuka.Name = "txtTatapMuka"
        Me.txtTatapMuka.Size = New System.Drawing.Size(163, 20)
        Me.txtTatapMuka.TabIndex = 4
        '
        'txtMidTest
        '
        Me.txtMidTest.Location = New System.Drawing.Point(190, 152)
        Me.txtMidTest.Name = "txtMidTest"
        Me.txtMidTest.Size = New System.Drawing.Size(163, 20)
        Me.txtMidTest.TabIndex = 5
        '
        'txtFnlTst
        '
        Me.txtFnlTst.Location = New System.Drawing.Point(190, 186)
        Me.txtFnlTst.Name = "txtFnlTst"
        Me.txtFnlTst.Size = New System.Drawing.Size(163, 20)
        Me.txtFnlTst.TabIndex = 6
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.Color.Red
        Me.btnHitung.Font = New System.Drawing.Font("DFMincho-SU", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHitung.Location = New System.Drawing.Point(222, 232)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(67, 26)
        Me.btnHitung.TabIndex = 7
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'lblHasil
        '
        Me.lblHasil.AutoSize = True
        Me.lblHasil.Location = New System.Drawing.Point(112, 285)
        Me.lblHasil.Name = "lblHasil"
        Me.lblHasil.Size = New System.Drawing.Size(54, 13)
        Me.lblHasil.TabIndex = 8
        Me.lblHasil.Text = "Nilai Akhir"
        '
        'txtHasil
        '
        Me.txtHasil.Location = New System.Drawing.Point(190, 282)
        Me.txtHasil.Name = "txtHasil"
        Me.txtHasil.Size = New System.Drawing.Size(163, 20)
        Me.txtHasil.TabIndex = 9
        '
        'frmHitungNilai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 400)
        Me.Controls.Add(Me.txtHasil)
        Me.Controls.Add(Me.lblHasil)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtFnlTst)
        Me.Controls.Add(Me.txtMidTest)
        Me.Controls.Add(Me.txtTatapMuka)
        Me.Controls.Add(Me.lblFnlTst)
        Me.Controls.Add(Me.lblMidTest)
        Me.Controls.Add(Me.lblTatapMuka)
        Me.Controls.Add(Me.lblJudul)
        Me.MaximizeBox = False
        Me.Name = "frmHitungNilai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Program Hitung Nilai"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblTatapMuka As Label
    Friend WithEvents lblMidTest As Label
    Friend WithEvents lblFnlTst As Label
    Friend WithEvents txtTatapMuka As TextBox
    Friend WithEvents txtMidTest As TextBox
    Friend WithEvents txtFnlTst As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents lblHasil As Label
    Friend WithEvents txtHasil As TextBox
End Class
