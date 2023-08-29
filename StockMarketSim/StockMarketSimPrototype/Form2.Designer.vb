<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.lblStockName = New System.Windows.Forms.Label()
        Me.lblSharesAv = New System.Windows.Forms.Label()
        Me.btnBuyStock = New System.Windows.Forms.Button()
        Me.btnSellStock = New System.Windows.Forms.Button()
        Me.lblSharOwned = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblFunds = New System.Windows.Forms.Label()
        Me.lblCurStockPrice = New System.Windows.Forms.Label()
        Me.PicStocks = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        CType(Me.PicStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStockName
        '
        Me.lblStockName.AutoSize = True
        Me.lblStockName.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStockName.Location = New System.Drawing.Point(354, 27)
        Me.lblStockName.Name = "lblStockName"
        Me.lblStockName.Size = New System.Drawing.Size(233, 50)
        Me.lblStockName.TabIndex = 2
        Me.lblStockName.Text = "ASX Stock"
        '
        'lblSharesAv
        '
        Me.lblSharesAv.AutoSize = True
        Me.lblSharesAv.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSharesAv.Location = New System.Drawing.Point(707, 199)
        Me.lblSharesAv.Name = "lblSharesAv"
        Me.lblSharesAv.Size = New System.Drawing.Size(211, 28)
        Me.lblSharesAv.TabIndex = 4
        Me.lblSharesAv.Text = "Shares Avaliable: 1000"
        '
        'btnBuyStock
        '
        Me.btnBuyStock.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBuyStock.Location = New System.Drawing.Point(58, 293)
        Me.btnBuyStock.Name = "btnBuyStock"
        Me.btnBuyStock.Size = New System.Drawing.Size(205, 44)
        Me.btnBuyStock.TabIndex = 5
        Me.btnBuyStock.Text = "Buy"
        Me.btnBuyStock.UseVisualStyleBackColor = True
        '
        'btnSellStock
        '
        Me.btnSellStock.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSellStock.Location = New System.Drawing.Point(58, 384)
        Me.btnSellStock.Name = "btnSellStock"
        Me.btnSellStock.Size = New System.Drawing.Size(205, 44)
        Me.btnSellStock.TabIndex = 6
        Me.btnSellStock.Text = "Sell"
        Me.btnSellStock.UseVisualStyleBackColor = True
        '
        'lblSharOwned
        '
        Me.lblSharOwned.AutoSize = True
        Me.lblSharOwned.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSharOwned.Location = New System.Drawing.Point(707, 278)
        Me.lblSharOwned.Name = "lblSharOwned"
        Me.lblSharOwned.Size = New System.Drawing.Size(165, 28)
        Me.lblSharOwned.TabIndex = 7
        Me.lblSharOwned.Text = "Shares Owned: 0"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(404, 440)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(169, 39)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back to Menu"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblDay.Location = New System.Drawing.Point(786, 21)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(66, 28)
        Me.lblDay.TabIndex = 16
        Me.lblDay.Text = "Day: 1"
        '
        'lblFunds
        '
        Me.lblFunds.AutoSize = True
        Me.lblFunds.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblFunds.Location = New System.Drawing.Point(786, 49)
        Me.lblFunds.Name = "lblFunds"
        Me.lblFunds.Size = New System.Drawing.Size(116, 28)
        Me.lblFunds.TabIndex = 15
        Me.lblFunds.Text = "Funds: 1000"
        '
        'lblCurStockPrice
        '
        Me.lblCurStockPrice.AutoSize = True
        Me.lblCurStockPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCurStockPrice.Location = New System.Drawing.Point(404, 134)
        Me.lblCurStockPrice.Name = "lblCurStockPrice"
        Me.lblCurStockPrice.Size = New System.Drawing.Size(69, 28)
        Me.lblCurStockPrice.TabIndex = 17
        Me.lblCurStockPrice.Text = "Label1"
        '
        'PicStocks
        '
        Me.PicStocks.Location = New System.Drawing.Point(58, 12)
        Me.PicStocks.Name = "PicStocks"
        Me.PicStocks.Size = New System.Drawing.Size(290, 233)
        Me.PicStocks.TabIndex = 18
        Me.PicStocks.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(786, 90)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(81, 28)
        Me.lblName.TabIndex = 19
        Me.lblName.Text = "Player 1"
        '
        'Form2
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(930, 526)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.PicStocks)
        Me.Controls.Add(Me.lblCurStockPrice)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblFunds)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblSharOwned)
        Me.Controls.Add(Me.btnSellStock)
        Me.Controls.Add(Me.btnBuyStock)
        Me.Controls.Add(Me.lblSharesAv)
        Me.Controls.Add(Me.lblStockName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form2"
        Me.Text = "Stock Market Info"
        CType(Me.PicStocks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStockName As Label
    Friend WithEvents lblSharesAv As Label
    Friend WithEvents btnBuyStock As Button
    Friend WithEvents btnSellStock As Button
    Friend WithEvents lblSharOwned As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblDay As Label
    Friend WithEvents lblFunds As Label
    Friend WithEvents lblCurStockPrice As Label
    Friend WithEvents PicStocks As PictureBox
    Friend WithEvents lblName As Label
End Class
