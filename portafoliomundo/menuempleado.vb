Imports System.Drawing.Design
Imports System.Runtime.InteropServices 'Libreria que nos permite mover user32
Imports System.Transactions
Imports FontAwesome.Sharp    'Se importa para poder mostrar los iconos relacionados con FontAwesome.sharp'


Public Class menuempleado

    'fields
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentchildform As Form

    'contructor 
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        panelmenu.Controls.Add(leftBorderBtn) 'panel donde estan bonotes 
    End Sub


    'Metodos 
    Private Sub activatebutton(senderbtn As Object, customcolor As Color)
        If senderbtn IsNot Nothing Then
            disablebutton()
            'Boton
            currentBtn = CType(senderbtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customcolor
            currentBtn.IconColor = customcolor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

            'border izq
            leftBorderBtn.BackColor = customcolor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()

            'icono actual
            iconactual.IconChar = currentBtn.IconChar
            iconactual.IconColor = customcolor


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

    'form hijos 
    Private Sub openchildform(childform As Form)
        'abrir formulario
        If currentchildform IsNot Nothing Then
            currentchildform.Close()
        End If
        currentchildform = childform
        'end
        childform.TopLevel = False 'Indica que el form hijo no es superior y se puede abrir en panel
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        paneldesktop.Controls.Add(childform)
        paneldesktop.Tag = childform
        childform.BringToFront()
        childform.Show()
        lblformtitle.Text = childform.Text

    End Sub



    'Eventos + botones 

    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        'color boton
        activatebutton(sender, RGBColors.color5)
        'cambio form
        'openchildform(New  )

    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        'color boton
        activatebutton(sender, RGBColors.color6)
        'cambio form
        openchildform(New Inventario)
    End Sub

    Private Sub btnRcliente_Click(sender As Object, e As EventArgs) Handles btnRcliente.Click
        'color boton
        activatebutton(sender, RGBColors.color4)
        'cambio form
        'openchildform(New )
    End Sub

    Private Sub btnRventas_Click(sender As Object, e As EventArgs) Handles btnRventas.Click
        'color boton
        activatebutton(sender, RGBColors.color3)
        'cambio form
        'openchildform(New )
    End Sub
    '------ volver al home ---
    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click
        If currentchildform IsNot Nothing Then
            currentchildform.Close()
        End If
        reset()
    End Sub

    Private Sub reset()
        disablebutton()
        iconactual.IconChar = IconChar.Home
        iconactual.IconColor = Color.MediumPurple
        lblformtitle.Text = "Home"

    End Sub

    'movimiento de form top
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub releasecapture()

    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer,
                                                                                        ByVal lParam As Integer)
    End Sub

    Private Sub paneltitle_MouseDown(sender As Object, e As MouseEventArgs) Handles paneltitle.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class