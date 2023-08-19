Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class FrmLOGIN


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New SqlClient.SqlConnection("Data Source=DESKTOP-J0CF9U2\SQLEXPRESS;Initial Catalog=Adams_Biblioteca;Integrated Security=True")

        Dim dr As SqlDataReader
        'Dim da As SqlDataAdapter
        Dim ds As New DataSet
        'Dim dt As DataTable

        Try
            conn.Open()
            Dim cmd As New SqlCommand("Select * from Usuarios where UsuarioID='" & Me.TextBox1.Text & "'" & " and Clave='" & Me.TextBox2.Text & "'", conn)
            dr = cmd.ExecuteReader
            If (dr.HasRows = True) Then
                MessageBox.Show("BIENVENIDO A NUESTRO SISTEMA ESCOLAR")
                Me.Hide()
                Dim Frmenu As New FrmMENU
                Frmenu.Show()

            ElseIf (dr.HasRows = False) Then
                MessageBox.Show("NOMBRE DE USUARIO O CLAVE NO EXISTE")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox1.Focus()
            End If
        Catch Exoledb As Exception
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub FrmLOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub
End Class