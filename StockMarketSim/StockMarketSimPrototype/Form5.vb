Public Class Form5
    'Sets up the analysis rating variable'
    Dim AnalysisRating As Integer

    ''' <summary>
    ''' Returns to the main menu via a button press
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub Back(sender As Object, e As EventArgs) Handles btnBack.Click
        'Closes the current page'
        Me.Close()
        'Shows the main menu page'
        Form1.Show()
    End Sub

    ''' <summary>
    ''' Displays the analysed move to the user via a label
    ''' </summary>
    Private Sub DisplayAnalysedScore()
        'Sets the label to be the most recent move plus its analysed rating'
        lblAnalyseMove.Text = (Form4.RecentMove & " " & AnalysisRating & "/5")
    End Sub

    ''' <summary>
    ''' Primary analysis of the moves through its change score, stock choice and type of action
    ''' </summary>
    ''' <param name="StockName">The name of the stock interacted with by the user</param>
    ''' <param name="StockChange">The change value of the stock</param>
    ''' <param name="MvType">The type of move by the user, either bought or sold</param>
    Public Sub AnalyseMove(StockName As String, StockChange As Integer, MvType As String)
        'Sets the base analysis rating to be 1'
        AnalysisRating = 1
        'Checks if the user interacted with the best stock'
        If CheckStockChoice() = StockName Then
            'Adds 2 to the analysis rating'
            AnalysisRating = AnalysisRating + 2
        Else
            'Adds one to the analysis rating'
            AnalysisRating = AnalysisRating + 1
        End If

        'Checks if the user invested in a stock with a good change rate'
        If CheckStockChange(StockChange) = True Then
            'Increases analysis rating by 1'
            AnalysisRating = AnalysisRating + 1
        End If

        'Checks if the user made the right choice in either buying or selling the stock'
        If CheckRightBorS(MvType, StockChange) = True Then
            'Increases analysis score by 1'
            AnalysisRating = AnalysisRating + 1
        End If
    End Sub

    ''' <summary>
    ''' Calculates the best stock to have interacted with and returns the stocks name
    ''' </summary>
    ''' <returns>Name of best calculated stock</returns>
    Private Function CheckStockChoice()
        'Sets up the best stock variable'
        Dim BestStock

        'Sets the default best stock to be APPL as a baseline'
        BestStock = "APPL"

        'If the MSFT stock has a better change rate than APPL'
        If APPL.StockChange <= MSFT.StockChange Then
            'Best stock becomes MSFT'
            BestStock = "MSFT"
            'If the WOW stock has a better change rate than MSFT'
            If MSFT.StockChange <= WOW.StockChange Then
                'Best stock becomes WOW'
                BestStock = "WOW"
                'If the CMB stock has a better change rate than WOW'
                If WOW.StockChange <= CMB.StockChange Then
                    'Best stock becomes CMB'
                    BestStock = "CMB"
                    'If the BHP stock has a better change rate than CMB'
                    If CMB.StockChange <= BHP.StockChange Then
                        'Best stock becomes BHP'
                        BestStock = "BHP"
                    End If
                End If
            End If
        End If

        'Returns the calulated best stock'
        Return BestStock

    End Function

    ''' <summary>
    ''' Checks if the stock interacted with by the user has a positive change rate
    ''' </summary>
    ''' <param name="StockChange">The change rate of the interacted stock</param>
    ''' <returns>Either true or false</returns>
    Private Function CheckStockChange(StockChange As Integer)
        'If the stock change rate is positive'
        If StockChange < 0 Then
            'Return the true value'
            Return True
        Else
            'Return the false value'
            Return False
        End If
    End Function

    ''' <summary>
    ''' Calulates if the move type made was the best choice
    ''' </summary>
    ''' <param name="MvType">Type of move, either bought or sold</param>
    ''' <param name="StockChange">The interacted stocks change rate</param>
    ''' <returns>Either true or false</returns>
    Private Function CheckRightBorS(MvType As String, StockChange As Integer)
        'If the stock change rate is positive and shares were sold'
        If MvType = "Sold" & StockChange > 0 Then
            'Return the true value'
            Return True
            'If the Stock Change value is negative and shares were bought'
        ElseIf MvType = "Bought" & StockChange < 0 Then
            'Return the true value'
            Return True
        Else
            'Return the false value'
            Return False
        End If
    End Function

    ''' <summary>
    ''' Activates the display analysis subroutine on the pages loading
    ''' </summary>
    ''' <param name="sender">Reference to the control which called the subroutine</param>
    ''' <param name="e">Provides more information about the event that caused this subroutine to be called</param>
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Activates the display analysis subroutine'
        DisplayAnalysedScore()
    End Sub
End Class