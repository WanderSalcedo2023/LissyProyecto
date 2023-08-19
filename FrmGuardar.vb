
''  COPIARESTOOOOOOOO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
''HASTA AQUI

Public Class FrmGuardar

    ''  COPIARESTOOOOOOOO
    Public Sub LLenarDataGrid()
        Dim conn As New SqlClient.SqlConnection("Data Source=DESKTOP-J0CF9U2\SQLEXPRESS;Initial Catalog=Adams_Biblioteca;Integrated Security=True")

        Dim ConsultaDatos As String = "Select * From Estudiante"
        Dim Adapter As New SqlDataAdapter(ConsultaDatos, conn)
        Dim dt As New DataTable
        Adapter.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub
    ''HASTA AQUI

    Private Sub FrmGuardar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LLenarDataGrid()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim conn As New SqlClient.SqlConnection("Data Source=DESKTOP-J0CF9U2\SQLEXPRESS;Initial Catalog=Adams_Biblioteca;Integrated Security=True")


        Try
            conn.Open()

            Dim cmd As New SqlCommand("INSERT INTO Estudiante (Cedula,Nombres,Apellidos,Direccion,Telefono,Email,Cargo) VALUES ('" & Matricula.Text & "','" & Carrera.Text & "','" & Nombre.Text & "','" & Apellido.Text & "','" & Telefono.Text & "','" & Email.Text & "')", conn)
            cmd.ExecuteReader()

        Catch Exoledb As Exception
        Finally
            MessageBox.Show("GUARDADO CON EXITO")
            LLenarDataGrid()

            conn.Close()
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New SqlClient.SqlConnection("Data Source=DESKTOP-J0CF9U2\SQLEXPRESS;Initial Catalog=Adams_Biblioteca;Integrated Security=True")



        conn.Open()
            Dim cmd As New SqlCommand("delete from Estudiante where Matricula='" & Matricula.Text & "'", conn)
            cmd.ExecuteReader()
        If (Matricula.Text = "") Then

            MessageBox.Show("POR FAVOR INGRESE UNA MATRICULA")


        Else


            MessageBox.Show("BORRADO CON EXITO")
            LLenarDataGrid()

            conn.Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim conn As New SqlClient.SqlConnection("Data Source=DESKTOP-J0CF9U2\SQLEXPRESS;Initial Catalog=Adams_Biblioteca;Integrated Security=True")



        conn.Open()
            Dim cmd As String = "Select * from Estudiante where Matricula='" & Me.Matricula.Text & "'"


            Dim Adapter As New SqlDataAdapter(cmd, conn)
            Dim dt As New DataTable


            Adapter.Fill(dt)
            DataGridView1.DataSource = dt

            conn.Close()


    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class