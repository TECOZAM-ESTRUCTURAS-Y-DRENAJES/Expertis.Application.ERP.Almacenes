Public Class frmMntoUbicaciones
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.Grid.RelationMode = RelationMode.NoRelation
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
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Panel2 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents txtIDAlmacen As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents ulDescAlmacen As Solmicro.Expertis.Engine.UI.UnderLineLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.ulDescAlmacen = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.txtIDAlmacen = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        Me.Panel2.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ulDescAlmacen)
        Me.Panel1.Controls.Add(Me.txtIDAlmacen)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 32)
        Me.Panel1.TabIndex = 10
        '
        'ulDescAlmacen
        '
        Me.ulDescAlmacen.Location = New System.Drawing.Point(192, 8)
        Me.ulDescAlmacen.Name = "ulDescAlmacen"
        Me.ulDescAlmacen.Size = New System.Drawing.Size(280, 21)
        Me.ulDescAlmacen.TabIndex = 7
        '
        'txtIDAlmacen
        '
        Me.txtIDAlmacen.Enabled = False
        Me.txtIDAlmacen.Location = New System.Drawing.Point(72, 6)
        Me.txtIDAlmacen.Name = "txtIDAlmacen"
        Me.txtIDAlmacen.ReadOnly = True
        Me.txtIDAlmacen.Size = New System.Drawing.Size(112, 21)
        Me.txtIDAlmacen.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Tag = ""
        Me.Label1.Text = "Almacén"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmbCancelar)
        Me.Panel2.Controls.Add(Me.cmbAceptar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 213)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(480, 48)
        Me.Panel2.TabIndex = 12
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(245, 8)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(102, 33)
        Me.cmbCancelar.TabIndex = 5
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(134, 8)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(102, 33)
        Me.cmbAceptar.TabIndex = 4
        Me.cmbAceptar.Text = "Aceptar"
        '
        'Grid
        '
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDUbicacion""" & _
        "><Caption>Ubicación</Caption><DataMember>IDUbicacion</DataMember><Key>IDUbicacio" & _
        "n</Key><Position>0</Position><TextAlignment>Near</TextAlignment></Column0><Colum" & _
        "n1 ID=""DescUbicacion""><Caption>Desc. Ubicación</Caption><DataMember>DescUbicacio" & _
        "n</DataMember><Key>DescUbicacion</Key><Position>1</Position><TextAlignment>Near<" & _
        "/TextAlignment><Width>225</Width></Column1><Column2 ID=""Predeterminada""><Caption" & _
        ">Predeterminada</Caption><ColumnType>CheckBox</ColumnType><DataMember>Predetermi" & _
        "nada</DataMember><EditType>CheckBox</EditType><Key>Predeterminada</Key><Position" & _
        ">2</Position><TextAlignment>Center</TextAlignment><Width>103</Width></Column2><C" & _
        "olumn3 ID=""IDAlmacen""><Caption>IDAlmacen</Caption><DataMember>IDAlmacen</DataMem" & _
        "ber><Key>IDAlmacen</Key><Position>3</Position><Visible>False</Visible></Column3>" & _
        "</Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
        Me.Grid.DesignTimeLayout = GridEXLayout1
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EntityName = ""
        Me.Grid.Location = New System.Drawing.Point(0, 32)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = ""
        Me.Grid.SecondaryDataFields = ""
        Me.Grid.Size = New System.Drawing.Size(480, 181)
        Me.Grid.TabIndex = 13
        Me.Grid.Tag = "idrec=4390;7240;4519"
        Me.Grid.ViewName = ""
        '
        'frmMntoUbicaciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(480, 261)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMntoUbicaciones"
        Me.NavigationFields = ""
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.AllRecords
        End Get
    End Property

    Private Sub Grid_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        Try
            With Grid
                Select Case e.Column.Key
                    Case "IDUbicacion"
                        If Length(.GetValue("IDUbicacion")) > 0 Then
                            e.Cancel = (.Row <> Grid.newTopRowPosition)
                        End If
                End Select
            End With
        Catch ex As Exception
            e.Cancel = True
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub AbrirMntoUbicaciones(ByVal strIDAlmacen As String, ByVal DescAlmacen As String, ByVal OwnerForm As FormBase)
        Try
            Grid.EntityName = "AlmacenUbicacion"
            Grid.ViewName = "tbMaestroAlmacenUbicacion"

            txtIDAlmacen.Text = strIDAlmacen
            ulDescAlmacen.Text = DescAlmacen

            Dim f As New Filter
            f.Add(New StringFilterItem("IDAlmacen", FilterOperator.Equal, strIDAlmacen))
            Grid.Filter = f
            Grid.Columns("IDAlmacen").DefaultValue = strIDAlmacen
            Me.ShowDialog(OwnerForm)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        If (Grid.RowCount > 1) Then
            ExpertisApp.GenerateMessage("El almacén no puede tener dos direcciones asignadas. Borre una.")
        Else
            Me.UpdateData()
            Me.Close()
        End If

    End Sub

    
End Class
