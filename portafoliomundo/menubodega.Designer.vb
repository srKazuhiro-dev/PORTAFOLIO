<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menubodega
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(menubodega))
        panelmenu = New Panel()
        Inventario = New FontAwesome.Sharp.IconButton()
        panellogo = New Panel()
        imgHome = New PictureBox()
        paneltitle = New Panel()
        lblformtitle = New Label()
        iconactual = New FontAwesome.Sharp.IconPictureBox()
        paneldesktop = New Panel()
        panelmenu.SuspendLayout()
        panellogo.SuspendLayout()
        CType(imgHome, ComponentModel.ISupportInitialize).BeginInit()
        paneltitle.SuspendLayout()
        CType(iconactual, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelmenu
        ' 
        panelmenu.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        panelmenu.Controls.Add(Inventario)
        panelmenu.Controls.Add(panellogo)
        panelmenu.Dock = DockStyle.Left
        panelmenu.Location = New Point(10, 0)
        panelmenu.Name = "panelmenu"
        panelmenu.Size = New Size(220, 620)
        panelmenu.TabIndex = 0
        ' 
        ' Inventario
        ' 
        Inventario.Dock = DockStyle.Top
        Inventario.FlatAppearance.BorderSize = 0
        Inventario.FlatStyle = FlatStyle.Flat
        Inventario.ForeColor = Color.Gainsboro
        Inventario.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt
        Inventario.IconColor = Color.Gainsboro
        Inventario.IconFont = FontAwesome.Sharp.IconFont.Auto
        Inventario.IconSize = 32
        Inventario.ImageAlign = ContentAlignment.MiddleLeft
        Inventario.Location = New Point(0, 140)
        Inventario.Name = "Inventario"
        Inventario.Size = New Size(220, 60)
        Inventario.TabIndex = 2
        Inventario.Text = "Inventario"
        Inventario.TextAlign = ContentAlignment.MiddleLeft
        Inventario.TextImageRelation = TextImageRelation.ImageBeforeText
        Inventario.UseVisualStyleBackColor = True
        ' 
        ' panellogo
        ' 
        panellogo.Controls.Add(imgHome)
        panellogo.Dock = DockStyle.Top
        panellogo.Location = New Point(0, 0)
        panellogo.Name = "panellogo"
        panellogo.Size = New Size(220, 140)
        panellogo.TabIndex = 1
        ' 
        ' imgHome
        ' 
        imgHome.Image = CType(resources.GetObject("imgHome.Image"), Image)
        imgHome.Location = New Point(0, 0)
        imgHome.Name = "imgHome"
        imgHome.Size = New Size(220, 140)
        imgHome.SizeMode = PictureBoxSizeMode.Zoom
        imgHome.TabIndex = 0
        imgHome.TabStop = False
        ' 
        ' paneltitle
        ' 
        paneltitle.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(62))
        paneltitle.Controls.Add(lblformtitle)
        paneltitle.Controls.Add(iconactual)
        paneltitle.Dock = DockStyle.Top
        paneltitle.Location = New Point(230, 0)
        paneltitle.Name = "paneltitle"
        paneltitle.Size = New Size(951, 75)
        paneltitle.TabIndex = 1
        ' 
        ' lblformtitle
        ' 
        lblformtitle.AutoSize = True
        lblformtitle.ForeColor = Color.Gainsboro
        lblformtitle.Location = New Point(66, 16)
        lblformtitle.Name = "lblformtitle"
        lblformtitle.Size = New Size(50, 20)
        lblformtitle.TabIndex = 1
        lblformtitle.Text = "Home"' 
        ' iconactual
        ' 
        iconactual.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(62))
        iconactual.ForeColor = Color.MediumPurple
        iconactual.IconChar = FontAwesome.Sharp.IconChar.House
        iconactual.IconColor = Color.MediumPurple
        iconactual.IconFont = FontAwesome.Sharp.IconFont.Auto
        iconactual.IconSize = 40
        iconactual.Location = New Point(20, 16)
        iconactual.Name = "iconactual"
        iconactual.Size = New Size(40, 40)
        iconactual.TabIndex = 0
        iconactual.TabStop = False
        ' 
        ' paneldesktop
        ' 
        paneldesktop.BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        paneldesktop.Dock = DockStyle.Fill
        paneldesktop.Location = New Point(230, 75)
        paneldesktop.Name = "paneldesktop"
        paneldesktop.Size = New Size(951, 545)
        paneldesktop.TabIndex = 2
        ' 
        ' menubodega
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1201, 620)
        Controls.Add(paneldesktop)
        Controls.Add(paneltitle)
        Controls.Add(panelmenu)
        Name = "menubodega"
        Padding = New Padding(10, 0, 20, 0)
        Text = "menubodega"
        panelmenu.ResumeLayout(False)
        panellogo.ResumeLayout(False)
        CType(imgHome, ComponentModel.ISupportInitialize).EndInit()
        paneltitle.ResumeLayout(False)
        paneltitle.PerformLayout()
        CType(iconactual, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelmenu As Panel
    Friend WithEvents Inventario As FontAwesome.Sharp.IconButton
    Friend WithEvents panellogo As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents paneltitle As Panel
    Friend WithEvents lblformtitle As Label
    Friend WithEvents iconactual As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents paneldesktop As Panel
End Class
