Imports System.Data.SqlClient
Public Class Customers
    Private Sub LoadData()
        Dim conn As New SqlConnection(DatabaseHelper.GetConnectionString())
        Dim sql As String = "SELECT * FROM Customers"
        Dim adapter As New SqlDataAdapter(sql, conn)
        Dim dt As New DataTable()

        Try
            conn.Open()
            adapter.Fill(dt)
            dgvCUSTOMERS.DataSource = dt

            dgvCUSTOMERS.ReadOnly = True
            dgvCUSTOMERS.AllowUserToAddRows = False
            dgvCUSTOMERS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnUPDATECUSTOMERS_Click_1(sender As Object, e As EventArgs) Handles btnUPDATECUSTOMERS.Click
        Dim conn As New SqlConnection
        Dim sql As String
        Dim cmd As New SqlCommand
        conn = New SqlConnection(DatabaseHelper.GetConnectionString())
        Dim IDCustomer As Integer = Convert.ToInt32(dgvCUSTOMERS.CurrentRow.Cells("ID").Value)

        ' Validasi: semua field wajib diisi
        If String.IsNullOrEmpty(txtNAMACUSTOMERS.Text) OrElse
            String.IsNullOrEmpty(txtNOMORTELEPONCUSTOMERS.Text) OrElse
            String.IsNullOrEmpty(txtEMAILCUSTOMERS.Text) Then
            MessageBox.Show("Semua field harus diisi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNAMACUSTOMERS.Clear()
            txtNOMORTELEPONCUSTOMERS.Clear()
            txtEMAILCUSTOMERS.Clear()
            txtNAMACUSTOMERS.Focus()
            Exit Sub
        End If

        conn.Open()

        ' Cek apakah data ada berdasarkan NAMACUSTOMERS
        Dim cekSql As String = "SELECT COUNT(*) FROM Customers WHERE ID = @ID"
        Dim cekCmd As New SqlCommand(cekSql, conn)
        cekCmd.Parameters.AddWithValue("@ID", IDCustomer)
        Dim count As Integer = Convert.ToInt32(cekCmd.ExecuteScalar())

        If count = 0 Then
            MessageBox.Show("Data tidak ditemukan di database!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            conn.Close()
            txtNAMACUSTOMERS.Focus()
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show("Anda ingin memperbarui data customers dengan kode """ & IDCustomer & """?" & vbCrLf &
                                                  "Nama: " & txtNAMACUSTOMERS.Text.Trim() & vbCrLf &
                                                  "NomorTelepon: " & txtNOMORTELEPONCUSTOMERS.Text.Trim() & vbCrLf &
                                                  "Email: " & txtEMAILCUSTOMERS.Text.Trim(),
                                                  "Konfirmasi Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.No Then
            conn.Close()
            Exit Sub
        End If


        ' Jika ada, lakukan update
        sql = "UPDATE Customers SET Nama = @nama, NomorTelepon = @nomortelepon, email = @email WHERE ID = @ID"
        With cmd
            .Connection = conn
            .CommandText = sql
            .Parameters.AddWithValue("@nama", Trim(txtNAMACUSTOMERS.Text))
            .Parameters.AddWithValue("@nomortelepon", Trim(txtNOMORTELEPONCUSTOMERS.Text))
            .Parameters.AddWithValue("@email", Trim(txtEMAILCUSTOMERS.Text))
            .Parameters.AddWithValue("@ID", IDCustomer)
            .ExecuteNonQuery()
        End With

        conn.Close()
        MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadData()
    End Sub

    Private Sub btnDELETECUSTOMERS_Click_1(sender As Object, e As EventArgs) Handles btnDELETECUSTOMERS.Click
        Dim conn As New SqlConnection
        Dim sql As String
        Dim cmd As New SqlCommand
        conn = New SqlConnection(DatabaseHelper.GetConnectionString())
        Dim IDCustomers As Integer = Convert.ToInt32(dgvCUSTOMERS.CurrentRow.Cells("ID").Value)
        conn.Open()

        ' Cek apakah data ada
        Dim cekSql As String = "SELECT COUNT(*) FROM Customers WHERE ID = @ID"
        Dim cekCmd As New SqlCommand(cekSql, conn)
        cekCmd.Parameters.AddWithValue("@ID", IDCustomers)
        Dim count As Integer = Convert.ToInt32(cekCmd.ExecuteScalar())

        If count = 0 Then
            MessageBox.Show("Data tidak ditemukan di database!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            conn.Close()

            ' Bersihkan dan fokuskan kembali
            txtNAMACUSTOMERS.Clear()
            txtNOMORTELEPONCUSTOMERS.Clear()
            txtEMAILCUSTOMERS.Clear()
            txtNAMACUSTOMERS.Focus()
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show("Anda ingin menghapus data customer dengan kode """ & IDCustomers & """?" & vbCrLf &
                                                  "Nama: " & txtNAMACUSTOMERS.Text.Trim() & vbCrLf &
                                                  "NomorTelepon: " & txtNOMORTELEPONCUSTOMERS.Text.Trim() & vbCrLf &
                                                  "Email: " & txtEMAILCUSTOMERS.Text.Trim(),
                                                  "Konfirmasi Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.No Then
            conn.Close()
            Exit Sub
        End If

        ' Lanjut hapus jika ada
        sql = "DELETE FROM Customers WHERE ID = @ID"
        With cmd
            .Connection = conn
            .CommandText = sql
            .Parameters.AddWithValue("@ID", IDCustomers)
            .ExecuteNonQuery()
        End With

        conn.Close()
        MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadData()

        ' Bersihkan input setelah berhasil
        txtNAMACUSTOMERS.Clear()
        txtNOMORTELEPONCUSTOMERS.Clear()
        txtEMAILCUSTOMERS.Clear()
        txtNAMACUSTOMERS.Focus()
    End Sub

    Private Sub btnINSERTCUSTOMERS_Click_1(sender As Object, e As EventArgs) Handles btnINSERTCUSTOMERS.Click
        Dim conn As New SqlConnection
        Dim sql As String
        Dim cmd As New SqlCommand
        conn = New SqlConnection(DatabaseHelper.GetConnectionString())


        ' Validasi field wajib diisi
        If String.IsNullOrEmpty(txtNAMACUSTOMERS.Text) OrElse
           String.IsNullOrEmpty(txtNOMORTELEPONCUSTOMERS.Text) OrElse
           String.IsNullOrEmpty(txtEMAILCUSTOMERS.Text) Then

            MessageBox.Show(" Semua field harus diisi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNAMACUSTOMERS.Clear()
            txtNOMORTELEPONCUSTOMERS.Clear()
            txtEMAILCUSTOMERS.Clear()
            txtNAMACUSTOMERS.Focus()
            Exit Sub
        End If

        ' Validasi format email harus mengandung @gmail.com
        If Not txtEMAILCUSTOMERS.Text.ToLower().Contains("@gmail.com") Then
            MessageBox.Show("Email harus menggunakan format @gmail.com!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEMAILCUSTOMERS.Focus()
            Exit Sub
        End If

        conn.Open()

        ' Cek duplikasi berdasarkan NamaCustomers baru
        Dim cekSql As String = "SELECT COUNT(*) FROM Customers WHERE Nama = @nama"
        Dim cekCmd As New SqlCommand(cekSql, conn)
        cekCmd.Parameters.AddWithValue("@nama", Trim(txtNAMACUSTOMERS.Text))
        Dim count As Integer = Convert.ToInt32(cekCmd.ExecuteScalar())

        If count > 0 Then
            MessageBox.Show("Data dengan nama tersebut sudah ada!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            conn.Close()
            txtNAMACUSTOMERS.Clear()
            txtNOMORTELEPONCUSTOMERS.Clear()
            txtEMAILCUSTOMERS.Clear()
            txtNAMACUSTOMERS.Focus()
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show("Anda ingin menambahkan data customer dengan " & vbCrLf &
                                                  "Nama: " & txtNAMACUSTOMERS.Text.Trim() & vbCrLf &
                                                  "NomorTelepon: " & txtNOMORTELEPONCUSTOMERS.Text.Trim() & vbCrLf &
                                                  "Email: " & txtEMAILCUSTOMERS.Text.Trim(),
                                                  "Konfirmasi Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.No Then
            conn.Close()
            Exit Sub
        End If

        ' Lanjut insert jika valid
        sql = "INSERT INTO Customers (Nama, NomorTelepon, Email) VALUES (@nama, @nomortelepon, @email)"
        With cmd
            .Connection = conn
            .CommandText = sql
            .Parameters.AddWithValue("@nama", Trim(txtNAMACUSTOMERS.Text))
            .Parameters.AddWithValue("@nomortelepon", Trim(txtNOMORTELEPONCUSTOMERS.Text))
            .Parameters.AddWithValue("@email", Trim(txtEMAILCUSTOMERS.Text))
            .ExecuteNonQuery()
        End With

        conn.Close()
        MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadData()

        ' Bersihkan field setelah berhasil
        txtNAMACUSTOMERS.Clear()
        txtNOMORTELEPONCUSTOMERS.Clear()
        txtEMAILCUSTOMERS.Clear()
        txtNAMACUSTOMERS.Focus()
    End Sub

    Private Sub btnCANCELCUSTOMERS_Click_1(sender As Object, e As EventArgs) Handles btnCANCELCUSTOMERS.Click
        txtNAMACUSTOMERS.Text = ""
        txtNOMORTELEPONCUSTOMERS.Text = ""
        txtEMAILCUSTOMERS.Text = ""
    End Sub

    Private Sub dgvCUSTOMERS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCUSTOMERS.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvCUSTOMERS.Rows(e.RowIndex)
            txtNAMACUSTOMERS.Text = row.Cells(1).Value.ToString()
            txtNOMORTELEPONCUSTOMERS.Text = row.Cells(2).Value.ToString()
            txtEMAILCUSTOMERS.Text = row.Cells(3).Value.ToString()
        End If
    End Sub
End Class