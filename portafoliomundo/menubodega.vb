Imports System.Runtime.InteropServices   'IMPORT LIBRERY DLL.USER32
Imports FontAwesome.Sharp ' importar librerio fontawesone importante para funcionamiento de app 


Public Class menubodega
    'fields
    Private currentBtn As IconButton
    Private leftborderBtn As Panel
    Private currentchildform As Form


    'Constructor 
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        leftborderBtn = New Panel()
        leftborderBtn.Size = New Size(7, 60)
        panelmenu.Controls.Add(leftborderBtn)
    End Sub


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

            'borde izq
            leftborderBtn.BackColor = customColor
            leftborderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftborderBtn.Visible = True
            leftborderBtn.BringToFront()


            'icon actual
            iconactual.IconChar = currentBtn.IconChar
            iconactual.IconColor = customColor

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


    'formularios hijos 
    Private Sub OpenChildForm(childform As Form)
        'Open only form
        If currentchildform IsNot Nothing Then
            currentchildform.Close()

        End If
        currentchildform = childform
        'fin
        childform.TopLevel = False  ' Deja que el form pueda abirse en el panel ya que no queda como superior 
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        paneldesktop.Controls.Add(childform)
        paneldesktop.Tag = childform
        childform.BringToFront()
        childform.Show()
        lblformtitle.Text = childform.Text



    End Sub





    'Eventos + botones 

    Private Sub Inventario_Click(sender As Object, e As EventArgs) Handles Inventario.Click
        'color buton
        activateButton(sender, RGBColors.color3)
        'abrir fomulario 
        OpenChildForm(New Inventario)


    End Sub

    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click
        If currentchildform IsNot Nothing Then
            currentchildform.Close()

        End If
        Reset()
    End Sub

    Private Sub Reset()
        disablebutton()
        leftborderBtn.Visible = False
        iconactual.IconChar = IconChar.Home
        iconactual.IconColor = Color.MediumPurple
        lblformtitle.Text = "Home"


    End Sub



    'Movimiento de form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
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