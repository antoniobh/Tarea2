<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NOTE
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
        Me.components = New System.ComponentModel.Container()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ContextMenuStripTools = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NegritaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursivaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubrayadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SombreadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlineacionDerecjaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlineacionIzquierdaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlineacionCentroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlineacionJustificadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.ContextMenuStrip = Me.ContextMenuStripTools
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(396, 426)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(414, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(353, 426)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'ContextMenuStripTools
        '
        Me.ContextMenuStripTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NegritaToolStripMenuItem, Me.CursivaToolStripMenuItem, Me.SubrayadoToolStripMenuItem, Me.SombreadoToolStripMenuItem, Me.AlineacionDerecjaToolStripMenuItem, Me.AlineacionIzquierdaToolStripMenuItem, Me.AlineacionCentroToolStripMenuItem, Me.AlineacionJustificadoToolStripMenuItem})
        Me.ContextMenuStripTools.Name = "ContextMenuStripTools"
        Me.ContextMenuStripTools.Size = New System.Drawing.Size(190, 180)
        '
        'NegritaToolStripMenuItem
        '
        Me.NegritaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NegritaToolStripMenuItem.Name = "NegritaToolStripMenuItem"
        Me.NegritaToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.NegritaToolStripMenuItem.Text = "Negrita"
        '
        'CursivaToolStripMenuItem
        '
        Me.CursivaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CursivaToolStripMenuItem.Name = "CursivaToolStripMenuItem"
        Me.CursivaToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.CursivaToolStripMenuItem.Text = "Cursiva"
        '
        'SubrayadoToolStripMenuItem
        '
        Me.SubrayadoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubrayadoToolStripMenuItem.Name = "SubrayadoToolStripMenuItem"
        Me.SubrayadoToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.SubrayadoToolStripMenuItem.Text = "Subrayado"
        '
        'SombreadoToolStripMenuItem
        '
        Me.SombreadoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SombreadoToolStripMenuItem.Name = "SombreadoToolStripMenuItem"
        Me.SombreadoToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.SombreadoToolStripMenuItem.Text = "Sombreado"
        '
        'AlineacionDerecjaToolStripMenuItem
        '
        Me.AlineacionDerecjaToolStripMenuItem.Name = "AlineacionDerecjaToolStripMenuItem"
        Me.AlineacionDerecjaToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.AlineacionDerecjaToolStripMenuItem.Text = "Alineacion Derecha"
        '
        'AlineacionIzquierdaToolStripMenuItem
        '
        Me.AlineacionIzquierdaToolStripMenuItem.Name = "AlineacionIzquierdaToolStripMenuItem"
        Me.AlineacionIzquierdaToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.AlineacionIzquierdaToolStripMenuItem.Text = "Alineacion Izquierda"
        '
        'AlineacionCentroToolStripMenuItem
        '
        Me.AlineacionCentroToolStripMenuItem.Name = "AlineacionCentroToolStripMenuItem"
        Me.AlineacionCentroToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.AlineacionCentroToolStripMenuItem.Text = "Alineacion Centro"
        '
        'AlineacionJustificadoToolStripMenuItem
        '
        Me.AlineacionJustificadoToolStripMenuItem.Name = "AlineacionJustificadoToolStripMenuItem"
        Me.AlineacionJustificadoToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.AlineacionJustificadoToolStripMenuItem.Text = "Alineacion Justificado"
        '
        'NOTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "NOTE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ContextMenuStripTools.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ContextMenuStripTools As ContextMenuStrip
    Friend WithEvents NegritaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CursivaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubrayadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SombreadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlineacionDerecjaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlineacionIzquierdaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlineacionCentroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlineacionJustificadoToolStripMenuItem As ToolStripMenuItem
End Class
