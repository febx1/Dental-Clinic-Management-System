Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Patient
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rud\source\repos\Dental Clinic Final\Dental Clinic Final\dentalclinic.mdf;Integrated Security=True")

    Dim username As String
    Public Sub populate()
        con.Open()
        Dim query = "Select * from Patient"
        Dim adapter As New SqlDataAdapter(query, con)
        Dim ds As New DataSet
        adapter.Fill(ds)
        Patientdtv.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Public Sub reset()
        Patnametb.Clear()
        Patphonetb.Clear()
        Pataddresstb.Clear()
        Patagetb.Clear()
        Patgencb.SelectedIndex = -1
    End Sub



    Private Sub Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DentalclinicDataSet.Patient' table. You can move, or remove it, as needed.

        populate()

    End Sub

    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        If Patnametb.Text = "" Or Patphonetb.Text = "" Or Pataddresstb.Text = "" Or Patgencb.SelectedIndex = -1 Then
            MsgBox("Fill all the details", MessageBoxIcon.Warning)
        ElseIf Patphonetb.Text.Length <> 10 Or IsNumeric(Patphonetb.Text) = False Then
            MsgBox("Invalid Phone number", MessageBoxIcon.Warning)
        ElseIf Not Regex.IsMatch(Patnametb.Text, "^[\p{L} \.\-]+$") Then
            MsgBox("Special characters are not allowed", MessageBoxIcon.Warning)
        ElseIf Not Regex.IsMatch(Patagetb.Text, "^[0-9]*$") Then
            MsgBox("Special characters are not allowed age", MessageBoxIcon.Warning)

        ElseIf Patagetb.Text.Length > 3 Or IsNumeric(Patagetb.Text) = False Or Convert.ToInt32(Patagetb.Text) < 0 Then
            MsgBox("Entered age is invalid!", MessageBoxIcon.Warning)
        Else
            username = GenerateUserId()
            Dim flag2 As Boolean = CheckForDuplication(username)
            If flag2 = False Then
                con.Open()
                Dim query = "insert into Patient values('" + Patnametb.Text + "','" + Patphonetb.Text + "','" + Pataddresstb.Text + "','" + Patgencb.SelectedItem.ToString() + "','" + Patagetb.Text + "','" & username & "')"
                Dim cmd As New SqlCommand(query, con)
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox("Patient  alredy exist , Try another phone number", MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                MsgBox("Patient Saved Successfully")
                con.Close()
                populate()
                reset()

            End If


        End If
    End Sub

    Private Function CheckForDuplication(username As String) As Boolean

        Dim query As String = "select PatUsername from Patient"
        Dim flag1 = False
        Dim cmd As New SqlCommand(query, con)
        con.Open()

        Dim dr As SqlDataReader
        Try

            dr = cmd.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Do While dr.Read
            If dr("PatUsername") = username Then
                MsgBox("This user has already registered")
                flag1 = True
            End If
        Loop
        con.Close()

        Return flag1
    End Function

    Private Function GenerateUserId() As String  'Function to create unique username

        Dim name As String = Patnametb.Text.ToLower.Trim()
        name = name.Replace(" ", "")
        Dim phone As String = Patphonetb.Text
        Dim username = name + phone
        Return username

    End Function

    Private Sub Updatebtn_Click(sender As Object, e As EventArgs) Handles Updatebtn.Click
        If Patnametb.Text = "" Or Patphonetb.Text = "" Or Pataddresstb.Text = "" Or Patgencb.SelectedIndex = -1 Then
            MsgBox("Fill all the details", MessageBoxIcon.Warning)
        ElseIf Patphonetb.Text.Length <> 10 Or IsNumeric(Patphonetb.Text) = False Then
            MsgBox("Invalid Phone number", MessageBoxIcon.Warning)

        ElseIf Not Regex.IsMatch(Patnametb.Text, "^[\p{L} \.\-]+$") Then
            MsgBox("Special characters are not allowed", MessageBoxIcon.Warning)
        ElseIf Not Regex.IsMatch(Patagetb.Text, "^[0-9]*$") Then
            MsgBox("Special characters are not allowed age", MessageBoxIcon.Warning)

        ElseIf Patagetb.Text.Length > 2 Or IsNumeric(Patagetb.Text) = False Or Convert.ToInt32(Patagetb.Text) < 0 Then
            MsgBox("Entered age is invalid!", MessageBoxIcon.Warning)
        Else
            con.Open()
            Dim query = "update Patient set PatName= '" & Patnametb.Text & "',PatPhone ='" & Patphonetb.Text & "',PatAddr='" & Pataddresstb.Text & "',PatGen='" & Patgencb.SelectedItem.ToString & "',PatAge='" & Patagetb.Text & "' where PatId=" & key & ""
            Dim cmd As New SqlCommand(query, con)
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)

                Exit Sub
            End Try
            MsgBox("Patient updated Successfully")
            con.Close()
            populate()
            reset()

        End If
    End Sub

    Dim key = 0

    Private Sub Patientdtv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Patientdtv.CellContentClick
        Try
            Dim row As DataGridViewRow = Patientdtv.Rows(e.RowIndex)
            Patnametb.Text = row.Cells(1).Value.ToString
            Patphonetb.Text = row.Cells(2).Value.ToString
            Pataddresstb.Text = row.Cells(3).Value.ToString
            Patgencb.SelectedItem = row.Cells(4).Value.ToString
            Patagetb.Text = row.Cells(5).Value.ToString
            If Patnametb.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Deletebtn_Click(sender As Object, e As EventArgs) Handles Deletebtn.Click
        If key = 0 Then
            MsgBox("Missing information , Selet data from the table to be deleted")
        Else
            con.Open()

            Dim query = "Delete from Appointment where PatId = " & key & ";Delete from Patient where PatId = " & key & ""
            Dim cmd As New SqlCommand(query, con)
            Try


                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            MsgBox("Patient deleted sucessfully")

            con.Close()
            populate()
            reset()

        End If
    End Sub

    Private Sub Exitbtn_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Public Sub filter()
        If searchtb.Text = "" Then
            MsgBox("Enter the patient name to be searched.")
        Else
            con.Open()
            Dim query = "select * from Patient where PatName='" & searchtb.Text & "'"
            Dim adapter As SqlDataAdapter
            adapter = New SqlDataAdapter(query, con)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            Patientdtv.DataSource = ds.Tables(0)
            con.Close()

        End If
    End Sub
    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        filter()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        populate()
        searchtb.Clear()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Patphonetb_TextChanged(sender As Object, e As EventArgs) Handles Patphonetb.TextChanged

    End Sub
End Class