<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Treatment
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Treatment))
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.Updatebtn = New System.Windows.Forms.Button()
        Me.Deletebtn = New System.Windows.Forms.Button()
        Me.Treatdtv = New System.Windows.Forms.DataGridView()
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DentalclinicDataSet = New Dental_Clinic_Final.dentalclinicDataSet()
        Me.PatientTableAdapter = New Dental_Clinic_Final.dentalclinicDataSetTableAdapters.PatientTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Treatmenttb = New System.Windows.Forms.TextBox()
        Me.Costtb = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.Treatdtv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DentalclinicDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Savebtn
        '
        Me.Savebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Savebtn.Location = New System.Drawing.Point(440, 316)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(123, 36)
        Me.Savebtn.TabIndex = 0
        Me.Savebtn.Text = "Save"
        Me.Savebtn.UseVisualStyleBackColor = True
        '
        'Updatebtn
        '
        Me.Updatebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Updatebtn.Location = New System.Drawing.Point(684, 316)
        Me.Updatebtn.Name = "Updatebtn"
        Me.Updatebtn.Size = New System.Drawing.Size(123, 36)
        Me.Updatebtn.TabIndex = 0
        Me.Updatebtn.Text = "Update"
        Me.Updatebtn.UseVisualStyleBackColor = True
        '
        'Deletebtn
        '
        Me.Deletebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deletebtn.Location = New System.Drawing.Point(928, 316)
        Me.Deletebtn.Name = "Deletebtn"
        Me.Deletebtn.Size = New System.Drawing.Size(123, 36)
        Me.Deletebtn.TabIndex = 0
        Me.Deletebtn.Text = "Delete"
        Me.Deletebtn.UseVisualStyleBackColor = True
        '
        'Treatdtv
        '
        Me.Treatdtv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Treatdtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Treatdtv.Location = New System.Drawing.Point(257, 427)
        Me.Treatdtv.Name = "Treatdtv"
        Me.Treatdtv.RowHeadersWidth = 51
        Me.Treatdtv.RowTemplate.Height = 24
        Me.Treatdtv.Size = New System.Drawing.Size(931, 219)
        Me.Treatdtv.TabIndex = 1
        '
        'PatientBindingSource
        '
        Me.PatientBindingSource.DataMember = "Patient"
        Me.PatientBindingSource.DataSource = Me.DentalclinicDataSet
        '
        'DentalclinicDataSet
        '
        Me.DentalclinicDataSet.DataSetName = "dentalclinicDataSet"
        Me.DentalclinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientTableAdapter
        '
        Me.PatientTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(523, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Treatment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(768, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cost"
        '
        'Treatmenttb
        '
        Me.Treatmenttb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Treatmenttb.Location = New System.Drawing.Point(526, 195)
        Me.Treatmenttb.Name = "Treatmenttb"
        Me.Treatmenttb.Size = New System.Drawing.Size(146, 27)
        Me.Treatmenttb.TabIndex = 3
        '
        'Costtb
        '
        Me.Costtb.Location = New System.Drawing.Point(756, 195)
        Me.Costtb.Name = "Costtb"
        Me.Costtb.Size = New System.Drawing.Size(152, 22)
        Me.Costtb.TabIndex = 3
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
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(74, 60)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(80, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 36)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Treatment"
        '
        'Treatment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1431, 754)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Costtb)
        Me.Controls.Add(Me.Treatmenttb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Treatdtv)
        Me.Controls.Add(Me.Deletebtn)
        Me.Controls.Add(Me.Updatebtn)
        Me.Controls.Add(Me.Savebtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Treatment"
        Me.Text = "Treatment"
        CType(Me.Treatdtv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DentalclinicDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Savebtn As Button
    Friend WithEvents Updatebtn As Button
    Friend WithEvents Deletebtn As Button
    Friend WithEvents Treatdtv As DataGridView
    Friend WithEvents DentalclinicDataSet As dentalclinicDataSet
    Friend WithEvents PatientBindingSource As BindingSource
    Friend WithEvents PatientTableAdapter As dentalclinicDataSetTableAdapters.PatientTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Treatmenttb As TextBox
    Friend WithEvents Costtb As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
