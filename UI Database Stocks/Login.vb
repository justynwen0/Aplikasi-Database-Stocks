Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim dbHelper As New DatabaseHelper()
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim hashedPassword As String = dbHelper.GetSHA256Hash(password)
        Dim Conn As New SqlConnection

        Try
            Conn = New SqlConnection(My.MySettings.Default.ApkDatabaseStocks)
            Conn.Open()
            Dim cmd As New SqlCommand("SELECT * FROM Users WHERE Nama = @nama AND Password = @pass", Conn)
            cmd.Parameters.AddWithValue("@nama", username)
            cmd.Parameters.AddWithValue("@pass", hashedPassword)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                Form1.Show()
            Else
                MessageBox.Show("Username atau Password salah.")
            End If

            reader.Close()
            Conn.Close()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

End Class