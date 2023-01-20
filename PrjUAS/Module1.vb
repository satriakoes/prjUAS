Imports MySql.Data.MySqlClient

Module Module1
    Dim strkon As String = "server=localhost;uid=root;database=Transaksi"
    Public kon As New MySqlConnection(strkon)
    Public perintah As New MySqlCommand
    Public cek As MySqlDataReader
    Public mda As New MySqlDataAdapter
    Public ds As New DataSet
    Public user As String
    Public simpan As Boolean
    Public password As String
    Public Nama_User As String
End Module
