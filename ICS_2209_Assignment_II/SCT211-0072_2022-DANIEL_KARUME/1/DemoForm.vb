Imports System.Windows.Forms
Public Class DemoForm
    Private Sub DemoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResizeForm()
    End Sub


    Private Sub ResizeForm()
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height

        Me.Size = New Size(screenWidth * 3 \ 4, screenHeight \ 2)
    End Sub


End Class
