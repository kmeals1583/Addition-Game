' Author: Kristofer Meals
' Created for my daughter's to learn quick addition
'     techniques while under a time limit.
' Created: 10/11/2020
' Modified: 10/12/2020

Option Explicit On
Option Infer On
Option Strict Off
Public Class mainForm
    'create a random object
    Private randomizer As New Random
    'int var to store the numbers
    Private laddend1, laddend2, laddend3, laddend4, laddend5 As Integer
    Private raddend1, raddend2, raddend3, raddend4, raddend5 As Integer
    Private timeLeft As Integer

    Private Sub ExitToolStipMenuItem_ItemClicked(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim exitconfirm As DialogResult
        exitconfirm =
            MessageBox.Show("Are you sure you wish to exit?", "MATH GAME",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button2)
        If exitconfirm = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        'clear out left side
        'laddend1.Text = String.Empty
        'laddend2.Text = String.Empty
        'laddend3.Text = String.Empty
        'laddend4.Text = String.Empty
        'laddend5.Text = String.Empty

        'clear out right side
        'raddend1.Text = String.Empty
        'raddend2.Text = String.Empty
        'raddend3.Text = String.Empty
        'raddend4.Text = String.Empty
        'raddend5.Text = String.Empty

        'clear answers
        'sum1Numeric.Value = String.Empty
        'sum2Numeric.Value = String.Empty
        'sum3Numeric.Value = String.Empty
        'sum4Numeric.Value = String.Empty
        'sum5Numeric.Value = String.Empty
        Call startTheQuiz()
    End Sub

    Private Sub HowToPlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToPlayToolStripMenuItem.Click
        MessageBox.Show("To play this Math Game, begin by clicking the 'Start Quiz' button.  Random numbers will be generated to add together.  Place your answer in the box before time expires." + ControlChars.NewLine + ControlChars.NewLine + "                   Good Luck and have Fun!! ", "How To Play", MessageBoxButtons.OK, MessageBoxIcon.Question)
    End Sub
    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        MessageBox.Show("Created by Kristofer Meals on October 11, 2020." + ControlChars.NewLine + "                Created in Enterprise, AL." + ControlChars.NewLine + ControlChars.NewLine + "     Thanks to my wonderful wife, Natalie Meals," + ControlChars.NewLine + "                for putting up with me coding!", "About Math Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub answer_Enter1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sum1Numeric.Enter
        Dim answerBox1 = TryCast(sender, NumericUpDown)
        If answerBox1 IsNot Nothing Then
            Dim lengthOfAnswer = answerBox1.Value.ToString().Length
            answerBox1.Select(0, lengthOfAnswer)
        End If
    End Sub
    Private Sub answer_Enter2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sum2Numeric.Enter
        Dim answerBox2 = TryCast(sender, NumericUpDown)
        If answerBox2 IsNot Nothing Then
            Dim lengthOfAnswer = answerBox2.Value.ToString().Length
            answerBox2.Select(0, lengthOfAnswer)
        End If
    End Sub



    Private Sub answer_Enter3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sum3Numeric.Enter
        Dim answerBox3 = TryCast(sender, NumericUpDown)
        If answerBox3 IsNot Nothing Then
            Dim lengthOfAnswer = answerBox3.Value.ToString().Length
            answerBox3.Select(0, lengthOfAnswer)
        End If
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub answer_Enter4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sum4Numeric.Enter
        Dim answerBox4 = TryCast(sender, NumericUpDown)
        If answerBox4 IsNot Nothing Then
            Dim lengthOfAnswer = answerBox4.Value.ToString().Length
            answerBox4.Select(0, lengthOfAnswer)
        End If
    End Sub

    Private Sub answer_Enter5(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sum5Numeric.Enter
        Dim answerBox5 = TryCast(sender, NumericUpDown)
        If answerBox5 IsNot Nothing Then
            Dim lengthOfAnswer = answerBox5.Value.ToString().Length
            answerBox5.Select(0, lengthOfAnswer)
        End If
    End Sub



    'start the quiz by filling the random addends in
    Public Sub startTheQuiz()
        'get random numbers to add
        laddend1 = randomizer.Next(11)
        laddend2 = randomizer.Next(11)
        laddend3 = randomizer.Next(11)
        laddend4 = randomizer.Next(11)
        laddend5 = randomizer.Next(11)
        raddend1 = randomizer.Next(11)
        raddend2 = randomizer.Next(11)
        raddend3 = randomizer.Next(11)
        raddend4 = randomizer.Next(11)
        raddend5 = randomizer.Next(11)

        'convert the random numbers to string left side
        leftAdd1Label.Text = laddend1.ToString()
        leftAdd2Label.Text = laddend2.ToString()
        leftAdd3Label.Text = laddend3.ToString()
        leftAdd4Label.Text = laddend4.ToString()
        leftAdd5Label.Text = laddend5.ToString()

        'convert the random numbers to string right side
        rightAdd1Label.Text = raddend1.ToString()
        rightAdd2Label.Text = raddend2.ToString()
        rightAdd3Label.Text = raddend3.ToString()
        rightAdd4Label.Text = raddend4.ToString()
        rightAdd5Label.Text = raddend5.ToString()

        'sum label set to zero
        sum1Numeric.Value = 0
        sum2Numeric.Value = 0
        sum3Numeric.Value = 0
        sum4Numeric.Value = 0
        sum5Numeric.Value = 0

        'start the timer
        timeLeft = 30
        timerLabel.Text = "30 Seconds"
        Timer1.Start()
    End Sub

    Public Function CheckTheAnswer() As Boolean
        ' continually assess answers - automatic ends game if all correct
        If laddend1 + raddend1 = sum1Numeric.Value AndAlso
        laddend2 + raddend2 = sum2Numeric.Value AndAlso
        laddend3 + raddend3 = sum3Numeric.Value AndAlso
        laddend4 + raddend4 = sum4Numeric.Value AndAlso
        laddend5 + raddend5 = sum5Numeric.Value Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        'actually 'check answers' button (need to rename)
        If CheckTheAnswer() = True Then
            Timer1.Stop()
            MessageBox.Show("You got all of the answers correct!", "YOU ARE AWESOME!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            startButton.Enabled = True
        Else
            MessageBox.Show("Not Quite...Keep Trying!", "NOT CORRECT!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)
        End If
    End Sub
    'create timer
    Private Sub timerLabel_Tick() Handles Timer1.Tick
        If CheckTheAnswer() Then
            Timer1.Stop()
            MessageBox.Show("You got all of the answers correct!", "YOU ARE AWESOME!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            startButton.Enabled = True
        ElseIf timeLeft > 0 Then
            timeLeft -= 1
            timerLabel.Text = timeLeft & " seconds"
        Else
            Timer1.Stop()
            timerLabel.Text = "Time is up!!"
            MessageBox.Show("You did not finish the problems in time." + ControlChars.NewLine + ControlChars.NewLine +
                            "              Game Over!!", "Sorry! Game Over", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            sum1Numeric.Value = laddend1 + raddend1
            sum2Numeric.Value = laddend2 + raddend2
            sum3Numeric.Value = laddend3 + raddend3
            sum4Numeric.Value = laddend4 + raddend4
            sum5Numeric.Value = laddend5 + raddend5
            startButton.Enabled = True
        End If
    End Sub

    Private Sub startButton_Click() Handles startButton.Click
        'call start function to begin game on button click
        startTheQuiz()
        startButton.Enabled = False
    End Sub

    'exit confirmation & button
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click

        Dim exitConfirm As DialogResult
        exitConfirm =
            MessageBox.Show("Are you sure you wish to exit?", "ADDITION GAME",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button2)
        If exitConfirm = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class
