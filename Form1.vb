Public Class frmHitungNilai
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblHasil.Click

    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim nilaiTatapMuka, nilaiMidTest, nilaiFnlTst As Double
        nilaiTatapMuka = Val(txtTatapMuka.Text)
        nilaiMidTest = Val(txtMidTest.Text)
        nilaiFnlTst = Val(txtFnlTst.Text)
        txtHasil.Text = (nilaiTatapMuka + nilaiMidTest + nilaiFnlTst) / 3
    End Sub
End Class
