Public Class Form1
    Private Sub botcalculo_Click(sender As Object, e As EventArgs) Handles botcalculo.Click
        Dim ent1, ent2, ent3, result1, result As Double
        ent1 = Val(TextB1.Text)
        ent2 = Val(TextB2.Text)
        ent3 = Val(TextB3.Text)
        result1 = (ent1 * (ent2 / 100)) + ent1
        result = result1 / ent3
        Labresult1.Text = result1
        Labper.Text = result
        Labfecha.Text = DateString & " " & TimeOfDay.TimeOfDay.ToString
    End Sub


End Class
