<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIHistoricoPrecios
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

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
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbMes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIHistoricoPrecios))
        Dim CmbAño_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.CmbMes = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.CmbAño = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.LblAño = New Solmicro.Expertis.Engine.UI.Label
        Me.LblMes = New Solmicro.Expertis.Engine.UI.Label
        Me.advArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Label5 = New Solmicro.Expertis.Engine.UI.Label
        Me.advTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.advFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.CmbMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.advFamilia)
        Me.FilterPanel.Controls.Add(Me.Label2)
        Me.FilterPanel.Controls.Add(Me.advTipo)
        Me.FilterPanel.Controls.Add(Me.Label1)
        Me.FilterPanel.Controls.Add(Me.advArticulo)
        Me.FilterPanel.Controls.Add(Me.Label5)
        Me.FilterPanel.Controls.Add(Me.CmbMes)
        Me.FilterPanel.Controls.Add(Me.CmbAño)
        Me.FilterPanel.Controls.Add(Me.LblAño)
        Me.FilterPanel.Controls.Add(Me.LblMes)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 309)
        Me.FilterPanel.Size = New System.Drawing.Size(739, 113)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(739, 309)
        '
        'Grid
        '
        Me.Grid.ColumnAutoResize = True
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "HistoricoPreciosArticulos"
        Me.Grid.Size = New System.Drawing.Size(739, 309)
        Me.Grid.ViewName = "vHistoricoPreciosArticulos"
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
        Me.MainPanel.Size = New System.Drawing.Size(739, 422)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(739, 422)
        '
        'CmbMes
        '
        CmbMes_DesignTimeLayout.LayoutString = resources.GetString("CmbMes_DesignTimeLayout.LayoutString")
        Me.CmbMes.DesignTimeLayout = CmbMes_DesignTimeLayout
        Me.CmbMes.DisabledBackColor = System.Drawing.Color.White
        Me.CmbMes.DisplayMember = "Text"
        Me.CmbMes.Location = New System.Drawing.Point(334, 29)
        Me.CmbMes.Name = "CmbMes"
        Me.CmbMes.SelectedIndex = -1
        Me.CmbMes.SelectedItem = Nothing
        Me.CmbMes.Size = New System.Drawing.Size(124, 21)
        Me.CmbMes.TabIndex = 29
        Me.CmbMes.ValueMember = "value"
        '
        'CmbAño
        '
        Me.CmbAño.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        CmbAño_DesignTimeLayout.LayoutString = resources.GetString("CmbAño_DesignTimeLayout.LayoutString")
        Me.CmbAño.DesignTimeLayout = CmbAño_DesignTimeLayout
        Me.CmbAño.DisabledBackColor = System.Drawing.Color.White
        Me.CmbAño.DisplayMember = "Año"
        Me.CmbAño.Location = New System.Drawing.Point(334, 71)
        Me.CmbAño.MaxLength = 4
        Me.CmbAño.Name = "CmbAño"
        Me.CmbAño.SelectedIndex = -1
        Me.CmbAño.SelectedItem = Nothing
        Me.CmbAño.Size = New System.Drawing.Size(124, 21)
        Me.CmbAño.TabIndex = 28
        Me.CmbAño.ValueMember = "Año"
        '
        'LblAño
        '
        Me.LblAño.Location = New System.Drawing.Point(288, 73)
        Me.LblAño.Name = "LblAño"
        Me.LblAño.Size = New System.Drawing.Size(34, 13)
        Me.LblAño.TabIndex = 26
        Me.LblAño.Text = "Año:"
        '
        'LblMes
        '
        Me.LblMes.Location = New System.Drawing.Point(288, 33)
        Me.LblMes.Name = "LblMes"
        Me.LblMes.Size = New System.Drawing.Size(34, 13)
        Me.LblMes.TabIndex = 25
        Me.LblMes.Text = "Mes:"
        '
        'advArticulo
        '
        Me.advArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.advArticulo.DisplayField = "IDArticulo"
        Me.advArticulo.EntityName = "Articulo"
        Me.advArticulo.Location = New System.Drawing.Point(601, 28)
        Me.advArticulo.Name = "advArticulo"
        Me.advArticulo.PrimaryDataFields = "IDArticulo"
        Me.advArticulo.SecondaryDataFields = "IDArticulo"
        Me.advArticulo.Size = New System.Drawing.Size(100, 23)
        Me.advArticulo.TabIndex = 34
        Me.advArticulo.ViewName = "tbMaestroArticulo"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(529, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Artículo:"
        '
        'advTipo
        '
        Me.advTipo.DisabledBackColor = System.Drawing.Color.White
        Me.advTipo.EntityName = "TipoArticulo"
        Me.advTipo.Location = New System.Drawing.Point(114, 28)
        Me.advTipo.Name = "advTipo"
        Me.advTipo.SecondaryDataFields = "IDTipo"
        Me.advTipo.Size = New System.Drawing.Size(100, 23)
        Me.advTipo.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(42, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Tipo:"
        '
        'advFamilia
        '
        Me.advFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advFamilia.DisplayField = "IDFamilia"
        Me.advFamilia.EntityName = "Familia"
        Me.advFamilia.Location = New System.Drawing.Point(114, 67)
        Me.advFamilia.Name = "advFamilia"
        Me.advFamilia.PrimaryDataFields = "IDFamilia"
        Me.advFamilia.SecondaryDataFields = "IDFamilia"
        Me.advFamilia.Size = New System.Drawing.Size(100, 23)
        Me.advFamilia.TabIndex = 38
        Me.advFamilia.ViewName = "tbMaestroFamilia"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(42, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Familia:"
        '
        'CIHistoricoPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 510)
        Me.EntityName = "HistoricoPreciosArticulos"
        Me.Name = "CIHistoricoPrecios"
        Me.Text = "CIHistoricoPrecios"
        Me.ViewName = "vHistoricoPreciosArticulos"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.CmbMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents advArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Label5 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents CmbMes As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents CmbAño As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents LblAño As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblMes As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
End Class
