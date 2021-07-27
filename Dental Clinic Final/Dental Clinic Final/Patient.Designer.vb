<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Patient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patient))
        Me.Patgencb = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Patagetb = New System.Windows.Forms.TextBox()
        Me.Pataddresstb = New System.Windows.Forms.TextBox()
        Me.Patphonetb = New System.Windows.Forms.TextBox()
        Me.Patnametb = New System.Windows.Forms.TextBox()
        Me.Patientdtv = New System.Windows.Forms.DataGridView()
        Me.Deletebtn = New System.Windows.Forms.Button()
        Me.Updatebtn = New System.Windows.Forms.Button()
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.searchtb = New System.Windows.Forms.TextBox()
        Me.searchbtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.Patientdtv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Patgencb
        '
        Me.Patgencb.FormattingEnabled = True
        Me.Patgencb.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.Patgencb.Location = New System.Drawing.Point(1041, 141)
        Me.Patgencb.Name = "Patgencb"
        Me.Patgencb.Size = New System.Drawing.Size(121, 24)
        Me.Patgencb.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1075, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(904, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Age"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(685, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(468, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Phone"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Name"
        '
        'Patagetb
        '
        Me.Patagetb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Patagetb.Location = New System.Drawing.Point(873, 146)
        Me.Patagetb.Name = "Patagetb"
        Me.Patagetb.Size = New System.Drawing.Size(100, 28)
        Me.Patagetb.TabIndex = 10
        '
        'Pataddresstb
        '
        Me.Pataddresstb.BackColor = System.Drawing.SystemColors.Window
        Me.Pataddresstb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pataddresstb.Location = New System.Drawing.Point(657, 146)
        Me.Pataddresstb.Multiline = True
        Me.Pataddresstb.Name = "Pataddresstb"
        Me.Pataddresstb.Size = New System.Drawing.Size(149, 93)
        Me.Pataddresstb.TabIndex = 11
        '
        'Patphonetb
        '
        Me.Patphonetb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Patphonetb.Location = New System.Drawing.Point(437, 146)
        Me.Patphonetb.Name = "Patphonetb"
        Me.Patphonetb.Size = New System.Drawing.Size(151, 28)
        Me.Patphonetb.TabIndex = 12
        '
        'Patnametb
        '
        Me.Patnametb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Patnametb.Location = New System.Drawing.Point(228, 146)
        Me.Patnametb.Name = "Patnametb"
        Me.Patnametb.Size = New System.Drawing.Size(150, 28)
        Me.Patnametb.TabIndex = 13
        '
        'Patientdtv
        '
        Me.Patientdtv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Patientdtv.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Patientdtv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.Patientdtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Patientdtv.GridColor = System.Drawing.Color.White
        Me.Patientdtv.Location = New System.Drawing.Point(250, 424)
        Me.Patientdtv.Name = "Patientdtv"
        Me.Patientdtv.RowHeadersWidth = 51
        Me.Patientdtv.RowTemplate.Height = 24
        Me.Patientdtv.Size = New System.Drawing.Size(931, 219)
        Me.Patientdtv.TabIndex = 9
        '
        'Deletebtn
        '
        Me.Deletebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deletebtn.Location = New System.Drawing.Point(822, 330)
        Me.Deletebtn.Name = "Deletebtn"
        Me.Deletebtn.Size = New System.Drawing.Size(121, 32)
        Me.Deletebtn.TabIndex = 6
        Me.Deletebtn.Text = "Delete"
        Me.Deletebtn.UseVisualStyleBackColor = True
        '
        'Updatebtn
        '
        Me.Updatebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Updatebtn.Location = New System.Drawing.Point(655, 330)
        Me.Updatebtn.Name = "Updatebtn"
        Me.Updatebtn.Size = New System.Drawing.Size(121, 32)
        Me.Updatebtn.TabIndex = 7
        Me.Updatebtn.Text = "Update"
        Me.Updatebtn.UseVisualStyleBackColor = True
        '
        'Savebtn
        '
        Me.Savebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Savebtn.Location = New System.Drawing.Point(488, 330)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(121, 32)
        Me.Savebtn.TabIndex = 8
        Me.Savebtn.Text = "Save"
        Me.Savebtn.UseVisualStyleBackColor = True
        '
        'searchtb
        '
        Me.searchtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchtb.Location = New System.Drawing.Point(655, 387)
        Me.searchtb.Name = "searchtb"
        Me.searchtb.Size = New System.Drawing.Size(162, 28)
        Me.searchtb.TabIndex = 10
        '
        'searchbtn
        '
        Me.searchbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbtn.Location = New System.Drawing.Point(831, 387)
        Me.searchbtn.Name = "searchbtn"
        Me.searchbtn.Size = New System.Drawing.Size(120, 29)
        Me.searchbtn.TabIndex = 6
        Me.searchbtn.Text = "Search"
        Me.searchbtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumVioletRed
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1431, 60)
        Me.Panel1.TabIndex = 22
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(92, 67)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(87, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 36)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Patient"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1431, 10)
        Me.Panel2.TabIndex = 23
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(957, 388)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(447, 393)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 20)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Search for patient "
        '
        'Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1431, 754)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Patgencb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.searchtb)
        Me.Controls.Add(Me.Patagetb)
        Me.Controls.Add(Me.Pataddresstb)
        Me.Controls.Add(Me.Patphonetb)
        Me.Controls.Add(Me.Patnametb)
        Me.Controls.Add(Me.Patientdtv)
        Me.Controls.Add(Me.searchbtn)
        Me.Controls.Add(Me.Deletebtn)
        Me.Controls.Add(Me.Updatebtn)
        Me.Controls.Add(Me.Savebtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Patient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patientd"
        CType(Me.Patientdtv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Patgencb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Patagetb As TextBox
    Friend WithEvents Pataddresstb As TextBox
    Friend WithEvents Patphonetb As TextBox
    Friend WithEvents Patnametb As TextBox
    Friend WithEvents Patientdtv As DataGridView
    Friend WithEvents Deletebtn As Button
    Friend WithEvents Updatebtn As Button
    Friend WithEvents Savebtn As Button
    Friend WithEvents searchtb As TextBox
    Friend WithEvents searchbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label7 As Label
End Class
