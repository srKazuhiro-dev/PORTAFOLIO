Imports FontAwesome.Sharp

Public Class Inventario

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


    'EVENTOS + BOTONES 
    Private Sub btnañadir_Click_1(sender As Object, e As EventArgs) Handles btnañadir.Click
        'color buton
        activateButton(sender, RGBColors.color2)
    End Sub

    Private Sub btnmodificar_Click_1(sender As Object, e As EventArgs) Handles btnmodificar.Click
        'color buton
        activateButton(sender, RGBColors.color2)
    End Sub

    Private Sub btneliminar_Click_1(sender As Object, e As EventArgs) Handles btneliminar.Click
        'color buton
        activateButton(sender, RGBColors.color2)
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        'color buton
        activateButton(sender, RGBColors.color2)
    End Sub
    ' Fin BTN

End Class