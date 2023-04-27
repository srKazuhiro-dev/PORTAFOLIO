Imports FontAwesome.Sharp

Public Class menuBodega
    'fields
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    'contrustor 
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        panelmenu.Controls.Add(leftBorderBtn)

    End Sub


    'FORMULARIO HIJO
    Private Sub OpenChildForm(childForm As Form)
        'Abrir form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'Fin
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        paneldesktop.Controls.Add(childForm)
        paneldesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblformtitle.Text = childForm.Text
    End Sub




    'ACTIVAR Y DESACTIVAR COLORES 
    Private Sub activatebutton(senderbtn As Object, customcolor As Color)
        If senderbtn IsNot Nothing Then
            Disablebutton()
            'Boton
            currentBtn = CType(senderbtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customcolor
            currentBtn.IconColor = customcolor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'borde izq
            leftBorderBtn.BackColor = customcolor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'icono de formulario actual
            iconactual.IconChar = currentBtn.IconChar
            iconactual.IconColor = customcolor


        End If

    End Sub
    'DESACTIVAR BTN
    Private Sub Disablebutton()
        If currentBtn IsNot Nothing Then
            'Boton
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub



    'EVENTOS + BOTONES 
    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        'BOTON COLOR
        activatebutton(sender, RGBColors.color1)
        'Abrir Form
        OpenChildForm(New Inventario)
    End Sub

    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        reset()
    End Sub

    Private Sub reset()
        Disablebutton()
        leftBorderBtn.Visible = False
        iconactual.IconChar = IconChar.Home
        iconactual.IconColor = Color.MediumPurple
        lblformtitle.Text = "Home"
    End Sub

End Class