Public Class Form6
    ''' <summary>
    ''' Activates the start of the game via a button press
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub Start(sender As Object, e As EventArgs) Handles btnStart.Click
        'Calls the get name subroutine'
        GetName()
    End Sub

    ''' <summary>
    ''' Gets the name from the user
    ''' </summary>
    Private Sub GetName()
        'User inputed name'
        PName = InputBox("Enter your name")
        'Checks if the name is valid via a function'
        If ValidateName() = True Then
            'Checks if name has been used before via a function'
            If NameCheck() = True Then
                'Sets up the stocks for the game'
                StockSetup()
                'Hides the current page'
                Me.Hide()
                'Shows the main menu'
                Form1.Show()
                'Updates the main menu'
                Form1.MainMenuUpDate()
                'Sets all name labels to be the player name'
                Form1.lblName.Text = PName
                Form2.lblName.Text = PName
                Form3.lblName.Text = PName
                Form4.lblName.Text = PName
                Form5.lblName.Text = PName
                'Sets up the past moves file via a subroutine'
                SetPastMovesFile()
            End If
        Else
            'Informs the user the name inputed is invalid'
            MsgBox("Invalid Name")
        End If

    End Sub

    ''' <summary>
    ''' Checks if the inputed name is valid
    ''' </summary>
    ''' <returns>Either true or false</returns>
    Private Function ValidateName()
        'Converts the player name to an array of characters'
        Dim NameArr() As Char = PName.ToCharArray
        'If the name is an empty field'
        If PName = "" Then
            'Inform the player the name field entered is empty and is invalid'
            MsgBox("Field is empty")
            'Return the false value'
            Return False
        Else
            'Return the true value'
            Return True
        End If

    End Function

    ''' <summary>
    '''  Checks if the name has been used before
    ''' </summary>
    ''' <returns>Either true or false</returns>
    Private Function NameCheck()
        'Opens the high scores file and reads in the player names to an array'
        FileSystem.FileOpen(1, "HighScores.txt", OpenMode.Input)
        Dim counter = 0
        Dim arrNum(10000)
        While Not EOF(1)
            FileSystem.Input(1, arrNum(counter))
        End While
        'Closes the high scores file'
        FileSystem.FileClose()
        'For the length of the array'
        For i = 1 To arrNum.Length - 1 Step 1
            'If the player inputed name if the same as a name in the high score file'
            If PName = arrNum(i) Then
                'Prompt the user the name is already used and ask if they want to change the name'
                MsgBox("Name already in use, change name?", MessageBoxButtons.YesNo)
                'If the user picks yes'
                If MsgBoxResult.Yes Then
                    'Return the false value'
                    Return False
                    'If the user picks no'
                ElseIf MsgBoxResult.No Then
                    'Return the true value'
                    Return True
                End If
            End If
        Next
        'Return the true value'
        Return True
    End Function

    ''' <summary>
    ''' Sets up the stocks and their values for the game session
    ''' </summary>
    Private Sub StockSetup()
        'Sets the day to be 1'
        Day = 1
        'Sets the funds to be $1000'
        Funds = 1000

        'Sets the stocks inital prices via the SetSPrice function'
        APPL.CStockPrice = SetSPrice()
        MSFT.CStockPrice = SetSPrice()
        WOW.CStockPrice = SetSPrice()
        CMB.CStockPrice = SetSPrice()
        BHP.CStockPrice = SetSPrice()

        'Sets the stocks avaliable shares to 1000 each'
        APPL.Avaliable = 1000
        MSFT.Avaliable = 1000
        WOW.Avaliable = 1000
        CMB.Avaliable = 1000
        BHP.Avaliable = 1000

        'Set the stock change rate to be 0'
        APPL.StockChange = 0
        MSFT.StockChange = 0
        WOW.StockChange = 0
        CMB.StockChange = 0
        BHP.StockChange = 0

        'Update the main menu labels'
        Form1.UpdateLabels()
        'Set the stock names array'
        Form1.SetSNames()
        'Set the stock prices array'
        Form1.SetSPrices()
    End Sub

    ''' <summary>
    ''' Sets up the past moves file for the past moves system
    ''' </summary>
    Private Sub SetPastMovesFile()
        'Opens the past moves file'
        FileSystem.FileOpen(3, "PastMoves.txt", OpenMode.Output)
        'Overwrites the previous data so the file is blank for a new game'
        FileSystem.WriteLine(3, "")
        'Closes the past moves file'
        FileSystem.FileClose()
    End Sub

End Class