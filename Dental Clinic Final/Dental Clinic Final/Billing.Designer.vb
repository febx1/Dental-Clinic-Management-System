<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Billing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Billing))
        Me.costtb = New System.Windows.Forms.TextBox()
        Me.Billdtv = New System.Windows.Forms.DataGridView()
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.Updatebtn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Patnamecb = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.searchtb = New System.Windows.Forms.TextBox()
        Me.searchbt = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Billdtv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'costtb
        '
        Me.costtb.Location = New System.Drawing.Point(930, 161)
        Me.costtb.Name = "costtb"
        Me.costtb.ReadOnly = True
        Me.costtb.Size = New System.Drawing.Size(100, 22)
        Me.costtb.TabIndex = 0
        '
        'Billdtv
        '
        Me.Billdtv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Billdtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Billdtv.Location = New System.Drawing.Point(250, 384)
        Me.Billdtv.Name = "Billdtv"
        Me.Billdtv.RowHeadersWidth = 51
        Me.Billdtv.RowTemplate.Height = 24
        Me.Billdtv.Size = New System.Drawing.Size(931, 219)
        Me.Billdtv.TabIndex = 1
        '
        'Savebtn
        '
        Me.Savebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Savebtn.Location = New System.Drawing.Point(487, 272)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(98, 38)
        Me.Savebtn.TabIndex = 2
        Me.Savebtn.Text = "Save"
        Me.Savebtn.UseVisualStyleBackColor = True
        '
        'Updatebtn
        '
        Me.Updatebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Updatebtn.Location = New System.Drawing.Point(671, 272)
        Me.Updatebtn.Name = "Updatebtn"
        Me.Updatebtn.Size = New System.Drawing.Size(98, 38)
        Me.Updatebtn.TabIndex = 2
        Me.Updatebtn.Text = "Edit"
        Me.Updatebtn.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(855, 272)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 38)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(400, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Patient Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(662, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Treatment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(927, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cost"
        '
        'Patnamecb
        '
        Me.Patnamecb.FormattingEnabled = True
        Me.Patnamecb.Location = New System.Drawing.Point(403, 161)
        Me.Patnamecb.Name = "Patnamecb"
        Me.Patnamecb.Size = New System.Drawing.Size(121, 24)
        Me.Patnamecb.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(665, 163)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 22)
        Me.TextBox1.TabIndex = 6
        '
        'searchtb
        '
        Me.searchtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchtb.Location = New System.Drawing.Point(665, 342)
        Me.searchtb.Multiline = True
        Me.searchtb.Name = "searchtb"
        Me.searchtb.Size = New System.Drawing.Size(161, 31)
        Me.searchtb.TabIndex = 7
        '
        'searchbt
        '
        Me.searchbt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbt.Location = New System.Drawing.Point(832, 342)
        Me.searchbt.Name = "searchbt"
        Me.searchbt.Size = New System.Drawing.Size(118, 36)
        Me.searchbt.TabIndex = 8
        Me.searchbt.Text = "Search"
        Me.searchbt.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(362, 351)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(260, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Enter the name of the patient "
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
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1431, 60)
        Me.Panel1.TabIndex = 24
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(11, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(74, 60)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(91, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 36)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Billing"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(956, 342)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Billing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1431, 754)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.searchbt)
        Me.Controls.Add(Me.searchtb)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Patnamecb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Updatebtn)
        Me.Controls.Add(Me.Savebtn)
        Me.Controls.Add(Me.Billdtv)
        Me.Controls.Add(Me.costtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Billing"
        Me.Text = "Billing"
        CType(Me.Billdtv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents costtb As TextBox
    Friend WithEvents Billdtv As DataGridView
    Friend WithEvents Savebtn As Button
    Friend WithEvents Updatebtn As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Patnamecb As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents searchtb As TextBox
    Friend WithEvents searchbt As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
