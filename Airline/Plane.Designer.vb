<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Plane
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
        Me.Plane_ID = New System.Windows.Forms.TextBox()
        Me.PlaneName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Seat = New System.Windows.Forms.MaskedTextBox()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.Btn_Del = New System.Windows.Forms.Button()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Avaliable Planes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Plane_ID
        '
        Me.Plane_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Plane_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Plane_ID.Location = New System.Drawing.Point(124, 88)
        Me.Plane_ID.Name = "Plane_ID"
        Me.Plane_ID.Size = New System.Drawing.Size(184, 23)
        Me.Plane_ID.TabIndex = 8
        '
        'PlaneName
        '
        Me.PlaneName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PlaneName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaneName.Location = New System.Drawing.Point(124, 127)
        Me.PlaneName.Name = "PlaneName"
        Me.PlaneName.Size = New System.Drawing.Size(353, 23)
        Me.PlaneName.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(30, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Plane ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(30, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Plane Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(314, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Seat Available"
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
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(59, 167)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(569, 298)
        Me.DataGridView1.TabIndex = 15
        '
        'Seat
        '
        Me.Seat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Seat.Location = New System.Drawing.Point(419, 88)
        Me.Seat.Mask = "000"
        Me.Seat.Name = "Seat"
        Me.Seat.Size = New System.Drawing.Size(38, 23)
        Me.Seat.TabIndex = 33
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
        Me.Btn_Clear.TabIndex = 32
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
        Me.Btn_Del.TabIndex = 31
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
        Me.Btn_Edit.TabIndex = 30
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
        Me.btn_Save.TabIndex = 29
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
        Me.Btn_Close.TabIndex = 28
        Me.Btn_Close.Text = "Close"
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Airline.My.Resources.Resources.orb
        Me.PictureBox1.Location = New System.Drawing.Point(764, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 18)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Plane
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(786, 492)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Seat)
        Me.Controls.Add(Me.Btn_Clear)
        Me.Controls.Add(Me.Btn_Del)
        Me.Controls.Add(Me.Btn_Edit)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PlaneName)
        Me.Controls.Add(Me.Plane_ID)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(40, 35)
        Me.Name = "Plane"
        Me.Text = "Plane"
        Me.TransparencyKey = System.Drawing.Color.AntiqueWhite
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Plane_ID As System.Windows.Forms.TextBox
    Friend WithEvents PlaneName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Clear As System.Windows.Forms.Button
    Friend WithEvents Btn_Del As System.Windows.Forms.Button
    Friend WithEvents Btn_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents Btn_Close As System.Windows.Forms.Button
    Friend WithEvents Seat As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
