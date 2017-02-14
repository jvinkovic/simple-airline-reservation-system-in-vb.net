Public Class Flight

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub RefreshFlight()
        Dim da As New OleDb.OleDbDataAdapter("Select * From tbl_Flight", cnn)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub
    Private Sub Flight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        'Me.BackColor = Color.Transparent
        Me.Location = New Point(170, 35)

        Dim da As New OleDb.OleDbDataAdapter("Select Plane_ID From tbl_Plane", cnn)
        Dim dt As New DataTable
        da.Fill(dt)
        Plane_ID.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Plane_ID.Items.Add(dt.Rows(i).Item("Plane_ID"))
        Next
        RefreshFlight()

    End Sub

   
    Private Sub Plane_ID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Plane_ID.SelectedIndexChanged
        Dim da As New OleDb.OleDbDataAdapter("Select Plane_Name, Seat From tbl_Plane Where Plane_ID='" & Plane_ID.Text & "'", cnn)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Plane_Name.Text = dt.Rows(0).Item("Plane_Name")
            Seat.Text = dt.Rows(0).Item("Seat")

        End If
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Try

       
        If btn_Save.Text = "Save" Then
            copen()
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = cnn
            cmd.CommandText = "Insert into tbl_Flight(Flight_ID, Plane_ID, A_time, D_time, Flight_Date) Values('" & Flight_ID.Text & "', '" & Plane_ID.Text & "', '" & A_time.Text & "', '" & D_Time.Text & "', '" & D_ate.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Saved")
            cclose()
            RefreshFlight()
            Btn_Clear.PerformClick()
        ElseIf btn_Save.Text = "Update" Then
            copen()
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = cnn
            cmd.CommandText = "Update tbl_Flight set Plane_ID='" & Plane_ID.Text & "', A_time='" & A_time.Text & "', D_time='" & D_Time.Text & "', Flight_Date='" & D_ate.Text & "' Where Flight_ID='" & Flight_ID.Text & "'"
            cmd.ExecuteNonQuery()
            cclose()
            RefreshFlight()
            Btn_Clear.PerformClick()
        End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        Flight_ID.Text = ""
        Plane_ID.SelectedIndex = -1
        Plane_Name.Text = ""
        A_Time.Text = ""
        D_Time.Text = ""
        D_ate.Text = ""
        Seat.Text = ""
        btn_Save.Text = "Save"
        Flight_ID.ReadOnly = False
    End Sub

    Private Sub Btn_Del_Click(sender As Object, e As EventArgs) Handles Btn_Del.Click
        If DataGridView1.RowCount > 0 Then


            Dim d As DialogResult = MsgBox(" Are you sure want to delete? Press 'OK' to confirm", MsgBoxStyle.OkCancel)
            If d = Windows.Forms.DialogResult.OK Then
                copen()
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = cnn
                cmd.CommandText = "Delete * from tbl_flight where flight_id = '" & DataGridView1.Item("flight_id", DataGridView1.CurrentRow.Index).Value & "'"
                cmd.ExecuteNonQuery()
                RefreshFlight()
                cclose()
            End If
        End If
    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        If DataGridView1.RowCount > 0 Then

            Flight_ID.Text = DataGridView1.Item("Flight_ID", DataGridView1.CurrentRow.Index).Value
            Plane_ID.Text = DataGridView1.Item("Plane_ID", DataGridView1.CurrentRow.Index).Value
            D_Time.Text = DataGridView1.Item("D_Time", DataGridView1.CurrentRow.Index).Value
            A_Time.Text = DataGridView1.Item("A_Time", DataGridView1.CurrentRow.Index).Value
            D_ate.Text = DataGridView1.Item("Flight_Date", DataGridView1.CurrentRow.Index).Value
            btn_Save.Text = "Update"
            Flight_ID.ReadOnly = True
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class