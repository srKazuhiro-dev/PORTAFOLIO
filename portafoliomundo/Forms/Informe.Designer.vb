<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informe
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
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        btnEliminar = New FontAwesome.Sharp.IconButton()
        btnActualiza = New FontAwesome.Sharp.IconButton()
        btnImprimir = New FontAwesome.Sharp.IconButton()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 23)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(939, 234)
        DataGridView1.TabIndex = 0
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
        btnEliminar.ImageAlign = ContentAlignment.MiddleLeft
        btnEliminar.Location = New Point(444, 275)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Padding = New Padding(10, 0, 20, 0)
        btnEliminar.Size = New Size(148, 46)
        btnEliminar.TabIndex = 1
        btnEliminar.Text = "Eliminar"
        btnEliminar.TextAlign = ContentAlignment.MiddleLeft
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
        btnActualiza.ImageAlign = ContentAlignment.MiddleLeft
        btnActualiza.Location = New Point(614, 275)
        btnActualiza.Name = "btnActualiza"
        btnActualiza.Padding = New Padding(10, 0, 20, 0)
        btnActualiza.Size = New Size(148, 46)
        btnActualiza.TabIndex = 2
        btnActualiza.Text = "Actualiza"
        btnActualiza.TextAlign = ContentAlignment.MiddleLeft
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
        btnImprimir.ImageAlign = ContentAlignment.MiddleLeft
        btnImprimir.Location = New Point(789, 275)
        btnImprimir.Name = "btnImprimir"
        btnImprimir.Padding = New Padding(10, 0, 20, 0)
        btnImprimir.Size = New Size(148, 46)
        btnImprimir.TabIndex = 3
        btnImprimir.Text = "Imprimir"
        btnImprimir.TextAlign = ContentAlignment.MiddleLeft
        btnImprimir.TextImageRelation = TextImageRelation.ImageBeforeText
        btnImprimir.UseVisualStyleBackColor = True
        ' 
        ' Informe
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(963, 498)
        Controls.Add(btnImprimir)
        Controls.Add(btnActualiza)
        Controls.Add(btnEliminar)
        Controls.Add(DataGridView1)
        Name = "Informe"
        Text = "Informe"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnActualiza As FontAwesome.Sharp.IconButton
    Friend WithEvents btnImprimir As FontAwesome.Sharp.IconButton
End Class
