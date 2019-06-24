Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting
Imports Sistema_de_infromación_climatológica.SIC
Public Class Form1
    Dim strConexion As New OleDbConnection
    Dim FirtsYear As DateTime
    Dim LastYear As DateTime

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            strConexion.ConnectionString = "Provider=Microsoft.jet.oledb.4.0;Data Source = C:\Sistema de informacion climatologica\SIC.mdb"
            strConexion.Open()
        Catch ex As Exception
            MsgBox("No se pudo realizar la conexión con la base de datos.", vbCritical, "Aviso")

        End Try
    End Sub

    Private Sub BtnGPcpn_Click(sender As Object, e As EventArgs) Handles BtnGPcpn.Click

    End Sub

    Private Sub BtnGTemp_Click(sender As Object, e As EventArgs) Handles BtnGTemp.Click

    End Sub
End Class