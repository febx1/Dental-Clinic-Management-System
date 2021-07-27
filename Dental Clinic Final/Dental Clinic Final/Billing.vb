Imports System.Data.SqlClient

Public Class Billing

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rud\source\repos\Dental Clinic Final\Dental Clinic Final\dentalclinic.mdf;Integrated Security=True")
    Dim key = 0
    Dim appId As Integer
    Dim patientId As Integer
    Dim treatmenttype As String
    Dim patusername As String
    Dim patname As String = ""

    Public Sub populate()
        con.Open()
        Dim query = "select * from Billing "
        Dim adapter As New SqlDataAdapter(query, con)
        Dim ds As New DataSet
        adapter.Fill(ds)
        Billdtv.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Public Sub fillpatient()
        con.Open()
        Dim query = "select PatUsername from Appointment"
        Dim cmd As New SqlCommand(query, con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        Do While dr.Read
            Patnamecb.Items.Add(dr("PatUsername"))
        Loop

        con.Close()

    End Sub


    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        fillpatient()


    End Sub



    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        If Patnamecb.SelectedIndex = -1 Then
            MsgBox("Select patient from dropdown ")
        
        Else
            con.Open()

            Dim query = "insert into Billing values('" + Patnamecb.SelectedItem + "','" & treatmenttype & "','" + costtb.Text + "'," & patientId & ",'" + patname + "')"
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            con.Close()
            populate()
            DeleteFromApp()
            fillpatient1()
            Patnamecb.Text = ""
            TextBox1.Clear()
            costtb.Clear()

            MessageBox.Show("Billed saved")
        End If
    End Sub

    Private Sub fillpatient1()
        con.Open()
        Patnamecb.Items.Clear()

        Dim query = "select PatUsername from Appointment"
        Dim cmd As New SqlCommand(query, con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        Do While dr.Read
            Patnamecb.Items.Add(dr("PatUsername"))
        Loop
        Patnamecb.SelectedIndex = -1
        Patnamecb.SelectedText = ""
        con.Close()
    End Sub

    Private Sub Updatebtn_Click(sender As Object, e As EventArgs) Handles Updatebtn.Click

        If key = 0 Then
            MsgBox("Select patient from the table ")

        Else
            con.Open()
            Dim query = "update Billing set BPatname= '" & Patnamecb.SelectedItem & "',BTreat='" & treatmenttype & "',BCost=" & costtb.Text & "  where BId='" & key & "'"
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Patient sucessfully")
            con.Close()
            populate()

        End If


    End Sub

    Private Sub Billdtv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Billdtv.CellContentClick
        Try


            Dim row As DataGridViewRow = Billdtv.Rows(e.RowIndex)
            Patnamecb.Text = row.Cells(1).Value.ToString
            TextBox1.Text = row.Cells(2).Value.ToString
            costtb.Text = row.Cells(3).Value.ToString

            If Patnamecb.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If key = 0 Then
            MsgBox("Select the row from the table to be deleted")
        Else
            con.Open()
            Dim query = "delete from BIlling where BId=" & key & ""
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Patnamecb.SelectedIndex = -1
            fillpatient1()
            populate()

        End If


    End Sub

    Private Sub Patnamecb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Patnamecb.SelectedIndexChanged
        con.Open()
        Dim query = "select PatUsername,ApName,ApId,PatId,ApTreat from Appointment where PatUsername ='" + Patnamecb.SelectedItem.ToString + "'"
        Dim cmd As New SqlCommand(query, con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        Do While dr.Read
            appId = dr("ApId")
            patientId = dr("PatId")
            treatmenttype = dr("ApTreat")
            patusername = dr("PatUsername")
            patname = dr("ApName")
        Loop

        con.Close()
        TextBox1.Text = treatmenttype
        RetreiveTreatment()
    End Sub

    Private Sub RetreiveTreatment()
        con.Open()
        Dim query = "select * from Treatment where Treatment ='" & treatmenttype & "'"
        Dim cmd As New SqlCommand(query, con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        Do While dr.Read
            costtb.Text = dr(2).ToString
        Loop

        con.Close()
    End Sub

    Private Sub DeleteFromApp()
        con.Open()
        Dim query1 = "delete from Appointment where ApId=" & appId & ""
        Dim cmd1 As New SqlCommand(query1, con)
        cmd1.ExecuteNonQuery()
        con.Close()
        populate()
    End Sub

    Private Sub searchbt_click(sender As Object, e As EventArgs) Handles searchbt.Click
        filter()

    End Sub
    Public Sub filter()
        If searchtb.Text = "" Then
            MsgBox("enter the patient name to be searched.")
        Else
            con.Open()
            Dim query = "select * from billing  where patname ='" & searchtb.Text & "'"
            Dim adapter As SqlDataAdapter
            adapter = New SqlDataAdapter(query, con)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            Billdtv.DataSource = ds.Tables(0)
            con.Close()

        End If
    End Sub

    Private Sub picturebox1_click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        populate()
        searchtb.Clear()

    End Sub
End Class