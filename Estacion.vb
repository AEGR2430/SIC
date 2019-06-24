Imports System.Data.OleDb
Imports Sistema_de_infromación_climatológica.SIC

Public Class Estacion
    Dim strConexion As New OleDbConnection

    Dim EstacionSeleccionada As String
    Dim Dias As Integer
    Dim fecha As Date
    Dim mes As String
    Dim dia As String
    Dim year As String
    Dim db As String
    Dim fechafinal As Date
    Dim conteo As TimeSpan


    Public Sub Estacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            strConexion.ConnectionString = "Provider=Microsoft.jet.oledb.4.0;Data Source = C:\Sistema de informacion climatologica\SIC.mdb"
            strConexion.Open()
        Catch ex As Exception
            MsgBox("No se pudo realizar la conexión con la base de datos.", vbCritical, "Aviso")

        End Try
        Label10.Hide()
        dtpFechaFinal.Hide()
    End Sub

    Private Sub Mostrar()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String
        EstacionSeleccionada = cbEstaciones.Text

        fecha = dtpFechaInicial.Value.ToShortDateString
        fechafinal = dtpFechaFinal.Value.ToShortDateString
        If CbPeriodos.Text = "" Then
            MsgBox("Debe seleccionar un periodo de fechas.", vbExclamation, "Aviso")
        Else
            If CbPeriodos.Text = "Fecha seleccionda" Then
                If cbEstaciones.Text = "Campeche Observatorio" Then
                    consulta = "Select Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from CampecheObservatorio Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    Datos.Visible = True
                    ods.Tables.Add("CampecheObservatorio")
                    oda.Fill(ods.Tables("CampecheObservatorio"))
                    Datos.DataSource = ods.Tables("CampecheObservatorio")
                End If
                If cbEstaciones.Text = "Campeche UAC" Then
                    consulta = "Select Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from CampecheUAC Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    ods.Tables.Add("CampecheUAC")
                    oda.Fill(ods.Tables("CampecheUAC"))
                    Datos.DataSource = ods.Tables("CampecheUAC")
                End If
                If cbEstaciones.Text = "Canasayab" Then
                    consulta = "Select Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Casanayab Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    ods.Tables.Add("Casanayab")
                    oda.Fill(ods.Tables("Casanayab"))
                    Datos.DataSource = ods.Tables("Casanayab")
                End If
                If cbEstaciones.Text = "Bolonchen" Then
                    consulta = "Select Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Bolonchen Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    ods.Tables.Add("Bolonchen")
                    oda.Fill(ods.Tables("Bolonchen"))
                    Datos.DataSource = ods.Tables("Bolonchen")
                End If
                If cbEstaciones.Text = "Candelaria" Then
                    consulta = "Select Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Candelaria Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    ods.Tables.Add("Candelaria")
                    oda.Fill(ods.Tables("Candelaria"))
                    Datos.DataSource = ods.Tables("Candelaria")
                End If
                If cbEstaciones.Text = "Carmen" Then
                    consulta = "Select Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Carmen Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    ods.Tables.Add("Carmen")
                    oda.Fill(ods.Tables("Carmen"))
                    Datos.DataSource = ods.Tables("Carmen")
                End If
                If cbEstaciones.Text = "Champotón" Then
                    consulta = "Select Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Champoton Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    ods.Tables.Add("Champoton")
                    oda.Fill(ods.Tables("Champoton"))
                    Datos.DataSource = ods.Tables("Champoton")
                End If
                If cbEstaciones.Text = "Escárcega" Then
                    consulta = "Select Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Escarcega Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    ods.Tables.Add("Escarcega")
                    oda.Fill(ods.Tables("Escarcega"))
                    Datos.DataSource = ods.Tables("Escarcega")
                End If
                If cbEstaciones.Text = "Hecelchakán" Then
                    consulta = "Select Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Hecelchakan Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    ods.Tables.Add("Hecelchakan")
                    oda.Fill(ods.Tables("Hecelchakan"))
                    Datos.DataSource = ods.Tables("Hecelchakan")
                End If
                If cbEstaciones.Text = "Hopelchén" Then
                    consulta = "Select Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Hopelchen Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    ods.Tables.Add("Hopelchen")
                    oda.Fill(ods.Tables("Hopelchen"))
                    Datos.DataSource = ods.Tables("Hopelchen")
                End If
                If cbEstaciones.Text = "Noh-Yaxché" Then
                    consulta = "Select Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from NohYaxche Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    ods.Tables.Add("NohYaxche")
                    oda.Fill(ods.Tables("NohYaxche"))
                    Datos.DataSource = ods.Tables("NohYaxche")
                End If
                If cbEstaciones.Text = "Palizada" Then
                    consulta = "Select Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Palizada Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    ods.Tables.Add("Palizada")
                    oda.Fill(ods.Tables("Palizada"))
                    Datos.DataSource = ods.Tables("Palizada")
                End If
                If cbEstaciones.Text = "Sabancuy" Then
                    consulta = "Select Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Sabancuy Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    ods.Tables.Add("Sabancuy")
                    oda.Fill(ods.Tables("Sabancuy"))
                    Datos.DataSource = ods.Tables("Sabancuy")
                End If
                If cbEstaciones.Text = "Xcupil" Then
                    consulta = "Select Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Xcupil Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    ods.Tables.Add("Xcupil")
                    oda.Fill(ods.Tables("Xcupil"))
                    Datos.DataSource = ods.Tables("Xcupil")
                End If
                If cbEstaciones.Text = "Xpujil" Then
                    consulta = "Select Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Xcupil Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    ods.Tables.Add("Xpujil")
                    oda.Fill(ods.Tables("Xpujil"))
                    Datos.DataSource = ods.Tables("Xpujil")
                End If
            End If
            If CbPeriodos.Text = "Periodo de fechas" Then
                Label10.Show()
                dtpFechaFinal.Show()

                Dim n As Integer = 1
                Dias = DateDiff(DateInterval.Day, fecha, fechafinal)
                If cbEstaciones.Text = "Campeche Observatorio" Then
                    consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from CampecheObservatorio Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    Datos.Visible = True
                    ods.Tables.Add("CampecheObservatorio")
                    oda.Fill(ods.Tables("CampecheObservatorio"))
                    While n <= Dias

                        MsgBox(fecha, vbInformation, "Aviso")
                        consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from CampecheObservatorio Where Fecha = '" + fecha.AddDays(1) + "'"
                        oda = New OleDbDataAdapter(consulta, strConexion)
                        oda.Fill(ods.Tables("CampecheObservatorio"))
                        Datos.DataSource = ods.Tables("CampecheObservatorio")
                        n = n + 1
                        fecha = fecha.AddDays(1)
                    End While
                End If
                If cbEstaciones.Text = "Bolonchen" Then
                    consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Bolonchen Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    Datos.Visible = True
                    ods.Tables.Add("Bolonchen")
                    oda.Fill(ods.Tables("Bolonchen"))
                    While n <= Dias
                        consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Bolonchen Where Fecha = '" + fecha.AddDays(1) + "'"
                        oda = New OleDbDataAdapter(consulta, strConexion)
                        oda.Fill(ods.Tables("Bolonchen"))
                        Datos.DataSource = ods.Tables("Bolonchen")
                        n = n + 1
                        fecha = fecha.AddDays(1)
                    End While
                End If
                If cbEstaciones.Text = "Campeche UAC" Then
                    consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from CampecheUAC Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    Datos.Visible = True
                    ods.Tables.Add("CampecheUAC")
                    oda.Fill(ods.Tables("CampecheUAC"))
                    While n <= Dias
                        consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from CampecheUAC Where Fecha = '" + fecha.AddDays(1) + "'"
                        oda = New OleDbDataAdapter(consulta, strConexion)
                        oda.Fill(ods.Tables("CampecheUAC"))
                        Datos.DataSource = ods.Tables("CampecheUAC")
                        n = n + 1
                        fecha = fecha.AddDays(1)
                    End While
                End If
                If cbEstaciones.Text = "Candelaria" Then
                    consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Candelaria Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    Datos.Visible = True
                    ods.Tables.Add("Candelaria")
                    oda.Fill(ods.Tables("Candelaria"))
                    While n <= Dias
                        consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Candelaria Where Fecha = '" + fecha.AddDays(1) + "'"
                        oda = New OleDbDataAdapter(consulta, strConexion)
                        oda.Fill(ods.Tables("Candelaria"))
                        Datos.DataSource = ods.Tables("Candelaria")
                        n = n + 1
                        fecha = fecha.AddDays(1)
                    End While
                End If
                If cbEstaciones.Text = "Carmen" Then
                    consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Carmen Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    Datos.Visible = True
                    ods.Tables.Add("Carmen")
                    oda.Fill(ods.Tables("Carmen"))
                    While n <= Dias
                        consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Carmen Where Fecha = '" + fecha.AddDays(1) + "'"
                        oda = New OleDbDataAdapter(consulta, strConexion)
                        oda.Fill(ods.Tables("Carmen"))
                        Datos.DataSource = ods.Tables("Carmen")
                        n = n + 1
                        fecha = fecha.AddDays(1)
                    End While
                End If
                If cbEstaciones.Text = "Champotón" Then
                    consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Champoton Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    Datos.Visible = True
                    ods.Tables.Add("Champoton")
                    oda.Fill(ods.Tables("Champoton"))
                    While n <= Dias
                        consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Champoton Where Fecha = '" + fecha.AddDays(1) + "'"
                        oda = New OleDbDataAdapter(consulta, strConexion)
                        oda.Fill(ods.Tables("Champoton"))
                        Datos.DataSource = ods.Tables("Champoton")
                        n = n + 1
                        fecha = fecha.AddDays(1)
                    End While
                End If
                If cbEstaciones.Text = "Escárcega" Then
                    consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Escarcega Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    Datos.Visible = True
                    ods.Tables.Add("Escarcega")
                    oda.Fill(ods.Tables("Escarcega"))
                    While n <= Dias
                        consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Escarcega Where Fecha = '" + fecha.AddDays(1) + "'"
                        oda = New OleDbDataAdapter(consulta, strConexion)
                        oda.Fill(ods.Tables("Escarcega"))
                        Datos.DataSource = ods.Tables("Escarcega")
                        n = n + 1
                        fecha = fecha.AddDays(1)
                    End While
                End If
                If cbEstaciones.Text = "Hecelchakán" Then
                    consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Hecelchakan Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    Datos.Visible = True
                    ods.Tables.Add("Hecelchakan")
                    oda.Fill(ods.Tables("Hecelchakan"))
                    While n <= Dias
                        consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Hecelchakan Where Fecha = '" + fecha.AddDays(1) + "'"
                        oda = New OleDbDataAdapter(consulta, strConexion)
                        oda.Fill(ods.Tables("Hecelchakan"))
                        Datos.DataSource = ods.Tables("Hecelchakan")
                        n = n + 1
                        fecha = fecha.AddDays(1)
                    End While
                End If
                If cbEstaciones.Text = "Hopelchén" Then
                    consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Hopelchen Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    Datos.Visible = True
                    ods.Tables.Add("Hopelchen")
                    oda.Fill(ods.Tables("Hopelchen"))
                    While n <= Dias
                        consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Hopelchen Where Fecha = '" + fecha.AddDays(1) + "'"
                        oda = New OleDbDataAdapter(consulta, strConexion)
                        oda.Fill(ods.Tables("Hopelchen"))
                        Datos.DataSource = ods.Tables("Hopelchen")
                        n = n + 1
                        fecha = fecha.AddDays(1)
                    End While
                End If
                If cbEstaciones.Text = "Nox-Yaxché" Then
                    consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from NoxYaxche Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    Datos.Visible = True
                    ods.Tables.Add("NoxYaxche")
                    oda.Fill(ods.Tables("NoxYaxche"))
                    While n <= Dias
                        consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from NoxYaxche Where Fecha = '" + fecha.AddDays(1) + "'"
                        oda = New OleDbDataAdapter(consulta, strConexion)
                        oda.Fill(ods.Tables("NoxYaxche"))
                        Datos.DataSource = ods.Tables("NoxYaxche")
                        n = n + 1
                        fecha = fecha.AddDays(1)
                    End While
                End If
                If cbEstaciones.Text = "Palizada" Then
                    consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Palizada Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    Datos.Visible = True
                    ods.Tables.Add("Palizada")
                    oda.Fill(ods.Tables("Palizada"))
                    While n <= Dias
                        consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Palizada Where Fecha = '" + fecha.AddDays(1) + "'"
                        oda = New OleDbDataAdapter(consulta, strConexion)
                        oda.Fill(ods.Tables("Palizada"))
                        Datos.DataSource = ods.Tables("Palizada")
                        n = n + 1
                        fecha = fecha.AddDays(1)
                    End While
                End If
                If cbEstaciones.Text = "Sabancuy" Then
                    consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Sabancuy Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    Datos.Visible = True
                    ods.Tables.Add("Sabancuy")
                    oda.Fill(ods.Tables("Sabancuy"))
                    While n <= Dias
                        consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Sabancuy Where Fecha = '" + fecha.AddDays(1) + "'"
                        oda = New OleDbDataAdapter(consulta, strConexion)
                        oda.Fill(ods.Tables("Sabancuy"))
                        Datos.DataSource = ods.Tables("Sabancuy")
                        n = n + 1
                        fecha = fecha.AddDays(1)
                    End While
                End If
                If cbEstaciones.Text = "Xcupil" Then
                    consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Xcupil Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    Datos.Visible = True
                    ods.Tables.Add("Xcupil")
                    oda.Fill(ods.Tables("Xcupil"))
                    While n <= Dias
                        consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Xcupil Where Fecha = '" + fecha.AddDays(1) + "'"
                        oda = New OleDbDataAdapter(consulta, strConexion)
                        oda.Fill(ods.Tables("Xcupil"))
                        Datos.DataSource = ods.Tables("Xcupil")
                        n = n + 1
                        fecha = fecha.AddDays(1)
                    End While
                End If
                If cbEstaciones.Text = "Xpujil" Then
                    consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Xpujil Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    Datos.Visible = True
                    ods.Tables.Add("Xpujil")
                    oda.Fill(ods.Tables("Xpujil"))
                    While n <= Dias
                        consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Xpujil Where Fecha = '" + fecha.AddDays(1) + "'"
                        oda = New OleDbDataAdapter(consulta, strConexion)
                        oda.Fill(ods.Tables("Xpujil"))
                        Datos.DataSource = ods.Tables("Xpujil")
                        n = n + 1
                        fecha = fecha.AddDays(1)
                    End While
                End If
                If cbEstaciones.Text = "Casanayab" Then
                    consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Casanayab Where Fecha = '" + fecha + "'"
                    oda = New OleDbDataAdapter(consulta, strConexion)
                    Datos.Visible = True
                    ods.Tables.Add("Casanayab")
                    oda.Fill(ods.Tables("Canasayab"))
                    While n <= Dias
                        consulta = "Select Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, MeMen, Anual from Casanayab Where Fecha = '" + fecha.AddDays(1) + "'"
                        oda = New OleDbDataAdapter(consulta, strConexion)
                        oda.Fill(ods.Tables("Casanayab"))
                        Datos.DataSource = ods.Tables("Casanayab")
                        n = n + 1
                        fecha = fecha.AddDays(1)
                    End While
                End If
            End If
        End If
        Datos.Visible = True
    End Sub
    Private Sub ButtonConsulta_Click(sender As Object, e As EventArgs) Handles ButtonConsulta.Click
        Mostrar()
    End Sub

    Private Sub ButtonInicio_Click(sender As Object, e As EventArgs) Handles ButtonInicio.Click
        SIC.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConsultaPeriodo.Click
        Mostrar()
    End Sub

    Private Sub Datos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datos.CellContentClick

    End Sub

    Private Sub ButtonGraficas_Click(sender As Object, e As EventArgs) Handles ButtonGraficas.Click
        Form1.Show()
        ButtonGraficas.Visible = True
    End Sub


End Class