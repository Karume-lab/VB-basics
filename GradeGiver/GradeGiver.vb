Imports System.Net.NetworkInformation

Public Class GradeGiver
    Private Sub GradeGiver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listViewWidth As Integer = 2000
        Dim subjectNameColumnWidth As Integer = CInt(listViewWidth * 0.7)
        Dim marksColumnWidth As Integer = CInt(listViewWidth * 0.3)

        ListView1.Columns.Add("Subject Name", subjectNameColumnWidth, HorizontalAlignment.Left)
        ListView1.Columns.Add("Marks", marksColumnWidth, HorizontalAlignment.Left)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim totalMarks As Double = 0
        Dim itemCount As Integer = ListView1.Items.Count
        Dim regNo As String = TextBox1.Text
        Dim firstName As String = TextBox4.Text
        Dim lastName As String = TextBox5.Text
        Dim stream As String = TextBox6.Text

        If itemCount <> 4 Then
            MessageBox.Show("Add four subjects.", "Four subjects", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        For Each item As ListViewItem In ListView1.Items
            totalMarks += CDbl(item.SubItems(1).Text)
        Next

        Dim averageMarks As Double = totalMarks / itemCount

        Dim grade As String
        If averageMarks >= 75 Then
            grade = "A"
        ElseIf averageMarks >= 65 Then
            grade = "B"
        ElseIf averageMarks >= 50 Then
            grade = "C"
        Else
            grade = "Fail"
        End If

        MessageBox.Show($"Student Details:" & vbCrLf &
                    $"Registration Number: {regNo}" & vbCrLf &
                    $"First Name: {firstName}" & vbCrLf &
                    $"Last Name: {lastName}" & vbCrLf &
                    $"Stream: {stream}" & vbCrLf &
                    $"Average Marks: {averageMarks:F2}" & vbCrLf &
                    $"Grade: {grade}", "Grade Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        ListView1.Items.Clear()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub




    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim regNo As String = TextBox1.Text()
        Dim firstName As String = TextBox4.Text()
        Dim lastName As String = TextBox5.Text()
        Dim stream As String = TextBox6.Text()

        If regNo = "" Or firstName = "" Or lastName = "" Or stream = "" Then
            MessageBox.Show("Kindly fill the student's details first.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox2.Clear()
            Return
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim regNo As String = TextBox1.Text()
        Dim firstName As String = TextBox4.Text()
        Dim lastName As String = TextBox5.Text()
        Dim stream As String = TextBox6.Text()
        If regNo = "" Or firstName = "" Or lastName = "" Or stream = "" Then
            MessageBox.Show("Kindly fill the student's details first.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox2.Clear()
            Return
        End If

        Dim marksStr As String = TextBox3.Text.Trim()

        If marksStr <> "" Then
            Dim marks As Integer
            If Integer.TryParse(marksStr, marks) Then
                If marks >= 1 AndAlso marks <= 100 Then
                Else
                    MessageBox.Show("Marks can only range between 1 and 100.")
                    TextBox3.Clear()
                End If
            Else
                TextBox3.Clear()
            End If
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim subjectName As String = TextBox2.Text.Trim()
        Dim marks As String = TextBox3.Text.Trim()
        Dim flag As Boolean = False

        If subjectName = "" Or marks = "" Then
            flag = True
        End If

        If ListView1.Items.Count < 4 AndAlso Not flag Then
            Dim newItem As New ListViewItem(subjectName)
            newItem.SubItems.Add(marks)

            ListView1.Items.Add(newItem)
        ElseIf flag Then
            MessageBox.Show("Both fields are required.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Maximum limit of four subjects reached.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub



    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged_2(sender As Object, e As EventArgs)Handles ListView1.SelectedIndexChanged

    End Sub
End Class
