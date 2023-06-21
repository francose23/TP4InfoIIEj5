Public Class Form1
    Dim Vector(10), VectorNuevo(15), Suma As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For c = 1 To 10
            dgVector.Columns.Add("", "")
            dgVector.Columns(c - 1).Width = 40
        Next
        dgVector.Rows.Add(1)

        For c = 1 To 15
            dgVectorNuevo.Columns.Add("", "")
            dgVectorNuevo.Columns(c - 1).Width = 40
        Next
        dgVectorNuevo.Rows.Add(1)
    End Sub

    Private Sub dgVector_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgVector.CellContentClick

    End Sub

    Private Sub Boton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton.Click

        Suma = 0
        For Contador = 1 To 10
            Vector(Contador) = dgVector.Item(Contador - 1, 0).Value
        Next

        For Contador = 1 To 2
            VectorNuevo(Contador) = Vector(Contador)
            Suma = Suma + Vector(Contador)
        Next

        For Contador = 3 To 15
            VectorNuevo(Contador) = Suma
            Suma = Suma + VectorNuevo(Contador)
        Next

        For Contador = 1 To 15
            dgVectorNuevo.Item(Contador - 1, 0).Value = VectorNuevo(Contador)
        Next
    End Sub
End Class
