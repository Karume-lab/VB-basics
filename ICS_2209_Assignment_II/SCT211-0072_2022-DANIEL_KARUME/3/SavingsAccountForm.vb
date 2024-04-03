Public Class SavingsAccountForm

    Private Sub CalculateAndDisplayAmounts()
        ListBox1.Items.Clear()
        Dim initialAmount As Decimal = 1000000
        Dim interestRate As Decimal = 0.05
        Dim numberOfYears As Integer = 10
        For year As Integer = 1 To numberOfYears
            Dim amount As Decimal = initialAmount * (1 + interestRate) ^ year

            ListBox1.Items.Add($"Year {year}: {amount:C}")
        Next
    End Sub

    Private Sub SavingsAccountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CalculateAndDisplayAmounts()
    End Sub

End Class
