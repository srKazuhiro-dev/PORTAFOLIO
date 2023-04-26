Imports FontAwesome.Sharp

Public Class Informe

    Private currentBtn As IconButton


    'Metodos 
    Private Sub activateButton(SenderBtn As Object, customColor As Color)
        If SenderBtn IsNot Nothing Then
            disablebutton()
            'botones 
            currentBtn = CType(SenderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

        End If
    End Sub

    Private Sub disablebutton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText

        End If
    End Sub
    'FIN METODOS 

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'color bnt
        activateButton(sender, RGBColors.color4)
    End Sub

    Private Sub btnActualiza_Click(sender As Object, e As EventArgs) Handles btnActualiza.Click
        'color bnt
        activateButton(sender, RGBColors.color4)
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        'color bnt
        activateButton(sender, RGBColors.color4)
    End Sub
End Class