Public Class Form2

    Dim createUserList As New List(Of String)
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCedula.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblNombre.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblEdad.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        For Each txt In {txtCedula, txtNombre, txtEdad, txtSexo, txtEmail, txtTelFijo, txtTelMovil}
            If txt.Text IsNot "" Then
                txt.Text = "test"
                createUserList.Add(txt.Text)
            End If
        Next

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCSalir.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnBSalir.Click
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnASalir.Click
        Me.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btnESalir.Click
        Me.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblTelMovil.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCCancelar.Click

        For Each txt In {txtCedula, txtNombre, txtEdad, txtSexo, txtEmail, txtTelFijo, txtTelMovil}
            txt.Clear()
        Next

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnBCancelar.Click
        For Each txt In {txtBID, txtBCedula, txtBNombre}
            txt.Clear()
        Next
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btnECancelar.Click
        For Each txt In {txtEID, txtECedula, txtENombre}
            txt.Clear()
        Next
    End Sub
End Class