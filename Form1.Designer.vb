<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblTitle = New Label()
        lblInstruction = New Label()
        btnStartRound = New Button()
        pnlSignal = New Panel()
        lblStatus = New Label()
        lblReactionTime = New Label()
        lblBestTime = New Label()
        lblScore = New Label()
        btnRestart = New Button()
        btnExit = New Button()
        waitTimer = New Timer(components)
        reactionTimer = New Timer(components)
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(220, 25)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(216, 28)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Reaction Timer Game"
        ' 
        ' lblInstruction
        ' 
        lblInstruction.AutoSize = True
        lblInstruction.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblInstruction.Location = New Point(220, 80)
        lblInstruction.Name = "lblInstruction"
        lblInstruction.Size = New Size(105, 28)
        lblInstruction.TabIndex = 1
        lblInstruction.Text = "Instruction"
        ' 
        ' btnStartRound
        ' 
        btnStartRound.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnStartRound.Location = New Point(224, 140)
        btnStartRound.Name = "btnStartRound"
        btnStartRound.Size = New Size(134, 42)
        btnStartRound.TabIndex = 2
        btnStartRound.Text = "Start Round"
        btnStartRound.UseVisualStyleBackColor = True
        ' 
        ' pnlSignal
        ' 
        pnlSignal.Location = New Point(231, 213)
        pnlSignal.Name = "pnlSignal"
        pnlSignal.Size = New Size(332, 100)
        pnlSignal.TabIndex = 3
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(100, 334)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(65, 28)
        lblStatus.TabIndex = 1
        lblStatus.Text = "Status"
        ' 
        ' lblReactionTime
        ' 
        lblReactionTime.AutoSize = True
        lblReactionTime.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblReactionTime.Location = New Point(373, 334)
        lblReactionTime.Name = "lblReactionTime"
        lblReactionTime.Size = New Size(134, 28)
        lblReactionTime.TabIndex = 1
        lblReactionTime.Text = "Reaction Time"
        ' 
        ' lblBestTime
        ' 
        lblBestTime.AutoSize = True
        lblBestTime.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBestTime.Location = New Point(616, 334)
        lblBestTime.Name = "lblBestTime"
        lblBestTime.Size = New Size(95, 28)
        lblBestTime.TabIndex = 1
        lblBestTime.Text = "Best Time"
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblScore.Location = New Point(231, 389)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(61, 28)
        lblScore.TabIndex = 1
        lblScore.Text = "Score"
        ' 
        ' btnRestart
        ' 
        btnRestart.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRestart.Location = New Point(429, 140)
        btnRestart.Name = "btnRestart"
        btnRestart.Size = New Size(134, 42)
        btnRestart.TabIndex = 2
        btnRestart.Text = "Restart"
        btnRestart.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(595, 411)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(134, 42)
        btnExit.TabIndex = 2
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' waitTimer
        ' 
        ' 
        ' reactionTimer
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 484)
        Controls.Add(pnlSignal)
        Controls.Add(btnExit)
        Controls.Add(btnRestart)
        Controls.Add(btnStartRound)
        Controls.Add(lblScore)
        Controls.Add(lblBestTime)
        Controls.Add(lblReactionTime)
        Controls.Add(lblStatus)
        Controls.Add(lblInstruction)
        Controls.Add(lblTitle)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInstruction As Label
    Friend WithEvents btnStartRound As Button
    Friend WithEvents pnlSignal As Panel
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblReactionTime As Label
    Friend WithEvents lblBestTime As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents btnRestart As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents waitTimer As Timer
    Friend WithEvents reactionTimer As Timer

End Class
