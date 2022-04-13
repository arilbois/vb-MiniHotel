Public Class Form1
    Dim xlama, xharga, xbiaya, xxbiaya, xjumlah, xkembali As Integer
    Dim xkamar As String
    Private Sub kamar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kamar.SelectedIndexChanged

        xkamar = kamar.Text

        Select Case xkamar
            Case "VIP"
                xharga = 750000
            Case "Kelas I"
                xharga = 500000
            Case "Kelas II"
                xharga = 300000
            Case "Kelas III"
                xharga = 150000
        End Select
        harga.Text = xharga
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub


    Private Sub lama_TextChanged(sender As Object, e As EventArgs) Handles lama.TextChanged
        xlama = Val(lama.Text)
        xbiaya = xlama * xharga

        Biaya.Text = xbiaya
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lama.Clear()
        harga.Clear()
        Biaya.Clear()
        jumlah.Clear()
        kembali.Clear()
    End Sub

    Private Sub jumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jumlah.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            xjumlah = Val(jumlah.Text)
            xkembali = xjumlah - xbiaya

            kembali.Text = xkembali




        End If
    End Sub
End Class
