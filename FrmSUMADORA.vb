Public Class FrmSUMADORA
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim n1 As Integer
        Dim n2 As Integer
        Dim suma As Integer

        n1 = TextBox1.Text()
        n2 = TextBox2.Text()

        suma = n1 + n2

        TextBox3.Text = suma


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim n1 As Integer
        Dim n2 As Integer
        Dim resta As Integer

        n1 = TextBox1.Text()
        n2 = TextBox2.Text()

        resta = n1 - n2

        TextBox3.Text = resta
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim n1 As Integer
        Dim n2 As Integer
        Dim Mult As Integer

        n1 = TextBox1.Text()
        n2 = TextBox2.Text()

        Mult = n1 * n2

        TextBox3.Text = Mult
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim n1 As Integer
        Dim n2 As Integer
        Dim dividir As Integer

        n1 = TextBox1.Text()
        n2 = TextBox2.Text()

        dividir = n1 / n2

        TextBox3.Text = dividir
    End Sub
End Class