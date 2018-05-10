<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
      Me.btnPLay = New System.Windows.Forms.Button()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.btnExit = New System.Windows.Forms.Button()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'btnPLay
      '
      Me.btnPLay.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnPLay.Location = New System.Drawing.Point(12, 299)
      Me.btnPLay.Name = "btnPLay"
      Me.btnPLay.Size = New System.Drawing.Size(329, 30)
      Me.btnPLay.TabIndex = 0
      Me.btnPLay.Text = "&Jugar..."
      Me.btnPLay.UseVisualStyleBackColor = True
      '
      'PictureBox1
      '
      Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.PictureBox1.Image = Global.tresEnRaya.My.Resources.Resources.gif
      Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(424, 336)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.PictureBox1.TabIndex = 1
      Me.PictureBox1.TabStop = False
      '
      'btnExit
      '
      Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnExit.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnExit.Location = New System.Drawing.Point(347, 299)
      Me.btnExit.Name = "btnExit"
      Me.btnExit.Size = New System.Drawing.Size(65, 30)
      Me.btnExit.TabIndex = 2
      Me.btnExit.Text = "&Salir"
      Me.btnExit.UseVisualStyleBackColor = True
      '
      'frmMain
      '
      Me.AcceptButton = Me.btnPLay
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.CancelButton = Me.btnExit
      Me.ClientSize = New System.Drawing.Size(424, 336)
      Me.ControlBox = False
      Me.Controls.Add(Me.btnExit)
      Me.Controls.Add(Me.btnPLay)
      Me.Controls.Add(Me.PictureBox1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmMain"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Principal"
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents btnPLay As System.Windows.Forms.Button
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
