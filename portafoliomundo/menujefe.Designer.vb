<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class menujefe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(menujefe))
        panelmenu = New Panel()
        btnempleado = New FontAwesome.Sharp.IconButton()
        btninforme = New FontAwesome.Sharp.IconButton()
        btninventario = New FontAwesome.Sharp.IconButton()
        btnproveedor = New FontAwesome.Sharp.IconButton()
        panellogo = New Panel()
        imghome = New PictureBox()
        paneltitle = New Panel()
        lblformtitle = New Label()
        iconactual = New FontAwesome.Sharp.IconPictureBox()
        paneldesktop = New Panel()
        panelmenu.SuspendLayout()
        panellogo.SuspendLayout()
        CType(imghome, ComponentModel.ISupportInitialize).BeginInit()
        paneltitle.SuspendLayout()
        CType(iconactual, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelmenu
        ' 
        panelmenu.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        panelmenu.Controls.Add(btnempleado)
        panelmenu.Controls.Add(btninforme)
        panelmenu.Controls.Add(btninventario)
        panelmenu.Controls.Add(btnproveedor)
        panelmenu.Controls.Add(panellogo)
        panelmenu.Dock = DockStyle.Left
        panelmenu.Location = New Point(0, 0)
        panelmenu.Name = "panelmenu"
        panelmenu.Size = New Size(220, 620)
        panelmenu.TabIndex = 0
        ' 
        ' btnempleado
        ' 
        btnempleado.Dock = DockStyle.Top
        btnempleado.FlatAppearance.BorderSize = 0
        btnempleado.FlatStyle = FlatStyle.Flat
        btnempleado.ForeColor = Color.Gainsboro
        btnempleado.IconChar = FontAwesome.Sharp.IconChar.Users
        btnempleado.IconColor = Color.Gainsboro
        btnempleado.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnempleado.IconSize = 32
        btnempleado.ImageAlign = ContentAlignment.MiddleLeft
        btnempleado.Location = New Point(0, 320)
        btnempleado.Name = "btnempleado"
        btnempleado.Padding = New Padding(10, 0, 20, 0)
        btnempleado.Size = New Size(220, 60)
        btnempleado.TabIndex = 5
        btnempleado.Text = "Empleado"
        btnempleado.TextAlign = ContentAlignment.MiddleLeft
        btnempleado.TextImageRelation = TextImageRelation.ImageBeforeText
        btnempleado.UseVisualStyleBackColor = True
        ' 
        ' btninforme
        ' 
        btninforme.Dock = DockStyle.Top
        btninforme.FlatAppearance.BorderSize = 0
        btninforme.FlatStyle = FlatStyle.Flat
        btninforme.ForeColor = Color.Gainsboro
        btninforme.IconChar = FontAwesome.Sharp.IconChar.LineChart
        btninforme.IconColor = Color.Gainsboro
        btninforme.IconFont = FontAwesome.Sharp.IconFont.Auto
        btninforme.IconSize = 32
        btninforme.ImageAlign = ContentAlignment.MiddleLeft
        btninforme.Location = New Point(0, 260)
        btninforme.Name = "btninforme"
        btninforme.Padding = New Padding(10, 0, 20, 0)
        btninforme.Size = New Size(220, 60)
        btninforme.TabIndex = 4
        btninforme.Text = "Informe de ventas"
        btninforme.TextAlign = ContentAlignment.MiddleLeft
        btninforme.TextImageRelation = TextImageRelation.ImageBeforeText
        btninforme.UseVisualStyleBackColor = True
        ' 
        ' btninventario
        ' 
        btninventario.Dock = DockStyle.Top
        btninventario.FlatAppearance.BorderSize = 0
        btninventario.FlatStyle = FlatStyle.Flat
        btninventario.ForeColor = Color.Gainsboro
        btninventario.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt
        btninventario.IconColor = Color.Gainsboro
        btninventario.IconFont = FontAwesome.Sharp.IconFont.Auto
        btninventario.IconSize = 32
        btninventario.ImageAlign = ContentAlignment.MiddleLeft
        btninventario.Location = New Point(0, 200)
        btninventario.Name = "btninventario"
        btninventario.Padding = New Padding(10, 0, 20, 0)
        btninventario.Size = New Size(220, 60)
        btninventario.TabIndex = 3
        btninventario.Text = "Inventario"
        btninventario.TextAlign = ContentAlignment.MiddleLeft
        btninventario.TextImageRelation = TextImageRelation.ImageBeforeText
        btninventario.UseVisualStyleBackColor = True
        ' 
        ' btnproveedor
        ' 
        btnproveedor.Dock = DockStyle.Top
        btnproveedor.FlatAppearance.BorderSize = 0
        btnproveedor.FlatStyle = FlatStyle.Flat
        btnproveedor.ForeColor = Color.Gainsboro
        btnproveedor.IconChar = FontAwesome.Sharp.IconChar.TruckField
        btnproveedor.IconColor = Color.Gainsboro
        btnproveedor.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnproveedor.IconSize = 32
        btnproveedor.ImageAlign = ContentAlignment.MiddleLeft
        btnproveedor.Location = New Point(0, 140)
        btnproveedor.Name = "btnproveedor"
        btnproveedor.Padding = New Padding(10, 0, 20, 0)
        btnproveedor.Size = New Size(220, 60)
        btnproveedor.TabIndex = 2
        btnproveedor.Text = "proveedores"
        btnproveedor.TextAlign = ContentAlignment.MiddleLeft
        btnproveedor.TextImageRelation = TextImageRelation.ImageBeforeText
        btnproveedor.UseVisualStyleBackColor = True
        ' 
        ' panellogo
        ' 
        panellogo.Controls.Add(imghome)
        panellogo.Dock = DockStyle.Top
        panellogo.Location = New Point(0, 0)
        panellogo.Name = "panellogo"
        panellogo.Size = New Size(220, 140)
        panellogo.TabIndex = 1
        ' 
        ' imghome
        ' 
        imghome.Image = CType(resources.GetObject("imghome.Image"), Image)
        imghome.Location = New Point(0, 0)
        imghome.Name = "imghome"
        imghome.Size = New Size(220, 137)
        imghome.SizeMode = PictureBoxSizeMode.Zoom
        imghome.TabIndex = 0
        imghome.TabStop = False
        ' 
        ' paneltitle
        ' 
        paneltitle.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(62))
        paneltitle.Controls.Add(lblformtitle)
        paneltitle.Controls.Add(iconactual)
        paneltitle.Dock = DockStyle.Top
        paneltitle.Location = New Point(220, 0)
        paneltitle.Name = "paneltitle"
        paneltitle.Size = New Size(981, 75)
        paneltitle.TabIndex = 1
        ' 
        ' lblformtitle
        ' 
        lblformtitle.AutoSize = True
        lblformtitle.ForeColor = Color.Gainsboro
        lblformtitle.Location = New Point(71, 25)
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
        iconactual.Location = New Point(25, 12)
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
        paneldesktop.Size = New Size(981, 545)
        paneldesktop.TabIndex = 2
        ' 
        ' menujefe
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1201, 620)
        Controls.Add(paneldesktop)
        Controls.Add(paneltitle)
        Controls.Add(panelmenu)
        Name = "menujefe"
        Text = "Form1"
        panelmenu.ResumeLayout(False)
        panellogo.ResumeLayout(False)
        CType(imghome, ComponentModel.ISupportInitialize).EndInit()
        paneltitle.ResumeLayout(False)
        paneltitle.PerformLayout()
        CType(iconactual, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelmenu As Panel
    Friend WithEvents panellogo As Panel
    Friend WithEvents btninventario As FontAwesome.Sharp.IconButton
    Friend WithEvents imghome As PictureBox
    Friend WithEvents btnempleado As FontAwesome.Sharp.IconButton
    Friend WithEvents btninforme As FontAwesome.Sharp.IconButton
    Friend WithEvents paneltitle As Panel
    Friend WithEvents lblformtitle As Label
    Friend WithEvents iconactual As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents paneldesktop As Panel
    Friend WithEvents btnproveedor As FontAwesome.Sharp.IconButton
End Class
