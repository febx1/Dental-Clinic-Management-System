
Imports System.Data.SqlClient

Public Class Treatment

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rud\source\repos\Dental Clinic Final\Dental Clinic Final\dentalclinic.mdf;Integrated Security=True")

    Public Sub populate()
        con.Open()
        Dim query = "select * from Treatment"
        Dim adapter As New SqlDataAdapter(query, con)
        Dim ds As New DataSet
        adapter.Fill(ds)
        Treatdtv.DataSource = ds.Tables(0)
        con.Close()

    End Sub

    Public Sub reset()
        Treatmenttb.Clear()
        Costtb.Clear()

    End Sub
    Private Sub Treatment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()

    End Sub

    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        If Treatmenttb.Text = "" Or Costtb.Text = "" Then
            MsgBox(" Information missing")
        ElseIf IsNumeric(Costtb.Text) = False Then
            MsgBox("Entered cost invalid")
        Else
            con.Open()

            Dim query = "insert into Treatment values('" + Treatmenttb.Text + "','" + Costtb.Text + "')"
            Dim cmd As New SqlCommand(query, con)
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            MsgBox("Treatment added successfully")
                con.Close()
            populate()
            reset()


        End If

    End Sub

    Private Sub Updatebtn_Click(sender As Object, e As EventArgs) Handles Updatebtn.Click
        If Treatmenttb.Text = "" Or Costtb.Text = "" Then
            MsgBox(" Information missing")
        ElseIf IsNumeric(Costtb.Text) = False Then
            MsgBox("Entered cost invalid")
        ElseIf key = 0 Then
            MsgBox("No row selected.Select from the table and update.")
        Else
            con.Open()

            Dim query = "update Treatment set Treatment= '" & Treatmenttb.Text & "' , Trcost= '" & Costtb.Text & "' where TrId = " & key & " "
            Dim cmd As New SqlCommand(query, con)
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            MsgBox("Treatment updated successfully")
                con.Close()
            populate()
            reset()


        End If
    End Sub
    Dim key = 0
    Private Sub Treatdtv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Treatdtv.CellContentClick
        Try


            Dim row As DataGridViewRow = Treatdtv.Rows(e.RowIndex)
            Treatmenttb.Text = row.Cells(1).Value.ToString
            Costtb.Text = row.Cells(2).Value.ToString
            If Treatmenttb.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Deletebtn_Click(sender As Object, e As EventArgs) Handles Deletebtn.Click
        con.Open()
        If key = 0 Then
            MsgBox("Select the Treatment to be deleted from the table")
        Else
            Dim query = "delete from Treatment where TrId = " & key & ""
            Dim cmd As New SqlCommand(query, con)
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            MsgBox("Treatment updated successfully")
                con.Close()
            populate()
            reset()
        End If



    End Sub
End Class