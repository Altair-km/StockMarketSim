Public Class Form1
    'Variable determining the stock selection for the info page'
    Public buttonP As Integer
    'Array of stock names'
    Public StockNames(5) As String
    'Array of stock prices'
    Public StockPArr(5) As Integer

    ''' <summary>
    ''' Sets up the So with the stock names
    ''' </summary>
    Public Sub SetSNames()
        'Sets the stock names'
        StockNames(1) = "APPL"
        StockNames(2) = "MSFT"
        StockNames(3) = "WOW"
        StockNames(4) = "CMB"
        StockNames(5) = "BHP"
    End Sub


    ''' <summary>
    ''' Sets up the StockPArr with the stock names
    ''' </summary>
    Public Sub SetSPrices()
        'Sets the stock prices'
        StockPArr(1) = APPL.CStockPrice
        StockPArr(2) = MSFT.CStockPrice
        StockPArr(3) = WOW.CStockPrice
        StockPArr(4) = CMB.CStockPrice
        StockPArr(5) = BHP.CStockPrice
    End Sub

    ''' <summary>
    ''' Determines the stock to be shown on the info page from a series of selectable rdo buttons,
    ''' which all change the value of buttonP
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub InfoPage(sender As Object, e As EventArgs) Handles btnInfo.Click
        'Set buttonP to 0 as a baseline'
        buttonP = 0
        'Determines the nature of buttonP based on rdo button selection'
        If rdoAPPL.Checked Then
            buttonP = 1
        ElseIf rdoMSFT.Checked Then
            buttonP = 2
        ElseIf rdoWOW.Checked Then
            buttonP = 3
        ElseIf rdoCMB.Checked Then
            buttonP = 4
        ElseIf rdoBHP.Checked Then
            buttonP = 5
        Else
            'Informs user a stock has to be selected for buttonP assignment'
            MsgBox("Please select a stock from the stock list")
        End If

        'If a stock has been selected'
        If buttonP > 0 Then
            'Hide main menu and show the stock page'
            Me.Hide()
            Form2.Show()
            'Set the information on stock info page'
            Form2.SetInfo()
        End If
    End Sub

    '''<summary>
    ''' Changes the page to the high score page from a button press
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    '''  <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub HighScorePage(sender As Object, e As EventArgs) Handles btnHighScores.Click
        'Hides current page and shows high score page'
        Me.Hide()
        Form3.Show()
    End Sub

    '''<summary>
    ''' Changes the page to the past moves page from a button press
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    '''  <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub PastMovesPage(sender As Object, e As EventArgs) Handles btnPastMoves.Click
        'Hides the current page and shows the past moves page'
        Me.Hide()
        Form4.Show()
    End Sub

    '''<summary>
    ''' Engages the subroutine to sort the stocks by name.
    ''' This is done through a button press.
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    '''  <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub StockSortNames(sender As Object, e As EventArgs) Handles btnSortNames.Click
        'Calls the sort stocks by name subroutine'
        SortSNames()
    End Sub

    '''<summary>
    ''' Engages the subroutine to sort the stocks by price.
    ''' This is done through a button press.
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    '''  <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub StockSortPrices(sender As Object, e As EventArgs) Handles btnSortPrice.Click
        'Calls the sort stocks by price subroutine'
        SortSPrices()
    End Sub

    ''' <summary>
    ''' Subroutine that sorts the stocks on the main menu by current price
    ''' </summary>
    Private Sub SortSPrices()
        'Sets the 5 locations for the sorted stock labels to be assigned'
        Dim locationS1 = New Point(12, 85)
        Dim locationS2 = New Point(12, 145)
        Dim locationS3 = New Point(12, 203)
        Dim locationS4 = New Point(12, 260)
        Dim locationS5 = New Point(12, 315)
        'Sets the 5 locations for the sorted stock rdo buttons to be assigned'
        Dim locationRDO1 = New Point(590, 88)
        Dim locationRDO2 = New Point(590, 148)
        Dim locationRDO3 = New Point(590, 204)
        Dim locationRDO4 = New Point(590, 264)
        Dim locationRDO5 = New Point(590, 318)

        'Sorts the stocks using a selection sort method'
        Dim Counter = 1
        Dim EndUnsorted = StockPArr.Length - 1
        While EndUnsorted > 1
            Dim i = 1
            Dim Max = StockPArr(i)
            Dim PosMax = i
            While i < EndUnsorted
                i = i + 1
                If StockPArr(i) > Max Then
                    Max = StockPArr(i)
                    PosMax = i
                End If
            End While
            'Swaps the two stocks that need to be changed in positon'
            Swap(StockPArr(PosMax), StockPArr(EndUnsorted))
            EndUnsorted = EndUnsorted - 1
            Counter = Counter + 1
        End While
        'Calls the subroutine to swap the stock positions'
        StockPriceSwaps(locationS1, locationS2, locationS3, locationS4, locationS5, locationRDO1, locationRDO2, locationRDO3, locationRDO4, locationRDO5)
    End Sub

    ''' <summary>
    ''' Sorts the stocks by their names
    ''' </summary>
    Private Sub SortSNames()
        'Sets the 5 locations for the sorted stock labels to be assigned'
        Dim locationS1 = New Point(12, 85)
        Dim locationS2 = New Point(12, 145)
        Dim locationS3 = New Point(12, 203)
        Dim locationS4 = New Point(12, 260)
        Dim locationS5 = New Point(12, 315)
        'Sets the 5 locations for the sorted stock rdo buttons to be assigned'
        Dim locationRDO1 = New Point(590, 88)
        Dim locationRDO2 = New Point(590, 148)
        Dim locationRDO3 = New Point(590, 204)
        Dim locationRDO4 = New Point(590, 264)
        Dim locationRDO5 = New Point(590, 318)

        'Sorts the stocks using a selection sort method'
        Dim Counter = 1
        Dim EndUnsorted = StockNames.Length - 1
        While EndUnsorted > 1
            Dim i = 1
            Dim Max = StockNames(i)
            Dim PosMax = i
            While i < EndUnsorted
                i = i + 1
                If StockNames(i) > Max Then
                    Max = StockNames(i)
                    PosMax = i
                End If
            End While
            'Swaps the two stocks that need to be changed in positon'
            Swap(StockNames(PosMax), StockNames(EndUnsorted))
            EndUnsorted = EndUnsorted - 1
            Counter = Counter + 1
        End While
        'Calls the subroutine to swap the stock positions'
        StockNameSwaps(locationS1, locationS2, locationS3, locationS4, locationS5, locationRDO1, locationRDO2, locationRDO3, locationRDO4, locationRDO5)
    End Sub

    ''' <summary>
    ''' This subroutine sets the stock label and rdo buttons positions according to their sorted names
    ''' </summary>
    ''' <param name="l1">location of stock 1 label</param>
    ''' <param name="l2">location of stock 2 label</param>
    ''' <param name="l3">location of stock 3 label</param>
    ''' <param name="l4">location of stock 4 label</param>
    ''' <param name="l5">location of stock 5 label</param>
    ''' <param name="rdo1">location of stock 1 rdo button</param>
    ''' <param name="rdo2">location of stock 2 rdo button</param>
    ''' <param name="rdo3">location of stock 3 rdo button</param>
    ''' <param name="rdo4">location of stock 4 rdo button</param>
    ''' <param name="rdo5">location of stock 5 rdo button</param>
    Private Sub StockNameSwaps(l1 As Point, l2 As Point, l3 As Point, l4 As Point, l5 As Point, rdo1 As Point, rdo2 As Point, rdo3 As Point, rdo4 As Point, rdo5 As Point)
        'Loops for the length of the stock array to swap labels and rdo buttons'
        For i = 1 To StockNames.Length - 1 Step 1
            'Selecting an option depending on the value of i'
            Select Case i
                'if i = 1'
                Case 1
                    'Selects a option depending on the value of StockNames(i)'
                    Select Case StockNames(i)
                        'If the StockNames(i) is APPL'
                        Case "APPL"
                            'Set the stock label and rdo button to locations 1'
                            Me.lblStockAP.Location = l1
                            Me.rdoAPPL.Location = rdo1
                        'If the StockNames(i) is MSFT'
                        Case "MSFT"
                            'Set the stock label and rdo button to locations 2'
                            Me.lblStockMS.Location = l1
                            Me.rdoMSFT.Location = rdo1
                       'If the StockNames(i) is WOW'
                        Case "WOW"
                            'Set the stock label and rdo button to locations 3'
                            Me.lblStockWO.Location = l1
                            Me.rdoWOW.Location = rdo1
                        'If the StockNames(i) is CMB'
                        Case "CMB"
                            'Set the stock label and rdo button to locations 4'
                            Me.lblStockCM.Location = l1
                            Me.rdoCMB.Location = rdo1
                        'If the StockNames(i) is BHP'
                        Case "BHP"
                            'Set the stock label and rdo button to locations 5'
                            Me.lblStockBH.Location = l1
                            Me.rdoBHP.Location = rdo1
                    End Select
                'if i = 2'
                Case 2
                    'Selects a option depending on the value of StockNames(i)'
                    Select Case StockNames(i)
                        'If the StockNames(i) is APPL'
                        Case "APPL"
                            'Set the stock label and rdo button to locations 2'
                            Me.lblStockAP.Location = l2
                            Me.rdoAPPL.Location = rdo2
                        'If the StockNames(i) is MSFT'
                        Case "MSFT"
                            'Set the stock label and rdo button to locations 2'
                            Me.lblStockMS.Location = l2
                            Me.rdoMSFT.Location = rdo2
                        'If the StockNames(i) is WOW'
                        Case "WOW"
                            'Set the stock label and rdo button to locations 2'
                            Me.lblStockWO.Location = l2
                            Me.rdoWOW.Location = rdo2
                        'If the StockNames(i) is CMB'
                        Case "CMB"
                            'Set the stock label and rdo button to locations 2'
                            Me.lblStockCM.Location = l2
                            Me.rdoCMB.Location = rdo2
                        'If the StockNames(i) is BHP'
                        Case "BHP"
                            'Set the stock label and rdo button to locations 2'
                            Me.lblStockBH.Location = l2
                            Me.rdoBHP.Location = rdo2
                    End Select
               'if i = 3'
                Case 3
                    'Selects a option depending on the value of StockNames(i)'
                    Select Case StockNames(i)
                        'If the StockNames(i) is APPL'
                        Case "APPL"
                            'Set the stock label and rdo button to locations 3'
                            Me.lblStockAP.Location = l3
                            Me.rdoAPPL.Location = rdo3
                        'If the StockNames(i) is MSFT'
                        Case "MSFT"
                            'Set the stock label and rdo button to locations 3'
                            Me.lblStockMS.Location = l3
                            Me.rdoMSFT.Location = rdo3
                        'If the StockNames(i) is WOW'
                        Case "WOW"
                            'Set the stock label and rdo button to locations 3'
                            Me.lblStockWO.Location = l3
                            Me.rdoWOW.Location = rdo3
                        'If the StockNames(i) is CMB'
                        Case "CMB"
                            'Set the stock label and rdo button to locations 3'
                            Me.lblStockCM.Location = l3
                            Me.rdoCMB.Location = rdo3
                        'If the StockNames(i) is BHP'
                        Case "BHP"
                            'Set the stock label and rdo button to locations 3'
                            Me.lblStockBH.Location = l3
                            Me.rdoBHP.Location = rdo3
                    End Select
               'if i = 4'
                Case 4
                    'Selects a option depending on the value of StockNames(i)'
                    Select Case StockNames(i)
                        'If the StockNames(i) is APPL'
                        Case "APPL"
                            'Set the stock label and rdo button to locations 4'
                            Me.lblStockAP.Location = l4
                            Me.rdoAPPL.Location = rdo4
                        'If the StockNames(i) is MSFT'
                        Case "MSFT"
                            'Set the stock label and rdo button to locations 4'
                            Me.lblStockMS.Location = l4
                            Me.rdoMSFT.Location = rdo4
                        'If the StockNames(i) is WOW'
                        Case "WOW"
                            'Set the stock label and rdo button to locations 4'
                            Me.lblStockWO.Location = l4
                            Me.rdoWOW.Location = rdo4
                        'If the StockNames(i) is CMB'
                        Case "CMB"
                            'Set the stock label and rdo button to locations 4'
                            Me.lblStockCM.Location = l4
                            Me.rdoCMB.Location = rdo4
                        'If the StockNames(i) is BHP'
                        Case "BHP"
                            'Set the stock label and rdo button to locations 4'
                            Me.lblStockBH.Location = l4
                            Me.rdoBHP.Location = rdo4
                    End Select
                'if i = 5'
                Case 5
                    'Selects a option depending on the value of StockNames(i)'
                    Select Case StockNames(i)
                        'If the StockNames(i) is APPL'
                        Case "APPL"
                            'Set the stock label and rdo button to locations 5'
                            Me.lblStockAP.Location = l5
                            Me.rdoAPPL.Location = rdo5
                        'If the StockNames(i) is MSFT'
                        Case "MSFT"
                            'Set the stock label and rdo button to locations 5'
                            Me.lblStockMS.Location = l5
                            Me.rdoMSFT.Location = rdo5
                        'If the StockNames(i) is WOW'
                        Case "WOW"
                            'Set the stock label and rdo button to locations 5'
                            Me.lblStockWO.Location = l5
                            Me.rdoWOW.Location = rdo5
                        'If the StockNames(i) is CMB'
                        Case "CMB"
                            'Set the stock label and rdo button to locations 5'
                            Me.lblStockCM.Location = l5
                            Me.rdoCMB.Location = rdo5
                        'If the StockNames(i) is BHP'
                        Case "BHP"
                            'Set the stock label and rdo button to locations 5'
                            Me.lblStockBH.Location = l5
                            Me.rdoBHP.Location = rdo5
                    End Select
            End Select
        Next i
    End Sub

    '''<summary>
    ''' This subroutine sets the stock label and rdo buttons positions according to their sorted prices
    ''' </summary>
    ''' <param name="l1">location of stock 1 label</param>
    ''' <param name="l2">location of stock 2 label</param>
    ''' <param name="l3">location of stock 3 label</param>
    ''' <param name="l4">location of stock 4 label</param>
    ''' <param name="l5">location of stock 5 label</param>
    ''' <param name="rdo1">location of stock 1 rdo button</param>
    ''' <param name="rdo2">location of stock 2 rdo button</param>
    ''' <param name="rdo3">location of stock 3 rdo button</param>
    ''' <param name="rdo4">location of stock 4 rdo button</param>
    ''' <param name="rdo5">location of stock 5 rdo button</param>
    Private Sub StockPriceSwaps(l1 As Point, l2 As Point, l3 As Point, l4 As Point, l5 As Point, rdo1 As Point, rdo2 As Point, rdo3 As Point, rdo4 As Point, rdo5 As Point)
        'Loops for the length of the stock array to swap labels and rdo buttons'
        For i = 1 To StockPArr.Length - 1 Step 1
            'Selecting an option depending on the value of i'
            Select Case i
                'if i = 1'
                Case 1
                    'Selects a option depending on the value of StockPArr(i)'
                    Select Case StockPArr(i)
                        'If the StockPArr(i) is the current stock price of APPL'
                        Case APPL.CStockPrice
                            'Set the stock label and rdo button to locations 1'
                            Me.lblStockAP.Location = l1
                            Me.rdoAPPL.Location = rdo1
                        'If the StockPArr(i) is the current stock price of MSFT'
                        Case MSFT.CStockPrice
                            'Set the stock label and rdo button to locations 1'
                            Me.lblStockMS.Location = l1
                            Me.rdoMSFT.Location = rdo1
                        'If the StockPArr(i) is the current stock price of WOW'
                        Case WOW.CStockPrice
                            'Set the stock label and rdo button to locations 1'
                            Me.lblStockWO.Location = l1
                            Me.rdoWOW.Location = rdo1
                        'If the StockPArr(i) is the current stock price of CMB'
                        Case CMB.CStockPrice
                            'Set the stock label and rdo button to locations 1'
                            Me.lblStockCM.Location = l1
                            Me.rdoCMB.Location = rdo1
                        'If the StockPArr(i) is the current stock price of BHP'
                        Case BHP.CStockPrice
                            'Set the stock label and rdo button to locations 1'
                            Me.lblStockBH.Location = l1
                            Me.rdoBHP.Location = rdo1
                    End Select
                'if i = 2'
                Case 2
                    Select Case StockPArr(i)
                        'If the StockPArr(i) is the current stock price of APPL'
                        Case APPL.CStockPrice
                            'Set the stock label and rdo button to locations 2'
                            Me.lblStockAP.Location = l2
                            Me.rdoAPPL.Location = rdo2
                        'If the StockPArr(i) is the current stock price of MSFT'
                        Case MSFT.CStockPrice
                            'Set the stock label and rdo button to locations 2'
                            Me.lblStockMS.Location = l2
                            Me.rdoMSFT.Location = rdo2
                        'If the StockPArr(i) is the current stock price of WOW'
                        Case WOW.CStockPrice
                            'Set the stock label and rdo button to locations 2'
                            Me.lblStockWO.Location = l2
                            Me.rdoWOW.Location = rdo2
                        'If the StockPArr(i) is the current stock price of CMB'
                        Case CMB.CStockPrice
                            'Set the stock label and rdo button to locations 2'
                            Me.lblStockCM.Location = l2
                            Me.rdoCMB.Location = rdo2
                        'If the StockPArr(i) is the current stock price of BHP'
                        Case BHP.CStockPrice
                            'Set the stock label and rdo button to locations 2'
                            Me.lblStockBH.Location = l2
                            Me.rdoBHP.Location = rdo2
                    End Select
                'if i = 3'
                Case 3
                    Select Case StockPArr(i)
                        'If the StockPArr(i) is the current stock price of APPL'
                        Case APPL.CStockPrice
                            'Set the stock label and rdo button to locations 3'
                            Me.lblStockAP.Location = l3
                            Me.rdoAPPL.Location = rdo3
                        'If the StockPArr(i) is the current stock price of MSFT'
                        Case MSFT.CStockPrice
                            'Set the stock label and rdo button to locations 3'
                            Me.lblStockMS.Location = l3
                            Me.rdoMSFT.Location = rdo3
                        'If the StockPArr(i) is the current stock price of WOW'
                        Case WOW.CStockPrice
                            'Set the stock label and rdo button to locations 3'
                            Me.lblStockWO.Location = l3
                            Me.rdoWOW.Location = rdo3
                        'If the StockPArr(i) is the current stock price of CMB'
                        Case CMB.CStockPrice
                            'Set the stock label and rdo button to locations 3'
                            Me.lblStockCM.Location = l3
                            Me.rdoCMB.Location = rdo3
                        'If the StockPArr(i) is the current stock price of BHP'
                        Case BHP.CStockPrice
                            'Set the stock label and rdo button to locations 3'
                            Me.lblStockBH.Location = l3
                            Me.rdoBHP.Location = rdo3
                    End Select
                'if i = 4'
                Case 4
                    Select Case StockPArr(i)
                        'If the StockPArr(i) is the current stock price of APPL'
                        Case APPL.CStockPrice
                            'Set the stock label and rdo button to locations 4'
                            Me.lblStockAP.Location = l4
                            Me.rdoAPPL.Location = rdo4
                        'If the StockPArr(i) is the current stock price of MSFT'
                        Case MSFT.CStockPrice
                            'Set the stock label and rdo button to locations 4'
                            Me.lblStockMS.Location = l4
                            Me.rdoMSFT.Location = rdo4
                        'If the StockPArr(i) is the current stock price of WOW'
                        Case WOW.CStockPrice
                            'Set the stock label and rdo button to locations 4'
                            Me.lblStockWO.Location = l4
                            Me.rdoWOW.Location = rdo4
                        'If the StockPArr(i) is the current stock price of CMB'
                        Case CMB.CStockPrice
                            'Set the stock label and rdo button to locations 4'
                            Me.lblStockCM.Location = l4
                            Me.rdoCMB.Location = rdo4
                        'If the StockPArr(i) is the current stock price of BHP'
                        Case BHP.CStockPrice
                            Me.lblStockBH.Location = l4
                            Me.rdoBHP.Location = rdo4
                    End Select
                'if i = 5'
                Case 5
                    Select Case StockPArr(i)
                        'If the StockPArr(i) is the current stock price of APPL'
                        Case APPL.CStockPrice
                            'Set the stock label and rdo button to locations 5'
                            Me.lblStockAP.Location = l5
                            Me.rdoAPPL.Location = rdo5
                        'If the StockPArr(i) is the current stock price of MSFT'
                        Case MSFT.CStockPrice
                            'Set the stock label and rdo button to locations 5'
                            Me.lblStockMS.Location = l5
                            Me.rdoMSFT.Location = rdo5
                        'If the StockPArr(i) is the current stock price of WOW'
                        Case WOW.CStockPrice
                            'Set the stock label and rdo button to locations 5'
                            Me.lblStockWO.Location = l5
                            Me.rdoWOW.Location = rdo5
                        'If the StockPArr(i) is the current stock price of CMB'
                        Case CMB.CStockPrice
                            'Set the stock label and rdo button to locations 5'
                            Me.lblStockCM.Location = l5
                            Me.rdoCMB.Location = rdo5
                        'If the StockPArr(i) is the current stock price of BHP'
                        Case BHP.CStockPrice
                            'Set the stock label and rdo button to locations 5'
                            Me.lblStockBH.Location = l5
                            Me.rdoBHP.Location = rdo5
                    End Select
            End Select
        Next i

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
    ''' Updates the labels on the main menu to included current stock prices
    ''' </summary>
    Public Sub UpdateLabels()
        'Updates the stock labels with current price'
        lblStockAP.Text = ("Apple (APPL)   Current Price: $" & APPL.CStockPrice)
        lblStockMS.Text = ("Microsoft (MSFT)  Current Price: $" & MSFT.CStockPrice)
        lblStockWO.Text = ("Woolworths (WOW)  Current Price: $" & WOW.CStockPrice)
        lblStockCM.Text = ("Commonweath Bank (CMB)   Current Price: $" & CMB.CStockPrice)
        lblStockBH.Text = ("BHP (BHP)   Current Price: $" & BHP.CStockPrice)
    End Sub

    ''' <summary>
    ''' Hides the current page and shows the move analysis page
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub AnalysisPage(sender As Object, e As EventArgs) Handles btnAnalysis.Click
        'Hide current page'
        Me.Hide()
        'Shows analysis page'
        Form5.Show()
    End Sub

    ''' <summary>
    ''' Exits the program via a button press
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    ''' <summary>
    ''' Ends the current day of play and moves to the next day/turn via a button press
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub Turn(sender As Object, e As EventArgs) Handles btnTurn.Click
        'Calls the next turn sub on the module 2 page'
        Module2.NextTurn()
    End Sub

    ''' <summary>
    ''' Updates the labels on the main menu with the current values of funds, name and day
    ''' </summary>
    Public Sub MainMenuUpDate()
        'Updates the label for funds'
        lblFunds.Text = "Funds: " & Funds
        'Updates the label for name'
        lblName.Text = "Name: " & PName
        'Updates the label for day'
        lblDay.Text = "Day: " & Day
    End Sub

End Class
