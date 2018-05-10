Public Class frmMain

   
   Private Sub btnPLay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPLay.Click
      Me.Hide()
      frmPlayers.ShowDialog(Me)
      Me.Show()
   End Sub

  
   Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
      End
   End Sub
End Class
