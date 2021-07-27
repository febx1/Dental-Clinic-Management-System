Public Class main
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel4.Controls.Clear()
        Patient.TopLevel = False
        Panel4.Controls.Add(Patient)
        Patient.Show()

    End Sub

    Private Sub Dashbtn_Click(sender As Object, e As EventArgs) Handles Dashbtn.Click
        Panel4.Controls.Clear()
        Dashboard.TopLevel = False
        Panel4.Controls.Add(Dashboard)
        Dashboard.Show()

    End Sub

    Private Sub appointbtn_Click(sender As Object, e As EventArgs) Handles appointbtn.Click
        Panel4.Controls.Clear()
        Appointment.TopLevel = False
        Panel4.Controls.Add(Appointment)
        Appointment.Show()
    End Sub

    Private Sub billingbtn_Click(sender As Object, e As EventArgs) Handles billingbtn.Click
        Panel4.Controls.Clear()
        Billing.TopLevel = False
        Panel4.Controls.Add(Billing)
        Billing.Show()

    End Sub

    Private Sub treatmentbtn_Click(sender As Object, e As EventArgs) Handles treatmentbtn.Click
        Panel4.Controls.Clear()
        Treatment.TopLevel = False
        Panel4.Controls.Add(Treatment)
        Treatment.Show()

    End Sub

    Private Sub patientbtn_Click(sender As Object, e As EventArgs) Handles patientbtn.Click
        Panel4.Controls.Clear()
        Patient.TopLevel = False
        Panel4.Controls.Add(Patient)
        Patient.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class