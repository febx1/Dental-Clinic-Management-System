
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Appointment
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rud\source\repos\Dental Clinic Final\Dental Clinic Final\dentalclinic.mdf;Integrated Security=True")
    Dim patientId As Integer
    Dim flag As Boolean
    Dim flagd As Boolean
    Dim key = 0
    Public Sub populate()
        con.Open()
        Dim query = "select * from Appointment"
        Dim adapter As New SqlDataAdapter(query, con)
        Dim ds As New DataSet
        adapter.Fill(ds)
        Appointdtv.DataSource = ds.Tables(0)
        con.Close()


    End Sub
    Public Sub fillpatients()
        con.Open()
        Dim query = "select distinct(PatName) from Patient"
        Dim cmd As New SqlCommand(query, con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        Do While dr.Read
            PatNamecb.Items.Add(dr("PatName"))

        Loop

        con.Close()

    End Sub
    Public Sub filltreatment()
        con.Open()
        Dim query = "select Treatment from Treatment"
        Dim cmd As New SqlCommand(query, con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        Do While dr.Read
            Treatmentcb.Items.Add(dr("Treatment"))
        Loop
        con.Close()

    End Sub
    Public Sub reset()
        PatNamecb.Text = ""
        Treatmentcb.Text = ""
    End Sub
    Private Sub Appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        fillpatients()
        filltreatment()



    End Sub
    Dim username As String = ""


    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click


        If PatNamecb.SelectedIndex = -1 Then
            MsgBox("Select the patient from drop down list or register if its a new patient")
        ElseIf Treatmentcb.SelectedIndex = -1 Then
            MsgBox("Select a treatment from dropdown list")
        ElseIf Treatmentcb.Text = "" Then
            MsgBox("Select a treatment from dropdown list")
        ElseIf PatNamecb.Text = "" Then
            MsgBox("Select the patient from drop down list or register if its a new patient")
        ElseIf ListBox1.SelectedIndex = -1 Then
            MsgBox("Select Patient username from the list box ")
        ElseIf Datedtp.Value < Date.Now.ToString Then
            MsgBox("You selected a past date,please select a valid date")
        Else
            username = ListBox1.SelectedItem.ToString
            flag = CheckPrimary(username)
            Dim adate = Datedtp.Value.Date
            Dim Time = Timedtp.Text

            flagd = CheckDatetime(adate, Time)
            If flagd = True Then
                MsgBox("Selected time is not available")
            ElseIf flag = False And flagd = False Then
                con.Open()
                Dim query = "insert into Appointment values('" + PatNamecb.Text + "','" + Treatmentcb.Text + "','" + Datedtp.Value.Date + "','" + Timedtp.Text + "'," & patientId & ",'" & username & "')"
                Dim cmd As New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Appointment sucessfully registered")
                ListBox1.Items.Clear()
                con.Close()

                populate()
                reset()


            Else
                MessageBox.Show(" Patient already  appointed")
                reset()
            End If


        End If

    End Sub



    Private Function CheckDatetime(adat As String, tym As String) As Boolean
        con.Open()
        Dim flag2 As Boolean

        Dim Timec As String = ""
        Dim datec As String = ""
        Dim query = "select * from Appointment"
        Dim cmd As New SqlCommand(query, con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        Do While dr.Read

            datec = dr("ApDate").ToString
            Timec = dr("ApTime").ToString

            If Timec = tym Then
                If datec = adat Then
                    flag2 = True
                End If
            End If
        Loop
        If Timec = "" And datec = "" Then
            flag2 = False


        End If
        con.Close()
        Return flag2

    End Function

    Private Function CheckPrimary(username1 As String) As Boolean
        con.Open()
        Dim flag1 As Boolean
        Dim patid As String = ""
        Dim query = "select PatUsername from Appointment"
        Dim cmd As New SqlCommand(query, con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        Do While dr.Read
            patid = dr("PatUsername")
            If patid = username1 Then
                flag1 = True
            End If
        Loop
        If patid = "" Then
            flag1 = False


        End If
        con.Close()
        Return flag1

    End Function






    Private Sub Appointdtv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Appointdtv.CellContentClick
        Try
            Dim row As DataGridViewRow = Appointdtv.Rows(e.RowIndex)
            PatNamecb.Text = row.Cells(1).Value.ToString
            Treatmentcb.Text = row.Cells(2).Value.ToString
            Datedtp.Text = row.Cells(3).Value.ToString
            Timedtp.Text = row.Cells(4).Value.ToString
            If PatNamecb.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Updatebtn_Click(sender As Object, e As EventArgs) Handles Updatebtn.Click
        If PatNamecb.SelectedIndex = -1 Then
            MsgBox("Select the patient from drop down list or register if its a new patient")
        ElseIf Treatmentcb.SelectedIndex = -1 Then
            MsgBox("Select a treatment from dropdown list or else add new treatment on the treatment page")
        ElseIf Treatmentcb.Text = "" Then
            MsgBox("Select a treatment from dropdown list")
        ElseIf PatNamecb.Text = "" Then
            MsgBox("Select the patient from drop down list or register if its a new patient")
        ElseIf Datedtp.Value < Date.Now.ToString Then
            MsgBox("You selected a past date,please select a valid date")
        ElseIf key = 0 Then
            MsgBox("Select the row to be edited")
        Else
            con.Open()
            Dim query = "update Appointment set ApName='" & PatNamecb.Text & "',ApTreat='" & Treatmentcb.Text & "', Apdate='" & Datedtp.Value.Date & "',ApTime='" & Timedtp.Text & "' where ApId=" & key & " "
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Appointment  updated sucessfully ")
            con.Close()
            populate()
            reset()

        End If
    End Sub

    Private Sub Deletebtn_Click(sender As Object, e As EventArgs) Handles Deletebtn.Click
        If key = 0 Then
            MsgBox("Select the row to be deleted  ")

        Else
            con.Open()
            Dim query = "delete from Appointment  where ApId=" & key & " "
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Appointment  deleted  sucessfully ")
            con.Close()
            populate()
            reset()

        End If
    End Sub

    Private Sub PatNamecb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PatNamecb.SelectedIndexChanged

        ListBox1.Items.Clear()
        CreateListView()
    End Sub

    Private Sub CreateListView()
        con.Open()
        Dim query = "select PatUsername from Patient where PatName='" & PatNamecb.SelectedItem.ToString & "'"
        Dim cmd As New SqlCommand(query, con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        Do While dr.Read
            ListBox1.Items.Add(dr("PatUsername"))
        Loop
        con.Close()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        con.Open()
        Dim query = "select PatId from Patient where PatUsername='" & ListBox1.SelectedItem.ToString & "'"
        Dim cmd As New SqlCommand(query, con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        Do While dr.Read
            patientId = dr("PatId")  'THis block of code will take selected patient id from combobox and it will store it to a global variable that is patientId
        Loop
        con.Close()
    End Sub

    Private Sub searchbt_Click(sender As Object, e As EventArgs) Handles searchbt.Click
        filter()

    End Sub
    Public Sub filter()
        If searchtb.Text = "" Then
            MsgBox("Enter the patient name to be searched.")
        Else
            con.Open()
            Dim query = "select * from Appointment where ApName='" & searchtb.Text & "'"
            Dim adapter As SqlDataAdapter
            adapter = New SqlDataAdapter(query, con)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            Appointdtv.DataSource = ds.Tables(0)
            con.Close()

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        populate()
        searchtb.Clear()

    End Sub
End Class