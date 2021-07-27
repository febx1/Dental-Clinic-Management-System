Public Class userpanel
    Private Sub userpanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel4.Controls.Clear()
        useradd.TopLevel = False
        Panel4.Controls.Add(useradd)
        useradd.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Dashbtn_Click(sender As Object, e As EventArgs) Handles Dashbtn.Click
        Panel4.Controls.Clear()
        useradd.TopLevel = False
        Panel4.Controls.Add(useradd)
        useradd.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel4.Controls.Clear()
        Dashboard.TopLevel = False
        Panel4.Controls.Add(Dashboard)
        Dashboard.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel4.Controls.Clear()
        admindtv.TopLevel = False
        Panel4.Controls.Add(admindtv)
        admindtv.Show()
    End Sub


End Class