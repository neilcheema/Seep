Public Class frmSeep

#Region "Variables and Structures"
    Private validationFailed As Boolean
    Private lastPlayerPicking As Integer
    Private player1Clicking As Boolean
    Private player1Seep, player2Seep As Integer
    Private player1Moves, player2Moves As Integer
    Private firstCallNumber As String
    Private firstCallNumberSelected As Boolean
    Private firstMoveDone As Boolean
    Private playerMove As Integer
    Private player1Score, player2Score As Integer
    Private player1SeriesScore, player2SeriesScore As Integer
    Public myDeck As clsCardDeck
    Public myHands As clsHand
    Public seepHands As clsHand
    Public yourHands As clsHand
    Public piles(8) As clsHand
    Public myCollect As clsHand
    Public yourCollect As clsHand
    Public player1Cards As PictureBox.ControlCollection
    Public seepCards As PictureBox.ControlCollection
    Public player2Cards As PictureBox.ControlCollection
#End Region ' Variables and Structures

#Region "Event Handlers"
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click


        btnStart.Enabled = False

        FlipFirstHand()



        If Not cardOver9() Then
            btnStart.Enabled = True
            reset()
            btnStart.Focus()
        End If
    End Sub
    'Private Sub frmTwoPlayerSeep_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
    '    Dim rm As New Resources.ResourceManager("twoPlayerSeep.images", System.Reflection.Assembly.GetExecutingAssembly)
    '    myDeck = New clsCardDeck


    '    myDeck.Shuffle()

    '    deck.Image = rm.GetObject("b1fv.gif")
    '    deck.Text = ReturnOrientationText(common.Orientation.NotFlipped)

    'End Sub

    Private Sub seepCard1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seepCard1.Click
        If sender.text.tolower <> "" Then
            If player1Clicking Then
                txtPlayer1.Text = txtPlayer1.Text + " + " + sender.text.tolower
            Else
                txtPlayer2.Text = txtPlayer2.Text + " + " + sender.text.tolower
            End If
        End If
        If firstCallNumberSelected = True Then
            flipSeepCards()
            firstCallNumberSelected = False
        End If


    End Sub
    Private Sub seepCard2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seepCard2.Click
        If sender.text.tolower <> "" Then
            If player1Clicking Then
                txtPlayer1.Text = txtPlayer1.Text + " + " + sender.text.tolower
            Else
                txtPlayer2.Text = txtPlayer2.Text + " + " + sender.text.tolower
            End If
        End If
        If firstCallNumberSelected = True Then
            flipSeepCards()
            firstCallNumberSelected = False
        End If


    End Sub
    Private Sub seepCard3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seepCard3.Click
        If sender.text.tolower <> "" Then
            If player1Clicking Then
                txtPlayer1.Text = txtPlayer1.Text + " + " + sender.text.tolower
            Else
                txtPlayer2.Text = txtPlayer2.Text + " + " + sender.text.tolower
            End If
        End If
        If firstCallNumberSelected = True Then
            flipSeepCards()
            firstCallNumberSelected = False
        End If


    End Sub
    Private Sub seepCard4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seepCard4.Click
        If sender.text.tolower <> "" Then
            If player1Clicking Then
                txtPlayer1.Text = txtPlayer1.Text + " + " + sender.text.tolower
            Else
                txtPlayer2.Text = txtPlayer2.Text + " + " + sender.text.tolower
            End If
        End If
        If firstCallNumberSelected = True Then
            flipSeepCards()
            firstCallNumberSelected = False
        End If


    End Sub
    Private Sub seepCard5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seepCard5.Click
        If sender.text.tolower <> "" Then
            If player1Clicking Then
                txtPlayer1.Text = txtPlayer1.Text + " + " + sender.text.tolower
            Else
                txtPlayer2.Text = txtPlayer2.Text + " + " + sender.text.tolower
            End If
        End If
    End Sub
    Private Sub seepCard6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seepCard6.Click
        If sender.text.tolower <> "" Then
            If player1Clicking Then
                txtPlayer1.Text = txtPlayer1.Text + " + " + sender.text.tolower
            Else
                txtPlayer2.Text = txtPlayer2.Text + " + " + sender.text.tolower
            End If
        End If
    End Sub
    Private Sub seepCard7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seepCard7.Click
        If sender.text.tolower <> "" Then
            If player1Clicking Then
                txtPlayer1.Text = txtPlayer1.Text + " + " + sender.text.tolower
            Else
                txtPlayer2.Text = txtPlayer2.Text + " + " + sender.text.tolower
            End If
        End If
    End Sub
    Private Sub seepCard8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seepCard8.Click
        If sender.text.tolower <> "" Then
            If player1Clicking Then
                txtPlayer1.Text = txtPlayer1.Text + " + " + sender.text.tolower
            Else
                txtPlayer2.Text = txtPlayer2.Text + " + " + sender.text.tolower
            End If
        End If
    End Sub
    Private Sub AnyPlayer1CardClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        player1Clicking = True
        txtPlayer1.Text = sender.text.tolower
    End Sub
    Private Sub AnyPlayer2CardClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        player1Clicking = False
        txtPlayer2.Text = sender.text.tolower
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        firstCallNumberSelected = True
        firstCallNumber = 9
        DisableEnableButtons()
        Enable1Player()
    End Sub

    Private Sub btn10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn10.Click
        firstCallNumberSelected = True
        firstCallNumber = 10
        DisableEnableButtons()
        Enable1Player()
    End Sub

    Private Sub btn11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn11.Click
        firstCallNumberSelected = True
        firstCallNumber = 11
        DisableEnableButtons()
        Enable1Player()
    End Sub

    Private Sub btn12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn12.Click
        firstCallNumberSelected = True
        firstCallNumber = 12
        DisableEnableButtons()
        Enable1Player()
    End Sub

    Private Sub btn13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn13.Click
        firstCallNumberSelected = True
        firstCallNumber = 13
        DisableEnableButtons()
        Enable1Player()
    End Sub


    Private Sub frmSeep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        reset()

        player1Cards = New PictureBox.ControlCollection(sender)
        player1Cards.Add(Me.player1Card1)
        player1Cards.Add(Me.player1card2)
        player1Cards.Add(Me.player1Card3)
        player1Cards.Add(Me.player1Card4)
        player1Cards.Add(Me.Player1Card5)
        player1Cards.Add(Me.Player1Card6)
        player1Cards.Add(Me.Player1Card7)
        player1Cards.Add(Me.Player1Card8)

        player2Cards = New PictureBox.ControlCollection(sender)
        player2Cards.Add(Me.Player2Card1)
        player2Cards.Add(Me.player2Card2)
        player2Cards.Add(Me.player2card3)
        player2Cards.Add(Me.player2Card4)
        player2Cards.Add(Me.Player2Card5)
        player2Cards.Add(Me.Player2Card6)
        player2Cards.Add(Me.Player2Card7)
        player2Cards.Add(Me.Player2Card8)

        seepCards = New PictureBox.ControlCollection(sender)
        seepCards.Add(Me.seepCard1)
        seepCards.Add(Me.seepCard2)
        seepCards.Add(Me.seepCard3)
        seepCards.Add(Me.seepCard4)
        seepCards.Add(Me.seepCard5)
        seepCards.Add(Me.seepCard6)
        seepCards.Add(Me.seepCard7)
        seepCards.Add(Me.seepCard8)

        Me.seepCard1.Text = ReturnOrientationText(common.Orientation.NoCard)
        Me.seepCard2.Text = ReturnOrientationText(common.Orientation.NoCard)
        Me.seepCard3.Text = ReturnOrientationText(common.Orientation.NoCard)
        Me.seepCard4.Text = ReturnOrientationText(common.Orientation.NoCard)
        Me.seepCard5.Text = ReturnOrientationText(common.Orientation.NoCard)
        Me.seepCard6.Text = ReturnOrientationText(common.Orientation.NoCard)
        Me.seepCard7.Text = ReturnOrientationText(common.Orientation.NoCard)
        Me.seepCard8.Text = ReturnOrientationText(common.Orientation.NoCard)

        btnStart.Enabled = True




        AddHandler player1Card1.Click, AddressOf AnyPlayer1CardClick
        AddHandler player1card2.Click, AddressOf AnyPlayer1CardClick
        AddHandler player1Card3.Click, AddressOf AnyPlayer1CardClick
        AddHandler player1Card4.Click, AddressOf AnyPlayer1CardClick
        AddHandler Player1Card5.Click, AddressOf AnyPlayer1CardClick
        AddHandler Player1Card6.Click, AddressOf AnyPlayer1CardClick
        AddHandler Player1Card7.Click, AddressOf AnyPlayer1CardClick
        AddHandler Player1Card8.Click, AddressOf AnyPlayer1CardClick

        AddHandler Player2Card1.Click, AddressOf AnyPlayer2CardClick
        AddHandler player2Card2.Click, AddressOf AnyPlayer2CardClick
        AddHandler player2card3.Click, AddressOf AnyPlayer2CardClick
        AddHandler player2Card4.Click, AddressOf AnyPlayer2CardClick
        AddHandler Player2Card5.Click, AddressOf AnyPlayer2CardClick
        AddHandler Player2Card6.Click, AddressOf AnyPlayer2CardClick
        AddHandler Player2Card7.Click, AddressOf AnyPlayer2CardClick
        AddHandler Player2Card8.Click, AddressOf AnyPlayer2CardClick

        player1SeriesScore = 0
        player2SeriesScore = 0

    End Sub







    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        'This function is not working at the moment

        resetHandsAndPiles()

        reset()



    End Sub
#End Region        ' Event Handlers

