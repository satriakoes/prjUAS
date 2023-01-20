Public Class frmtransaksi
    Sub tampiltransaksi(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "Barang")
        dgtransaksi.DataSource = (ds.Tables("Barang"))
        kon.Close()
    End Sub
    Sub prosestransaksi(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        perintah.ExecuteNonQuery()
        kon.Close()
    End Sub
    Sub setdatagrid()
        dgtransaksi.Columns(0).HeaderText = "Kode Barang"
        dgtransaksi.Columns(1).HeaderText = "Nama Barang"
        dgtransaksi.Columns(2).HeaderText = "HARGA"
        dgtransaksi.Columns(3).HeaderText = "Jumlah Barang"
        dgtransaksi.Columns(4).HeaderText = "Total Bayar"

        dgtransaksi.Columns(0).Width = 70
        dgtransaksi.Columns(1).Width = 100
        dgtransaksi.Columns(2).Width = 50
        dgtransaksi.Columns(3).Width = 50
        dgtransaksi.Columns(3).Width = 50
    End Sub
    Sub tidakaktif()
        txtkode.Enabled = False
        txtnama.Enabled = False
        txtharga.Enabled = False
        txtjumlahbarang.Enabled = False
        txtjumlahbayar.Enabled = False
        btnsimpan.Enabled = False
        btnbatal.Enabled = False
        btnhapus.Enabled = False
        txtkode.BackColor = Color.Gray
        txtnama.BackColor = Color.Gray
        txtharga.BackColor = Color.Gray
        txtjumlahbarang.BackColor = Color.Gray
        txtjumlahbayar.BackColor = Color.Gray
    End Sub
    Sub aktif()
        txtkode.Enabled = True
        txtnama.Enabled = True
        txtharga.Enabled = True
        txtjumlahbarang.Enabled = True
        txtjumlahbayar.Enabled = True
        txtkode.BackColor = Color.White
        txtnama.BackColor = Color.White
        txtharga.BackColor = Color.White
        txtjumlahbarang.BackColor = Color.White
        txtjumlahbayar.BackColor = Color.White
    End Sub
    Sub bersih()
        txtkode.Text = ""
        txtnama.Text = ""
        txtharga.Text = ""
        txtjumlahbarang.Text = ""
        txtjumlahbayar.Text = ""
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampiltransaksi("select * from Barang")
        setdatagrid()
        tidakaktif()
    End Sub

    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        tidakaktif()
        bersih()
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        bersih()
        aktif()
        btntambah.Enabled = False
        btnbatal.Enabled = True
        btnsimpan.Enabled = True
        btnHapus.Enabled = False
        txtkode.Focus()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        prosestransaksi("insert into Barang values('" & txtkode.Text & "','" &
                        txtnama.Text & "','" & txtharga.Text & "','" & txtjumlahbarang.Text & "','" & txtjumlahbayar.Text & "')")
        MsgBox("Data Telah Tersimpan", MsgBoxStyle.Information, "Informasi")

        tampiltransaksi("select* from Barang")
        setdatagrid()
        bersih()
        tidakaktif()
        btnsimpan.Enabled = False
        btntambah.Enabled = True
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        prosestransaksi("delete from Barang where Id_Barang='" & txtkode.Text & "'")

        MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Sukses")
        tampiltransaksi("select* from Barang")
        setdatagrid()
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        btntambah.Enabled = True
        btnbatal.Enabled = False
        btntambah.Focus()
        btnHapus.Enabled = False
        bersih()
        tidakaktif()
        btnsimpan.Enabled = False
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Dispose()
    End Sub

    Private Sub txtkode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkode.KeyPress
        If e.KeyChar = Chr(13) Then
            txtkode.Text = UCase(txtkode.Text)
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "select * from Barang WHERE Id_Barang='" &
            txtkode.Text & "'"
            cek = perintah.ExecuteReader
            cek.Read()
            If cek.HasRows Then
                txtkode.Enabled = False
                txtnama.Text = cek.Item("Nama_Barang")
                txtharga.Text = cek.Item("Harga_Barang")
                txtjumlahbarang.Text = cek.Item("Jumlah_Barang")
                txtjumlahbayar.Text = cek.Item("Total_Bayar")
                btnsimpan.Enabled = False
            Else
                btnsimpan.Enabled = True
            End If
            cek.Close()
            kon.Close()
            aktif()
            txtnama.Focus()
        End If
    End Sub

    Private Sub txtnama_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnama.KeyPress
        If e.KeyChar = Chr(13) Then
            txtnama.Text = UCase(txtnama.Text)
            txtharga.Focus()
        End If
    End Sub

    Private Sub txtharga_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtharga.KeyPress
        If e.KeyChar = Chr(13) Then
            txtjumlahbarang.Focus()
        End If
    End Sub

    Private Sub txtjumlahbarang_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjumlahbarang.KeyPress
        If e.KeyChar = Chr(13) Then
            txtjumlahbayar.Focus()
        End If
    End Sub

    Private Sub txtjumlahbayar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjumlahbayar.KeyPress
        If e.KeyChar = Chr(13) Then
            btnsimpan.Focus()
        End If
    End Sub

    Private Sub dgtransaksi_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgtransaksi.CellClick
        aktif()
        txtkode.Enabled = False
        Dim i As Integer
        i = Me.dgtransaksi.CurrentRow.Index
        With dgtransaksi.Rows.Item(i)
            txtkode.Text = .Cells(0).Value
            txtnama.Text = .Cells(1).Value
            txtharga.Text = .Cells(2).Value
            txtjumlahbarang.Text = .Cells(3).Value
            txtjumlahbayar.Text = .Cells(4).Value
            txtkode.Focus()
            btnHapus.Enabled = True
            btnsimpan.Enabled = False
            btnbatal.Enabled = True
            btntambah.Enabled = False
        End With
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
