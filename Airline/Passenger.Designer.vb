<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Passenger
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbFlightID = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.P_Age = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.P_Contact = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.P_Address = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.P_name = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.P_ID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.A_Time = New System.Windows.Forms.Label()
        Me.D_Time = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.D_Ate = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ReServed = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Unserved = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.Btn_Del = New System.Windows.Forms.Button()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.P_Gender = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
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
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Passengers"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(14, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Select Flight"
        '
        'CmbFlightID
        '
        Me.CmbFlightID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFlightID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CmbFlightID.FormattingEnabled = True
        Me.CmbFlightID.Location = New System.Drawing.Point(109, 57)
        Me.CmbFlightID.Name = "CmbFlightID"
        Me.CmbFlightID.Size = New System.Drawing.Size(201, 24)
        Me.CmbFlightID.TabIndex = 41
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.P_Gender)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.P_Age)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.P_Contact)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.P_Address)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.P_name)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.P_ID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 138)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Passenger Details"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(333, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 17)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Gender"
        '
        'P_Age
        '
        Me.P_Age.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.P_Age.Location = New System.Drawing.Point(111, 97)
        Me.P_Age.Name = "P_Age"
        Me.P_Age.Size = New System.Drawing.Size(201, 23)
        Me.P_Age.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(66, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 17)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Age"
        '
        'P_Contact
        '
        Me.P_Contact.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.P_Contact.Location = New System.Drawing.Point(401, 68)
        Me.P_Contact.Name = "P_Contact"
        Me.P_Contact.Size = New System.Drawing.Size(201, 23)
        Me.P_Contact.TabIndex = 52
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(333, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Contact"
        '
        'P_Address
        '
        Me.P_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.P_Address.Location = New System.Drawing.Point(111, 68)
        Me.P_Address.Name = "P_Address"
        Me.P_Address.Size = New System.Drawing.Size(201, 23)
        Me.P_Address.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(39, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 17)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Address"
        '
        'P_name
        '
        Me.P_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.P_name.Location = New System.Drawing.Point(401, 34)
        Me.P_name.Name = "P_name"
        Me.P_name.Size = New System.Drawing.Size(201, 23)
        Me.P_name.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(318, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Full Name"
        '
        'P_ID
        '
        Me.P_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.P_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.P_ID.Location = New System.Drawing.Point(111, 34)
        Me.P_ID.Name = "P_ID"
        Me.P_ID.Size = New System.Drawing.Size(201, 23)
        Me.P_ID.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(6, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Passenger ID"
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
        Me.DataGridView1.Location = New System.Drawing.Point(17, 254)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(608, 249)
        Me.DataGridView1.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(335, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Arrival Time"
        '
        'A_Time
        '
        Me.A_Time.AutoSize = True
        Me.A_Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.A_Time.Location = New System.Drawing.Point(424, 57)
        Me.A_Time.Name = "A_Time"
        Me.A_Time.Size = New System.Drawing.Size(12, 17)
        Me.A_Time.TabIndex = 49
        Me.A_Time.Text = "."
        '
        'D_Time
        '
        Me.D_Time.AutoSize = True
        Me.D_Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.D_Time.Location = New System.Drawing.Point(588, 57)
        Me.D_Time.Name = "D_Time"
        Me.D_Time.Size = New System.Drawing.Size(12, 17)
        Me.D_Time.TabIndex = 51
        Me.D_Time.Text = "."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(475, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 17)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Departure Time"
        '
        'D_Ate
        '
        Me.D_Ate.AutoSize = True
        Me.D_Ate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.D_Ate.Location = New System.Drawing.Point(424, 90)
        Me.D_Ate.Name = "D_Ate"
        Me.D_Ate.Size = New System.Drawing.Size(12, 17)
        Me.D_Ate.TabIndex = 53
        Me.D_Ate.Text = "."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(380, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 17)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Date"
        '
        'ReServed
        '
        Me.ReServed.AutoSize = True
        Me.ReServed.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ReServed.Location = New System.Drawing.Point(120, 90)
        Me.ReServed.Name = "ReServed"
        Me.ReServed.Size = New System.Drawing.Size(12, 17)
        Me.ReServed.TabIndex = 55
        Me.ReServed.Text = "."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(14, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 17)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Reserved Seat"
        '
        'Unserved
        '
        Me.Unserved.AutoSize = True
        Me.Unserved.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Unserved.Location = New System.Drawing.Point(267, 90)
        Me.Unserved.Name = "Unserved"
        Me.Unserved.Size = New System.Drawing.Size(12, 17)
        Me.Unserved.TabIndex = 57
        Me.Unserved.Text = "."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(141, 90)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 17)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "UnReserved Seat"
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
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Airline.My.Resources.Resources.orb
        Me.PictureBox1.Location = New System.Drawing.Point(764, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 18)
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'P_Gender
        '
        Me.P_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.P_Gender.FormattingEnabled = True
        Me.P_Gender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.P_Gender.Location = New System.Drawing.Point(401, 98)
        Me.P_Gender.Name = "P_Gender"
        Me.P_Gender.Size = New System.Drawing.Size(201, 24)
        Me.P_Gender.TabIndex = 56
        '
        'Passenger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(786, 492)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Unserved)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ReServed)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.D_Ate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.D_Time)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.A_Time)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CmbFlightID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_Clear)
        Me.Controls.Add(Me.Btn_Del)
        Me.Controls.Add(Me.Btn_Edit)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(40, 40)
        Me.Name = "Passenger"
        Me.Text = "Passenger"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Clear As System.Windows.Forms.Button
    Friend WithEvents Btn_Del As System.Windows.Forms.Button
    Friend WithEvents Btn_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents Btn_Close As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbFlightID As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents P_Age As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents P_Contact As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents P_Address As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents P_name As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents P_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents A_Time As System.Windows.Forms.Label
    Friend WithEvents D_Time As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents D_Ate As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ReServed As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Unserved As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents P_Gender As System.Windows.Forms.ComboBox
End Class
