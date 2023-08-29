Module Module2
    'Variable storing the player name for the game session'
    Public PName As String
    'Variable storing the players funds'
    Public Funds As Integer
    'Variable storing the current day/turn'
    Public Day As Integer

    'Class setup for stocks'
    Public Class Stock
        'Sets up stock name variable'
        Public StockName As String
        'Sets up stock price variable'
        Public CStockPrice As Double
        'Sets up stock change variable'
        Public StockChange As Double
        'Sets up stock avaliable variable'
        Public Avaliable As Integer
        'Sets up stock owned variable'
        Public Owned As Integer
    End Class

    'Declares all the stocks of the game as new Stock types as seen above'
    Public APPL As New Stock
    Public MSFT As New Stock
    Public WOW As New Stock
    Public CMB As New Stock
    Public BHP As New Stock

    ''' <summary>
    ''' Function that sets the current stock prices at the beginning of the game session
    ''' </summary>
    ''' <returns>Current stock price for called stock</returns>
    Public Function SetSPrice()
        'Sets the price as 0'
        Dim Price As Integer = 0
        'Declares an array of 10 values'
        Dim RandArr(10) As Integer
        'Assigns the AssignRand variable a random number'
        Dim AssignRand = Int((10 * Rnd()) + 1)
        'For the length of the rand array'
        For i = 1 To 10 Step 1
            'Set the rand array at index i to be a random number'
            RandArr(i) = Int((10 * Rnd()) + 1)
        Next i

        'Set the price to be a random number at a random index from the RandArr'
        Price = Price + RandArr(AssignRand)

        'Return the value of price'
        Return Price
    End Function

    ''' <summary>
    ''' Function that uses the old stock value to generate a new volitile stock price
    ''' </summary>
    ''' <param name="CurrentPrice">Current price of stock</param>
    ''' <returns>New price of the stock</returns>
    Public Function RenewSPrice(CurrentPrice As Integer)
        'Set up new price variable'
        Dim NewPrice As Integer
        'Sets the ajustment factor as a random number between 1 and 4'
        Dim aj = Int((4 * Rnd()) + 1)
        'Ihe ajustment factor is below 2'
        If aj <= 2 Then
            'Set new price to be the current price - a random number between 1 and 3'
            NewPrice = CurrentPrice - Int((3 * Rnd()) + 1)
            'If the new price is 0'
            If NewPrice <= 0 Then
                'Add a random number between 1 and 6'
                NewPrice = Int((6 * Rnd()) + 1)
            End If
        Else
            'Set new price to be the current price+- a random number between 1 and 6'
            NewPrice = CurrentPrice + Int((6 * Rnd()) + 1)
        End If

        'Return the newly generated price value'
        Return NewPrice
    End Function

    ''' <summary>
    ''' Updates the change values of the stocks
    ''' </summary>
    Private Sub UpdateChange()
        If Day = 1 Then
            'Set the stock change to equal the stocks current price'
            APPL.StockChange = APPL.CStockPrice
            MSFT.StockChange = MSFT.CStockPrice
            WOW.StockChange = WOW.CStockPrice
            CMB.StockChange = CMB.CStockPrice
            BHP.StockChange = BHP.CStockPrice
        Else
            'Stock change is equal to the current change - the stocks current price'
            APPL.StockChange = APPL.StockChange - APPL.CStockPrice
            MSFT.StockChange = MSFT.StockChange - MSFT.CStockPrice
            WOW.StockChange = WOW.StockChange - WOW.CStockPrice
            CMB.StockChange = CMB.StockChange - CMB.CStockPrice
            BHP.StockChange = BHP.StockChange - BHP.CStockPrice
        End If
    End Sub

    ''' <summary>
    ''' Sets the next turn/day of the player, renewing the prices 
    ''' </summary>
    Public Sub NextTurn()
        'Increments the day by 1'
        Day = Day + 1
        'Updates the label with the new day'
        Form1.lblDay.Text = "Day: " & Day
        'Renews the current stock prices of the stocks'
        APPL.CStockPrice = RenewSPrice(APPL.CStockPrice)
        MSFT.CStockPrice = RenewSPrice(MSFT.CStockPrice)
        WOW.CStockPrice = RenewSPrice(WOW.CStockPrice)
        CMB.CStockPrice = RenewSPrice(CMB.CStockPrice)
        BHP.CStockPrice = RenewSPrice(BHP.CStockPrice)
        'Calls the EndGameCheck subroutine to check if the game has ended'
        EndGameCheck()
        'Calls the update labels sub to update all of the labels to their new values'
        Form1.UpdateLabels()
        'Updates all the stocks change values'
        UpdateChange()
    End Sub

    ''' <summary>
    ''' Checks to see if the game has ended via running out of time
    ''' </summary>
    Private Sub EndGameCheck()
        'If the day is 30 or greater'
        If Day >= 30 Then
            'Call the end game subroutine'
            EndGame()
        End If
    End Sub

    ''' <summary>
    ''' Ends the current game session, returning them to the start screen
    ''' </summary>
    Private Sub EndGame()
        'Messages the player to let them know the game session is over'
        MsgBox("Congrats on making it to the end of the month. Your final balance is " & Funds)
        'Closes all the current game pages'
        Form1.Close()
        Form2.Close()
        Form4.Close()
        Form5.Close()
        'Opens the game start screen'
        Form6.Show()
        Form3.Close()
        'Calls the Fetch High Scores sub to update the high scores'
        Form3.FetchHighScores()
    End Sub

End Module
