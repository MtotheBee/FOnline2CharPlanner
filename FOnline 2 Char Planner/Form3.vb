Public Class Form3
    Friend isFullOP As Boolean

    Private Sub Form3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y)
        Me.Left += 230
        Me.Top += 170
        Me.BringToFront()
    End Sub

   
    Private Sub F3TimerMsgBox_Tick(sender As System.Object, e As System.EventArgs) Handles F3TimerMsgBox.Tick
        Me.BringToFront()
        If Me.Opacity = 100 Then
            isFullOP = True
        End If

        Me.Opacity += 0.03
    End Sub

    Private Sub BtnF3Ok_Click(sender As System.Object, e As System.EventArgs) Handles BtnF3Ok.Click
        Me.Close()
    End Sub

    Private Sub BtnF3DontB_Click(sender As System.Object, e As System.EventArgs) Handles BtnF3DontB.Click
        Form1.isDontBother = True
        Me.Close()
    End Sub
End Class