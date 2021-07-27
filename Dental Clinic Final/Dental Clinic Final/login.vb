Imports System.Data.SqlClient

Public Class login
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rud\source\repos\Dental Clinic Final\Dental Clinic Final\dentalclinic.mdf;Integrated Security=True")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        Dim flag As Boolean = False

        Dim query = "select * from Users"

        Dim cmd As New SqlCommand(query, con)
        Dim dr As SqlDataReader

        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            MessageBox.Show("            Login successfull              ")
            userpanel.Show()
            Me.Hide()

            clear()
            con.Close()
            Exit Sub
        Else
            dr = cmd.ExecuteReader
            Do While dr.Read

                If TextBox1.Text = dr("username") And TextBox2.Text = dr("password") Then

                    flag = True



                End If
            Loop
            If flag = True Then
                MessageBox.Show("            Login successfull              ")

                Me.Hide()

                Dim a As New main
                a.Show()
                Me.Hide()

                clear()
                con.Close()

            Else
                MessageBox.Show("          Check the credintials            ")
            End If


        End If
        con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox2.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Public Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
