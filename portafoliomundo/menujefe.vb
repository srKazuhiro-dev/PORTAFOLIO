Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports FontAwesome.Sharp


Public Class menujefe

    'fields
    Private currentbtn As IconButton
    Private leftborderbtn As Panel
    Private currentchildform As Form

    'contructor
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        leftborderbtn = New Panel()
        leftborderbtn.Size = New Size(7, 60)
        panelmenu.Controls.Add(leftborderbtn)
        '----DESCARTADO SACAR BRODER Y DEMAS POR GENERACION DE CONFLICTO DE APP------
        'form / menujefe
        ' Me.Text = String.Empty
        'Me.ControlBox = False
        'Me.DoubleBuffered = True
        ' Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
        '----DESCARTADO SACAR BRODER Y DEMAS POR GENERACION DE CONFLICTO DE APP------
    End Sub


    'Metodos
    'ACTIVAR BTN
    Private Sub activerbutton(senderbtn As Object, customcolor As Color)
        If senderbtn IsNot Nothing Then
            Disablebutton()
            'Boton
            currentbtn = CType(senderbtn, IconButton)
            currentbtn.BackColor = Color.FromArgb(37, 36, 81)
            currentbtn.ForeColor = customcolor
            currentbtn.IconColor = customcolor
            currentbtn.TextAlign = ContentAlignment.MiddleCenter
            currentbtn.ImageAlign = ContentAlignment.MiddleRight
            currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'borde izq
            leftborderbtn.BackColor = customcolor
            leftborderbtn.Location = New Point(0, currentbtn.Location.Y)
            leftborderbtn.Visible = True
            leftborderbtn.BringToFront()
            'icono de formulario actual
            iconactual.IconChar = currentbtn.IconChar
            iconactual.IconColor = customcolor




        End If

    End Sub
    'DESACTIVAR BTN
    Private Sub Disablebutton()
        If currentbtn IsNot Nothing Then
            'Boton
            currentbtn.BackColor = Color.FromArgb(31, 30, 68)
            currentbtn.ForeColor = Color.Gainsboro
            currentbtn.IconColor = Color.Gainsboro
            currentbtn.TextAlign = ContentAlignment.MiddleLeft
            currentbtn.ImageAlign = ContentAlignment.MiddleLeft
            currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    'Abrir formularios hijos (abrir form dentro de un panel )
    Private Sub openchildform(childform As Form)
        'open  
        If currentchildform IsNot Nothing Then
            currentchildform.Close()
        End If
        currentchildform = childform
        'end
        childform.TopLevel = False 'Dar orden de que form hijo  no es superior 
        childform.FormBorderStyle = FormBorderStyle.None 'quitar borde
        childform.Dock = DockStyle.Fill
        paneldesktop.Controls.Add(childform)
        paneldesktop.Tag = childform
        childform.BringToFront()
        childform.Show()
        lblformtitle.Text = childform.Text

    End Sub
    '---------------------SE ELIMINA POR CONFLICTO ---------------
    'Configuracion de tamaño de menujefe 
    ' Private Sub menujefe_Resize(sender As Object, e As EventArgs)
    ' If WindowState = FormWindowState.Maximized Then
    '        FormBorderStyle = FormBorderStyle.None
    'Else
    '        FormBorderStyle = FormBorderStyle.Sizable
    'End If
    ' End Sub
'---------------------------------------------------------------------
    'Botones General + eventos 
    Private Sub btnproveedor_Click(sender As Object, e As EventArgs) Handles btnproveedor.Click
        'color bnt
        activerbutton(sender, RGBColors.color1)
        'abrir form
        openchildform(New Proveedores)
    End Sub

    Private Sub btninventario_Click(sender As Object, e As EventArgs) Handles btninventario.Click
        'color bnt
        activerbutton(sender, RGBColors.color2)
        'abrir form
        openchildform(New Inventario)
    End Sub

    Private Sub btninforme_Click(sender As Object, e As EventArgs) Handles btninforme.Click
        'color bnt
        activerbutton(sender, RGBColors.color3)
        'abrir form
        openchildform(New Inventario)
    End Sub

    Private Sub btnempleado_Click(sender As Object, e As EventArgs) Handles btnempleado.Click
        'color bnt
        activerbutton(sender, RGBColors.color6)
        'abrir form
        openchildform(New Empleados)
    End Sub

    'fin btn
    '-------------------------------------------------------'
    'Movimiento de form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer,
                                                                                        ByVal lParam As Integer)
    End Sub

    Private Sub paneltitle_MouseDown_1(sender As Object, e As MouseEventArgs) Handles paneltitle.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    '---------------------------------------------------------------'
    'Home
    Private Sub imghome_Click(sender As Object, e As EventArgs) Handles imghome.Click
        If currentchildform IsNot Nothing Then
            currentchildform.Close()

        End If
        reset()
    End Sub

    'Metodo para restablecer valores 
    Private Sub reset()
        Disablebutton()
        leftborderbtn.Visible = False
        iconactual.IconChar = IconChar.Home
        iconactual.IconColor = Color.MediumPurple
        lblformtitle.Text = " Home "
    End Sub


End Class
