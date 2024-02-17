Public Class WelcomeForm
    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Red
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Object Demonstrations")
    End Sub

    Private Sub WelcomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
