<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblStockAP = New System.Windows.Forms.Label()
        Me.lblStockMS = New System.Windows.Forms.Label()
        Me.lblStockWO = New System.Windows.Forms.Label()
        Me.btnPastMoves = New System.Windows.Forms.Button()
        Me.btnHighScores = New System.Windows.Forms.Button()
        Me.btnAnalysis = New System.Windows.Forms.Button()
        Me.lblFunds = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnTurn = New System.Windows.Forms.Button()
        Me.lblStockCM = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblStockBH = New System.Windows.Forms.Label()
        Me.rdoAPPL = New System.Windows.Forms.RadioButton()
        Me.rdoMSFT = New System.Windows.Forms.RadioButton()
        Me.rdoCMB = New System.Windows.Forms.RadioButton()
        Me.rdoWOW = New System.Windows.Forms.RadioButton()
        Me.rdoBHP = New System.Windows.Forms.RadioButton()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnSortNames = New System.Windows.Forms.Button()
        Me.btnSortPrice = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Showcard Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(174, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(473, 43)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Stock Market Simulator"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(12, 21)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(81, 28)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Player 1"
        '
        'lblStockAP
        '
        Me.lblStockAP.AutoSize = True
        Me.lblStockAP.BackColor = System.Drawing.Color.Silver
        Me.lblStockAP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStockAP.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblStockAP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblStockAP.Location = New System.Drawing.Point(12, 118)
        Me.lblStockAP.Name = "lblStockAP"
        Me.lblStockAP.Padding = New System.Windows.Forms.Padding(100, 30, 800, 0)
        Me.lblStockAP.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblStockAP.Size = New System.Drawing.Size(988, 55)
        Me.lblStockAP.TabIndex = 5
        Me.lblStockAP.Text = "Apple Inc"
        Me.lblStockAP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStockMS
        '
        Me.lblStockMS.AutoSize = True
        Me.lblStockMS.BackColor = System.Drawing.Color.Green
        Me.lblStockMS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStockMS.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblStockMS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblStockMS.Location = New System.Drawing.Point(12, 191)
        Me.lblStockMS.Name = "lblStockMS"
        Me.lblStockMS.Padding = New System.Windows.Forms.Padding(100, 30, 800, 0)
        Me.lblStockMS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblStockMS.Size = New System.Drawing.Size(989, 55)
        Me.lblStockMS.TabIndex = 6
        Me.lblStockMS.Text = "Microsoft"
        Me.lblStockMS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStockWO
        '
        Me.lblStockWO.AutoSize = True
        Me.lblStockWO.BackColor = System.Drawing.Color.YellowGreen
        Me.lblStockWO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStockWO.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblStockWO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblStockWO.Location = New System.Drawing.Point(12, 269)
        Me.lblStockWO.Name = "lblStockWO"
        Me.lblStockWO.Padding = New System.Windows.Forms.Padding(100, 30, 800, 0)
        Me.lblStockWO.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblStockWO.Size = New System.Drawing.Size(1009, 55)
        Me.lblStockWO.TabIndex = 7
        Me.lblStockWO.Text = "Woolworths"
        Me.lblStockWO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPastMoves
        '
        Me.btnPastMoves.Location = New System.Drawing.Point(181, 499)
        Me.btnPastMoves.Name = "btnPastMoves"
        Me.btnPastMoves.Size = New System.Drawing.Size(113, 29)
        Me.btnPastMoves.TabIndex = 10
        Me.btnPastMoves.Text = "Past Moves"
        Me.btnPastMoves.UseVisualStyleBackColor = True
        '
        'btnHighScores
        '
        Me.btnHighScores.Location = New System.Drawing.Point(21, 499)
        Me.btnHighScores.Name = "btnHighScores"
        Me.btnHighScores.Size = New System.Drawing.Size(126, 29)
        Me.btnHighScores.TabIndex = 11
        Me.btnHighScores.Text = "High Scores"
        Me.btnHighScores.UseVisualStyleBackColor = True
        '
        'btnAnalysis
        '
        Me.btnAnalysis.Location = New System.Drawing.Point(333, 498)
        Me.btnAnalysis.Name = "btnAnalysis"
        Me.btnAnalysis.Size = New System.Drawing.Size(143, 29)
        Me.btnAnalysis.TabIndex = 12
        Me.btnAnalysis.Text = "Move Analysis"
        Me.btnAnalysis.UseVisualStyleBackColor = True
        '
        'lblFunds
        '
        Me.lblFunds.AutoSize = True
        Me.lblFunds.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblFunds.Location = New System.Drawing.Point(662, 46)
        Me.lblFunds.Name = "lblFunds"
        Me.lblFunds.Size = New System.Drawing.Size(116, 28)
        Me.lblFunds.TabIndex = 13
        Me.lblFunds.Text = "Funds: 1000"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblDay.Location = New System.Drawing.Point(662, 13)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(66, 28)
        Me.lblDay.TabIndex = 14
        Me.lblDay.Text = "Day: 1"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(647, 498)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(116, 29)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnTurn
        '
        Me.btnTurn.Location = New System.Drawing.Point(662, 77)
        Me.btnTurn.Name = "btnTurn"
        Me.btnTurn.Size = New System.Drawing.Size(103, 29)
        Me.btnTurn.TabIndex = 16
        Me.btnTurn.Text = "End Day"
        Me.btnTurn.UseVisualStyleBackColor = True
        '
        'lblStockCM
        '
        Me.lblStockCM.AutoSize = True
        Me.lblStockCM.BackColor = System.Drawing.Color.Gold
        Me.lblStockCM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStockCM.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblStockCM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblStockCM.Location = New System.Drawing.Point(12, 345)
        Me.lblStockCM.Name = "lblStockCM"
        Me.lblStockCM.Padding = New System.Windows.Forms.Padding(100, 30, 800, 0)
        Me.lblStockCM.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblStockCM.Size = New System.Drawing.Size(1084, 55)
        Me.lblStockCM.TabIndex = 17
        Me.lblStockCM.Text = "Commonwealth Bank"
        Me.lblStockCM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(662, 479)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(116, 32)
        Me.Button5.TabIndex = 30
        Me.Button5.Text = "Info"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(24, 466)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(100, 20, 450, 0)
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(623, 45)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Stock C"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(662, 413)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(116, 32)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "Info"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(662, 349)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(116, 32)
        Me.Button7.TabIndex = 27
        Me.Button7.Text = "Info"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(22, 400)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(100, 20, 450, 0)
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(623, 45)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Stock C"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(22, 336)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(100, 20, 450, 0)
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(623, 45)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Stock B"
        '
        'lblStockBH
        '
        Me.lblStockBH.AutoSize = True
        Me.lblStockBH.BackColor = System.Drawing.Color.SlateBlue
        Me.lblStockBH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStockBH.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblStockBH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblStockBH.Location = New System.Drawing.Point(12, 418)
        Me.lblStockBH.Name = "lblStockBH"
        Me.lblStockBH.Padding = New System.Windows.Forms.Padding(100, 30, 800, 0)
        Me.lblStockBH.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblStockBH.Size = New System.Drawing.Size(946, 55)
        Me.lblStockBH.TabIndex = 19
        Me.lblStockBH.Text = "BHP"
        Me.lblStockBH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rdoAPPL
        '
        Me.rdoAPPL.AutoSize = True
        Me.rdoAPPL.BackColor = System.Drawing.Color.Silver
        Me.rdoAPPL.Location = New System.Drawing.Point(647, 133)
        Me.rdoAPPL.Name = "rdoAPPL"
        Me.rdoAPPL.Size = New System.Drawing.Size(107, 24)
        Me.rdoAPPL.TabIndex = 30
        Me.rdoAPPL.TabStop = True
        Me.rdoAPPL.Text = "APPL Select"
        Me.rdoAPPL.UseVisualStyleBackColor = False
        '
        'rdoMSFT
        '
        Me.rdoMSFT.AutoSize = True
        Me.rdoMSFT.BackColor = System.Drawing.Color.Green
        Me.rdoMSFT.Location = New System.Drawing.Point(646, 210)
        Me.rdoMSFT.Name = "rdoMSFT"
        Me.rdoMSFT.Size = New System.Drawing.Size(110, 24)
        Me.rdoMSFT.TabIndex = 31
        Me.rdoMSFT.TabStop = True
        Me.rdoMSFT.Text = "MSFT Select"
        Me.rdoMSFT.UseVisualStyleBackColor = False
        '
        'rdoCMB
        '
        Me.rdoCMB.AutoSize = True
        Me.rdoCMB.BackColor = System.Drawing.Color.Gold
        Me.rdoCMB.Location = New System.Drawing.Point(647, 361)
        Me.rdoCMB.Name = "rdoCMB"
        Me.rdoCMB.Size = New System.Drawing.Size(105, 24)
        Me.rdoCMB.TabIndex = 33
        Me.rdoCMB.TabStop = True
        Me.rdoCMB.Text = "CMB Select"
        Me.rdoCMB.UseVisualStyleBackColor = False
        '
        'rdoWOW
        '
        Me.rdoWOW.AutoSize = True
        Me.rdoWOW.BackColor = System.Drawing.Color.YellowGreen
        Me.rdoWOW.Location = New System.Drawing.Point(647, 285)
        Me.rdoWOW.Name = "rdoWOW"
        Me.rdoWOW.Size = New System.Drawing.Size(113, 24)
        Me.rdoWOW.TabIndex = 32
        Me.rdoWOW.TabStop = True
        Me.rdoWOW.Text = "WOW Select"
        Me.rdoWOW.UseVisualStyleBackColor = False
        '
        'rdoBHP
        '
        Me.rdoBHP.AutoSize = True
        Me.rdoBHP.BackColor = System.Drawing.Color.SlateBlue
        Me.rdoBHP.Location = New System.Drawing.Point(647, 433)
        Me.rdoBHP.Name = "rdoBHP"
        Me.rdoBHP.Size = New System.Drawing.Size(102, 24)
        Me.rdoBHP.TabIndex = 34
        Me.rdoBHP.TabStop = True
        Me.rdoBHP.Text = "BHP Select"
        Me.rdoBHP.UseVisualStyleBackColor = False
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(507, 498)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(94, 29)
        Me.btnInfo.TabIndex = 40
        Me.btnInfo.Text = "Info"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'btnSortNames
        '
        Me.btnSortNames.Location = New System.Drawing.Point(174, 68)
        Me.btnSortNames.Name = "btnSortNames"
        Me.btnSortNames.Size = New System.Drawing.Size(120, 33)
        Me.btnSortNames.TabIndex = 43
        Me.btnSortNames.Text = "Sort by Name"
        Me.btnSortNames.UseVisualStyleBackColor = True
        '
        'btnSortPrice
        '
        Me.btnSortPrice.Location = New System.Drawing.Point(333, 68)
        Me.btnSortPrice.Name = "btnSortPrice"
        Me.btnSortPrice.Size = New System.Drawing.Size(120, 33)
        Me.btnSortPrice.TabIndex = 44
        Me.btnSortPrice.Text = "Sort by Price"
        Me.btnSortPrice.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 543)
        Me.Controls.Add(Me.btnSortPrice)
        Me.Controls.Add(Me.btnSortNames)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.rdoBHP)
        Me.Controls.Add(Me.rdoCMB)
        Me.Controls.Add(Me.rdoWOW)
        Me.Controls.Add(Me.rdoMSFT)
        Me.Controls.Add(Me.rdoAPPL)
        Me.Controls.Add(Me.lblStockBH)
        Me.Controls.Add(Me.lblStockCM)
        Me.Controls.Add(Me.btnTurn)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblFunds)
        Me.Controls.Add(Me.btnAnalysis)
        Me.Controls.Add(Me.btnHighScores)
        Me.Controls.Add(Me.btnPastMoves)
        Me.Controls.Add(Me.lblStockWO)
        Me.Controls.Add(Me.lblStockMS)
        Me.Controls.Add(Me.lblStockAP)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Stock Market Simulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblStockAP As Label
    Friend WithEvents lblStockMS As Label
    Friend WithEvents lblStockWO As Label
    Friend WithEvents btnPastMoves As Button
    Friend WithEvents btnHighScores As Button
    Friend WithEvents btnAnalysis As Button
    Friend WithEvents lblFunds As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnTurn As Button
    Friend WithEvents lblStockCM As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblStockBH As Label
    Friend WithEvents rdoAPPL As RadioButton
    Friend WithEvents rdoMSFT As RadioButton
    Friend WithEvents rdoCMB As RadioButton
    Friend WithEvents rdoWOW As RadioButton
    Friend WithEvents rdoBHP As RadioButton
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnSortNames As Button
    Friend WithEvents btnSortPrice As Button
End Class
