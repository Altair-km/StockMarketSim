Public Class Form4
    'Declares the recent move variable'
    Public RecentMove As String

    ''' <summary>
    ''' Returns the player to the main menu via a button press
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub Back(sender As Object, e As EventArgs) Handles btnBack.Click
        'Hides the current page'
        Me.Hide()
        'Shows the main menu page'
        Form1.Show()
    End Sub

    ''' <summary>
    ''' Allocates the label for the most recent move and activates the sub for the adding of the move to a text file
    ''' </summary>
    ''' <param name="Outcome">Whether the player has bought or sold a stock</param>
    ''' <param name="Stock">The stock interacted with by the player in that move</param>
    ''' <param name="Number">The amount of stocks bought or sold</param>
    Public Sub DetermineMove(Outcome As String, Stock As String, Number As Integer)
        'Sets the most recent moves to be the players moves based on their action to a stock for a ceratin amount of shares'
        RecentMove = "Recent Move: " & Outcome & " " & Number & " " & Stock & " stocks"
        'Adds the move to a text file via the calling of the subroutine'
        AddPastMoves()
    End Sub

    ''' <summary>
    ''' Reads the past moves text file and displays the values to the user via a list box
    ''' </summary>
    Private Sub ReadPastMoves()
        'Opens the past move file and reads its contents'
        FileSystem.FileOpen(1, "PastMoves.txt", OpenMode.Input)
        Dim counter = 0
        Dim arrNum(10000)
        While Not EOF(1)
            FileSystem.Input(1, arrNum(counter))
            'Outputs the read line to the user via a list box'
            lstPastMoves.Items.Add(arrNum(counter))
            counter = counter + 1
        End While
        'Closes the past moves file'
        FileSystem.FileClose()
        'Sets the recent move label to the most recent move'
        lblRecentMove.Text = RecentMove
    End Sub

    ''' <summary>
    ''' Adds the latest move to the past moves file
    ''' </summary>
    Private Sub AddPastMoves()
        'Opens the past moves file for appending'
        FileSystem.FileOpen(1, "PastMoves.txt", OpenMode.Append)
        'Adds the most recent move to the text file in addition to its current contents'
        FileSystem.WriteLine(1, RecentMove)
        'Closes the past moves file'
        FileSystem.FileClose()
    End Sub

    ''' <summary>
    ''' Activates the displaying of the past moves upon the loading of the page
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Activates the read past moves subroutine'
        ReadPastMoves()
    End Sub
End Class