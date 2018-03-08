<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeep
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
    'NOTE: The following procedure is required by the Windows Form Designer
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents deck As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn10 As System.Windows.Forms.Button
    Friend WithEvents btn11 As System.Windows.Forms.Button
    Friend WithEvents btn12 As System.Windows.Forms.Button
    Friend WithEvents btn13 As System.Windows.Forms.Button
    Friend WithEvents btnDeal As System.Windows.Forms.Button
    Friend WithEvents Player1Card8 As System.Windows.Forms.PictureBox
    Friend WithEvents Player1Card6 As System.Windows.Forms.PictureBox
    Friend WithEvents Player1Card5 As System.Windows.Forms.PictureBox
    Friend WithEvents player1Card4 As System.Windows.Forms.PictureBox
    Friend WithEvents player1Card3 As System.Windows.Forms.PictureBox
    Friend WithEvents player1card2 As System.Windows.Forms.PictureBox
    Friend WithEvents player1Card1 As System.Windows.Forms.PictureBox
    Friend WithEvents Player2Card8 As System.Windows.Forms.PictureBox
    Friend WithEvents Player2Card7 As System.Windows.Forms.PictureBox
    Friend WithEvents Player2Card6 As System.Windows.Forms.PictureBox
    Friend WithEvents Player2Card5 As System.Windows.Forms.PictureBox
    Friend WithEvents player2Card4 As System.Windows.Forms.PictureBox
    Friend WithEvents player2card3 As System.Windows.Forms.PictureBox
    Friend WithEvents player2Card2 As System.Windows.Forms.PictureBox
    Friend WithEvents Player2Card1 As System.Windows.Forms.PictureBox
    Friend WithEvents seepCard4 As System.Windows.Forms.PictureBox
    Friend WithEvents seepCard3 As System.Windows.Forms.PictureBox
    Friend WithEvents seepCard2 As System.Windows.Forms.PictureBox
    Friend WithEvents seepCard1 As System.Windows.Forms.PictureBox
    Friend WithEvents Player1Card7 As System.Windows.Forms.PictureBox
    Friend WithEvents txtPlayer1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer2 As System.Windows.Forms.TextBox
    Friend WithEvents seepCard5 As System.Windows.Forms.PictureBox
    Friend WithEvents seepCard6 As System.Windows.Forms.PictureBox
    Friend WithEvents seepCard7 As System.Windows.Forms.PictureBox
    Friend WithEvents seepCard8 As System.Windows.Forms.PictureBox
    Friend WithEvents ttPlayer1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblPlayer2Score As System.Windows.Forms.Label
    Friend WithEvents lblPlayer1Score As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblSeepCard1 As System.Windows.Forms.Label
    Friend WithEvents lblSeepCard2 As System.Windows.Forms.Label
    Friend WithEvents lblSeepCard3 As System.Windows.Forms.Label
    Friend WithEvents lblSeepCard4 As System.Windows.Forms.Label
    Friend WithEvents lblSeepCard5 As System.Windows.Forms.Label
    Friend WithEvents lblSeepCard6 As System.Windows.Forms.Label
    Friend WithEvents lblSeepCard7 As System.Windows.Forms.Label
    Friend WithEvents lblSeepCard8 As System.Windows.Forms.Label
    Friend WithEvents lblSeepCard1Value As System.Windows.Forms.Label
    Friend WithEvents lblSeepCard2Value As System.Windows.Forms.Label
    Friend WithEvents lblSeepCard3Value As System.Windows.Forms.Label
    Friend WithEvents lblSeepCard4Value As System.Windows.Forms.Label
    Friend WithEvents lblSeepCard5Value As System.Windows.Forms.Label
    Friend WithEvents lblSeepCard6Value As System.Windows.Forms.Label
    Friend WithEvents lblSeepCard7Value As System.Windows.Forms.Label
    Friend WithEvents lblSeepCard8Value As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnPickCard1 As System.Windows.Forms.Button
    Friend WithEvents btnThrowCard1 As System.Windows.Forms.Button
    Friend WithEvents btnAddPile1 As System.Windows.Forms.Button
    Friend WithEvents btnCreatePile1 As System.Windows.Forms.Button
    Friend WithEvents btnPickPile1 As System.Windows.Forms.Button
    Friend WithEvents btnThrowCard2 As System.Windows.Forms.Button
    Friend WithEvents btnPickCard2 As System.Windows.Forms.Button
    Friend WithEvents btnCreatePile2 As System.Windows.Forms.Button
    Friend WithEvents btnPickPile2 As System.Windows.Forms.Button
    Friend WithEvents btnAddPile2 As System.Windows.Forms.Button
    Friend WithEvents btnChangePile1 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnChangePile2 As System.Windows.Forms.Button
    Friend WithEvents btnSeepPoints1 As System.Windows.Forms.Button
    Friend WithEvents btnSeepPoints2 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPlayer1Seep As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPlayer2Seep As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPlayer1SeriesScore As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPlayer2SeriesScore As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblPlayer2Score = New System.Windows.Forms.Label()
        Me.btn13 = New System.Windows.Forms.Button()
        Me.btn12 = New System.Windows.Forms.Button()
        Me.btn11 = New System.Windows.Forms.Button()
        Me.btn10 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDeal = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.deck = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblPlayer1Score = New System.Windows.Forms.Label()
        Me.Player1Card8 = New System.Windows.Forms.PictureBox()
        Me.Player1Card7 = New System.Windows.Forms.PictureBox()
        Me.Player1Card6 = New System.Windows.Forms.PictureBox()
        Me.Player1Card5 = New System.Windows.Forms.PictureBox()
        Me.player1Card4 = New System.Windows.Forms.PictureBox()
        Me.player1Card3 = New System.Windows.Forms.PictureBox()
        Me.player1card2 = New System.Windows.Forms.PictureBox()
        Me.player1Card1 = New System.Windows.Forms.PictureBox()
        Me.Player2Card8 = New System.Windows.Forms.PictureBox()
        Me.Player2Card7 = New System.Windows.Forms.PictureBox()
        Me.Player2Card6 = New System.Windows.Forms.PictureBox()
        Me.Player2Card5 = New System.Windows.Forms.PictureBox()
        Me.player2Card4 = New System.Windows.Forms.PictureBox()
        Me.player2card3 = New System.Windows.Forms.PictureBox()
        Me.player2Card2 = New System.Windows.Forms.PictureBox()
        Me.Player2Card1 = New System.Windows.Forms.PictureBox()
        Me.seepCard4 = New System.Windows.Forms.PictureBox()
        Me.seepCard3 = New System.Windows.Forms.PictureBox()
        Me.seepCard2 = New System.Windows.Forms.PictureBox()
        Me.seepCard1 = New System.Windows.Forms.PictureBox()
        Me.txtPlayer1 = New System.Windows.Forms.TextBox()
        Me.txtPlayer2 = New System.Windows.Forms.TextBox()
        Me.seepCard5 = New System.Windows.Forms.PictureBox()
        Me.seepCard6 = New System.Windows.Forms.PictureBox()
        Me.seepCard7 = New System.Windows.Forms.PictureBox()
        Me.seepCard8 = New System.Windows.Forms.PictureBox()
        Me.ttPlayer1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblSeepCard1 = New System.Windows.Forms.Label()
        Me.lblSeepCard2 = New System.Windows.Forms.Label()
        Me.lblSeepCard3 = New System.Windows.Forms.Label()
        Me.lblSeepCard4 = New System.Windows.Forms.Label()
        Me.lblSeepCard5 = New System.Windows.Forms.Label()
        Me.lblSeepCard6 = New System.Windows.Forms.Label()
        Me.lblSeepCard7 = New System.Windows.Forms.Label()
        Me.lblSeepCard8 = New System.Windows.Forms.Label()
        Me.lblSeepCard1Value = New System.Windows.Forms.Label()
        Me.lblSeepCard2Value = New System.Windows.Forms.Label()
        Me.lblSeepCard3Value = New System.Windows.Forms.Label()
        Me.lblSeepCard4Value = New System.Windows.Forms.Label()
        Me.lblSeepCard5Value = New System.Windows.Forms.Label()
        Me.lblSeepCard6Value = New System.Windows.Forms.Label()
        Me.lblSeepCard7Value = New System.Windows.Forms.Label()
        Me.lblSeepCard8Value = New System.Windows.Forms.Label()
        Me.btnPickCard1 = New System.Windows.Forms.Button()
        Me.btnCreatePile1 = New System.Windows.Forms.Button()
        Me.btnPickPile1 = New System.Windows.Forms.Button()
        Me.btnAddPile1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnThrowCard1 = New System.Windows.Forms.Button()
        Me.btnThrowCard2 = New System.Windows.Forms.Button()
        Me.btnPickCard2 = New System.Windows.Forms.Button()
        Me.btnCreatePile2 = New System.Windows.Forms.Button()
        Me.btnPickPile2 = New System.Windows.Forms.Button()
        Me.btnAddPile2 = New System.Windows.Forms.Button()
        Me.btnChangePile1 = New System.Windows.Forms.Button()
        Me.btnChangePile2 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSeepPoints1 = New System.Windows.Forms.Button()
        Me.btnSeepPoints2 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPlayer1Seep = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPlayer2Seep = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblPlayer1SeriesScore = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblPlayer2SeriesScore = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        CType(Me.deck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Player1Card8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1Card7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1Card6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1Card5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player1Card4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player1Card3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player1card2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player1Card1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2Card8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2Card7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2Card6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2Card5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player2Card4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player2card3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player2Card2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2Card1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seepCard4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seepCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seepCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seepCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seepCard5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seepCard6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seepCard7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seepCard8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblPlayer2Score)
        Me.GroupBox5.Location = New System.Drawing.Point(1128, 720)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(152, 48)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Player 2 Score"
        '
        'lblPlayer2Score
        '
        Me.lblPlayer2Score.Location = New System.Drawing.Point(64, 16)
        Me.lblPlayer2Score.Name = "lblPlayer2Score"
        Me.lblPlayer2Score.Size = New System.Drawing.Size(80, 24)
        Me.lblPlayer2Score.TabIndex = 8
        '
        'btn13
        '
        Me.btn13.Location = New System.Drawing.Point(112, 400)
        Me.btn13.Name = "btn13"
        Me.btn13.Size = New System.Drawing.Size(32, 23)
        Me.btn13.TabIndex = 6
        Me.btn13.Text = "13"
        '
        'btn12
        '
        Me.btn12.Location = New System.Drawing.Point(80, 400)
        Me.btn12.Name = "btn12"
        Me.btn12.Size = New System.Drawing.Size(32, 23)
        Me.btn12.TabIndex = 5
        Me.btn12.Text = "12"
        '
        'btn11
        '
        Me.btn11.Location = New System.Drawing.Point(128, 376)
        Me.btn11.Name = "btn11"
        Me.btn11.Size = New System.Drawing.Size(32, 23)
        Me.btn11.TabIndex = 4
        Me.btn11.Text = "11"
        '
        'btn10
        '
        Me.btn10.Location = New System.Drawing.Point(96, 376)
        Me.btn10.Name = "btn10"
        Me.btn10.Size = New System.Drawing.Size(32, 24)
        Me.btn10.TabIndex = 3
        Me.btn10.Text = "10"
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(72, 376)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(24, 23)
        Me.btn9.TabIndex = 2
        Me.btn9.Text = "9"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 352)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Select a Number"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDeal
        '
        Me.btnDeal.Enabled = False
        Me.btnDeal.Location = New System.Drawing.Point(56, 424)
        Me.btnDeal.Name = "btnDeal"
        Me.btnDeal.Size = New System.Drawing.Size(120, 24)
        Me.btnDeal.TabIndex = 9
        Me.btnDeal.Text = "Deal"
        '
        'btnStart
        '
        Me.btnStart.Enabled = False
        Me.btnStart.Location = New System.Drawing.Point(56, 328)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(120, 24)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Seep Deal"
        '
        'deck
        '
        Me.deck.Location = New System.Drawing.Point(64, 456)
        Me.deck.Name = "deck"
        Me.deck.Size = New System.Drawing.Size(96, 144)
        Me.deck.TabIndex = 2
        Me.deck.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblPlayer1Score)
        Me.GroupBox3.Location = New System.Drawing.Point(1128, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(152, 48)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Player 1 Score"
        '
        'lblPlayer1Score
        '
        Me.lblPlayer1Score.Location = New System.Drawing.Point(64, 16)
        Me.lblPlayer1Score.Name = "lblPlayer1Score"
        Me.lblPlayer1Score.Size = New System.Drawing.Size(80, 24)
        Me.lblPlayer1Score.TabIndex = 7
        '
        'Player1Card8
        '
        Me.Player1Card8.Location = New System.Drawing.Point(936, 64)
        Me.Player1Card8.Name = "Player1Card8"
        Me.Player1Card8.Size = New System.Drawing.Size(70, 100)
        Me.Player1Card8.TabIndex = 29
        Me.Player1Card8.TabStop = False
        '
        'Player1Card7
        '
        Me.Player1Card7.Location = New System.Drawing.Point(832, 64)
        Me.Player1Card7.Name = "Player1Card7"
        Me.Player1Card7.Size = New System.Drawing.Size(70, 100)
        Me.Player1Card7.TabIndex = 28
        Me.Player1Card7.TabStop = False
        '
        'Player1Card6
        '
        Me.Player1Card6.Location = New System.Drawing.Point(728, 64)
        Me.Player1Card6.Name = "Player1Card6"
        Me.Player1Card6.Size = New System.Drawing.Size(70, 100)
        Me.Player1Card6.TabIndex = 27
        Me.Player1Card6.TabStop = False
        '
        'Player1Card5
        '
        Me.Player1Card5.Location = New System.Drawing.Point(624, 64)
        Me.Player1Card5.Name = "Player1Card5"
        Me.Player1Card5.Size = New System.Drawing.Size(70, 100)
        Me.Player1Card5.TabIndex = 26
        Me.Player1Card5.TabStop = False
        '
        'player1Card4
        '
        Me.player1Card4.Location = New System.Drawing.Point(520, 64)
        Me.player1Card4.Name = "player1Card4"
        Me.player1Card4.Size = New System.Drawing.Size(70, 100)
        Me.player1Card4.TabIndex = 25
        Me.player1Card4.TabStop = False
        '
        'player1Card3
        '
        Me.player1Card3.Location = New System.Drawing.Point(416, 64)
        Me.player1Card3.Name = "player1Card3"
        Me.player1Card3.Size = New System.Drawing.Size(70, 100)
        Me.player1Card3.TabIndex = 24
        Me.player1Card3.TabStop = False
        '
        'player1card2
        '
        Me.player1card2.Location = New System.Drawing.Point(312, 64)
        Me.player1card2.Name = "player1card2"
        Me.player1card2.Size = New System.Drawing.Size(70, 100)
        Me.player1card2.TabIndex = 23
        Me.player1card2.TabStop = False
        '
        'player1Card1
        '
        Me.player1Card1.Location = New System.Drawing.Point(208, 64)
        Me.player1Card1.Name = "player1Card1"
        Me.player1Card1.Size = New System.Drawing.Size(70, 100)
        Me.player1Card1.TabIndex = 22
        Me.player1Card1.TabStop = False
        '
        'Player2Card8
        '
        Me.Player2Card8.Location = New System.Drawing.Point(912, 768)
        Me.Player2Card8.Name = "Player2Card8"
        Me.Player2Card8.Size = New System.Drawing.Size(70, 100)
        Me.Player2Card8.TabIndex = 41
        Me.Player2Card8.TabStop = False
        '
        'Player2Card7
        '
        Me.Player2Card7.Location = New System.Drawing.Point(808, 768)
        Me.Player2Card7.Name = "Player2Card7"
        Me.Player2Card7.Size = New System.Drawing.Size(70, 100)
        Me.Player2Card7.TabIndex = 40
        Me.Player2Card7.TabStop = False
        '
        'Player2Card6
        '
        Me.Player2Card6.Location = New System.Drawing.Point(704, 768)
        Me.Player2Card6.Name = "Player2Card6"
        Me.Player2Card6.Size = New System.Drawing.Size(70, 100)
        Me.Player2Card6.TabIndex = 39
        Me.Player2Card6.TabStop = False
        '
        'Player2Card5
        '
        Me.Player2Card5.Location = New System.Drawing.Point(600, 768)
        Me.Player2Card5.Name = "Player2Card5"
        Me.Player2Card5.Size = New System.Drawing.Size(70, 100)
        Me.Player2Card5.TabIndex = 38
        Me.Player2Card5.TabStop = False
        '
        'player2Card4
        '
        Me.player2Card4.Location = New System.Drawing.Point(496, 768)
        Me.player2Card4.Name = "player2Card4"
        Me.player2Card4.Size = New System.Drawing.Size(70, 100)
        Me.player2Card4.TabIndex = 37
        Me.player2Card4.TabStop = False
        '
        'player2card3
        '
        Me.player2card3.Location = New System.Drawing.Point(392, 768)
        Me.player2card3.Name = "player2card3"
        Me.player2card3.Size = New System.Drawing.Size(70, 100)
        Me.player2card3.TabIndex = 36
        Me.player2card3.TabStop = False
        '
        'player2Card2
        '
        Me.player2Card2.Location = New System.Drawing.Point(288, 768)
        Me.player2Card2.Name = "player2Card2"
        Me.player2Card2.Size = New System.Drawing.Size(70, 100)
        Me.player2Card2.TabIndex = 35
        Me.player2Card2.TabStop = False
        '
        'Player2Card1
        '
        Me.Player2Card1.Location = New System.Drawing.Point(184, 768)
        Me.Player2Card1.Name = "Player2Card1"
        Me.Player2Card1.Size = New System.Drawing.Size(70, 100)
        Me.Player2Card1.TabIndex = 34
        Me.Player2Card1.TabStop = False
        '
        'seepCard4
        '
        Me.seepCard4.Location = New System.Drawing.Point(528, 408)
        Me.seepCard4.Name = "seepCard4"
        Me.seepCard4.Size = New System.Drawing.Size(70, 100)
        Me.seepCard4.TabIndex = 37
        Me.seepCard4.TabStop = False
        '
        'seepCard3
        '
        Me.seepCard3.Location = New System.Drawing.Point(432, 408)
        Me.seepCard3.Name = "seepCard3"
        Me.seepCard3.Size = New System.Drawing.Size(70, 100)
        Me.seepCard3.TabIndex = 36
        Me.seepCard3.TabStop = False
        '
        'seepCard2
        '
        Me.seepCard2.Location = New System.Drawing.Point(328, 408)
        Me.seepCard2.Name = "seepCard2"
        Me.seepCard2.Size = New System.Drawing.Size(70, 100)
        Me.seepCard2.TabIndex = 35
        Me.seepCard2.TabStop = False
        '
        'seepCard1
        '
        Me.seepCard1.Location = New System.Drawing.Point(232, 408)
        Me.seepCard1.Name = "seepCard1"
        Me.seepCard1.Size = New System.Drawing.Size(70, 100)
        Me.seepCard1.TabIndex = 34
        Me.seepCard1.TabStop = False
        '
        'txtPlayer1
        '
        Me.txtPlayer1.Enabled = False
        Me.txtPlayer1.Location = New System.Drawing.Point(328, 264)
        Me.txtPlayer1.Name = "txtPlayer1"
        Me.txtPlayer1.Size = New System.Drawing.Size(280, 20)
        Me.txtPlayer1.TabIndex = 7
        Me.txtPlayer1.Text = "Enter Player Card first and then seep cards"
        '
        'txtPlayer2
        '
        Me.txtPlayer2.Enabled = False
        Me.txtPlayer2.Location = New System.Drawing.Point(328, 624)
        Me.txtPlayer2.Name = "txtPlayer2"
        Me.txtPlayer2.Size = New System.Drawing.Size(280, 20)
        Me.txtPlayer2.TabIndex = 11
        Me.txtPlayer2.Text = "Enter Player Card first and then seep cards"
        '
        'seepCard5
        '
        Me.seepCard5.Location = New System.Drawing.Point(632, 408)
        Me.seepCard5.Name = "seepCard5"
        Me.seepCard5.Size = New System.Drawing.Size(70, 100)
        Me.seepCard5.TabIndex = 44
        Me.seepCard5.TabStop = False
        '
        'seepCard6
        '
        Me.seepCard6.Location = New System.Drawing.Point(728, 408)
        Me.seepCard6.Name = "seepCard6"
        Me.seepCard6.Size = New System.Drawing.Size(70, 100)
        Me.seepCard6.TabIndex = 45
        Me.seepCard6.TabStop = False
        '
        'seepCard7
        '
        Me.seepCard7.Location = New System.Drawing.Point(832, 408)
        Me.seepCard7.Name = "seepCard7"
        Me.seepCard7.Size = New System.Drawing.Size(70, 100)
        Me.seepCard7.TabIndex = 46
        Me.seepCard7.TabStop = False
        '
        'seepCard8
        '
        Me.seepCard8.Location = New System.Drawing.Point(928, 408)
        Me.seepCard8.Name = "seepCard8"
        Me.seepCard8.Size = New System.Drawing.Size(70, 100)
        Me.seepCard8.TabIndex = 47
        Me.seepCard8.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(200, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Enter CMD (Player 1)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(200, 624)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 23)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Enter CMD (Player 2)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(752, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(416, 24)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Direction for Command Box Use: (PC and CP working)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(712, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(504, 24)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "1:"" Player Card Type ""+"" Seep Card Type"" + more seep card types ""+"" in middle ---" &
    "> Pick Cards"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(712, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(488, 48)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Card Type = suit + face value For example for King of Spade card type =  s13, for" &
    " Queen of hearts card type =  h12,  for jack of club card type = c11 and for Ace" &
    " of diamond card type = d1"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(712, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(560, 14)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "2: "" Player Card Type ""+"" Seep Card Type ""+"" more seep card types ""+"" in middle -" &
    "--> Create Pile"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(712, 244)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(560, 18)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "3: ""Player Card Type ""+""Seep Card Types"" ""+"" in middle and ""Seep Card in pile"" at" &
    " last  ---> Pick Pile"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(712, 284)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(560, 16)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "5: ""Player Card Type""  ---> Throw Card"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(64, 280)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 58
        Me.btnReset.Text = "RESET"
        '
        'lblSeepCard1
        '
        Me.lblSeepCard1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeepCard1.Location = New System.Drawing.Point(230, 520)
        Me.lblSeepCard1.Name = "lblSeepCard1"
        Me.lblSeepCard1.Size = New System.Drawing.Size(80, 23)
        Me.lblSeepCard1.TabIndex = 59
        '
        'lblSeepCard2
        '
        Me.lblSeepCard2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeepCard2.Location = New System.Drawing.Point(328, 520)
        Me.lblSeepCard2.Name = "lblSeepCard2"
        Me.lblSeepCard2.Size = New System.Drawing.Size(80, 23)
        Me.lblSeepCard2.TabIndex = 60
        '
        'lblSeepCard3
        '
        Me.lblSeepCard3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeepCard3.Location = New System.Drawing.Point(432, 520)
        Me.lblSeepCard3.Name = "lblSeepCard3"
        Me.lblSeepCard3.Size = New System.Drawing.Size(80, 23)
        Me.lblSeepCard3.TabIndex = 61
        '
        'lblSeepCard4
        '
        Me.lblSeepCard4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeepCard4.Location = New System.Drawing.Point(528, 520)
        Me.lblSeepCard4.Name = "lblSeepCard4"
        Me.lblSeepCard4.Size = New System.Drawing.Size(80, 23)
        Me.lblSeepCard4.TabIndex = 62
        '
        'lblSeepCard5
        '
        Me.lblSeepCard5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeepCard5.Location = New System.Drawing.Point(632, 520)
        Me.lblSeepCard5.Name = "lblSeepCard5"
        Me.lblSeepCard5.Size = New System.Drawing.Size(80, 23)
        Me.lblSeepCard5.TabIndex = 63
        '
        'lblSeepCard6
        '
        Me.lblSeepCard6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeepCard6.Location = New System.Drawing.Point(728, 520)
        Me.lblSeepCard6.Name = "lblSeepCard6"
        Me.lblSeepCard6.Size = New System.Drawing.Size(80, 23)
        Me.lblSeepCard6.TabIndex = 64
        '
        'lblSeepCard7
        '
        Me.lblSeepCard7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeepCard7.Location = New System.Drawing.Point(832, 520)
        Me.lblSeepCard7.Name = "lblSeepCard7"
        Me.lblSeepCard7.Size = New System.Drawing.Size(80, 23)
        Me.lblSeepCard7.TabIndex = 65
        '
        'lblSeepCard8
        '
        Me.lblSeepCard8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeepCard8.Location = New System.Drawing.Point(928, 520)
        Me.lblSeepCard8.Name = "lblSeepCard8"
        Me.lblSeepCard8.Size = New System.Drawing.Size(80, 23)
        Me.lblSeepCard8.TabIndex = 66
        '
        'lblSeepCard1Value
        '
        Me.lblSeepCard1Value.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeepCard1Value.Location = New System.Drawing.Point(230, 552)
        Me.lblSeepCard1Value.Name = "lblSeepCard1Value"
        Me.lblSeepCard1Value.Size = New System.Drawing.Size(80, 23)
        Me.lblSeepCard1Value.TabIndex = 67
        '
        'lblSeepCard2Value
        '
        Me.lblSeepCard2Value.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeepCard2Value.Location = New System.Drawing.Point(328, 552)
        Me.lblSeepCard2Value.Name = "lblSeepCard2Value"
        Me.lblSeepCard2Value.Size = New System.Drawing.Size(80, 23)
        Me.lblSeepCard2Value.TabIndex = 68
        '
        'lblSeepCard3Value
        '
        Me.lblSeepCard3Value.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeepCard3Value.Location = New System.Drawing.Point(432, 552)
        Me.lblSeepCard3Value.Name = "lblSeepCard3Value"
        Me.lblSeepCard3Value.Size = New System.Drawing.Size(80, 23)
        Me.lblSeepCard3Value.TabIndex = 69
        '
        'lblSeepCard4Value
        '
        Me.lblSeepCard4Value.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeepCard4Value.Location = New System.Drawing.Point(528, 552)
        Me.lblSeepCard4Value.Name = "lblSeepCard4Value"
        Me.lblSeepCard4Value.Size = New System.Drawing.Size(80, 23)
        Me.lblSeepCard4Value.TabIndex = 70
        '
        'lblSeepCard5Value
        '
        Me.lblSeepCard5Value.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeepCard5Value.Location = New System.Drawing.Point(632, 552)
        Me.lblSeepCard5Value.Name = "lblSeepCard5Value"
        Me.lblSeepCard5Value.Size = New System.Drawing.Size(80, 23)
        Me.lblSeepCard5Value.TabIndex = 71
        '
        'lblSeepCard6Value
        '
        Me.lblSeepCard6Value.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeepCard6Value.Location = New System.Drawing.Point(728, 552)
        Me.lblSeepCard6Value.Name = "lblSeepCard6Value"
        Me.lblSeepCard6Value.Size = New System.Drawing.Size(80, 23)
        Me.lblSeepCard6Value.TabIndex = 72
        '
        'lblSeepCard7Value
        '
        Me.lblSeepCard7Value.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeepCard7Value.Location = New System.Drawing.Point(832, 552)
        Me.lblSeepCard7Value.Name = "lblSeepCard7Value"
        Me.lblSeepCard7Value.Size = New System.Drawing.Size(80, 23)
        Me.lblSeepCard7Value.TabIndex = 73
        '
        'lblSeepCard8Value
        '
        Me.lblSeepCard8Value.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeepCard8Value.Location = New System.Drawing.Point(928, 552)
        Me.lblSeepCard8Value.Name = "lblSeepCard8Value"
        Me.lblSeepCard8Value.Size = New System.Drawing.Size(80, 23)
        Me.lblSeepCard8Value.TabIndex = 74
        '
        'btnPickCard1
        '
        Me.btnPickCard1.Enabled = False
        Me.btnPickCard1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPickCard1.Location = New System.Drawing.Point(248, 288)
        Me.btnPickCard1.Name = "btnPickCard1"
        Me.btnPickCard1.Size = New System.Drawing.Size(88, 23)
        Me.btnPickCard1.TabIndex = 8
        Me.btnPickCard1.Text = "1: Pick Cards"
        '
        'btnCreatePile1
        '
        Me.btnCreatePile1.Enabled = False
        Me.btnCreatePile1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreatePile1.Location = New System.Drawing.Point(336, 288)
        Me.btnCreatePile1.Name = "btnCreatePile1"
        Me.btnCreatePile1.Size = New System.Drawing.Size(96, 23)
        Me.btnCreatePile1.TabIndex = 9
        Me.btnCreatePile1.Text = "2: Create Pile"
        '
        'btnPickPile1
        '
        Me.btnPickPile1.Enabled = False
        Me.btnPickPile1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPickPile1.Location = New System.Drawing.Point(432, 288)
        Me.btnPickPile1.Name = "btnPickPile1"
        Me.btnPickPile1.Size = New System.Drawing.Size(80, 23)
        Me.btnPickPile1.TabIndex = 10
        Me.btnPickPile1.Text = "3: Pick Pile"
        '
        'btnAddPile1
        '
        Me.btnAddPile1.Enabled = False
        Me.btnAddPile1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPile1.Location = New System.Drawing.Point(512, 288)
        Me.btnAddPile1.Name = "btnAddPile1"
        Me.btnAddPile1.Size = New System.Drawing.Size(80, 23)
        Me.btnAddPile1.TabIndex = 77
        Me.btnAddPile1.Text = "4: Add Pile"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(712, 264)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(560, 16)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "4: ""Player Card Type"" + ""Seep Card Types"" ""+"" in middle and ""Seep Card in pile"" a" &
    "t last  ---> Add Pile"
        '
        'btnThrowCard1
        '
        Me.btnThrowCard1.Enabled = False
        Me.btnThrowCard1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThrowCard1.Location = New System.Drawing.Point(592, 288)
        Me.btnThrowCard1.Name = "btnThrowCard1"
        Me.btnThrowCard1.Size = New System.Drawing.Size(104, 23)
        Me.btnThrowCard1.TabIndex = 80
        Me.btnThrowCard1.Text = "5: Throw Card"
        '
        'btnThrowCard2
        '
        Me.btnThrowCard2.Enabled = False
        Me.btnThrowCard2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThrowCard2.Location = New System.Drawing.Point(592, 648)
        Me.btnThrowCard2.Name = "btnThrowCard2"
        Me.btnThrowCard2.Size = New System.Drawing.Size(104, 23)
        Me.btnThrowCard2.TabIndex = 85
        Me.btnThrowCard2.Text = "5: Throw Card"
        '
        'btnPickCard2
        '
        Me.btnPickCard2.Enabled = False
        Me.btnPickCard2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPickCard2.Location = New System.Drawing.Point(248, 648)
        Me.btnPickCard2.Name = "btnPickCard2"
        Me.btnPickCard2.Size = New System.Drawing.Size(88, 23)
        Me.btnPickCard2.TabIndex = 81
        Me.btnPickCard2.Text = "1: Pick Cards"
        '
        'btnCreatePile2
        '
        Me.btnCreatePile2.Enabled = False
        Me.btnCreatePile2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreatePile2.Location = New System.Drawing.Point(336, 648)
        Me.btnCreatePile2.Name = "btnCreatePile2"
        Me.btnCreatePile2.Size = New System.Drawing.Size(96, 23)
        Me.btnCreatePile2.TabIndex = 82
        Me.btnCreatePile2.Text = "2: Create Pile"
        '
        'btnPickPile2
        '
        Me.btnPickPile2.Enabled = False
        Me.btnPickPile2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPickPile2.Location = New System.Drawing.Point(432, 648)
        Me.btnPickPile2.Name = "btnPickPile2"
        Me.btnPickPile2.Size = New System.Drawing.Size(80, 23)
        Me.btnPickPile2.TabIndex = 83
        Me.btnPickPile2.Text = "3: Pick Pile"
        '
        'btnAddPile2
        '
        Me.btnAddPile2.Enabled = False
        Me.btnAddPile2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPile2.Location = New System.Drawing.Point(512, 648)
        Me.btnAddPile2.Name = "btnAddPile2"
        Me.btnAddPile2.Size = New System.Drawing.Size(80, 23)
        Me.btnAddPile2.TabIndex = 84
        Me.btnAddPile2.Text = "4: Add Pile"
        '
        'btnChangePile1
        '
        Me.btnChangePile1.Enabled = False
        Me.btnChangePile1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePile1.Location = New System.Drawing.Point(376, 312)
        Me.btnChangePile1.Name = "btnChangePile1"
        Me.btnChangePile1.Size = New System.Drawing.Size(96, 23)
        Me.btnChangePile1.TabIndex = 86
        Me.btnChangePile1.Text = "6: Change Pile"
        '
        'btnChangePile2
        '
        Me.btnChangePile2.Enabled = False
        Me.btnChangePile2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePile2.Location = New System.Drawing.Point(376, 672)
        Me.btnChangePile2.Name = "btnChangePile2"
        Me.btnChangePile2.Size = New System.Drawing.Size(96, 23)
        Me.btnChangePile2.TabIndex = 87
        Me.btnChangePile2.Text = "6: Change Pile"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(712, 302)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(560, 16)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "6: ""Player Card Type""  + ""Seep Card Type"" --->  Change Pile"
        '
        'btnSeepPoints1
        '
        Me.btnSeepPoints1.Enabled = False
        Me.btnSeepPoints1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeepPoints1.Location = New System.Drawing.Point(472, 312)
        Me.btnSeepPoints1.Name = "btnSeepPoints1"
        Me.btnSeepPoints1.Size = New System.Drawing.Size(96, 23)
        Me.btnSeepPoints1.TabIndex = 89
        Me.btnSeepPoints1.Text = "7: Seep Points"
        '
        'btnSeepPoints2
        '
        Me.btnSeepPoints2.Enabled = False
        Me.btnSeepPoints2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeepPoints2.Location = New System.Drawing.Point(472, 672)
        Me.btnSeepPoints2.Name = "btnSeepPoints2"
        Me.btnSeepPoints2.Size = New System.Drawing.Size(96, 23)
        Me.btnSeepPoints2.TabIndex = 90
        Me.btnSeepPoints2.Text = "7: Seep Points"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(712, 322)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(560, 16)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = "7: ""Player Card Type""  --->  Seep Points"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPlayer1Seep)
        Me.GroupBox1.Location = New System.Drawing.Point(1128, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 48)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Player 1 Seeps"
        '
        'lblPlayer1Seep
        '
        Me.lblPlayer1Seep.Location = New System.Drawing.Point(64, 16)
        Me.lblPlayer1Seep.Name = "lblPlayer1Seep"
        Me.lblPlayer1Seep.Size = New System.Drawing.Size(80, 24)
        Me.lblPlayer1Seep.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblPlayer2Seep)
        Me.GroupBox2.Location = New System.Drawing.Point(1128, 776)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 48)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Player 2 Seeps"
        '
        'lblPlayer2Seep
        '
        Me.lblPlayer2Seep.Location = New System.Drawing.Point(64, 16)
        Me.lblPlayer2Seep.Name = "lblPlayer2Seep"
        Me.lblPlayer2Seep.Size = New System.Drawing.Size(80, 24)
        Me.lblPlayer2Seep.TabIndex = 8
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblPlayer1SeriesScore)
        Me.GroupBox4.Location = New System.Drawing.Point(1128, 120)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(152, 48)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Player 1 Series Score"
        '
        'lblPlayer1SeriesScore
        '
        Me.lblPlayer1SeriesScore.Location = New System.Drawing.Point(64, 16)
        Me.lblPlayer1SeriesScore.Name = "lblPlayer1SeriesScore"
        Me.lblPlayer1SeriesScore.Size = New System.Drawing.Size(80, 24)
        Me.lblPlayer1SeriesScore.TabIndex = 7
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblPlayer2SeriesScore)
        Me.GroupBox6.Location = New System.Drawing.Point(1128, 832)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(152, 48)
        Me.GroupBox6.TabIndex = 21
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Player 2 Series Score"
        '
        'lblPlayer2SeriesScore
        '
        Me.lblPlayer2SeriesScore.Location = New System.Drawing.Point(64, 16)
        Me.lblPlayer2SeriesScore.Name = "lblPlayer2SeriesScore"
        Me.lblPlayer2SeriesScore.Size = New System.Drawing.Size(80, 24)
        Me.lblPlayer2SeriesScore.TabIndex = 8
        '
        'frmSeep
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 938)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnSeepPoints2)
        Me.Controls.Add(Me.btnSeepPoints1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnChangePile2)
        Me.Controls.Add(Me.btnChangePile1)
        Me.Controls.Add(Me.btnThrowCard2)
        Me.Controls.Add(Me.btnPickCard2)
        Me.Controls.Add(Me.btnCreatePile2)
        Me.Controls.Add(Me.btnPickPile2)
        Me.Controls.Add(Me.btnAddPile2)
        Me.Controls.Add(Me.btnThrowCard1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblSeepCard8Value)
        Me.Controls.Add(Me.lblSeepCard7Value)
        Me.Controls.Add(Me.lblSeepCard6Value)
        Me.Controls.Add(Me.lblSeepCard5Value)
        Me.Controls.Add(Me.lblSeepCard4Value)
        Me.Controls.Add(Me.lblSeepCard3Value)
        Me.Controls.Add(Me.lblSeepCard2Value)
        Me.Controls.Add(Me.lblSeepCard1Value)
        Me.Controls.Add(Me.lblSeepCard8)
        Me.Controls.Add(Me.lblSeepCard7)
        Me.Controls.Add(Me.lblSeepCard6)
        Me.Controls.Add(Me.lblSeepCard5)
        Me.Controls.Add(Me.lblSeepCard4)
        Me.Controls.Add(Me.lblSeepCard3)
        Me.Controls.Add(Me.lblSeepCard2)
        Me.Controls.Add(Me.lblSeepCard1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.seepCard8)
        Me.Controls.Add(Me.seepCard7)
        Me.Controls.Add(Me.seepCard6)
        Me.Controls.Add(Me.seepCard5)
        Me.Controls.Add(Me.txtPlayer2)
        Me.Controls.Add(Me.txtPlayer1)
        Me.Controls.Add(Me.Player2Card8)
        Me.Controls.Add(Me.Player2Card7)
        Me.Controls.Add(Me.Player2Card6)
        Me.Controls.Add(Me.Player2Card5)
        Me.Controls.Add(Me.player2Card4)
        Me.Controls.Add(Me.player2card3)
        Me.Controls.Add(Me.player2Card2)
        Me.Controls.Add(Me.Player2Card1)
        Me.Controls.Add(Me.Player1Card8)
        Me.Controls.Add(Me.Player1Card7)
        Me.Controls.Add(Me.Player1Card6)
        Me.Controls.Add(Me.Player1Card5)
        Me.Controls.Add(Me.player1Card4)
        Me.Controls.Add(Me.player1Card3)
        Me.Controls.Add(Me.player1card2)
        Me.Controls.Add(Me.player1Card1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.seepCard1)
        Me.Controls.Add(Me.seepCard4)
        Me.Controls.Add(Me.seepCard3)
        Me.Controls.Add(Me.seepCard2)
        Me.Controls.Add(Me.btn13)
        Me.Controls.Add(Me.deck)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnDeal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn10)
        Me.Controls.Add(Me.btn11)
        Me.Controls.Add(Me.btn12)
        Me.Controls.Add(Me.btnPickCard1)
        Me.Controls.Add(Me.btnCreatePile1)
        Me.Controls.Add(Me.btnPickPile1)
        Me.Controls.Add(Me.btnAddPile1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox6)
        Me.Name = "frmSeep"
        Me.Text = "Two Player Seep"
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.deck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Player1Card8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1Card7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1Card6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1Card5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player1Card4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player1Card3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player1card2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player1Card1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2Card8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2Card7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2Card6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2Card5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player2Card4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player2card3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player2Card2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2Card1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seepCard4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seepCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seepCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seepCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seepCard5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seepCard6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seepCard7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seepCard8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
