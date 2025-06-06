Imports System.Data.SqlClient

Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim Conn As New SqlConnection
        Try
            Conn.Open()
            Dim cmd As New SqlCommand("SELECT * FROM Users WHERE Nama = @nama AND Password = @pass", Conn)
            cmd.Parameters.AddWithValue("@nama", username)
            cmd.Parameters.AddWithValue("@pass", password)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                MessageBox.Show("Login Berhasil!")
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