Imports System.Data.SqlClient

Public Class Dashboard
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rud\source\repos\Dental Clinic Final\Dental Clinic Final\dentalclinic.mdf;Integrated Security=True")


    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        countpat()

        countappoint()
        income()

    End Sub
    Private Sub countpat()
        con.Open()
        Dim patno As Integer
        Dim query = "select count (*) As count from Patient"
        Dim cmd As New SqlCommand(query, con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        Do While dr.Read
            patno = dr("count")
        Loop
        patientno.Text = patno
        con.Close()
    End Sub
    Private Sub countappoint()
        con.Open()
        Dim patno As Integer
        Dim query = "select count (*) As count from Appointment"
        Dim cmd As New SqlCommand(query, con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        Do While dr.Read
            patno = dr("count")
        Loop
        appointmentno.Text = patno
        con.Close()
    End Sub
    Private Sub income()
        con.Open()
        Dim patno As Integer
        Dim query = "select sum (BCost) As count from Billing"
        Dim cmd As New SqlCommand(query, con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        Do While dr.Read
            patno = dr("count")
        Loop
        incomelb.Text = patno
        con.Close()
    End Sub
End Class