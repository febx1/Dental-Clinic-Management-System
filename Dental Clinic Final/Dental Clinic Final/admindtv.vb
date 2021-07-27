Imports System.Data.SqlClient

Public Class admindtv
    Private Sub admindtv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DentalclinicDataSet1.Billing' table. You can move, or remove it, as needed.
        Me.BillingTableAdapter.Fill(Me.DentalclinicDataSet1.Billing)
        'TODO: This line of code loads data into the 'DentalclinicDataSet.Patient' table. You can move, or remove it, as needed.
        Me.PatientTableAdapter.Fill(Me.DentalclinicDataSet.Patient)
        'TODO: This line of code loads data into the 'DentalclinicDataSet.Patient' table. You can move, or remove it, as needed.
        Me.PatientTableAdapter.Fill(Me.DentalclinicDataSet.Patient)

        populate()

    End Sub
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rud\source\repos\Dental Clinic Final\Dental Clinic Final\dentalclinic.mdf;Integrated Security=True")


    Public Sub populate()
        con.Open()
        Dim query = "Select * from Appointment"
        Dim adapter As New SqlDataAdapter(query, con)
        Dim ds As New DataSet
        adapter.Fill(ds)
        Appointmentdtv.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Appointmentdtv.CellContentClick

    End Sub
End Class