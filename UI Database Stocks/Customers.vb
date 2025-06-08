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

    Private Sub btnUPDATECUSTOMERS_Click(sender As Object, e As EventArgs) Handles btnUPDATECUSTOMERS.Click
        Dim conn As New SqlConnection
        Dim sql As String
        Dim cmd As New SqlCommand
        conn = New SqlConnection(DatabaseHelper.GetConnectionString())
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
        Dim cekSql As String = "SELECT COUNT(*) FROM Customers WHERE NamaCustomers = @nama"
        Dim cekCmd As New SqlCommand(cekSql, conn)
        cekCmd.Parameters.AddWithValue("@NamaCustomers", Trim(txtNAMACUSTOMERS.Text))
        Dim count As Integer = Convert.ToInt32(cekCmd.ExecuteScalar())

        If count = 0 Then
            MessageBox.Show("Data tidak ditemukan di database!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            conn.Close()
            txtNAMACUSTOMERS.Focus()
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show("Anda ingin memperbaharui customer dengan nama """ & txtNAMACUSTOMERS.Text.Trim() & """, dengan nomor telepon """ & txtNOMORTELEPONCUSTOMERS.Text.Trim() & """, dan emailnya """ & txtEMAILCUSTOMERS.Text.Trim() & """?", "Konfirmasi Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.No Then
            conn.Close()
            Exit Sub
        End If


        ' Jika ada, lakukan update
        sql = "UPDATE Customers SET NamaCustomers = @NamaCustomers, NomorTeleponCustomer = @NomorTeleponCustomers, EmailCustomer = @EmailCustomers WHERE NamaCustomers = @nama"
        With cmd
            .Connection = conn
            .CommandText = sql
            .Parameters.AddWithValue("@NamaCustomers", Trim(txtNAMACUSTOMERS.Text))
            .Parameters.AddWithValue("@NomorTeleponCustomers", Trim(txtNOMORTELEPONCUSTOMERS.Text))
            .Parameters.AddWithValue("@EmailCustomers", Trim(txtEMAILCUSTOMERS.Text))
            .ExecuteNonQuery()
        End With

        conn.Close()
        MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadData()
    End Sub

    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
End Class