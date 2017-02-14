<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Flight
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Plane_Name = New System.Windows.Forms.TextBox()
        Me.Seat = New System.Windows.Forms.TextBox()
        Me.Flight_ID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.Btn_Del = New System.Windows.Forms.Button()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Plane_ID = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.D_ate = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.D_Time = New System.Windows.Forms.DateTimePicker()
        Me.A_time = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(786, 31)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Avaliable Flights"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Plane_Name
        '
        Me.Plane_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Plane_Name.Location = New System.Drawing.Point(107, 136)
        Me.Plane_Name.Name = "Plane_Name"
        Me.Plane_Name.ReadOnly = True
        Me.Plane_Name.Size = New System.Drawing.Size(216, 23)
        Me.Plane_Name.TabIndex = 15
        '
        'Seat
        '
        Me.Seat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Seat.Location = New System.Drawing.Point(108, 165)
        Me.Seat.Name = "Seat"
        Me.Seat.ReadOnly = True
        Me.Seat.Size = New System.Drawing.Size(216, 23)
        Me.Seat.TabIndex = 14
        '
        'Flight_ID
        '
        Me.Flight_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Flight_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Flight_ID.Location = New System.Drawing.Point(107, 71)
        Me.Flight_ID.Name = "Flight_ID"
        Me.Flight_ID.Size = New System.Drawing.Size(216, 23)
        Me.Flight_ID.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Seat Available"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(44, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "PlaneID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(42, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Flight ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(20, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "PlaneName"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(333, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = " Depature Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(352, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 17)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Date"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Airline.My.Resources.Resources.bg6
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(829, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 50)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Airline.My.Resources.Resources.bg6
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(829, 171)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 50)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Airline.My.Resources.Resources.bg41
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(829, 226)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 50)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.Airline.My.Resources.Resources.bg41
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(829, 282)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 50)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "Clear"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Btn_Clear
        '
        Me.Btn_Clear.BackgroundImage = Global.Airline.My.Resources.Resources.bg41
        Me.Btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Clear.ForeColor = System.Drawing.Color.White
        Me.Btn_Clear.Location = New System.Drawing.Point(649, 268)
        Me.Btn_Clear.Name = "Btn_Clear"
        Me.Btn_Clear.Size = New System.Drawing.Size(100, 50)
        Me.Btn_Clear.TabIndex = 37
        Me.Btn_Clear.Text = "Clear"
        Me.Btn_Clear.UseVisualStyleBackColor = True
        '
        'Btn_Del
        '
        Me.Btn_Del.BackgroundImage = Global.Airline.My.Resources.Resources.bg41
        Me.Btn_Del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Del.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Del.ForeColor = System.Drawing.Color.White
        Me.Btn_Del.Location = New System.Drawing.Point(649, 207)
        Me.Btn_Del.Name = "Btn_Del"
        Me.Btn_Del.Size = New System.Drawing.Size(100, 50)
        Me.Btn_Del.TabIndex = 36
        Me.Btn_Del.Text = "Delete"
        Me.Btn_Del.UseVisualStyleBackColor = True
        '
        'Btn_Edit
        '
        Me.Btn_Edit.BackgroundImage = Global.Airline.My.Resources.Resources.bg6
        Me.Btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Edit.ForeColor = System.Drawing.Color.White
        Me.Btn_Edit.Location = New System.Drawing.Point(649, 145)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(100, 50)
        Me.Btn_Edit.TabIndex = 35
        Me.Btn_Edit.Text = "Edit"
        Me.Btn_Edit.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.BackgroundImage = Global.Airline.My.Resources.Resources.bg6
        Me.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.ForeColor = System.Drawing.Color.White
        Me.btn_Save.Location = New System.Drawing.Point(649, 84)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(100, 50)
        Me.btn_Save.TabIndex = 34
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'Btn_Close
        '
        Me.Btn_Close.BackgroundImage = Global.Airline.My.Resources.Resources.bg51
        Me.Btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Close.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_Close.FlatAppearance.BorderSize = 10
        Me.Btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Btn_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Close.ForeColor = System.Drawing.Color.White
        Me.Btn_Close.Location = New System.Drawing.Point(649, 330)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(100, 50)
        Me.Btn_Close.TabIndex = 33
        Me.Btn_Close.Text = "Close"
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(338, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 17)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Arrival Time"
        '
        'Plane_ID
        '
        Me.Plane_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Plane_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Plane_ID.FormattingEnabled = True
        Me.Plane_ID.Location = New System.Drawing.Point(108, 105)
        Me.Plane_ID.Name = "Plane_ID"
        Me.Plane_ID.Size = New System.Drawing.Size(215, 24)
        Me.Plane_ID.TabIndex = 40
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AntiqueWhite
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(42, 209)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(569, 271)
        Me.DataGridView1.TabIndex = 41
        '
        'D_ate
        '
        Me.D_ate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.D_ate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.D_ate.Location = New System.Drawing.Point(446, 134)
        Me.D_ate.Name = "D_ate"
        Me.D_ate.Size = New System.Drawing.Size(93, 23)
        Me.D_ate.TabIndex = 44
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Airline.My.Resources.Resources.orb
        Me.PictureBox1.Location = New System.Drawing.Point(762, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 18)
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'D_Time
        '
        Me.D_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.D_Time.Location = New System.Drawing.Point(446, 70)
        Me.D_Time.Name = "D_Time"
        Me.D_Time.Size = New System.Drawing.Size(93, 20)
        Me.D_Time.TabIndex = 46
        '
        'A_time
        '
        Me.A_time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.A_time.Location = New System.Drawing.Point(446, 102)
        Me.A_time.Name = "A_time"
        Me.A_time.Size = New System.Drawing.Size(93, 20)
        Me.A_time.TabIndex = 47
        '
        'Flight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(786, 492)
        Me.Controls.Add(Me.A_time)
        Me.Controls.Add(Me.D_Time)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.D_ate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Plane_ID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Btn_Clear)
        Me.Controls.Add(Me.Btn_Del)
        Me.Controls.Add(Me.Btn_Edit)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Plane_Name)
        Me.Controls.Add(Me.Seat)
        Me.Controls.Add(Me.Flight_ID)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(40, 35)
        Me.Name = "Flight"
        Me.Text = "Flight"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Plane_Name As System.Windows.Forms.TextBox
    Friend WithEvents Seat As System.Windows.Forms.TextBox
    Friend WithEvents Flight_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Btn_Clear As System.Windows.Forms.Button
    Friend WithEvents Btn_Del As System.Windows.Forms.Button
    Friend WithEvents Btn_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents Btn_Close As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Plane_ID As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents D_ate As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents D_Time As System.Windows.Forms.DateTimePicker
    Friend WithEvents A_time As System.Windows.Forms.DateTimePicker
End Class
