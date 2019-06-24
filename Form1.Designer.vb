<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBMesTemp = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TPTemp = New System.Windows.Forms.TabPage()
        Me.BtnGTemp = New System.Windows.Forms.Button()
        Me.NUDTempF = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NUDTemp = New System.Windows.Forms.NumericUpDown()
        Me.TPPcpn = New System.Windows.Forms.TabPage()
        Me.BtnGPcpn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NUDFPcpn = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbMesPcnp = New System.Windows.Forms.ComboBox()
        Me.NUDIPcpn = New System.Windows.Forms.NumericUpDown()
        Me.StdDesv = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Media = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TPTemp.SuspendLayout()
        CType(Me.NUDTempF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPPcpn.SuspendLayout()
        CType(Me.NUDFPcpn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDIPcpn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StdDesv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Media, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(883, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(31, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(83, 113)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 42
        Me.PictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(332, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(359, 24)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Sistema de Información Climatológica"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(345, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(320, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Dirección de Análisis y Previsión de Riesgos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(395, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(214, 16)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Secretaría de Protección Civil"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CBMesTemp
        '
        Me.CBMesTemp.FormattingEnabled = True
        Me.CBMesTemp.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.CBMesTemp.Location = New System.Drawing.Point(9, 35)
        Me.CBMesTemp.Name = "CBMesTemp"
        Me.CBMesTemp.Size = New System.Drawing.Size(121, 21)
        Me.CBMesTemp.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 15)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Seleccione el mes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 15)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Seleccione un rango de años"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TPTemp)
        Me.TabControl1.Controls.Add(Me.TPPcpn)
        Me.TabControl1.Location = New System.Drawing.Point(31, 141)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(228, 204)
        Me.TabControl1.TabIndex = 46
        '
        'TPTemp
        '
        Me.TPTemp.BackColor = System.Drawing.Color.GhostWhite
        Me.TPTemp.Controls.Add(Me.BtnGTemp)
        Me.TPTemp.Controls.Add(Me.NUDTempF)
        Me.TPTemp.Controls.Add(Me.Label6)
        Me.TPTemp.Controls.Add(Me.NUDTemp)
        Me.TPTemp.Controls.Add(Me.CBMesTemp)
        Me.TPTemp.Controls.Add(Me.Label5)
        Me.TPTemp.Controls.Add(Me.Label1)
        Me.TPTemp.Location = New System.Drawing.Point(4, 22)
        Me.TPTemp.Name = "TPTemp"
        Me.TPTemp.Padding = New System.Windows.Forms.Padding(3)
        Me.TPTemp.Size = New System.Drawing.Size(220, 178)
        Me.TPTemp.TabIndex = 0
        Me.TPTemp.Text = "Temperatura"
        '
        'BtnGTemp
        '
        Me.BtnGTemp.Location = New System.Drawing.Point(54, 107)
        Me.BtnGTemp.Name = "BtnGTemp"
        Me.BtnGTemp.Size = New System.Drawing.Size(113, 51)
        Me.BtnGTemp.TabIndex = 50
        Me.BtnGTemp.Text = "Graficar"
        Me.BtnGTemp.UseVisualStyleBackColor = True
        '
        'NUDTempF
        '
        Me.NUDTempF.Location = New System.Drawing.Point(109, 81)
        Me.NUDTempF.Maximum = New Decimal(New Integer() {2025, 0, 0, 0})
        Me.NUDTempF.Minimum = New Decimal(New Integer() {2010, 0, 0, 0})
        Me.NUDTempF.Name = "NUDTempF"
        Me.NUDTempF.Size = New System.Drawing.Size(58, 20)
        Me.NUDTempF.TabIndex = 49
        Me.NUDTempF.Value = New Decimal(New Integer() {2010, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(81, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 15)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "al"
        '
        'NUDTemp
        '
        Me.NUDTemp.Location = New System.Drawing.Point(12, 81)
        Me.NUDTemp.Maximum = New Decimal(New Integer() {2025, 0, 0, 0})
        Me.NUDTemp.Minimum = New Decimal(New Integer() {2010, 0, 0, 0})
        Me.NUDTemp.Name = "NUDTemp"
        Me.NUDTemp.Size = New System.Drawing.Size(58, 20)
        Me.NUDTemp.TabIndex = 48
        Me.NUDTemp.Value = New Decimal(New Integer() {2010, 0, 0, 0})
        '
        'TPPcpn
        '
        Me.TPPcpn.BackColor = System.Drawing.Color.MintCream
        Me.TPPcpn.Controls.Add(Me.BtnGPcpn)
        Me.TPPcpn.Controls.Add(Me.Label9)
        Me.TPPcpn.Controls.Add(Me.NUDFPcpn)
        Me.TPPcpn.Controls.Add(Me.Label8)
        Me.TPPcpn.Controls.Add(Me.Label7)
        Me.TPPcpn.Controls.Add(Me.CbMesPcnp)
        Me.TPPcpn.Controls.Add(Me.NUDIPcpn)
        Me.TPPcpn.Location = New System.Drawing.Point(4, 22)
        Me.TPPcpn.Name = "TPPcpn"
        Me.TPPcpn.Padding = New System.Windows.Forms.Padding(3)
        Me.TPPcpn.Size = New System.Drawing.Size(220, 178)
        Me.TPPcpn.TabIndex = 1
        Me.TPPcpn.Text = "Precipitación"
        '
        'BtnGPcpn
        '
        Me.BtnGPcpn.Location = New System.Drawing.Point(54, 107)
        Me.BtnGPcpn.Name = "BtnGPcpn"
        Me.BtnGPcpn.Size = New System.Drawing.Size(113, 51)
        Me.BtnGPcpn.TabIndex = 57
        Me.BtnGPcpn.Text = "Graficar"
        Me.BtnGPcpn.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 15)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Seleccione el mes"
        '
        'NUDFPcpn
        '
        Me.NUDFPcpn.Location = New System.Drawing.Point(109, 81)
        Me.NUDFPcpn.Maximum = New Decimal(New Integer() {2025, 0, 0, 0})
        Me.NUDFPcpn.Minimum = New Decimal(New Integer() {2010, 0, 0, 0})
        Me.NUDFPcpn.Name = "NUDFPcpn"
        Me.NUDFPcpn.Size = New System.Drawing.Size(58, 20)
        Me.NUDFPcpn.TabIndex = 56
        Me.NUDFPcpn.Value = New Decimal(New Integer() {2010, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(194, 15)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Seleccione un rango de años"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(81, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 15)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "al"
        '
        'CbMesPcnp
        '
        Me.CbMesPcnp.FormattingEnabled = True
        Me.CbMesPcnp.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.CbMesPcnp.Location = New System.Drawing.Point(9, 35)
        Me.CbMesPcnp.Name = "CbMesPcnp"
        Me.CbMesPcnp.Size = New System.Drawing.Size(121, 21)
        Me.CbMesPcnp.TabIndex = 51
        '
        'NUDIPcpn
        '
        Me.NUDIPcpn.Location = New System.Drawing.Point(12, 81)
        Me.NUDIPcpn.Maximum = New Decimal(New Integer() {2025, 0, 0, 0})
        Me.NUDIPcpn.Minimum = New Decimal(New Integer() {2010, 0, 0, 0})
        Me.NUDIPcpn.Name = "NUDIPcpn"
        Me.NUDIPcpn.Size = New System.Drawing.Size(58, 20)
        Me.NUDIPcpn.TabIndex = 55
        Me.NUDIPcpn.Value = New Decimal(New Integer() {2010, 0, 0, 0})
        '
        'StdDesv
        '
        ChartArea1.Name = "ChartArea1"
        Me.StdDesv.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.StdDesv.Legends.Add(Legend1)
        Me.StdDesv.Location = New System.Drawing.Point(378, 141)
        Me.StdDesv.Name = "StdDesv"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.StdDesv.Series.Add(Series1)
        Me.StdDesv.Size = New System.Drawing.Size(470, 160)
        Me.StdDesv.TabIndex = 47
        Me.StdDesv.Text = "Chart1"
        Title1.BackColor = System.Drawing.Color.LemonChiffon
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Desviación Estándar"
        Title1.Text = "Desviación Estándar"
        Me.StdDesv.Titles.Add(Title1)
        '
        'Media
        '
        ChartArea2.Name = "ChartArea1"
        Me.Media.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Media.Legends.Add(Legend2)
        Me.Media.Location = New System.Drawing.Point(378, 332)
        Me.Media.Name = "Media"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Media.Series.Add(Series2)
        Me.Media.Size = New System.Drawing.Size(470, 160)
        Me.Media.TabIndex = 48
        Me.Media.Text = "Chart2"
        Title2.BackColor = System.Drawing.Color.LemonChiffon
        Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.Name = "Title1"
        Title2.Text = "Media"
        Me.Media.Titles.Add(Title2)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 601)
        Me.Controls.Add(Me.Media)
        Me.Controls.Add(Me.StdDesv)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Form1"
        Me.Text = "Graficas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TPTemp.ResumeLayout(False)
        Me.TPTemp.PerformLayout()
        CType(Me.NUDTempF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDTemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPPcpn.ResumeLayout(False)
        Me.TPPcpn.PerformLayout()
        CType(Me.NUDFPcpn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDIPcpn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StdDesv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Media, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CBMesTemp As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TPTemp As TabPage
    Friend WithEvents BtnGTemp As Button
    Friend WithEvents NUDTempF As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents NUDTemp As NumericUpDown
    Friend WithEvents TPPcpn As TabPage
    Friend WithEvents BtnGPcpn As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents NUDFPcpn As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CbMesPcnp As ComboBox
    Friend WithEvents NUDIPcpn As NumericUpDown
    Friend WithEvents StdDesv As DataVisualization.Charting.Chart
    Friend WithEvents Media As DataVisualization.Charting.Chart
End Class
