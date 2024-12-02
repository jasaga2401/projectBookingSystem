Imports MySql.Data.MySqlClient


Module modDbConnection

    ' Define the connection string
    Private connectionString As String = "server=localhost;userid=root;password=12Yellow34!;database=dbBookingSystem;"

    ' Define the MySqlConnection object
    Public connection As MySqlConnection

    ' Function to return the connection string
    Public Function GetConnectionString() As String
        Return connectionString
    End Function

    ' Method to create and return a new connection
    Public Function GetConnection() As MySqlConnection
        If connection Is Nothing Then
            connection = New MySqlConnection(GetConnectionString())
        End If
        Return connection
    End Function

    ' Method to open the connection
    Public Sub OpenConnection()
        Try
            If connection Is Nothing Then
                connection = GetConnection()
            End If
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error opening connection: {ex.Message}")
        End Try
    End Sub

    ' Method to close the connection
    Public Sub CloseConnection()
        Try
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error closing connection: {ex.Message}")
        End Try
    End Sub



End Module
