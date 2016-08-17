Public Class Form1

    ' Initialize Variables
    Dim firstName As String
    Dim lastName As String
    Dim address As String
    Dim postCode As Integer

    ' Constants
    Dim wBeePrice As Decimal = 0.05
    Dim qBeePrice As Decimal = 15.0
    Dim surcharge As Decimal
    Dim surchargePercentage As Decimal = 0.125
    Dim total As Decimal
    Dim freight As Decimal
    Dim customerID As String


    Private Sub num_WBee_ValueChanged(sender As Object, e As EventArgs) Handles num_WBee.ValueChanged
        tb_WBeeInc.Text = num_WBee.Value * wBeePrice
    End Sub

    Private Sub num_QBee_ValueChanged(sender As Object, e As EventArgs) Handles num_QBee.ValueChanged
        tb_QBeeInc.Text = num_QBee.Value * qBeePrice
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If tb_PostCode.Text <= 999 Then
            freight = 25
        ElseIf tb_PostCode.Text <= 2999 Then
            freight = 15
        ElseIf tb_PostCode.Text <= 3999 Then
            freight = 15
        ElseIf tb_PostCode.Text <= 4999 Then
            freight = 20
        ElseIf tb_PostCode.Text <= 5999 Then
            freight = 15
        ElseIf tb_PostCode.Text <= 6999 Then
            freight = 25
        ElseIf tb_PostCode.Text <= 7999 Then
            freight = 15
        Else
            MsgBox("Not a valid postcode moron")
        End If

        tb_Freight.Text = freight

        total = Convert.ToDecimal(tb_WBeeInc.Text) + Convert.ToDecimal(tb_QBeeInc.Text) + freight
        If num_QBee.Value > 0 Then
            tb_Surcharge.Text = Math.Round(total * surchargePercentage, 2)
            total = (total * surchargePercentage) + total
        End If

        tb_Total.Text = Math.Round(total, 2)

        customerID = (((Guid.NewGuid.ToString).Replace("-", "")).Substring(0, 10)).ToUpper()

        tb_CustomerID.Text = customerID

    End Sub
End Class
