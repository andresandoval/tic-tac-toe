Public Class frmPlayers


   Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
      Dim p1 As String = Me.txtPlayer1.Text
      Dim p2 As String = Me.txtPlayer2.Text
      If (p1.Length <= 0 Or p2.Length <= 0) Then
         MsgBox("Se debe ingresar el nombre de ambos jugadores")
         Return
      End If
      Me.Hide()
      Dim frm As New frmPlay(p1, p2)
      Me.Hide()
      frm.ShowDialog(Me)
      frm.Dispose()
      Me.Dispose()
   End Sub
End Class