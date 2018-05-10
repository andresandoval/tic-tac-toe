Public Class frmPlay

   Private player1 As String
   Private player2 As String
   Private turn As Integer = 0
   Private tags() As String = {"X", "O"}
   Private times As Integer = 0

   Private ReadOnly Property getCursor() As Cursor
      Get
         Dim icon As System.Drawing.Icon = IIf(Me.turn = 0, My.Resources.cross, My.Resources.nought)
         Return New Cursor(icon.Handle)
      End Get
   End Property

   Private ReadOnly Property getPlayer
      Get
         Return IIf(Me.turn = 0, Me.player1, Me.player2)
      End Get
   End Property

   Private ReadOnly Property toogleTurn
      Get
         Return IIf(Me.turn = 0, 1, 0)
      End Get
   End Property

   Private Sub setCursor()
      Dim c = Me.getCursor
      Me.pxB1.Cursor = IIf(Me.pxB1.Tag <> "", Cursors.Default, c)
      Me.pxB2.Cursor = IIf(Me.pxB2.Tag <> "", Cursors.Default, c)
      Me.pxB3.Cursor = IIf(Me.pxB3.Tag <> "", Cursors.Default, c)
      Me.pxB4.Cursor = IIf(Me.pxB4.Tag <> "", Cursors.Default, c)
      Me.pxB5.Cursor = IIf(Me.pxB5.Tag <> "", Cursors.Default, c)
      Me.pxB6.Cursor = IIf(Me.pxB6.Tag <> "", Cursors.Default, c)
      Me.pxB7.Cursor = IIf(Me.pxB7.Tag <> "", Cursors.Default, c)
      Me.pxB8.Cursor = IIf(Me.pxB8.Tag <> "", Cursors.Default, c)
      Me.pxB9.Cursor = IIf(Me.pxB9.Tag <> "", Cursors.Default, c)
      Me.txtStatus.Text = "Es turno de " & Me.getPlayer & " (" & Me.tags(Me.turn) & ")"
   End Sub

   Private Function hasWon() As Boolean
      'dim match(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}, {1, 4, 7}, {2, 5, 8}, {3, 6, 9}, {3, 5, 7}, {1, 5, 9}}

      Dim marked As New List(Of Integer)
      Dim winColor As Color = Color.Lime

      If (Me.pxB1.Tag = Me.tags(Me.turn)) Then
         marked.Add(1)
      End If
      If (Me.pxB2.Tag = Me.tags(Me.turn)) Then
         marked.Add(2)
      End If
      If (Me.pxB3.Tag = Me.tags(Me.turn)) Then
         marked.Add(3)
      End If
      If (Me.pxB4.Tag = Me.tags(Me.turn)) Then
         marked.Add(4)
      End If
      If (Me.pxB5.Tag = Me.tags(Me.turn)) Then
         marked.Add(5)
      End If
      If (Me.pxB6.Tag = Me.tags(Me.turn)) Then
         marked.Add(6)
      End If
      If (Me.pxB7.Tag = Me.tags(Me.turn)) Then
         marked.Add(7)
      End If
      If (Me.pxB8.Tag = Me.tags(Me.turn)) Then
         marked.Add(8)
      End If
      If (Me.pxB9.Tag = Me.tags(Me.turn)) Then
         marked.Add(9)
      End If

      If (marked.Contains(1) And marked.Contains(2) And marked.Contains(3)) Then
         Me.pxB1.BackColor = winColor
         Me.pxB2.BackColor = winColor
         Me.pxB3.BackColor = winColor
         Return (True)
      End If
      If (marked.Contains(4) And marked.Contains(5) And marked.Contains(6)) Then
         Me.pxB4.BackColor = winColor
         Me.pxB5.BackColor = winColor
         Me.pxB6.BackColor = winColor
         Return True
      End If
      If (marked.Contains(9) And marked.Contains(8) And marked.Contains(7)) Then
         Me.pxB7.BackColor = winColor
         Me.pxB8.BackColor = winColor
         Me.pxB9.BackColor = winColor
         Return True
      End If
      If (marked.Contains(1) And marked.Contains(4) And marked.Contains(7)) Then
         Me.pxB1.BackColor = winColor
         Me.pxB4.BackColor = winColor
         Me.pxB7.BackColor = winColor
         Return True
      End If
      If (marked.Contains(5) And marked.Contains(2) And marked.Contains(8)) Then
         Me.pxB5.BackColor = winColor
         Me.pxB2.BackColor = winColor
         Me.pxB8.BackColor = winColor
         Return True
      End If
      If (marked.Contains(6) And marked.Contains(9) And marked.Contains(3)) Then
         Me.pxB6.BackColor = winColor
         Me.pxB9.BackColor = winColor
         Me.pxB3.BackColor = winColor
         Return True
      End If
      If (marked.Contains(3) And marked.Contains(5) And marked.Contains(7)) Then
         Me.pxB3.BackColor = winColor
         Me.pxB5.BackColor = winColor
         Me.pxB7.BackColor = winColor
         Return True
      End If
      If (marked.Contains(1) And marked.Contains(5) And marked.Contains(9)) Then
         Me.pxB1.BackColor = winColor
         Me.pxB5.BackColor = winColor
         Me.pxB9.BackColor = winColor
         Return True
      End If
      Return False
   End Function

   Public Sub New(ByVal p1 As String, ByVal p2 As String)
      InitializeComponent()
      Me.player1 = p1
      Me.player2 = p2
   End Sub

   Private Sub px_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pxB9.Click, pxB8.Click, pxB7.Click, pxB6.Click, pxB5.Click, pxB4.Click, pxB3.Click, pxB2.Click, pxB1.Click
      Dim bx As PictureBox = sender
      If (bx.Tag <> Nothing) Then
         Return
      End If
      Me.times += 1
      bx.Tag = Me.tags(Me.turn)
      bx.Image = IIf(Me.turn = 0, My.Resources.cross_png, My.Resources.nought_png)
      If (Me.hasWon()) Then
         MsgBox("Ganó: " & Me.getPlayer)
         Me.Close()
         Return
      End If
      If (Me.times >= 9) Then
         MsgBox("Ocurrio un empate")
         Me.Close()
         Return
      End If
      Me.turn = Me.toogleTurn
      Me.setCursor()
   End Sub

   Private Sub frmPlay_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      Me.setCursor()
   End Sub
End Class