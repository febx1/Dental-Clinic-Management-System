<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class useradd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(useradd))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addusrbtn = New System.Windows.Forms.Button()
        Me.usernametb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.passdtb = New System.Windows.Forms.TextBox()
        Me.userdv = New System.Windows.Forms.DataGridView()
        Me.Updatebtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.userdv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(583, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Name"
        '
        'addusrbtn
        '
        Me.addusrbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addusrbtn.Location = New System.Drawing.Point(509, 282)
        Me.addusrbtn.Name = "addusrbtn"
        Me.addusrbtn.Size = New System.Drawing.Size(104, 33)
        Me.addusrbtn.TabIndex = 1
        Me.addusrbtn.Text = "Add User"
        Me.addusrbtn.UseVisualStyleBackColor = True
        '
        'usernametb
        '
        Me.usernametb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametb.Location = New System.Drawing.Point(705, 149)
        Me.usernametb.Name = "usernametb"
        Me.usernametb.Size = New System.Drawing.Size(126, 27)
        Me.usernametb.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(583, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Password"
        '
        'passdtb
        '
        Me.passdtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passdtb.Location = New System.Drawing.Point(705, 210)
        Me.passdtb.Name = "passdtb"
        Me.passdtb.Size = New System.Drawing.Size(126, 27)
        Me.passdtb.TabIndex = 2
        '
        'userdv
        '
        Me.userdv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.userdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.userdv.Location = New System.Drawing.Point(335, 337)
        Me.userdv.Name = "userdv"
        Me.userdv.RowHeadersWidth = 51
        Me.userdv.RowTemplate.Height = 24
        Me.userdv.Size = New System.Drawing.Size(719, 238)
        Me.userdv.TabIndex = 3
        '
        'Updatebtn
        '
        Me.Updatebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Updatebtn.Location = New System.Drawing.Point(667, 282)
        Me.Updatebtn.Name = "Updatebtn"
        Me.Updatebtn.Size = New System.Drawing.Size(104, 33)
        Me.Updatebtn.TabIndex = 4
        Me.Updatebtn.Text = "Update"
        Me.Updatebtn.UseVisualStyleBackColor = True
        '
        'deletebtn
        '
        Me.deletebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletebtn.Location = New System.Drawing.Point(825, 282)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(104, 33)
        Me.deletebtn.TabIndex = 5
        Me.deletebtn.Text = "Delete"
        Me.deletebtn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1413, 10)
        Me.Panel2.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumVioletRed
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1413, 60)
        Me.Panel1.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(78, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 36)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Add User"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(72, 60)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'useradd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1413, 707)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.Updatebtn)
        Me.Controls.Add(Me.userdv)
        Me.Controls.Add(Me.passdtb)
        Me.Controls.Add(Me.usernametb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.addusrbtn)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "useradd"
        Me.Text = "useradd"
        CType(Me.userdv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents addusrbtn As Button
    Friend WithEvents usernametb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents passdtb As TextBox
    Friend WithEvents userdv As DataGridView
    Friend WithEvents Updatebtn As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
