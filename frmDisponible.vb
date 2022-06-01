Imports Solmicro.Expertis.Business.Produccion
Imports Solmicro.Expertis.Business.BusinessEnum

Public Class frmDisponible
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
    Friend WithEvents lblFwiDispTeorico As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Line1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblFwiTotOFs As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFwiTotDisponible As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFwiQPendiente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFwiStock As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiStock As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents fwiQPendiente As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents fwiTotDisponible As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents fwiTotOFs As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents fwiDispTeorico As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents jngDisponible As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.fwiDispTeorico = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.fwiTotOFs = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.fwiTotDisponible = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.fwiQPendiente = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.fwiStock = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblFwiDispTeorico = New Solmicro.Expertis.Engine.UI.Label
        Me.Line1 = New Janus.Windows.EditControls.UIGroupBox
        Me.lblFwiTotOFs = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwiTotDisponible = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwiQPendiente = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwiStock = New Solmicro.Expertis.Engine.UI.Label
        Me.jngDisponible = New Solmicro.Expertis.Engine.UI.Grid
        Me.Frame1.SuspendLayout()
        CType(Me.Line1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jngDisponible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.fwiDispTeorico)
        Me.Frame1.Controls.Add(Me.fwiTotOFs)
        Me.Frame1.Controls.Add(Me.fwiTotDisponible)
        Me.Frame1.Controls.Add(Me.fwiQPendiente)
        Me.Frame1.Controls.Add(Me.fwiStock)
        Me.Frame1.Controls.Add(Me.lblFwiDispTeorico)
        Me.Frame1.Controls.Add(Me.Line1)
        Me.Frame1.Controls.Add(Me.lblFwiTotOFs)
        Me.Frame1.Controls.Add(Me.lblFwiTotDisponible)
        Me.Frame1.Controls.Add(Me.lblFwiQPendiente)
        Me.Frame1.Controls.Add(Me.lblFwiStock)
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Frame1.Location = New System.Drawing.Point(0, 205)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(560, 104)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'fwiDispTeorico
        '
        Me.fwiDispTeorico.Enabled = False
        Me.fwiDispTeorico.Location = New System.Drawing.Point(416, 72)
        Me.fwiDispTeorico.Name = "fwiDispTeorico"
        Me.fwiDispTeorico.Size = New System.Drawing.Size(128, 21)
        Me.fwiDispTeorico.TabIndex = 17
        '
        'fwiTotOFs
        '
        Me.fwiTotOFs.Enabled = False
        Me.fwiTotOFs.Location = New System.Drawing.Point(416, 40)
        Me.fwiTotOFs.Name = "fwiTotOFs"
        Me.fwiTotOFs.Size = New System.Drawing.Size(128, 21)
        Me.fwiTotOFs.TabIndex = 16
        '
        'fwiTotDisponible
        '
        Me.fwiTotDisponible.Enabled = False
        Me.fwiTotDisponible.Location = New System.Drawing.Point(416, 16)
        Me.fwiTotDisponible.Name = "fwiTotDisponible"
        Me.fwiTotDisponible.Size = New System.Drawing.Size(128, 21)
        Me.fwiTotDisponible.TabIndex = 15
        '
        'fwiQPendiente
        '
        Me.fwiQPendiente.Enabled = False
        Me.fwiQPendiente.Location = New System.Drawing.Point(104, 40)
        Me.fwiQPendiente.Name = "fwiQPendiente"
        Me.fwiQPendiente.Size = New System.Drawing.Size(128, 21)
        Me.fwiQPendiente.TabIndex = 14
        '
        'fwiStock
        '
        Me.fwiStock.Enabled = False
        Me.fwiStock.Location = New System.Drawing.Point(104, 16)
        Me.fwiStock.Name = "fwiStock"
        Me.fwiStock.Size = New System.Drawing.Size(128, 21)
        Me.fwiStock.TabIndex = 13
        '
        'lblFwiDispTeorico
        '
        Me.lblFwiDispTeorico.Location = New System.Drawing.Point(288, 74)
        Me.lblFwiDispTeorico.Name = "lblFwiDispTeorico"
        Me.lblFwiDispTeorico.Size = New System.Drawing.Size(93, 17)
        Me.lblFwiDispTeorico.TabIndex = 0
        Me.lblFwiDispTeorico.Text = "DISP. TEORICO"
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(272, 64)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(280, 3)
        Me.Line1.TabIndex = 7
        '
        'lblFwiTotOFs
        '
        Me.lblFwiTotOFs.Location = New System.Drawing.Point(288, 42)
        Me.lblFwiTotOFs.Name = "lblFwiTotOFs"
        Me.lblFwiTotOFs.Size = New System.Drawing.Size(68, 17)
        Me.lblFwiTotOFs.TabIndex = 8
        Me.lblFwiTotOFs.Text = "TOTAL OFS"
        '
        'lblFwiTotDisponible
        '
        Me.lblFwiTotDisponible.Location = New System.Drawing.Point(288, 18)
        Me.lblFwiTotDisponible.Name = "lblFwiTotDisponible"
        Me.lblFwiTotDisponible.Size = New System.Drawing.Size(117, 17)
        Me.lblFwiTotDisponible.TabIndex = 9
        Me.lblFwiTotDisponible.Text = "TOTAL DISPONIBLE"
        '
        'lblFwiQPendiente
        '
        Me.lblFwiQPendiente.Location = New System.Drawing.Point(24, 42)
        Me.lblFwiQPendiente.Name = "lblFwiQPendiente"
        Me.lblFwiQPendiente.Size = New System.Drawing.Size(70, 17)
        Me.lblFwiQPendiente.TabIndex = 10
        Me.lblFwiQPendiente.Text = "PENDIENTE"
        '
        'lblFwiStock
        '
        Me.lblFwiStock.Location = New System.Drawing.Point(24, 18)
        Me.lblFwiStock.Name = "lblFwiStock"
        Me.lblFwiStock.Size = New System.Drawing.Size(44, 17)
        Me.lblFwiStock.TabIndex = 11
        Me.lblFwiStock.Text = "STOCK"
        '
        'jngDisponible
        '
        Me.jngDisponible.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
        Me.jngDisponible.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False
        Me.jngDisponible.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""FechaEntrega" & _
        """><Caption>Fecha</Caption><DataMember>FechaEntrega</DataMember><EditTarget>Text<" & _
        "/EditTarget><FormatString>dd/MM/yy</FormatString><Key>FechaEntrega</Key><Positio" & _
        "n>0</Position><TextAlignment>Near</TextAlignment><Width>67</Width></Column0><Col" & _
        "umn1 ID=""IDArticulo""><Caption>Articulo</Caption><DataMember>IDArticulo</DataMemb" & _
        "er><Key>IDArticulo</Key><Position>1</Position><TextAlignment>Near</TextAlignment" & _
        "></Column1><Column2 ID=""IDCliente""><Caption>IDCliente</Caption><DataMember>IDCli" & _
        "ente</DataMember><Key>IDCliente</Key><Position>2</Position><TextAlignment>Near</" & _
        "TextAlignment><Width>67</Width></Column2><Column3 ID=""DescCliente""><Caption>Clie" & _
        "nte</Caption><DataMember>DescCliente</DataMember><Key>DescCliente</Key><Position" & _
        ">3</Position><TextAlignment>Near</TextAlignment></Column3><Column4 ID=""IDPedido""" & _
        "><Caption>Núm Pedido</Caption><DataMember>IDPedido</DataMember><Key>IDPedido</Ke" & _
        "y><Position>4</Position><TextAlignment>Far</TextAlignment><Width>67</Width></Col" & _
        "umn4><Column5 ID=""QPendiente""><Caption>Pendiente</Caption><DataMember>QPendiente" & _
        "</DataMember><EditTarget>Text</EditTarget><FormatString>#,0.0#######</FormatStri" & _
        "ng><Key>QPendiente</Key><Position>5</Position><TextAlignment>Far</TextAlignment>" & _
        "<Width>47</Width></Column5><Column6 ID=""IdAlmacen""><Caption>Almacen</Caption><Da" & _
        "taMember>IdAlmacen</DataMember><Key>IdAlmacen</Key><Position>6</Position><TextAl" & _
        "ignment>Near</TextAlignment><Visible>False</Visible><Width>33</Width></Column6><" & _
        "Column7 ID=""QDisponible""><Caption>Disponible</Caption><DataMember>QDisponible</D" & _
        "ataMember><EditTarget>Text</EditTarget><FormatString>#,0.0#######</FormatString>" & _
        "<Key>QDisponible</Key><Position>7</Position><TextAlignment>Far</TextAlignment><W" & _
        "idth>57</Width></Column7><Column8 ID=""QEnFabrica""><Caption>En Fabrica</Caption><" & _
        "DataMember>QEnFabrica</DataMember><EditTarget>Text</EditTarget><FormatString>#,0" & _
        ".0#######</FormatString><Key>QEnFabrica</Key><Position>8</Position><TextAlignmen" & _
        "t>Far</TextAlignment></Column8><Column9 ID=""QPedida""><Caption>QPedida</Caption><" & _
        "DataMember>QPedida</DataMember><EditTarget>Text</EditTarget><FormatString>#,0.0#" & _
        "######</FormatString><Key>QPedida</Key><Position>9</Position><TextAlignment>Far<" & _
        "/TextAlignment><Visible>False</Visible></Column9><Column10 ID=""IdLineaPedido""><C" & _
        "aption>IdLineaPedido</Caption><DataMember>IdLineaPedido</DataMember><Key>IdLinea" & _
        "Pedido</Key><Position>10</Position><TextAlignment>Near</TextAlignment><Visible>F" & _
        "alse</Visible></Column10></Columns><GroupCondition ID="""" /><SortKeys Collection=" & _
        """true""><SortKey0 ID=""SortKey0""><ColIndex>0</ColIndex></SortKey0></SortKeys></Roo" & _
        "tTable></GridEXLayoutData>"
        Me.jngDisponible.DesignTimeLayout = GridEXLayout1
        Me.jngDisponible.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngDisponible.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.jngDisponible.EntityName = "PedidoVentaLinea"
        Me.jngDisponible.Location = New System.Drawing.Point(0, 0)
        Me.jngDisponible.Name = "jngDisponible"
        Me.jngDisponible.PrimaryDataFields = "IDArticulo"
        Me.jngDisponible.SecondaryDataFields = "IDArticulo"
        Me.jngDisponible.Size = New System.Drawing.Size(560, 205)
        Me.jngDisponible.TabIndex = 2
        Me.jngDisponible.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngDisponible.ViewName = "VCtlDisponible"
        '
        'frmDisponible
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(560, 309)
        Me.Controls.Add(Me.jngDisponible)
        Me.Controls.Add(Me.Frame1)
        Me.EntityName = "PedidoVentaLinea"
        Me.Name = "frmDisponible"
        Me.NavigationFields = "IDArticulo"
        Me.Text = "Disponible"
        Me.ViewName = "VCtlDisponible"
        Me.Frame1.ResumeLayout(False)
        CType(Me.Line1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jngDisponible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private blnImporteCambiado As Boolean
    Private blnGrabado As Boolean
    Private blnClave As Boolean

    Dim _IDArticulo As String
    Property IDArticulo() As String
        Get
            Return _IDArticulo
        End Get
        Set(ByVal Value As String)
            _IDArticulo = Value
        End Set
    End Property
    Dim _IDAlmacen As String
    Property IDAlmacen() As String
        Get
            Return _IDAlmacen
        End Get
        Set(ByVal Value As String)
            _IDAlmacen = Value
        End Set
    End Property

    Private Sub frmDisponible_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CalcularDispTeorico()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub jngDisponible_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles jngDisponible.RowDoubleClick
        Try
            With jngDisponible
                If .CurrentColumn.Index = .Columns("FechaEntrega").Index Then
                    Dim frm As New frmNuevosDatos
                    frm.FechaEntrega = .GetValue("FechaEntrega")
                    frm.QPedida = .GetValue("QPedida")
                    frm.QPendiente = .GetValue("QPendiente")
                    frm.IDLineaPedido = .GetValue("IDLineaPedido")
                    frm.ShowDialog()

                    If frm.DialogResult = DialogResult.OK Then
                        Me.GotoRecord(DataProviderActions.Update)
                        CalcularDispTeorico()
                    End If

                    frm.Dispose()
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub CalcularDispTeorico()
        Try
            Dim dtGrid As DataTable = jngDisponible.DataSource
            If Not dtGrid Is Nothing AndAlso dtGrid.Rows.Count > 0 Then
                Dim dblTotOFs As Double

                ' Se calcula el total OFS
                Dim ofa As New OrdenFabricacion
                Dim f As New Filter
                f.Add(New StringFilterItem("IDArticulo", FilterOperator.Equal, _IDArticulo))
                f.Add(New StringFilterItem("IDAlmacen", FilterOperator.Equal, _IDAlmacen))
                f.Add(New NumberFilterItem("Estado", FilterOperator.NotEqual, enumofEstado.ofeTerminada))
                f.Add(New NumberFilterItem("Estado", FilterOperator.NotEqual, enumofEstado.ofeOfAnulada))
                'strWhere = strWhere & " AND Estado <> 4 AND Estado <> 5"
                Dim dtOF As DataTable = ofa.Filter(f)

                If Not dtOF Is Nothing AndAlso dtOF.Rows.Count Then
                    For Each drOF As DataRow In dtOF.Rows
                        dblTotOFs = dblTotOFs + drOF("QFabricar") - drOF("QFabricada")
                    Next
                    fwiTotOFs.Value = dblTotOFs
                End If

                fwiQPendiente.Value = jngDisponible.GetTotal(jngDisponible.Columns("QPendiente"), AggregateFunction.Sum)

                fwiTotDisponible.Value = dtGrid.Rows(0)("QDisponible") - dtGrid.Rows(0)("QPendiente")
                fwiDispTeorico.Value = dblTotOFs + dtGrid.Rows(0)("QDisponible") - dtGrid.Rows(0)("QPendiente")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
