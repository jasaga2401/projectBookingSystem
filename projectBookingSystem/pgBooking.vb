Imports MySql.Data.MySqlClient

Public Class pgBooking


    Private Sub pgBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateTimeSlots()
        LoadAppointments()

    End Sub

    Private Sub PopulateTimeSlots()
        cmbTimeSlots.Items.Clear()
        For hour As Integer = 9 To 16
            cmbTimeSlots.Items.Add($"{hour}:00 - {hour + 1}:00")
        Next
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateTimeSlots()
        LoadAppointments()
    End Sub

    Private Sub LoadAppointments()

        connection = modDbConnection.GetConnection()

        Try
            modDbConnection.OpenConnection()
            Dim query As String = "SELECT appointment_date, appointment_time, client_name, client_email FROM tblappointments"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            dvgAppointments.DataSource = table
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnBookingAppointment_Click(sender As Object, e As EventArgs) Handles btnBookingAppointment.Click


        If cmbTimeSlots.SelectedIndex = -1 OrElse String.IsNullOrEmpty(txtClient.Text) OrElse String.IsNullOrEmpty(txtEmail.Text) Then
            MessageBox.Show("Please fill all fields!")
            Return
        End If

        Dim selectedDate As Date = DateTimePicker1.Value.Date
        Dim selectedTime As String = cmbTimeSlots.SelectedItem.ToString().Split(" "c)(0)
        Dim clientName As String = txtClient.Text
        Dim clientEmail As String = txtEmail.Text

        Try
            modDbConnection.OpenConnection()
            Dim query As String = "INSERT INTO tblappointments (appointment_date, appointment_time, client_name, client_email) VALUES (@date, @time, @name, @email)"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@date", selectedDate)
            command.Parameters.AddWithValue("@time", TimeSpan.Parse(selectedTime))
            command.Parameters.AddWithValue("@name", clientName)
            command.Parameters.AddWithValue("@email", clientEmail)

            command.ExecuteNonQuery()
            MessageBox.Show("Appointment booked successfully!")
            LoadAppointments()
        Catch ex As MySqlException When ex.Number = 1062
            MessageBox.Show("This time slot is already booked.")
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub lblTimeSlot_Click(sender As Object, e As EventArgs) Handles lblTimeSlot.Click

    End Sub
End Class
