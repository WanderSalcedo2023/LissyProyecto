Public Class FrmMENU
    Private Sub SalirDelSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirDelSistemaToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub HerramientasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HerramientasToolStripMenuItem.Click

    End Sub

    Private Sub SumadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumadoraToolStripMenuItem.Click

        Dim Sumadora As New FrmSUMADORA
        Sumadora.Show()

    End Sub

    Private Sub CasaDeCambioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CasaDeCambioToolStripMenuItem.Click

    End Sub

    Private Sub MantenimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoToolStripMenuItem.Click

    End Sub

    Private Sub CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CToolStripMenuItem.Click

    End Sub

    Private Sub AgregarEstudianteToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AgregarLibrosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ConsultarEstudiantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarEstudiantesToolStripMenuItem.Click
        Dim Estudiante As New FrmGuardar
        Estudiante.Show()


    End Sub

    Private Sub ConsultarUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ConsultarLibrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarLibrosToolStripMenuItem.Click
        Dim Empleados As New FrmEmpleados
        Empleados.Show()
    End Sub

    Private Sub NominaSemanalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NominaSemanalToolStripMenuItem.Click
        Dim Nomina As New FrmNOMINA
        Nomina.Show()
    End Sub
End Class