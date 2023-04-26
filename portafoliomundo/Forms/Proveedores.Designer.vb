<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        DataGridView1 = New DataGridView()
        btnañadir = New FontAwesome.Sharp.IconButton()
        btnmodificar = New FontAwesome.Sharp.IconButton()
        btnEliminar = New FontAwesome.Sharp.IconButton()
        btnActualiza = New FontAwesome.Sharp.IconButton()
        btnImprimir = New FontAwesome.Sharp.IconButton()
        txtNombre = New TextBox()
        lblNombre = New Label()
        txtCorreo = New TextBox()
        lblCorreo = New Label()
        txtContacto = New TextBox()
        lblContacto = New Label()
        txtProducto = New TextBox()
        lblProducto = New Label()
        txtID = New TextBox()
        lblMarca = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(271, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(680, 366)
        DataGridView1.TabIndex = 0
        ' 
        ' btnañadir
        ' 
        btnañadir.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnañadir.FlatStyle = FlatStyle.Flat
        btnañadir.ForeColor = Color.Gainsboro
        btnañadir.IconChar = FontAwesome.Sharp.IconChar.Add
        btnañadir.IconColor = Color.Gainsboro
        btnañadir.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnañadir.IconSize = 32
        btnañadir.Location = New Point(170, 450)
        btnañadir.Name = "btnañadir"
        btnañadir.Padding = New Padding(10, 0, 20, 0)
        btnañadir.Size = New Size(152, 36)
        btnañadir.TabIndex = 1
        btnañadir.Text = "Añadir"
        btnañadir.TextImageRelation = TextImageRelation.ImageBeforeText
        btnañadir.UseVisualStyleBackColor = True
        ' 
        ' btnmodificar
        ' 
        btnmodificar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnmodificar.FlatStyle = FlatStyle.Flat
        btnmodificar.ForeColor = Color.Gainsboro
        btnmodificar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
        btnmodificar.IconColor = Color.Gainsboro
        btnmodificar.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnmodificar.IconSize = 32
        btnmodificar.Location = New Point(328, 450)
        btnmodificar.Name = "btnmodificar"
        btnmodificar.Padding = New Padding(10, 0, 20, 0)
        btnmodificar.Size = New Size(152, 36)
        btnmodificar.TabIndex = 2
        btnmodificar.Text = "Modificar"
        btnmodificar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnmodificar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.ForeColor = Color.Gainsboro
        btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Eraser
        btnEliminar.IconColor = Color.Gainsboro
        btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnEliminar.IconSize = 32
        btnEliminar.Location = New Point(486, 450)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Padding = New Padding(10, 0, 20, 0)
        btnEliminar.Size = New Size(152, 36)
        btnEliminar.TabIndex = 3
        btnEliminar.Text = "Eliminar"
        btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnActualiza
        ' 
        btnActualiza.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnActualiza.FlatStyle = FlatStyle.Flat
        btnActualiza.ForeColor = Color.Gainsboro
        btnActualiza.IconChar = FontAwesome.Sharp.IconChar.RotateForward
        btnActualiza.IconColor = Color.Gainsboro
        btnActualiza.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnActualiza.IconSize = 32
        btnActualiza.Location = New Point(644, 450)
        btnActualiza.Name = "btnActualiza"
        btnActualiza.Padding = New Padding(10, 0, 20, 0)
        btnActualiza.Size = New Size(152, 36)
        btnActualiza.TabIndex = 4
        btnActualiza.Text = "Actualiza"
        btnActualiza.TextImageRelation = TextImageRelation.ImageBeforeText
        btnActualiza.UseVisualStyleBackColor = True
        ' 
        ' btnImprimir
        ' 
        btnImprimir.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnImprimir.FlatStyle = FlatStyle.Flat
        btnImprimir.ForeColor = Color.Gainsboro
        btnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print
        btnImprimir.IconColor = Color.Gainsboro
        btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnImprimir.IconSize = 32
        btnImprimir.Location = New Point(802, 450)
        btnImprimir.Name = "btnImprimir"
        btnImprimir.Padding = New Padding(10, 0, 20, 0)
        btnImprimir.Size = New Size(152, 36)
        btnImprimir.TabIndex = 5
        btnImprimir.Text = "Imprimir"
        btnImprimir.TextImageRelation = TextImageRelation.ImageBeforeText
        btnImprimir.UseVisualStyleBackColor = True
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(12, 32)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(182, 27)
        txtNombre.TabIndex = 11
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.ForeColor = Color.Gainsboro
        lblNombre.Location = New Point(12, 9)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(64, 20)
        lblNombre.TabIndex = 10
        lblNombre.Text = "Nombre" ' txtCorreo
        ' 
        txtCorreo.Location = New Point(12, 99)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(182, 27)
        txtCorreo.TabIndex = 13
        ' 
        ' lblCorreo
        ' 
        lblCorreo.AutoSize = True
        lblCorreo.ForeColor = Color.Gainsboro
        lblCorreo.Location = New Point(12, 76)
        lblCorreo.Name = "lblCorreo"
        lblCorreo.Size = New Size(54, 20)
        lblCorreo.TabIndex = 12
        lblCorreo.Text = "Correo" ' txtContacto
        ' 
        txtContacto.Location = New Point(12, 168)
        txtContacto.Name = "txtContacto"
        txtContacto.Size = New Size(182, 27)
        txtContacto.TabIndex = 15
        ' 
        ' lblContacto
        ' 
        lblContacto.AutoSize = True
        lblContacto.ForeColor = Color.Gainsboro
        lblContacto.Location = New Point(12, 145)
        lblContacto.Name = "lblContacto"
        lblContacto.Size = New Size(69, 20)
        lblContacto.TabIndex = 14
        lblContacto.Text = "Contacto" ' txtProducto
        ' 
        txtProducto.Location = New Point(12, 237)
        txtProducto.Name = "txtProducto"
        txtProducto.Size = New Size(182, 27)
        txtProducto.TabIndex = 17
        ' 
        ' lblProducto
        ' 
        lblProducto.AutoSize = True
        lblProducto.ForeColor = Color.Gainsboro
        lblProducto.Location = New Point(12, 214)
        lblProducto.Name = "lblProducto"
        lblProducto.Size = New Size(73, 20)
        lblProducto.TabIndex = 16
        lblProducto.Text = "Producto " ' txtID
        ' 
        txtID.Location = New Point(12, 308)
        txtID.Name = "txtID"
        txtID.Size = New Size(182, 27)
        txtID.TabIndex = 19
        ' 
        ' lblMarca
        ' 
        lblMarca.AutoSize = True
        lblMarca.ForeColor = Color.Gainsboro
        lblMarca.Location = New Point(12, 285)
        lblMarca.Name = "lblMarca"
        lblMarca.Size = New Size(50, 20)
        lblMarca.TabIndex = 18
        lblMarca.Text = "Marca" ' Proveedores
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(34, 33, 74)
        ClientSize = New Size(963, 498)
        Controls.Add(txtID)
        Controls.Add(lblMarca)
        Controls.Add(txtProducto)
        Controls.Add(lblProducto)
        Controls.Add(txtContacto)
        Controls.Add(lblContacto)
        Controls.Add(txtCorreo)
        Controls.Add(lblCorreo)
        Controls.Add(txtNombre)
        Controls.Add(lblNombre)
        Controls.Add(btnImprimir)
        Controls.Add(btnActualiza)
        Controls.Add(btnEliminar)
        Controls.Add(btnmodificar)
        Controls.Add(btnañadir)
        Controls.Add(DataGridView1)
        Name = "Proveedores"
        Text = "Proveedores"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnañadir As FontAwesome.Sharp.IconButton
    Friend WithEvents btnmodificar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnActualiza As FontAwesome.Sharp.IconButton
    Friend WithEvents btnImprimir As FontAwesome.Sharp.IconButton
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents txtContacto As TextBox
    Friend WithEvents lblContacto As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents lblProducto As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblMarca As Label
End Class
