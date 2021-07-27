<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admindtv
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
        Me.components = New System.ComponentModel.Container()
        Me.Patientdtv = New System.Windows.Forms.DataGridView()
        Me.billingdt = New System.Windows.Forms.DataGridView()
        Me.Appointmentdtv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.patientdt = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DentalclinicDataSet = New Dental_Clinic_Final.dentalclinicDataSet()
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientTableAdapter = New Dental_Clinic_Final.dentalclinicDataSetTableAdapters.PatientTableAdapter()
        Me.PatIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatAddrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatGenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatAgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatUsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DentalclinicDataSet1 = New Dental_Clinic_Final.dentalclinicDataSet1()
        Me.BillingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillingTableAdapter = New Dental_Clinic_Final.dentalclinicDataSet1TableAdapters.BillingTableAdapter()
        Me.BIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BPatnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTreatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatIdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Patientdtv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.billingdt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Appointmentdtv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.patientdt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DentalclinicDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DentalclinicDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Patientdtv
        '
        Me.Patientdtv.AutoGenerateColumns = False
        Me.Patientdtv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Patientdtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Patientdtv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatIdDataGridViewTextBoxColumn, Me.PatNameDataGridViewTextBoxColumn, Me.PatPhoneDataGridViewTextBoxColumn, Me.PatAddrDataGridViewTextBoxColumn, Me.PatGenDataGridViewTextBoxColumn, Me.PatAgeDataGridViewTextBoxColumn, Me.PatUsernameDataGridViewTextBoxColumn})
        Me.Patientdtv.DataSource = Me.PatientBindingSource
        Me.Patientdtv.Location = New System.Drawing.Point(129, 66)
        Me.Patientdtv.Name = "Patientdtv"
        Me.Patientdtv.RowHeadersWidth = 51
        Me.Patientdtv.RowTemplate.Height = 24
        Me.Patientdtv.Size = New System.Drawing.Size(928, 150)
        Me.Patientdtv.TabIndex = 0
        '
        'billingdt
        '
        Me.billingdt.AutoGenerateColumns = False
        Me.billingdt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.billingdt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.billingdt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BIdDataGridViewTextBoxColumn, Me.BPatnameDataGridViewTextBoxColumn, Me.BTreatDataGridViewTextBoxColumn, Me.BCostDataGridViewTextBoxColumn, Me.PatIdDataGridViewTextBoxColumn1, Me.PatNameDataGridViewTextBoxColumn1})
        Me.billingdt.DataSource = Me.BillingBindingSource
        Me.billingdt.Location = New System.Drawing.Point(129, 445)
        Me.billingdt.Name = "billingdt"
        Me.billingdt.RowHeadersWidth = 51
        Me.billingdt.RowTemplate.Height = 24
        Me.billingdt.Size = New System.Drawing.Size(928, 150)
        Me.billingdt.TabIndex = 0
        '
        'Appointmentdtv
        '
        Me.Appointmentdtv.AllowUserToOrderColumns = True
        Me.Appointmentdtv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Appointmentdtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Appointmentdtv.Location = New System.Drawing.Point(129, 258)
        Me.Appointmentdtv.Name = "Appointmentdtv"
        Me.Appointmentdtv.RowHeadersWidth = 51
        Me.Appointmentdtv.RowTemplate.Height = 24
        Me.Appointmentdtv.Size = New System.Drawing.Size(928, 150)
        Me.Appointmentdtv.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Patient List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(129, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Appointmet list"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(129, 425)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Billing List"
        '
        'patientdt
        '
        Me.patientdt.AutoGenerateColumns = False
        Me.patientdt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.patientdt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.patientdt.Location = New System.Drawing.Point(129, 66)
        Me.patientdt.Name = "patientdt"
        Me.patientdt.RowHeadersWidth = 51
        Me.patientdt.RowTemplate.Height = 24
        Me.patientdt.Size = New System.Drawing.Size(928, 150)
        Me.patientdt.TabIndex = 0
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(129, 445)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(928, 150)
        Me.DataGridView3.TabIndex = 0
        '
        'DentalclinicDataSet
        '
        Me.DentalclinicDataSet.DataSetName = "dentalclinicDataSet"
        Me.DentalclinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientBindingSource
        '
        Me.PatientBindingSource.DataMember = "Patient"
        Me.PatientBindingSource.DataSource = Me.DentalclinicDataSet
        '
        'PatientTableAdapter
        '
        Me.PatientTableAdapter.ClearBeforeFill = True
        '
        'PatIdDataGridViewTextBoxColumn
        '
        Me.PatIdDataGridViewTextBoxColumn.DataPropertyName = "PatId"
        Me.PatIdDataGridViewTextBoxColumn.HeaderText = "PatId"
        Me.PatIdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatIdDataGridViewTextBoxColumn.Name = "PatIdDataGridViewTextBoxColumn"
        Me.PatIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PatNameDataGridViewTextBoxColumn
        '
        Me.PatNameDataGridViewTextBoxColumn.DataPropertyName = "PatName"
        Me.PatNameDataGridViewTextBoxColumn.HeaderText = "PatName"
        Me.PatNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatNameDataGridViewTextBoxColumn.Name = "PatNameDataGridViewTextBoxColumn"
        '
        'PatPhoneDataGridViewTextBoxColumn
        '
        Me.PatPhoneDataGridViewTextBoxColumn.DataPropertyName = "PatPhone"
        Me.PatPhoneDataGridViewTextBoxColumn.HeaderText = "PatPhone"
        Me.PatPhoneDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatPhoneDataGridViewTextBoxColumn.Name = "PatPhoneDataGridViewTextBoxColumn"
        '
        'PatAddrDataGridViewTextBoxColumn
        '
        Me.PatAddrDataGridViewTextBoxColumn.DataPropertyName = "PatAddr"
        Me.PatAddrDataGridViewTextBoxColumn.HeaderText = "PatAddr"
        Me.PatAddrDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatAddrDataGridViewTextBoxColumn.Name = "PatAddrDataGridViewTextBoxColumn"
        '
        'PatGenDataGridViewTextBoxColumn
        '
        Me.PatGenDataGridViewTextBoxColumn.DataPropertyName = "PatGen"
        Me.PatGenDataGridViewTextBoxColumn.HeaderText = "PatGen"
        Me.PatGenDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatGenDataGridViewTextBoxColumn.Name = "PatGenDataGridViewTextBoxColumn"
        '
        'PatAgeDataGridViewTextBoxColumn
        '
        Me.PatAgeDataGridViewTextBoxColumn.DataPropertyName = "PatAge"
        Me.PatAgeDataGridViewTextBoxColumn.HeaderText = "PatAge"
        Me.PatAgeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatAgeDataGridViewTextBoxColumn.Name = "PatAgeDataGridViewTextBoxColumn"
        '
        'PatUsernameDataGridViewTextBoxColumn
        '
        Me.PatUsernameDataGridViewTextBoxColumn.DataPropertyName = "PatUsername"
        Me.PatUsernameDataGridViewTextBoxColumn.HeaderText = "PatUsername"
        Me.PatUsernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatUsernameDataGridViewTextBoxColumn.Name = "PatUsernameDataGridViewTextBoxColumn"
        '
        'DentalclinicDataSet1
        '
        Me.DentalclinicDataSet1.DataSetName = "dentalclinicDataSet1"
        Me.DentalclinicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BillingBindingSource
        '
        Me.BillingBindingSource.DataMember = "Billing"
        Me.BillingBindingSource.DataSource = Me.DentalclinicDataSet1
        '
        'BillingTableAdapter
        '
        Me.BillingTableAdapter.ClearBeforeFill = True
        '
        'BIdDataGridViewTextBoxColumn
        '
        Me.BIdDataGridViewTextBoxColumn.DataPropertyName = "BId"
        Me.BIdDataGridViewTextBoxColumn.HeaderText = "BId"
        Me.BIdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BIdDataGridViewTextBoxColumn.Name = "BIdDataGridViewTextBoxColumn"
        Me.BIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BPatnameDataGridViewTextBoxColumn
        '
        Me.BPatnameDataGridViewTextBoxColumn.DataPropertyName = "BPatname"
        Me.BPatnameDataGridViewTextBoxColumn.HeaderText = "BPatname"
        Me.BPatnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BPatnameDataGridViewTextBoxColumn.Name = "BPatnameDataGridViewTextBoxColumn"
        '
        'BTreatDataGridViewTextBoxColumn
        '
        Me.BTreatDataGridViewTextBoxColumn.DataPropertyName = "BTreat"
        Me.BTreatDataGridViewTextBoxColumn.HeaderText = "BTreat"
        Me.BTreatDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BTreatDataGridViewTextBoxColumn.Name = "BTreatDataGridViewTextBoxColumn"
        '
        'BCostDataGridViewTextBoxColumn
        '
        Me.BCostDataGridViewTextBoxColumn.DataPropertyName = "BCost"
        Me.BCostDataGridViewTextBoxColumn.HeaderText = "BCost"
        Me.BCostDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BCostDataGridViewTextBoxColumn.Name = "BCostDataGridViewTextBoxColumn"
        '
        'PatIdDataGridViewTextBoxColumn1
        '
        Me.PatIdDataGridViewTextBoxColumn1.DataPropertyName = "PatId"
        Me.PatIdDataGridViewTextBoxColumn1.HeaderText = "PatId"
        Me.PatIdDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.PatIdDataGridViewTextBoxColumn1.Name = "PatIdDataGridViewTextBoxColumn1"
        '
        'PatNameDataGridViewTextBoxColumn1
        '
        Me.PatNameDataGridViewTextBoxColumn1.DataPropertyName = "PatName"
        Me.PatNameDataGridViewTextBoxColumn1.HeaderText = "PatName"
        Me.PatNameDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.PatNameDataGridViewTextBoxColumn1.Name = "PatNameDataGridViewTextBoxColumn1"
        '
        'admindtv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1365, 703)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Appointmentdtv)
        Me.Controls.Add(Me.billingdt)
        Me.Controls.Add(Me.Patientdtv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "admindtv"
        CType(Me.Patientdtv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.billingdt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Appointmentdtv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.patientdt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DentalclinicDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DentalclinicDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Patientdtv As DataGridView
    Friend WithEvents billingdt As DataGridView
    Friend WithEvents Appointmentdtv As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents patientdt As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DentalclinicDataSet As dentalclinicDataSet
    Friend WithEvents PatientBindingSource As BindingSource
    Friend WithEvents PatientTableAdapter As dentalclinicDataSetTableAdapters.PatientTableAdapter
    Friend WithEvents PatIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatPhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatAddrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatGenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatAgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatUsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DentalclinicDataSet1 As dentalclinicDataSet1
    Friend WithEvents BillingBindingSource As BindingSource
    Friend WithEvents BillingTableAdapter As dentalclinicDataSet1TableAdapters.BillingTableAdapter
    Friend WithEvents BIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BPatnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BTreatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatIdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PatNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
