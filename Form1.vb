Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()




    End Sub

    Dim N As Integer = 0

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim FrmLOGIN As New FrmLOGIN
        N = N + 10
        ProgressBar1.Value = N
        Label2.Text = N.ToString
        If N = 100 Then
            Timer1.Stop()
            Me.Hide()
            FrmLOGIN.Show()
        End If



    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
