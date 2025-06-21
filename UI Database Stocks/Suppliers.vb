Imports System.Data.SqlClient
Public Class Suppliers
    Private Sub LoadData()
        Dim conn As New SqlConnection(DatabaseHelper.GetConnectionString())
        Dim sql As String = "SELECT * FROM Suppliers"
        Dim adapter As New SqlDataAdapter(sql, conn)
        Dim dt As New DataTable()

        Try
            conn.Open()
            adapter.Fill(dt)
            dgvSUPPLIERS.DataSource = dt

            dgvSUPPLIERS.ReadOnly = True
            dgvSUPPLIERS.AllowUserToAddRows = False
            dgvSUPPLIERS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Suppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub btnUPDATE_Click(sender As Object, e As EventArgs) Handles btnUPDATE.Click
        Dim conn As New SqlConnection
        Dim sql As String
        Dim cmd As New SqlCommand
        conn = New SqlConnection(DatabaseHelper.GetConnectionString())
        Dim ID As Integer = Convert.ToInt32(dgvSUPPLIERS.CurrentRow.Cells("ID").Value)


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

        ' Cek apakah data ada berdasarkan Namasuppliers baru
        Dim cekSql As String = "SELECT COUNT(*) FROM Suppliers WHERE ID = @ID"
        Dim cekCmd As New SqlCommand(cekSql, conn)
        cekCmd.Parameters.AddWithValue("@ID", ID)
        Dim count As Integer = Convert.ToInt32(cekCmd.ExecuteScalar())

        If count = 0 Then
            MessageBox.Show("Data tidak ditemukan di database!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            conn.Close()
            txtNAMA.Focus()
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show("Anda ingin memperbarui data suppliers dengan kode """ & ID & """?" & vbCrLf &
                                                  "Nama: " & txtNAMA.Text.Trim() & vbCrLf &
                                                  "NomorTelepon: " & txtNOTELP.Text.Trim() & vbCrLf &
                                                  "Email: " & txtEMAIL.Text.Trim(),
                                                  "Konfirmasi Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.No Then
            conn.Close()
            Exit Sub
        End If


        ' Jika ada, lakukan update
        sql = "UPDATE Suppliers SET Nama = @nama, NomorTelepon = @nomor, email = @email WHERE ID = @ID"
        With cmd
            .Connection = conn
            .CommandText = sql
            .Parameters.AddWithValue("@nama", Trim(txtNAMA.Text))
            .Parameters.AddWithValue("@nomor", Trim(txtNOTELP.Text))
            .Parameters.AddWithValue("@email", Trim(txtEMAIL.Text))
            .Parameters.AddWithValue("@ID", ID)
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
        conn = New SqlConnection(DatabaseHelper.GetConnectionString())
        Dim ID As Integer = Convert.ToInt32(dgvSUPPLIERS.CurrentRow.Cells("ID").Value)
        conn.Open()


        ' Cek apakah data ada
        Dim cekSql As String = "SELECT COUNT(*) FROM Suppliers WHERE ID = @ID"
        Dim cekCmd As New SqlCommand(cekSql, conn)
        cekCmd.Parameters.AddWithValue("@ID", ID)
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

        Dim konfirmasi As DialogResult = MessageBox.Show("Anda ingin menghapus data suppliers dengan kode """ & ID & """?" & vbCrLf &
                                                  "Nama: " & txtNAMA.Text.Trim() & vbCrLf &
                                                  "NomorTelepon: " & txtNOTELP.Text.Trim() & vbCrLf &
                                                  "Email: " & txtEMAIL.Text.Trim(),
                                                  "Konfirmasi Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.No Then
            conn.Close()
            Exit Sub
        End If

        ' Lanjut hapus jika ada
        sql = "DELETE FROM Suppliers WHERE ID = @ID"
        With cmd
            .Connection = conn
            .CommandText = sql
            .Parameters.AddWithValue("@ID", ID)
            .ExecuteNonQuery()
        End With

        conn.Close()
        MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadData()

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
    Private Sub btnINSERT_Click(sender As Object, e As EventArgs) Handles btnINSERT.Click
        Dim conn As New SqlConnection
        Dim sql As String
        Dim cmd As New SqlCommand
        conn = New SqlConnection(DatabaseHelper.GetConnectionString())

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

        ' Cek duplikasi berdasarkan Namasuppliers baru
        Dim cekSql As String = "SELECT COUNT(*) FROM Suppliers WHERE Nama = @nama"
        Dim cekCmd As New SqlCommand(cekSql, conn)
        cekCmd.Parameters.AddWithValue("@nama", Trim(txtNAMA.Text))
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

        Dim konfirmasi As DialogResult = MessageBox.Show("Anda ingin menambahkan data suppliers dengan " & vbCrLf &
                                                  "Nama: " & txtNAMA.Text.Trim() & vbCrLf &
                                                  "NomorTelepon: " & txtNOTELP.Text.Trim() & vbCrLf &
                                                  "Email: " & txtEMAIL.Text.Trim(),
                                                  "Konfirmasi Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.No Then
            conn.Close()
            Exit Sub
        End If

        ' Lanjut insert jika valid
        sql = "INSERT INTO Suppliers (Nama, NomorTelepon, Email) VALUES (@nama, @nomor, @email)"
        With cmd
            .Connection = conn
            .CommandText = sql
            .Parameters.AddWithValue("@nama", Trim(txtNAMA.Text))
            .Parameters.AddWithValue("@nomor", Trim(txtNOTELP.Text))
            .Parameters.AddWithValue("@email", Trim(txtEMAIL.Text))
            .ExecuteNonQuery()
        End With

        conn.Close()
        MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadData()

        ' Bersihkan field setelah berhasil
        txtNAMA.Clear()
        txtNOTELP.Clear()
        txtEMAIL.Clear()
        txtNAMA.Focus()
    End Sub
    Private Sub dgvSUPPLIERS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSUPPLIERS.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSUPPLIERS.Rows(e.RowIndex)
            txtNAMA.Text = row.Cells(1).Value.ToString()
            txtNOTELP.Text = row.Cells(2).Value.ToString()
            txtEMAIL.Text = row.Cells(3).Value.ToString()
        End If
    End Sub
End Class