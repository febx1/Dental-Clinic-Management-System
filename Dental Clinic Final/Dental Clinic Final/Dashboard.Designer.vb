<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.patientno = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.appointmentno = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.incomelb = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'patientno
        '
        Me.patientno.AutoSize = True
        Me.patientno.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientno.Location = New System.Drawing.Point(316, 391)
        Me.patientno.Name = "patientno"
        Me.patientno.Size = New System.Drawing.Size(109, 32)
        Me.patientno.TabIndex = 0
        Me.patientno.Text = "patient"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(197, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total number of patients"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(651, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Appointmnts"
        '
        'appointmentno
        '
        Me.appointmentno.AutoSize = True
        Me.appointmentno.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.appointmentno.Location = New System.Drawing.Point(682, 391)
        Me.appointmentno.Name = "appointmentno"
        Me.appointmentno.Size = New System.Drawing.Size(109, 32)
        Me.appointmentno.TabIndex = 0
        Me.appointmentno.Text = "patient"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(945, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Total Income"
        '
        'incomelb
        '
        Me.incomelb.AutoSize = True
        Me.incomelb.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.incomelb.Location = New System.Drawing.Point(990, 391)
        Me.incomelb.Name = "incomelb"
        Me.incomelb.Size = New System.Drawing.Size(109, 32)
        Me.incomelb.TabIndex = 0
        Me.incomelb.Text = "patient"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1333, 10)
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
        Me.Panel1.Size = New System.Drawing.Size(1333, 60)
        Me.Panel1.TabIndex = 26
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 0)
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
        Me.Label6.Location = New System.Drawing.Point(92, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 36)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Report"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 754)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.incomelb)
        Me.Controls.Add(Me.patientno)
        Me.Controls.Add(Me.appointmentno)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents patientno As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents appointmentno As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents incomelb As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
