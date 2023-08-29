<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.lblPastMoves = New System.Windows.Forms.Label()
        Me.lblRecentMove = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lstPastMoves = New System.Windows.Forms.ListBox()
        Me.lblName = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPastMoves
        '
        Me.lblPastMoves.AutoSize = True
        Me.lblPastMoves.Font = New System.Drawing.Font("Showcard Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPastMoves.Location = New System.Drawing.Point(275, 25)
        Me.lblPastMoves.Name = "lblPastMoves"
        Me.lblPastMoves.Size = New System.Drawing.Size(222, 43)
        Me.lblPastMoves.TabIndex = 1
        Me.lblPastMoves.Text = "Past Moves"
        '
        'lblRecentMove
        '
        Me.lblRecentMove.AutoSize = True
        Me.lblRecentMove.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRecentMove.Location = New System.Drawing.Point(233, 82)
        Me.lblRecentMove.Name = "lblRecentMove"
        Me.lblRecentMove.Size = New System.Drawing.Size(136, 28)
        Me.lblRecentMove.TabIndex = 4
        Me.lblRecentMove.Text = "Most Recent: "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 454)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(587, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(214, 454)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(334, 370)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(113, 29)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Back to Menu"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lstPastMoves
        '
        Me.lstPastMoves.FormattingEnabled = True
        Me.lstPastMoves.ItemHeight = 20
        Me.lstPastMoves.Location = New System.Drawing.Point(233, 134)
        Me.lstPastMoves.Name = "lstPastMoves"
        Me.lstPastMoves.Size = New System.Drawing.Size(333, 204)
        Me.lstPastMoves.TabIndex = 8
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(12, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(81, 28)
        Me.lblName.TabIndex = 9
        Me.lblName.Text = "Player 1"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lstPastMoves)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblRecentMove)
        Me.Controls.Add(Me.lblPastMoves)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form4"
        Me.Text = "Past Moves"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPastMoves As Label
    Friend WithEvents lblRecentMove As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents lstPastMoves As ListBox
    Friend WithEvents lblName As Label
End Class