#Region "Seep CMD Buttons Click Handlers"
    Private Sub btnPickCard1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPickCard1.Click


        Dim cmdString As String
        cmdString = txtPlayer1.Text
        Dim temp() As String
        temp = cmdString.Split("+"c)
        Dim result As Integer = pickCardValidates(temp, 1)
        If result = 1 Then
            isFirstMoveDone()
            PickCardPlayer1(temp)
            player1Moves = player1Moves + 1
            lastPlayerPicking = 1
            Enable2Player()
            RefreshHands()
        ElseIf result = 2 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 3 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 4 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strPickCardError1")
            strError = strError + CType(firstCallNumber, String)
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 5 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strPickCardError2")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub btnPickCard2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPickCard2.Click

        Dim cmdString As String
        cmdString = txtPlayer2.Text
        Dim temp() As String
        temp = cmdString.Split("+"c)
        Dim result As Integer = pickCardValidates(temp, 2)
        If result = 1 Then
            PickCardPlayer2(temp)
            player2Moves = player2Moves + 1
            lastPlayerPicking = 2
            Enable1Player()
            RefreshHands()
            If player2Moves = 8 OrElse player2Moves = 16 OrElse player2Moves = 24 Then ReDealCards()
        ElseIf result = 2 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 3 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 4 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strPickCardError1")
            strError = strError + CType(firstCallNumber, String)
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 5 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strPickCardError2")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnCreatePile1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreatePile1.Click


        Dim cmdString As String
        cmdString = txtPlayer1.Text
        Dim temp() As String
        temp = cmdString.Split("+"c)

        Dim result As Integer = pileCardValidates(temp, 1)
        If result = 1 Then
            isFirstMoveDone()
            PileCardPlayer1(temp)
            player1Moves = player1Moves + 1
            Enable2Player()
            RefreshHands()
        ElseIf result = 2 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 3 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 4 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strPileCardError1")
            strError = strError + CType(firstCallNumber, String)
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 5 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strPileCardError2")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 6 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strPileCardError3")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 6 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strPileCardError4")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCreatePile2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreatePile2.Click
        Dim cmdString As String
        cmdString = txtPlayer2.Text
        Dim temp() As String
        temp = cmdString.Split("+"c)
        Dim result As Integer = pileCardValidates(temp, 2)
        If result = 1 Then
            PileCardPlayer2(temp)
            player2Moves = player2Moves + 1
            Enable1Player()
            RefreshHands()
            If player2Moves = 8 OrElse player2Moves = 16 OrElse player2Moves = 24 Then ReDealCards()
        ElseIf result = 2 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 3 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 4 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strPileCardError1")
            strError = strError + CType(firstCallNumber, String)
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 5 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strPileCardError2")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 6 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strPileCardError3")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 6 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strPileCardError4")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnPickPile1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPickPile1.Click

        Dim cmdString As String
        cmdString = txtPlayer1.Text
        Dim temp() As String
        temp = cmdString.Split("+"c)
        Dim result As Integer = pickPileValidates(temp, 1)
        If result = 1 Then
            PickPilePlayer1(temp)
            player1Moves = player1Moves + 1
            lastPlayerPicking = 1
            Enable2Player()
            RefreshHands()
        ElseIf result = 2 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 3 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 4 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strInvalidError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 5 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strPickPileError1")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 6 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strPickPileError2")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnPickPile2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPickPile2.Click

        Dim cmdString As String
        cmdString = txtPlayer2.Text
        Dim temp() As String
        temp = cmdString.Split("+"c)
        Dim result As Integer = pickPileValidates(temp, 2)
        If result = 1 Then
            PickPilePlayer2(temp)
            player2Moves = player2Moves + 1
            lastPlayerPicking = 2
            Enable1Player()
            RefreshHands()
            If player2Moves = 8 OrElse player2Moves = 16 OrElse player2Moves = 24 Then ReDealCards()
        ElseIf result = 2 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 3 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 4 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strInvalidError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 5 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strPickPileError1")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 6 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strPickPileError2")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnThrowCard1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThrowCard1.Click

        Dim cmdString As String
        cmdString = txtPlayer1.Text

        Dim result As Integer = throwCardValidates(cmdString, 1)

        If result = 1 Then
            isFirstMoveDone()
            ThrowCard(cmdString.TrimEnd.TrimStart, 1)
            player1Moves = player1Moves + 1
            Enable2Player()
            RefreshHands()
        ElseIf result = 2 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf result = 3 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 4 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strThrowCardError1")
            strError = strError + CType(firstCallNumber, String)
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnThrowCard2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThrowCard2.Click
        Dim cmdString As String
        cmdString = txtPlayer2.Text

        Dim result As Integer = throwCardValidates(cmdString, 2)

        If result = 1 Then
            ThrowCard(cmdString.TrimEnd.TrimStart, 2)
            player2Moves = player2Moves + 1
            Enable1Player()
            RefreshHands()
            If player2Moves = 8 OrElse player2Moves = 16 OrElse player2Moves = 24 Then ReDealCards()
        ElseIf result = 2 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf result = 3 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 4 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strThrowCardError1")
            strError = strError + CType(firstCallNumber, String)
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnAddPile1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPile1.Click
        Dim cmdString As String
        cmdString = txtPlayer1.Text
        Dim temp() As String
        temp = cmdString.Split("+"c)
        Dim result As Integer = addPileValidates(temp, 1)
        If result = 1 Then
            AddPilePlayer1(temp)
            player1Moves = player1Moves + 1
            Enable2Player()
            RefreshHands()
        ElseIf result = 2 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf result = 3 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 4 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strInvalidError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 5 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strAddPileError1")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 6 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strAddPileError2")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 7 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strAddPileError3")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnAddPile2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPile2.Click
        Dim cmdString As String
        cmdString = txtPlayer2.Text
        Dim temp() As String
        temp = cmdString.Split("+"c)

        Dim result As Integer = addPileValidates(temp, 2)
        If result = 1 Then
            AddPilePlayer2(temp)
            player2Moves = player2Moves + 1
            Enable1Player()
            RefreshHands()
            If player2Moves = 8 OrElse player2Moves = 16 OrElse player2Moves = 24 Then ReDealCards()
        ElseIf result = 2 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf result = 3 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 4 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strInvalidError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 5 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strAddPileError1")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 6 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strAddPileError2")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 7 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strAddPileError3")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnChangePile1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangePile1.Click
        Dim cmdString As String
        cmdString = txtPlayer1.Text
        Dim temp() As String
        temp = cmdString.Split("+"c)
        Dim result As Integer = changePileValidates(temp, 1)
        If result = 1 Then
            ChangePile(temp, 1)
            player1Moves = player1Moves + 1
            Enable2Player()
            RefreshHands()
        ElseIf result = 2 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf result = 3 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 4 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strInvalidError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 5 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strChangePileError1")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 6 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strChangePileError2")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 7 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strChangePileError3")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 8 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strChangePileError4")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 9 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strChangePileError5")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnChangePile2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangePile2.Click
        Dim cmdString As String
        cmdString = txtPlayer2.Text
        Dim temp() As String
        temp = cmdString.Split("+"c)

        Dim result As Integer = changePileValidates(temp, 2)
        If result = 1 Then
            ChangePile(temp, 2)
            player2Moves = player2Moves + 1
            Enable1Player()
            RefreshHands()
            If player2Moves = 8 OrElse player2Moves = 16 OrElse player2Moves = 24 Then ReDealCards()
        ElseIf result = 2 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf result = 3 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 4 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strInvalidError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 5 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strChangePileError1")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 6 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strChangePileError2")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 7 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strChangePileError3")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 8 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strChangePileError4")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 9 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strChangePileError5")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnSeepPoints1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeepPoints1.Click
        Dim cmdString As String
        cmdString = txtPlayer1.Text
        Dim temp() As String
        temp = cmdString.Split("+"c)
        Dim result As Integer = seepPointValidates(temp, 1)
        If result = 1 Then
            SeepPoints(cmdString.TrimEnd.TrimStart, 1)
            player1Moves = player1Moves + 1
            Enable2Player()
            RefreshHands()
        ElseIf result = 2 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf result = 3 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 4 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strInvalidError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 5 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strSeepPointError1")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 6 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strSeepPointError2")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 7 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strSeepPointError3")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 8 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strSeepPointError4")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnSeepPoints2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeepPoints2.Click
        Dim cmdString As String
        cmdString = txtPlayer2.Text
        Dim temp() As String
        temp = cmdString.Split("+"c)

        Dim result As Integer = seepPointValidates(temp, 2)
        If result = 1 Then
            SeepPoints(cmdString.TrimEnd.TrimStart, 2)
            player2Moves = player2Moves + 1
            Enable1Player()
            RefreshHands()
        ElseIf result = 2 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf result = 3 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strNoCardError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 4 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strInvalidError")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 5 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strSeepPointError1")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 6 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strSeepPointError2")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 7 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strSeepPointError3")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf result = 8 Then
            Dim rm As New Resources.ResourceManager("twoPlayerSeep.errors", System.Reflection.Assembly.GetExecutingAssembly)
            Dim strError As String = rm.GetObject("strSeepPointError4")
            strError = strError
            MessageBox.Show(strError, "Two Player Seep", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
#End Region ' Seep CMD Buttons Click Handlers

#Region "Intial Seep Functions"
    Private Sub FlipFirstHand()
        Dim rm As New Resources.ResourceManager("twoPlayerSeep.images", System.Reflection.Assembly.GetExecutingAssembly)
        For player As Integer = 1 To 3
            If player = 1 Then
                myHands = myDeck.Deal(8, common.Player.one, True)
                'For i As Integer = myHands.Count - 1 To 0 Step -1
                '    myDeck.Remove(myHands.Item(i))
                'Next
            ElseIf player = 2 Then
                seepHands = myDeck.Deal(4, common.Player.Seep, False)
                'For i As Integer = seepHands.Count - 1 To 0 Step -1
                '    myDeck.Remove(seepHands.Item(i))
                'Next
            Else
                yourHands = myDeck.Deal(8, common.Player.Two, False)
                'For i As Integer = yourHands.Count - 1 To 0 Step -1
                '    myDeck.Remove(yourHands.Item(i))
                'Next
            End If

            For card As Integer = 1 To 4
                Dim fileName, cardType As String
                Select Case player

                    Case 1

                        cardType = ConvertSuit(myHands.Item(card - 1).Suit) + ConvertFace(myHands.Item(card - 1).Face)
                        'split the string will be in the format ("Suit.Face")
                        fileName = cardType + ".gif"
                        Dim tempImage As Image = rm.GetObject(fileName)
                        Select Case card
                            Case 1
                                player1Card1.Image = tempImage
                                player1Card1.Text = cardType.ToUpper
                            Case 2
                                player1card2.Image = tempImage
                                player1card2.Text = cardType.ToUpper
                            Case 3
                                player1Card3.Image = tempImage
                                player1Card3.Text = cardType.ToUpper
                            Case 4
                                player1Card4.Image = tempImage
                                player1Card4.Text = cardType.ToUpper
                            Case 5
                                Player1Card5.Image = rm.GetObject("b1fv.gif")

                            Case 6
                                Player1Card6.Image = rm.GetObject("b1fv.gif")

                            Case 7
                                Player1Card7.Image = rm.GetObject("b1fv.gif")

                            Case 8
                                Player1Card8.Image = rm.GetObject("b1fv.gif")

                        End Select

                    Case 2

                        Select Case card
                            Case 1
                                seepCard1.Image = rm.GetObject("b1fv.gif")

                            Case 2
                                seepCard2.Image = rm.GetObject("b1fv.gif")

                            Case 3
                                seepCard3.Image = rm.GetObject("b1fv.gif")

                            Case 4
                                seepCard4.Image = rm.GetObject("b1fv.gif")

                        End Select

                    Case 3
                        cardType = ConvertSuit(yourHands.Item(card - 1).Suit) + ConvertFace(yourHands.Item(card - 1).Face)
                        'split the string will be in the format ("Suit.Face")
                        fileName = cardType + ".gif"
                        Dim tempImage As Image = rm.GetObject(fileName)
                        Select Case card
                            Case 1
                                'Player2Card1.Image = tempImage
                                rm.GetObject("b1fv.gif")
                                Player2Card1.Text = cardType.ToUpper
                            Case 2
                                'player2Card2.Image = tempImage
                                rm.GetObject("b1fv.gif")
                                player2Card2.Text = cardType.ToUpper
                            Case 3
                                'player2card3.Image = tempImage
                                rm.GetObject("b1fv.gif")
                                player2card3.Text = cardType.ToUpper
                            Case 4
                                'player2Card4.Image = tempImage
                                rm.GetObject("b1fv.gif")
                                player2Card4.Text = cardType.ToUpper
                            Case 5
                                Player2Card5.Image = rm.GetObject("b1fv.gif")

                            Case 6
                                Player2Card6.Image = rm.GetObject("b1fv.gif")

                            Case 7
                                Player2Card7.Image = rm.GetObject("b1fv.gif")

                            Case 8
                                Player2Card8.Image = rm.GetObject("b1fv.gif")

                        End Select

                End Select
            Next
        Next
    End Sub
    Private Sub FlipOtherHands()
        Dim rm As New Resources.ResourceManager("twoPlayerSeep.images", System.Reflection.Assembly.GetExecutingAssembly)
        For player As Integer = 1 To 2
            For card As Integer = 5 To 8
                Dim fileName, cardType As String
                Select Case player

                    Case 1
                        cardType = ConvertSuit(myHands.Item(card - 1).Suit) + ConvertFace(myHands.Item(card - 1).Face)
                        'split the string will be in the format ("Suit.Face")
                        fileName = cardType + ".gif"
                        Dim tempImage As Image = rm.GetObject(fileName)
                        Select Case card
                            Case 5
                                Player1Card5.Image = tempImage
                                Player1Card5.Text = cardType.ToUpper
                            Case 6
                                Player1Card6.Image = tempImage
                                Player1Card6.Text = cardType.ToUpper
                            Case 7
                                Player1Card7.Image = tempImage
                                Player1Card7.Text = cardType.ToUpper
                            Case 8
                                Player1Card8.Image = tempImage
                                Player1Card8.Text = cardType.ToUpper
                        End Select

                    Case 2
                        cardType = ConvertSuit(yourHands.Item(card - 1).Suit) + ConvertFace(yourHands.Item(card - 1).Face)
                        'split the string will be in the format ("Suit.Face")
                        fileName = cardType + ".gif"
                        Dim tempImage As Image = rm.GetObject(fileName)
                        Select Case card
                            Case 5
                                Player2Card5.Image = tempImage
                                Player2Card5.Text = cardType.ToUpper
                            Case 6
                                Player2Card6.Image = tempImage
                                Player2Card6.Text = cardType.ToUpper
                            Case 7
                                Player2Card7.Image = tempImage
                                Player2Card7.Text = cardType.ToUpper
                            Case 8
                                Player2Card8.Image = tempImage
                                Player2Card8.Text = cardType.ToUpper
                        End Select

                End Select
            Next
        Next
    End Sub
    Private Sub flipSeepCards()
        Dim rm As New Resources.ResourceManager("twoPlayerSeep.images", System.Reflection.Assembly.GetExecutingAssembly)
        Dim cardType As String = ConvertSuit(seepHands.Item(0).Suit) + ConvertFace(seepHands.Item(0).Face)
        Dim fileName As String = cardType + ".gif"
        seepCard1.Image = rm.GetObject(fileName)
        seepCard1.Text = cardType.ToUpper

        cardType = ConvertSuit(seepHands.Item(1).Suit) + ConvertFace(seepHands.Item(1).Face)
        fileName = cardType + ".gif"
        seepCard2.Image = rm.GetObject(fileName)
        seepCard2.Text = cardType.ToUpper

        cardType = ConvertSuit(seepHands.Item(2).Suit) + ConvertFace(seepHands.Item(2).Face)
        fileName = cardType + ".gif"
        seepCard3.Image = rm.GetObject(fileName)
        seepCard3.Text = cardType.ToUpper

        cardType = ConvertSuit(seepHands.Item(3).Suit) + ConvertFace(seepHands.Item(3).Face)
        fileName = cardType + ".gif"
        seepCard4.Image = rm.GetObject(fileName)
        seepCard4.Text = cardType.ToUpper
    End Sub
    Private Sub ReDealCards()
        Dim rm As New Resources.ResourceManager("twoPlayerSeep.images", System.Reflection.Assembly.GetExecutingAssembly)

        If player2Moves >= 24 Then
            player1Score = ReturnMyCollectPoints()
            player2Score = ReturnYourCollectPoints()
            If lastPlayerPicking = 1 Then
                player1Score = player1Score + ReturnSeepPoints()
            Else
                player2Score = player2Score + ReturnSeepPoints()
            End If
            If player1Score >= player2Score Then
                player1Score = (50 - player2Score) * 2
                player2Score = 0
            Else
                player2Score = (50 - player1Score) * 2
                player1Score = 0
            End If
            player1Score = player1Score + player1Seep * 50
            player2Score = player2Score + player2Seep * 50
            If player1Score >= player2Score Then
                player1Score = player1Score - player2Score
                player2Score = 0
            Else
                player2Score = player2Score - player1Score
                player1Score = 0
            End If
            player1SeriesScore = player1SeriesScore + player1Score
            player2SeriesScore = player2SeriesScore + player2Score
            player1Score = 0
            player2Score = 0
            If player1SeriesScore >= player2SeriesScore Then
                player1SeriesScore = player1SeriesScore - player2SeriesScore
                player2SeriesScore = 0
            Else
                player2SeriesScore = player2SeriesScore - player1SeriesScore
                player1SeriesScore = 0
            End If
            Me.lblPlayer1SeriesScore.Text = player1SeriesScore
            Me.lblPlayer2SeriesScore.Text = player2SeriesScore
            Me.lblPlayer1Score.Text = player1Score
            Me.lblPlayer2Score.Text = player2Score
            btnStart.Enabled = True
            EnableDisableButtons()
            If player1SeriesScore >= 101 Then
                MessageBox.Show("Game Over! Player 1 the winner", "Two Player Seep Game", MessageBoxButtons.OK)
                btnStart.Enabled = False
                DisableEnableButtons()
                resetHandsAndPiles()
                reset()
                Exit Sub
            End If
            If player2SeriesScore >= 101 Then
                MessageBox.Show("Game Over! Player 2 the winner", "Two Player Seep Game", MessageBoxButtons.OK)
                btnStart.Enabled = False
                DisableEnableButtons()
                resetHandsAndPiles()
                reset()
                Exit Sub
            End If
            resetHandsAndPiles()
            reset()
            FlipFirstHand()
            Exit Sub
        End If

        For player As Integer = 1 To 2
            If player = 1 Then
                myHands = myDeck.Deal(8, common.Player.one, True)
            Else
                yourHands = myDeck.Deal(8, common.Player.Two, False)
            End If


        Next
        RefreshHands()
    End Sub

    Private Sub AddNewSeepCard(ByVal cardNumber As String)
        Dim newSeepCard As New Windows.Forms.PictureBox
        newSeepCard = Me.seepCard1
        newSeepCard.Name = "seepCard" + cardNumber
        seepCards.Add(newSeepCard)
    End Sub

#End Region     ' Intial Seep Functions

#Region "Seep Command Functions"

    Private Sub PickCardPlayer1(ByRef temp() As String)
        Dim seepHandIndex(7), myHandIndex, count As Integer
        Dim length As Integer
        Dim playerCard As String
        Dim seepCard As String
        count = 0
        For Each cardInPile As String In temp
            If playerCard Is Nothing Then
                playerCard = cardInPile
                length = myHands.Count
                For i As Integer = 0 To length - 1 Step 1
                    'If myHands.Item(i).Flipped = True Then
                    Dim cardType As String = ConvertSuit(myHands.Item(i).Suit) + ConvertFace(myHands.Item(i).Face)
                    If cardType = playerCard.TrimStart.TrimEnd Then
                        ResetPlayer1Cards(i)
                        If firstMoveDone Then
                            player1Score = player1Score + ConvertScore(myHands.Item(i).Face, myHands.Item(i).Suit)
                            lblPlayer1Score.Text = player1Score
                        End If
                        myHandIndex = i
                        Exit For
                    End If
                    'End If
                Next i
            Else
                seepCard = cardInPile
                length = seepHands.Count
                For i As Integer = 0 To length - 1 Step 1
                    Dim cardType = ConvertSuit(seepHands.Item(i).Suit) + ConvertFace(seepHands.Item(i).Face)
                    If cardType = seepCard.TrimStart.TrimEnd Then
                        ResetSeepCards(i)
                        If firstMoveDone Then
                            player1Score = player1Score + ConvertScore(seepHands.Item(i).Face, seepHands.Item(i).Suit)
                            lblPlayer1Score.Text = player1Score
                        End If
                        seepHandIndex(count) = i + 1
                        count = count + 1
                        Exit For
                    End If
                Next i
            End If
        Next cardInPile
        If myCollect Is Nothing Then myCollect = New clsHand
        seepHandIndex.Sort(seepHandIndex)
        Dim c As Integer = 0
        For Each i As Integer In seepHandIndex
            If i <> 0 Then
                myCollect.Insert(myCollect.Count, seepHands.Item(i - (c + 1)))
                seepHands.Remove(seepHands.Item(i - (c + 1)))
                c = c + 1
            End If
        Next i

        myCollect.Insert(myCollect.Count, myHands.Item(myHandIndex))
        myHands.Remove(myHands.Item(myHandIndex))
    End Sub

    Private Sub PickCardPlayer2(ByRef temp() As String)
        Dim seepHandIndex(7), yourHandIndex, count As Integer
        Dim length As Integer
        Dim playerCard As String
        Dim seepCard As String
        count = 0
        For Each cardInPile As String In temp
            If playerCard Is Nothing Then
                playerCard = cardInPile
                length = yourHands.Count
                For i As Integer = 0 To length - 1 Step 1
                    'If myHands.Item(i).Flipped = True Then
                    Dim cardType = ConvertSuit(yourHands.Item(i).Suit) + ConvertFace(yourHands.Item(i).Face)
                    If cardType = playerCard.TrimStart.TrimEnd Then
                        ResetPlayer2Cards(i)
                        If firstMoveDone Then
                            player2Score = player2Score + ConvertScore(yourHands.Item(i).Face, yourHands.Item(i).Suit)
                            lblPlayer2Score.Text = player2Score
                        End If
                        yourHandIndex = i
                        Exit For
                    End If
                    'End If
                Next i
            Else
                seepCard = cardInPile
                length = seepHands.Count
                For i As Integer = 0 To length - 1 Step 1
                    Dim cardType = ConvertSuit(seepHands.Item(i).Suit) + ConvertFace(seepHands.Item(i).Face)
                    If cardType = seepCard.TrimStart.TrimEnd Then
                        ResetSeepCards(i)
                        If firstMoveDone Then
                            player2Score = player2Score + ConvertScore(seepHands.Item(i).Face, seepHands.Item(i).Suit)
                            lblPlayer2Score.Text = player2Score
                        End If
                        seepHandIndex(count) = i + 1
                        count = count + 1
                        Exit For
                    End If
                Next i
            End If
        Next cardInPile
        If yourCollect Is Nothing Then yourCollect = New clsHand
        seepHandIndex.Sort(seepHandIndex)
        Dim c As Integer = 0
        For Each i As Integer In seepHandIndex
            If i <> 0 Then
                yourCollect.Insert(yourCollect.Count, seepHands.Item(i - (c + 1)))
                seepHands.Remove(seepHands.Item(i - (c + 1)))
                c = c + 1
            End If
        Next i

        yourCollect.Insert(yourCollect.Count, yourHands.Item(yourHandIndex))
        yourHands.Remove(yourHands.Item(yourHandIndex))
    End Sub
    Private Sub PileCardPlayer1(ByRef temp() As String)
        Dim tempFinal As Boolean = False
        Dim count, myHandIndex, seepHandIndex(7), pictureBoxIndex, iPileValue, pileScore As Integer
        Dim length As Integer
        pictureBoxIndex = 9

        Dim cardType As String
        Dim pileCard As String = temp(temp.Length - 1)
        length = seepHands.Count
        For j As Integer = 0 To length - 1 Step 1
            cardType = ConvertSuit(seepHands.Item(j).Suit) + ConvertFace(seepHands.Item(j).Face)
            If cardType = pileCard.TrimStart.TrimEnd Then
                If pictureBoxIndex = 9 Then pictureBoxIndex = j
                Exit For
            End If
        Next j


        count = 0
        Dim playerCard As String
        Dim seepCard As String
        Dim tempPileValue As PileValue
        pileID = pileID + 1
        For Each cardInPile As String In temp
            iPileValue = iPileValue + convertFace(cardInPile)
        Next
        If iPileValue > 13 Then
            iPileValue = ReturnPileValue2(iPileValue)
            tempFinal = True
        End If

        For Each cardInPile As String In temp
            If playerCard Is Nothing Then
                playerCard = cardInPile
                length = myHands.Count
                For j As Integer = 0 To length - 1 Step 1
                    cardType = ConvertSuit(myHands.Item(j).Suit) + ConvertFace(myHands.Item(j).Face)
                    If cardType = playerCard.TrimStart.TrimEnd Then
                        ResetPlayer1Cards(j)
                        myHandIndex = j
                        Exit For
                    End If
                Next j
                Dim newPile As New Pile
                newPile.pileID = pileID
                newPile.Value = GetPileValue(iPileValue)
                Dim newCard As Card
                newCard = New Card
                newCard = myHands.Item(myHandIndex)
                newCard.Index = pictureBoxIndex
                newCard.Final = tempFinal
                newCard.Pile = newPile
                myHands.Remove(myHands.Item(myHandIndex))
                Dim Pile As clsHand
                Pile = New clsHand
                Pile.Add(newCard)
                piles(pileID - 1) = Pile
            Else
                seepCard = cardInPile
                length = seepHands.Count
                For j As Integer = 0 To length - 1 Step 1
                    cardType = ConvertSuit(seepHands.Item(j).Suit) + ConvertFace(seepHands.Item(j).Face)
                    If cardType = seepCard.TrimStart.TrimEnd Then
                        ResetSeepCards(j)
                        seepHandIndex(count) = j + 1
                        count = count + 1
                        Exit For
                    End If
                Next j
            End If
        Next cardInPile
        ' Add Cards to pile
        seepHandIndex.Sort(seepHandIndex)
        Dim c As Integer = 0
        For Each i As Integer In seepHandIndex
            If i <> 0 Then
                Dim newPile As New Pile
                newPile.pileID = pileID
                newPile.Value = GetPileValue(iPileValue)
                Dim newCard As Card
                newCard = New Card
                newCard = seepHands.Item(i - (1 + c))
                newCard.Index = pictureBoxIndex
                newCard.Pile = newPile
                newCard.Final = tempFinal
                Dim Pile As clsHand
                piles(pileID - 1).Insert(piles(pileID - 1).Count, newCard)
                seepHands.Remove(seepHands.Item(i - (1 + c)))
                c = c + 1
            End If
        Next i

        cardType = ConvertSuit(piles(pileID - 1).Item(piles(pileID - 1).Count - 1).Suit) + ConvertFace(piles(pileID - 1).Item(piles(pileID - 1).Count - 1).Face)
        Dim fileName As String = cardType + ".gif"

        pileScore = 0
        length = piles(pileID - 1).Count
        For i As Integer = 0 To length - 1
            tempPileValue = piles(pileID - 1).Item(i).Pile.Value
            pileScore = pileScore + ConvertScore(piles(pileID - 1).Item(i).Face, piles(pileID - 1).Item(i).Suit)
        Next

        Dim rm As New Resources.ResourceManager("twoPlayerSeep.images", System.Reflection.Assembly.GetExecutingAssembly)
        Dim tempImage As Image = rm.GetObject(fileName)
        Dim tempValue As String = ConvertPileValue(tempPileValue)
        'If tempPileValue = common.PileValue.Thirteen Then ConvertPileFinal(pileID - 1)
        Select Case pictureBoxIndex
            Case 0
                seepCard1.Image = tempImage
                seepCard1.Text = cardType.ToUpper
                lblSeepCard1.Text = "Pile Score: " + CType(pileScore, String)
                lblSeepCard1Value.Text = "Pile Value: " + tempValue
            Case 1
                seepCard2.Image = tempImage
                seepCard2.Text = cardType.ToUpper
                lblSeepCard2.Text = "Pile Score: " + CType(pileScore, String)
                lblSeepCard2Value.Text = "Pile Value: " + tempValue
            Case 2
                seepCard3.Image = tempImage
                seepCard3.Text = cardType.ToUpper
                lblSeepCard3.Text = "Pile Score: " + CType(pileScore, String)
                lblSeepCard3Value.Text = "Pile Value: " + tempValue
            Case 3
                seepCard4.Image = tempImage
                seepCard4.Text = cardType.ToUpper
                lblSeepCard4.Text = "Pile Score: " + CType(pileScore, String)
                lblSeepCard4Value.Text = "Pile Value: " + tempValue
            Case 4
                seepCard5.Image = tempImage
                seepCard5.Text = cardType.ToUpper
                lblSeepCard5.Text = "Pile Score: " + CType(pileScore, String)
                lblSeepCard5Value.Text = "Pile Value: " + tempValue
            Case 5
                seepCard6.Image = tempImage
                seepCard6.Text = cardType.ToUpper
                lblSeepCard6.Text = "Pile Score: " + CType(pileScore, String)
                lblSeepCard6Value.Text = "Pile Value: " + tempValue
            Case 6
                seepCard7.Image = tempImage
                seepCard7.Text = cardType.ToUpper
                lblSeepCard7.Text = "Pile Score: " + CType(pileScore, String)
                lblSeepCard7Value.Text = "Pile Value: " + tempValue
            Case 7
                seepCard8.Image = tempImage
                seepCard8.Text = cardType.ToUpper
                lblSeepCard8.Text = "Pile Score: " + CType(pileScore, String)
                lblSeepCard8Value.Text = "Pile Value: " + tempValue
        End Select

    End Sub
    Private Sub PileCardPlayer2(ByRef temp() As String)
        Dim tempFinal As Boolean = False
        Dim count, yourHandIndex, seepHandIndex(7), pictureBoxIndex, iPileValue, pileScore As Integer
        Dim length As Integer
        pictureBoxIndex = 9

        Dim cardType As String
        Dim pileCard As String = temp(temp.Length - 1)
        length = seepHands.Count
        For j As Integer = 0 To length - 1 Step 1
            cardType = ConvertSuit(seepHands.Item(j).Suit) + ConvertFace(seepHands.Item(j).Face)
            If cardType = pileCard.TrimStart.TrimEnd Then
                If pictureBoxIndex = 9 Then pictureBoxIndex = j
                Exit For
            End If
        Next j


        count = 0
        Dim playerCard As String
        Dim seepCard As String
        Dim tempPileValue As PileValue
        pileID = pileID + 1
        For Each cardInPile As String In temp
            iPileValue = iPileValue + convertFace(cardInPile)
        Next
        If iPileValue > 13 Then
            iPileValue = ReturnPileValue2(iPileValue)
            tempFinal = True
        End If

        For Each cardInPile As String In temp
            If playerCard Is Nothing Then
                playerCard = cardInPile
                length = yourHands.Count
                For j As Integer = 0 To length - 1 Step 1
                    cardType = ConvertSuit(yourHands.Item(j).Suit) + ConvertFace(yourHands.Item(j).Face)
                    If cardType = playerCard.TrimStart.TrimEnd Then
                        ResetPlayer2Cards(j)
                        yourHandIndex = j
                        Exit For
                    End If
                Next j
                Dim newPile As New Pile
                newPile.pileID = pileID
                newPile.Value = GetPileValue(iPileValue)
                Dim newCard As Card
                newCard = New Card
                newCard = yourHands.Item(yourHandIndex)
                newCard.Index = pictureBoxIndex
                newCard.Pile = newPile
                newCard.Final = tempFinal
                yourHands.Remove(yourHands.Item(yourHandIndex))
                Dim Pile As clsHand
                Pile = New clsHand
                Pile.Add(newCard)
                piles(pileID - 1) = Pile
            Else
                seepCard = cardInPile
                length = seepHands.Count
                For j As Integer = 0 To length - 1 Step 1
                    cardType = ConvertSuit(seepHands.Item(j).Suit) + ConvertFace(seepHands.Item(j).Face)
                    If cardType = seepCard.TrimStart.TrimEnd Then
                        ResetSeepCards(j)
                        seepHandIndex(count) = j + 1
                        count = count + 1
                        Exit For
                    End If
                Next j
            End If
        Next cardInPile
        seepHandIndex.Sort(seepHandIndex)
        ' Add Cards to pile
        Dim c As Integer = 0
        For Each i As Integer In seepHandIndex
            If i <> 0 Then
                Dim newPile As New Pile
                newPile.pileID = pileID
                newPile.Value = GetPileValue(iPileValue)
                Dim newCard As Card
                newCard = New Card
                newCard = seepHands.Item(i - (1 + c))
                newCard.Index = pictureBoxIndex
                newCard.Pile = newPile
                newCard.Final = tempFinal
                piles(pileID - 1).Insert(piles(pileID - 1).Count, newCard)
                seepHands.Remove(seepHands.Item(i - (1 + c)))
                c = c + 1
            End If
        Next i

        cardType = ConvertSuit(piles(pileID - 1).Item(piles(pileID - 1).Count - 1).Suit) + ConvertFace(piles(pileID - 1).Item(piles(pileID - 1).Count - 1).Face)
        Dim fileName As String = cardType + ".gif"

        pileScore = 0
        length = piles(pileID - 1).Count
        For i As Integer = 0 To length - 1
            tempPileValue = piles(pileID - 1).Item(i).Pile.Value
            pileScore = pileScore + ConvertScore(piles(pileID - 1).Item(i).Face, piles(pileID - 1).Item(i).Suit)
        Next

        Dim rm As New Resources.ResourceManager("twoPlayerSeep.images", System.Reflection.Assembly.GetExecutingAssembly)
        Dim tempImage As Image = rm.GetObject(fileName)

        Dim tempValue As String = ConvertPileValue(tempPileValue)
        'If tempPileValue = common.PileValue.Thirteen Then ConvertPileFinal(pileID - 1)
        Select Case pictureBoxIndex
            Case 0
                seepCard1.Image = tempImage
                seepCard1.Text = cardType.ToUpper
                lblSeepCard1.Text = "Pile Score: " + CType(pileScore, String)
                lblSeepCard1Value.Text = "Pile Value: " + tempValue
            Case 1
                seepCard2.Image = tempImage
                seepCard2.Text = cardType.ToUpper
                lblSeepCard2.Text = "Pile Score: " + CType(pileScore, String)
                lblSeepCard2Value.Text = "Pile Value: " + tempValue
            Case 2
                seepCard3.Image = tempImage
                seepCard3.Text = cardType.ToUpper
                lblSeepCard3.Text = "Pile Score: " + CType(pileScore, String)
                lblSeepCard3Value.Text = "Pile Value: " + tempValue
            Case 3
                seepCard4.Image = tempImage
                seepCard4.Text = cardType.ToUpper
                lblSeepCard4.Text = "Pile Score: " + CType(pileScore, String)
                lblSeepCard4Value.Text = "Pile Value: " + tempValue
            Case 4
                seepCard5.Image = tempImage
                seepCard5.Text = cardType.ToUpper
                lblSeepCard5.Text = "Pile Score: " + CType(pileScore, String)
                lblSeepCard5Value.Text = "Pile Value: " + tempValue
            Case 5
                seepCard6.Image = tempImage
                seepCard6.Text = cardType.ToUpper
                lblSeepCard6.Text = "Pile Score: " + CType(pileScore, String)
                lblSeepCard6Value.Text = "Pile Value: " + tempValue
            Case 6
                seepCard7.Image = tempImage
                seepCard7.Text = cardType.ToUpper
                lblSeepCard7.Text = "Pile Score: " + CType(pileScore, String)
                lblSeepCard7Value.Text = "Pile Value: " + tempValue
            Case 7
                seepCard8.Image = tempImage
                seepCard8.Text = cardType.ToUpper
                lblSeepCard8.Text = "Pile Score: " + CType(pileScore, String)
                lblSeepCard8Value.Text = "Pile Value: " + tempValue
        End Select
    End Sub
    Private Sub PickPilePlayer1(ByRef temp() As String)
        Dim length, count As Integer
        Dim pileIndex, myHandIndex, seepHandIndex(7) As Integer
        Dim pileCard As String = temp(temp.Length - 1).TrimEnd.TrimStart
        pileIndex = ReturnPileID(pileCard)
        Dim playerCard As String
        Dim seepCard As String
        count = 0
        For Each cardInPile As String In temp
            If playerCard Is Nothing Then
                playerCard = cardInPile.TrimEnd.TrimStart

                length = myHands.Count
                For i As Integer = 0 To length - 1 Step 1
                    Dim cardType As String = ConvertSuit(myHands.Item(i).Suit) + ConvertFace(myHands.Item(i).Face)
                    If cardType = playerCard.TrimStart.TrimEnd Then
                        ResetPlayer1Cards(i)
                        myHandIndex = i
                        Exit For
                    End If
                Next i

            Else
                If cardInPile.TrimEnd.TrimStart.ToUpper = pileCard.TrimEnd.TrimStart.ToUpper Then
                    Dim pictureBoxIndex As Integer = piles(pileIndex).Item(0).Index
                    ResetSeepCards(pictureBoxIndex)
                Else
                    seepCard = cardInPile.TrimEnd.TrimStart
                    length = seepHands.Count
                    For i As Integer = 0 To length - 1 Step 1
                        Dim cardType As String = ConvertSuit(seepHands.Item(i).Suit) + ConvertFace(seepHands.Item(i).Face)
                        If cardType = seepCard.TrimStart.TrimEnd Then
                            ResetSeepCards(i)
                            seepHandIndex(count) = i + 1
                            count = count + 1
                            Exit For
                        End If
                    Next
                End If
            End If
        Next cardInPile

        If myCollect Is Nothing Then myCollect = New clsHand
        length = piles(pileIndex).Count
        For j As Integer = 0 To length - 1 Step 1
            myCollect.Insert(myCollect.Count, piles(pileIndex).Item(j))
        Next j
        myCollect.Insert(myCollect.Count, myHands.Item(myHandIndex))

        seepHandIndex.Sort(seepHandIndex)
        Dim c As Integer = 0
        For Each i As Integer In seepHandIndex
            If i <> 0 Then
                myCollect.Insert(myCollect.Count, seepHands.Item(i - (1 + c)))
                seepHands.Remove(seepHands.Item(i - (1 + c)))
                c = c + 1
            End If
        Next

        length = piles(pileIndex).Count
        For i As Integer = length - 1 To 0 Step -1
            piles(pileIndex).Remove(piles(pileIndex).Item(i))
        Next i
        piles(pileIndex) = Nothing

        SortPiles()
        pileID = pileID - 1
        myHands.Remove(myHands.Item(myHandIndex))




    End Sub
    Private Sub PickPilePlayer2(ByRef temp() As String)
        Dim length, count As Integer
        Dim pileIndex, yourHandIndex, seepHandIndex(7) As Integer
        Dim pileCard As String = temp(temp.Length - 1)
        pileIndex = ReturnPileID(pileCard)
        Dim playerCard As String
        Dim seepCard As String
        count = 0
        For Each cardInPile As String In temp
            If playerCard Is Nothing Then
                playerCard = cardInPile

                length = yourHands.Count
                For i As Integer = 0 To length - 1 Step 1
                    Dim cardType As String = ConvertSuit(yourHands.Item(i).Suit) + ConvertFace(yourHands.Item(i).Face)
                    If cardType = playerCard.TrimStart.TrimEnd Then
                        ResetPlayer2Cards(i)

                        yourHandIndex = i
                        Exit For
                    End If
                Next i

            Else
                If cardInPile.TrimEnd.TrimStart.ToUpper = pileCard.TrimEnd.TrimStart.ToUpper Then
                    Dim pictureBoxIndex As Integer = piles(pileIndex).Item(0).Index
                    ResetSeepCards(pictureBoxIndex)
                Else
                    seepCard = cardInPile
                    length = seepHands.Count
                    For i As Integer = 0 To length - 1 Step 1
                        Dim cardType As String = ConvertSuit(seepHands.Item(i).Suit) + ConvertFace(seepHands.Item(i).Face)
                        If cardType = seepCard.TrimStart.TrimEnd Then
                            ResetSeepCards(i)
                            seepHandIndex(count) = i + 1
                            count = count + 1
                            Exit For
                        End If
                    Next
                End If
            End If
        Next cardInPile

        If yourCollect Is Nothing Then yourCollect = New clsHand
        length = piles(pileIndex).Count
        For j As Integer = 0 To length - 1 Step 1
            yourCollect.Insert(yourCollect.Count, piles(pileIndex).Item(j))
        Next j
        yourCollect.Insert(yourCollect.Count, yourHands.Item(yourHandIndex))

        seepHandIndex.Sort(seepHandIndex)
        Dim c As Integer = 0
        For Each i As Integer In seepHandIndex
            If i <> 0 Then
                yourCollect.Insert(yourCollect.Count, seepHands.Item(i - (1 + c)))
                seepHands.Remove(seepHands.Item(i - (1 + c)))
                c = c + 1
            End If
        Next

        length = piles(pileIndex).Count
        For i As Integer = length - 1 To 0 Step -1
            piles(pileIndex).Remove(piles(pileIndex).Item(i))
        Next i
        piles(pileIndex) = Nothing

        SortPiles()
        pileID = pileID - 1
        yourHands.Remove(yourHands.Item(yourHandIndex))


    End Sub
    Private Sub AddPilePlayer1(ByRef temp() As String)

        Dim pileIndex As Integer
        Dim pileCard As String = temp(temp.Length - 1)
        Dim length As Integer
        pileIndex = ReturnPileID(pileCard.TrimEnd.TrimStart)

        Dim count, myHandIndex, seepHandIndex(7), pictureBoxIndex, iPileValue, iPileScore As Integer
        pictureBoxIndex = 9
        count = 0
        Dim playerCard As String
        Dim seepCard, cardType As String
        Dim tempPileValue As PileValue = ReturnPileValue(pileIndex)


        For Each cardInPile As String In temp
            If playerCard Is Nothing Then
                playerCard = cardInPile
                length = myHands.Count
                For j As Integer = 0 To length - 1 Step 1
                    cardType = ConvertSuit(myHands.Item(j).Suit) + ConvertFace(myHands.Item(j).Face)
                    If cardType = playerCard.TrimStart.TrimEnd Then
                        ResetPlayer1Cards(j)
                        myHandIndex = j
                        Exit For
                    End If
                Next j
                Dim newPile As New Pile
                newPile.pileID = pileIndex
                newPile.Value = tempPileValue
                Dim newCard As Card
                newCard = New Card
                newCard = myHands.Item(myHandIndex)
                newCard.Pile = newPile
                myHands.Remove(myHands.Item(myHandIndex))
                piles(pileIndex).Insert(piles(pileIndex).Count, newCard)
            Else
                If cardInPile.TrimEnd.TrimStart.ToUpper = pileCard.TrimEnd.TrimStart.ToUpper Then
                    length = piles(pileIndex).Count
                    For j As Integer = 0 To length - 1 Step 1
                        cardType = ConvertSuit(piles(pileIndex).Item(j).Suit) + ConvertFace(piles(pileIndex).Item(j).Face)
                        If cardType = cardInPile.TrimStart.TrimEnd Then
                            pictureBoxIndex = piles(pileIndex).Item(j).Index
                            Exit For
                        End If
                    Next
                Else
                    seepCard = cardInPile
                    length = seepHands.Count
                    For j As Integer = 0 To length - 1 Step 1
                        cardType = ConvertSuit(seepHands.Item(j).Suit) + ConvertFace(seepHands.Item(j).Face)
                        If cardType = seepCard.TrimStart.TrimEnd Then
                            ResetSeepCards(j)
                            seepHandIndex(count) = j + 1
                            count = count + 1
                            Exit For
                        End If
                    Next j
                End If
            End If
        Next cardInPile
        seepHandIndex.Sort(seepHandIndex)
        ' Add card to pile
        Dim c As Integer = 0
        For Each i As Integer In seepHandIndex
            If i <> 0 Then
                Dim newPile As New Pile
                newPile.pileID = pileIndex
                newPile.Value = tempPileValue
                Dim newCard As Card
                newCard = New Card
                newCard = seepHands.Item(i - (1 + c))
                newCard.Pile = newPile
                piles(pileIndex).Insert(piles(pileIndex).Count, newCard)
                seepHands.Remove(seepHands.Item(i - (1 + c)))
                c = c + 1
            End If
        Next
        ConvertPileFinal(pileIndex)
        iPileScore = 0
        length = piles(pileIndex).Count
        For i As Integer = 0 To length - 1
            iPileScore = iPileScore + ConvertScore(piles(pileIndex).Item(i).Face, piles(pileIndex).Item(i).Suit)
        Next

        cardType = ConvertSuit(piles(pileIndex).Item(piles(pileIndex).Count - 1).Suit) + ConvertFace(piles(pileIndex).Item(piles(pileIndex).Count - 1).Face)
        Dim fileName As String = cardType + ".gif"



        Dim rm As New Resources.ResourceManager("twoPlayerSeep.images", System.Reflection.Assembly.GetExecutingAssembly)
        Dim tempImage As Image = rm.GetObject(fileName)

        Dim tempValue As String = ConvertPileValue(tempPileValue)
        Select Case pictureBoxIndex
            Case 0
                seepCard1.Image = tempImage
                seepCard1.Text = cardType.ToUpper
                lblSeepCard1.Text = "Pile Score: " + CType(iPileScore, String)
                lblSeepCard1Value.Text = "Pile Value: " + tempValue
            Case 1
                seepCard2.Image = tempImage
                seepCard2.Text = cardType.ToUpper
                lblSeepCard2.Text = "Pile Score: " + CType(iPileScore, String)
                lblSeepCard2Value.Text = "Pile Value: " + tempValue
            Case 2
                seepCard3.Image = tempImage
                seepCard3.Text = cardType.ToUpper
                lblSeepCard3.Text = "Pile Score: " + CType(iPileScore, String)
                lblSeepCard3Value.Text = "Pile Value: " + tempValue
            Case 3
                seepCard4.Image = tempImage
                seepCard4.Text = cardType.ToUpper
                lblSeepCard4.Text = "Pile Score: " + CType(iPileScore, String)
                lblSeepCard4Value.Text = "Pile Value: " + tempValue
            Case 4
                seepCard5.Image = tempImage
                seepCard5.Text = cardType.ToUpper
                lblSeepCard5.Text = "Pile Score: " + CType(iPileScore, String)
                lblSeepCard5Value.Text = "Pile Value: " + tempValue
            Case 5
                seepCard6.Image = tempImage
                seepCard6.Text = cardType.ToUpper
                lblSeepCard6.Text = "Pile Score: " + CType(iPileScore, String)
                lblSeepCard6Value.Text = "Pile Value: " + tempValue
            Case 6
                seepCard7.Image = tempImage
                seepCard7.Text = cardType.ToUpper
                lblSeepCard7.Text = "Pile Score: " + CType(iPileScore, String)
                lblSeepCard7Value.Text = "Pile Value: " + tempValue
            Case 7
                seepCard8.Image = tempImage
                seepCard8.Text = cardType.ToUpper
                lblSeepCard8.Text = "Pile Score: " + CType(iPileScore, String)
                lblSeepCard8Value.Text = "Pile Value: " + tempValue
        End Select
    End Sub
    Private Sub AddPilePlayer2(ByRef temp() As String)
        Dim pileIndex As Integer
        Dim pileCard As String = temp(temp.Length - 1)
        Dim length As Integer
        pileIndex = ReturnPileID(pileCard.TrimEnd.TrimStart)

        Dim count, yourHandIndex, seepHandIndex(7), pictureBoxIndex, iPileValue, iPileScore As Integer
        pictureBoxIndex = 9
        count = 0
        Dim playerCard As String
        Dim seepCard, cardType As String
        Dim tempPileValue As PileValue = ReturnPileValue(pileIndex)


        For Each cardInPile As String In temp
            If playerCard Is Nothing Then
                playerCard = cardInPile
                length = yourHands.Count
                For j As Integer = 0 To length - 1 Step 1
                    cardType = ConvertSuit(yourHands.Item(j).Suit) + ConvertFace(yourHands.Item(j).Face)
                    If cardType = playerCard.TrimStart.TrimEnd Then
                        ResetPlayer2Cards(j)
                        yourHandIndex = j
                        Exit For
                    End If
                Next j
                Dim newPile As New Pile
                newPile.pileID = pileIndex
                newPile.Value = tempPileValue
                Dim newCard As Card
                newCard = New Card
                newCard = yourHands.Item(yourHandIndex)
                yourHands.Remove(yourHands.Item(yourHandIndex))
                newCard.Pile = newPile
                piles(pileIndex).Insert(piles(pileIndex).Count, newCard)
            Else
                If cardInPile.TrimEnd.TrimStart.ToUpper = pileCard.TrimEnd.TrimStart.ToUpper Then
                    length = piles(pileIndex).Count
                    For j As Integer = 0 To length - 1 Step 1
                        cardType = ConvertSuit(piles(pileIndex).Item(j).Suit) + ConvertFace(piles(pileIndex).Item(j).Face)
                        If cardType = cardInPile.TrimStart.TrimEnd Then
                            pictureBoxIndex = piles(pileIndex).Item(j).Index
                            Exit For
                        End If
                    Next
                Else
                    seepCard = cardInPile
                    length = seepHands.Count
                    For j As Integer = 0 To length - 1 Step 1
                        cardType = ConvertSuit(seepHands.Item(j).Suit) + ConvertFace(seepHands.Item(j).Face)
                        If cardType = seepCard.TrimStart.TrimEnd Then
                            ResetSeepCards(j)
                            seepHandIndex(count) = j + 1
                            count = count + 1
                            Exit For
                        End If
                    Next j
                End If
            End If
        Next cardInPile
        seepHandIndex.Sort(seepHandIndex)
        ' Add card to pile
        Dim c As Integer = 0
        For Each i As Integer In seepHandIndex
            If i <> 0 Then
                Dim newPile As New Pile
                newPile.pileID = pileIndex
                newPile.Value = tempPileValue
                Dim newCard As Card
                newCard = New Card
                newCard = seepHands.Item(i - (1 + c))
                newCard.Pile = newPile
                piles(pileIndex).Insert(piles(pileIndex).Count, newCard)
                seepHands.Remove(seepHands.Item(i - (1 + c)))
                c = c + 1
            End If
        Next
        ConvertPileFinal(pileIndex)
        iPileScore = 0
        length = piles(pileIndex).Count
        For i As Integer = 0 To length - 1
            iPileScore = iPileScore + ConvertScore(piles(pileIndex).Item(i).Face, piles(pileIndex).Item(i).Suit)
        Next

        cardType = ConvertSuit(piles(pileIndex).Item(piles(pileIndex).Count - 1).Suit) + ConvertFace(piles(pileIndex).Item(piles(pileIndex).Count - 1).Face)
        Dim fileName As String = cardType + ".gif"


        Dim rm As New Resources.ResourceManager("twoPlayerSeep.images", System.Reflection.Assembly.GetExecutingAssembly)
        Dim tempImage As Image = rm.GetObject(fileName)

        Dim tempValue As String = ConvertPileValue(tempPileValue)
        Select Case pictureBoxIndex
            Case 0
                seepCard1.Image = tempImage
                seepCard1.Text = cardType.ToUpper
                lblSeepCard1.Text = "Pile Score: " + CType(iPileScore, String)
                lblSeepCard1Value.Text = "Pile Value: " + tempValue
            Case 1
                seepCard2.Image = tempImage
                seepCard2.Text = cardType.ToUpper
                lblSeepCard2.Text = "Pile Score: " + CType(iPileScore, String)
                lblSeepCard2Value.Text = "Pile Value: " + tempValue
            Case 2
                seepCard3.Image = tempImage
                seepCard3.Text = cardType.ToUpper
                lblSeepCard3.Text = "Pile Score: " + CType(iPileScore, String)
                lblSeepCard3Value.Text = "Pile Value: " + tempValue
            Case 3
                seepCard4.Image = tempImage
                seepCard4.Text = cardType.ToUpper
                lblSeepCard4.Text = "Pile Score: " + CType(iPileScore, String)
                lblSeepCard4Value.Text = "Pile Value: " + tempValue
            Case 4
                seepCard5.Image = tempImage
                seepCard5.Text = cardType.ToUpper
                lblSeepCard5.Text = "Pile Score: " + CType(iPileScore, String)
                lblSeepCard5Value.Text = "Pile Value: " + tempValue
            Case 5
                seepCard6.Image = tempImage
                seepCard6.Text = cardType.ToUpper
                lblSeepCard6.Text = "Pile Score: " + CType(iPileScore, String)
                lblSeepCard6Value.Text = "Pile Value: " + tempValue
            Case 6
                seepCard7.Image = tempImage
                seepCard7.Text = cardType.ToUpper
                lblSeepCard7.Text = "Pile Score: " + CType(iPileScore, String)
                lblSeepCard7Value.Text = "Pile Value: " + tempValue
            Case 7
                seepCard8.Image = tempImage
                seepCard8.Text = cardType.ToUpper
                lblSeepCard8.Text = "Pile Score: " + CType(iPileScore, String)
                lblSeepCard8Value.Text = "Pile Value: " + tempValue
        End Select
    End Sub
    Private Sub ThrowCard(ByVal cmd As String, ByVal player As Integer)
        Dim myHandIndex As Integer
        Dim length As Integer
        If player = 1 Then
            length = myHands.Count
            For i As Integer = 0 To length - 1 Step 1
                'If myHands.Item(i).Flipped = True Then
                Dim cardType As String = ConvertSuit(myHands.Item(i).Suit) + ConvertFace(myHands.Item(i).Face)
                Dim fileName As String = cardType + ".gif"
                If cardType = cmd.TrimStart.TrimEnd Then
                    ResetPlayer1Cards(i)
                    myHandIndex = i
                    AddSeepCard(cmd.TrimEnd.TrimStart, fileName)
                    seepHands.Insert(seepHands.Count, myHands.Item(i))
                    Exit For
                End If
                'End If
            Next i
        Else
            length = yourHands.Count
            For i As Integer = 0 To length - 1 Step 1
                'If myHands.Item(i).Flipped = True Then
                Dim cardType As String = ConvertSuit(yourHands.Item(i).Suit) + ConvertFace(yourHands.Item(i).Face)
                Dim fileName As String = cardType + ".gif"
                If cardType = cmd.TrimStart.TrimEnd Then
                    ResetPlayer2Cards(i)
                    myHandIndex = i
                    AddSeepCard(cmd.TrimEnd.TrimStart, fileName)
                    seepHands.Insert(seepHands.Count, yourHands.Item(i))
                    Exit For
                End If
                'End If
            Next i
        End If
        If player = 1 Then
            myHands.Remove(myHands.Item(myHandIndex))
        Else
            yourHands.Remove(yourHands.Item(myHandIndex))
        End If
    End Sub
    Private Sub ChangePile(ByVal temp() As String, ByVal player As Integer)
        Dim rm As New Resources.ResourceManager("twoPlayerSeep.images", System.Reflection.Assembly.GetExecutingAssembly)
        Dim myHandIndex, pileIndex, iPValue, iNewPValue, seepCardIndex As Integer
        Dim sPValue, fileName, cardType As String
        Dim length As Integer
        pileIndex = ReturnPileID(temp(1).TrimEnd.TrimStart)
        Dim pValue As PileValue
        pValue = ReturnPileValue(pileIndex)
        sPValue = ConvertPileValue(pValue)
        iPValue = ConvertPileValue(sPValue)
        iNewPValue = convertFace(temp(0).TrimEnd.TrimStart)
        iNewPValue = iNewPValue + iPValue
        pValue = GetPileValue(iNewPValue)
        Dim pileIndex1 As Integer = -1
        pileIndex1 = GetSamePile(pValue, pileIndex)
        If player = 1 Then
            length = myHands.Count
            For i As Integer = 0 To length - 1 Step 1
                'If myHands.Item(i).Flipped = True Then
                cardType = ConvertSuit(myHands.Item(i).Suit) + ConvertFace(myHands.Item(i).Face)
                fileName = cardType + ".gif"
                If cardType = temp(0).TrimStart.TrimEnd Then
                    ResetPlayer1Cards(i)
                    myHandIndex = i
                    Exit For
                End If
            Next i

            Dim newPile As Pile
            Dim newCard As Card
            Dim Pile As clsHand
            length = piles(pileIndex).Count
            Pile = New clsHand
            For i As Integer = length - 1 To 0 Step -1
                newPile = New Pile
                newPile.pileID = pileIndex
                newPile.Value = pValue
                newCard = New Card
                newCard = piles(pileIndex).Item(i)
                newCard.Pile = newPile
                seepCardIndex = newCard.Index
                Pile.Insert(Pile.Count, newCard)
            Next i
            length = piles(pileIndex).Count
            For i As Integer = length - 1 To 0 Step -1
                piles(pileIndex).Remove(piles(pileIndex).Item(i))
            Next i
            piles(pileIndex) = Pile
            newPile = New Pile
            newPile.pileID = pileIndex
            newPile.Value = pValue
            newCard = New Card
            newCard = myHands.Item(myHandIndex)
            myHands.Remove(myHands.Item(myHandIndex))
            newCard.Pile = newPile
            piles(pileIndex).Insert(piles(pileIndex).Count, newCard)
        Else
            length = yourHands.Count
            For i As Integer = 0 To length - 1 Step 1
                'If myHands.Item(i).Flipped = True Then
                cardType = ConvertSuit(yourHands.Item(i).Suit) + ConvertFace(yourHands.Item(i).Face)
                fileName = cardType + ".gif"

                If cardType = temp(0).TrimStart.TrimEnd Then
                    ResetPlayer2Cards(i)
                    myHandIndex = i
                    Exit For
                End If
            Next i
            Dim newPile As Pile
            Dim newCard As Card
            Dim Pile As clsHand
            Pile = New clsHand
            length = piles(pileIndex).Count
            For i As Integer = length - 1 To 0 Step -1
                newPile = New Pile
                newPile.pileID = pileIndex
                newPile.Value = pValue
                newCard = New Card
                newCard = piles(pileIndex).Item(i)
                newCard.Pile = newPile
                seepCardIndex = newCard.Index
                Pile.Insert(Pile.Count, newCard)
            Next i
            length = piles(pileIndex).Count
            For i As Integer = length - 1 To 0 Step -1
                piles(pileIndex).Remove(piles(pileIndex).Item(i))
            Next i
            piles(pileIndex) = Pile
            newPile = New Pile
            newPile.pileID = pileIndex
            newPile.Value = pValue
            newCard = New Card
            newCard = yourHands.Item(myHandIndex)
            yourHands.Remove(yourHands.Item(myHandIndex))
            newCard.Pile = newPile
            piles(pileIndex).Insert(piles(pileIndex).Count, newCard)
        End If

        If player = 1 Then
            myHands.Remove(myHands.Item(myHandIndex))
        Else
            yourHands.Remove(yourHands.Item(myHandIndex))
        End If

        Dim tempPileScore As String
        Dim TempPileValue As String

        If pileIndex1 <> -1 Then
            Dim removePileIndex As Integer
            If pileIndex1 > pileIndex Then
                Dim newPile As Pile
                Dim newCard As Card
                Dim Pile As clsHand
                length = piles(pileIndex1).Count
                For i As Integer = length - 1 To 0 Step -1
                    newCard = New Card
                    newCard = piles(pileIndex1).Item(i)
                    removePileIndex = newCard.Index
                    piles(pileIndex).Insert(piles(pileIndex).Count, newCard)
                Next i
                length = piles(pileIndex1).Count
                For i As Integer = length - 1 To 0 Step -1
                    piles(pileIndex1).Remove(piles(pileIndex1).Item(i))
                Next i
                piles(pileIndex1) = Nothing

                SortPiles()
                pileID = pileID - 1
                newCard = New Card
                newCard = piles(pileIndex).Item(0)
                seepCardIndex = newCard.Index
                ResetSeepCards(removePileIndex)
                tempPileScore = CType(pileScore(pileIndex), String)
                'If pValue = common.PileValue.Thirteen Then ConvertPileFinal(pileIndex)
            Else
                Dim newPile As Pile
                Dim newCard As Card
                Dim Pile As clsHand
                length = piles(pileIndex).Count
                For i As Integer = length - 1 To 0 Step -1
                    newCard = New Card
                    newCard = piles(pileIndex).Item(i)
                    removePileIndex = newCard.Index
                    piles(pileIndex1).Insert(piles(pileIndex1).Count, newCard)
                Next i
                length = piles(pileIndex).Count
                For i As Integer = length - 1 To 0 Step -1
                    piles(pileIndex).Remove(piles(pileIndex).Item(i))
                Next i
                piles(pileIndex) = Nothing

                SortPiles()
                pileID = pileID - 1
                newCard = New Card
                newCard = piles(pileIndex1).Item(0)
                seepCardIndex = newCard.Index
                ResetSeepCards(removePileIndex)
                tempPileScore = CType(pileScore(pileIndex1), String)
                'If pValue = common.PileValue.Thirteen Then ConvertPileFinal(pileIndex1)
            End If
        End If


        TempPileValue = ConvertPileValue(pValue)
        SetSeepCardImages(seepCardIndex, fileName, cardType, TempPileValue, tempPileScore)


    End Sub
    Private Sub SeepPoints(ByVal cmd As String, ByVal player As Integer)
        Dim cardType As String
        Dim myHandIndex As Integer
        Dim length As Integer
        Dim newCard As Card

        If player = 1 Then
            length = myHands.Count
            For i As Integer = 0 To length - 1 Step 1
                'If myHands.Item(i).Flipped = True Then
                cardType = ConvertSuit(myHands.Item(i).Suit) + ConvertFace(myHands.Item(i).Face)
                If cardType = cmd.TrimStart.TrimEnd Then
                    ResetPlayer1Cards(i)
                    myHandIndex = i
                    Exit For
                End If
            Next i
            If myCollect Is Nothing Then myCollect = New clsHand
            newCard = New Card
            newCard = myHands.Item(myHandIndex)
            myHands.Remove(myHands.Item(myHandIndex))
            myCollect.Insert(myCollect.Count, newCard)
            length = seepHands.Count
            For i As Integer = length - 1 To 0 Step -1
                newCard = New Card
                newCard = seepHands.Item(i)
                seepHands.Remove(seepHands.Item(i))
                myCollect.Insert(myCollect.Count, newCard)
            Next i
            For i As Integer = 0 To pileID - 1 Step 1
                If piles(i).Count > 1 Then
                    length = piles(i).Count
                    For j As Integer = length - 1 To 0 Step -1
                        newCard = New Card
                        newCard = piles(i).Item(j)
                        piles(i).Remove(piles(i).Item(i))
                        myCollect.Insert(myCollect.Count, newCard)
                    Next j
                End If
            Next i
            player1Seep = player1Seep + 1
        Else
            length = yourHands.Count
            For i As Integer = 0 To length - 1 Step 1
                'If myHands.Item(i).Flipped = True Then
                cardType = ConvertSuit(yourHands.Item(i).Suit) + ConvertFace(yourHands.Item(i).Face)
                If cardType = cmd.TrimStart.TrimEnd Then
                    ResetPlayer2Cards(i)
                    myHandIndex = i
                    Exit For
                End If
            Next i
            If yourCollect Is Nothing Then yourCollect = New clsHand
            newCard = New Card
            newCard = yourHands.Item(myHandIndex)
            yourHands.Remove(yourHands.Item(myHandIndex))
            yourCollect.Insert(yourCollect.Count, newCard)
            length = seepHands.Count
            For i As Integer = length - 1 To 0 Step -1
                newCard = New Card
                newCard = seepHands.Item(i)
                seepHands.Remove(seepHands.Item(i))
                yourCollect.Insert(yourCollect.Count, newCard)
            Next i
            For i As Integer = 0 To pileID - 1 Step 1
                If piles(i).Count > 1 Then
                    length = piles(i).Count
                    For j As Integer = length - 1 To 0 Step -1
                        newCard = New Card
                        newCard = piles(i).Item(j)
                        piles(i).Remove(piles(i).Item(i))
                        yourCollect.Insert(yourCollect.Count, newCard)
                    Next j
                End If
            Next i
            player2Seep = player2Seep + 1
        End If

    End Sub
    Private Function cardOver9() As Boolean
        For i As Integer = 0 To 3
            If ConvertFace(myHands.Item(i).Face) > 9 Then Return (True)
        Next
        Return (False)
    End Function

#End Region ' Seep Command Functions

#Region "General Functions"
    Private Sub reset()

        Dim rm As New Resources.ResourceManager("twoPlayerSeep.images", System.Reflection.Assembly.GetExecutingAssembly)
        myDeck = New clsCardDeck
        myDeck.Shuffle()
        deck.Image = rm.GetObject("b1fv.gif")
        deck.Text = ReturnOrientationText(common.Orientation.NotFlipped)

        'myDeck.collect(1)
        'Application.DoEvents()
        'myDeck.collect(2)
        Me.player1Card1.Image = Nothing
        Me.player1card2.Image = Nothing
        Me.player1Card3.Image = Nothing
        Me.player1Card4.Image = Nothing
        Me.Player1Card5.Image = Nothing
        Me.Player1Card6.Image = Nothing
        Me.Player1Card7.Image = Nothing
        Me.Player1Card8.Image = Nothing
        Me.seepCard1.Image = Nothing
        Me.seepCard2.Image = Nothing
        Me.seepCard3.Image = Nothing
        Me.seepCard4.Image = Nothing
        Me.seepCard5.Image = Nothing
        Me.seepCard6.Image = Nothing
        Me.seepCard7.Image = Nothing
        Me.seepCard8.Image = Nothing
        Me.seepCard1.Text = ReturnOrientationText(common.Orientation.NoCard)
        Me.seepCard2.Text = ReturnOrientationText(common.Orientation.NoCard)
        Me.seepCard3.Text = ReturnOrientationText(common.Orientation.NoCard)
        Me.seepCard4.Text = ReturnOrientationText(common.Orientation.NoCard)
        Me.seepCard5.Text = ReturnOrientationText(common.Orientation.NoCard)
        Me.seepCard6.Text = ReturnOrientationText(common.Orientation.NoCard)
        Me.seepCard7.Text = ReturnOrientationText(common.Orientation.NoCard)
        Me.seepCard8.Text = ReturnOrientationText(common.Orientation.NoCard)
        Me.lblSeepCard1.Text = ""
        Me.lblSeepCard2.Text = ""
        Me.lblSeepCard3.Text = ""
        Me.lblSeepCard4.Text = ""
        Me.lblSeepCard5.Text = ""
        Me.lblSeepCard6.Text = ""
        Me.lblSeepCard7.Text = ""
        Me.lblSeepCard8.Text = ""
        Me.lblSeepCard1Value.Text = ""
        Me.lblSeepCard2Value.Text = ""
        Me.lblSeepCard3Value.Text = ""
        Me.lblSeepCard4Value.Text = ""
        Me.lblSeepCard5Value.Text = ""
        Me.lblSeepCard6Value.Text = ""
        Me.lblSeepCard7Value.Text = ""
        Me.lblSeepCard8Value.Text = ""
        Me.lblPlayer1Score.Text = ""
        Me.lblPlayer2Score.Text = ""
        Me.Player2Card1.Image = Nothing
        Me.player2Card2.Image = Nothing
        Me.player2card3.Image = Nothing
        Me.player2Card4.Image = Nothing
        Me.Player2Card5.Image = Nothing
        Me.Player2Card6.Image = Nothing
        Me.Player2Card7.Image = Nothing
        Me.Player2Card8.Image = Nothing
        Me.txtPlayer1.Text = "Enter Player Card first and then seep cards"
        Me.txtPlayer2.Text = "Enter Player Card first and then seep cards"
        firstCallNumberSelected = False
        firstMoveDone = False
        Me.btnStart.Enabled = True
        Me.btnStart.Focus()
        player1Score = 0
        player2Score = 0
        pileID = 0
        player1Moves = 0
        player2Moves = 0
        player1Seep = 0
        player2Seep = 0
        'player1SeriesScore = 0
        'player2SeriesScore = 0
        EnableDisableButtons()
    End Sub
    Private Sub resetHandsAndPiles()

        myHands = Nothing

        seepHands = Nothing

        yourHands = Nothing

        piles = Nothing

        ReDim piles(8)
    End Sub
    Private Sub isFirstMoveDone()

        If firstMoveDone = False AndAlso validationFailed = False Then
            FlipOtherHands()
            firstMoveDone = True
        End If
    End Sub
    Private Sub RefreshHands()
        Dim seepHand As Integer = 0
        Dim length As Integer
        ResetMyHands()
        ResetYourHands()
        ResetSeepHands()
        ResetPlayerScores()
        length = myHands.Count
        If playerMove = 1 Or playerMove = 2 Then
            MessageBox.Show("Please handover the screen output to other player first before clicking OK button", "Two Player Seep Game", MessageBoxButtons.OK)
        End If
        For i As Integer = 0 To length - 1 Step 1
            Dim cardType As String = ConvertSuit(myHands.Item(i).Suit) + ConvertFace(myHands.Item(i).Face)
            Dim fileName As String
            If playerMove = 1 Then
                fileName = cardType + ".gif"
            Else
                fileName = "b1fv.gif"
            End If
            SetMyCardImages(i, fileName, cardType)
        Next i
        length = seepHands.Count
        For i As Integer = length - 1 To 0 Step -1
            Dim cardType As String = ConvertSuit(seepHands.Item(i).Suit) + ConvertFace(seepHands.Item(i).Face)
            Dim fileName As String = cardType + ".gif"
            Dim tempCard As Card
            tempCard = seepHands.Item(i)
            seepHands.Remove(seepHands.Item(i))
            tempCard.Index = i
            seepHands.Insert(seepHands.Count, tempCard)
            SetSeepCardImages(i, fileName, cardType)
        Next i
        seepHand = (seepHands.Count - 1) + 1
        For i As Integer = 0 To pileID - 1 Step 1
            If piles(i).Count > 1 Then
                Dim tempPileScore, tempPileValue, cardType, cardFace As String
                Dim PileValue As PileValue
                length = piles(i).Count
                For j As Integer = 0 To length - 1 Step 1
                    PileValue = piles(i).Item(j).Pile.Value
                    tempPileValue = ConvertPileValue(PileValue)
                    tempPileScore = pileScore(i)
                    If j = 0 Then
                        cardFace = ConvertFace(piles(i).Item(j).Face)
                        cardType = ConvertSuit(piles(i).Item(j).Suit) + ConvertFace(piles(i).Item(j).Face)
                    End If
                    If ConvertFace(piles(i).Item(j).Face) > cardFace Then
                        cardFace = ConvertFace(piles(i).Item(j).Face)
                        cardType = ConvertSuit(piles(i).Item(j).Suit) + ConvertFace(piles(i).Item(j).Face)
                    End If

                Next j
                Dim fileName As String = cardType + ".gif"
                For j As Integer = length - 1 To 0 Step -1
                    Dim tempCard As Card
                    tempCard = piles(i).Item(j)
                    tempCard.Index = seepHand
                    piles(i).Remove(piles(i).Item(j))
                    piles(i).Insert(piles(i).Count, tempCard)
                Next
                SetSeepCardImages(seepHand, fileName, cardType, tempPileValue, tempPileScore)
                seepHand = seepHand + 1
                cardFace = ""
            End If
        Next i
        length = yourHands.Count
        For i As Integer = 0 To length - 1 Step 1
            Dim cardType As String = ConvertSuit(yourHands.Item(i).Suit) + ConvertFace(yourHands.Item(i).Face)
            Dim fileName As String
            If playerMove = 2 Then
                fileName = cardType + ".gif"
            Else
                fileName = "b1fv.gif"
            End If
            SetYourCardImages(i, fileName, cardType)
        Next i

        player1Score = ReturnMyCollectPoints()
        player2Score = ReturnYourCollectPoints()
        Me.lblPlayer1Score.Text = player1Score
        Me.lblPlayer2Score.Text = player2Score
        Me.lblPlayer1Seep.Text = player1Seep
        Me.lblPlayer2Seep.Text = player2Seep
    End Sub
    Private Sub ResetMyHands()
        Me.player1Card1.Image = Nothing
        Me.player1card2.Image = Nothing
        Me.player1Card3.Image = Nothing
        Me.player1Card4.Image = Nothing
        Me.Player1Card5.Image = Nothing
        Me.Player1Card6.Image = Nothing
        Me.Player1Card7.Image = Nothing
        Me.Player1Card8.Image = Nothing
    End Sub
    Private Sub ResetSeepHands()
        Me.seepCard1.Image = Nothing
        Me.seepCard2.Image = Nothing
        Me.seepCard3.Image = Nothing
        Me.seepCard4.Image = Nothing
        Me.seepCard5.Image = Nothing
        Me.seepCard6.Image = Nothing
        Me.seepCard7.Image = Nothing
        Me.seepCard8.Image = Nothing

        Me.seepCard1.Text = ReturnOrientationText(common.Orientation.NoCard)
        Me.seepCard2.Text = ReturnOrientationText(common.Orientation.NoCard)
        Me.seepCard3.Text = ReturnOrientationText(common.Orientation.NoCard)
        Me.seepCard4.Text = ReturnOrientationText(common.Orientation.NoCard)
        Me.seepCard5.Text = ReturnOrientationText(common.Orientation.NoCard)
        Me.seepCard6.Text = ReturnOrientationText(common.Orientation.NoCard)
        Me.seepCard7.Text = ReturnOrientationText(common.Orientation.NoCard)
        Me.seepCard8.Text = ReturnOrientationText(common.Orientation.NoCard)

        Me.lblSeepCard1.Text = ""
        Me.lblSeepCard2.Text = ""
        Me.lblSeepCard3.Text = ""
        Me.lblSeepCard4.Text = ""
        Me.lblSeepCard5.Text = ""
        Me.lblSeepCard6.Text = ""
        Me.lblSeepCard7.Text = ""
        Me.lblSeepCard8.Text = ""
        Me.lblSeepCard1Value.Text = ""
        Me.lblSeepCard2Value.Text = ""
        Me.lblSeepCard3Value.Text = ""
        Me.lblSeepCard4Value.Text = ""
        Me.lblSeepCard5Value.Text = ""
        Me.lblSeepCard6Value.Text = ""
        Me.lblSeepCard7Value.Text = ""
        Me.lblSeepCard8Value.Text = ""
    End Sub
    Private Sub ResetYourHands()
        Me.Player2Card1.Image = Nothing
        Me.player2Card2.Image = Nothing
        Me.player2card3.Image = Nothing
        Me.player2Card4.Image = Nothing
        Me.Player2Card5.Image = Nothing
        Me.Player2Card6.Image = Nothing
        Me.Player2Card7.Image = Nothing
        Me.Player2Card8.Image = Nothing
    End Sub
    Private Sub ResetPlayerScores()
        Me.lblPlayer1Score.Text = 0
        Me.lblPlayer2Score.Text = 0
    End Sub
    Private Sub DisableEnableButtons()
        Me.btn9.Enabled = False
        Me.btn10.Enabled = False
        Me.btn11.Enabled = False
        Me.btn12.Enabled = False
        Me.btn13.Enabled = False
        Me.btnAddPile1.Enabled = True
        Me.btnAddPile2.Enabled = True
        Me.btnChangePile1.Enabled = True
        Me.btnChangePile2.Enabled = True
        Me.btnCreatePile1.Enabled = True
        Me.btnCreatePile2.Enabled = True
        Me.btnPickCard1.Enabled = True
        Me.btnPickCard2.Enabled = True
        Me.btnPickPile1.Enabled = True
        Me.btnPickPile2.Enabled = True
        Me.btnSeepPoints1.Enabled = True
        Me.btnSeepPoints2.Enabled = True
        Me.btnThrowCard1.Enabled = True
        Me.btnThrowCard2.Enabled = True
    End Sub
    Private Sub EnableDisableButtons()
        Me.btn9.Enabled = True
        Me.btn10.Enabled = True
        Me.btn11.Enabled = True
        Me.btn12.Enabled = True
        Me.btn13.Enabled = True
        Me.btnAddPile1.Enabled = False
        Me.btnAddPile2.Enabled = False
        Me.btnChangePile1.Enabled = False
        Me.btnChangePile2.Enabled = False
        Me.btnCreatePile1.Enabled = False
        Me.btnCreatePile2.Enabled = False
        Me.btnPickCard1.Enabled = False
        Me.btnPickCard2.Enabled = False
        Me.btnPickPile1.Enabled = False
        Me.btnPickPile2.Enabled = False
        Me.btnSeepPoints1.Enabled = False
        Me.btnSeepPoints2.Enabled = False
        Me.btnThrowCard1.Enabled = False
        Me.btnThrowCard2.Enabled = False
    End Sub
    Private Sub Enable2Player()
        Me.btnAddPile1.Enabled = False
        Me.btnChangePile1.Enabled = False
        Me.btnCreatePile1.Enabled = False
        Me.btnPickCard1.Enabled = False
        Me.btnPickPile1.Enabled = False
        Me.btnSeepPoints1.Enabled = False
        Me.btnThrowCard1.Enabled = False
        Me.btnAddPile2.Enabled = True
        Me.btnChangePile2.Enabled = True
        Me.btnCreatePile2.Enabled = True
        Me.btnPickCard2.Enabled = True
        Me.btnPickPile2.Enabled = True
        Me.btnSeepPoints2.Enabled = True
        Me.btnThrowCard2.Enabled = True
        playerMove = 2


    End Sub
    Private Sub Enable1Player()
        Me.btnAddPile2.Enabled = False
        Me.btnChangePile2.Enabled = False
        Me.btnCreatePile2.Enabled = False
        Me.btnPickCard2.Enabled = False
        Me.btnPickPile2.Enabled = False
        Me.btnSeepPoints2.Enabled = False
        Me.btnThrowCard2.Enabled = False
        Me.btnAddPile1.Enabled = True
        Me.btnChangePile1.Enabled = True
        Me.btnCreatePile1.Enabled = True
        Me.btnPickCard1.Enabled = True
        Me.btnPickPile1.Enabled = True
        Me.btnSeepPoints1.Enabled = True
        Me.btnThrowCard1.Enabled = True
        playerMove = 1

    End Sub
    Private Sub SetMyCardImages(ByVal index As Integer, ByVal fileName As String, ByVal cardType As String)
        Dim rm As New Resources.ResourceManager("twoPlayerSeep.images", System.Reflection.Assembly.GetExecutingAssembly)
        Dim tempImage As Image = rm.GetObject(fileName)

        Select Case index
            Case 0
                player1Card1.Image = tempImage
                player1Card1.Text = cardType.ToUpper
            Case 1
                player1card2.Image = tempImage
                player1card2.Text = cardType.ToUpper
            Case 2
                player1Card3.Image = tempImage
                player1Card3.Text = cardType.ToUpper
            Case 3
                player1Card4.Image = tempImage
                player1Card4.Text = cardType.ToUpper
            Case 4
                Player1Card5.Image = tempImage
                Player1Card5.Text = cardType.ToUpper
            Case 5
                Player1Card6.Image = tempImage
                Player1Card6.Text = cardType.ToUpper
            Case 6
                Player1Card7.Image = tempImage
                Player1Card7.Text = cardType.ToUpper
            Case 7
                Player1Card8.Image = tempImage
                Player1Card8.Text = cardType.ToUpper
        End Select

    End Sub
    Private Sub SetYourCardImages(ByVal index As Integer, ByVal fileName As String, ByVal cardType As String)
        Dim rm As New Resources.ResourceManager("twoPlayerSeep.images", System.Reflection.Assembly.GetExecutingAssembly)
        Dim tempImage As Image = rm.GetObject(fileName)
        Select Case index
            Case 0
                Player2Card1.Image = tempImage
                Player2Card1.Text = cardType.ToUpper
            Case 1
                player2Card2.Image = tempImage
                player2Card2.Text = cardType.ToUpper
            Case 2
                player2card3.Image = tempImage
                player2card3.Text = cardType.ToUpper
            Case 3
                player2Card4.Image = tempImage
                player2Card4.Text = cardType.ToUpper
            Case 4
                Player2Card5.Image = tempImage
                Player2Card5.Text = cardType.ToUpper
            Case 5
                Player2Card6.Image = tempImage
                Player2Card6.Text = cardType.ToUpper
            Case 6
                Player2Card7.Image = tempImage
                Player2Card7.Text = cardType.ToUpper
            Case 7
                Player2Card8.Image = tempImage
                Player2Card8.Text = cardType.ToUpper
        End Select

    End Sub
    Private Sub SetSeepCardImages(ByVal index As Integer, ByVal fileName As String, ByVal cardType As String, Optional ByVal pileValue As String = "", Optional ByVal pileScore As String = "")
        Dim rm As New Resources.ResourceManager("twoPlayerSeep.images", System.Reflection.Assembly.GetExecutingAssembly)
        Dim tempImage As Image = rm.GetObject(fileName)
        Select Case index
            Case 0
                seepCard1.Image = tempImage
                seepCard1.Text = cardType.ToUpper
                If pileScore <> "" OrElse pileValue <> "" Then
                    lblSeepCard1.Text = "Pile Score: " + CType(pileScore, String)
                    lblSeepCard1Value.Text = "Pile Value: " + pileValue
                End If
            Case 1
                seepCard2.Image = tempImage
                seepCard2.Text = cardType.ToUpper
                If pileScore <> "" OrElse pileValue <> "" Then
                    lblSeepCard2.Text = "Pile Score: " + CType(pileScore, String)
                    lblSeepCard2Value.Text = "Pile Value: " + pileValue
                End If
            Case 2
                seepCard3.Image = tempImage
                seepCard3.Text = cardType.ToUpper
                If pileScore <> "" OrElse pileValue <> "" Then
                    lblSeepCard3.Text = "Pile Score: " + CType(pileScore, String)
                    lblSeepCard3Value.Text = "Pile Value: " + pileValue
                End If
            Case 3
                seepCard4.Image = tempImage
                seepCard4.Text = cardType.ToUpper
                If pileScore <> "" OrElse pileValue <> "" Then
                    lblSeepCard4.Text = "Pile Score: " + CType(pileScore, String)
                    lblSeepCard4Value.Text = "Pile Value: " + pileValue
                End If
            Case 4
                seepCard5.Image = tempImage
                seepCard5.Text = cardType.ToUpper
                If pileScore <> "" OrElse pileValue <> "" Then
                    lblSeepCard5.Text = "Pile Score: " + CType(pileScore, String)
                    lblSeepCard5Value.Text = "Pile Value: " + pileValue
                End If
            Case 5
                seepCard6.Image = tempImage
                seepCard6.Text = cardType.ToUpper
                If pileScore <> "" OrElse pileValue <> "" Then
                    lblSeepCard6.Text = "Pile Score: " + CType(pileScore, String)
                    lblSeepCard6Value.Text = "Pile Value: " + pileValue
                End If
            Case 6
                seepCard7.Image = tempImage
                seepCard7.Text = cardType.ToUpper
                If pileScore <> "" OrElse pileValue <> "" Then
                    lblSeepCard7.Text = "Pile Score: " + CType(pileScore, String)
                    lblSeepCard7Value.Text = "Pile Value: " + pileValue
                End If
            Case 7
                seepCard8.Image = tempImage
                seepCard8.Text = cardType.ToUpper
                If pileScore <> "" OrElse pileValue <> "" Then
                    lblSeepCard8.Text = "Pile Score: " + CType(pileScore, String)
                    lblSeepCard8Value.Text = "Pile Value: " + pileValue
                End If
        End Select

    End Sub


    Private Sub ResetSeepCards(ByVal index As Integer)
        Select Case index
            Case 0
                seepCard1.Image = Nothing
                seepCard1.Text = ReturnOrientationText(common.Orientation.NoCard)
            Case 1
                seepCard2.Image = Nothing
                seepCard2.Text = ReturnOrientationText(common.Orientation.NoCard)
            Case 2
                seepCard3.Image = Nothing
                seepCard3.Text = ReturnOrientationText(common.Orientation.NoCard)
            Case 3
                seepCard4.Image = Nothing
                seepCard4.Text = ReturnOrientationText(common.Orientation.NoCard)
            Case 4
                seepCard5.Image = Nothing
                seepCard5.Text = ReturnOrientationText(common.Orientation.NoCard)
            Case 5
                seepCard6.Image = Nothing
                seepCard6.Text = ReturnOrientationText(common.Orientation.NoCard)
            Case 6
                seepCard7.Image = Nothing
                seepCard7.Text = ReturnOrientationText(common.Orientation.NoCard)
            Case 7
                seepCard8.Image = Nothing
                seepCard8.Text = ReturnOrientationText(common.Orientation.NoCard)
        End Select
    End Sub
    Private Sub ResetPlayer1Cards(ByVal index As Integer)
        Select Case index
            Case 0
                player1Card1.Image = Nothing
                player1Card1.Text = ReturnOrientationText(common.Orientation.NoCard)
            Case 1
                player1card2.Image = Nothing
                player1card2.Text = ReturnOrientationText(common.Orientation.NoCard)
            Case 2
                player1Card3.Image = Nothing
                player1Card3.Text = ReturnOrientationText(common.Orientation.NoCard)
            Case 3
                player1Card4.Image = Nothing
                player1Card4.Text = ReturnOrientationText(common.Orientation.NoCard)
            Case 4
                Player1Card5.Image = Nothing
                Player1Card5.Text = ReturnOrientationText(common.Orientation.NoCard)
            Case 5
                Player1Card6.Image = Nothing
                Player1Card6.Text = ReturnOrientationText(common.Orientation.NoCard)
            Case 6
                Player1Card7.Image = Nothing
                Player1Card7.Text = ReturnOrientationText(common.Orientation.NoCard)
            Case 7
                Player1Card8.Image = Nothing
                Player1Card8.Text = ReturnOrientationText(common.Orientation.NoCard)
        End Select
    End Sub
    Private Sub ResetPlayer2Cards(ByVal index As Integer)
        Select Case index
            Case 0
                Player2Card1.Image = Nothing
                Player2Card1.Text = ReturnOrientationText(common.Orientation.NoCard)
            Case 1
                player2Card2.Image = Nothing
                player2Card2.Text = ReturnOrientationText(common.Orientation.NoCard)
            Case 2
                player2card3.Image = Nothing
                player2card3.Text = ReturnOrientationText(common.Orientation.NoCard)
            Case 3
                player2Card4.Image = Nothing
                player2Card4.Text = ReturnOrientationText(common.Orientation.NoCard)
            Case 4
                Player2Card5.Image = Nothing
                Player2Card5.Text = ReturnOrientationText(common.Orientation.NoCard)
            Case 5
                Player2Card6.Image = Nothing
                Player2Card6.Text = ReturnOrientationText(common.Orientation.NoCard)
            Case 6
                Player2Card7.Image = Nothing
                Player2Card7.Text = ReturnOrientationText(common.Orientation.NoCard)
            Case 7
                Player2Card8.Image = Nothing
                Player2Card8.Text = ReturnOrientationText(common.Orientation.NoCard)
        End Select
    End Sub
    Private Sub AddSeepCard(ByVal cardType As String, ByVal fileName As String)
        Dim rm As New Resources.ResourceManager("twoPlayerSeep.images", System.Reflection.Assembly.GetExecutingAssembly)
        Dim tempImage As Image = rm.GetObject(fileName)

        For i As Integer = 0 To 7
            Select Case i
                Case 0
                    If seepCard1.Text = "NO CARD" Then
                        seepCard1.Text = cardType.ToUpper
                        seepCard1.Image = tempImage
                        Exit For
                    End If
                Case 1
                    If seepCard2.Text = "NO CARD" Then
                        seepCard2.Text = cardType.ToUpper
                        seepCard2.Image = tempImage
                        Exit For
                    End If
                Case 2
                    If seepCard3.Text = "NO CARD" Then
                        seepCard3.Text = cardType.ToUpper
                        seepCard3.Image = tempImage
                        Exit For
                    End If
                Case 3
                    If seepCard4.Text = "NO CARD" Then
                        seepCard4.Text = cardType.ToUpper
                        seepCard4.Image = tempImage
                        Exit For
                    End If
                Case 4
                    If seepCard5.Text = "NO CARD" Then
                        seepCard5.Text = cardType.ToUpper
                        seepCard5.Image = tempImage
                        Exit For
                    End If
                Case 5
                    If seepCard6.Text = "NO CARD" Then
                        seepCard6.Text = cardType.ToUpper
                        seepCard6.Image = tempImage
                        Exit For
                    End If
                Case 6
                    If seepCard7.Text = "NO CARD" Then
                        seepCard7.Text = cardType.ToUpper
                        seepCard7.Image = tempImage
                        Exit For
                    End If
                Case 7
                    If seepCard8.Text = "NO CARD" Then
                        seepCard8.Text = cardType.ToUpper
                        seepCard8.Image = tempImage
                        Exit For
                    End If
            End Select
        Next
    End Sub
    Private Function ReturnPileID(ByVal cardType As String) As Integer
        Dim pileIndex As Integer = -1
        For i As Integer = 0 To pileID - 1 Step 1
            Dim CT As String
            For j As Integer = 0 To piles(i).Count - 1 Step 1
                CT = ConvertSuit(piles(i).Item(j).Suit) + ConvertFace(piles(i).Item(j).Face)
                If Trim(cardType).ToUpper = Trim(CT).ToUpper Then
                    pileIndex = i
                    Exit For
                End If
            Next j
        Next i
        Return pileIndex
    End Function
    Private Function ReturnPileValue(ByVal pile As Integer) As PileValue

        Dim PileValue As PileValue

        For j As Integer = 0 To piles(pile).Count - 1 Step 1
            PileValue = piles(pile).Item(j).Pile.Value
            Exit For
        Next j

        Return PileValue
    End Function
    Private Function ReturnPileFinal(ByVal pile As Integer) As Boolean

        If piles(pile) Is Nothing Then Return False

        For j As Integer = 0 To piles(pile).Count - 1 Step 1
            Return piles(pile).Item(j).Final
        Next j

        Return False
    End Function
    Private Function pileScore(ByVal pile As Integer) As Integer
        Dim tempPileScore, PileValue As Integer

        For i As Integer = 0 To piles(pile).Count - 1
            tempPileScore = tempPileScore + ConvertScore(piles(pile).Item(i).Face, piles(pile).Item(i).Suit)
        Next
        Return tempPileScore
    End Function
    Private Function GetSamePile(ByVal pileValue As PileValue, ByVal pileIndex As Integer) As Integer
        Dim index As Integer = -1
        Dim length As Integer
        For j As Integer = 0 To pileID - 1 Step 1
            If index <> -1 Then
                Exit For
            Else
                If j <> pileIndex Then
                    length = piles(j).Count
                    For i As Integer = 0 To length - 1 Step 1
                        If piles(j).Item(i).Pile.Value = pileValue Then
                            index = j
                            Exit For
                        End If
                    Next i
                End If
            End If
        Next j
        Return index
    End Function
    Private Function TotalSeepFloorValue() As Integer
        Dim length, value, cardFace As Integer
        value = 0
        length = seepHands.Count
        For i As Integer = length - 1 To 0 Step -1
            cardFace = CType(ConvertFace(seepHands.Item(i).Face), Integer)
            value = value + cardFace
        Next i
        For i As Integer = 0 To pileID - 1 Step 1
            If piles(i).Count > 1 Then
                length = piles(i).Count
                For j As Integer = 0 To length - 1 Step 1
                    cardFace = CType(ConvertFace(piles(i).Item(j).Face), Integer)
                    value = value + cardFace
                Next j
            End If
        Next i
        Return value
    End Function
    Private Function ReturnMyCollectPoints() As Integer
        Dim length, myScore As Integer
        myScore = 0
        If myCollect Is Nothing Then
            Return myScore
        Else
            length = myCollect.Count
            For i As Integer = 0 To length - 1 Step 1
                myScore = myScore + ConvertScore(myCollect.Item(i).Face, myCollect.Item(i).Suit)
            Next i
        End If
        Return myScore

    End Function
    Private Function ReturnYourCollectPoints() As Integer
        Dim length, yourScore As Integer
        yourScore = 0
        If yourCollect Is Nothing Then
            Return yourScore
        Else
            length = yourCollect.Count
            For i As Integer = 0 To length - 1 Step 1
                yourScore = yourScore + ConvertScore(yourCollect.Item(i).Face, yourCollect.Item(i).Suit)
            Next i
        End If
        Return yourScore
    End Function
    Private Function ReturnSeepPoints() As Integer
        Dim length, myScore As Integer
        myScore = 0
        If seepHands Is Nothing Then
            Return myScore
        Else
            length = seepHands.Count
            For i As Integer = 0 To length - 1 Step 1
                myScore = myScore + ConvertScore(seepHands.Item(i).Face, seepHands.Item(i).Suit)
            Next i
        End If
        Return myScore

    End Function
    Private Function ReturnPileValue2(ByVal oldValue As Integer) As Integer
        Dim icardTotal As Integer = oldValue
        If (icardTotal > 13) AndAlso (icardTotal <= 26) Then icardTotal = icardTotal / 2
        If (icardTotal > 26) AndAlso (icardTotal <= 39) Then icardTotal = icardTotal / 3
        If (icardTotal > 39) AndAlso (icardTotal <= 52) Then icardTotal = icardTotal / 4
        If (icardTotal > 52) AndAlso (icardTotal <= 65) Then icardTotal = icardTotal / 5
        If (icardTotal > 65) AndAlso (icardTotal <= 78) Then icardTotal = icardTotal / 6
        If (icardTotal > 78) AndAlso (icardTotal <= 91) Then icardTotal = icardTotal / 7
        If (icardTotal > 91) AndAlso (icardTotal <= 104) Then icardTotal = icardTotal / 8
        If (icardTotal > 104) AndAlso (icardTotal <= 117) Then icardTotal = icardTotal / 9
        If (icardTotal > 117) AndAlso (icardTotal <= 130) Then icardTotal = icardTotal / 10
        Return icardTotal
    End Function
    Private Sub ConvertPileFinal(ByVal index As Integer)
        Dim length = piles(index).Count
        For i As Integer = length - 1 To 0 Step -1
            Dim newCard As Card
            newCard = New Card
            newCard = piles(index).Item(i)
            newCard.Final = True
            piles(index).Remove(piles(index).Item(i))
            piles(index).Insert(piles(index).Count, newCard)
        Next i
    End Sub
    Private Sub SortPiles()


        For i As Integer = 0 To 8 Step 1
            If piles(i) Is Nothing Then
                If i < 8 Then
                    If Not (piles(i + 1) Is Nothing) AndAlso piles(i + 1).Count > 0 Then
                        Dim tempPile As clsHand
                        tempPile = New clsHand
                        tempPile = piles(i + 1)
                        piles(i + 1) = Nothing
                        piles(i) = tempPile
                    End If
                End If
            End If
        Next

        Dim length As Integer = piles.Length

        For i As Integer = 0 To length - 1 Step 1
            If Not (piles(i) Is Nothing) AndAlso piles(i).Count > 0 Then
                Dim inlength As Integer = piles(i).Count
                For j As Integer = inlength - 1 To 0 Step -1
                    Dim tempCard As Card
                    tempCard = New Card
                    tempCard = piles(i).Item(j)
                    Dim tempPileValue As PileValue = tempCard.Pile.Value
                    Dim tempPile As Pile
                    tempPile.pileID = i
                    tempPile.Value = tempPileValue
                    tempCard.Pile = tempPile
                    piles(i).Remove(piles(i).Item(j))
                    piles(i).Insert(piles(i).Count, tempCard)
                Next
            End If
        Next
    End Sub
    Private Function cardExistsInMyHand(ByVal cardType As String, ByVal player As Integer) As Boolean
        Dim length As Integer
        Dim tempCardType As String
        If player = 1 Then
            length = myHands.Count
            For i As Integer = length - 1 To 0 Step -1
                tempCardType = (ConvertSuit(myHands.Item(i).Suit) + ConvertFace(myHands.Item(i).Face))
                If Trim(cardType).ToUpper = Trim(tempCardType).ToUpper Then Return True
            Next
        Else
            length = yourHands.Count
            For i As Integer = length - 1 To 0 Step -1
                tempCardType = (ConvertSuit(yourHands.Item(i).Suit) + ConvertFace(yourHands.Item(i).Face))
                If Trim(cardType).ToUpper = Trim(tempCardType).ToUpper Then Return True
            Next
        End If
        Return False
    End Function
#End Region     ' General Functions

#Region "Seep Validate Functions"
    Private Function ValidateAction(ByRef temp() As String, ByVal seepCmd As Integer, ByVal player As Integer) As Boolean
        Select Case seepCmd

        End Select
        Return False
    End Function

    Private Function pickCardValidates(ByRef temp() As String, ByVal player As Integer) As Integer
        If temp(0).Substring(0, 1) = "E" Then
            Return 2
        End If

        If Not cardExistsInMyHand(temp(0).TrimEnd.TrimStart.ToLower, player) Then
            Return 3
        End If

        Dim playerCard As String
        Dim iPlayerCard, iOtherCardTotal As Integer
        For Each cardInPlay As String In temp
            If playerCard Is Nothing Then
                playerCard = cardInPlay
                iPlayerCard = convertFace(playerCard.TrimEnd.TrimStart)
            Else
                iOtherCardTotal = iOtherCardTotal + convertFace(cardInPlay.TrimEnd.TrimStart)
            End If
        Next
        If player1Moves = 0 AndAlso firstCallNumber <> iPlayerCard Then
            Return 4
        End If

        If (iOtherCardTotal Mod iPlayerCard) Then
            Return 5
        End If

        Return 1

    End Function
    Private Function pileCardValidates(ByRef Temp() As String, ByVal player As Integer) As Integer

        If Temp(0).Substring(0, 1) = "E" Then
            Return 2
        End If

        If Not cardExistsInMyHand(Temp(0).TrimEnd.TrimStart.ToLower, player) Then
            Return 3
        End If


        Dim playerCard As String
        Dim iPlayerCard, iOtherCardTotal, count, iPileValue, length As Integer
        Dim iBiggestCard, iCardTotal, iGreaterThanNine(8) As Integer
        count = 0
        iOtherCardTotal = 0
        iBiggestCard = 0
        For Each cardInPlay As String In Temp
            If playerCard Is Nothing Then
                playerCard = cardInPlay
                iPlayerCard = convertFace(playerCard.TrimEnd.TrimStart)
                If iPlayerCard > 9 Then
                    iGreaterThanNine(count) = iPlayerCard
                    count = count + 1
                End If
            Else
                Dim icardValue As Integer = convertFace(cardInPlay.TrimEnd.TrimStart)
                If icardValue > 9 Then
                    iGreaterThanNine(count) = icardValue
                    count = count + 1
                End If
                iOtherCardTotal = iOtherCardTotal + icardValue
            End If
        Next



        For i As Integer = 0 To iGreaterThanNine.Length - 1 Step 1
            If iGreaterThanNine(i) > 0 Then
                If iGreaterThanNine(i) > iBiggestCard Then
                    iBiggestCard = iGreaterThanNine(i)
                End If
            End If
        Next i

        iPileValue = iOtherCardTotal + iPlayerCard
        iCardTotal = iPileValue
        iPileValue = iPileValue - iBiggestCard

        If iCardTotal > 13 Then
            iCardTotal = ReturnPileValue2(iCardTotal)
        End If
        If (iPileValue <> iBiggestCard) Then
            iPileValue = iPileValue + iBiggestCard
            iBiggestCard = 0
            If iPileValue > 13 Then iPileValue = ReturnPileValue2(iPileValue)
        End If

        If player1Moves = 0 AndAlso firstCallNumber <> iPileValue Then
            Return 4
        ElseIf (iBiggestCard > 0) AndAlso (iPileValue <> iBiggestCard) Then
            Return 7
        End If


        If (iCardTotal < 9) Then
            Return 6
        End If

        If iCardTotal > 13 Then iCardTotal = ReturnPileValue2(iCardTotal)

        Dim tempError As Boolean = True
        If player = 1 Then
            length = myHands.Count
            Dim cardValue As Integer
            Dim cardType As String
            For i As Integer = length - 1 To 0 Step -1
                cardType = (ConvertSuit(myHands.Item(i).Suit) + ConvertFace(myHands.Item(i).Face))
                cardValue = convertFace(cardType.TrimEnd.TrimStart)
                If cardValue = iCardTotal Then
                    tempError = False
                    Exit For
                End If
            Next
        Else
            length = yourHands.Count
            Dim cardValue As Integer
            Dim cardType As String
            For i As Integer = length - 1 To 0 Step -1
                cardType = (ConvertSuit(yourHands.Item(i).Suit) + ConvertFace(yourHands.Item(i).Face))
                cardValue = convertFace(cardType.TrimEnd.TrimStart)
                If cardValue = iCardTotal Then
                    tempError = False
                    Exit For
                End If
            Next
        End If
        If tempError = True Then Return 5

        Return 1

    End Function
    Private Function pickPileValidates(ByRef temp() As String, ByVal player As Integer) As Integer

        If temp(0).Substring(0, 1) = "E" Then
            Return 2
        End If

        If Not cardExistsInMyHand(temp(0).TrimEnd.TrimStart.ToLower, player) Then
            Return 3
        End If

        If player1Moves = 0 Then
            Return 4
        End If

        Dim pileCard As String = temp(temp.Length - 1)
        Dim pileIndex As Integer = -1
        pileIndex = ReturnPileID(pileCard)
        If pileIndex = -1 Then
            Return 5
        End If


        Dim playerCard As String

        Dim iOtherCardTotal, iPlayerCard, iPileTotal, iTotal, length As Integer
        iTotal = 0
        iPileTotal = 0
        iOtherCardTotal = 0
        For Each cardInPlay As String In temp
            If playerCard Is Nothing Then
                playerCard = cardInPlay
                iPlayerCard = convertFace(cardInPlay.TrimEnd.TrimStart)
            Else
                If pileCard.TrimEnd.TrimStart.ToUpper <> cardInPlay.TrimEnd.TrimStart.ToUpper Then
                    iOtherCardTotal = iOtherCardTotal + convertFace(cardInPlay.TrimEnd.TrimStart)
                End If
            End If
        Next

        length = piles(pileIndex).Count
        For i As Integer = length - 1 To 0 Step -1
            Dim cardType As String = (ConvertSuit(piles(pileIndex).Item(i).Suit) + ConvertFace(piles(pileIndex).Item(i).Face))
            iPileTotal = iPileTotal + convertFace(cardType.TrimEnd.TrimStart)
        Next i

        iTotal = iPileTotal + iOtherCardTotal

        If iTotal Mod iPlayerCard Then
            Return 6
        End If

        Return 1

    End Function

    Private Sub btnDeal_Click(sender As Object, e As EventArgs) Handles btnDeal.Click

    End Sub

    Private Function addPileValidates(ByRef temp() As String, ByVal player As Integer) As Integer

        If temp(0).Substring(0, 1) = "E" Then
            Return 2
        End If

        If Not cardExistsInMyHand(temp(0).TrimEnd.TrimStart.ToLower, player) Then
            Return 3
        End If


        Dim playerCard, pileCard As String
        pileCard = temp(temp.Length - 1)
        Dim iPlayerCard, iOtherCardTotal, iCardTotal, count, iPileValue As Integer
        Dim pileIndex, iBiggestCard, iGreaterThanNine(8) As Integer
        count = 0
        iOtherCardTotal = 0
        iBiggestCard = 0
        For Each cardInPlay As String In temp
            If playerCard Is Nothing Then
                playerCard = cardInPlay
                iPlayerCard = convertFace(playerCard.TrimEnd.TrimStart)
                If iPlayerCard > 9 Then
                    iGreaterThanNine(count) = iPlayerCard
                    count = count + 1
                End If
            Else
                If pileCard.TrimEnd.TrimStart.ToUpper = cardInPlay.TrimEnd.TrimStart.ToUpper Then
                    pileIndex = ReturnPileID(pileCard.TrimEnd.TrimStart.ToLower)
                Else
                    Dim icardValue As Integer = convertFace(cardInPlay.TrimEnd.TrimStart)
                    If icardValue > 9 Then
                        iGreaterThanNine(count) = icardValue
                        count = count + 1
                    End If
                    iOtherCardTotal = iOtherCardTotal + icardValue
                End If
            End If
        Next

        If pileIndex <> -1 Then
            Dim pValue As PileValue = ReturnPileValue(pileIndex)
            Dim sValue As String = ConvertPileValue(pValue)
            iPileValue = ConvertPileValue(sValue)
        End If

        For i As Integer = 0 To iGreaterThanNine.Length - 1 Step 1
            If iGreaterThanNine(i) > 0 Then
                If iGreaterThanNine(i) > iBiggestCard Then
                    iBiggestCard = iGreaterThanNine(i)
                End If
            End If
        Next i

        iCardTotal = iOtherCardTotal + iPlayerCard

        'iCardTotal = iCardTotal - iBiggestCard

        If iCardTotal > 13 Then iCardTotal = ReturnPileValue2(iCardTotal)

        If player1Moves = 0 Then
            Return 4
        ElseIf pileIndex = -1 Then
            Return 5
        ElseIf (iCardTotal > 0) AndAlso (iCardTotal <> iPileValue) Then
            Return 6
        ElseIf (iBiggestCard > 0) AndAlso (iCardTotal > 0) AndAlso (iBiggestCard > iPileValue) Then
            Return 7
        Else
            Return 1
        End If
    End Function

    Private Function throwCardValidates(ByRef temp As String, ByVal player As Integer) As Integer


        If temp.Length > 3 Then
            Return 2
        End If

        If Not cardExistsInMyHand(temp.TrimEnd.TrimStart.ToLower, player) Then
            Return 3
        End If

        Dim iPlayerCard As Integer
        iPlayerCard = convertFace(temp.TrimEnd.TrimStart)
        If player1Moves = 0 AndAlso firstCallNumber <> iPlayerCard Then
            Return 4
        End If

        Return 1
    End Function

    Private Function changePileValidates(ByRef temp() As String, ByVal player As Integer) As Integer


        If temp(0).Substring(0, 1) = "E" Then
            Return 2
        End If

        If Not cardExistsInMyHand(temp(0).TrimEnd.TrimStart.ToLower, player) Then
            Return 3
        End If

        If player1Moves = 0 Then
            Return 4
        End If

        If temp.Length > 2 Then
            Return 5
        End If

        Dim iPlayerCard As Integer
        iPlayerCard = convertFace(temp(0).TrimEnd.TrimStart)

        If iPlayerCard > 4 Then
            Return 6
        End If

        Dim pileCard As String = Trim(temp(1)).ToLower
        Dim pileIndex As Integer
        pileIndex = ReturnPileID(pileCard.TrimEnd.TrimStart.ToLower)

        If pileIndex = -1 Then
            Return 7
        End If

        If ReturnPileFinal(pileIndex) Then
            Return 8
        End If

        Dim pValue As PileValue = ReturnPileValue(pileIndex)
        Dim sValue As String = ConvertPileValue(pValue)
        Dim iPileValue As Integer = ConvertPileValue(sValue)

        If iPileValue + iPlayerCard > 13 Then
            Return 9
        End If


        Return 1
    End Function
    Private Function seepPointValidates(ByRef temp() As String, ByVal player As Integer) As Integer


        If temp(0).Substring(0, 1) = "E" Then
            Return 2
        End If

        If Not cardExistsInMyHand(temp(0).TrimEnd.TrimStart.ToLower, player) Then
            Return 3
        End If

        Dim iPlayerCard As Integer
        iPlayerCard = convertFace(temp(0).TrimEnd.TrimStart)
        If player1Moves = 0 AndAlso firstCallNumber <> iPlayerCard Then
            Return 4
        End If

        If temp.Length > 1 Then
            Return 5
        End If

        If (pileID - 1) > 1 Then
            Return 6
        End If

        Dim length As Integer = seepHands.Count

        If ReturnPileFinal(0) And length > 1 Then
            Return 7
        End If


        Dim SeepFloorValue As Integer
        SeepFloorValue = TotalSeepFloorValue()
        Dim playerCardValue As Integer = CType(temp(0).Substring(1, temp(0).Length - 1), Integer)

        Dim modulus As Integer = SeepFloorValue Mod playerCardValue
        If (SeepFloorValue Mod playerCardValue) OrElse (pileID > 1) Then
            Return 8
        End If


        Return 1
    End Function

#End Region      ' Seep Validate Functions
End Class