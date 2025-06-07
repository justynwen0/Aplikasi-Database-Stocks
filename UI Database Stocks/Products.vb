Imports System.Data.SqlClient
Public Class Products
    Private Sub LoadData()
        Dim conn As New SqlConnection(My.MySettings.Default.ApkDatabaseStocks)
        Dim sql As String = "SELECT * FROM Products"
        Dim adapter As New SqlDataAdapter(sql, conn)
        Dim dt As New DataTable()

        Try
            conn.Open()
            adapter.Fill(dt)
            dgvPRODUCTS.DataSource = dt

            dgvPRODUCTS.ReadOnly = True
            dgvPRODUCTS.AllowUserToAddRows = False
            dgvPRODUCTS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Products2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub btnUPDATE_Click(sender As Object, e As EventArgs) Handles btnUPDATE.Click
        Dim conn As New SqlConnection
        Dim sql As String
        Dim cmd As New SqlCommand
        conn = New SqlConnection(My.MySettings.Default.ApkDatabaseStocks)
        ' Validasi: semua field wajib diisi
        If String.IsNullOrEmpty(txtNAMABARANG.Text) OrElse
            String.IsNullOrEmpty(txtHARGA.Text) OrElse
            String.IsNullOrEmpty(txtMEREKBARANG.Text) Then
            MessageBox.Show("Semua field harus diisi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNAMABARANG.Clear()
            txtHARGA.Clear()
            txtMEREKBARANG.Clear()
            txtNAMABARANG.Focus()
            Exit Sub
        End If

        conn.Open()

        ' Cek apakah data ada berdasarkan NamaBarang
        Dim cekSql As String = "SELECT COUNT(*) FROM Products WHERE NamaBarang = @nama"
        Dim cekCmd As New SqlCommand(cekSql, conn)
        cekCmd.Parameters.AddWithValue("@nama", Trim(txtNAMABARANG.Text))
        Dim count As Integer = Convert.ToInt32(cekCmd.ExecuteScalar())

        If count = 0 Then
            MessageBox.Show("Data tidak ditemukan di database!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            conn.Close()
            txtNAMABARANG.Focus()
            Exit Sub
        End If

        ' Jika ada, lakukan update
        sql = "UPDATE Products SET NamaBarang = @nama, Harga = @harga, MerekBarang = @merek WHERE NamaBarang = @nama"
        With cmd
            .Connection = conn
            .CommandText = sql
            .Parameters.AddWithValue("@nama", Trim(txtNAMABARANG.Text))
            .Parameters.AddWithValue("@harga", Trim(txtHARGA.Text))
            .Parameters.AddWithValue("@merek", Trim(txtMEREKBARANG.Text))
            .ExecuteNonQuery()
        End With

        conn.Close()
        MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadData()
    End Sub

    Private Sub btnDELETE_Click(sender As Object, e As EventArgs) Handles btnDELETE.Click
        Dim conn As New SqlConnection
        Dim sql As String
        Dim cmd As New SqlCommand
        conn = New SqlConnection(My.MySettings.Default.ApkDatabaseStocks)
        conn.Open()

        ' Cek apakah data ada
        Dim cekSql As String = "SELECT COUNT(*) FROM Products WHERE NamaBarang = @nama"
        Dim cekCmd As New SqlCommand(cekSql, conn)
        cekCmd.Parameters.AddWithValue("@nama", Trim(txtNAMABARANG.Text))
        Dim count As Integer = Convert.ToInt32(cekCmd.ExecuteScalar())

        If count = 0 Then
            MessageBox.Show("Data tidak ditemukan di database!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            conn.Close()

            ' Bersihkan dan fokuskan kembali
            txtNAMABARANG.Clear()
            txtHARGA.Clear()
            txtMEREKBARANG.Clear()
            txtNAMABARANG.Focus()
            Exit Sub
        End If

        ' Lanjut hapus jika ada
        sql = "DELETE FROM Products WHERE NamaBarang = @nama"
        With cmd
            .Connection = conn
            .CommandText = sql
            .Parameters.AddWithValue("@nama", Trim(txtNAMABARANG.Text))
            .ExecuteNonQuery()
        End With

        conn.Close()
        MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadData()

        ' Bersihkan input setelah berhasil
        txtNAMABARANG.Clear()
        txtHARGA.Clear()
        txtMEREKBARANG.Clear()
        txtNAMABARANG.Focus()
    End Sub

    Private Sub btnCANCEL_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        txtNAMABARANG.Text = ""
        txtHARGA.Text = ""
        txtMEREKBARANG.Text = ""
    End Sub
    Private Sub btnINSERT_Click(sender As Object, e As EventArgs) Handles btnINSERT.Click
        Dim conn As New SqlConnection
        Dim sql As String
        Dim cmd As New SqlCommand
        conn = New SqlConnection(My.MySettings.Default.ApkDatabaseStocks)

        ' Validasi field wajib diisi
        If String.IsNullOrEmpty(txtNAMABARANG.Text) OrElse
           String.IsNullOrEmpty(txtHARGA.Text) OrElse
           String.IsNullOrEmpty(txtMEREKBARANG.Text) Then

            MessageBox.Show(" Semua field harus diisi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNAMABARANG.Clear()
            txtHARGA.Clear()
            txtMEREKBARANG.Clear()
            txtNAMABARANG.Focus()
            Exit Sub
        End If

        ' Validasi harga angka bulat
        Dim harga As Integer
        If Not Integer.TryParse(txtHARGA.Text.Trim(), harga) Then
            MessageBox.Show("Harga harus berupa angka bulat!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHARGA.Clear()
            txtHARGA.Focus()
            Exit Sub
        End If

        conn.Open()

        ' Cek duplikasi berdasarkan NamaBarang
        Dim cekSql As String = "SELECT COUNT(*) FROM Products WHERE NamaBarang = @nama"
        Dim cekCmd As New SqlCommand(cekSql, conn)
        cekCmd.Parameters.AddWithValue("@nama", Trim(txtNAMABARANG.Text))
        Dim count As Integer = Convert.ToInt32(cekCmd.ExecuteScalar())

        If count > 0 Then
            MessageBox.Show("Data dengan nama tersebut sudah ada!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            conn.Close()
            txtNAMABARANG.Clear()
            txtHARGA.Clear()
            txtMEREKBARANG.Clear()
            txtNAMABARANG.Focus()
            Exit Sub
        End If

        ' Lanjut insert jika valid
        sql = "INSERT INTO Products (NamaBarang, Harga, MerekBarang) VALUES (@nama, @harga, @merek)"
        With cmd
            .Connection = conn
            .CommandText = sql
            .Parameters.AddWithValue("@nama", Trim(txtNAMABARANG.Text))
            .Parameters.AddWithValue("@harga", harga) ' harga sudah dipastikan integer
            .Parameters.AddWithValue("@merek", Trim(txtMEREKBARANG.Text))
            .ExecuteNonQuery()
        End With

        conn.Close()
        MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadData()

        ' Bersihkan field setelah berhasil
        txtNAMABARANG.Clear()
        txtHARGA.Clear()
        txtMEREKBARANG.Clear()
        txtNAMABARANG.Focus()
    End Sub
    Private Sub dgvPRODUCTS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPRODUCTS.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvPRODUCTS.Rows(e.RowIndex)
            txtNAMABARANG.Text = row.Cells(1).Value.ToString()
            txtHARGA.Text = row.Cells(2).Value.ToString()
            txtMEREKBARANG.Text = row.Cells(3).Value.ToString()
        End If
    End Sub

End Class