<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SIC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SIC))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonConsultaEscacion = New System.Windows.Forms.Button()
        Me.ButtonConsultaFecha = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.InsertaDatos = New System.Windows.Forms.Button()
        Me.LoadBD = New System.Windows.Forms.Button()
        Me.OFDdb = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(199, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Secretaría de Protección Civil"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(149, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(320, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Dirección de Análisis y Previsión de Riesgos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(126, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(359, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sistema de Información Climatológica"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonConsultaEscacion
        '
        Me.ButtonConsultaEscacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonConsultaEscacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonConsultaEscacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonConsultaEscacion.FlatAppearance.BorderSize = 0
        Me.ButtonConsultaEscacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonConsultaEscacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConsultaEscacion.ForeColor = System.Drawing.Color.AliceBlue
        Me.ButtonConsultaEscacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonConsultaEscacion.Location = New System.Drawing.Point(12, 144)
        Me.ButtonConsultaEscacion.Name = "ButtonConsultaEscacion"
        Me.ButtonConsultaEscacion.Size = New System.Drawing.Size(110, 106)
        Me.ButtonConsultaEscacion.TabIndex = 6
        Me.ButtonConsultaEscacion.Text = "Consultar por estación"
        Me.ButtonConsultaEscacion.UseVisualStyleBackColor = False
        '
        'ButtonConsultaFecha
        '
        Me.ButtonConsultaFecha.BackColor = System.Drawing.Color.Transparent
        Me.ButtonConsultaFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonConsultaFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonConsultaFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonConsultaFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConsultaFecha.ForeColor = System.Drawing.Color.DarkBlue
        Me.ButtonConsultaFecha.Location = New System.Drawing.Point(143, 144)
        Me.ButtonConsultaFecha.Name = "ButtonConsultaFecha"
        Me.ButtonConsultaFecha.Size = New System.Drawing.Size(112, 106)
        Me.ButtonConsultaFecha.TabIndex = 7
        Me.ButtonConsultaFecha.Text = "Consultar registradas por Estado"
        Me.ButtonConsultaFecha.UseVisualStyleBackColor = False
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.Transparent
        Me.Salir.BackgroundImage = CType(resources.GetObject("Salir.BackgroundImage"), System.Drawing.Image)
        Me.Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.Location = New System.Drawing.Point(402, 145)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(104, 106)
        Me.Salir.TabIndex = 12
        Me.Salir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(502, 10)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(124, 105)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 38
        Me.PictureBox3.TabStop = False
        '
        'InsertaDatos
        '
        Me.InsertaDatos.BackColor = System.Drawing.Color.Transparent
        Me.InsertaDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InsertaDatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InsertaDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InsertaDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InsertaDatos.ForeColor = System.Drawing.Color.OrangeRed
        Me.InsertaDatos.Location = New System.Drawing.Point(275, 144)
        Me.InsertaDatos.Name = "InsertaDatos"
        Me.InsertaDatos.Size = New System.Drawing.Size(104, 106)
        Me.InsertaDatos.TabIndex = 39
        Me.InsertaDatos.Text = "Insertar en base de datos"
        Me.InsertaDatos.UseVisualStyleBackColor = False
        '
        'LoadBD
        '
        Me.LoadBD.BackColor = System.Drawing.Color.Transparent
        Me.LoadBD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LoadBD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoadBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadBD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadBD.ForeColor = System.Drawing.Color.Green
        Me.LoadBD.Location = New System.Drawing.Point(522, 145)
        Me.LoadBD.Name = "LoadBD"
        Me.LoadBD.Size = New System.Drawing.Size(104, 106)
        Me.LoadBD.TabIndex = 40
        Me.LoadBD.Text = "Cargar base de datos."
        Me.LoadBD.UseVisualStyleBackColor = False
        '
        'OFDdb
        '
        Me.OFDdb.FileName = "OFDdb"
        '
        'SIC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(638, 294)
        Me.Controls.Add(Me.LoadBD)
        Me.Controls.Add(Me.InsertaDatos)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.ButtonConsultaFecha)
        Me.Controls.Add(Me.ButtonConsultaEscacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SIC"
        Me.Text = "Sistema de Información Climatológica"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonConsultaEscacion As Button
    Friend WithEvents ButtonConsultaFecha As Button
    Friend WithEvents Salir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents InsertaDatos As Button
    Friend WithEvents LoadBD As Button
    Friend WithEvents OFDdb As OpenFileDialog
End Class
