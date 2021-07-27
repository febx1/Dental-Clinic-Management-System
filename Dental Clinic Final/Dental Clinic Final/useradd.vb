Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class useradd
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rud\source\repos\Dental Clinic Final\Dental Clinic Final\dentalclinic.mdf;Integrated Security=True")

    Private Sub addusrbtn_Click(sender As Object, e As EventArgs) Handles addusrbtn.Click
        Dim uname As String = usernametb.Text
        Dim passwrd As String = passdtb.Text
        If usernametb.Text = "" Then
            MsgBox("Enter the username")
        ElseIf passdtb.Text = "" Then
            MsgBox("Enter the password for user")
        ElseIf Not Regex.IsMatch(uname, "^[\p{L} \.\-]+$") Then
            MsgBox("Username should not contain any special characters")
        Else
            con.Open()

            Dim query = "insert into Users values('" + usernametb.Text + "','" + passdtb.Text + "' )"
            Dim cmd As New SqlCommand(query, con)
            Try


                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            MsgBox("User added successfully")
            con.Close()
            filldv()
        End If
    End Sub

    Private Sub useradd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filldv()
    End Sub


    Public Sub filldv()
        con.Open()
        Dim query = "select * from Users"
        Dim adapter As New SqlDataAdapter(query, con)
        Dim ds As New DataSet
        adapter.Fill(ds)
        userdv.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub Updatebtn_Click(sender As Object, e As EventArgs) Handles Updatebtn.Click
        con.Open()
        Dim query = "update Users set username='" & usernametb.Text & "',password='" & passdtb.Text & "' where userid=" & key & " "
        Dim cmd As New SqlCommand(query, con)
        Try


            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        MsgBox("user updated sucessfully")


        con.Close()
        filldv()

    End Sub

    Dim key = 0

    Private Sub userdv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles userdv.CellContentClick
        Try
            Dim row As DataGridViewRow = userdv.Rows(e.RowIndex)
            usernametb.Text = row.Cells(1).Value.ToString
            passdtb.Text = row.Cells(2).Value.ToString

            If usernametb.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If
        Catch
        End Try

    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        con.Open()
        Dim query = "delete from Users where userid=" & key & " "
        Dim cmd As New SqlCommand(query, con)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MsgBox("user deleted")
        con.Close()
        filldv()

    End Sub
End Class