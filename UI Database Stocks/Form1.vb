Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnINSERT_Click(sender As Object, e As EventArgs) Handles btnINSERT.Click
        Dim conn As New SqlConnection
        Dim sql As String
        Dim cmd As New SqlCommand
        conn = New SqlConnection(My.MySettings.Default.ApkDatabaseStocks)
        conn.Open()
        sql = "INSERT INTO Products VALUES('" & Trim(txtNAMABARANG.Text) & "', '" & Trim(txtHARGA.Text) & "', '" & Trim(txtMEREKBARANG.Text) & "')"

        With cmd
            .Connection = conn
            .CommandText = sql
            .ExecuteNonQuery()
        End With
        conn.Close()
    End Sub

    Private Sub btnUPDATE_Click(sender As Object, e As EventArgs) Handles btnUPDATE.Click
        Dim conn As New SqlConnection
        Dim sql As String
        Dim cmd As New SqlCommand
        conn = New SqlConnection(My.MySettings.Default.ApkDatabaseStocks)
        conn.Open()
        sql = "UPDATE Products SET NamaBarang = '" & Trim(txtNAMABARANG.Text) & "', Harga = '" & Trim(txtHARGA.Text) & "', MerekBarang = '" & Trim(txtMEREKBARANG.Text) & "' where NamaBarang = '" & Trim(txtNAMABARANG.Text) & "'"



        With cmd
            .Connection = conn
            .CommandText = sql
            .ExecuteNonQuery()
        End With
    End Sub

    Private Sub btnDELETE_Click(sender As Object, e As EventArgs) Handles btnDELETE.Click
        Dim conn As New SqlConnection
        Dim sql As String
        Dim cmd As New SqlCommand
        conn = New SqlConnection(My.MySettings.Default.ApkDatabaseStocks)
        conn.Open()
        sql = "DELETE FROM Products WHERE NamaBarang = '" & Trim(txtNAMABARANG.Text) & "'"


        With cmd
            .Connection = conn
            .CommandText = sql
            .ExecuteNonQuery()
        End With
        conn.Close()
    End Sub

    Private Sub btnCANCEL_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        txtNAMABARANG.Text = ""
        txtHARGA.Text = ""
        txtMEREKBARANG.Text = ""
    End Sub
End Class
