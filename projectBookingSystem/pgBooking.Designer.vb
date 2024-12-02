<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pgBooking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cmbTimeSlots = New System.Windows.Forms.ComboBox()
        Me.lblAppointmentDate = New System.Windows.Forms.Label()
        Me.lblTimeSlot = New System.Windows.Forms.Label()
        Me.txtClient = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.btnBookingAppointment = New System.Windows.Forms.Button()
        Me.dvgAppointments = New System.Windows.Forms.DataGridView()
        Me.lblAppointments = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAppointmentView = New System.Windows.Forms.Label()
        CType(Me.dvgAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(494, 181)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(297, 34)
        Me.DateTimePicker1.TabIndex = 0
        '
        'cmbTimeSlots
        '
        Me.cmbTimeSlots.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTimeSlots.FormattingEnabled = True
        Me.cmbTimeSlots.Location = New System.Drawing.Point(495, 256)
        Me.cmbTimeSlots.Name = "cmbTimeSlots"
        Me.cmbTimeSlots.Size = New System.Drawing.Size(296, 37)
        Me.cmbTimeSlots.TabIndex = 1
        '
        'lblAppointmentDate
        '
        Me.lblAppointmentDate.AutoSize = True
        Me.lblAppointmentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppointmentDate.Location = New System.Drawing.Point(489, 149)
        Me.lblAppointmentDate.Name = "lblAppointmentDate"
        Me.lblAppointmentDate.Size = New System.Drawing.Size(204, 29)
        Me.lblAppointmentDate.TabIndex = 2
        Me.lblAppointmentDate.Text = "Appointment Date"
        '
        'lblTimeSlot
        '
        Me.lblTimeSlot.AutoSize = True
        Me.lblTimeSlot.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeSlot.Location = New System.Drawing.Point(490, 224)
        Me.lblTimeSlot.Name = "lblTimeSlot"
        Me.lblTimeSlot.Size = New System.Drawing.Size(117, 29)
        Me.lblTimeSlot.TabIndex = 3
        Me.lblTimeSlot.Text = "Time Slot"
        '
        'txtClient
        '
        Me.txtClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClient.Location = New System.Drawing.Point(119, 183)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(301, 34)
        Me.txtClient.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(121, 259)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(299, 34)
        Me.txtEmail.TabIndex = 5
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(118, 228)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(74, 29)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Email"
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClient.Location = New System.Drawing.Point(116, 152)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(75, 29)
        Me.lblClient.TabIndex = 7
        Me.lblClient.Text = "Client"
        '
        'btnBookingAppointment
        '
        Me.btnBookingAppointment.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookingAppointment.Location = New System.Drawing.Point(819, 172)
        Me.btnBookingAppointment.Name = "btnBookingAppointment"
        Me.btnBookingAppointment.Size = New System.Drawing.Size(135, 121)
        Me.btnBookingAppointment.TabIndex = 8
        Me.btnBookingAppointment.Text = "Book"
        Me.btnBookingAppointment.UseVisualStyleBackColor = True
        '
        'dvgAppointments
        '
        Me.dvgAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgAppointments.Location = New System.Drawing.Point(129, 362)
        Me.dvgAppointments.Name = "dvgAppointments"
        Me.dvgAppointments.RowHeadersWidth = 51
        Me.dvgAppointments.RowTemplate.Height = 24
        Me.dvgAppointments.Size = New System.Drawing.Size(825, 310)
        Me.dvgAppointments.TabIndex = 9
        '
        'lblAppointments
        '
        Me.lblAppointments.AutoSize = True
        Me.lblAppointments.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppointments.Location = New System.Drawing.Point(114, 81)
        Me.lblAppointments.Name = "lblAppointments"
        Me.lblAppointments.Size = New System.Drawing.Size(225, 39)
        Me.lblAppointments.TabIndex = 10
        Me.lblAppointments.Text = "Appointments"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(126, 332)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(132, 25)
        Me.lblTitle.TabIndex = 11
        Me.lblTitle.Text = "Appointments"
        '
        'lblAppointmentView
        '
        Me.lblAppointmentView.AutoSize = True
        Me.lblAppointmentView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppointmentView.Location = New System.Drawing.Point(482, 688)
        Me.lblAppointmentView.Name = "lblAppointmentView"
        Me.lblAppointmentView.Size = New System.Drawing.Size(125, 18)
        Me.lblAppointmentView.TabIndex = 12
        Me.lblAppointmentView.Text = "Appointment View"
        '
        'pgBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 730)
        Me.Controls.Add(Me.lblAppointmentView)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblAppointments)
        Me.Controls.Add(Me.dvgAppointments)
        Me.Controls.Add(Me.btnBookingAppointment)
        Me.Controls.Add(Me.lblClient)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtClient)
        Me.Controls.Add(Me.lblTimeSlot)
        Me.Controls.Add(Me.lblAppointmentDate)
        Me.Controls.Add(Me.cmbTimeSlots)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pgBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.dvgAppointments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cmbTimeSlots As ComboBox
    Friend WithEvents lblAppointmentDate As Label
    Friend WithEvents lblTimeSlot As Label
    Friend WithEvents txtClient As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblClient As Label
    Friend WithEvents btnBookingAppointment As Button
    Friend WithEvents dvgAppointments As DataGridView
    Friend WithEvents lblAppointments As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblAppointmentView As Label
End Class
