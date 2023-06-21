<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Boton = New System.Windows.Forms.Button()
        Me.dgVector = New System.Windows.Forms.DataGridView()
        Me.dgVectorNuevo = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgVector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgVectorNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Boton
        '
        Me.Boton.Location = New System.Drawing.Point(489, 58)
        Me.Boton.Name = "Boton"
        Me.Boton.Size = New System.Drawing.Size(75, 23)
        Me.Boton.TabIndex = 0
        Me.Boton.Text = "Ejecutar"
        Me.Boton.UseVisualStyleBackColor = True
        '
        'dgVector
        '
        Me.dgVector.AllowUserToAddRows = False
        Me.dgVector.AllowUserToDeleteRows = False
        Me.dgVector.AllowUserToResizeColumns = False
        Me.dgVector.AllowUserToResizeRows = False
        Me.dgVector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVector.ColumnHeadersVisible = False
        Me.dgVector.Location = New System.Drawing.Point(12, 56)
        Me.dgVector.Name = "dgVector"
        Me.dgVector.RowHeadersVisible = False
        Me.dgVector.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgVector.ShowCellToolTips = False
        Me.dgVector.ShowRowErrors = False
        Me.dgVector.Size = New System.Drawing.Size(403, 25)
        Me.dgVector.TabIndex = 1
        '
        'dgVectorNuevo
        '
        Me.dgVectorNuevo.AllowUserToAddRows = False
        Me.dgVectorNuevo.AllowUserToDeleteRows = False
        Me.dgVectorNuevo.AllowUserToResizeColumns = False
        Me.dgVectorNuevo.AllowUserToResizeRows = False
        Me.dgVectorNuevo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVectorNuevo.ColumnHeadersVisible = False
        Me.dgVectorNuevo.Location = New System.Drawing.Point(12, 132)
        Me.dgVectorNuevo.Name = "dgVectorNuevo"
        Me.dgVectorNuevo.RowHeadersVisible = False
        Me.dgVectorNuevo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgVectorNuevo.ShowCellToolTips = False
        Me.dgVectorNuevo.ShowRowErrors = False
        Me.dgVectorNuevo.Size = New System.Drawing.Size(603, 25)
        Me.dgVectorNuevo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ingrese Vector original:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "El Vector alterado es: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 203)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgVectorNuevo)
        Me.Controls.Add(Me.dgVector)
        Me.Controls.Add(Me.Boton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgVector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgVectorNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Boton As System.Windows.Forms.Button
    Friend WithEvents dgVector As System.Windows.Forms.DataGridView
    Friend WithEvents dgVectorNuevo As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
