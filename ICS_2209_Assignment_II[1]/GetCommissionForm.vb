Public Class GetCommissionForm
    Const weeklyBasePay As Double = 2500
    Const quota As Double = 1000
    Const commissionRate As Double = 0.15

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim weeklySale As Double = 0
        Dim weeklySalary As Double
        Dim commission As Boolean = False
        If DataGridView1.RowCount > 10 Then
            MessageBox.Show("Can only add 10 Sales Person", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        weeklySale += If(Double.TryParse(TextBox3.Text, Nothing), Double.Parse(TextBox3.Text), 0)
        weeklySale += If(Double.TryParse(TextBox4.Text, Nothing), Double.Parse(TextBox4.Text), 0)
        weeklySale += If(Double.TryParse(TextBox5.Text, Nothing), Double.Parse(TextBox5.Text), 0)
        weeklySale += If(Double.TryParse(TextBox6.Text, Nothing), Double.Parse(TextBox6.Text), 0)
        weeklySale += If(Double.TryParse(TextBox7.Text, Nothing), Double.Parse(TextBox7.Text), 0)
        weeklySale += If(Double.TryParse(TextBox8.Text, Nothing), Double.Parse(TextBox8.Text), 0)
        weeklySale += If(Double.TryParse(TextBox9.Text, Nothing), Double.Parse(TextBox9.Text), 0)

        weeklySalary = weeklyBasePay

        If weeklySale > quota Then
            commission = True
            weeklySalary += commissionRate * weeklySale
        End If


        DataGridView1.Rows.Add(DataGridView1.RowCount, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, weeklySale.ToString(), commission, weeklySalary)
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub GetCommissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
