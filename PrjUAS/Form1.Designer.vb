<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtransaksi
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
        Me.txtjumlahbarang = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtjumlahbayar = New System.Windows.Forms.TextBox()
        Me.dgtransaksi = New System.Windows.Forms.DataGridView()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        CType(Me.dgtransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtjumlahbarang
        '
        Me.txtjumlahbarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjumlahbarang.Location = New System.Drawing.Point(171, 186)
        Me.txtjumlahbarang.Name = "txtjumlahbarang"
        Me.txtjumlahbarang.Size = New System.Drawing.Size(227, 28)
        Me.txtjumlahbarang.TabIndex = 20
        '
        'txtnama
        '
        Me.txtnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(171, 88)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(316, 28)
        Me.txtnama.TabIndex = 19
        '
        'txtharga
        '
        Me.txtharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtharga.Location = New System.Drawing.Point(171, 136)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(227, 28)
        Me.txtharga.TabIndex = 22
        '
        'txtkode
        '
        Me.txtkode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkode.Location = New System.Drawing.Point(171, 44)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(227, 28)
        Me.txtkode.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Futura Md BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 21)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Jumlah Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Futura Md BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 21)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Harga Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Futura Md BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 21)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Futura Md BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 21)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Kode Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Futura Md BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 21)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Jumlah Bayar"
        '
        'txtjumlahbayar
        '
        Me.txtjumlahbayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjumlahbayar.Location = New System.Drawing.Point(171, 244)
        Me.txtjumlahbayar.Name = "txtjumlahbayar"
        Me.txtjumlahbayar.Size = New System.Drawing.Size(227, 28)
        Me.txtjumlahbayar.TabIndex = 28
        '
        'dgtransaksi
        '
        Me.dgtransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtransaksi.Location = New System.Drawing.Point(36, 391)
        Me.dgtransaksi.Name = "dgtransaksi"
        Me.dgtransaksi.RowTemplate.Height = 28
        Me.dgtransaksi.Size = New System.Drawing.Size(614, 186)
        Me.dgtransaksi.TabIndex = 29
        '
        'btnkeluar
        '
        Me.btnkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.Image = Global.PrjUAS.My.Resources.Resources.icons8_power_off_button_24
        Me.btnkeluar.Location = New System.Drawing.Point(61, 296)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(537, 70)
        Me.btnkeluar.TabIndex = 18
        Me.btnkeluar.Text = "&Keluar"
        Me.btnkeluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.Image = Global.PrjUAS.My.Resources.Resources.back
        Me.btnbatal.Location = New System.Drawing.Point(535, 231)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(130, 44)
        Me.btnbatal.TabIndex = 17
        Me.btnbatal.Text = "&Batal"
        Me.btnbatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Image = Global.PrjUAS.My.Resources.Resources.delete
        Me.btnHapus.Location = New System.Drawing.Point(535, 168)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(130, 44)
        Me.btnHapus.TabIndex = 16
        Me.btnHapus.Text = "&Hapus"
        Me.btnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.Image = Global.PrjUAS.My.Resources.Resources.icons8_save_241
        Me.btnsimpan.Location = New System.Drawing.Point(535, 102)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(130, 42)
        Me.btnsimpan.TabIndex = 15
        Me.btnsimpan.Text = "&Simpan"
        Me.btnsimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.Image = Global.PrjUAS.My.Resources.Resources.add1
        Me.btntambah.Location = New System.Drawing.Point(535, 44)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(130, 43)
        Me.btntambah.TabIndex = 14
        Me.btntambah.Text = "&Tambah"
        Me.btntambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'frmtransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(704, 589)
        Me.Controls.Add(Me.dgtransaksi)
        Me.Controls.Add(Me.txtjumlahbayar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtkode)
        Me.Controls.Add(Me.txtjumlahbarang)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btntambah)
        Me.Name = "frmtransaksi"
        Me.Text = "Form Transaksi Barang"
        CType(Me.dgtransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents txtjumlahbarang As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtharga As System.Windows.Forms.TextBox
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtjumlahbayar As System.Windows.Forms.TextBox
    Friend WithEvents dgtransaksi As System.Windows.Forms.DataGridView

End Class
