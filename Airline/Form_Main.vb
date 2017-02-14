Public Class Form_Main

    Private Sub Form_Main_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        LoginForm.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try

            Flight.Close()
            Passenger.Close()
            Form_Report.Close()

        Catch ex As Exception

        End Try
        Plane.MdiParent = Me
        Plane.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        Timer1.Start()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Plane.Close()
            Passenger.Close()
            Form_Report.Close()

        Catch ex As Exception

        End Try
        Flight.MdiParent = Me
        Flight.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Flight.Close()
            Form_Report.Close()
            Plane.Close()

        Catch ex As Exception

        End Try
        Passenger.MdiParent = Me
        Passenger.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblDate.Text = "Today : " + Today.ToLongDateString
        LblTime.Text = "Time : " + DateAndTime.Now
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Flight.Close()
            Passenger.Close()
            Plane.Close()

        Catch ex As Exception

        End Try
        Try
            Form_Report.MdiParent = Me
            Form_Report.Show()
        Catch ex2 As Exception
        End Try

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AboutBox.ShowDialog()
    End Sub
End Class