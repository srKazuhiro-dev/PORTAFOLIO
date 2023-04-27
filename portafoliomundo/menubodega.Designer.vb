<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuBodega
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(menuBodega))
        panelmenu = New Panel()
        btnInventario = New FontAwesome.Sharp.IconButton()
        panelLogo = New Panel()
        imgHome = New PictureBox()
        panelTitle = New Panel()
        lblformtitle = New Label()
        iconactual = New FontAwesome.Sharp.IconPictureBox()
        paneldesktop = New Panel()
        panelmenu.SuspendLayout()
        panelLogo.SuspendLayout()
        CType(imgHome, ComponentModel.ISupportInitialize).BeginInit()
        panelTitle.SuspendLayout()
        CType(iconactual, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelmenu
        ' 
        panelmenu.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        panelmenu.Controls.Add(btnInventario)
        panelmenu.Controls.Add(panelLogo)
        panelmenu.Dock = DockStyle.Left
        panelmenu.Location = New Point(0, 0)
        panelmenu.Name = "panelmenu"
        panelmenu.Size = New Size(220, 654)
        panelmenu.TabIndex = 0
        ' 
        ' btnInventario
        ' 
        btnInventario.Dock = DockStyle.Top
        btnInventario.FlatAppearance.BorderSize = 0
        btnInventario.FlatStyle = FlatStyle.Flat
        btnInventario.ForeColor = Color.Gainsboro
        btnInventario.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt
        btnInventario.IconColor = Color.Gainsboro
        btnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnInventario.IconSize = 32
        btnInventario.ImageAlign = ContentAlignment.MiddleLeft
        btnInventario.Location = New Point(0, 140)
        btnInventario.Name = "btnInventario"
        btnInventario.Padding = New Padding(10, 0, 20, 0)
        btnInventario.Size = New Size(220, 60)
        btnInventario.TabIndex = 1
        btnInventario.Text = "Inventario"
        btnInventario.TextAlign = ContentAlignment.MiddleLeft
        btnInventario.TextImageRelation = TextImageRelation.ImageBeforeText
        btnInventario.UseVisualStyleBackColor = True
        ' 
        ' panelLogo
        ' 
        panelLogo.Controls.Add(imgHome)
        panelLogo.Dock = DockStyle.Top
        panelLogo.Location = New Point(0, 0)
        panelLogo.Name = "panelLogo"
        panelLogo.Size = New Size(220, 140)
        panelLogo.TabIndex = 0
        ' 
        ' imgHome
        ' 
        imgHome.Image = CType(resources.GetObject("imgHome.Image"), Image)
        imgHome.Location = New Point(3, 3)
        imgHome.Name = "imgHome"
        imgHome.Size = New Size(214, 134)
        imgHome.SizeMode = PictureBoxSizeMode.Zoom
        imgHome.TabIndex = 0
        imgHome.TabStop = False
        ' 
        ' panelTitle
        ' 
        panelTitle.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(62))
        panelTitle.Controls.Add(lblformtitle)
        panelTitle.Controls.Add(iconactual)
        panelTitle.Dock = DockStyle.Top
        panelTitle.Location = New Point(220, 0)
        panelTitle.Name = "panelTitle"
        panelTitle.Size = New Size(1048, 75)
        panelTitle.TabIndex = 2
        ' 
        ' lblformtitle
        ' 
        lblformtitle.AutoSize = True
        lblformtitle.ForeColor = Color.Gainsboro
        lblformtitle.Location = New Point(73, 32)
        lblformtitle.Name = "lblformtitle"
        lblformtitle.Size = New Size(50, 20)
        lblformtitle.TabIndex = 1
        lblformtitle.Text = "Home"' 
        ' iconactual
        ' 
        iconactual.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(62))
        iconactual.ForeColor = Color.MediumPurple
        iconactual.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        iconactual.IconColor = Color.MediumPurple
        iconactual.IconFont = FontAwesome.Sharp.IconFont.Auto
        iconactual.IconSize = 40
        iconactual.Location = New Point(27, 12)
        iconactual.Name = "iconactual"
        iconactual.Size = New Size(40, 40)
        iconactual.TabIndex = 0
        iconactual.TabStop = False
        ' 
        ' paneldesktop
        ' 
        paneldesktop.BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        paneldesktop.Dock = DockStyle.Fill
        paneldesktop.Location = New Point(220, 75)
        paneldesktop.Name = "paneldesktop"
        paneldesktop.Size = New Size(1048, 579)
        paneldesktop.TabIndex = 3
        ' 
        ' menuBodega
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1268, 654)
        Controls.Add(paneldesktop)
        Controls.Add(panelTitle)
        Controls.Add(panelmenu)
        Name = "menuBodega"
        Text = "menuBodega"
        panelmenu.ResumeLayout(False)
        panelLogo.ResumeLayout(False)
        CType(imgHome, ComponentModel.ISupportInitialize).EndInit()
        panelTitle.ResumeLayout(False)
        panelTitle.PerformLayout()
        CType(iconactual, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelmenu As Panel
    Friend WithEvents btnInventario As FontAwesome.Sharp.IconButton
    Friend WithEvents panelLogo As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents panelTitle As Panel
    Friend WithEvents lblformtitle As Label
    Friend WithEvents iconactual As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents paneldesktop As Panel
End Class
