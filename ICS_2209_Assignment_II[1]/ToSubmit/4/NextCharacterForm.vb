Public Class NextCharacterForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inputChar As String = TextBox1.Text()

        If Not String.IsNullOrEmpty(inputChar) Then
            MessageBox.Show($"The character following '{inputChar}' is '{GetNextCharacter(inputChar)}'", "Next Character")
        End If
    End Sub

    Private Function GetNextCharacter(currentChar As Char) As Char
        Dim nextCharCode As Integer = Asc(currentChar) + 1

        Return ChrW(nextCharCode)
    End Function
End Class
