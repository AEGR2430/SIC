Imports System.Data.OleDb
Imports Sistema_de_infromación_climatológica.SIC
Public Class Fecha
    Dim strConexion As New OleDbConnection
    Dim db As String
    Dim fecha As Date
    Dim fechafinal As Date
    Dim n As Integer = 1
    Dim Dias As Integer
    Private Sub Fecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            strConexion.ConnectionString = "Provider=Microsoft.jet.oledb.4.0;Data Source = C:\Sistema de informacion climatologica\SIC.mdb"
            strConexion.Open()
            MsgBox("Se ha realizado la conexión con la base de datos.", vbInformation, "Aviso")
        Catch ex As Exception
            MsgBox("No se pudo realizar la conexión con la base de datos.", vbCritical, "Aviso")

        End Try

    End Sub

    Private Sub Mostrar()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String
        fecha = dtpFechaInicial.Value.ToShortDateString
        fechafinal = dtpFechaFinal.Value.ToShortDateString
        Dias = DateDiff(DateInterval.Day, fecha, fechafinal)
        If cbPeriodo.Text = "Fecha seleccionada" Then
            Label10.Hide()
            dtpFechaFinal.Hide()
            consulta = "Select Promedio, Maxima, Minima from Estado Where Fecha = '" + fecha + "'"
            oda = New OleDbDataAdapter(consulta, strConexion)
            Datos.Visible = True
            ods.Tables.Add("Estado")
            oda.Fill(ods.Tables("Estado"))
            Datos.DataSource = ods.Tables("Estado")
        Else
            consulta = "Select Fecha, Promedio, Maxima, Minima from Estado Where Fecha = '" + fecha + "'"
            oda = New OleDbDataAdapter(consulta, strConexion)
            Datos.Visible = True
            ods.Tables.Add("Estado")
            oda.Fill(ods.Tables("Estado"))
            Datos.DataSource = ods.Tables("Estado")
            While n <= Dias
                consulta = "Select Fecha, Promedio, Maxima, Minima from Estado Where Fecha = '" + fecha.AddDays(1) + "'"
                oda = New OleDbDataAdapter(consulta, strConexion)
                oda.Fill(ods.Tables("Estado"))
                Datos.DataSource = ods.Tables("Estado")
                n = n + 1
                fecha = fecha.AddDays(1)
            End While
        End If
        Datos.Visible = True
    End Sub
    Private Sub CbPeriodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPeriodo.SelectedIndexChanged
        Label10.Hide()
        dtpFechaFinal.Hide()
        If cbPeriodo.Text = "Periodo de fechas" Then
            Label10.Show()
            dtpFechaFinal.Show()
        Else
            Label10.Hide()
            dtpFechaFinal.Hide()
        End If
    End Sub


    Private Sub ButtonInicio_Click(sender As Object, e As EventArgs) Handles ButtonInicio.Click
        SIC.Show()
        Me.Close()
    End Sub

    Private Sub ButtonConsultar_Click(sender As Object, e As EventArgs) Handles ButtonConsultar.Click
        Mostrar()
    End Sub

    Private Sub Datos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datos.CellContentClick

    End Sub

    Private oda As New OleDbDataAdapter
    Dim ods As New DataSet
    Dim consulta As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        consulta = "Select * from Estado"
        oda = New OleDbDataAdapter(consulta, strConexion)
        Datos.Visible = True
        ods.Tables.Add("Estado")
        oda.Fill(ods.Tables("Estado"))
        Datos.DataSource = ods.Tables("Estado")
    End Sub
End Class