Public Class frmFechas



    Friend familia As String
    Friend fecha1 As String
    Friend almacen As String

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        familia = txtFamilia.Text
        fecha1 = cbFecha1.Text
        almacen = txtalmacen.Text

        If Trim(fecha1).Length = 0 Or Trim(familia).Length = 0 Then
            MsgBox("Debe de seleccionar un mes y un año")
        Else
            'MsgBox("Ha elegido mes " & mes & " año " & anio)
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class