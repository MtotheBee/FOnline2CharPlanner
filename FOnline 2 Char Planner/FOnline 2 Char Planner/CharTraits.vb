Public Class CharTraits

    Friend senderColor As Color
    Dim checkCounter As Integer = 0


    Sub TraitsMLeave(ByVal sender As System.Object, ByVal Trait As String)
        Static OldTraitCaption As String
        Dim TraitCaption As String

        TraitCaption = Trait

        If senderColor = Color.Gold Then
            sender.ForeColor = Color.Gold
        Else
            sender.ForeColor = Color.LimeGreen
        End If

        OldTraitCaption = TraitCaption
    End Sub

    Sub TraitsCheck(ByVal sender As System.Object, ByVal isChecked As Boolean, ByVal TraitCap As String)
        Dim ctl As Control

        'Check if more then two Traits are checked

        If isChecked = True And checkCounter < 1 Then
            sender.ForeColor = Color.Gold
            checkCounter = checkCounter + 1
        ElseIf isChecked = True And checkCounter = 1 Then
            sender.forecolor = Color.Gold
            For Each ctl In Form1.PanTraits.Controls
                If Not ctl.ForeColor = Color.Gold Then
                    ctl.Visible = False
                End If
            Next
            checkCounter = checkCounter + 1
        ElseIf isChecked = False Then
            checkCounter = checkCounter - 1
            For Each ctl In Form1.PanTraits.Controls
                If ctl.Visible = False Then
                    ctl.Visible = True
                End If
            Next
            sender.ForeColor = Color.LimeGreen
        End If
        senderColor = sender.ForeColor

    End Sub

End Class
