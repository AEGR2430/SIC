Imports Sistema_de_infromación_climatológica.SIC
Imports System.Data.OleDb


Public Class InsertarDatos
    Dim strConexion As New OleDbConnection
    Dim Fecha As Date
    Private Sub InsertarDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            strConexion.ConnectionString = "Provider=Microsoft.jet.oledb.4.0;Data Source = C:\Sistema de informacion climatologica\SIC.mdb"
            strConexion.Open()
            MsgBox("Se ha realizado la conexión con la base de datos.", vbInformation, "Aviso")
        Catch ex As Exception
            MsgBox("No se pudo realizar la conexión con la base de datos.", vbCritical, "Aviso")

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Fecha = DTPFecha.Value.ToShortDateString
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta
        Dim comandos
        Dim uac, bolonchen, carmen, candelaria, champoton, escarcega, hecelchakan, hopelchen, noxyache, palizada, sabancuy, xcupil, xpujil, casanayab
        Try
            'Consulta INSERT en Access
            comandos = New OleDbCommand("INSERT INTO Estado(Fecha, Promedio, Maxima, Minima)" & vbCrLf &
                "VALUES(Fecha, PROM, TMAX, TMIN)", strConexion)
            'Agregar los valores de los TextBox en la consulta
            comandos.Parameters.AddWithValue("@Fecha", Fecha)
                comandos.Parameters.AddWithValue("@PROM", PROM.Text)
                comandos.Parameters.AddWithValue("@TMAX", TMAX.Text)
                comandos.Parameters.AddWithValue("@TMIN", TMIN.Text)
                'Para ejecutar la consulta en el Access
                comandos.ExecuteNonQuery()
                MsgBox("Se ha registrado correctamente en la tabla.", vbInformation, "Aviso")
            Catch ex As Exception
                MsgBox("No se realizó el registro de datos en la tabla RegistradasEstado.", vbExclamation, "Aviso")
            End Try
            Try
                consulta = New OleDbCommand("INSERT INTO CampecheObservatorio(Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, Acum, MeMen, Anual)" & vbCrLf &
                                        "VALUES(Fecha, TMAX, TMIN, MAXH, MINH, PCPN, ACUM, MMEN, ANUAL)", strConexion)
                consulta.Parameters.AddWithValue("@Fecha", Fecha)
                consulta.Parameters.AddWithValue("@TMAX", TextBox1.Text)
                consulta.Parameters.AddWithValue("@TMIN", TextBox2.Text)
                consulta.Parameters.AddWithValue("@MAXH", TextBox3.Text)
                consulta.Parameters.AddWithValue("@MINH", TextBox4.Text)
                consulta.Parameters.AddWithValue("@PCPN", TextBox5.Text)
                consulta.Parameters.AddWithValue("@ACUM", TextBox6.Text)
                consulta.Parameters.AddWithValue("@MMEN", TextBox7.Text)
                consulta.Parameters.AddWithValue("@ANUAL", TextBox8.Text)
                consulta.Execute.NonQuery()
            Catch ex As Exception
                MsgBox("No se realizó el registro de datos en la tabla CampecheObservatorio.", vbExclamation, "Aviso")
            End Try
            Try
                bolonchen = New OleDbCommand("INSERT INTO Bolonchen(Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, Acum, MeMen, Anual)" & vbCrLf &
                                        "VALUES(Fecha, TMAX, TMIN, MAXH, MINH, PCPN, ACUM, MMEN, ANUAL)", strConexion)
                bolonchen.Parameters.AddWithValue("@Fecha", Fecha)
                bolonchen.Parameters.AddWithValue("@TMAX", TextBox9.Text)
                bolonchen.Parameters.AddWithValue("@TMIN", TextBox10.Text)
                bolonchen.Parameters.AddWithValue("@MAXH", TextBox11.Text)
                bolonchen.Parameters.AddWithValue("@MINH", TextBox12.Text)
                bolonchen.Parameters.AddWithValue("@PCPN", TextBox13.Text)
                bolonchen.Parameters.AddWithValue("@ACUM", TextBox14.Text)
                bolonchen.Parameters.AddWithValue("@MMEN", TextBox15.Text)
                bolonchen.Parameters.AddWithValue("@ANUAL", TextBox16.Text)
                bolonchen.Execute.NonQuery()
            Catch ex As Exception
                MsgBox("No se realizó el registro de datos en la tabla Bolonchen.", vbExclamation, "Aviso")
            End Try

            Try
                uac = New OleDbCommand("INSERT INTO CampecheUAC(Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, Acum, MeMen, Anual)" & vbCrLf &
                                            "VALUES(Fecha, TMAX, TMIN, MAXH, MINH, PCPN, ACUM, MMEN, ANUAL)", strConexion)
                uac.Parameters.AddWithValue("@Fecha", Fecha)
                uac.Parameters.AddWithValue("@TMAX", TextBox17.Text)
                uac.Parameters.AddWithValue("@TMIN", TextBox18.Text)
                uac.Parameters.AddWithValue("@MAXH", TextBox19.Text)
                uac.Parameters.AddWithValue("@MINH", TextBox20.Text)
                uac.Parameters.AddWithValue("@PCPN", TextBox21.Text)
                uac.Parameters.AddWithValue("@ACUM", TextBox22.Text)
                uac.Parameters.AddWithValue("@MMEN", TextBox23.Text)
                uac.Parameters.AddWithValue("@ANUAL", TextBox24.Text)
                uac.Execute.NonQuery()
            Catch ex As Exception
                MsgBox("No se realizó el registro de datos en la tabla CampecheUAC.", vbExclamation, "Aviso")
            End Try

            Try
                candelaria = New OleDbCommand("INSERT INTO Candelaria(Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, Acum, MeMen, Anual)" & vbCrLf &
                                        "VALUES(Fecha, TMAX, TMIN, MAXH, MINH, PCPN, ACUM, MMEN, ANUAL)", strConexion)
                candelaria.Parameters.AddWithValue("@Fecha", Fecha)
                candelaria.Parameters.AddWithValue("@TMAX", TextBox25.Text)
                candelaria.Parameters.AddWithValue("@TMIN", TextBox26.Text)
                candelaria.Parameters.AddWithValue("@MAXH", TextBox27.Text)
                candelaria.Parameters.AddWithValue("@MINH", TextBox28.Text)
                candelaria.Parameters.AddWithValue("@PCPN", TextBox29.Text)
                candelaria.Parameters.AddWithValue("@ACUM", TextBox30.Text)
                candelaria.Parameters.AddWithValue("@MMEN", TextBox31.Text)
                candelaria.Parameters.AddWithValue("@ANUAL", TextBox32.Text)
                candelaria.Execute.NonQuery()
            Catch ex As Exception
                MsgBox("No se realizó el registro de datos en la tabla Candelaria.", vbExclamation, "Aviso")
            End Try

            Try
                carmen = New OleDbCommand("INSERT INTO Carmen(Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, Acum, MeMen, Anual)" & vbCrLf &
                                        "VALUES(Fecha, TMAX, TMIN, MAXH, MINH, PCPN, ACUM, MMEN, ANUAL)", strConexion)
                carmen.Parameters.AddWithValue("@Fecha", Fecha)
                carmen.Parameters.AddWithValue("@TMAX", TextBox33.Text)
                carmen.Parameters.AddWithValue("@TMIN", TextBox34.Text)
                carmen.Parameters.AddWithValue("@MAXH", TextBox35.Text)
                carmen.Parameters.AddWithValue("@MINH", TextBox36.Text)
                carmen.Parameters.AddWithValue("@PCPN", TextBox37.Text)
                carmen.Parameters.AddWithValue("@ACUM", TextBox38.Text)
                carmen.Parameters.AddWithValue("@MMEN", TextBox39.Text)
                carmen.Parameters.AddWithValue("@ANUAL", TextBox40.Text)
                carmen.Execute.NonQuery()
            Catch ex As Exception
                MsgBox("No se realizó el registro de datos en la tabla Carmen.", vbExclamation, "Aviso")
            End Try

            Try
                champoton = New OleDbCommand("INSERT INTO Champoton(Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, Acum, MeMen, Anual)" & vbCrLf &
                                        "VALUES(Fecha, TMAX, TMIN, MAXH, MINH, PCPN, ACUM, MMEN, ANUAL)", strConexion)
                champoton.Parameters.AddWithValue("@Fecha", Fecha)
                champoton.Parameters.AddWithValue("@TMAX", TextBox41.Text)
                champoton.Parameters.AddWithValue("@TMIN", TextBox42.Text)
                champoton.Parameters.AddWithValue("@MAXH", TextBox43.Text)
                champoton.Parameters.AddWithValue("@MINH", TextBox44.Text)
                champoton.Parameters.AddWithValue("@PCPN", TextBox45.Text)
                champoton.Parameters.AddWithValue("@ACUM", TextBox46.Text)
                champoton.Parameters.AddWithValue("@MMEN", TextBox47.Text)
                champoton.Parameters.AddWithValue("@ANUAL", TextBox48.Text)
                champoton.Execute.NonQuery()
            Catch ex As Exception
                MsgBox("No se realizó el registro de datos en la tabla Champoton.", vbExclamation, "Aviso")
            End Try

            Try
                escarcega = New OleDbCommand("INSERT INTO Escarcega(Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, Acum, MeMen, Anual)" & vbCrLf &
                                        "VALUES(Fecha, TMAX, TMIN, MAXH, MINH, PCPN, ACUM, MMEN, ANUAL)", strConexion)
                escarcega.Parameters.AddWithValue("@Fecha", Fecha)
                escarcega.Parameters.AddWithValue("@TMAX", TextBox49.Text)
                escarcega.Parameters.AddWithValue("@TMIN", TextBox50.Text)
                escarcega.Parameters.AddWithValue("@MAXH", TextBox51.Text)
                escarcega.Parameters.AddWithValue("@MINH", TextBox52.Text)
                escarcega.Parameters.AddWithValue("@PCPN", TextBox53.Text)
                escarcega.Parameters.AddWithValue("@ACUM", TextBox54.Text)
                escarcega.Parameters.AddWithValue("@MMEN", TextBox55.Text)
                escarcega.Parameters.AddWithValue("@ANUAL", TextBox56.Text)
                escarcega.Execute.NonQuery()
            Catch ex As Exception
                MsgBox("No se realizó el registro de datos en la tabla Escarcega.", vbExclamation, "Aviso")
            End Try

            Try
                hecelchakan = New OleDbCommand("INSERT INTO Hecelchakan(Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, Acum, MeMen, Anual)" & vbCrLf &
                                        "VALUES(Fecha, TMAX, TMIN, MAXH, MINH, PCPN, ACUM, MMEN, ANUAL)", strConexion)
                hecelchakan.Parameters.AddWithValue("@Fecha", Fecha)
                hecelchakan.Parameters.AddWithValue("@TMAX", TextBox57.Text)
                hecelchakan.Parameters.AddWithValue("@TMIN", TextBox58.Text)
                hecelchakan.Parameters.AddWithValue("@MAXH", TextBox59.Text)
                hecelchakan.Parameters.AddWithValue("@MINH", TextBox60.Text)
                hecelchakan.Parameters.AddWithValue("@PCPN", TextBox61.Text)
                hecelchakan.Parameters.AddWithValue("@ACUM", TextBox62.Text)
                hecelchakan.Parameters.AddWithValue("@MMEN", TextBox63.Text)
                hecelchakan.Parameters.AddWithValue("@ANUAL", TextBox64.Text)
                hecelchakan.Execute.NonQuery()
            Catch ex As Exception
                MsgBox("No se realizó el registro de datos en la tabla Hecelchakan.", vbExclamation, "Aviso")
            End Try

            Try
                hopelchen = New OleDbCommand("INSERT INTO Hopelchen(Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, Acum, MeMen, Anual)" & vbCrLf &
                                        "VALUES(Fecha, TMAX, TMIN, MAXH, MINH, PCPN, ACUM, MMEN, ANUAL)", strConexion)
                hopelchen.Parameters.AddWithValue("@Fecha", Fecha)
                hopelchen.Parameters.AddWithValue("@TMAX", TextBox65.Text)
                hopelchen.Parameters.AddWithValue("@TMIN", TextBox66.Text)
                hopelchen.Parameters.AddWithValue("@MAXH", TextBox67.Text)
                hopelchen.Parameters.AddWithValue("@MINH", TextBox68.Text)
                hopelchen.Parameters.AddWithValue("@PCPN", TextBox69.Text)
                hopelchen.Parameters.AddWithValue("@ACUM", TextBox70.Text)
                hopelchen.Parameters.AddWithValue("@MMEN", TextBox71.Text)
                hopelchen.Parameters.AddWithValue("@ANUAL", TextBox72.Text)
                hopelchen.Execute.NonQuery()
            Catch ex As Exception
                MsgBox("No se realizó el registro de datos en la tabla Hopelchen.", vbExclamation, "Aviso")
            End Try

            Try
                noxyache = New OleDbCommand("INSERT INTO NohYaxche(Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, Acum, MeMen, Anual)" & vbCrLf &
                                        "VALUES(Fecha, TMAX, TMIN, MAXH, MINH, PCPN, ACUM, MMEN, ANUAL)", strConexion)
                noxyache.Parameters.AddWithValue("@Fecha", Fecha)
                noxyache.Parameters.AddWithValue("@TMAX", TextBox73.Text)
                noxyache.Parameters.AddWithValue("@TMIN", TextBox74.Text)
                noxyache.Parameters.AddWithValue("@MAXH", TextBox75.Text)
                noxyache.Parameters.AddWithValue("@MINH", TextBox76.Text)
                noxyache.Parameters.AddWithValue("@PCPN", TextBox77.Text)
                noxyache.Parameters.AddWithValue("@ACUM", TextBox78.Text)
                noxyache.Parameters.AddWithValue("@MMEN", TextBox79.Text)
                noxyache.Parameters.AddWithValue("@ANUAL", TextBox80.Text)
                noxyache.Execute.NonQuery()
            Catch ex As Exception
                MsgBox("No se realizó el registro de datos en la tabla NoxYache.", vbExclamation, "Aviso")
            End Try

            Try
                palizada = New OleDbCommand("INSERT INTO Palizada(Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, Acum, MeMen, Anual)" & vbCrLf &
                                        "VALUES(Fecha, TMAX, TMIN, MAXH, MINH, PCPN, ACUM, MMEN, ANUAL)", strConexion)
                palizada.Parameters.AddWithValue("@Fecha", Fecha)
                palizada.Parameters.AddWithValue("@TMAX", TextBox81.Text)
                palizada.Parameters.AddWithValue("@TMIN", TextBox82.Text)
                palizada.Parameters.AddWithValue("@MAXH", TextBox83.Text)
                palizada.Parameters.AddWithValue("@MINH", TextBox84.Text)
                palizada.Parameters.AddWithValue("@PCPN", TextBox85.Text)
                palizada.Parameters.AddWithValue("@ACUM", TextBox86.Text)
                palizada.Parameters.AddWithValue("@MMEN", TextBox87.Text)
                palizada.Parameters.AddWithValue("@ANUAL", TextBox88.Text)
                palizada.Execute.NonQuery()
            Catch ex As Exception
                MsgBox("No se realizó el registro de datos en la tabla Palizada.", vbExclamation, "Aviso")
            End Try

            Try
                sabancuy = New OleDbCommand("INSERT INTO Sabancuy(Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, Acum, MeMen, Anual)" & vbCrLf &
                                        "VALUES(Fecha, TMAX, TMIN, MAXH, MINH, PCPN, ACUM, MMEN, ANUAL)", strConexion)
                sabancuy.Parameters.AddWithValue("@Fecha", Fecha)
                sabancuy.Parameters.AddWithValue("@TMAX", TextBox89.Text)
                sabancuy.Parameters.AddWithValue("@TMIN", TextBox90.Text)
                sabancuy.Parameters.AddWithValue("@MAXH", TextBox91.Text)
                sabancuy.Parameters.AddWithValue("@MINH", TextBox92.Text)
                sabancuy.Parameters.AddWithValue("@PCPN", TextBox93.Text)
                sabancuy.Parameters.AddWithValue("@ACUM", TextBox94.Text)
                sabancuy.Parameters.AddWithValue("@MMEN", TextBox95.Text)
                sabancuy.Parameters.AddWithValue("@ANUAL", TextBox96.Text)
                sabancuy.Execute.NonQuery()
            Catch ex As Exception
                MsgBox("No se realizó el registro de datos en la tabla Sabancuy.", vbExclamation, "Aviso")
            End Try

            Try
                xcupil = New OleDbCommand("INSERT INTO Xcupil(Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, Acum, MeMen, Anual)" & vbCrLf &
                                        "VALUES(Fecha, TMAX, TMIN, MAXH, MINH, PCPN, ACUM, MMEN, ANUAL)", strConexion)
                xcupil.Parameters.AddWithValue("@Fecha", Fecha)
                xcupil.Parameters.AddWithValue("@TMAX", TextBox97.Text)
                xcupil.Parameters.AddWithValue("@TMIN", TextBox98.Text)
                xcupil.Parameters.AddWithValue("@MAXH", TextBox99.Text)
                xcupil.Parameters.AddWithValue("@MINH", TextBox100.Text)
                xcupil.Parameters.AddWithValue("@PCPN", TextBox101.Text)
                xcupil.Parameters.AddWithValue("@ACUM", TextBox102.Text)
                xcupil.Parameters.AddWithValue("@MMEN", TextBox103.Text)
                xcupil.Parameters.AddWithValue("@ANUAL", TextBox104.Text)
                xcupil.Execute.NonQuery()
            Catch ex As Exception
                MsgBox("No se realizó el registro de datos en la tabla Xcupil.", vbExclamation, "Aviso")
            End Try

            Try
                xpujil = New OleDbCommand("INSERT INTO Xpujil(Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, Acum, MeMen, Anual)" & vbCrLf &
                                        "VALUES(Fecha, TMAX, TMIN, MAXH, MINH, PCPN, ACUM, MMEN, ANUAL)", strConexion)
                xpujil.Parameters.AddWithValue("@Fecha", Fecha)
                xpujil.Parameters.AddWithValue("@TMAX", TextBox105.Text)
                xpujil.Parameters.AddWithValue("@TMIN", TextBox106.Text)
                xpujil.Parameters.AddWithValue("@MAXH", TextBox107.Text)
                xpujil.Parameters.AddWithValue("@MINH", TextBox108.Text)
                xpujil.Parameters.AddWithValue("@PCPN", TextBox109.Text)
                xpujil.Parameters.AddWithValue("@ACUM", TextBox110.Text)
                xpujil.Parameters.AddWithValue("@MMEN", TextBox111.Text)
                xpujil.Parameters.AddWithValue("@ANUAL", TextBox112.Text)
                xpujil.Execute.NonQuery()
            Catch ex As Exception
                MsgBox("No se realizó el registro de datos en la tabla Xpujil.", vbExclamation, "Aviso")
            End Try

        Try
            casanayab = New OleDbCommand("INSERT INTO Canasayab(Fecha, Tmax, Tmin, MaxHis, MinHis, Pcpn, Acum, MeMen, Anual)" & vbCrLf &
                                        "VALUES(Fecha, TMAX, TMIN, MAXH, MINH, PCPN, ACUM, MMEN, ANUAL)", strConexion)
            casanayab.Parameters.AddWithValue("@Fecha", Fecha)
            casanayab.Parameters.AddWithValue("@TMAX", TextBox113.Text)
            casanayab.Parameters.AddWithValue("@TMIN", TextBox114.Text)
            casanayab.Parameters.AddWithValue("@MAXH", TextBox115.Text)
            casanayab.Parameters.AddWithValue("@MINH", TextBox116.Text)
            casanayab.Parameters.AddWithValue("@PCPN", TextBox117.Text)
            casanayab.Parameters.AddWithValue("@ACUM", TextBox118.Text)
            casanayab.Parameters.AddWithValue("@MMEN", TextBox110.Text)
            casanayab.Parameters.AddWithValue("@ANUAL", TextBox120.Text)
            casanayab.Execute.NonQuery()
        Catch ex As Exception
            MsgBox("No se realizó el registro de datos en la tabla Canasayab.", vbExclamation, "Aviso")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        SIC.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TMAX.Clear()
        TMIN.Clear()
        PROM.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        TextBox16.Clear()
        TextBox17.Clear()
        TextBox18.Clear()
        TextBox19.Clear()
        TextBox20.Clear()
        TextBox21.Clear()
        TextBox22.Clear()
        TextBox23.Clear()
        TextBox24.Clear()
        TextBox25.Clear()
        TextBox26.Clear()
        TextBox27.Clear()
        TextBox28.Clear()
        TextBox29.Clear()
        TextBox30.Clear()
        TextBox31.Clear()
        TextBox32.Clear()
        TextBox33.Clear()
        TextBox34.Clear()
        TextBox35.Clear()
        TextBox36.Clear()
        TextBox37.Clear()
        TextBox38.Clear()
        TextBox39.Clear()
        TextBox40.Clear()
        TextBox41.Clear()
        TextBox42.Clear()
        TextBox43.Clear()
        TextBox44.Clear()
        TextBox45.Clear()
        TextBox46.Clear()
        TextBox47.Clear()
        TextBox48.Clear()
        TextBox49.Clear()
        TextBox50.Clear()
        TextBox51.Clear()
        TextBox52.Clear()
        TextBox53.Clear()
        TextBox54.Clear()
        TextBox55.Clear()
        TextBox56.Clear()
        TextBox57.Clear()
        TextBox58.Clear()
        TextBox59.Clear()
        TextBox60.Clear()
        TextBox61.Clear()
        TextBox62.Clear()
        TextBox63.Clear()
        TextBox64.Clear()
        TextBox65.Clear()
        TextBox66.Clear()
        TextBox67.Clear()
        TextBox68.Clear()
        TextBox69.Clear()
        TextBox70.Clear()
        TextBox71.Clear()
        TextBox72.Clear()
        TextBox73.Clear()
        TextBox74.Clear()
        TextBox75.Clear()
        TextBox76.Clear()
        TextBox77.Clear()
        TextBox78.Clear()
        TextBox79.Clear()
        TextBox80.Clear()
        TextBox81.Clear()
        TextBox82.Clear()
        TextBox83.Clear()
        TextBox84.Clear()
        TextBox85.Clear()
        TextBox86.Clear()
        TextBox87.Clear()
        TextBox88.Clear()
        TextBox89.Clear()
        TextBox90.Clear()
        TextBox91.Clear()
        TextBox92.Clear()
        TextBox93.Clear()
        TextBox94.Clear()
        TextBox95.Clear()
        TextBox96.Clear()
        TextBox97.Clear()
        TextBox98.Clear()
        TextBox99.Clear()
        TextBox100.Clear()
        TextBox101.Clear()
        TextBox102.Clear()
        TextBox103.Clear()
        TextBox104.Clear()
        TextBox105.Clear()
        TextBox106.Clear()
        TextBox107.Clear()
        TextBox108.Clear()
        TextBox109.Clear()
        TextBox110.Clear()
        TextBox111.Clear()
        TextBox112.Clear()
        TextBox113.Clear()
        TextBox114.Clear()
        TextBox115.Clear()
        TextBox116.Clear()
        TextBox117.Clear()
        TextBox118.Clear()
        TextBox119.Clear()
        TextBox120.Clear()

    End Sub
End Class