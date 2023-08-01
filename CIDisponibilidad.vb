Imports Solmicro.Expertis.Business.ClasesTecozam
Imports OfficeOpenXml
Imports System.IO
Imports Solmicro.Expertis.Engine

Public Class CIDisponibilidad
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        FwiPendiente.Value = System.DBNull.Value
        FwiDisponibleMayor.Value = System.DBNull.Value
        FwiDisponibleMenorIg.Value = System.DBNull.Value
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
    Friend WithEvents lblFwiPendiente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiIDArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFwiIDArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcFwiIDArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents LblFamliliaArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ULblDescFamilia As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents AdvFamiliaArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblTipoArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ULblDescTipo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents AdvTipoArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents FwiDisponibleMayor As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblFwiDisponibleMayor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiDisponibleMenorIg As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblFwiDisponibleMenorIg As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents LblArticuloPadre As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ULblDescSubfamilia As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents AdvSubFamiliaArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiPendiente As Solmicro.Expertis.Engine.UI.NumericTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIDisponibilidad))
        Me.lblFwiPendiente = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiIDArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblcFwiIDArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblFwiIDArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiPendiente = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblTipoArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.ULblDescTipo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvTipoArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblFamliliaArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.ULblDescFamilia = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvFamiliaArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FwiDisponibleMayor = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblFwiDisponibleMayor = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiDisponibleMenorIg = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblFwiDisponibleMenorIg = New Solmicro.Expertis.Engine.UI.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.LblArticuloPadre = New Solmicro.Expertis.Engine.UI.Label
        Me.ULblDescSubfamilia = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvSubFamiliaArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.AdvAlmacen)
        Me.FilterPanel.Controls.Add(Me.lblAlmacen)
        Me.FilterPanel.Controls.Add(Me.LblArticuloPadre)
        Me.FilterPanel.Controls.Add(Me.ULblDescSubfamilia)
        Me.FilterPanel.Controls.Add(Me.AdvSubFamiliaArticulo)
        Me.FilterPanel.Controls.Add(Me.FwiDisponibleMenorIg)
        Me.FilterPanel.Controls.Add(Me.lblFwiDisponibleMenorIg)
        Me.FilterPanel.Controls.Add(Me.FwiDisponibleMayor)
        Me.FilterPanel.Controls.Add(Me.lblFwiDisponibleMayor)
        Me.FilterPanel.Controls.Add(Me.LblFamliliaArticulo)
        Me.FilterPanel.Controls.Add(Me.ULblDescFamilia)
        Me.FilterPanel.Controls.Add(Me.AdvFamiliaArticulo)
        Me.FilterPanel.Controls.Add(Me.LblTipoArticulo)
        Me.FilterPanel.Controls.Add(Me.ULblDescTipo)
        Me.FilterPanel.Controls.Add(Me.AdvTipoArticulo)
        Me.FilterPanel.Controls.Add(Me.FwiPendiente)
        Me.FilterPanel.Controls.Add(Me.lblFwiPendiente)
        Me.FilterPanel.Controls.Add(Me.lblFwiIDArticulo)
        Me.FilterPanel.Controls.Add(Me.lblcFwiIDArticulo)
        Me.FilterPanel.Controls.Add(Me.FwiIDArticulo)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 281)
        Me.FilterPanel.Size = New System.Drawing.Size(688, 140)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(688, 281)
        '
        'Grid
        '
        Grid_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_0.Instance"), Object)
        Grid_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {Grid_DesignTimeLayout_Reference_0})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "PedidoVentaLinea"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.ImageList = Me.ImageList1
        Me.Grid.KeyField = "IDLineaPedido"
        Me.Grid.Size = New System.Drawing.Size(688, 281)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "VCtlConsDisponibilidad"
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'ClearFilter
        '
        Me.ClearFilter.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Export
        '
        Me.Export.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(245, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(688, 421)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(688, 421)
        '
        'lblFwiPendiente
        '
        Me.lblFwiPendiente.Location = New System.Drawing.Point(506, 24)
        Me.lblFwiPendiente.Name = "lblFwiPendiente"
        Me.lblFwiPendiente.Size = New System.Drawing.Size(76, 13)
        Me.lblFwiPendiente.TabIndex = 0
        Me.lblFwiPendiente.Text = "Pendiente >"
        '
        'FwiIDArticulo
        '
        Me.FwiIDArticulo.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescArticulo", lblcFwiIDArticulo)})
        Me.FwiIDArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.FwiIDArticulo.EntityName = "Articulo"
        Me.FwiIDArticulo.Location = New System.Drawing.Point(80, 26)
        Me.FwiIDArticulo.Name = "FwiIDArticulo"
        Me.FwiIDArticulo.SecondaryDataFields = "IDArticulo"
        Me.FwiIDArticulo.Size = New System.Drawing.Size(136, 23)
        Me.FwiIDArticulo.TabIndex = 2
        '
        'lblcFwiIDArticulo
        '
        Me.lblcFwiIDArticulo.Location = New System.Drawing.Point(224, 26)
        Me.lblcFwiIDArticulo.Name = "lblcFwiIDArticulo"
        Me.lblcFwiIDArticulo.Size = New System.Drawing.Size(278, 24)
        Me.lblcFwiIDArticulo.TabIndex = 5
        '
        'lblFwiIDArticulo
        '
        Me.lblFwiIDArticulo.Location = New System.Drawing.Point(9, 28)
        Me.lblFwiIDArticulo.Name = "lblFwiIDArticulo"
        Me.lblFwiIDArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblFwiIDArticulo.TabIndex = 4
        Me.lblFwiIDArticulo.Text = "Artículo"
        '
        'FwiPendiente
        '
        Me.FwiPendiente.DisabledBackColor = System.Drawing.Color.White
        Me.FwiPendiente.Location = New System.Drawing.Point(592, 24)
        Me.FwiPendiente.Name = "FwiPendiente"
        Me.FwiPendiente.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.FwiPendiente.Size = New System.Drawing.Size(88, 21)
        Me.FwiPendiente.TabIndex = 6
        '
        'LblTipoArticulo
        '
        Me.LblTipoArticulo.Location = New System.Drawing.Point(9, 57)
        Me.LblTipoArticulo.Name = "LblTipoArticulo"
        Me.LblTipoArticulo.Size = New System.Drawing.Size(31, 13)
        Me.LblTipoArticulo.TabIndex = 8
        Me.LblTipoArticulo.Text = "Tipo"
        '
        'ULblDescTipo
        '
        Me.ULblDescTipo.Location = New System.Drawing.Point(224, 52)
        Me.ULblDescTipo.Name = "ULblDescTipo"
        Me.ULblDescTipo.Size = New System.Drawing.Size(278, 24)
        Me.ULblDescTipo.TabIndex = 9
        '
        'AdvTipoArticulo
        '
        Me.AdvTipoArticulo.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescTipo", ULblDescTipo)})
        Me.AdvTipoArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipoArticulo.EntityName = "TipoArticulo"
        Me.AdvTipoArticulo.Location = New System.Drawing.Point(80, 52)
        Me.AdvTipoArticulo.Name = "AdvTipoArticulo"
        Me.AdvTipoArticulo.SecondaryDataFields = "IDTipo"
        Me.AdvTipoArticulo.Size = New System.Drawing.Size(136, 23)
        Me.AdvTipoArticulo.TabIndex = 3
        '
        'LblFamliliaArticulo
        '
        Me.LblFamliliaArticulo.Location = New System.Drawing.Point(9, 83)
        Me.LblFamliliaArticulo.Name = "LblFamliliaArticulo"
        Me.LblFamliliaArticulo.Size = New System.Drawing.Size(46, 13)
        Me.LblFamliliaArticulo.TabIndex = 11
        Me.LblFamliliaArticulo.Text = "Familia"
        '
        'ULblDescFamilia
        '
        Me.ULblDescFamilia.Location = New System.Drawing.Point(224, 78)
        Me.ULblDescFamilia.Name = "ULblDescFamilia"
        Me.ULblDescFamilia.Size = New System.Drawing.Size(278, 24)
        Me.ULblDescFamilia.TabIndex = 12
        '
        'AdvFamiliaArticulo
        '
        Me.AdvFamiliaArticulo.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescFamilia", ULblDescFamilia)})
        Me.AdvFamiliaArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFamiliaArticulo.EntityName = "Familia"
        Me.AdvFamiliaArticulo.Location = New System.Drawing.Point(80, 78)
        Me.AdvFamiliaArticulo.Name = "AdvFamiliaArticulo"
        Me.AdvFamiliaArticulo.SecondaryDataFields = "IDFamilia"
        Me.AdvFamiliaArticulo.Size = New System.Drawing.Size(136, 23)
        Me.AdvFamiliaArticulo.TabIndex = 4
        '
        'FwiDisponibleMayor
        '
        Me.FwiDisponibleMayor.DisabledBackColor = System.Drawing.Color.White
        Me.FwiDisponibleMayor.Location = New System.Drawing.Point(592, 51)
        Me.FwiDisponibleMayor.Name = "FwiDisponibleMayor"
        Me.FwiDisponibleMayor.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.FwiDisponibleMayor.Size = New System.Drawing.Size(88, 21)
        Me.FwiDisponibleMayor.TabIndex = 7
        '
        'lblFwiDisponibleMayor
        '
        Me.lblFwiDisponibleMayor.Location = New System.Drawing.Point(506, 51)
        Me.lblFwiDisponibleMayor.Name = "lblFwiDisponibleMayor"
        Me.lblFwiDisponibleMayor.Size = New System.Drawing.Size(79, 13)
        Me.lblFwiDisponibleMayor.TabIndex = 13
        Me.lblFwiDisponibleMayor.Text = "Disponible >"
        '
        'FwiDisponibleMenorIg
        '
        Me.FwiDisponibleMenorIg.DisabledBackColor = System.Drawing.Color.White
        Me.FwiDisponibleMenorIg.Location = New System.Drawing.Point(592, 78)
        Me.FwiDisponibleMenorIg.Name = "FwiDisponibleMenorIg"
        Me.FwiDisponibleMenorIg.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.FwiDisponibleMenorIg.Size = New System.Drawing.Size(88, 21)
        Me.FwiDisponibleMenorIg.TabIndex = 8
        '
        'lblFwiDisponibleMenorIg
        '
        Me.lblFwiDisponibleMenorIg.Location = New System.Drawing.Point(506, 78)
        Me.lblFwiDisponibleMenorIg.Name = "lblFwiDisponibleMenorIg"
        Me.lblFwiDisponibleMenorIg.Size = New System.Drawing.Size(88, 13)
        Me.lblFwiDisponibleMenorIg.TabIndex = 15
        Me.lblFwiDisponibleMenorIg.Text = "Disponible <="
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "xDisponibilidad.ico")
        '
        'LblArticuloPadre
        '
        Me.LblArticuloPadre.Location = New System.Drawing.Point(9, 107)
        Me.LblArticuloPadre.Name = "LblArticuloPadre"
        Me.LblArticuloPadre.Size = New System.Drawing.Size(67, 13)
        Me.LblArticuloPadre.TabIndex = 17
        Me.LblArticuloPadre.Text = "Subfamilia"
        '
        'ULblDescSubfamilia
        '
        Me.ULblDescSubfamilia.Location = New System.Drawing.Point(224, 105)
        Me.ULblDescSubfamilia.Name = "ULblDescSubfamilia"
        Me.ULblDescSubfamilia.Size = New System.Drawing.Size(278, 24)
        Me.ULblDescSubfamilia.TabIndex = 18
        '
        'AdvSubFamiliaArticulo
        '
        Me.AdvSubFamiliaArticulo.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescSubfamilia", ULblDescSubfamilia)})
        Me.AdvSubFamiliaArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvSubFamiliaArticulo.EntityName = "Subfamilia"
        Me.AdvSubFamiliaArticulo.Location = New System.Drawing.Point(80, 105)
        Me.AdvSubFamiliaArticulo.Name = "AdvSubFamiliaArticulo"
        Me.AdvSubFamiliaArticulo.SecondaryDataFields = "IDSubfamilia"
        Me.AdvSubFamiliaArticulo.Size = New System.Drawing.Size(136, 23)
        Me.AdvSubFamiliaArticulo.TabIndex = 5
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(506, 111)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.lblAlmacen.TabIndex = 19
        Me.lblAlmacen.Text = "Almacén"
        '
        'AdvAlmacen
        '
        Me.AdvAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.AdvAlmacen.EntityName = "Almacen"
        Me.AdvAlmacen.Location = New System.Drawing.Point(592, 106)
        Me.AdvAlmacen.Name = "AdvAlmacen"
        Me.AdvAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.AdvAlmacen.Size = New System.Drawing.Size(88, 23)
        Me.AdvAlmacen.TabIndex = 20
        Me.AdvAlmacen.ViewName = "tbMaestroAlmacen"
        '
        'CIDisponibilidad
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.EntityName = "PedidoVentaLinea"
        Me.KeyField = "IDLineaPedido"
        Me.Name = "CIDisponibilidad"
        Me.ViewName = "VCtlConsDisponibilidad"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim aux As New Business.ClasesTecozam.MetodosAuxiliares
    Private mblnStkDobleUnidad As Boolean

    Private Sub CIDisponibilidad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitFilterCriteria()
        LoadGridActions()
        loadToolbarActions()
        If Not Me.DesignMode Then
            SettingDobleUnidad()
        End If
    End Sub

    Private Sub loadToolbarActions()
        Me.FormActions.Add("Inventario Almacenes con fecha.", AddressOf GeneraInventarioFechaAC)
    End Sub

    Public Sub GeneraInventarioFecha()
        Dim mes As String
        Dim anio As String
        Dim familia As String
        Dim Fecha1 As DateTime
        Dim almacen As String

        Dim frm As New frmFechas
        frm.ShowDialog()

        Fecha1 = frm.fecha1
        familia = frm.familia
        almacen = frm.almacen

        mes = Fecha1.Month
        anio = Fecha1.Year

        Dim dtStockHoy As New DataTable
        dtStockHoy = devuelveStockFechaHoy(familia, almacen)

        Dim Fecha2 As String
        'Fecha1 = "02/" & mes & "/" & anio

        Fecha2 = "(SELECT MAX(FechaDocumento) FROM tbHistoricoMovimiento)"
        Dim IDArticulo As String
        Dim dtAux As New DataTable
        Dim sql As String

        'MsgBox(dtStockHoy.Rows.Count)
        For Each dr As DataRow In dtStockHoy.Rows
            IDArticulo = dr("IDArticulo")
            sql = "select Sum(Cantidad) As Cantidad from tbHistoricoMovimiento where FechaDocumento>='" & Fecha1 & "'"
            sql &= "and FechaDocumento<=" & Fecha2 & " and IDArticulo='" & IDArticulo & "' and IDAlmacen='" & almacen & "' and IDTipoMovimiento!=11"
            dtAux = aux.EjecutarSqlSelect(sql)

            Try
                dr("StockFisico") = dr("StockFisico") - dtAux.Rows(0)("Cantidad")
            Catch ex As Exception
                dtAux.Rows(0)("Cantidad") = 0
            End Try
        Next

        'Dim dtFinal As DataTable = DevuelveTablaOrdenada(dtStockHoy)
        'EXPORTO ESTA TABLA
        'CAMPOS: IDALMACEN-IDARTICULO-DESCARTICULO-STOCKFISICO-PRECIOULTIMACOMPRAA-IDUDINTERNA-TOTAL(€) [Calculado]
        Dim ruta As String
        ruta = DevuelveRuta()

        'GuardaExcel(ruta, familia, dtFinal, mes, anio)
    End Sub
    Public Sub GeneraInventarioFechaAC()
        Dim mes As String
        Dim anio As String
        Dim familia As String
        Dim Fecha1 As DateTime
        Dim almacen As String

        Dim frm As New frmFechas
        frm.ShowDialog()

        Fecha1 = frm.fecha1
        familia = frm.familia
        almacen = frm.almacen

        mes = Fecha1.Month
        anio = Fecha1.Year

        Dim dtStockHoy As New DataTable
        dtStockHoy = devuelveStockFechaHoy(familia, almacen)

        Dim Fecha2 As String
        'Fecha1 = "02/" & mes & "/" & anio

        Fecha2 = "(SELECT MAX(FechaMovimiento) FROM tbHistoricoMovimiento)"
        Dim IDArticulo As String
        Dim dtAux As New DataTable
        Dim sql As String

        For Each dr As DataRow In dtStockHoy.Rows
            IDArticulo = dr("IDArticulo")
            sql = "select Sum(Cantidad) As Cantidad from tbHistoricoMovimiento where FechaMovimiento>='" & Fecha1 & "'"
            sql &= "and FechaMovimiento<=" & Fecha2 & " and IDArticulo='" & IDArticulo & "' and IDAlmacen='" & almacen & "' and IDTipoMovimiento!=11"
            dtAux = aux.EjecutarSqlSelect(sql)
            Try
                dr("StockFisico") = dr("StockFisico") - dtAux.Rows(0)("Cantidad")
            Catch ex As Exception
                dtAux.Rows(0)("Cantidad") = 0
            End Try
        Next

        Dim dtFinal As DataTable = DevuelveTablaOrdenada(dtStockHoy, Fecha1)
        'EXPORTO ESTA TABLA
        'CAMPOS: IDALMACEN-IDARTICULO-DESCARTICULO-STOCKFISICO-PRECIOULTIMACOMPRAA-IDUDINTERNA-TOTAL(€) [Calculado]
        Dim ruta As String
        ruta = DevuelveRuta()

        GuardaExcel(ruta, familia, dtFinal, mes, anio)
    End Sub
    Public Function DevuelveTablaOrdenada(ByVal dtStockHoy As DataTable, ByVal Fecha1 As String) As DataTable
        Dim dt As New DataTable

        Dim dc As New DataColumn("ALMACEN")
        dt.Columns.Add(dc)
        dc = New DataColumn("IDARTICULO")
        dt.Columns.Add(dc)
        dc = New DataColumn("ARTICULO")
        dt.Columns.Add(dc)
        dc = New DataColumn("CANTIDAD", System.Type.GetType("System.Double"))
        dt.Columns.Add(dc)
        dc = New DataColumn("PRECIO COMPRA", System.Type.GetType("System.Double"))
        dt.Columns.Add(dc)
        dc = New DataColumn("UND")
        dt.Columns.Add(dc)
        dc = New DataColumn("TOTAL", System.Type.GetType("System.Double"))
        dt.Columns.Add(dc)

        For Each dr As DataRow In dtStockHoy.Rows
            If dr("IDArticulo") = "ABONOFERRET" Then
            Else
                Dim drFinal As DataRow
                drFinal = dt.NewRow
                drFinal("ALMACEN") = dr("IDAlmacen")
                drFinal("IDARTICULO") = dr("IDArticulo")
                drFinal("ARTICULO") = dr("DescArticulo")
                drFinal("CANTIDAD") = dr("stockfisico")
                'drFinal("PRECIO COMPRA") = dr("PrecioUltimaCompraA")
                drFinal("PRECIO COMPRA") = CheckUltimoPrecio(dr("IDArticulo"), Fecha1)
                drFinal("UND") = dr("IDUdInterna")
                drFinal("TOTAL") = dr("stockfisico") * drFinal("PRECIO COMPRA")
                dt.Rows.Add(drFinal)
            End If 
        Next

        Return dt
    End Function
    Public Function CheckUltimoPrecio(ByVal IDArticulo As String, ByVal Fecha1 As String) As Double
        Dim f As New Filter
        f.Add("IDMaterial", FilterOperator.Equal, IDArticulo)
        f.Add("FechaEntrega", FilterOperator.LessThanOrEqual, Fecha1)
        Dim dtObraMaterial As DataTable
        dtObraMaterial = New BE.DataEngine().Filter("tbObraMaterial", f, , "FechaEntrega desc")


        Dim filtro As New Filter
        filtro.Add("IDArticulo", FilterOperator.Equal, IDArticulo)
        Dim dtArticulo As DataTable
        dtArticulo = New BE.DataEngine().Filter("tbMaestroArticulo", filtro)

        If dtObraMaterial.Rows.Count <> 0 Then
            'Si el articulo es de alquiler se pone el precio compra
            If dtObraMaterial.Rows(0)("TipoFacturacion") = 3 Then
                Return dtArticulo.Rows(0)("PrecioUltimaCompraA")
            Else
                'Tengo que comparar si el precio del ultimo material salido es menor que el ultimo comprado
                Dim fechaAlq As Date
                fechaAlq = dtObraMaterial.Rows(0)("FechaEntrega").ToString
                Dim fechaUlCompra As Date
                Try
                    fechaUlCompra = dtArticulo.Rows(0)("FechaUltimaCompra").ToString
                Catch ex As Exception
                    fechaUlCompra = "31/12/2021"
                End Try

                '1º CHECK QUE FECHA ULTIMA COMPRA SEA MENO QUE FECHA 1
                If fechaUlCompra > Fecha1 Then
                    Return dtObraMaterial.Rows(0)("PrecioPrevMatA")
                Else
                    If fechaAlq < fechaUlCompra Then
                        Return dtArticulo.Rows(0)("PrecioEstandarA")
                    Else
                        Return dtObraMaterial.Rows(0)("PrecioPrevMatA")
                    End If
                End If
                
            End If
        Else
            'Si no hay historial se pone PrecioEstandarA que es el que vino de Expertis4
            Return dtArticulo.Rows(0)("PrecioEstandarA")
        End If
    End Function
    Public Sub GuardaExcel(ByVal ruta As String, ByVal familia As String, ByVal dtFinal As DataTable, ByVal mes As String, ByVal anio As String)
        Dim sumaTotal As Double = 0
        For Each dr As DataRow In dtFinal.Rows
            sumaTotal += dr("TOTAL")
        Next

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial

        Using package As New ExcelPackage(ruta)
            ' Crear una hoja de cálculo y obtener una referencia a ella.
            Dim worksheet = package.Workbook.Worksheets.Add(mes & " " & familia & " " & mes & "" & anio.Substring(anio.Length - 2))

            ' Copiar los datos de la DataTable a la hoja de cálculo.
            worksheet.Cells("A1").LoadFromDataTable(dtFinal, True)

            ' Establecer el valor "1" en la celda I2
            worksheet.Cells("I2").Value = "TOTAL"
            worksheet.Cells("J2").Value = sumaTotal

            worksheet.Cells("J2").Style.Numberformat.Format = "#,##0.00€"
            ' Establecer el formato de la columna E a partir de la fila 2
            Dim columnaE As ExcelRange = worksheet.Cells("E2:E" & worksheet.Dimension.End.Row)
            'columnaE.Style.Numberformat.Format = "#,##0.00€"

            ' Establecer el formato de la columna G a partir de la fila 2
            Dim columnaG As ExcelRange = worksheet.Cells("G2:G" & worksheet.Dimension.End.Row)
            columnaG.Style.Numberformat.Format = "#,##0.00€"

            worksheet.Column(10).Width = 15

            ' Aplicar formato negrita a la fila 1
            Dim fila1 As ExcelRange = worksheet.Cells(1, 1, 1, worksheet.Dimension.End.Column)
            fila1.Style.Font.Bold = True

            ' Aplicar formato negrita a las celdas I2 y J2
            Dim celdaI2 As ExcelRange = worksheet.Cells("I2")
            Dim celdaJ2 As ExcelRange = worksheet.Cells("J2")
            celdaI2.Style.Font.Bold = True
            celdaJ2.Style.Font.Bold = True

            ' Guardar el archivo de Excel.
            package.Save()
        End Using
    End Sub
    Public Function DevuelveRuta() As String
        Dim CD As New SaveFileDialog()

        CD.Title = "Seleccionar archivos"
        CD.Filter = "Archivos Excel (*.xlsx)|*.xlsx"

        'CD.ShowOpen()
        CD.ShowDialog()

        If CD.FileName <> "" Then
            'lblRuta.Caption = CD.FileName
            Return CD.FileName
        End If
    End Function
    Public Function devuelveStockFechaHoy(ByVal familia As String, ByVal almacen As String) As DataTable
        Dim dt As New DataTable
        Dim filtro As New Solmicro.Expertis.Engine.Filter
        filtro.Add("IDEstado", FilterOperator.NotEqual, "OBS")
        filtro.Add("IDAlmacen", FilterOperator.Equal, almacen)
        filtro.Add("IDFamilia", FilterOperator.Equal, familia)

        dt = New BE.DataEngine().Filter("vCtlConsDisponibilidad", filtro)
        Return dt
    End Function

    Private Sub LoadGridActions()
        Me.Grid.Actions.Add("Abrir Disponibilidad Artículo", AddressOf AccionAbrirDisponibilidadArticulo)
        Me.Grid.Actions.Add("Abrir Mantenimiento de Artículo", AddressOf AccionAbrirArticulo)
    End Sub

    Private Sub AccionAbrirArticulo()
        If ExpertisApp.IsFormOpen("MARTICULO") Then ExpertisApp.CloseForm("MARTICULO")
        ExpertisApp.OpenForm("MARTICULO", New FilterItem("IDArticulo", FilterOperator.Equal, Me.Grid.GetValue("IDArticulo")))
    End Sub

    Private Sub AccionAbrirDisponibilidadArticulo()
        VerDisponibilidad()
    End Sub

    Private Sub SettingDobleUnidad()
        mblnStkDobleUnidad = New Parametro().GestionDobleUnidad
        If Me.Grid.Columns.Contains("StockFisico2") Then
            Me.Grid.Columns("StockFisico2").Visible = mblnStkDobleUnidad
            Me.Grid.Columns("StockFisico2").Position = Me.Grid.Columns("StockFisico").Position + 1
        End If
        If Me.Grid.Columns.Contains("QPendiente2") Then
            Me.Grid.Columns("QPendiente2").Visible = mblnStkDobleUnidad
        End If
        If Me.Grid.Columns.Contains("QPedida2") Then
            Me.Grid.Columns("QPedida2").Visible = mblnStkDobleUnidad
        End If
        If Me.Grid.Columns.Contains("QDisponible2") Then
            Me.Grid.Columns("QDisponible2").Visible = mblnStkDobleUnidad
        End If
    End Sub

    Private Sub Grid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.Click
        Try
            Dim hit As GridArea
            With Grid
                hit = .HitTest()
                If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                    Dim c As GridEXColumn = .ColumnFromPoint()
                    If Not IsNothing(c) Then
                        If c.Key = "Disponibilidad" Then
                            VerDisponibilidad()
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub VerDisponibilidad()
        Dim htParams As New Hashtable
        htParams("IDArticulo") = Grid.GetValue("IdArticulo")
        htParams("IDAlmacen") = Grid.GetValue("IdAlmacen")
        htParams("EvolDisp") = True

        ExpertisApp.OpenForm("DISP", , htParams)
    End Sub

    Protected Overrides Sub OnFilterClearing(ByVal e As System.EventArgs)
        MyBase.OnFilterClearing(e)
        InitFilterCriteria()
    End Sub

    Private Sub ConsDisponibilidad_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        Try
            e.Filter.Add("IDArticulo", FilterOperator.Equal, FwiIDArticulo.Text, FilterType.String)
            e.Filter.Add("QPendiente", FilterOperator.GreaterThan, FwiPendiente.Text, FilterType.Numeric)
            e.Filter.Add("QDisponible", FilterOperator.GreaterThan, FwiDisponibleMayor.Text, FilterType.Numeric)
            e.Filter.Add("QDisponible", FilterOperator.LessThanOrEqual, FwiDisponibleMenorIg.Text, FilterType.Numeric)
            e.Filter.Add("IDTipo", FilterOperator.Equal, Me.AdvTipoArticulo.Value)
            e.Filter.Add("IDFamilia", FilterOperator.Equal, Me.AdvFamiliaArticulo.Value)
            e.Filter.Add("IDSubfamilia", FilterOperator.Equal, Me.AdvSubFamiliaArticulo.Value)
            e.Filter.Add("IDAlmacen", FilterOperator.Equal, Me.AdvAlmacen.Value)

            ''David V 31/08/22
            e.Filter.Add("IDEstado", FilterOperator.NotEqual, "OBS")
        Catch ex As Exception
            e.Cancel = True
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AdvFamiliaArticulo_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvFamiliaArticulo.SetPredefinedFilter
        e.ForcePredefinedFilter = True
        If Length(Me.AdvTipoArticulo.Value) > 0 Then
            e.Filter.Add("IDTipo", FilterOperator.Equal, Me.AdvTipoArticulo.Value)
        Else : ExpertisApp.GenerateMessage("Seleccione un Tipo de Artículo para seleccionar una Familia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub InitFilterCriteria()
        FwiPendiente.Value = ""
    End Sub

End Class
