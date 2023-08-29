<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.PicScreen1 = New System.Windows.Forms.PictureBox()
        Me.PicScreen2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lstHS = New System.Windows.Forms.ListBox()
        Me.lblUserScore = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        CType(Me.PicScreen1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicScreen2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicScreen1
        '
        Me.PicScreen1.BackgroundImage = CType(resources.GetObject("PicScreen1.BackgroundImage"), System.Drawing.Image)
        Me.PicScreen1.ErrorImage = Nothing
        Me.PicScreen1.Location = New System.Drawing.Point(0, 1)
        Me.PicScreen1.Name = "PicScreen1"
        Me.PicScreen1.Size = New System.Drawing.Size(208, 447)
        Me.PicScreen1.TabIndex = 4
        Me.PicScreen1.TabStop = False
        '
        'PicScreen2
        '
        Me.PicScreen2.BackgroundImage = CType(resources.GetObject("PicScreen2.BackgroundImage"), System.Drawing.Image)
        Me.PicScreen2.ErrorImage = Nothing
        Me.PicScreen2.Location = New System.Drawing.Point(589, 1)
        Me.PicScreen2.Name = "PicScreen2"
        Me.PicScreen2.Size = New System.Drawing.Size(208, 447)
        Me.PicScreen2.TabIndex = 5
        Me.PicScreen2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(271, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(236, 43)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "High Scores"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(326, 392)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(112, 29)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Back to Menu"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lstHS
        '
        Me.lstHS.FormattingEnabled = True
        Me.lstHS.ItemHeight = 20
        Me.lstHS.Location = New System.Drawing.Point(302, 150)
        Me.lstHS.Name = "lstHS"
        Me.lstHS.Size = New System.Drawing.Size(174, 204)
        Me.lstHS.TabIndex = 8
        '
        'lblUserScore
        '
        Me.lblUserScore.AutoSize = True
        Me.lblUserScore.Location = New System.Drawing.Point(353, 105)
        Me.lblUserScore.Name = "lblUserScore"
        Me.lblUserScore.Size = New System.Drawing.Size(53, 20)
        Me.lblUserScore.TabIndex = 9
        Me.lblUserScore.Text = "Label1"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(12, 19)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(81, 28)
        Me.lblName.TabIndex = 10
        Me.lblName.Text = "Player 1"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblUserScore)
        Me.Controls.Add(Me.lstHS)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PicScreen2)
        Me.Controls.Add(Me.PicScreen1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form3"
        Me.Text = "High Scores"
        CType(Me.PicScreen1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicScreen2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PicScreen1 As PictureBox
    Friend WithEvents PicScreen2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lstHS As ListBox
    Friend WithEvents lblUserScore As Label
    Friend WithEvents lblName As Label
End Class
