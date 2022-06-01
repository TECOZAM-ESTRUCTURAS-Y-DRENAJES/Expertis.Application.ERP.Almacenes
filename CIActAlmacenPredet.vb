Public Class CIActAlmacenPredet
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

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
    Friend WithEvents fwiIdArticuloHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiIdArticuloHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcfwiIdArticuloHasta As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents fwiIdSubFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiIdSubFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcfwiIdSubFamilia As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents fwiIdFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiIdFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcfwiIdFamilia As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents fwiIdTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiIdTipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcfwiIdTipo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents FwiIdArticuloDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFwiIdArticuloDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcFwiIdArticuloDesde As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents FwiIdAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFwiIdAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcFwiIdAlmacen As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents lblfwiFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiTipoArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDArticuloDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIDFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIDTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiSubfamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDSubfamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIDArticuloHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiArticuloDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiArticuloHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblfwiAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIActAlmacenPredet))
        Me.fwiIdArticuloHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiIdArticuloHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiIdArticuloHasta = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiIdSubFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiIdSubFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiIdSubFamilia = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiIdFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiIdFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiIdFamilia = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiIdTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiIdTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiIdTipo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.FwiIdArticuloDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFwiIdArticuloDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcFwiIdArticuloDesde = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.FwiIdAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFwiIdAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcFwiIdAlmacen = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblfwiArticuloDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiTipoArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDArticuloDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advIDFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advIDTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiSubfamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDSubfamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advIDArticuloHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiArticuloHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblfwiAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblfwiArticuloHasta)
        Me.FilterPanel.Controls.Add(Me.lblfwiSubfamilia)
        Me.FilterPanel.Controls.Add(Me.lblfwiArticuloDesde)
        Me.FilterPanel.Controls.Add(Me.lblfwiFamilia)
        Me.FilterPanel.Controls.Add(Me.lblfwiTipoArticulo)
        Me.FilterPanel.Controls.Add(Me.lblfwiIdArticuloHasta)
        Me.FilterPanel.Controls.Add(Me.lblfwiIdSubFamilia)
        Me.FilterPanel.Controls.Add(Me.lblfwiIdFamilia)
        Me.FilterPanel.Controls.Add(Me.lblfwiIdTipo)
        Me.FilterPanel.Controls.Add(Me.lblFwiIdArticuloDesde)
        Me.FilterPanel.Controls.Add(Me.lblFwiIdAlmacen)
        Me.FilterPanel.Controls.Add(Me.advIDArticuloHasta)
        Me.FilterPanel.Controls.Add(Me.advIDSubfamilia)
        Me.FilterPanel.Controls.Add(Me.advIDArticuloDesde)
        Me.FilterPanel.Controls.Add(Me.advIDFamilia)
        Me.FilterPanel.Controls.Add(Me.advIDTipo)
        Me.FilterPanel.Controls.Add(Me.lblcfwiIdArticuloHasta)
        Me.FilterPanel.Controls.Add(Me.fwiIdArticuloHasta)
        Me.FilterPanel.Controls.Add(Me.lblcfwiIdSubFamilia)
        Me.FilterPanel.Controls.Add(Me.fwiIdSubFamilia)
        Me.FilterPanel.Controls.Add(Me.lblcfwiIdFamilia)
        Me.FilterPanel.Controls.Add(Me.fwiIdFamilia)
        Me.FilterPanel.Controls.Add(Me.lblcfwiIdTipo)
        Me.FilterPanel.Controls.Add(Me.fwiIdTipo)
        Me.FilterPanel.Controls.Add(Me.lblcFwiIdArticuloDesde)
        Me.FilterPanel.Controls.Add(Me.FwiIdArticuloDesde)
        Me.FilterPanel.Controls.Add(Me.lblcFwiIdAlmacen)
        Me.FilterPanel.Controls.Add(Me.FwiIdAlmacen)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 341)
        Me.FilterPanel.Size = New System.Drawing.Size(688, 80)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.Panel1)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(688, 341)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Panel1, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ArticuloAlmacen"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.KeyField = "IDArticulo"
        Me.Grid.Location = New System.Drawing.Point(0, 32)
        Me.Grid.Size = New System.Drawing.Size(688, 309)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "FrmMntoActAlmacenPredet"
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.CheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.UncheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.ShowAllCheckedItems.Visible = Janus.Windows.UI.InheritableBoolean.[True]
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
        Me.Toolbar.Size = New System.Drawing.Size(320, 28)
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
        'fwiIdArticuloHasta
        '
        Me.fwiIdArticuloHasta.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIdArticuloHasta.EntityName = "Articulo"
        Me.fwiIdArticuloHasta.Location = New System.Drawing.Point(226, 360)
        Me.fwiIdArticuloHasta.Name = "fwiIdArticuloHasta"
        Me.fwiIdArticuloHasta.PrimaryDataFields = "IDArticulo"
        Me.fwiIdArticuloHasta.SecondaryDataFields = "IDArticulo"
        Me.fwiIdArticuloHasta.Size = New System.Drawing.Size(73, 23)
        Me.fwiIdArticuloHasta.TabIndex = 2
        Me.fwiIdArticuloHasta.ViewName = "tbMaestroArticulo"
        '
        'lblfwiIdArticuloHasta
        '
        Me.lblfwiIdArticuloHasta.Location = New System.Drawing.Point(185, 360)
        Me.lblfwiIdArticuloHasta.Name = "lblfwiIdArticuloHasta"
        Me.lblfwiIdArticuloHasta.Size = New System.Drawing.Size(39, 13)
        Me.lblfwiIdArticuloHasta.TabIndex = 0
        Me.lblfwiIdArticuloHasta.Tag = "IdRec=4377;"
        Me.lblfwiIdArticuloHasta.Text = "Hasta"
        '
        'lblcfwiIdArticuloHasta
        '
        Me.lblcfwiIdArticuloHasta.Location = New System.Drawing.Point(299, 360)
        Me.lblcfwiIdArticuloHasta.Name = "lblcfwiIdArticuloHasta"
        Me.lblcfwiIdArticuloHasta.Size = New System.Drawing.Size(100, 20)
        Me.lblcfwiIdArticuloHasta.TabIndex = 1
        '
        'fwiIdSubFamilia
        '
        Me.fwiIdSubFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIdSubFamilia.EntityName = "Subfamilia"
        Me.fwiIdSubFamilia.Location = New System.Drawing.Point(87, 423)
        Me.fwiIdSubFamilia.Name = "fwiIdSubFamilia"
        Me.fwiIdSubFamilia.PrimaryDataFields = "IDSubfamilia"
        Me.fwiIdSubFamilia.SecondaryDataFields = "IDSubfamilia"
        Me.fwiIdSubFamilia.Size = New System.Drawing.Size(73, 23)
        Me.fwiIdSubFamilia.TabIndex = 5
        Me.fwiIdSubFamilia.ViewName = "tbMaestroSubfamilia"
        '
        'lblfwiIdSubFamilia
        '
        Me.lblfwiIdSubFamilia.Location = New System.Drawing.Point(13, 423)
        Me.lblfwiIdSubFamilia.Name = "lblfwiIdSubFamilia"
        Me.lblfwiIdSubFamilia.Size = New System.Drawing.Size(69, 13)
        Me.lblfwiIdSubFamilia.TabIndex = 3
        Me.lblfwiIdSubFamilia.Tag = "IdRec=4452;"
        Me.lblfwiIdSubFamilia.Text = "SubFamilia"
        '
        'lblcfwiIdSubFamilia
        '
        Me.TryDataBinding(lblcfwiIdSubFamilia, New System.Windows.Forms.Binding("Text", Me.fwiIdSubFamilia, "DescSubfamilia", True))
        Me.lblcfwiIdSubFamilia.Location = New System.Drawing.Point(160, 423)
        Me.lblcfwiIdSubFamilia.Name = "lblcfwiIdSubFamilia"
        Me.lblcfwiIdSubFamilia.Size = New System.Drawing.Size(167, 21)
        Me.lblcfwiIdSubFamilia.TabIndex = 4
        '
        'fwiIdFamilia
        '
        Me.fwiIdFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIdFamilia.EntityName = "Familia"
        Me.fwiIdFamilia.Location = New System.Drawing.Point(87, 402)
        Me.fwiIdFamilia.Name = "fwiIdFamilia"
        Me.fwiIdFamilia.PrimaryDataFields = "IDFamilia"
        Me.fwiIdFamilia.SecondaryDataFields = "IDFamilia"
        Me.fwiIdFamilia.Size = New System.Drawing.Size(73, 23)
        Me.fwiIdFamilia.TabIndex = 4
        Me.fwiIdFamilia.ViewName = "tbMaestroFamilia"
        '
        'lblfwiIdFamilia
        '
        Me.lblfwiIdFamilia.Location = New System.Drawing.Point(13, 402)
        Me.lblfwiIdFamilia.Name = "lblfwiIdFamilia"
        Me.lblfwiIdFamilia.Size = New System.Drawing.Size(47, 13)
        Me.lblfwiIdFamilia.TabIndex = 6
        Me.lblfwiIdFamilia.Tag = "IdRec=4454;"
        Me.lblfwiIdFamilia.Text = "Familia"
        '
        'lblcfwiIdFamilia
        '
        Me.TryDataBinding(lblcfwiIdFamilia, New System.Windows.Forms.Binding("Text", Me.fwiIdFamilia, "DescFamilia", True))
        Me.lblcfwiIdFamilia.Location = New System.Drawing.Point(160, 402)
        Me.lblcfwiIdFamilia.Name = "lblcfwiIdFamilia"
        Me.lblcfwiIdFamilia.Size = New System.Drawing.Size(171, 21)
        Me.lblcfwiIdFamilia.TabIndex = 7
        '
        'fwiIdTipo
        '
        Me.fwiIdTipo.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIdTipo.EntityName = "TipoArticulo"
        Me.fwiIdTipo.Location = New System.Drawing.Point(87, 381)
        Me.fwiIdTipo.Name = "fwiIdTipo"
        Me.fwiIdTipo.PrimaryDataFields = "IDTipo"
        Me.fwiIdTipo.SecondaryDataFields = "IDTipo"
        Me.fwiIdTipo.Size = New System.Drawing.Size(73, 23)
        Me.fwiIdTipo.TabIndex = 3
        Me.fwiIdTipo.ViewName = "tbMaestroTipoArticulo"
        '
        'lblfwiIdTipo
        '
        Me.lblfwiIdTipo.Location = New System.Drawing.Point(13, 381)
        Me.lblfwiIdTipo.Name = "lblfwiIdTipo"
        Me.lblfwiIdTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblfwiIdTipo.TabIndex = 8
        Me.lblfwiIdTipo.Tag = "IdRec=4456;"
        Me.lblfwiIdTipo.Text = "Tipo"
        '
        'lblcfwiIdTipo
        '
        Me.TryDataBinding(lblcfwiIdTipo, New System.Windows.Forms.Binding("Text", Me.fwiIdTipo, "DescTipo", True))
        Me.lblcfwiIdTipo.Location = New System.Drawing.Point(160, 381)
        Me.lblcfwiIdTipo.Name = "lblcfwiIdTipo"
        Me.lblcfwiIdTipo.Size = New System.Drawing.Size(172, 21)
        Me.lblcfwiIdTipo.TabIndex = 9
        '
        'FwiIdArticuloDesde
        '
        Me.FwiIdArticuloDesde.DisabledBackColor = System.Drawing.Color.White
        Me.FwiIdArticuloDesde.EntityName = "Articulo"
        Me.FwiIdArticuloDesde.Location = New System.Drawing.Point(87, 360)
        Me.FwiIdArticuloDesde.Name = "FwiIdArticuloDesde"
        Me.FwiIdArticuloDesde.PrimaryDataFields = "IDArticulo"
        Me.FwiIdArticuloDesde.SecondaryDataFields = "IDArticulo"
        Me.FwiIdArticuloDesde.Size = New System.Drawing.Size(73, 23)
        Me.FwiIdArticuloDesde.TabIndex = 1
        Me.FwiIdArticuloDesde.ViewName = "tbMaestroArticulo"
        '
        'lblFwiIdArticuloDesde
        '
        Me.lblFwiIdArticuloDesde.Location = New System.Drawing.Point(13, 360)
        Me.lblFwiIdArticuloDesde.Name = "lblFwiIdArticuloDesde"
        Me.lblFwiIdArticuloDesde.Size = New System.Drawing.Size(90, 13)
        Me.lblFwiIdArticuloDesde.TabIndex = 10
        Me.lblFwiIdArticuloDesde.Tag = "IdRec=4377;"
        Me.lblFwiIdArticuloDesde.Text = "Artículo Desde"
        '
        'lblcFwiIdArticuloDesde
        '
        Me.lblcFwiIdArticuloDesde.Location = New System.Drawing.Point(160, 360)
        Me.lblcFwiIdArticuloDesde.Name = "lblcFwiIdArticuloDesde"
        Me.lblcFwiIdArticuloDesde.Size = New System.Drawing.Size(100, 20)
        Me.lblcFwiIdArticuloDesde.TabIndex = 11
        '
        'FwiIdAlmacen
        '
        Me.FwiIdAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.FwiIdAlmacen.EntityName = "Almacen"
        Me.FwiIdAlmacen.Location = New System.Drawing.Point(371, 381)
        Me.FwiIdAlmacen.Name = "FwiIdAlmacen"
        Me.FwiIdAlmacen.PrimaryDataFields = "IDAlmacen"
        Me.FwiIdAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.FwiIdAlmacen.Size = New System.Drawing.Size(73, 23)
        Me.FwiIdAlmacen.TabIndex = 6
        Me.FwiIdAlmacen.ViewName = "tbMaestroAlmacen"
        '
        'lblFwiIdAlmacen
        '
        Me.lblFwiIdAlmacen.Location = New System.Drawing.Point(371, 360)
        Me.lblFwiIdAlmacen.Name = "lblFwiIdAlmacen"
        Me.lblFwiIdAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.lblFwiIdAlmacen.TabIndex = 12
        Me.lblFwiIdAlmacen.Tag = "IdRec=4390;"
        Me.lblFwiIdAlmacen.Text = "Almacén"
        '
        'lblcFwiIdAlmacen
        '
        Me.TryDataBinding(lblcFwiIdAlmacen, New System.Windows.Forms.Binding("Text", Me.FwiIdAlmacen, "DescAlmacen", True))
        Me.lblcFwiIdAlmacen.Location = New System.Drawing.Point(728, 360)
        Me.lblcFwiIdAlmacen.Name = "lblcFwiIdAlmacen"
        Me.lblcFwiIdAlmacen.Size = New System.Drawing.Size(192, 41)
        Me.lblcFwiIdAlmacen.TabIndex = 13
        '
        'lblfwiArticuloDesde
        '
        Me.lblfwiArticuloDesde.Location = New System.Drawing.Point(14, 29)
        Me.lblfwiArticuloDesde.Name = "lblfwiArticuloDesde"
        Me.lblfwiArticuloDesde.Size = New System.Drawing.Size(88, 13)
        Me.lblfwiArticuloDesde.TabIndex = 87
        Me.lblfwiArticuloDesde.Tag = ""
        Me.lblfwiArticuloDesde.Text = "Artículo desde"
        '
        'lblfwiFamilia
        '
        Me.lblfwiFamilia.Location = New System.Drawing.Point(294, 55)
        Me.lblfwiFamilia.Name = "lblfwiFamilia"
        Me.lblfwiFamilia.Size = New System.Drawing.Size(47, 13)
        Me.lblfwiFamilia.TabIndex = 88
        Me.lblfwiFamilia.Tag = "IdRec=4454;"
        Me.lblfwiFamilia.Text = "Familia"
        '
        'lblfwiTipoArticulo
        '
        Me.lblfwiTipoArticulo.Location = New System.Drawing.Point(294, 29)
        Me.lblfwiTipoArticulo.Name = "lblfwiTipoArticulo"
        Me.lblfwiTipoArticulo.Size = New System.Drawing.Size(31, 13)
        Me.lblfwiTipoArticulo.TabIndex = 89
        Me.lblfwiTipoArticulo.Tag = "IdRec=4456;"
        Me.lblfwiTipoArticulo.Text = "Tipo"
        '
        'advIDArticuloDesde
        '
        Me.advIDArticuloDesde.DisabledBackColor = System.Drawing.Color.White
        Me.advIDArticuloDesde.EntityName = "Articulo"
        Me.advIDArticuloDesde.Location = New System.Drawing.Point(104, 24)
        Me.advIDArticuloDesde.Name = "advIDArticuloDesde"
        Me.advIDArticuloDesde.PrimaryDataFields = "IDArticulo"
        Me.advIDArticuloDesde.SecondaryDataFields = "IDArticulo"
        Me.advIDArticuloDesde.Size = New System.Drawing.Size(120, 23)
        Me.advIDArticuloDesde.TabIndex = 0
        Me.advIDArticuloDesde.ViewName = "tbMaestroArticulo"
        '
        'advIDFamilia
        '
        Me.advIDFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advIDFamilia.EntityName = "Familia"
        Me.advIDFamilia.Location = New System.Drawing.Point(350, 50)
        Me.advIDFamilia.Name = "advIDFamilia"
        Me.advIDFamilia.PrimaryDataFields = "IDFamilia"
        Me.advIDFamilia.SecondaryDataFields = "IDFamilia"
        Me.advIDFamilia.Size = New System.Drawing.Size(84, 23)
        Me.advIDFamilia.TabIndex = 3
        Me.advIDFamilia.ViewName = "tbMaestroFamilia"
        '
        'advIDTipo
        '
        Me.advIDTipo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDTipo.EntityName = "TipoArticulo"
        Me.advIDTipo.Location = New System.Drawing.Point(350, 24)
        Me.advIDTipo.Name = "advIDTipo"
        Me.advIDTipo.PrimaryDataFields = "IDTipo"
        Me.advIDTipo.SecondaryDataFields = "IDTipo"
        Me.advIDTipo.Size = New System.Drawing.Size(84, 23)
        Me.advIDTipo.TabIndex = 2
        Me.advIDTipo.ViewName = "tbMaestroTipoArticulo"
        '
        'lblfwiSubfamilia
        '
        Me.lblfwiSubfamilia.Location = New System.Drawing.Point(512, 29)
        Me.lblfwiSubfamilia.Name = "lblfwiSubfamilia"
        Me.lblfwiSubfamilia.Size = New System.Drawing.Size(67, 13)
        Me.lblfwiSubfamilia.TabIndex = 92
        Me.lblfwiSubfamilia.Tag = "IdRec=4452;"
        Me.lblfwiSubfamilia.Text = "Subfamilia"
        '
        'advIDSubfamilia
        '
        Me.advIDSubfamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advIDSubfamilia.EntityName = "Subfamilia"
        Me.advIDSubfamilia.Location = New System.Drawing.Point(584, 24)
        Me.advIDSubfamilia.Name = "advIDSubfamilia"
        Me.advIDSubfamilia.PrimaryDataFields = "IDSubfamilia"
        Me.advIDSubfamilia.SecondaryDataFields = "IDSubfamilia"
        Me.advIDSubfamilia.Size = New System.Drawing.Size(88, 23)
        Me.advIDSubfamilia.TabIndex = 4
        Me.advIDSubfamilia.ViewName = "tbMaestroSubfamilia"
        '
        'advIDArticuloHasta
        '
        Me.advIDArticuloHasta.DisabledBackColor = System.Drawing.Color.White
        Me.advIDArticuloHasta.EntityName = "Articulo"
        Me.advIDArticuloHasta.Location = New System.Drawing.Point(104, 50)
        Me.advIDArticuloHasta.Name = "advIDArticuloHasta"
        Me.advIDArticuloHasta.PrimaryDataFields = "IDArticulo"
        Me.advIDArticuloHasta.SecondaryDataFields = "IDArticulo"
        Me.advIDArticuloHasta.Size = New System.Drawing.Size(120, 23)
        Me.advIDArticuloHasta.TabIndex = 1
        Me.advIDArticuloHasta.ViewName = "tbMaestroArticulo"
        '
        'lblfwiArticuloHasta
        '
        Me.lblfwiArticuloHasta.Location = New System.Drawing.Point(14, 55)
        Me.lblfwiArticuloHasta.Name = "lblfwiArticuloHasta"
        Me.lblfwiArticuloHasta.Size = New System.Drawing.Size(85, 13)
        Me.lblfwiArticuloHasta.TabIndex = 94
        Me.lblfwiArticuloHasta.Tag = ""
        Me.lblfwiArticuloHasta.Text = "Artículo hasta"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblfwiAlmacen)
        Me.Panel1.Controls.Add(Me.advIDAlmacen)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(688, 32)
        Me.Panel1.TabIndex = 1
        '
        'lblfwiAlmacen
        '
        Me.lblfwiAlmacen.Location = New System.Drawing.Point(16, 11)
        Me.lblfwiAlmacen.Name = "lblfwiAlmacen"
        Me.lblfwiAlmacen.Size = New System.Drawing.Size(191, 13)
        Me.lblfwiAlmacen.TabIndex = 92
        Me.lblfwiAlmacen.Tag = ""
        Me.lblfwiAlmacen.Text = "Nuevo Almacén predeterminado"
        '
        'advIDAlmacen
        '
        Me.advIDAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.advIDAlmacen.EntityName = "Almacen"
        Me.advIDAlmacen.Location = New System.Drawing.Point(216, 6)
        Me.advIDAlmacen.Name = "advIDAlmacen"
        Me.advIDAlmacen.PrimaryDataFields = "IDAlmacen"
        Me.advIDAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.advIDAlmacen.Size = New System.Drawing.Size(120, 23)
        Me.advIDAlmacen.TabIndex = 0
        Me.advIDAlmacen.ViewName = "tbMaestroAlmacen"
        '
        'CIActAlmacenPredet
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.EntityName = "ArticuloAlmacen"
        Me.KeyField = "IDArticulo"
        Me.Name = "CIActAlmacenPredet"
        Me.UseCheck = True
        Me.ViewName = "FrmMntoActAlmacenPredet"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CIActAlmacenPredet_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormActions.Add("Actualizar Almacén Predeterminado", AddressOf ActualizarAlmacen)
    End Sub

