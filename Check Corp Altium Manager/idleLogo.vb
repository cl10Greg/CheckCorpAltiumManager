Public Class idleLogo
    Private moveSpeed As Integer
    Private xDir As Integer
    Private yDir As Integer


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Check to see if you can move
        'Moving Right
        If xDir = 1 Then
            If picLogo.Left + picLogo.Width + moveSpeed > Me.Width Then
                xDir = 0
            End If
            'Moving Left
        Else
            If picLogo.Left - moveSpeed < 0 Then
                xDir = 1
            End If
        End If

        'Moving Down
        If yDir = 1 Then
            If picLogo.Top + picLogo.Height + moveSpeed > Me.Height Then
                yDir = 0
            End If
            'Moving Up
        Else
            If picLogo.Top - moveSpeed < 0 Then
                yDir = 1
            End If
        End If
        'Find directions
        If xDir = 1 Then
            picLogo.Left = picLogo.Left + moveSpeed
        Else
            picLogo.Left = picLogo.Left - moveSpeed
        End If

        If yDir = 1 Then
            picLogo.Top = picLogo.Top + moveSpeed
        Else
            picLogo.Top = picLogo.Top - moveSpeed
        End If
    End Sub

    Private Sub idleLogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim generator As New Random
        'Set the speed and direction
        moveSpeed = 10
        xDir = generator.Next(1)
        yDir = generator.Next(1)

    End Sub
End Class
