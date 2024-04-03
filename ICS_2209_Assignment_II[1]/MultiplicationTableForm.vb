Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class MultiplicationTableForm

    Private Sub GenerateMultiplicationTable()
        TextBox1.Clear()

        TextBox1.AppendText("Multiplication Table" & vbCrLf)
        TextBox1.AppendText("* ")

        For i As Integer = 1 To 7
            TextBox1.AppendText(i.ToString() & " ")
        Next

        For i As Integer = 1 To 7
            TextBox1.AppendText(vbCrLf & i.ToString() & " ")

            For j As Integer = 1 To 7
                TextBox1.AppendText((i * j).ToString() & " ")
            Next
        Next
    End Sub

    Private Sub MultiplicationTableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateMultiplicationTable()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
