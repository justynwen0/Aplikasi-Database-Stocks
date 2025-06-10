Imports System.Data.SqlClient
Public Class Orders
    Private Sub FormOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Di form tempat ComboBox berada
        LoadCustomersToComboBox()
        LoadProductsToComboBox()
        txtHARGASATUAN.ReadOnly = True
        txtHARGA.ReadOnly = True

        dgvORDERS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvORDERS.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvORDERS.ReadOnly = True

        LoadOrders()
    End Sub

    Private Sub LoadOrders()
        Dim conn As New SqlConnection(DatabaseHelper.GetConnectionString())
        Dim query As String = "
        SELECT 
            o.PembelianBarangID AS OrderID,
            o.TanggalOrders,
            o.Harga,
            d.KuantitasBarang,
            d.HargaSatuan,
            c.Nama AS NamaCustomers,
            p.NamaBarang
        FROM Orders o
        JOIN DetailOrders d ON o.PembelianBarangID = d.Orders_PembelianBarangID
        JOIN InventoryStock_has_Orders i ON i.Orders_PembelianBarangID = o.PembelianBarangID
        JOIN Customers c ON c.ID = i.Customers_ID
        JOIN Products p ON p.KodeBarang = i.Products_KodeBarang
    "

        Dim adapter As New SqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            dgvORDERS.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadCustomersToComboBox()
        Dim conn As New SqlConnection(DatabaseHelper.GetConnectionString())
        Dim cmd As New SqlCommand("SELECT Nama FROM Customers", conn)
        Dim reader As SqlDataReader

        Try
            conn.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                cmbCUSTOMERS.Items.Add(reader("Nama").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show("Gagal memuat customer: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadProductsToComboBox()
        Dim conn As New SqlConnection(DatabaseHelper.GetConnectionString())
        Dim cmd As New SqlCommand("SELECT NamaBarang FROM Products", conn)
        Dim reader As SqlDataReader

        Try
            conn.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                cmbPRODUCTS.Items.Add(reader("NamaBarang").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show("Gagal memuat produk: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub cmbPRODUCTS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPRODUCTS.SelectedIndexChanged

        Dim selectedProduct As String = cmbPRODUCTS.SelectedItem.ToString()

        Dim conn As New SqlConnection(DatabaseHelper.GetConnectionString())
        Dim cmd As New SqlCommand("SELECT Harga FROM Products WHERE NamaBarang = @NamaBarang", conn)
        cmd.Parameters.AddWithValue("@NamaBarang", selectedProduct)

        Try
            conn.Open()
            Dim result As Object = cmd.ExecuteScalar()

            If result IsNot Nothing Then
                Dim hargaSatuan As Integer = Convert.ToInt32(result)
                txtHARGASATUAN.Text = hargaSatuan.ToString()
                HitungTotalHarga()
            Else
                MessageBox.Show("Harga produk tidak ditemukan di database.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error mengambil harga: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub HitungTotalHarga()
        Dim qty As Integer
        Dim hargaSatuan As Integer

        If Integer.TryParse(txtQUANTITY.Text, qty) AndAlso Integer.TryParse(txtHARGASATUAN.Text, hargaSatuan) Then
            txtHARGA.Text = (qty * hargaSatuan).ToString()
        Else
            txtHARGA.Text = ""
        End If
    End Sub

    Private Sub txtQUANTITY_TextChanged(sender As Object, e As EventArgs) Handles txtQUANTITY.TextChanged
        HitungTotalHarga()
    End Sub

    Private Sub btnINSERTORDERS_Click(sender As Object, e As EventArgs) Handles btnINSERTORDERS.Click

        Dim conn As New SqlConnection(DatabaseHelper.GetConnectionString())
        Dim insertedOrderId As Integer
        Dim trans As SqlTransaction = Nothing

        Try
            conn.Open()
            trans = conn.BeginTransaction()

            ' Insert ke tabel Orders
            Dim cmd As New SqlCommand("
                INSERT INTO Orders (TanggalOrders, Harga)
                VALUES (@TanggalOrders, @Harga);
                SELECT CAST(SCOPE_IDENTITY() AS INT);
            ", conn, trans)

            cmd.Parameters.AddWithValue("@TanggalOrders", dtpORDERS.Value)
            cmd.Parameters.AddWithValue("@Harga", Convert.ToDecimal(txtHARGA.Text))

            insertedOrderId = Convert.ToInt32(cmd.ExecuteScalar())

            ' Insert ke DetailOrders
            Dim quantity As Integer = Convert.ToInt32(txtQUANTITY.Text)
            Dim hargaSatuan As Decimal = Convert.ToDecimal(txtHARGASATUAN.Text)

            Dim insertDetailCmd As New SqlCommand("
                INSERT INTO DetailOrders (KuantitasBarang, HargaSatuan, Orders_PembelianBarangID)
                VALUES (@KuantitasBarang, @HargaSatuan, @Orders_PembelianBarangID)
            ", conn, trans)

            insertDetailCmd.Parameters.AddWithValue("@Orders_PembelianBarangID", insertedOrderId)
            insertDetailCmd.Parameters.AddWithValue("@KuantitasBarang", quantity)
            insertDetailCmd.Parameters.AddWithValue("@HargaSatuan", hargaSatuan)
            insertDetailCmd.ExecuteNonQuery()

            ' Insert ke InventoryStock_has_Orders
            Dim customerId As Integer = GetCustomerIdByName(cmbCUSTOMERS.SelectedItem.ToString())
            Dim productId As Integer = GetProductIdByName(cmbPRODUCTS.SelectedItem.ToString())

            Dim insert As New SqlCommand("
                INSERT INTO InventoryStock_has_Orders (Orders_PembelianBarangID, Customers_ID, Products_KodeBarang)
                VALUES (@Orders_PembelianBarangID, @Customers_ID, @Products_KodeBarang)
            ", conn, trans)

            insert.Parameters.AddWithValue("@Orders_PembelianBarangID", insertedOrderId)
            insert.Parameters.AddWithValue("@Customers_ID", customerId)
            insert.Parameters.AddWithValue("@Products_KodeBarang", productId)
            insert.ExecuteNonQuery()

            ' Jika semua sukses, commit transaksi
            trans.Commit()
            MessageBox.Show("Transaksi berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            ' Jika error, rollback semua perubahan
            If trans IsNot Nothing Then
                trans.Rollback()
            End If
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
            LoadOrders()
        End Try


    End Sub

    Private Function GetCustomerIdByName(customerName As String) As Integer
        Dim conn As New SqlConnection(DatabaseHelper.GetConnectionString())
        Dim cmd As New SqlCommand("SELECT ID FROM Customers WHERE Nama = @nama", conn)
        cmd.Parameters.AddWithValue("@nama", customerName)

        Try
            conn.Open()
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                Return Convert.ToInt32(result)
            Else
                Throw New Exception("Customer tidak ditemukan.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error saat mengambil ID Customer: " & ex.Message)
            Return -1 ' atau kamu bisa Return 0 sebagai default
        Finally
            conn.Close()
        End Try
    End Function

    Private Function GetProductIdByName(productName As String) As Integer
        Dim conn As New SqlConnection(DatabaseHelper.GetConnectionString())
        Dim cmd As New SqlCommand("SELECT KodeBarang FROM Products WHERE NamaBarang = @NamaBarang", conn)
        cmd.Parameters.AddWithValue("@NamaBarang", productName)

        Try
            conn.Open()
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                Return Convert.ToInt32(result)
            Else
                Throw New Exception("Produk tidak ditemukan.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error saat mengambil ID Produk: " & ex.Message)
            Return -1
        Finally
            conn.Close()
        End Try
    End Function

    Private Sub btnUPDATEORDERS_Click(sender As Object, e As EventArgs) Handles btnUPDATEORDERS.Click

        Dim conn As New SqlConnection(DatabaseHelper.GetConnectionString())
        Dim trans As SqlTransaction = Nothing

        If MessageBox.Show("Apakah Anda yakin ingin memperbarui data tersebut?", "Konfirmasi Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Try
            conn.Open()
            trans = conn.BeginTransaction()

            ' Update Orders
            Dim updateOrderCmd As New SqlCommand("UPDATE Orders SET TanggalOrders = @Tanggal, Harga = @Harga WHERE PembelianBarangID = @OrderID
        ", conn, trans)
            Dim selectedOrderId As Integer = Convert.ToInt32(dgvORDERS.CurrentRow.Cells("OrderID").Value)

            updateOrderCmd.Parameters.AddWithValue("@Tanggal", dtpORDERS.Value)
            updateOrderCmd.Parameters.AddWithValue("@Harga", Convert.ToDecimal(txtHARGA.Text))
            updateOrderCmd.Parameters.AddWithValue("@OrderID", selectedOrderId)
            updateOrderCmd.ExecuteNonQuery()

            ' Update DetailOrders
            Dim updateDetailCmd As New SqlCommand("
            UPDATE DetailOrders SET KuantitasBarang = @Qty, HargaSatuan = @HargaSatuan 
            WHERE Orders_PembelianBarangID = @OrderID
        ", conn, trans)

            updateDetailCmd.Parameters.AddWithValue("@Qty", Convert.ToInt32(txtQUANTITY.Text))
            updateDetailCmd.Parameters.AddWithValue("@HargaSatuan", Convert.ToDecimal(txtHARGASATUAN.Text))
            updateDetailCmd.Parameters.AddWithValue("@OrderID", selectedOrderId)
            updateDetailCmd.ExecuteNonQuery()

            ' Update InventoryStock_has_Orders
            Dim updateInventoryCmd As New SqlCommand("
            UPDATE InventoryStock_has_Orders 
            SET Customers_ID = @CustomerID, Products_KodeBarang = @ProductID 
            WHERE Orders_PembelianBarangID = @OrderID
        ", conn, trans)

            updateInventoryCmd.Parameters.AddWithValue("@CustomerID", GetCustomerIdByName(cmbCUSTOMERS.SelectedItem.ToString()))
            updateInventoryCmd.Parameters.AddWithValue("@ProductID", GetProductIdByName(cmbPRODUCTS.SelectedItem.ToString()))
            updateInventoryCmd.Parameters.AddWithValue("@OrderID", selectedOrderId)
            updateInventoryCmd.ExecuteNonQuery()

            trans.Commit()
            MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            trans?.Rollback()
            MessageBox.Show("Gagal update: " & ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
            LoadOrders()
        End Try

    End Sub

    Private Sub btnDELETEORDERS_Click(sender As Object, e As EventArgs) Handles btnDELETEORDERS.Click

        Dim conn As New SqlConnection(DatabaseHelper.GetConnectionString())
        Dim trans As SqlTransaction = Nothing

        If MessageBox.Show("Apakah Anda yakin ingin memperbarui data tersebut?", "Konfirmasi Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Try
            conn.Open()
            trans = conn.BeginTransaction()

            ' Hapus dari tabel yang tergantung lebih dulu
            Dim deleteInventoryCmd As New SqlCommand("
            DELETE FROM InventoryStock_has_Orders WHERE Orders_PembelianBarangID = @OrderID
        ", conn, trans)
            Dim selectedOrderId As Integer = Convert.ToInt32(dgvORDERS.CurrentRow.Cells("OrderID").Value)

            deleteInventoryCmd.Parameters.AddWithValue("@OrderID", selectedOrderId)
            deleteInventoryCmd.ExecuteNonQuery()

            Dim deleteDetailCmd As New SqlCommand("
            DELETE FROM DetailOrders WHERE Orders_PembelianBarangID = @OrderID
        ", conn, trans)

            deleteDetailCmd.Parameters.AddWithValue("@OrderID", selectedOrderId)
            deleteDetailCmd.ExecuteNonQuery()

            Dim deleteOrderCmd As New SqlCommand("
            DELETE FROM Orders WHERE PembelianBarangID = @OrderID
        ", conn, trans)

            deleteOrderCmd.Parameters.AddWithValue("@OrderID", selectedOrderId)
            deleteOrderCmd.ExecuteNonQuery()

            trans.Commit()
            MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            trans?.Rollback()
            MessageBox.Show("Gagal hapus: " & ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
            LoadOrders()
        End Try

    End Sub

    Private Sub btnCANCELORDERS_Click(sender As Object, e As EventArgs) Handles btnCANCELORDERS.Click
        txtHARGA.Text = ""
        txtHARGASATUAN.Text = ""
        txtQUANTITY.Text = ""
        cmbCUSTOMERS.Text = ""
        cmbPRODUCTS.Text = ""
    End Sub

    Private Sub dgvORDERS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvORDERS.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvORDERS.Rows(e.RowIndex)
            cmbCUSTOMERS.Text = row.Cells(5).Value.ToString()
            txtHARGA.Text = row.Cells(2).Value.ToString()
            txtHARGASATUAN.Text = row.Cells(4).Value.ToString()
            txtQUANTITY.Text = row.Cells(3).Value.ToString()
            cmbPRODUCTS.Text = row.Cells(6).Value.ToString()

            Dim tanggalOrder As Object = row.Cells(1).Value
            Dim tanggalParsed As DateTime

            If DateTime.TryParse(tanggalOrder.ToString(), tanggalParsed) Then
                dtpORDERS.Value = tanggalParsed
            Else
                dtpORDERS.Value = Date.Today ' fallback jika gagal parse
            End If

        End If
    End Sub
End Class