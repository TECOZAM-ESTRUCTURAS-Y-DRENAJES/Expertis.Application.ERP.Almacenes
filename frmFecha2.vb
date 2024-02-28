Public Class frmFecha2

    Friend fecha2 As String

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        fecha2 = cbFecha.Text

        If Trim(fecha2).Length = 0 Then
            MsgBox("Debe de seleccionar el dia hasta donde se va a calcular el precio medio de cada artículo.")
        Else
            'MsgBox("Ha elegido mes " & mes & " año " & anio)
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class