Imports Solmicro.Expertis.Business.Negocio

Public Class frmNuevosDatos
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblFwiFechaEntrega As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFwiQPedida As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiNuevaFecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFwiNuevaFecha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFwiQPendiente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFwiQNueva As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiQNueva As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents FwiQPendiente As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents FwiQPedida As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents FwiFechaEntrega As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents btCambiar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents btCerrar As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.FwiQPedida = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.FwiQPendiente = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.FwiQNueva = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblFwiFechaEntrega = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiFechaEntrega = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFwiQPedida = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwiNuevaFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiNuevaFecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFwiQPendiente = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwiQNueva = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.btCambiar = New Solmicro.Expertis.Engine.UI.Button
        Me.btCerrar = New Solmicro.Expertis.Engine.UI.Button
        Me.Frame1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.FwiQPedida)
        Me.Frame1.Controls.Add(Me.FwiQPendiente)
        Me.Frame1.Controls.Add(Me.FwiQNueva)
        Me.Frame1.Controls.Add(Me.lblFwiFechaEntrega)
        Me.Frame1.Controls.Add(Me.FwiFechaEntrega)
        Me.Frame1.Controls.Add(Me.lblFwiQPedida)
        Me.Frame1.Controls.Add(Me.lblFwiNuevaFecha)
        Me.Frame1.Controls.Add(Me.FwiNuevaFecha)
        Me.Frame1.Controls.Add(Me.lblFwiQPendiente)
        Me.Frame1.Controls.Add(Me.lblFwiQNueva)
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(488, 173)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'FwiQPedida
        '
        Me.FwiQPedida.Enabled = False
        Me.FwiQPedida.Location = New System.Drawing.Point(368, 16)
        Me.FwiQPedida.Name = "FwiQPedida"
        Me.FwiQPedida.Size = New System.Drawing.Size(112, 21)
        Me.FwiQPedida.TabIndex = 15
        '
        'FwiQPendiente
        '
        Me.FwiQPendiente.Enabled = False
        Me.FwiQPendiente.Location = New System.Drawing.Point(368, 48)
        Me.FwiQPendiente.Name = "FwiQPendiente"
        Me.FwiQPendiente.Size = New System.Drawing.Size(112, 21)
        Me.FwiQPendiente.TabIndex = 14
        '
        'FwiQNueva
        '
        Me.FwiQNueva.Location = New System.Drawing.Point(368, 96)
        Me.FwiQNueva.Name = "FwiQNueva"
        Me.FwiQNueva.Size = New System.Drawing.Size(112, 21)
        Me.FwiQNueva.TabIndex = 13
        '
        'lblFwiFechaEntrega
        '
        Me.lblFwiFechaEntrega.Location = New System.Drawing.Point(8, 16)
        Me.lblFwiFechaEntrega.Name = "lblFwiFechaEntrega"
        Me.lblFwiFechaEntrega.Size = New System.Drawing.Size(86, 17)
        Me.lblFwiFechaEntrega.TabIndex = 8
        Me.lblFwiFechaEntrega.Text = "Fecha Entrega"
        '
        'FwiFechaEntrega
        '
        Me.FwiFechaEntrega.Enabled = False
        Me.FwiFechaEntrega.Location = New System.Drawing.Point(112, 16)
        Me.FwiFechaEntrega.Name = "FwiFechaEntrega"
        Me.FwiFechaEntrega.Size = New System.Drawing.Size(104, 21)
        Me.FwiFechaEntrega.TabIndex = 4
        '
        'lblFwiQPedida
        '
        Me.lblFwiQPedida.Location = New System.Drawing.Point(240, 16)
        Me.lblFwiQPedida.Name = "lblFwiQPedida"
        Me.lblFwiQPedida.Size = New System.Drawing.Size(101, 17)
        Me.lblFwiQPedida.TabIndex = 9
        Me.lblFwiQPedida.Text = "Cantidad Pedida:"
        '
        'lblFwiNuevaFecha
        '
        Me.lblFwiNuevaFecha.Location = New System.Drawing.Point(8, 96)
        Me.lblFwiNuevaFecha.Name = "lblFwiNuevaFecha"
        Me.lblFwiNuevaFecha.Size = New System.Drawing.Size(77, 17)
        Me.lblFwiNuevaFecha.TabIndex = 10
        Me.lblFwiNuevaFecha.Text = "Nueva Fecha"
        '
        'FwiNuevaFecha
        '
        Me.FwiNuevaFecha.Location = New System.Drawing.Point(112, 96)
        Me.FwiNuevaFecha.Name = "FwiNuevaFecha"
        Me.FwiNuevaFecha.Size = New System.Drawing.Size(104, 21)
        Me.FwiNuevaFecha.TabIndex = 2
        '
        'lblFwiQPendiente
        '
        Me.lblFwiQPendiente.Location = New System.Drawing.Point(240, 48)
        Me.lblFwiQPendiente.Name = "lblFwiQPendiente"
        Me.lblFwiQPendiente.Size = New System.Drawing.Size(120, 17)
        Me.lblFwiQPendiente.TabIndex = 11
        Me.lblFwiQPendiente.Text = "Cantidad Pendiente:"
        '
        'lblFwiQNueva
        '
        Me.lblFwiQNueva.Location = New System.Drawing.Point(240, 96)
        Me.lblFwiQNueva.Name = "lblFwiQNueva"
        Me.lblFwiQNueva.Size = New System.Drawing.Size(90, 17)
        Me.lblFwiQNueva.TabIndex = 12
        Me.lblFwiQNueva.Text = "NuevaCantidad"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btCambiar)
        Me.Panel1.Controls.Add(Me.btCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 125)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 48)
        Me.Panel1.TabIndex = 1
        '
        'btCambiar
        '
        Me.btCambiar.Location = New System.Drawing.Point(148, 8)
        Me.btCambiar.Name = "btCambiar"
        Me.btCambiar.Size = New System.Drawing.Size(92, 33)
        Me.btCambiar.TabIndex = 13
        Me.btCambiar.Text = "Aceptar"
        '
        'btCerrar
        '
        Me.btCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btCerrar.Location = New System.Drawing.Point(248, 8)
        Me.btCerrar.Name = "btCerrar"
        Me.btCerrar.Size = New System.Drawing.Size(92, 33)
        Me.btCerrar.TabIndex = 12
        Me.btCerrar.Text = "Cancelar"
        '
        'frmNuevosDatos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(488, 173)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Frame1)
        Me.Name = "frmNuevosDatos"
        Me.Text = "Cambio datos Disponible"
        Me.Frame1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Property FechaEntrega() As DateTime
        Get
            Return FwiFechaEntrega.Text
        End Get
        Set(ByVal Value As DateTime)
            FwiFechaEntrega.Text = Value
            FwiNuevaFecha.Value = Value
        End Set
    End Property
    Property QPedida() As Double
        Get
            Return FwiQPedida.Text
        End Get
        Set(ByVal Value As Double)
            FwiQPedida.Text = Value
        End Set
    End Property
    Property QPendiente() As Double
        Get
            Return FwiQPendiente.Text
        End Get
        Set(ByVal Value As Double)
            FwiQPendiente.Text = Value
        End Set
    End Property
    Private _IDLineaPedido As Double
    Property IDLineaPedido() As Double
        Get
            Return _IDLineaPedido
        End Get
        Set(ByVal Value As Double)
            _IDLineaPedido = Value
        End Set
    End Property

    Private Sub frmNuevosDatos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            FwiQNueva.Value = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCambiar.Click
        Try
            If IsNumeric(FwiQNueva.Value) And IsDate(FwiNuevaFecha.Value) Then
                Me.Cursor = Cursors.WaitCursor
                Dim dblQPendiente As Double
                Dim pvl As New PedidoVentaLinea
                pvl.CambiarDatosDisponible(_IDLineaPedido, FwiNuevaFecha.Value, FwiQNueva.Value, dblQPendiente)
                FwiQPendiente.Value = dblQPendiente

                Me.Cursor = Cursors.Default

                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                ExpertisApp.GenerateMessage("Debe introducir la nueva fecha y la nueva cantidad.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
