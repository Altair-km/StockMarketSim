<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.lblAnalysis = New System.Windows.Forms.Label()
        Me.PicScreen2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAnalyseMove = New System.Windows.Forms.Label()
        Me.lblAnalysisDesc = New System.Windows.Forms.Label()
        Me.lblAnalysisDescription2 = New System.Windows.Forms.Label()
        Me.lblAnalysisDescription3 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        CType(Me.PicScreen2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAnalysis
        '
        Me.lblAnalysis.AutoSize = True
        Me.lblAnalysis.Font = New System.Drawing.Font("Showcard Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAnalysis.Location = New System.Drawing.Point(262, 30)
        Me.lblAnalysis.Name = "lblAnalysis"
        Me.lblAnalysis.Size = New System.Drawing.Size(274, 43)
        Me.lblAnalysis.TabIndex = 7
        Me.lblAnalysis.Text = "Game Analysis"
        '
        'PicScreen2
        '
        Me.PicScreen2.BackgroundImage = CType(resources.GetObject("PicScreen2.BackgroundImage"), System.Drawing.Image)
        Me.PicScreen2.ErrorImage = Nothing
        Me.PicScreen2.Location = New System.Drawing.Point(2, 1)
        Me.PicScreen2.Name = "PicScreen2"
        Me.PicScreen2.Size = New System.Drawing.Size(167, 447)
        Me.PicScreen2.TabIndex = 8
        Me.PicScreen2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(635, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 447)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(338, 409)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(113, 29)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back to Menu"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(321, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 11
        '
        'lblAnalyseMove
        '
        Me.lblAnalyseMove.AutoSize = True
        Me.lblAnalyseMove.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAnalyseMove.Location = New System.Drawing.Point(204, 199)
        Me.lblAnalyseMove.Name = "lblAnalyseMove"
        Me.lblAnalyseMove.Size = New System.Drawing.Size(247, 28)
        Me.lblAnalyseMove.TabIndex = 12
        Me.lblAnalyseMove.Text = "Bought ASX for 30 Shares"
        '
        'lblAnalysisDesc
        '
        Me.lblAnalysisDesc.AutoSize = True
        Me.lblAnalysisDesc.Location = New System.Drawing.Point(267, 90)
        Me.lblAnalysisDesc.Name = "lblAnalysisDesc"
        Me.lblAnalysisDesc.Size = New System.Drawing.Size(269, 20)
        Me.lblAnalysisDesc.TabIndex = 13
        Me.lblAnalysisDesc.Text = "Here your latest move will be analysed "
        '
        'lblAnalysisDescription2
        '
        Me.lblAnalysisDescription2.AutoSize = True
        Me.lblAnalysisDescription2.Location = New System.Drawing.Point(209, 116)
        Me.lblAnalysisDescription2.Name = "lblAnalysisDescription2"
        Me.lblAnalysisDescription2.Size = New System.Drawing.Size(378, 20)
        Me.lblAnalysisDescription2.TabIndex = 14
        Me.lblAnalysisDescription2.Text = "The analysis system will rate your move a score out of 5."
        '
        'lblAnalysisDescription3
        '
        Me.lblAnalysisDescription3.AutoSize = True
        Me.lblAnalysisDescription3.Location = New System.Drawing.Point(267, 147)
        Me.lblAnalysisDescription3.Name = "lblAnalysisDescription3"
        Me.lblAnalysisDescription3.Size = New System.Drawing.Size(232, 20)
        Me.lblAnalysisDescription3.TabIndex = 15
        Me.lblAnalysisDescription3.Text = "Use this to inform your next move"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(22, 20)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(81, 28)
        Me.lblName.TabIndex = 16
        Me.lblName.Text = "Player 1"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblAnalysisDescription3)
        Me.Controls.Add(Me.lblAnalysisDescription2)
        Me.Controls.Add(Me.lblAnalysisDesc)
        Me.Controls.Add(Me.lblAnalyseMove)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PicScreen2)
        Me.Controls.Add(Me.lblAnalysis)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form5"
        Me.Text = "Game Analysis"
        CType(Me.PicScreen2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAnalysis As Label
    Friend WithEvents PicScreen2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAnalyseMove As Label
    Friend WithEvents lblAnalysisDesc As Label
    Friend WithEvents lblAnalysisDescription2 As Label
    Friend WithEvents lblAnalysisDescription3 As Label
    Friend WithEvents lblName As Label
End Class
