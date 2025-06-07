Imports System.Data.SqlClient
Public Class Suppliers
    Private Sub Suppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnINSERT_Click(sender As Object, e As EventArgs) Handles btnINSERT.Click
        Dim conn As New SqlConnection
        Dim sql As String
        Dim cmd As New SqlCommand
        conn = New SqlConnection(My.MySettings.Default.ApkDatabaseStocks)

        ' Validasi field wajib diisi
        If String.IsNullOrEmpty(txtNAMA.Text) OrElse
           String.IsNullOrEmpty(txtNOTELP.Text) OrElse
           String.IsNullOrEmpty(txtEMAIL.Text) Then

            MessageBox.Show(" Semua field harus diisi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNAMA.Clear()
            txtNOTELP.Clear()
            txtEMAIL.Clear()
            txtNAMA.Focus()
            Exit Sub
        End If

        ' Validasi format email harus mengandung @gmail.com
        If Not txtEMAIL.Text.ToLower().Contains("@gmail.com") Then
            MessageBox.Show("Email harus menggunakan format @gmail.com!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEMAIL.Focus()
            Exit Sub
        End If

        conn.Open()

        ' Cek duplikasi berdasarkan NamaBarang
        Dim cekSql As String = "SELECT COUNT(*) FROM Suppliers WHERE Nama = @Nama"
        Dim cekCmd As New SqlCommand(cekSql, conn)
        cekCmd.Parameters.AddWithValue("@Nama", Trim(txtNAMA.Text))
        Dim count As Integer = Convert.ToInt32(cekCmd.ExecuteScalar())

        If count > 0 Then
            MessageBox.Show("Data dengan nama tersebut sudah ada!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            conn.Close()
            txtNAMA.Clear()
            txtNOTELP.Clear()
            txtEMAIL.Clear()
            txtNAMA.Focus()
            Exit Sub
        End If

        ' Lanjut insert jika valid
        sql = "INSERT INTO Suppliers (Nama, NomorTelepon, Email) VALUES (@Nama, @NomorTelepon, @Email)"
        With cmd
            .Connection = conn
            .CommandText = sql
            .Parameters.AddWithValue("@Nama", Trim(txtNAMA.Text))
            .Parameters.AddWithValue("@NomorTelepon", Trim(txtNOTELP.Text))
            .Parameters.AddWithValue("@Email", Trim(txtEMAIL.Text))
            .ExecuteNonQuery()
        End With

        conn.Close()
        MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Bersihkan field setelah berhasil
        txtNAMA.Clear()
        txtNOTELP.Clear()
        txtEMAIL.Clear()
        txtNAMA.Focus()
    End Sub

    Private Sub btnUPDATE_Click(sender As Object, e As EventArgs) Handles btnUPDATE.Click
        Dim conn As New SqlConnection
        Dim sql As String
        Dim cmd As New SqlCommand
        conn = New SqlConnection(My.MySettings.Default.ApkDatabaseStocks)

        ' Validasi: semua field wajib diisi
        If String.IsNullOrEmpty(txtNAMA.Text) OrElse
            String.IsNullOrEmpty(txtNOTELP.Text) OrElse
            String.IsNullOrEmpty(txtEMAIL.Text) Then
            MessageBox.Show("Semua field harus diisi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNAMA.Clear()
            txtNOTELP.Clear()
            txtEMAIL.Clear()
            txtNAMA.Focus()
            Exit Sub
        End If

        conn.Open()

        ' Cek apakah data ada berdasarkan NamaBarang
        Dim cekSql As String = "SELECT COUNT(*) FROM Suppliers WHERE Nama = @Nama"
        Dim cekCmd As New SqlCommand(cekSql, conn)
        cekCmd.Parameters.AddWithValue("@Nama", Trim(txtNAMA.Text))
        Dim count As Integer = Convert.ToInt32(cekCmd.ExecuteScalar())

        If count = 0 Then
            MessageBox.Show("Data tidak ditemukan di database!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            conn.Close()
            txtNAMA.Focus()
            Exit Sub
        End If

        ' Jika ada, lakukan update
        sql = "UPDATE Suppliers SET Nama = @Nama, NomorTelepon = @NomorTelepon, Email = @Email WHERE Nama = @Nama"
        With cmd
            .Connection = conn
            .CommandText = sql
            .Parameters.AddWithValue("@Nama", Trim(txtNAMA.Text))
            .Parameters.AddWithValue("@NomorTelepon", Trim(txtNOTELP.Text))
            .Parameters.AddWithValue("@Email", Trim(txtEMAIL.Text))
            .ExecuteNonQuery()
        End With

        conn.Close()
        MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnDELETE_Click(sender As Object, e As EventArgs) Handles btnDELETE.Click
        Dim conn As New SqlConnection
        Dim sql As String
        Dim cmd As New SqlCommand
        conn = New SqlConnection(My.MySettings.Default.ApkDatabaseStocks)
        conn.Open()

        ' Cek apakah data ada
        Dim cekSql As String = "SELECT COUNT(*) FROM Suppliers WHERE Nama = @Nama"
        Dim cekCmd As New SqlCommand(cekSql, conn)
        cekCmd.Parameters.AddWithValue("@Nama", Trim(txtNAMA.Text))
        Dim count As Integer = Convert.ToInt32(cekCmd.ExecuteScalar())

        If count = 0 Then
            MessageBox.Show("Data tidak ditemukan di database!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            conn.Close()

            ' Bersihkan dan fokuskan kembali
            txtNAMA.Clear()
            txtNOTELP.Clear()
            txtEMAIL.Clear()
            txtNAMA.Focus()
            Exit Sub
        End If

        ' Lanjut hapus jika ada
        sql = "DELETE FROM Suppliers WHERE Nama = @Nama"
        With cmd
            .Connection = conn
            .CommandText = sql
            .Parameters.AddWithValue("@Nama", Trim(txtNAMA.Text))
            .ExecuteNonQuery()
        End With

        conn.Close()
        MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Bersihkan input setelah berhasil
        txtNAMA.Clear()
        txtNOTELP.Clear()
        txtEMAIL.Clear()
        txtNAMA.Focus()
    End Sub

    Private Sub btnCANCEL_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        txtNAMA.Text = ""
        txtNOTELP.Text = ""
        txtEMAIL.Text = ""
    End Sub
End Class