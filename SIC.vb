Imports System.Data
Imports System.Data.OleDb

Public Class SIC
    Dim strConexion As New OleDbConnection

    Private Sub Conexion()
        Try
            strConexion.ConnectionString = "Provider=Microsoft.jet.oledb.4.0;Data Source = C:\Sistema de informacion climatologica\SIC.mdb"
            strConexion.Open()
            MsgBox("Se ha realizado la conexión con la base de datos.", vbInformation, "Aviso")
        Catch ex As Exception
            MsgBox("No se pudo realizar la conexión con la base de datos.", vbCritical, "Aviso")

        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonConsultaEscacion.Click
        Estacion.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub ButtonConsultaFecha_Click(sender As Object, e As EventArgs) Handles ButtonConsultaFecha.Click
        Fecha.Show()
        Me.Hide()
    End Sub

    Private Sub SIC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles InsertaDatos.Click
        InsertarDatos.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles LoadBD.Click
        Conexion()
    End Sub
End Class
