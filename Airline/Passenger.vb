Public Class Passenger
    Private Sub RefresPassenger()
        DataGridView1.Columns.Clear()
        Dim da As New OleDb.OleDbDataAdapter("Select * From tbl_Passenger Where Flight_ID='" & CmbFlightID.Text & "'", cnn)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.Columns("Flight_ID").Visible = False
        DataGridView1.Columns("Age").Width = 50
        DataGridView1.Columns("P_ID").Width = 50


        Dim btn As New DataGridViewButtonColumn()
        'DataGridView1.Columns.Add(btn)
        btn.HeaderText = "Ticket"
        btn.Text = "Print Ticket"
        btn.Name = "btn"
        btn.UseColumnTextForButtonValue = True
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex = 7 Then
            Dim ds As New PlaneDataSet

        End If
    End Sub
    Private Sub FillFlightIDCombo()
        Dim da As New OleDb.OleDbDataAdapter("Select Flight_ID From tbl_Flight", cnn)
        Dim dt As New DataTable
        da.Fill(dt)
        CmbFlightID.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            CmbFlightID.Items.Add(dt.Rows(i).Item("Flight_ID"))
        Next
    End Sub
    Private Sub CalcReservedSeat()
        Dim daa As New OleDb.OleDbDataAdapter("Select Plane_ID From tbl_Flight where Flight_ID='" & CmbFlightID.Text & "'", cnn)
        Dim dtt As New DataTable
        daa.Fill(dtt)


        Dim daaa As New OleDb.OleDbDataAdapter("Select Seat from tbl_Plane Where Plane_ID='" & dtt.Rows(0).Item(0).ToString & "'", cnn)
        Dim dttt As New DataTable
        daaa.Fill(dttt)
        Unserved.Text = dttt.Rows(0).Item(0) - DataGridView1.RowCount
        ReServed.Text = DataGridView1.RowCount
    End Sub

    Private Sub Passenger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(170, 35)
        FillFlightIDCombo()


    End Sub

    Private Sub Plane_ID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFlightID.SelectedIndexChanged


        RefresPassenger()
        Dim da As New OleDb.OleDbDataAdapter("Select A_Time, D_Time, Flight_Date From tbl_Flight Where Flight_ID='" & CmbFlightID.Text & "'", cnn)

        Dim dt As New DataTable
        da.Fill(dt)
        A_Time.Text = dt.Rows(0).Item("A_Time")
        D_Time.Text = dt.Rows(0).Item("D_Time")
        D_Ate.Text = dt.Rows(0).Item("Flight_date")

        CalcReservedSeat()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub
    Private Function check() As Boolean
        If CmbFlightID.Text <> "" And P_ID.Text <> "" And P_name.Text <> "" And P_Address.Text <> "" And P_Age.Text <> "" Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Try

      
        If check() = False Then
            MsgBox("Please Insert * Information")
            Exit Sub
        End If

        If btn_Save.Text = "Save" Then
            copen()
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = cnn
            cmd.CommandText = "Insert into tbl_Passenger(P_ID, P_Name, P_Address, P_Contact, Age, Gender, Flight_ID) Values('" & P_ID.Text & "', '" & P_name.Text & "', '" & P_Address.Text & "', '" & P_Contact.Text & "', '" & P_Age.Text & "', '" & P_Gender.Text & "', '" & CmbFlightID.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Saved")
            cclose()
            RefresPassenger()
            Btn_Clear.PerformClick()
        ElseIf btn_Save.Text = "Update" Then
            copen()
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = cnn
            cmd.CommandText = "Update tbl_Passenger set P_Name='" & P_name.Text & "', P_Address='" & P_Address.Text & "', P_Contact='" & P_Contact.Text & "', Age='" & P_Age.Text & "', Gender='" & P_Gender.Text & "', Flight_ID='" & CmbFlightID.Text & "' Where P_ID='" & P_ID.Text & "'"

            cmd.ExecuteNonQuery()
            cclose()
            RefresPassenger()
            Btn_Clear.PerformClick()
        End If
            CalcReservedSeat()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        P_ID.Text = ""
        P_name.Text = ""
        P_Address.Text = ""
        P_Age.Text = ""
        P_Gender.Text = ""
        P_Contact.Text = ""
        btn_Save.Text = "Save"
        P_ID.ReadOnly = False
    End Sub

    Private Sub Btn_Del_Click(sender As Object, e As EventArgs) Handles Btn_Del.Click

        If DataGridView1.RowCount > 0 Then
            Dim d As DialogResult = MsgBox("Press Ok to Confirm Delete", MsgBoxStyle.OkCancel)
            If d = Windows.Forms.DialogResult.OK Then
                copen()
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = cnn
                cmd.CommandText = "Delete * from tbl_Passenger Where P_ID= '" & DataGridView1.Item("P_ID", DataGridView1.CurrentRow.Index).Value & "'"
                cmd.ExecuteNonQuery()
                cclose()
                RefresPassenger()
                Btn_Clear.PerformClick()
            End If
        End If
        CalcReservedSeat()
    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        If DataGridView1.RowCount > 0 Then
            P_ID.Text = DataGridView1.Item("P_ID", DataGridView1.CurrentRow.Index).Value
            P_name.Text = DataGridView1.Item("P_Name", DataGridView1.CurrentRow.Index).Value
            P_Address.Text = DataGridView1.Item("P_Address", DataGridView1.CurrentRow.Index).Value
            P_Contact.Text = DataGridView1.Item("P_Contact", DataGridView1.CurrentRow.Index).Value
            P_Age.Text = DataGridView1.Item("Age", DataGridView1.CurrentRow.Index).Value
            P_Gender.Text = DataGridView1.Item("Gender", DataGridView1.CurrentRow.Index).Value
            btn_Save.Text = "Update"
            P_ID.ReadOnly = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub P_Contact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles P_Contact.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
                Beep()
            End If

        End If

    End Sub

    Private Sub P_Contact_TextChanged(sender As Object, e As EventArgs) Handles P_Contact.TextChanged

    End Sub

    Private Sub P_Age_KeyPress(sender As Object, e As KeyPressEventArgs) Handles P_Age.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
                Beep()
            End If

        End If

    End Sub

    Private Sub P_Age_TextChanged(sender As Object, e As EventArgs) Handles P_Age.TextChanged

    End Sub
End Class