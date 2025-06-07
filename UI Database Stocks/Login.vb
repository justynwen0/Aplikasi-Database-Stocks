Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim hashedPassword As String = DatabaseHelper.GetSHA256Hash(txtPassword.Text)
        Dim connString As String = My.MySettings.Default.ApkDatabaseStocks

        Try
            Dim data = New Dictionary(Of String, Object) From {
                {"nama", Trim(txtUsername.Text)},
                {"pass", hashedPassword}
            }

            Dim resultTable As DataTable = DatabaseHelper.ExecuteDynamicSQL(
                "select", "Users", data, connString, "Nama = @nama AND Password = @pass", New List(Of String) From {"ID", "Nama", "Email"}
            )
            If resultTable.Rows.Count > 0 Then
                Products.Show()
            Else
                MessageBox.Show("Username atau Password salah.")
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub
End Class