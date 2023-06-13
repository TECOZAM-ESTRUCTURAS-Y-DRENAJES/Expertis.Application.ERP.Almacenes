<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFechas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFechas))
        Me.btnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.btnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label4 = New Solmicro.Expertis.Engine.UI.Label
        Me.txtFamilia = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.cbFecha1 = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.txtalmacen = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Icon = CType(resources.GetObject("btnCancelar.Icon"), System.Drawing.Icon)
        Me.btnCancelar.Location = New System.Drawing.Point(179, 230)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(81, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Icon = CType(resources.GetObject("btnAceptar.Icon"), System.Drawing.Icon)
        Me.btnAceptar.Location = New System.Drawing.Point(81, 230)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(52, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Elija un mes y un año para cada familia"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(20, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Familia"
        '
        'txtFamilia
        '
        Me.txtFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.txtFamilia.Location = New System.Drawing.Point(84, 65)
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.Size = New System.Drawing.Size(129, 21)
        Me.txtFamilia.TabIndex = 2
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.cbFecha1)
        Me.Frame1.Controls.Add(Me.txtalmacen)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.txtFamilia)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Location = New System.Drawing.Point(44, 55)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(270, 153)
        Me.Frame1.TabIndex = 15
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Datos obligatorios"
        '
        'cbFecha1
        '
        Me.cbFecha1.DisabledBackColor = System.Drawing.Color.White
        Me.cbFecha1.Location = New System.Drawing.Point(84, 27)
        Me.cbFecha1.Name = "cbFecha1"
        Me.cbFecha1.Size = New System.Drawing.Size(129, 21)
        Me.cbFecha1.TabIndex = 1
        '
        'txtalmacen
        '
        Me.txtalmacen.DisabledBackColor = System.Drawing.Color.White
        Me.txtalmacen.Location = New System.Drawing.Point(84, 104)
        Me.txtalmacen.Name = "txtalmacen"
        Me.txtalmacen.Size = New System.Drawing.Size(129, 21)
        Me.txtalmacen.TabIndex = 3
        Me.txtalmacen.Text = "011"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Almacen"
        '
        'frmFechas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 288)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Name = "frmFechas"
        Me.Text = "frmFechas"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents btnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label4 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtFamilia As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents txtalmacen As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbFecha1 As Solmicro.Expertis.Engine.UI.CalendarBox
End Class
