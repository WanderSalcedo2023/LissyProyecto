<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMENU
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarEstudiantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeEstudiantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SumadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CasaDeCambioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NominaSemanalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirDelSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoToolStripMenuItem, Me.CToolStripMenuItem, Me.ReporteToolStripMenuItem, Me.HerramientasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(585, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'CToolStripMenuItem
        '
        Me.CToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarEstudiantesToolStripMenuItem, Me.ConsultarLibrosToolStripMenuItem})
        Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
        Me.CToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.CToolStripMenuItem.Text = "Consulta "
        '
        'ConsultarEstudiantesToolStripMenuItem
        '
        Me.ConsultarEstudiantesToolStripMenuItem.Name = "ConsultarEstudiantesToolStripMenuItem"
        Me.ConsultarEstudiantesToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ConsultarEstudiantesToolStripMenuItem.Text = "Consultar Estudiantes"
        '
        'ConsultarLibrosToolStripMenuItem
        '
        Me.ConsultarLibrosToolStripMenuItem.Name = "ConsultarLibrosToolStripMenuItem"
        Me.ConsultarLibrosToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ConsultarLibrosToolStripMenuItem.Text = "Consultar Empleados"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteDeEstudiantesToolStripMenuItem, Me.ReporteDeEmpleadosToolStripMenuItem, Me.ReporteDeLibrosToolStripMenuItem, Me.ReporteDeUsuariosToolStripMenuItem})
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ReporteToolStripMenuItem.Text = "Reporte"
        '
        'ReporteDeEstudiantesToolStripMenuItem
        '
        Me.ReporteDeEstudiantesToolStripMenuItem.Name = "ReporteDeEstudiantesToolStripMenuItem"
        Me.ReporteDeEstudiantesToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ReporteDeEstudiantesToolStripMenuItem.Text = "Reporte de Estudiantes"
        '
        'ReporteDeEmpleadosToolStripMenuItem
        '
        Me.ReporteDeEmpleadosToolStripMenuItem.Name = "ReporteDeEmpleadosToolStripMenuItem"
        Me.ReporteDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ReporteDeEmpleadosToolStripMenuItem.Text = "Reporte de Empleados"
        '
        'ReporteDeLibrosToolStripMenuItem
        '
        Me.ReporteDeLibrosToolStripMenuItem.Name = "ReporteDeLibrosToolStripMenuItem"
        Me.ReporteDeLibrosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ReporteDeLibrosToolStripMenuItem.Text = "Reporte de Libros"
        '
        'ReporteDeUsuariosToolStripMenuItem
        '
        Me.ReporteDeUsuariosToolStripMenuItem.Name = "ReporteDeUsuariosToolStripMenuItem"
        Me.ReporteDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ReporteDeUsuariosToolStripMenuItem.Text = "Reporte de Usuarios"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SumadoraToolStripMenuItem, Me.CasaDeCambioToolStripMenuItem, Me.NominaSemanalToolStripMenuItem, Me.SalirDelSistemaToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'SumadoraToolStripMenuItem
        '
        Me.SumadoraToolStripMenuItem.Name = "SumadoraToolStripMenuItem"
        Me.SumadoraToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SumadoraToolStripMenuItem.Text = "Sumadora"
        '
        'CasaDeCambioToolStripMenuItem
        '
        Me.CasaDeCambioToolStripMenuItem.Name = "CasaDeCambioToolStripMenuItem"
        Me.CasaDeCambioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CasaDeCambioToolStripMenuItem.Text = "Casa de cambio"
        '
        'NominaSemanalToolStripMenuItem
        '
        Me.NominaSemanalToolStripMenuItem.Name = "NominaSemanalToolStripMenuItem"
        Me.NominaSemanalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NominaSemanalToolStripMenuItem.Text = "Nomina Semanal"
        '
        'SalirDelSistemaToolStripMenuItem
        '
        Me.SalirDelSistemaToolStripMenuItem.Name = "SalirDelSistemaToolStripMenuItem"
        Me.SalirDelSistemaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirDelSistemaToolStripMenuItem.Text = "Salir del Sistema"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WinFormsApp2.My.Resources.Resources.BT
        Me.PictureBox1.Location = New System.Drawing.Point(24, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(537, 315)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'FrmMENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(585, 388)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMENU"
        Me.Text = " FrmMenu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SumadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CasaDeCambioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NominaSemanalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirDelSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarEstudiantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarLibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeEstudiantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeLibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
