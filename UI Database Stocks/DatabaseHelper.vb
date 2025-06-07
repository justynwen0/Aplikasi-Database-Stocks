Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class DatabaseHelper
    Public Shared Function ExecuteDynamicSQL(
        operation As String,
        tableName As String,
        data As Dictionary(Of String, Object),
        connectionString As String,
        Optional whereClause As String = "",
        Optional selectColumns As List(Of String) = Nothing
    ) As Object

        Dim query As String = ""
        Dim parameters As New List(Of SqlParameter)

        Select Case operation.ToLower()
            Case "insert"
                Dim cols = String.Join(", ", data.Keys)
                Dim vals = String.Join(", ", data.Keys.Select(Function(k) "@" & k))
                query = $"INSERT INTO {tableName} ({cols}) VALUES ({vals})"
                parameters.AddRange(data.Select(Function(kvp) New SqlParameter("@" & kvp.Key, kvp.Value)))

            Case "update"
                If String.IsNullOrEmpty(whereClause) Then Throw New ArgumentException("WHERE clause harus diisi untuk UPDATE")
                Dim setClauses = String.Join(", ", data.Keys.Select(Function(k) $"{k} = @{k}"))
                query = $"UPDATE {tableName} SET {setClauses} WHERE {whereClause}"
                parameters.AddRange(data.Select(Function(kvp) New SqlParameter("@" & kvp.Key, kvp.Value)))

            Case "delete"
                If String.IsNullOrEmpty(whereClause) Then Throw New ArgumentException("WHERE clause harus diisi untuk DELETE")
                query = $"DELETE FROM {tableName} WHERE {whereClause}"
                parameters.AddRange(data.Select(Function(kvp) New SqlParameter("@" & kvp.Key, kvp.Value)))

            Case "select"
                Dim cols As String = If(selectColumns IsNot Nothing AndAlso selectColumns.Count > 0, String.Join(", ", selectColumns), "*")
                query = $"SELECT {cols} FROM {tableName}"
                If Not String.IsNullOrWhiteSpace(whereClause) Then
                    query &= $" WHERE {whereClause}"
                End If
                parameters.AddRange(data.Select(Function(kvp) New SqlParameter("@" & kvp.Key, kvp.Value)))

            Case Else
                Throw New ArgumentException("Operation tidak dikenali. Gunakan: insert, update, delete, atau select.")
        End Select

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddRange(parameters.ToArray())
                conn.Open()

                If operation.ToLower() = "select" Then
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    Return dt
                Else
                    Return cmd.ExecuteNonQuery() ' untuk insert/update/delete
                End If
            End Using
        End Using
    End Function

    Public Shared Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hashBytes).Replace("-", "").ToLower()
        End Using
    End Function

    Public Shared Function GetSHA256Hash(ByVal text As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(text)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Dim sb As New StringBuilder()
            For Each b As Byte In hash
                sb.Append(b.ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function
End Class
