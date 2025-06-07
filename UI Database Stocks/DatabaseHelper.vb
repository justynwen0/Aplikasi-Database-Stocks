Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class DatabaseHelper
    Function ExecuteDynamicSQL(operation As String, tableName As String, data As Dictionary(Of String, Object), connectionString As String, Optional whereClause As String = "") As Integer
        Dim query As String = ""
        Dim columns As New List(Of String)
        Dim parameters As New List(Of SqlParameter)

        Select Case operation.ToLower()
            Case "insert"
                columns.AddRange(data.Keys)
                Dim cols As String = String.Join(", ", columns)
                Dim vals As String = String.Join(", ", columns.Select(Function(c) "@" & c))
                query = $"INSERT INTO {tableName} ({cols}) VALUES ({vals})"

                For Each kvp In data
                    parameters.Add(New SqlParameter("@" & kvp.Key, kvp.Value))
                Next

            Case "update"
                If String.IsNullOrEmpty(whereClause) Then Throw New ArgumentException("WHERE clause harus diisi untuk UPDATE")

                Dim setClauses As New List(Of String)
                For Each kvp In data
                    setClauses.Add($"{kvp.Key} = @{kvp.Key}")
                    parameters.Add(New SqlParameter("@" & kvp.Key, kvp.Value))
                Next
                Dim setClauseStr As String = String.Join(", ", setClauses)
                query = $"UPDATE {tableName} SET {setClauseStr} WHERE {whereClause}"

            Case "delete"
                If String.IsNullOrEmpty(whereClause) Then Throw New ArgumentException("WHERE clause harus diisi untuk DELETE")
                query = $"DELETE FROM {tableName} WHERE {whereClause}"

            Case Else
                Throw New ArgumentException("Operation tidak dikenali.")
        End Select

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddRange(parameters.ToArray())
                conn.Open()
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function HashPassword(password As String) As String
        Using sha256 As SHA256 = sha256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hashBytes).Replace("-", "").ToLower()
        End Using
    End Function

    Public Function GetSHA256Hash(ByVal text As String) As String
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
