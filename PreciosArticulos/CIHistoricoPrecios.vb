Imports Solmicro.Expertis.Business.ClasesTecozam

Public Class CIHistoricoPrecios

    Private Sub CIHistoricoPrecios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadToolbarActions()
        cargarComboAnio()
        CmbMes.DataSource = EnumData.EnumView("enumcaMesAño")
    End Sub

    Private Sub loadToolbarActions()
        Me.FormActions.Add("Ingresar datos por excel", AddressOf InsertarDatosExcel)
    End Sub

    Private Sub cargarComboAnio()
        Dim dtcombo As New DataTable
        dtcombo.Columns.Add("Año")

        Dim dr As DataRow

        For i As Integer = 0 To 10
            Dim j As Integer = Year(Today)
            dr = dtcombo.NewRow()
            dr("Año") = j - i
            dtcombo.Rows.Add(dr)
        Next
        CmbAño.DataSource = dtcombo
    End Sub
    Public Sub InsertarDatosExcel()
        Dim ruta As String
        Dim hoja As String = 1
        Dim rango As String = ""

        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                Dim dtCoste As New DataTable
                Dim control As Integer = 0
                Try
                    ruta = openFD.FileName

                    dtCoste.Columns.Add("IDArticulo")
                    dtCoste.Columns.Add("PrecioMedio")
                    dtCoste.Columns.Add("Mes")
                    dtCoste.Columns.Add("Año")

                    hoja = "1"
                    rango = "A1:D10000"

                    Dim dt As DataTable = ObtenerDatosExcel(ruta, hoja, rango)
                    MessageBox.Show("El excel tiene " & (dt.Rows.Count) & " filas.")

                    Dim drCoste As DataRow

                    For Each dr As DataRow In dt.Rows
                        If IsDBNull(dr(0)) Then
                        Else
                            drCoste = dtCoste.NewRow
                            drCoste("IDArticulo") = dr(0)
                            drCoste("PrecioMedio") = dr(1)
                            drCoste("Mes") = dr(2)
                            drCoste("Año") = dr(3)
                            dtCoste.Rows.Add(drCoste)
                            control = control + 1
                        End If
                    Next

                    For Each drInsert As DataRow In dtCoste.Rows             
                        Dim clsCE As New HistoricoPreciosArticulos
                        Dim dtCE As DataTable = clsCE.AddNewForm
                        dtCE.Rows(0)("IDArticulo") = drInsert("IDArticulo")
                        dtCE.Rows(0)("PrecioMedio") = drInsert("PrecioMedio")
                        dtCE.Rows(0)("Mes") = drInsert("Mes")
                        dtCE.Rows(0)("Año") = drInsert("Año")
                        Try
                            clsCE.Update(dtCE)
                        Catch ex As Exception
                        End Try

                    Next
                Catch ex As Exception
                    MessageBox.Show("No hay más datos que añadir. ")
                    Me.Close()
                End Try
                ExpertisApp.GenerateMessage("Se han insertado las lineas correctamente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End With
    End Sub
    Public Function ObtenerDatosExcel(ByVal ruta As String, ByVal hoja As String, ByVal rango As String) As DataTable
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim DtSet As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & ruta & "';Extended Properties=Excel 12.0;")
        MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [" & hoja & "$" & rango & "]", MyConnection)
        'MyCommand.TableMappings.Add("Table", "Net-informations.com")
        DtSet = New System.Data.DataSet
        MyCommand.Fill(DtSet)
        Dim dt As DataTable = DtSet.Tables(0)
        MyConnection.Close()

        Return dt

    End Function

    Private Sub CIHistoricoPrecios_QueryExecuting(ByVal sender As System.Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        Try
            e.Filter.Add("IDArticulo", FilterOperator.Equal, advArticulo.Text, FilterType.String)
            e.Filter.Add("Mes", FilterOperator.Equal, CmbMes.Value, FilterType.String)
            e.Filter.Add("Año", FilterOperator.Equal, CmbAño.Value, FilterType.String)
            e.Filter.Add("IDTipo", FilterOperator.Equal, advTipo.Value)
            e.Filter.Add("IDFamilia", FilterOperator.Equal, advFamilia.Value)
        Catch ex As Exception
            e.Cancel = True
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class