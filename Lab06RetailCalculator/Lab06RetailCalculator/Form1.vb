Public Class Form1
    Private decCost As Decimal
    Private decMarkup As Decimal

    Private Function ValidateInputFields() As Boolean
        If Not Decimal.TryParse(txtCost.Text, decCost) Then
            MessageBox.Show("Wholesale Cost must be numeric")
            Return False
        End If

        If Not Decimal.TryParse(txtMarkup.Text, decMarkup) Then
            MessageBox.Show("Markup percentage must be numeric")
            Return False
        End If

        Return True
    End Function

    Private Function CalculateRetail(ByVal decCost As Decimal,
                                     ByVal decMarkup As Decimal) As Decimal
        Dim decRetailPrice As Decimal

        decRetailPrice = decCost + (decCost * decMarkup)
        Return decRetailPrice

    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decRetailPrice As Decimal

        If ValidateInputFields() Then
            decMarkup = decMarkup / 100
            decRetailPrice = CalculateRetail(decCost, decMarkup)
            lblOutput.Text = decRetailPrice.ToString("c")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
