<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFecha2
    Inherits Solmicro.Expertis.Engine.UI.FormBase

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFecha2))
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.cbFecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.btnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.btnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.cbFecha)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Location = New System.Drawing.Point(93, 69)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(270, 71)
        Me.Frame1.TabIndex = 19
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Datos obligatorios"
        '
        'cbFecha
        '
        Me.cbFecha.DisabledBackColor = System.Drawing.Color.White
        Me.cbFecha.Location = New System.Drawing.Point(84, 27)
        Me.cbFecha.Name = "cbFecha"
        Me.cbFecha.Size = New System.Drawing.Size(129, 21)
        Me.cbFecha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(21, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(430, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Seleccione el último día de cada mes para obtener el precio hasta ese día"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnAceptar
        '
        Me.btnAceptar.Icon = CType(resources.GetObject("btnAceptar.Icon"), System.Drawing.Icon)
        Me.btnAceptar.Location = New System.Drawing.Point(63, 163)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 16
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Icon = CType(resources.GetObject("btnCancelar.Icon"), System.Drawing.Icon)
        Me.btnCancelar.Location = New System.Drawing.Point(324, 163)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(81, 23)
        Me.btnCancelar.TabIndex = 17
        Me.btnCancelar.Text = "Cancelar"
        '
        'frmFecha2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 214)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Name = "frmFecha2"
        Me.Text = "Calcular precio para el siguiente mes"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents cbFecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents btnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents btnCancelar As Solmicro.Expertis.Engine.UI.Button
End Class