#Region " Toolbar Actions "

    Private Sub ActualizarAlmacen()
        If Grid.RowCount > 0 Then
            If Length(advIDAlmacen.Value) > 0 Then
                Dim ArtAlm As New DataArtAlm
                ArtAlm.dt = Grid.CheckedRecords
                ArtAlm.IDAlmacen = advIDAlmacen.Value
                ExpertisApp.ExecuteTask(Of DataArtAlm)(AddressOf ArticuloAlmacen.CambioAlmacenPredeterminado, ArtAlm)

                ExpertisApp.GenerateMessage("Proceso finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.UnCheckAllRecords()
                Me.Execute()
            Else
                ExpertisApp.GenerateMessage("El campo Nuevo Almacén predeterminado es un dato obligatorio para poder actualizar el almacén predeteminado de las líneas seleccionadas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

#End Region

    Private Sub CIActAlmacenPredet_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDArticulo", FilterOperator.GreaterThanOrEqual, advIDArticuloDesde.Text, FilterType.String)
        e.Filter.Add("IDArticulo", FilterOperator.LessThanOrEqual, advIDArticuloHasta.Text, FilterType.String)
        e.Filter.Add("IdTipo", FilterOperator.Equal, advIDTipo.Text, FilterType.String)
        e.Filter.Add("IDFamilia", FilterOperator.Equal, advIDFamilia.Text, FilterType.String)
        e.Filter.Add("IDSubFamilia", FilterOperator.Equal, advIDSubfamilia.Text, FilterType.String)
    End Sub

    Private Sub advIDTipo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles advIDTipo.TextChanged
        advIDFamilia.Text = String.Empty
        advIDSubfamilia.Text = String.Empty
    End Sub

    Private Sub advIDFamilia_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advIDFamilia.SetPredefinedFilter
        If Length(advIDTipo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipo", FilterOperator.Equal, advIDTipo.Text))
        End If
    End Sub
    Private Sub advIDFamilia_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advIDFamilia.SelectionChanged
        If Not e.Selected Is Nothing Then
            advIDTipo.Text = e.Selected.Rows(0)("IDTipo")
            advIDFamilia.Text = e.Selected.Rows(0)("IDFamilia")
        End If
    End Sub
    Private Sub advIDFamilia_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles advIDFamilia.TextChanged
        advIDSubfamilia.Text = String.Empty
    End Sub

    Private Sub advIDSubfamilia_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advIDSubfamilia.SetPredefinedFilter
        If Length(advIDTipo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipo", FilterOperator.Equal, advIDTipo.Text))
        End If
        If Length(advIDFamilia.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDFamilia", FilterOperator.Equal, advIDFamilia.Text))
        End If
    End Sub
    Private Sub advIDSubfamilia_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advIDSubfamilia.SelectionChanged
        If Not e.Selected Is Nothing Then
            advIDTipo.Text = e.Selected.Rows(0)("IDTipo")
            advIDFamilia.Text = e.Selected.Rows(0)("IDFamilia")
            advIDSubfamilia.Text = e.Selected.Rows(0)("IDSubFamilia")
        End If
    End Sub

    Private Sub advIDAlmacen_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles advIDAlmacen.SetPredefinedFilter
        e.Filter.Add(New BooleanFilterItem("Activo", FilterOperator.Equal, True))
    End Sub

End Class