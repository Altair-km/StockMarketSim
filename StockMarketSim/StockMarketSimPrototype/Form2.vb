Public Class Form2
    'Declares the stocks share price'
    Dim SharePrice
    'Declares the stock name'
    Dim StockName
    'Declares avaliable stocks'
    Dim SharesAvaliable
    'Declares the stock shares owned'
    Dim SharesOwned
    'Declares the stock change values'
    Dim StockChange

    ''' <summary>
    ''' Sets up the info page with the required stock
    ''' </summary>
    Public Sub SetInfo()
        'Sets the lables with the current funds and day'
        lblFunds.Text = "Funds: " & Module2.Funds
        lblDay.Text = "Day: " & Module2.Day

        'Sets the all the stocks names'
        APPL.StockName = "Apple Inc"

        MSFT.StockName = "Microsoft Inc"

        WOW.StockName = "Woolworths Inc"

        CMB.StockName = "Commonwealth Bank"

        'Selects options based on the result of buttonP'
        Select Case Form1.buttonP
            'if buttonP = 1'
            Case 1
                'Sets the picture box to be the stock logo image'
                PicStocks.Image = Image.FromFile("APPLimg.jpg")
                'Sets the label for stock name to be the stocks full name'
                lblStockName.Text = APPL.StockName
                'Sets the local stock name variable to be the stocks acronym name'
                StockName = "APPL"
                'Sets the labels for shares avaliable, shares owned and the current stock price to be the stock values'
                lblSharesAv.Text = ("Shares Avaliable: " & APPL.Avaliable)
                lblSharOwned.Text = ("Shares Owned: " & APPL.Owned)
                lblCurStockPrice.Text = ("Price: $" & APPL.CStockPrice & " Per Share")
                'Sets the local share price, shares avaliable, shares owned and stock chnage to be the stock values'
                SharePrice = APPL.CStockPrice
                SharesAvaliable = APPL.Avaliable
                SharesOwned = APPL.Owned
                StockChange = APPL.StockChange
            'if buttonP = 2'
            Case 2
                'Sets the picture box to be the stock logo image'
                PicStocks.Image = Image.FromFile("MSFTimg.jpg")
                'Sets the label for stock name to be the stocks name'
                lblStockName.Text = MSFT.StockName
                'Sets the local stock name variable to be the stocks acronym name'
                StockName = "MSFT"
                'Sets the labels for shares avaliable, shares owned and the current stock price to be the stock values'
                lblSharesAv.Text = ("Shares Avaliable: " & MSFT.Avaliable)
                lblSharOwned.Text = ("Shares Owned: " & MSFT.Owned)
                lblCurStockPrice.Text = ("Price: $" & MSFT.CStockPrice & " Per Share")
                'Sets the local share price, shares avaliable, shares owned and stock chnage to be the stock values'
                SharePrice = MSFT.CStockPrice
                SharesAvaliable = MSFT.Avaliable
                SharesOwned = MSFT.Owned
                StockChange = MSFT.StockChange
            'if buttonP = 3'
            Case 3
                'Sets the picture box to be the stock logo image'
                PicStocks.Image = Image.FromFile("WOWimg.png")
                'Sets the label for stock name to be the stocks name'
                lblStockName.Text = WOW.StockName
                'Sets the local stock name variable to be the stocks acronym name'
                StockName = "WOW"
                'Sets the labels for shares avaliable, shares owned and the current stock price to be the stock values'
                lblSharesAv.Text = ("Shares Avaliable: " & WOW.Avaliable)
                lblSharOwned.Text = ("Shares Owned: " & WOW.Owned)
                lblCurStockPrice.Text = ("Price: $" & WOW.CStockPrice & " Per Share")
                'Sets the local share price, shares avaliable, shares owned and stock chnage to be the stock values'
                SharePrice = WOW.CStockPrice
                SharesAvaliable = WOW.Avaliable
                SharesOwned = WOW.Owned
                StockChange = WOW.StockChange
            'if buttonP = 4'
            Case 4
                'Sets the picture box to be the stock logo image'
                PicStocks.Image = Image.FromFile("CMBimg.png")
                'Sets the label for stock name to be the stocks name'
                lblStockName.Text = CMB.StockName
                'Sets the local stock name variable to be the stocks acronym name'
                StockName = "CMB"
                'Sets the labels for shares avaliable, shares owned and the current stock price to be the stock values'
                lblSharesAv.Text = ("Shares Avaliable: " & CMB.Avaliable)
                lblSharOwned.Text = ("Shares Owned: " & CMB.Owned)
                lblCurStockPrice.Text = ("Price: $" & CMB.CStockPrice & " Per Share")
                'Sets the local share price, shares avaliable, shares owned and stock chnage to be the stock values'
                SharePrice = CMB.CStockPrice
                SharesAvaliable = CMB.Avaliable
                SharesOwned = CMB.Owned
                StockChange = CMB.StockChange
            'if buttonP = 5'
            Case 5
                'Sets the picture box to be the stock logo image'
                PicStocks.Image = Image.FromFile("BHPimg.png")
                'Sets the label for stock name to be the stocks name'
                lblStockName.Text = BHP.StockName
                'Sets the local stock name variable to be the stocks acronym name'
                StockName = "BHP"
                'Sets the labels for shares avaliable, shares owned and the current stock price to be the stock values'
                lblSharesAv.Text = ("Shares Avaliable: " & BHP.Avaliable)
                lblSharOwned.Text = ("Shares Owned: " & BHP.Owned)
                lblCurStockPrice.Text = ("Price: $" & BHP.CStockPrice & " Per Share")
                'Sets the local share price, shares avaliable, shares owned and stock chnage to be the stock values'
                SharePrice = BHP.CStockPrice
                SharesAvaliable = BHP.Avaliable
                SharesOwned = BHP.Owned
                StockChange = BHP.StockChange
        End Select

    End Sub

    ''' <summary>
    ''' Updates the current stock sales including the labels and stock values
    ''' </summary>
    Private Sub UpdateSales()
        'Sets the labels to be the updates stock values'
        lblSharesAv.Text = ("Shares Avaliable: " & SharesAvaliable)
        lblSharOwned.Text = ("Shares Owned: " & SharesOwned)

        Select Case Form1.buttonP
            'if buttonP = 1'
            Case 1
                'Set the stock price label to by the APPL CStockPrice'
                lblCurStockPrice.Text = ("Current Share Price: " & APPL.CStockPrice)
                'Updates the stocks Avaliable and owned shares with the local variables'
                APPL.Avaliable = SharesAvaliable
                APPL.Owned = SharesOwned
            'if buttonP = 2'
            Case 2
                'Set the stock price label to by the MSFT CStockPrice'
                lblCurStockPrice.Text = ("Current Share Price: " & MSFT.CStockPrice)
                'Updates the stocks Avaliable and owned shares with the local variables'
                MSFT.Avaliable = SharesAvaliable
                MSFT.Owned = SharesOwned
            'if buttonP = 3'
            Case 3
                'Set the stock price label to by the WOW CStockPrice'
                lblCurStockPrice.Text = ("Current Share Price: " & WOW.CStockPrice)
                'Updates the stocks Avaliable and owned shares with the local variables'
                WOW.Avaliable = SharesAvaliable
                WOW.Owned = SharesOwned
            'if buttonP = 4'
            Case 4
                'Set the stock price label to by the CMB CStockPrice'
                lblCurStockPrice.Text = ("Current Share Price: " & CMB.CStockPrice)
                'Updates the stocks Avaliable and owned shares with the local variables'
                CMB.Avaliable = SharesAvaliable
                CMB.Owned = SharesOwned
            'if buttonP = 5'
            Case 5
                'Set the stock price label to by the BHP CStockPrice'
                lblCurStockPrice.Text = ("Current Share Price: " & BHP.CStockPrice)
                'Updates the stocks Avaliable and owned shares with the local variables'
                BHP.Avaliable = SharesAvaliable
                BHP.Owned = SharesOwned
        End Select
    End Sub

    ''' <summary>
    ''' Sets up the buying of the stocks shares.
    ''' This is done through a button press and a user input
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub Buy(sender As Object, e As EventArgs) Handles btnBuyStock.Click
        'Gets the user input of how many shares they want to buy'
        Dim BuyAmount As Integer = InputBox("Enter amount of shares to buy: ")
        'Calulates the price of the shares based on the user input and current price'
        Dim SharesBought = SharePrice * BuyAmount
        'If the number of shares the user wants to buy is greater than the shares avaliable'
        If BuyAmount > SharesAvaliable Then
            'Inform the user they cannot buy the desired number of shares'
            MsgBox("Not enough shares left to buy")
        Else
            'If the price to buy the shares is greater than the players current funds'
            If (Funds / BuyAmount) < SharePrice Then
                'Inform the user the shares cost too much to buy'
                MsgBox("Cannot afford to buy this many shares")
            Else
                'Update the shares owned to include the newly bought shares'
                SharesOwned = SharesOwned + BuyAmount
                'Update shares owned label with new value'
                lblSharOwned.Text = ("Shares Owned: " & BuyAmount)
                'Deprecate funds by the cost of the shares'
                Funds = Funds - SharesBought
                'Deprecate the shares avaliable buy the number of shares bought'
                SharesAvaliable = SharesAvaliable - BuyAmount
                'Update labels with the newly changed values'
                lblSharesAv.Text = "Shares avaliable: " & SharesAvaliable
                lblFunds.Text = "Funds: " & Funds
                'Calls the update sales subroutine'
                UpdateSales()
                'Calls the determine move sub for the past moves page'
                Form4.DetermineMove("Bought", StockName, BuyAmount)
                'Activates the analysis system on the move just made'
                Form5.AnalyseMove(StockName, StockChange, "Bought")
            End If
        End If
    End Sub

    ''' <summary>
    ''' Returns to the main menu via a button press
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub Back(sender As Object, e As EventArgs) Handles btnBack.Click
        'Hides the current page'
        Me.Hide()
        'Shows the main menu page'
        Form1.Show()
        'Updates the main menu items via the called subroutine'
        Form1.MainMenuUpDate()
        'Updates the main menu labels via the called subroutine'
        Form1.UpdateLabels()
    End Sub

    ''' <summary>
    ''' Sets up the selling of stock shares
    ''' This is done via  button press
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub Sell(sender As Object, e As EventArgs) Handles btnSellStock.Click
        'If the user owns no shares'
        If SharesOwned <= 0 Then
            MsgBox("You have no shares to sell")
        Else
            'User input of how many shares to sell'
            Dim SellAmount = InputBox("Enter amount of shares to sell: ")
            'Calulates the sale price based on current price and shares to sell'
            Dim AmountSold = SharePrice * SellAmount
            'If the user trys to sell shares they do not own'
            If SellAmount > SharesOwned Then
                'Inform the user they cannot sell that amount'
                MsgBox("Invalid amount")
            Else
                'Remove shares from ownership based on the sell amount'
                SharesOwned = SharesOwned - SellAmount
                'Updates shares avaliable with newly sold shares'
                SharesAvaliable = SharesAvaliable + SellAmount
                'Appreciates funds with new selling of shares'
                Module2.Funds = Module2.Funds + AmountSold
                'Updates labels with new values based on the sale of shares'
                lblFunds.Text = ("Funds: " & Module2.Funds)
                lblSharOwned.Text = "Shares Owned: " & SharesOwned
                lblSharesAv.Text = "Shares Avaliable: " & SharesAvaliable
                'Updates the sale of shares via the calling of teh subroutine'
                UpdateSales()
                'Determines the move made for the past moves system'
                Form4.DetermineMove("Sold", StockName, SellAmount)
                'Activates the analysis system for the current move'
                Form5.AnalyseMove(StockName, StockChange, "Sold")
            End If
        End If
    End Sub

End Class