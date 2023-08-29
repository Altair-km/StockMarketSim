Public Class Form3
    ''' <summary>
    ''' Displays the High Scores to the user by reading them from the high scores file
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub DisplayHighScores(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets the label to be the users name and current score/funds'
        lblUserScore.Text = (PName & ": " & Funds)
        'Opens and reads the high score file'
        FileSystem.FileOpen(1, "HighScores.txt", OpenMode.Input)
        Dim counter = 0
        Dim arrNum(10000) As String
        While Not EOF(1)
            FileSystem.Input(1, arrNum(counter))
            'Displays the read file values to the user via the list box'
            lstHS.Items.Add(arrNum(counter))
            counter = counter + 1
        End While
        'Closes the high scores file'
        FileSystem.FileClose()
    End Sub

    ''' <summary>
    ''' Sorts the read in high scores
    ''' </summary>
    ''' <param name="arrScores">Array containing the high scores values read in from the text file</param>
    Private Sub SortHighScores(arrScores() As String)
        'Sorts the scores using the selection sort method'
        Dim Counter = 1
        Dim EndUnsorted = arrScores.Length - 1
        arrScores(1) = PName & Funds
        While EndUnsorted > 1
            Dim i = 1
            Dim Max = arrScores(i)
            Dim PosMax = i
            While i < EndUnsorted
                i = i + 1
                If arrScores(i) > Max Then
                    Max = arrScores(i)
                    PosMax = i
                End If
            End While
            Swap(arrScores(PosMax), arrScores(EndUnsorted))
            EndUnsorted = EndUnsorted - 1
            Counter = Counter + 1
        End While
        'Updates the high scores file with the sorted scores via the calling of the subroutine'
        UpdateHighScores(arrScores)
    End Sub

    ''' <summary>
    ''' Swaps two stocks into different positions
    ''' </summary>
    ''' <param name="A">Value of a stock at a position</param>
    ''' <param name="B">Value of a stock at a different position</param>
    Private Sub Swap(ByRef A, ByRef B)
        'Stores A in a temp value'
        Dim Temp = A
        'Sets A to equal the value of B'
        A = B
        'Sets B to equal the value of Temp which is A'
        B = Temp
    End Sub

    ''' <summary>
    ''' Returns to the main menu via a button press
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Closes the current page'
        Me.Close()
        'Shows the main menu page'
        Form1.Show()
        'Updates the values on the main menu via the calling of the subroutine'
        Form1.MainMenuUpDate()
    End Sub

    ''' <summary>
    ''' Reads in the current high scores from the high scores file into an array with the players name and score
    ''' </summary>
    Public Sub FetchHighScores()

        'Opens the high scores file and assigns the read in values to arrScores'
        FileSystem.FileOpen(1, "HighScores.txt", OpenMode.Input)
        Dim counter = 2
        Dim arrScores(10) As String
        arrScores(1) = (PName & ": " & Funds)
        While Not EOF(1)
            arrScores(counter) = LineInput(1)
            counter = counter + 1
        End While
        'Closes the High Scores file'
        FileSystem.FileClose()

        'Calls the subroutine to sort the high scores read in'
        SortHighScores(arrScores)
    End Sub

    ''' <summary>
    ''' Updates the high scores file with the newly sorted high scores and the players high score
    ''' </summary>
    ''' <param name="arrScores">Array containing the sorted player and file high scores</param>
    Private Sub UpdateHighScores(arrScores() As String)
        'Opens the file and overwrites its data with the new values from arrScores'
        FileSystem.FileOpen(2, "HighScores.txt", OpenMode.Output)
        For i = arrScores.Length - 1 To 1 Step -1
            FileSystem.WriteLine(2, arrScores(i))
        Next i
        'Closes the High Scores file'
        FileSystem.FileClose()
    End Sub
End Class