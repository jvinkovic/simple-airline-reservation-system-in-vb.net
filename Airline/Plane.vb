Imports System.Data.OleDb
Public Class Plane
    Private Sub RefreshPlane()
        Dim da As New OleDbDataAdapter("Select * From tbl_Plane", cnn)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.Columns(0).Width = 200
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(2).Width = 150
    End Sub
    Private Sub Plane_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        ' Me.BackColor = Color.Transparent
        Me.Location = New Point(170, 35)
        RefreshPlane()
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Try

      
        If btn_Save.Text = "Save" Then
            copen()
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = cnn
            cmd.CommandText = "insert into tbl_Plane(Plane_ID, Plane_Name, Seat) Values('" & Plane_ID.Text & "','" & PlaneName.Text & "', '" & Seat.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Saved")
            cclose()
        ElseIf btn_Save.Text = "Update" Then
            copen()
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = cnn
            cmd.CommandText = "Update tbl_Plane Set Plane_Name='" & PlaneName.Text & "', Seat='" & Seat.Text & "' Where Plane_ID='" & Plane_ID.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Saved")
            cclose()
            btn_Save.Text = "Update"
            Plane_ID.ReadOnly = False
        End If
        RefreshPlane()
        Btn_Clear.PerformClick()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        If DataGridView1.RowCount > 0 Then
            Plane_ID.Text = DataGridView1.Item("Plane_ID", DataGridView1.CurrentRow.Index).Value
            PlaneName.Text = DataGridView1.Item("Plane_Name", DataGridView1.CurrentRow.Index).Value
            Seat.Text = DataGridView1.Item("Seat", DataGridView1.CurrentRow.Index).Value
            btn_Save.Text = "Update"
            Plane_ID.ReadOnly = True
        End If
    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        PlaneName.Text = ""
        Plane_ID.Text = ""
        Seat.Text = ""
        btn_Save.Text = "Save"
        Plane_ID.ReadOnly = False
    End Sub

    Private Sub Btn_Del_Click(sender As Object, e As EventArgs) Handles Btn_Del.Click
        If DataGridView1.RowCount > 0 Then
            Dim d As MsgBoxResult = MsgBox("Press Ok To Confirm", MsgBoxStyle.OkCancel)
            If d = MsgBoxResult.Ok Then


                copen()
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = cnn
                cmd.CommandText = "Delete * From tbl_Plane Where Plane_ID='" & DataGridView1.Item("Plane_ID", DataGridView1.CurrentRow.Index).Value & "'"
                cmd.ExecuteNonQuery()
                cclose()
                RefreshPlane()

            End If
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class