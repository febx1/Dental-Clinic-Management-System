<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Appointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Appointment))
        Me.PatNamecb = New System.Windows.Forms.ComboBox()
        Me.Treatmentcb = New System.Windows.Forms.ComboBox()
        Me.Datedtp = New System.Windows.Forms.DateTimePicker()
        Me.Timedtp = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Appointdtv = New System.Windows.Forms.DataGridView()
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.Updatebtn = New System.Windows.Forms.Button()
        Me.Deletebtn = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.searchtb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.searchbt = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Appointdtv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PatNamecb
        '
        Me.PatNamecb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatNamecb.FormattingEnabled = True
        Me.PatNamecb.Location = New System.Drawing.Point(109, 163)
        Me.PatNamecb.Name = "PatNamecb"
        Me.PatNamecb.Size = New System.Drawing.Size(121, 28)
        Me.PatNamecb.TabIndex = 0
        '
        'Treatmentcb
        '
        Me.Treatmentcb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Treatmentcb.FormattingEnabled = True
        Me.Treatmentcb.Location = New System.Drawing.Point(677, 163)
        Me.Treatmentcb.Name = "Treatmentcb"
        Me.Treatmentcb.Size = New System.Drawing.Size(121, 28)
        Me.Treatmentcb.TabIndex = 0
        '
        'Datedtp
        '
        Me.Datedtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datedtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Datedtp.Location = New System.Drawing.Point(882, 163)
        Me.Datedtp.Name = "Datedtp"
        Me.Datedtp.Size = New System.Drawing.Size(152, 28)
        Me.Datedtp.TabIndex = 1
        '
        'Timedtp
        '
        Me.Timedtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timedtp.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Timedtp.Location = New System.Drawing.Point(1119, 163)
        Me.Timedtp.Name = "Timedtp"
        Me.Timedtp.ShowUpDown = True
        Me.Timedtp.Size = New System.Drawing.Size(148, 28)
        Me.Timedtp.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Patient Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(879, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(674, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Treatment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1116, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Time"
        '
        'Appointdtv
        '
        Me.Appointdtv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Appointdtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Appointdtv.Location = New System.Drawing.Point(158, 469)
        Me.Appointdtv.Name = "Appointdtv"
        Me.Appointdtv.RowHeadersWidth = 51
        Me.Appointdtv.RowTemplate.Height = 24
        Me.Appointdtv.Size = New System.Drawing.Size(931, 219)
        Me.Appointdtv.TabIndex = 3
        '
        'Savebtn
        '
        Me.Savebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Savebtn.Location = New System.Drawing.Point(297, 323)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(111, 33)
        Me.Savebtn.TabIndex = 4
        Me.Savebtn.Text = "Save"
        Me.Savebtn.UseVisualStyleBackColor = True
        '
        'Updatebtn
        '
        Me.Updatebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Updatebtn.Location = New System.Drawing.Point(534, 323)
        Me.Updatebtn.Name = "Updatebtn"
        Me.Updatebtn.Size = New System.Drawing.Size(111, 33)
        Me.Updatebtn.TabIndex = 4
        Me.Updatebtn.Text = "Update"
        Me.Updatebtn.UseVisualStyleBackColor = True
        '
        'Deletebtn
        '
        Me.Deletebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deletebtn.Location = New System.Drawing.Point(771, 323)
        Me.Deletebtn.Name = "Deletebtn"
        Me.Deletebtn.Size = New System.Drawing.Size(111, 33)
        Me.Deletebtn.TabIndex = 4
        Me.Deletebtn.Text = "Delete"
        Me.Deletebtn.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(360, 163)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(200, 124)
        Me.ListBox1.TabIndex = 5
        '
        'searchtb
        '
        Me.searchtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchtb.Location = New System.Drawing.Point(578, 408)
        Me.searchtb.Name = "searchtb"
        Me.searchtb.Size = New System.Drawing.Size(148, 28)
        Me.searchtb.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(210, 416)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(268, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Search for patient appointment"
        '
        'searchbt
        '
        Me.searchbt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbt.Location = New System.Drawing.Point(741, 401)
        Me.searchbt.Name = "searchbt"
        Me.searchbt.Size = New System.Drawing.Size(121, 36)
        Me.searchbt.TabIndex = 8
        Me.searchbt.Text = "Search"
        Me.searchbt.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(356, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Patient username"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1431, 10)
        Me.Panel2.TabIndex = 25
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumVioletRed
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1431, 60)
        Me.Panel1.TabIndex = 24
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(74, 60)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(92, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 36)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Appointment"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(878, 401)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Appointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1431, 754)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.searchbt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.searchtb)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Deletebtn)
        Me.Controls.Add(Me.Updatebtn)
        Me.Controls.Add(Me.Savebtn)
        Me.Controls.Add(Me.Appointdtv)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Timedtp)
        Me.Controls.Add(Me.Datedtp)
        Me.Controls.Add(Me.Treatmentcb)
        Me.Controls.Add(Me.PatNamecb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Appointment"
        Me.Text = "Appointment"
        CType(Me.Appointdtv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PatNamecb As ComboBox
    Friend WithEvents Treatmentcb As ComboBox
    Friend WithEvents Datedtp As DateTimePicker
    Friend WithEvents Timedtp As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Appointdtv As DataGridView
    Friend WithEvents Savebtn As Button
    Friend WithEvents Updatebtn As Button
    Friend WithEvents Deletebtn As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents searchtb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents searchbt As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
