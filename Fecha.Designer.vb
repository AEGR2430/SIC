<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fecha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fecha))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonConsultar = New System.Windows.Forms.Button()
        Me.ButtonInicio = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.cbPeriodo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OFDdb = New System.Windows.Forms.OpenFileDialog()
        Me.SICDataSet = New Sistema_de_infromación_climatológica.SICDataSet()
        Me.SICDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Datos = New System.Windows.Forms.DataGridView()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SICDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SICDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(156, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(269, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Sistema de Información Climatológica"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(129, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(320, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Dirección de Análisis y Previsión de Riesgos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Secretaría de Protección Civil"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonConsultar
        '
        Me.ButtonConsultar.Location = New System.Drawing.Point(17, 454)
        Me.ButtonConsultar.Name = "ButtonConsultar"
        Me.ButtonConsultar.Size = New System.Drawing.Size(135, 51)
        Me.ButtonConsultar.TabIndex = 13
        Me.ButtonConsultar.Text = "Consultar"
        Me.ButtonConsultar.UseVisualStyleBackColor = True
        '
        'ButtonInicio
        '
        Me.ButtonInicio.Location = New System.Drawing.Point(158, 454)
        Me.ButtonInicio.Name = "ButtonInicio"
        Me.ButtonInicio.Size = New System.Drawing.Size(135, 51)
        Me.ButtonInicio.TabIndex = 14
        Me.ButtonInicio.Text = "Inicio"
        Me.ButtonInicio.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(171, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 15)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Fecha final"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(172, 210)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(99, 20)
        Me.dtpFechaFinal.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 15)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Fecha de inicio"
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.CustomFormat = "dd/mm/yyyy"
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(15, 210)
        Me.dtpFechaInicial.MaxDate = New Date(2020, 3, 24, 0, 0, 0, 0)
        Me.dtpFechaInicial.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(114, 20)
        Me.dtpFechaInicial.TabIndex = 32
        Me.dtpFechaInicial.Value = New Date(2019, 4, 3, 0, 0, 0, 0)
        '
        'cbPeriodo
        '
        Me.cbPeriodo.BackColor = System.Drawing.Color.DarkCyan
        Me.cbPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPeriodo.FormattingEnabled = True
        Me.cbPeriodo.Items.AddRange(New Object() {"Fecha seleccionada", "Periodo de fechas"})
        Me.cbPeriodo.Location = New System.Drawing.Point(15, 157)
        Me.cbPeriodo.Name = "cbPeriodo"
        Me.cbPeriodo.Size = New System.Drawing.Size(128, 23)
        Me.cbPeriodo.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(222, 15)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Seleccione el periodo a consultar"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OFDdb
        '
        Me.OFDdb.FileName = "SIC"
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
        Me.Datos.Location = New System.Drawing.Point(3, 242)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(529, 206)
        Me.Datos.TabIndex = 36
        Me.Datos.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(470, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(124, 105)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 37
        Me.PictureBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(299, 454)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 51)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Mostrar todo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Fecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(606, 514)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Datos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtpFechaInicial)
        Me.Controls.Add(Me.cbPeriodo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonInicio)
        Me.Controls.Add(Me.ButtonConsultar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fecha"
        Me.Text = "Fecha"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SICDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SICDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonConsultar As Button
    Friend WithEvents ButtonInicio As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Protected WithEvents cbPeriodo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents OFDdb As OpenFileDialog
    Friend WithEvents SICDataSetBindingSource As BindingSource
    Friend WithEvents SICDataSet As SICDataSet
    Friend WithEvents Datos As DataGridView
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
End Class
