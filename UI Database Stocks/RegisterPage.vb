Imports System.Data.SqlClient

Public Class RegisterPage
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim dbHelper As New DatabaseHelper()
        Dim connString As String = My.MySettings.Default.ApkDatabaseStocks

        Dim hashedPassword As String = dbHelper.HashPassword(Trim(txtPasswordRegister.Text))

        Dim data As New Dictionary(Of String, Object)
        data("Nama") = Trim(txtUsernameRegister.Text)
        data("Email") = Trim(txtEmailRegister.Text)
        data("Password") = hashedPassword

        Try
            Dim rowsAffected As Integer = dbHelper.ExecuteDynamicSQL("insert", "Users", data, connString)
            If rowsAffected > 0 Then
                MessageBox.Show("Registrasi berhasil")
            Else
                MessageBox.Show("Registrasi gagal!")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub RegisterPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class