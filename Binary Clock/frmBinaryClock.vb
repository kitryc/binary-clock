Public Class frmBinaryClock
    Private Sub frmBinaryClock_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        timeClock.Interval = 1000
        timeClock.Start()


    End Sub

    Private Sub timeClock_Tick(sender As Object, e As EventArgs) Handles timeClock.Tick
        lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt")

        secondOnes()
        secondTens()
        minuteOnes()
        minuteTens()
        hourOnes()
        hourTens()
    End Sub
    '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------'

    Private Sub secondOnes()
        'Code for the second ones row'
        Dim intSecondOnes As Integer = Now.Second.ToString("D2").Substring(1, 1)
        Console.WriteLine(intSecondOnes)

        picSec1.Image = My.Resources.gray
        picSec2.Image = My.Resources.gray
        picSec3.Image = My.Resources.gray
        picSec4.Image = My.Resources.gray

        If intSecondOnes >= 8 Then
            intSecondOnes -= 8
            picSec4.Image = My.Resources.blue

        Else
            picSec4.Image = My.Resources.gray

        End If

        If intSecondOnes >= 4 Then
            intSecondOnes -= 4
            picSec3.Image = My.Resources.blue

        Else
            picSec3.Image = My.Resources.gray

        End If

        If intSecondOnes >= 2 Then
            intSecondOnes -= 2
            picSec2.Image = My.Resources.blue

        Else
            picSec2.Image = My.Resources.gray

        End If

        If intSecondOnes >= 1 Then
            intSecondOnes -= 1
            picSec1.Image = My.Resources.blue

        Else
            picSec1.Image = My.Resources.gray

        End If
    End Sub
    'Code for the second 10s row'
    Private Sub secondTens()
        Dim intSecondTens As Integer = Now.Second.ToString("D2").Substring(0, 1)

        If intSecondTens >= 4 Then
            intSecondTens -= 4
            picSec7.Image = My.Resources.blue

        Else
            picSec7.Image = My.Resources.gray

        End If

        If intSecondTens >= 2 Then
            intSecondTens -= 2
            picSec6.Image = My.Resources.blue

        Else
            picSec6.Image = My.Resources.gray

        End If

        If intSecondTens >= 1 Then
            intSecondTens -= 1
            picSec5.Image = My.Resources.blue

        Else
            picSec5.Image = My.Resources.gray

        End If
    End Sub
    'Code for the minute ones row'
    Private Sub minuteOnes()
        Dim intMinuteOnes As Integer = Now.Minute.ToString("D2").Substring(1, 1)

        If intMinuteOnes >= 8 Then
            intMinuteOnes -= 8
            picMin4.Image = My.Resources.blue

        Else
            picMin4.Image = My.Resources.gray

        End If

        If intMinuteOnes >= 4 Then
            intMinuteOnes -= 4
            picMin3.Image = My.Resources.blue

        Else
            picMin3.Image = My.Resources.gray

        End If

        If intMinuteOnes >= 2 Then
            intMinuteOnes -= 2
            picMin2.Image = My.Resources.blue

        Else
            picMin2.Image = My.Resources.gray

        End If

        If intMinuteOnes >= 1 Then
            intMinuteOnes -= 1
            picMin1.Image = My.Resources.blue

        Else
            picMin1.Image = My.Resources.gray

        End If
    End Sub

    Private Sub minuteTens()
        Dim intMinuteTens As Integer = Now.Minute.ToString("D2").Substring(0, 1)

        If intMinuteTens >= 4 Then
            intMinuteTens -= 4
            picMin7.Image = My.Resources.blue

        Else
            picMin7.Image = My.Resources.gray

        End If

        If intMinuteTens >= 2 Then
            intMinuteTens -= 2
            picMin6.Image = My.Resources.blue

        Else
            picMin6.Image = My.Resources.gray

        End If
        If intMinuteTens >= 1 Then
            intMinuteTens -= 1
            picMin5.Image = My.Resources.blue

        Else
            picMin5.Image = My.Resources.gray

        End If

    End Sub

    Private Sub hourOnes()
        Dim intHoursOnes As Integer = Now.Hour.ToString("D2").Substring(1, 1)

        If intHoursOnes >= 8 Then
            intHoursOnes -= 8
            picHour4.Image = My.Resources.blue

        Else
            picHour4.Image = My.Resources.gray

        End If

        If intHoursOnes >= 4 Then
            intHoursOnes -= 4
            picHour3.Image = My.Resources.blue

        Else
            picHour3.Image = My.Resources.gray

        End If

        If intHoursOnes >= 2 Then
            intHoursOnes -= 2
            picHour2.Image = My.Resources.blue

        Else
            picHour2.Image = My.Resources.gray

        End If

        If intHoursOnes >= 1 Then
            intHoursOnes -= 1
            picHour1.Image = My.Resources.blue

        Else
            picHour1.Image = My.Resources.gray

        End If

    End Sub

    Private Sub hourTens()
        Dim intHoursTens As Integer = Now.Hour.ToString("D2").Substring(0, 1)

        If intHoursTens >= 1 Then
            intHoursTens -= 1
            picHour1.Image = My.Resources.blue

        Else
            picHour1.Image = My.Resources.gray

        End If
    End Sub
End Class
