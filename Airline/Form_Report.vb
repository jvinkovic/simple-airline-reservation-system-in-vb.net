Imports CrystalDecisions.Windows.Forms

Public Class Form_Report

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Me.Location = New Point(170, 35)
        Dim da As New OleDb.OleDbDataAdapter("Select * From tbl_Flight", cnn)
        Dim dt As New DataTable
        da.Fill(dt)
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("All")
        For i = 0 To dt.Rows.Count - 1
            ComboBox1.Items.Add(dt.Rows(i).Item("Flight_ID"))
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Dim da As OleDb.OleDbDataAdapter

        If ComboBox1.Text = "All" Then
            da = New OleDb.OleDbDataAdapter("Select * From tbl_Passenger", cnn)
        Else
            da = New OleDb.OleDbDataAdapter("Select * From tbl_Passenger Where Flight_ID='" & ComboBox1.Text & "'", cnn)
        End If

        Dim ds As New PlaneDataSet

        da.Fill(ds, "tbl_Passenger")

        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "tbl_Passenger"

        'DataGridView1.Refresh()

        'Dim rpt As New CrystalReport1
        'rpt.SetDataSource(ds)
        'CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Form_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(170, 35)
        Dim da As New OleDb.OleDbDataAdapter("Select * From tbl_Flight", cnn)
        Dim dt As New DataTable
        da.Fill(dt)
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("All")
        For i = 0 To dt.Rows.Count - 1
            ComboBox1.Items.Add(dt.Rows(i).Item("Flight_ID"))
        Next

        Me.DataGridView1.Refresh()
    End Sub

End Class