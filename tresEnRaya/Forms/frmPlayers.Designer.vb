<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlayers
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlayers))
      Me.txtPlayer1 = New System.Windows.Forms.TextBox()
      Me.txtPlayer2 = New System.Windows.Forms.TextBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.btnStart = New System.Windows.Forms.Button()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'txtPlayer1
      '
      Me.txtPlayer1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPlayer1.Location = New System.Drawing.Point(118, 21)
      Me.txtPlayer1.Margin = New System.Windows.Forms.Padding(4)
      Me.txtPlayer1.Name = "txtPlayer1"
      Me.txtPlayer1.Size = New System.Drawing.Size(344, 23)
      Me.txtPlayer1.TabIndex = 0
      Me.txtPlayer1.Text = "Jugador Nro 1"
      '
      'txtPlayer2
      '
      Me.txtPlayer2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPlayer2.Location = New System.Drawing.Point(118, 69)
      Me.txtPlayer2.Margin = New System.Windows.Forms.Padding(4)
      Me.txtPlayer2.Name = "txtPlayer2"
      Me.txtPlayer2.Size = New System.Drawing.Size(344, 23)
      Me.txtPlayer2.TabIndex = 1
      Me.txtPlayer2.Text = "Jugador Nro 2"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(26, 25)
      Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(72, 16)
      Me.Label1.TabIndex = 2
      Me.Label1.Text = "Jugador 1"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(26, 71)
      Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(72, 16)
      Me.Label2.TabIndex = 3
      Me.Label2.Text = "Jugador 2"
      '
      'btnStart
      '
      Me.btnStart.Location = New System.Drawing.Point(13, 127)
      Me.btnStart.Name = "btnStart"
      Me.btnStart.Size = New System.Drawing.Size(500, 23)
      Me.btnStart.TabIndex = 2
      Me.btnStart.Text = "&Iniciar..."
      Me.btnStart.UseVisualStyleBackColor = True
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(470, 24)
      Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(29, 16)
      Me.Label3.TabIndex = 4
      Me.Label3.Text = "(X)"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(470, 72)
      Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(30, 16)
      Me.Label4.TabIndex = 5
      Me.Label4.Text = "(O)"
      '
      'frmPlayers
      '
      Me.AcceptButton = Me.btnStart
      Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(525, 162)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.btnStart)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.txtPlayer2)
      Me.Controls.Add(Me.txtPlayer1)
      Me.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.Margin = New System.Windows.Forms.Padding(4)
      Me.MaximizeBox = False
      Me.Name = "frmPlayers"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Jugadores"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents txtPlayer1 As System.Windows.Forms.TextBox
   Friend WithEvents txtPlayer2 As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents btnStart As System.Windows.Forms.Button
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
