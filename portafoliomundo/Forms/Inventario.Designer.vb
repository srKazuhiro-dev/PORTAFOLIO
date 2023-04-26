<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
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
        lblID = New Label()
        txtID = New TextBox()
        txtMarca = New TextBox()
        txtStock = New TextBox()
        txtDescripcion = New TextBox()
        DataGridView1 = New DataGridView()
        lblMarca = New Label()
        lblDescripcion = New Label()
        lblStock = New Label()
        btnañadir = New FontAwesome.Sharp.IconButton()
        btnmodificar = New FontAwesome.Sharp.IconButton()
        btneliminar = New FontAwesome.Sharp.IconButton()
        btnactualizar = New FontAwesome.Sharp.IconButton()
        txtPrecio = New TextBox()
        lblprecio = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.ForeColor = Color.Gainsboro
        lblID.Location = New Point(12, 9)
        lblID.Name = "lblID"
        lblID.Size = New Size(24, 20)
        lblID.TabIndex = 3
        lblID.Text = "ID"' 
        ' txtID
        ' 
        txtID.Location = New Point(12, 32)
        txtID.Name = "txtID"
        txtID.Size = New Size(182, 27)
        txtID.TabIndex = 9
        ' 
        ' txtMarca
        ' 
        txtMarca.Location = New Point(12, 103)
        txtMarca.Name = "txtMarca"
        txtMarca.Size = New Size(182, 27)
        txtMarca.TabIndex = 10
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(12, 251)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(182, 27)
        txtStock.TabIndex = 13
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(12, 176)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(182, 27)
        txtDescripcion.TabIndex = 14
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(247, 29)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(691, 323)
        DataGridView1.TabIndex = 15
        ' 
        ' lblMarca
        ' 
        lblMarca.AutoSize = True
        lblMarca.ForeColor = Color.Gainsboro
        lblMarca.Location = New Point(12, 80)
        lblMarca.Name = "lblMarca"
        lblMarca.Size = New Size(50, 20)
        lblMarca.TabIndex = 19
        lblMarca.Text = "Marca"' 
        ' lblDescripcion
        ' 
        lblDescripcion.AutoSize = True
        lblDescripcion.ForeColor = Color.Gainsboro
        lblDescripcion.Location = New Point(12, 153)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New Size(87, 20)
        lblDescripcion.TabIndex = 20
        lblDescripcion.Text = "Descripción"' 
        ' lblStock
        ' 
        lblStock.AutoSize = True
        lblStock.ForeColor = Color.Gainsboro
        lblStock.Location = New Point(12, 228)
        lblStock.Name = "lblStock"
        lblStock.Size = New Size(45, 20)
        lblStock.TabIndex = 21
        lblStock.Text = "Stock"' 
        ' btnañadir
        ' 
        btnañadir.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnañadir.FlatStyle = FlatStyle.Flat
        btnañadir.ForeColor = Color.Gainsboro
        btnañadir.IconChar = FontAwesome.Sharp.IconChar.Add
        btnañadir.IconColor = Color.Gainsboro
        btnañadir.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnañadir.IconSize = 32
        btnañadir.ImageAlign = ContentAlignment.MiddleLeft
        btnañadir.Location = New Point(280, 439)
        btnañadir.Name = "btnañadir"
        btnañadir.Padding = New Padding(10, 0, 20, 0)
        btnañadir.Size = New Size(145, 47)
        btnañadir.TabIndex = 22
        btnañadir.Text = "Añadir"
        btnañadir.TextAlign = ContentAlignment.MiddleLeft
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
        btnmodificar.ImageAlign = ContentAlignment.MiddleLeft
        btnmodificar.Location = New Point(448, 439)
        btnmodificar.Name = "btnmodificar"
        btnmodificar.Padding = New Padding(10, 0, 20, 0)
        btnmodificar.Size = New Size(145, 47)
        btnmodificar.TabIndex = 23
        btnmodificar.Text = "Modificar"
        btnmodificar.TextAlign = ContentAlignment.MiddleLeft
        btnmodificar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnmodificar.UseVisualStyleBackColor = True
        ' 
        ' btneliminar
        ' 
        btneliminar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btneliminar.FlatStyle = FlatStyle.Flat
        btneliminar.ForeColor = Color.Gainsboro
        btneliminar.IconChar = FontAwesome.Sharp.IconChar.Eraser
        btneliminar.IconColor = Color.Gainsboro
        btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto
        btneliminar.IconSize = 32
        btneliminar.ImageAlign = ContentAlignment.MiddleLeft
        btneliminar.Location = New Point(621, 439)
        btneliminar.Name = "btneliminar"
        btneliminar.Padding = New Padding(10, 0, 20, 0)
        btneliminar.Size = New Size(145, 47)
        btneliminar.TabIndex = 24
        btneliminar.Text = "Eliminar"
        btneliminar.TextAlign = ContentAlignment.MiddleLeft
        btneliminar.TextImageRelation = TextImageRelation.ImageBeforeText
        btneliminar.UseVisualStyleBackColor = True
        ' 
        ' btnactualizar
        ' 
        btnactualizar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnactualizar.FlatStyle = FlatStyle.Flat
        btnactualizar.ForeColor = Color.Gainsboro
        btnactualizar.IconChar = FontAwesome.Sharp.IconChar.RotateForward
        btnactualizar.IconColor = Color.Gainsboro
        btnactualizar.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnactualizar.IconSize = 32
        btnactualizar.ImageAlign = ContentAlignment.MiddleLeft
        btnactualizar.Location = New Point(795, 439)
        btnactualizar.Name = "btnactualizar"
        btnactualizar.Padding = New Padding(10, 0, 20, 0)
        btnactualizar.Size = New Size(145, 47)
        btnactualizar.TabIndex = 25
        btnactualizar.Text = "Actualiza"
        btnactualizar.TextAlign = ContentAlignment.MiddleLeft
        btnactualizar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnactualizar.UseVisualStyleBackColor = True
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(12, 325)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(182, 27)
        txtPrecio.TabIndex = 26
        ' 
        ' lblprecio
        ' 
        lblprecio.AutoSize = True
        lblprecio.ForeColor = Color.Gainsboro
        lblprecio.Location = New Point(12, 303)
        lblprecio.Name = "lblprecio"
        lblprecio.Size = New Size(50, 20)
        lblprecio.TabIndex = 27
        lblprecio.Text = "Precio"' 
        ' Inventario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(963, 498)
        Controls.Add(lblprecio)
        Controls.Add(txtPrecio)
        Controls.Add(btnactualizar)
        Controls.Add(btneliminar)
        Controls.Add(btnmodificar)
        Controls.Add(btnañadir)
        Controls.Add(lblStock)
        Controls.Add(lblDescripcion)
        Controls.Add(lblMarca)
        Controls.Add(DataGridView1)
        Controls.Add(txtDescripcion)
        Controls.Add(txtStock)
        Controls.Add(txtMarca)
        Controls.Add(txtID)
        Controls.Add(lblID)
        Name = "Inventario"
        Text = "Inventario"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblMarca As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents btnañadir As FontAwesome.Sharp.IconButton
    Friend WithEvents btnmodificar As FontAwesome.Sharp.IconButton
    Friend WithEvents btneliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnactualizar As FontAwesome.Sharp.IconButton
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblprecio As Label
End Class
