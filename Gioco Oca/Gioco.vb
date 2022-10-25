Public Class Gioco

    Dim dado As New Integer
    Dim dadoR As New Random


    Dim casella As New Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dado = dadoR.Next(1, 7)
        System.Threading.Thread.Sleep(3000)
        casella += dado

        dado = 0

        TEST.Text = casella
        TEST2.Text = dado

    End Sub
End Class