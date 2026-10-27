Public Class Form1
    Dim rnd As New Random()
    Dim waitingForSignal As Boolean = False
    Dim signalActive As Boolean = False
    Dim reactionTimerCount As Integer = 0
    Dim delayBeforeSignal As Integer = 0
    Dim score As Integer = 0
    Dim bestTime As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = "Reaction Timer Game"
        lblInstruction.Text = "Click Start Round, then wait for the signal."

        pnlSignal.BackColor = Color.Gray
        lblStatus.Text = "Click Start Round to begin."
        lblReactionTime.Text = "Reaction Time: -"
        lblBestTime.Text = "Best Time: -"
        lblScore.Text = "Score: 0"
    End Sub

    Private Sub btnStartRound_Click(sender As Object, e As EventArgs) Handles btnStartRound.Click
        waitingForSignal = True
        signalActive = False
        reactionTimerCount = 0

        delayBeforeSignal = rnd.Next(1000, 4001)

        pnlSignal.BackColor = Color.Gray
        lblStatus.Text = "Wait for the signal..."

        waitTimer.Interval = delayBeforeSignal
        waitTimer.Start()
    End Sub

    Private Sub waitTimer_Tick(sender As Object, e As EventArgs) Handles waitTimer.Tick
        waitTimer.Stop()
        waitingForSignal = False
        signalActive = True
        reactionTimerCount = 0

        pnlSignal.BackColor = Color.LimeGreen
        lblStatus.Text = "CLICK NOW!"

        reactionTimer.Interval = 1
        reactionTimer.Start()
    End Sub

    Private Sub reactionTimer_Tick(sender As Object, e As EventArgs) Handles reactionTimer.Tick
        reactionTimerCount += 1
    End Sub

    Private Sub pnlSignal_Click(sender As Object, e As EventArgs) Handles pnlSignal.Click
        If signalActive Then
            reactionTimer.Stop()
            signalActive = False

            lblReactionTime.Text = "Reaction Time: " & reactionTimerCount.ToString() & " ms"
            lblStatus.Text = "Good reaction!"
            pnlSignal.BackColor = Color.LightBlue

            If bestTime = 0 OrElse reactionTimerCount < bestTime Then
                bestTime = reactionTimerCount
                lblBestTime.Text = "Best Time: " & bestTime.ToString() & " ms"
            End If

            If reactionTimerCount <= 250 Then
                score += 10
            ElseIf reactionTimerCount <= 400 Then
                score += 7
            ElseIf reactionTimerCount <= 600 Then
                score += 5
            Else
                score += 3
            End If

            lblScore.Text = "Score: " & score.ToString()

        ElseIf waitingForSignal Then
            waitTimer.Stop()
            waitingForSignal = False
            signalActive = False

            pnlSignal.BackColor = Color.Red
            lblStatus.Text = "Too soon! Wait for the signal."
            MessageBox.Show("Too early!")
        End If
    End Sub

    Private Sub lblStatus_Click(sender As Object, e As EventArgs) Handles lblStatus.Click

    End Sub
End Class
