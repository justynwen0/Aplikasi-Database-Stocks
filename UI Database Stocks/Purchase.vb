Imports System.Data.SqlClient
Public Class Purchase

    Private Sub LoadPurchases()
        Dim conn As New SqlConnection(DatabaseHelper.GetConnectionString())
        Dim query As String = "
        SELECT 
            p.PenjualanBarangID AS PurchaseID,
            p.TanggalPembelian,
            p.Harga,
            po.KuantitasBarang,
            po.HargaSatuan,
            s.Nama AS NamaSupplier,
            pr.NamaBarang
        FROM Purchase p
        INNER JOIN DetailPurchases po ON po.Purchase_PenjualanBarangID = p.PenjualanBarangID
        INNER JOIN Suppliers_has_Purchase shp ON shp.Purchase_PenjualanBarangID = p.PenjualanBarangID
        INNER JOIN Suppliers s ON s.ID = shp.Suppliers_ID
        INNER JOIN Products_has_Purchase php ON php.Purchase_PenjualanBarangID = p.PenjualanBarangID
        INNER JOIN Products pr ON pr.KodeBarang = php.Products_KodeBarang
    "

        Dim adapter As New SqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            dgvPURCHASES.DataSource = table
            dgvPURCHASES.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvPURCHASES.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvPURCHASES.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data pembelian: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub FormPurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPURCHASES.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPURCHASES.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPURCHASES.ReadOnly = True

        LoadSuppliers()
        LoadProducts()
        LoadPurchases()
        txtHARGASATUANPURCHASE.ReadOnly = True
        txtHARGAPURCHASE.ReadOnly = True
    End Sub

    Private Sub LoadSuppliers()
        cmbSUPPLIERS.Items.Clear()
        Dim connStr = DatabaseHelper.GetConnectionString()
        Dim dt = DatabaseHelper.ExecuteDynamicSQL("select", "Suppliers", New Dictionary(Of String, Object), connStr, "", New List(Of String) From {"Nama"})
        For Each row As DataRow In CType(dt, DataTable).Rows
            cmbSUPPLIERS.Items.Add(row("Nama").ToString())
        Next
    End Sub

    Private Sub LoadProducts()
        cmbPRODUCTPURCHASE.Items.Clear()
        Dim connStr = DatabaseHelper.GetConnectionString()
        Dim dt = DatabaseHelper.ExecuteDynamicSQL("select", "Products", New Dictionary(Of String, Object), connStr, "", New List(Of String) From {"NamaBarang"})
        For Each row As DataRow In CType(dt, DataTable).Rows
            cmbPRODUCTPURCHASE.Items.Add(row("NamaBarang").ToString())
        Next
    End Sub

    Private Sub HitungTotalHarga()
        Dim qty As Integer, hargaSatuan As Integer
        If Integer.TryParse(txtQUANTITYPURCHASE.Text, qty) AndAlso Integer.TryParse(txtHARGASATUANPURCHASE.Text, hargaSatuan) Then
            txtHARGAPURCHASE.Text = (qty * hargaSatuan).ToString()
        Else
            txtHARGAPURCHASE.Text = ""
        End If
    End Sub

    Private Sub cmbPRODUCTPURCHASE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPRODUCTPURCHASE.SelectedIndexChanged
        If cmbPRODUCTPURCHASE.SelectedItem Is Nothing OrElse cmbPRODUCTPURCHASE.SelectedIndex = -1 Then
            txtHARGASATUANPURCHASE.Clear()
            txtHARGAPURCHASE.Clear()
            Exit Sub
        End If


        Dim selected = cmbPRODUCTPURCHASE.SelectedItem.ToString()
        Dim connStr = DatabaseHelper.GetConnectionString()
        Dim dt = DatabaseHelper.ExecuteDynamicSQL("select", "Products",
        New Dictionary(Of String, Object) From {{"NamaBarang", selected}},
        connStr, "NamaBarang = @NamaBarang", New List(Of String) From {"Harga"})

        If CType(dt, DataTable).Rows.Count > 0 Then
            txtHARGASATUANPURCHASE.Text = dt.Rows(0)("Harga").ToString()
            HitungTotalHarga()
        End If
    End Sub

    Private Sub txtQUANTITYPURCHASE_TextChanged(sender As Object, e As EventArgs) Handles txtQUANTITYPURCHASE.TextChanged
        HitungTotalHarga()
    End Sub

    Private Function GetProductIdByName(productName As String) As String
        Dim conn As New SqlConnection(DatabaseHelper.GetConnectionString())
        Dim cmd As New SqlCommand("SELECT KodeBarang FROM Products WHERE NamaBarang = @NamaBarang", conn)
        cmd.Parameters.AddWithValue("@NamaBarang", productName)

        Try
            conn.Open()
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                Return result.ToString()
            Else
                Throw New Exception("Produk tidak ditemukan.")
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil ID Produk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        Finally
            conn.Close()
        End Try
    End Function


    Private Function GetSupplierIdByName(name As String) As Integer
        Dim conn = New SqlConnection(DatabaseHelper.GetConnectionString())
        Dim cmd = New SqlCommand("SELECT ID FROM Suppliers WHERE Nama = @Nama", conn)
        cmd.Parameters.AddWithValue("@Nama", name)
        Try
            conn.Open()
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                Return Convert.ToInt32(result)
            Else
                Throw New Exception("Supplier tidak ditemukan.")
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal ambil ID Supplier: " & ex.Message)
            Return -1
        Finally
            conn.Close()
        End Try
    End Function


    Private Sub btnINSERTPURCHASE_Click(sender As Object, e As EventArgs) Handles btnINSERTPURCHASE.Click
        Dim connStr = DatabaseHelper.GetConnectionString()
        Dim conn As New SqlConnection(connStr)
        Dim trans As SqlTransaction = Nothing

        Try
            conn.Open()
            trans = conn.BeginTransaction()

            ' 1. Insert ke tabel Purchase
            Dim purchaseData = New Dictionary(Of String, Object) From {
            {"TanggalPembelian", dtpPURCHASE.Value},
            {"Harga", Convert.ToDecimal(txtHARGAPURCHASE.Text)}
        }

            Dim cmdPurchase = New SqlCommand("
            INSERT INTO Purchase (TanggalPembelian, Harga) 
            VALUES (@TanggalPembelian, @Harga); 
            SELECT CAST(SCOPE_IDENTITY() AS INT);", conn, trans)

            For Each kvp In purchaseData
                cmdPurchase.Parameters.AddWithValue("@" & kvp.Key, kvp.Value)
            Next

            Dim insertedPurchaseId As Integer = Convert.ToInt32(cmdPurchase.ExecuteScalar())

            ' 2. Insert ke tabel DetailPurchases
            Dim cmdPurchaseOrder = New SqlCommand("
            INSERT INTO DetailPurchases (KuantitasBarang, HargaSatuan, Purchase_PenjualanBarangID)
            VALUES (@Qty, @HargaSatuan, @PurchaseId)", conn, trans)

            cmdPurchaseOrder.Parameters.AddWithValue("@Qty", Convert.ToInt32(txtQUANTITYPURCHASE.Text))
            cmdPurchaseOrder.Parameters.AddWithValue("@HargaSatuan", Convert.ToDecimal(txtHARGASATUANPURCHASE.Text))
            cmdPurchaseOrder.Parameters.AddWithValue("@PurchaseId", insertedPurchaseId)
            cmdPurchaseOrder.ExecuteNonQuery()

            ' 3. Insert ke tabel Suppliers_has_Purchase
            Dim supplierId = GetSupplierIdByName(cmbSUPPLIERS.SelectedItem.ToString())
            Dim cmdSuppHasPurchase = New SqlCommand("
            INSERT INTO Suppliers_has_Purchase (Suppliers_ID, Purchase_PenjualanBarangID)
            VALUES (@SupplierID, @PurchaseId)", conn, trans)

            cmdSuppHasPurchase.Parameters.AddWithValue("@SupplierID", supplierId)
            cmdSuppHasPurchase.Parameters.AddWithValue("@PurchaseId", insertedPurchaseId)
            cmdSuppHasPurchase.ExecuteNonQuery()

            ' 4. Insert ke tabel Products_has_Purchase
            Dim productId = GetProductIdByName(cmbPRODUCTPURCHASE.SelectedItem.ToString())
            Dim cmdProdHasPurchase = New SqlCommand("
            INSERT INTO Products_has_Purchase (Products_KodeBarang, Purchase_PenjualanBarangID)
            VALUES (@ProductID, @PurchaseId)", conn, trans)

            cmdProdHasPurchase.Parameters.AddWithValue("@ProductID", productId)
            cmdProdHasPurchase.Parameters.AddWithValue("@PurchaseId", insertedPurchaseId)
            cmdProdHasPurchase.ExecuteNonQuery()

            trans.Commit()
            ClearPurchaseInputs()
            MessageBox.Show("Data pembelian berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            trans?.Rollback()
            MessageBox.Show("Insert gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
            LoadPurchases()
        End Try
    End Sub

    Private Sub btnUPDATEPURCHASE_Click(sender As Object, e As EventArgs) Handles btnUPDATEPURCHASE.Click
        Dim connStr = DatabaseHelper.GetConnectionString()
        Dim conn As New SqlConnection(connStr)
        Dim trans As SqlTransaction = Nothing

        If dgvPURCHASES.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih baris data yang ingin diperbarui terlebih dahulu.")
            Exit Sub
        End If

        If MessageBox.Show("Apakah Anda yakin ingin memperbarui data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Dim selectedRow = dgvPURCHASES.CurrentRow
        Dim selectedPurchaseId = Convert.ToInt32(selectedRow.Cells("PurchaseID").Value)

        Try
            conn.Open()
            trans = conn.BeginTransaction()

            ' 1. Update Purchase
            Dim updatePurchase = New SqlCommand("
            UPDATE Purchase SET 
                TanggalPembelian = @Tanggal, 
                Harga = @Harga 
            WHERE PenjualanBarangID = @ID", conn, trans)

            updatePurchase.Parameters.AddWithValue("@Tanggal", dtpPURCHASE.Value)
            updatePurchase.Parameters.AddWithValue("@Harga", Convert.ToDecimal(txtHARGAPURCHASE.Text))
            updatePurchase.Parameters.AddWithValue("@ID", selectedPurchaseId)
            updatePurchase.ExecuteNonQuery()

            ' 2. Update DetailPurchases
            Dim updateDetailPurchases = New SqlCommand("
            UPDATE DetailPurchases SET 
                KuantitasBarang = @Qty, 
                HargaSatuan = @HargaSatuan 
            WHERE Purchase_PenjualanBarangID = @ID", conn, trans)

            updateDetailPurchases.Parameters.AddWithValue("@Qty", Convert.ToInt32(txtQUANTITYPURCHASE.Text))
            updateDetailPurchases.Parameters.AddWithValue("@HargaSatuan", Convert.ToDecimal(txtHARGASATUANPURCHASE.Text))
            updateDetailPurchases.Parameters.AddWithValue("@ID", selectedPurchaseId)
            updateDetailPurchases.ExecuteNonQuery()

            ' 3. Update Suppliers_has_Purchase
            Dim updateSupplier = New SqlCommand("
            UPDATE Suppliers_has_Purchase 
            SET Suppliers_ID = @SupplierID 
            WHERE Purchase_PenjualanBarangID = @ID", conn, trans)

            updateSupplier.Parameters.AddWithValue("@SupplierID", GetSupplierIdByName(cmbSUPPLIERS.Text))
            updateSupplier.Parameters.AddWithValue("@ID", selectedPurchaseId)
            updateSupplier.ExecuteNonQuery()

            ' 4. Update Products_has_Purchase
            Dim updateProduct = New SqlCommand("
            UPDATE Products_has_Purchase 
            SET Products_KodeBarang = @ProductID 
            WHERE Purchase_PenjualanBarangID = @ID", conn, trans)

            updateProduct.Parameters.AddWithValue("@ProductID", GetProductIdByName(cmbPRODUCTPURCHASE.Text))
            updateProduct.Parameters.AddWithValue("@ID", selectedPurchaseId)
            updateProduct.ExecuteNonQuery()

            trans.Commit()
            ClearPurchaseInputs()
            MessageBox.Show("Data berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            trans?.Rollback()
            MessageBox.Show("Gagal update: " & ex.Message)
        Finally
            conn.Close()
            LoadPurchases()
        End Try
    End Sub

    Private Sub btnDELETEPURCHASE_Click(sender As Object, e As EventArgs) Handles btnDELETEPURCHASE.Click
        Dim connStr = DatabaseHelper.GetConnectionString()
        Dim conn As New SqlConnection(connStr)
        Dim trans As SqlTransaction = Nothing

        If dgvPURCHASES.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu.")
            Exit Sub
        End If

        If MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Dim selectedRow = dgvPURCHASES.CurrentRow
        Dim selectedPurchaseId = Convert.ToInt32(selectedRow.Cells("PurchaseID").Value)

        Try
            conn.Open()
            trans = conn.BeginTransaction()

            Dim delProduct = New SqlCommand("DELETE FROM Products_has_Purchase WHERE Purchase_PenjualanBarangID = @ID", conn, trans)
            delProduct.Parameters.AddWithValue("@ID", selectedPurchaseId)
            delProduct.ExecuteNonQuery()

            Dim delSupplier = New SqlCommand("DELETE FROM Suppliers_has_Purchase WHERE Purchase_PenjualanBarangID = @ID", conn, trans)
            delSupplier.Parameters.AddWithValue("@ID", selectedPurchaseId)
            delSupplier.ExecuteNonQuery()

            Dim delPurchaseOrder = New SqlCommand("DELETE FROM DetailPurchases WHERE Purchase_PenjualanBarangID = @ID", conn, trans)
            delPurchaseOrder.Parameters.AddWithValue("@ID", selectedPurchaseId)
            delPurchaseOrder.ExecuteNonQuery()

            Dim delPurchase = New SqlCommand("DELETE FROM Purchase WHERE PenjualanBarangID = @ID", conn, trans)
            delPurchase.Parameters.AddWithValue("@ID", selectedPurchaseId)
            delPurchase.ExecuteNonQuery()

            trans.Commit()
            ClearPurchaseInputs()
            MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            trans?.Rollback()
            MessageBox.Show("Gagal hapus: " & ex.Message)
        Finally
            conn.Close()
            LoadPurchases()
        End Try
    End Sub

    Private Sub btnCANCELPURCHASE_Click(sender As Object, e As EventArgs) Handles btnCANCELPURCHASE.Click
        txtHARGAPURCHASE.Text = ""
        txtHARGASATUANPURCHASE.Text = ""
        txtQUANTITYPURCHASE.Text = ""
        cmbSUPPLIERS.Text = ""
        cmbPRODUCTPURCHASE.Text = ""
    End Sub

    Private Sub dgvPURCHASES_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPURCHASES.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvPURCHASES.Rows(e.RowIndex)
            cmbSUPPLIERS.Text = row.Cells(5).Value.ToString()
            txtHARGAPURCHASE.Text = row.Cells(2).Value.ToString()
            txtHARGASATUANPURCHASE.Text = row.Cells(4).Value.ToString()
            txtQUANTITYPURCHASE.Text = row.Cells(3).Value.ToString()
            cmbPRODUCTPURCHASE.Text = row.Cells(6).Value.ToString()

            Dim tanggalOrder As Object = row.Cells(1).Value
            Dim tanggalParsed As DateTime

            If DateTime.TryParse(tanggalOrder.ToString(), tanggalParsed) Then
                dtpPURCHASE.Value = tanggalParsed
            Else
                dtpPURCHASE.Value = Date.Today
            End If

        End If
    End Sub

    Private Sub ClearPurchaseInputs()
        cmbSUPPLIERS.SelectedIndex = -1
        cmbPRODUCTPURCHASE.SelectedIndex = -1
        txtHARGAPURCHASE.Clear()
        txtHARGASATUANPURCHASE.Clear()
        txtQUANTITYPURCHASE.Clear()
        dtpPURCHASE.Value = Date.Today
    End Sub

End Class