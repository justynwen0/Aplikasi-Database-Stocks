Imports System.Data.SqlClient

Public Class RegisterPage

    Private selectedID As Integer = -1
    Private conn As String = DatabaseHelper.GetConnectionString()

    Private Sub ClearForm()
        txtUsernameRegister.Clear()
        txtEmailRegister.Clear()
        txtPasswordRegister.Clear()
        txtUsernameRegister.Focus()
    End Sub

    Private Sub LoadData()
        Dim dt As New DataTable()
        Try
            dt = DatabaseHelper.ExecuteDynamicSQL("select", "Users", New Dictionary(Of String, Object), conn, "", New List(Of String) From {"ID", "Nama", "Email"})
            dgvRegister.DataSource = dt

            dgvRegister.ReadOnly = True
            dgvRegister.AllowUserToAddRows = False
            dgvRegister.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message)
        End Try
    End Sub
    Private Sub RegisterPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim hashedPassword As String = DatabaseHelper.HashPassword(Trim(txtPasswordRegister.Text))

        Dim data As New Dictionary(Of String, Object)
        data("Nama") = Trim(txtUsernameRegister.Text)
        data("Email") = Trim(txtEmailRegister.Text)
        data("Password") = hashedPassword

        Try
            Dim rowsAffected As Integer = DatabaseHelper.ExecuteDynamicSQL("insert", "Users", data, conn)
            If rowsAffected > 0 Then
                MessageBox.Show("Registrasi berhasil")
                LoadData()
                ClearForm()
            Else
                MessageBox.Show("Registrasi gagal!")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDeleteRegister_Click(sender As Object, e As EventArgs) Handles btnDeleteRegister.Click
        Try
            Dim rowsAffected As Integer = DatabaseHelper.ExecuteDynamicSQL("delete", "Users", New Dictionary(Of String, Object), conn, "ID =" & selectedID)
            If rowsAffected > 0 Then
                MessageBox.Show("Delete Data berhasil")
                LoadData()
                ClearForm()
            Else
                MessageBox.Show("Delete Data gagal!")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvRegister_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRegister.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvRegister.Rows(e.RowIndex)
            selectedID = Convert.ToInt32(row.Cells(0).Value) ' ID dari kolom pertama
            txtUsernameRegister.Text = row.Cells(1).Value.ToString()
            txtEmailRegister.Text = row.Cells(2).Value.ToString()
        End If
    End Sub

    Private Sub btnCancelRegister_Click(sender As Object, e As EventArgs) Handles btnCancelRegister.Click
        ClearForm()
    End Sub
End Class