<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccesoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalzadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CamisetasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChaquetasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PantalonesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SudaderasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaloncestoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CiclismoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FútbolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunningToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YogaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonCerrar = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(387, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Indica producto o deporte "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(380, 303)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(380, 26)
        Me.TextBox1.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(514, 358)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 27)
        Me.Button2.TabIndex = 10
        Me.Button2.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.DeportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(802, 34)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccesoriosToolStripMenuItem, Me.CalzadoToolStripMenuItem, Me.CamisetasToolStripMenuItem, Me.ChaquetasToolStripMenuItem, Me.PantalonesToolStripMenuItem, Me.SudaderasToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(117, 30)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'AccesoriosToolStripMenuItem
        '
        Me.AccesoriosToolStripMenuItem.Name = "AccesoriosToolStripMenuItem"
        Me.AccesoriosToolStripMenuItem.Size = New System.Drawing.Size(214, 34)
        Me.AccesoriosToolStripMenuItem.Text = "Accesorios"
        '
        'CalzadoToolStripMenuItem
        '
        Me.CalzadoToolStripMenuItem.Name = "CalzadoToolStripMenuItem"
        Me.CalzadoToolStripMenuItem.Size = New System.Drawing.Size(214, 34)
        Me.CalzadoToolStripMenuItem.Text = "Calzado"
        '
        'CamisetasToolStripMenuItem
        '
        Me.CamisetasToolStripMenuItem.Name = "CamisetasToolStripMenuItem"
        Me.CamisetasToolStripMenuItem.Size = New System.Drawing.Size(214, 34)
        Me.CamisetasToolStripMenuItem.Text = "Camisetas"
        '
        'ChaquetasToolStripMenuItem
        '
        Me.ChaquetasToolStripMenuItem.Name = "ChaquetasToolStripMenuItem"
        Me.ChaquetasToolStripMenuItem.Size = New System.Drawing.Size(214, 34)
        Me.ChaquetasToolStripMenuItem.Text = "Chaquetas"
        '
        'PantalonesToolStripMenuItem
        '
        Me.PantalonesToolStripMenuItem.Name = "PantalonesToolStripMenuItem"
        Me.PantalonesToolStripMenuItem.Size = New System.Drawing.Size(214, 34)
        Me.PantalonesToolStripMenuItem.Text = "Pantalones"
        '
        'SudaderasToolStripMenuItem
        '
        Me.SudaderasToolStripMenuItem.Name = "SudaderasToolStripMenuItem"
        Me.SudaderasToolStripMenuItem.Size = New System.Drawing.Size(214, 34)
        Me.SudaderasToolStripMenuItem.Text = "Sudaderas"
        '
        'DeportesToolStripMenuItem
        '
        Me.DeportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BaloncestoToolStripMenuItem, Me.CiclismoToolStripMenuItem, Me.FútbolToolStripMenuItem, Me.RunningToolStripMenuItem, Me.YogaToolStripMenuItem})
        Me.DeportesToolStripMenuItem.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeportesToolStripMenuItem.Name = "DeportesToolStripMenuItem"
        Me.DeportesToolStripMenuItem.Size = New System.Drawing.Size(108, 30)
        Me.DeportesToolStripMenuItem.Text = "Deportes"
        '
        'BaloncestoToolStripMenuItem
        '
        Me.BaloncestoToolStripMenuItem.Name = "BaloncestoToolStripMenuItem"
        Me.BaloncestoToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.BaloncestoToolStripMenuItem.Text = "Baloncesto"
        '
        'CiclismoToolStripMenuItem
        '
        Me.CiclismoToolStripMenuItem.Name = "CiclismoToolStripMenuItem"
        Me.CiclismoToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.CiclismoToolStripMenuItem.Text = "Ciclismo"
        '
        'FútbolToolStripMenuItem
        '
        Me.FútbolToolStripMenuItem.Name = "FútbolToolStripMenuItem"
        Me.FútbolToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.FútbolToolStripMenuItem.Text = "Fútbol"
        '
        'RunningToolStripMenuItem
        '
        Me.RunningToolStripMenuItem.Name = "RunningToolStripMenuItem"
        Me.RunningToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.RunningToolStripMenuItem.Text = "Running"
        '
        'YogaToolStripMenuItem
        '
        Me.YogaToolStripMenuItem.Name = "YogaToolStripMenuItem"
        Me.YogaToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.YogaToolStripMenuItem.Text = "Yoga"
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.BackgroundImage = CType(resources.GetObject("ButtonCerrar.BackgroundImage"), System.Drawing.Image)
        Me.ButtonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonCerrar.Location = New System.Drawing.Point(756, 0)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(34, 38)
        Me.ButtonCerrar.TabIndex = 16
        Me.ButtonCerrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(802, 460)
        Me.Controls.Add(Me.ButtonCerrar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccesoriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalzadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CamisetasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChaquetasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PantalonesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SudaderasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaloncestoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CiclismoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FútbolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YogaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RunningToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonCerrar As Button
End Class
