<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteCalculoAction
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.btnGenerarCalculo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(132, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Fecha fin"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.CustomFormat = "dd-MM-yyyy"
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFin.Location = New System.Drawing.Point(135, 86)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(87, 20)
        Me.dtpFechaFin.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Fecha inicio"
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.CustomFormat = "dd-MM-yyyy"
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaIni.Location = New System.Drawing.Point(31, 86)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(87, 20)
        Me.dtpFechaIni.TabIndex = 15
        '
        'btnGenerarCalculo
        '
        Me.btnGenerarCalculo.Location = New System.Drawing.Point(82, 132)
        Me.btnGenerarCalculo.Name = "btnGenerarCalculo"
        Me.btnGenerarCalculo.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerarCalculo.TabIndex = 19
        Me.btnGenerarCalculo.Text = "Generar"
        Me.btnGenerarCalculo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 214)
        Me.Controls.Add(Me.btnGenerarCalculo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpFechaIni)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFechaIni As DateTimePicker
    Friend WithEvents btnGenerarCalculo As Button
End Class
