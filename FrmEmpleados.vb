Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmEmpleados
    Public Sub LLenarDataGrid()
        Dim conn As New SqlClient.SqlConnection("Data Source=DESKTOP-J0CF9U2\SQLEXPRESS;Initial Catalog=Adams_Biblioteca;Integrated Security=True")

        Dim ConsultaDatos As String = "Select * From Estudiante"
        Dim Adapter As New SqlDataAdapter(ConsultaDatos, conn)
        Dim dt As New DataTable
        Adapter.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub
    Private Sub FrmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim conn As New SqlClient.SqlConnection("Data Source=DESKTOP-J0CF9U2\SQLEXPRESS;Initial Catalog=Adams_Biblioteca;Integrated Security=True")


        Try
            conn.Open()
            Dim cmd As New SqlCommand("INSERT INTO Empleados (Cedula,Nombres,Apellidos,Direccion,Telefono,Email,Cargo) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "', '" & TextBox7.Text & "')", conn)
            cmd.ExecuteReader()

        Catch Exoledb As Exception
        Finally
            MessageBox.Show("GUARDADO CON EXITO")
            LLenarDataGrid()

            conn.Close()
        End Try
    End Sub
End Class