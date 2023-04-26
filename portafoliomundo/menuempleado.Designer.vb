<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuempleado
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(menuempleado))
        panelmenu = New Panel()
        btnRventas = New FontAwesome.Sharp.IconButton()
        btnRcliente = New FontAwesome.Sharp.IconButton()
        btnInventario = New FontAwesome.Sharp.IconButton()
        btnVenta = New FontAwesome.Sharp.IconButton()
        panelLogo = New Panel()
        imgHome = New PictureBox()
        paneltitle = New Panel()
        lblformtitle = New Label()
        iconactual = New FontAwesome.Sharp.IconPictureBox()
        paneldesktop = New Panel()
        panelmenu.SuspendLayout()
        panelLogo.SuspendLayout()
        CType(imgHome, ComponentModel.ISupportInitialize).BeginInit()
        paneltitle.SuspendLayout()
        CType(iconactual, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelmenu
        ' 
        panelmenu.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        panelmenu.Controls.Add(btnRventas)
        panelmenu.Controls.Add(btnRcliente)
        panelmenu.Controls.Add(btnInventario)
        panelmenu.Controls.Add(btnVenta)
        panelmenu.Controls.Add(panelLogo)
        panelmenu.Dock = DockStyle.Left
        panelmenu.Location = New Point(0, 0)
        panelmenu.Name = "panelmenu"
        panelmenu.Size = New Size(220, 654)
        panelmenu.TabIndex = 0
        ' 
        ' btnRventas
        ' 
        btnRventas.Dock = DockStyle.Top
        btnRventas.FlatAppearance.BorderSize = 0
        btnRventas.FlatStyle = FlatStyle.Flat
        btnRventas.ForeColor = Color.Gainsboro
        btnRventas.IconChar = FontAwesome.Sharp.IconChar.CashRegister
        btnRventas.IconColor = Color.Gainsboro
        btnRventas.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnRventas.IconSize = 32
        btnRventas.ImageAlign = ContentAlignment.MiddleLeft
        btnRventas.Location = New Point(0, 320)
        btnRventas.Name = "btnRventas"
        btnRventas.Padding = New Padding(10, 0, 20, 0)
        btnRventas.Size = New Size(220, 60)
        btnRventas.TabIndex = 4
        btnRventas.Text = "Registro venta"
        btnRventas.TextAlign = ContentAlignment.MiddleLeft
        btnRventas.TextImageRelation = TextImageRelation.ImageBeforeText
        btnRventas.UseVisualStyleBackColor = True
        ' 
        ' btnRcliente
        ' 
        btnRcliente.Dock = DockStyle.Top
        btnRcliente.FlatAppearance.BorderSize = 0
        btnRcliente.FlatStyle = FlatStyle.Flat
        btnRcliente.ForeColor = Color.Gainsboro
        btnRcliente.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        btnRcliente.IconColor = Color.Gainsboro
        btnRcliente.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnRcliente.IconSize = 32
        btnRcliente.ImageAlign = ContentAlignment.MiddleLeft
        btnRcliente.Location = New Point(0, 260)
        btnRcliente.Name = "btnRcliente"
        btnRcliente.Padding = New Padding(10, 0, 20, 0)
        btnRcliente.Size = New Size(220, 60)
        btnRcliente.TabIndex = 3
        btnRcliente.Text = "Registro Cliente"
        btnRcliente.TextAlign = ContentAlignment.MiddleLeft
        btnRcliente.TextImageRelation = TextImageRelation.ImageBeforeText
        btnRcliente.UseVisualStyleBackColor = True
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
        btnInventario.Location = New Point(0, 200)
        btnInventario.Name = "btnInventario"
        btnInventario.Padding = New Padding(10, 0, 20, 0)
        btnInventario.Size = New Size(220, 60)
        btnInventario.TabIndex = 2
        btnInventario.Text = "Inventario"
        btnInventario.TextAlign = ContentAlignment.MiddleLeft
        btnInventario.TextImageRelation = TextImageRelation.ImageBeforeText
        btnInventario.UseVisualStyleBackColor = True
        ' 
        ' btnVenta
        ' 
        btnVenta.Dock = DockStyle.Top
        btnVenta.FlatAppearance.BorderSize = 0
        btnVenta.FlatStyle = FlatStyle.Flat
        btnVenta.ForeColor = Color.Gainsboro
        btnVenta.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        btnVenta.IconColor = Color.Gainsboro
        btnVenta.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnVenta.IconSize = 32
        btnVenta.ImageAlign = ContentAlignment.MiddleLeft
        btnVenta.Location = New Point(0, 140)
        btnVenta.Name = "btnVenta"
        btnVenta.Padding = New Padding(10, 0, 20, 0)
        btnVenta.Size = New Size(220, 60)
        btnVenta.TabIndex = 1
        btnVenta.Text = "Venta"
        btnVenta.TextAlign = ContentAlignment.MiddleLeft
        btnVenta.TextImageRelation = TextImageRelation.ImageBeforeText
        btnVenta.UseVisualStyleBackColor = True
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
        paneltitle.Location = New Point(220, 0)
        paneltitle.Name = "paneltitle"
        paneltitle.Size = New Size(1048, 75)
        paneltitle.TabIndex = 1
        ' 
        ' lblformtitle
        ' 
        lblformtitle.AutoSize = True
        lblformtitle.ForeColor = Color.Gainsboro
        lblformtitle.Location = New Point(68, 12)
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
        iconactual.Location = New Point(22, 12)
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
        paneldesktop.TabIndex = 5
        ' 
        ' menuempleado
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1268, 654)
        Controls.Add(paneldesktop)
        Controls.Add(paneltitle)
        Controls.Add(panelmenu)
        Name = "menuempleado"
        Text = "menuempleado"
        panelmenu.ResumeLayout(False)
        panelLogo.ResumeLayout(False)
        CType(imgHome, ComponentModel.ISupportInitialize).EndInit()
        paneltitle.ResumeLayout(False)
        paneltitle.PerformLayout()
        CType(iconactual, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelmenu As Panel
    Friend WithEvents btnRventas As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRcliente As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInventario As FontAwesome.Sharp.IconButton
    Friend WithEvents btnVenta As FontAwesome.Sharp.IconButton
    Friend WithEvents panelLogo As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents paneltitle As Panel
    Friend WithEvents lblformtitle As Label
    Friend WithEvents iconactual As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents paneldesktop As Panel
End Class
