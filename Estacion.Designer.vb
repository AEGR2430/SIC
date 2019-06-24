<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estacion
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estacion))
        Me.cbEstaciones = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonConsulta = New System.Windows.Forms.Button()
        Me.ButtonInicio = New System.Windows.Forms.Button()
        Me.ButtonGraficas = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.SICDataSet = New Sistema_de_infromación_climatológica.SICDataSet()
        Me.SICDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Datos = New System.Windows.Forms.DataGridView()
        Me.OFDdb = New System.Windows.Forms.OpenFileDialog()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.btnConsultaPeriodo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CbPeriodos = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SICDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SICDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbEstaciones
        '
        Me.cbEstaciones.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbEstaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstaciones.FormattingEnabled = True
        Me.cbEstaciones.Items.AddRange(New Object() {"Campeche Observatorio", "Bolonchen", "Campeche UAC", "Candelaria", "Carmen", "Champotón", "Escárcega", "Hecelchakán", "Hopelchén", "Noh-Yaxché", "Palizada", "Sabancuy", "Xcupil", "Xpujil", "Canasayab"})
        Me.cbEstaciones.Location = New System.Drawing.Point(15, 136)
        Me.cbEstaciones.Name = "cbEstaciones"
        Me.cbEstaciones.Size = New System.Drawing.Size(173, 23)
        Me.cbEstaciones.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione la estación a consultar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(200, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(359, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Sistema de Información Climatológica"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(214, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(320, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Dirección de Análisis y Previsión de Riesgos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(264, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(214, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Secretaría de Protección Civil"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonConsulta
        '
        Me.ButtonConsulta.Location = New System.Drawing.Point(204, 435)
        Me.ButtonConsulta.Name = "ButtonConsulta"
        Me.ButtonConsulta.Size = New System.Drawing.Size(89, 42)
        Me.ButtonConsulta.TabIndex = 10
        Me.ButtonConsulta.Text = "Consultar día"
        Me.ButtonConsulta.UseVisualStyleBackColor = True
        '
        'ButtonInicio
        '
        Me.ButtonInicio.Location = New System.Drawing.Point(14, 435)
        Me.ButtonInicio.Name = "ButtonInicio"
        Me.ButtonInicio.Size = New System.Drawing.Size(89, 42)
        Me.ButtonInicio.TabIndex = 11
        Me.ButtonInicio.Text = "Inicio"
        Me.ButtonInicio.UseVisualStyleBackColor = True
        '
        'ButtonGraficas
        '
        Me.ButtonGraficas.Location = New System.Drawing.Point(109, 435)
        Me.ButtonGraficas.Name = "ButtonGraficas"
        Me.ButtonGraficas.Size = New System.Drawing.Size(89, 42)
        Me.ButtonGraficas.TabIndex = 12
        Me.ButtonGraficas.Text = "Graficar"
        Me.ButtonGraficas.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(341, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(222, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Seleccione el periodo a consultar"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(32, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(83, 113)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'SICDataSet
        '
        Me.SICDataSet.DataSetName = "SICDataSet"
        Me.SICDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SICDataSetBindingSource
        '
        Me.SICDataSetBindingSource.DataSource = Me.SICDataSet
        Me.SICDataSetBindingSource.Position = 0
        '
        'Datos
        '
        Me.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datos.Location = New System.Drawing.Point(9, 224)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(708, 205)
        Me.Datos.TabIndex = 23
        Me.Datos.Visible = False
        '
        'OFDdb
        '
        Me.OFDdb.FileName = "OFDbd"
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtpFechaInicial.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(15, 189)
        Me.dtpFechaInicial.MaxDate = New Date(2020, 3, 24, 0, 0, 0, 0)
        Me.dtpFechaInicial.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(114, 20)
        Me.dtpFechaInicial.TabIndex = 24
        Me.dtpFechaInicial.Value = New Date(2019, 4, 3, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 15)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Fecha de inicio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(171, 171)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 15)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Fecha final"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(172, 189)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(99, 20)
        Me.dtpFechaFinal.TabIndex = 26
        '
        'btnConsultaPeriodo
        '
        Me.btnConsultaPeriodo.Location = New System.Drawing.Point(299, 435)
        Me.btnConsultaPeriodo.Name = "btnConsultaPeriodo"
        Me.btnConsultaPeriodo.Size = New System.Drawing.Size(89, 42)
        Me.btnConsultaPeriodo.TabIndex = 28
        Me.btnConsultaPeriodo.Text = "Consultar periodo"
        Me.btnConsultaPeriodo.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(593, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'CbPeriodos
        '
        Me.CbPeriodos.FormattingEnabled = True
        Me.CbPeriodos.Items.AddRange(New Object() {"Fecha seleccionada", "Periodo de fechas"})
        Me.CbPeriodos.Location = New System.Drawing.Point(344, 138)
        Me.CbPeriodos.Name = "CbPeriodos"
        Me.CbPeriodos.Size = New System.Drawing.Size(190, 21)
        Me.CbPeriodos.TabIndex = 39
        '
        'Estacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(729, 489)
        Me.Controls.Add(Me.CbPeriodos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnConsultaPeriodo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtpFechaInicial)
        Me.Controls.Add(Me.Datos)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonGraficas)
        Me.Controls.Add(Me.ButtonInicio)
        Me.Controls.Add(Me.ButtonConsulta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbEstaciones)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Estacion"
        Me.Text = "Estacion"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SICDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SICDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonConsulta As Button
    Friend WithEvents ButtonInicio As Button
    Friend WithEvents ButtonGraficas As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents cbMes As ComboBox
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbDia As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents SICDataSetBindingSource As BindingSource
    Friend WithEvents SICDataSet As SICDataSet
    Friend WithEvents Datos As DataGridView
    Friend WithEvents OFDdb As OpenFileDialog
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents btnConsultaPeriodo As Button
    Protected WithEvents cbEstaciones As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CbPeriodos As ComboBox
End Class
