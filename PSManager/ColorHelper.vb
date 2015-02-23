Module ColorHelper
    Public LightGreen As Color = Color.FromArgb(0, 201, 100)
    Public DarkGreen As Color = Color.FromArgb(0,165,73)

    Public LightYellow As Color = Color.FromArgb(246, 220, 67)
    Public DarkYellow As Color = Color.FromArgb(243, 202, 45)

    Public LightOrange As Color = Color.FromArgb(246, 147, 37)
    Public DarkOrange As Color = Color.FromArgb(242, 107, 19)

    Public LightRed As Color = Color.FromArgb(242, 45, 46)
    Public DarkRed As Color = Color.FromArgb(177, 23, 22)
    
    Public LightPink As Color = Color.FromArgb(243, 74, 169)
    Public DarkPink As Color = Color.FromArgb(236, 61, 128)

    Public LightPurple As Color = Color.FromArgb(142, 65, 180)
    Public DarkPurple As Color = Color.FromArgb(100, 36, 136)

    Public LightBlue As Color = Color.FromArgb(48, 113, 199)
    Public DarkBlue As Color = Color.FromArgb(30, 80, 160)

    Public LightGrey As Color = Color.FromArgb(225, 225, 225)
    Public MediumLightGrey As Color = Color.FromArgb(175, 175, 175)
    Public MediumDarkGrey As Color = Color.FromArgb(197, 197, 197)
    Public DarkGrey As Color = Color.FromArgb(75, 80, 87)

    Public LightTurquoise As Color = Color.FromArgb(9, 184, 161)
    Public DarkTurquoise As Color = Color.FromArgb(35, 126, 118)

    Public Enum ColorPallet
        Color1
        Color2
        Color3
        Color4
        Color5
        Color6
        Color7
        Color8
        Color9
        Color10
        Color11
        Color12
        Color13
        Color14
        Color15
        Color16
        Color17
        Color18
        Color19
        Color20
    End Enum

    Private _color1 As Color
    Private _color2 As Color
    Private _color3 As Color
    Private _color4 As Color
    Private _color5 As Color
    Private _foreColor1 As Color
    Private _foreColor2 As Color
    Private _foreColor3 As Color
    Private _foreColor4 As Color
    Private _foreColor5 As Color
    Public ReadOnly Property Color1() As Color
        Get
            Return _color1
        End Get
    End Property
    Public ReadOnly Property Color2() As Color
        Get
            Return _color2
        End Get
    End Property
    Public ReadOnly Property Color3() As Color
        Get
            Return _color3
        End Get
    End Property
    Public ReadOnly Property Color4() As Color
        Get
            Return _color4
        End Get
    End Property
    Public ReadOnly Property Color5() As Color
        Get
            Return _color5
        End Get
    End Property
    Public ReadOnly Property ForeColor1() As Color
        Get
            Return _foreColor1
        End Get
    End Property
    Public ReadOnly Property ForeColor2() As Color
        Get
            Return _foreColor2
        End Get
    End Property
    Public ReadOnly Property ForeColor3() As Color
        Get
            Return _foreColor3
        End Get
    End Property
    Public ReadOnly Property ForeColor4() As Color
        Get
            Return _foreColor4
        End Get
    End Property
    Public ReadOnly Property ForeColor5() As Color
        Get
            Return _foreColor5
        End Get
    End Property

    Private _count As Integer = 1
    Public Sub SetNextPallete()
        Select Case _count
            Case 1
                SetColor(ColorPallet.Color1)
                _count += 1
            Case 2
                SetColor(ColorPallet.Color2)
                _count += 1
            Case 3
                SetColor(ColorPallet.Color3)
                _count += 1
            Case 4
                SetColor(ColorPallet.Color4)
                _count += 1
            Case 5
                SetColor(ColorPallet.Color5)
                _count += 1
            Case 6
                SetColor(ColorPallet.Color6)
                _count += 1
            Case 7
                SetColor(ColorPallet.Color7)
                _count += 1
            Case 8
                SetColor(ColorPallet.Color8)
                _count += 1
            Case 9
                SetColor(ColorPallet.Color9)
                _count += 1
            Case 10
                SetColor(ColorPallet.Color10)
                _count += 1
            Case 11
                SetColor(ColorPallet.Color11)
                _count += 1
            Case 12
                SetColor(ColorPallet.Color12)
                _count += 1
            Case 13
                SetColor(ColorPallet.Color13)
                _count += 1
            Case 14
                SetColor(ColorPallet.Color14)
                _count += 1
            Case 15
                SetColor(ColorPallet.Color15)
                _count += 1
            Case 16
                SetColor(ColorPallet.Color16)
                _count += 1
            Case 17
                SetColor(ColorPallet.Color17)
                _count += 1
            Case 18
                SetColor(ColorPallet.Color18)
                _count += 1
            Case 19
                SetColor(ColorPallet.Color19)
                _count += 1
            Case 20
                SetColor(ColorPallet.Color20)
                _count = 1
        End Select
    End Sub

    Public Sub SetColor(pallete As ColorPallet)

        Select Case pallete
            Case ColorPallet.Color1
                _color1 = Color.FromArgb(241, 67, 63)
                _color2 = Color.FromArgb(247, 233, 103)
                _color3 = Color.FromArgb(169, 207, 84)
                _color4 = Color.FromArgb(112, 183, 186)
                _color5 = Color.FromArgb(61, 76, 83)
                '_foreColor = Color.Black
            Case ColorPallet.Color2
                _color1 = Color.FromArgb(204, 153, 0)
                _color2 = Color.FromArgb(255, 222, 0)
                _color3 = Color.FromArgb(0, 102, 102)
                _color4 = Color.FromArgb(0, 102, 153)
                _color5 = Color.FromArgb(0, 0, 102)
                '_foreColor = Color.Black
            Case ColorPallet.Color3
                _color1 = Color.FromArgb(0, 158, 206)
                _color2 = Color.FromArgb(255, 158, 0)
                _color3 = Color.FromArgb(247, 215, 8)
                _color4 = Color.FromArgb(206, 0, 0)
                _color5 = Color.FromArgb(156, 207, 49)
                '_foreColor = Color.Black
            Case ColorPallet.Color4
                _color1 = Color.FromArgb(239, 89, 123)
                _color2 = Color.FromArgb(255, 109, 49)
                _color3 = Color.FromArgb(115, 182, 107)
                _color4 = Color.FromArgb(255, 203, 24)
                _color5 = Color.FromArgb(41, 162, 198)
                '_foreColor = Color.Black
            Case ColorPallet.Color5
                _color1 = Color.FromArgb(64, 87, 116)
                _color2 = Color.FromArgb(103, 135, 176)
                _color3 = Color.FromArgb(177, 177, 123)
                _color4 = Color.FromArgb(205, 102, 7)
                _color5 = Color.FromArgb(246, 160, 61)
                '_foreColor = Color.Black
            Case ColorPallet.Color6
                _color1 = Color.FromArgb(200, 96, 0)
                _color2 = Color.FromArgb(214, 136, 64)
                _color3 = Color.FromArgb(114, 146, 63)
                _color4 = Color.FromArgb(70, 116, 8)
                _color5 = Color.FromArgb(64, 64, 64)
                '_foreColor = Color.Black
            Case ColorPallet.Color7
                _color1 = Color.FromArgb(33, 50, 64)
                _color2 = Color.FromArgb(144, 174, 198)
                _color3 = Color.FromArgb(16, 200, 205)
                _color4 = Color.FromArgb(236, 21, 89)
                _color5 = Color.FromArgb(250, 249, 60)
                '_foreColor = Color.Black
            Case ColorPallet.Color8
                _color1 = Color.FromArgb(255, 194, 0)
                _color2 = Color.FromArgb(255, 91, 0)
                _color3 = Color.FromArgb(184, 0, 40)
                _color4 = Color.FromArgb(132, 0, 46)
                _color5 = Color.FromArgb(74, 192, 242)
                '_foreColor = Color.Black
            Case ColorPallet.Color9
                _color1 = Color.FromArgb(254, 150, 1)
                _color2 = Color.FromArgb(204, 0, 99)
                _color3 = Color.FromArgb(134, 38, 155)
                _color4 = Color.FromArgb(0, 210, 241)
                _color5 = Color.FromArgb(0, 183, 150)
                '_foreColor = Color.Black
            Case ColorPallet.Color10
                _color1 = Color.FromArgb(232, 160, 184)
                _color2 = Color.FromArgb(255, 195, 0)
                _color3 = Color.FromArgb(188, 207, 61)
                _color4 = Color.FromArgb(2, 201, 201)
                _color5 = Color.FromArgb(51, 51, 51)
                '_foreColor = Color.Black
            Case ColorPallet.Color11
                _color1 = Color.FromArgb(93, 184, 157)
                _color2 = Color.FromArgb(0, 112, 52)
                _color3 = Color.FromArgb(140, 133, 53)
                _color4 = Color.FromArgb(255, 202, 0)
                _color5 = Color.FromArgb(242, 101, 71)
                '_foreColor = Color.Black
            Case ColorPallet.Color12
                _color1 = Color.FromArgb(255, 151, 0)
                _color2 = Color.FromArgb(204, 102, 0)
                _color3 = Color.FromArgb(153, 153, 0)
                _color4 = Color.FromArgb(51, 51, 0)
                _color5 = Color.FromArgb(102, 0, 102)
                '_foreColor = Color.Black
            Case ColorPallet.Color13
                _color1 = Color.FromArgb(40, 190, 155)
                _color2 = Color.FromArgb(146, 220, 224)
                _color3 = Color.FromArgb(96, 145, 148)
                _color4 = Color.FromArgb(239, 153, 80)
                _color5 = Color.FromArgb(215, 156, 140)
                '_foreColor = Color.Black
            Case ColorPallet.Color14
                _color1 = Color.FromArgb(89, 30, 35)
                _color2 = Color.FromArgb(217, 78, 103)
                _color3 = Color.FromArgb(242, 216, 167)
                _color4 = Color.FromArgb(166, 133, 114)
                _color5 = Color.FromArgb(115, 80, 60)
                '_foreColor = Color.Black
            Case ColorPallet.Color15
                _color1 = Color.FromArgb(241, 125, 128)
                _color2 = Color.FromArgb(115, 116, 149)
                _color3 = Color.FromArgb(104, 168, 173)
                _color4 = Color.FromArgb(196, 212, 175)
                _color5 = Color.FromArgb(108, 134, 114)
                '_foreColor = Color.Black
            Case ColorPallet.Color16
                _color1 = Color.FromArgb(131, 170, 48)
                _color2 = Color.FromArgb(20, 153, 211)
                _color3 = Color.FromArgb(77, 102, 132)
                _color4 = Color.FromArgb(61, 61, 61)
                _color5 = Color.FromArgb(231, 71, 0)
                '_foreColor = Color.Black
            Case ColorPallet.Color17
                _color1 = Color.FromArgb(242, 103, 31)
                _color2 = Color.FromArgb(201, 27, 38)
                _color3 = Color.FromArgb(156, 15, 95)
                _color4 = Color.FromArgb(96, 4, 122)
                _color5 = Color.FromArgb(22, 10, 71)
                '_foreColor = Color.Black
            Case ColorPallet.Color18
                _color1 = Color.FromArgb(66, 152, 181)
                _color2 = Color.FromArgb(173, 196, 204)
                _color3 = Color.FromArgb(146, 176, 106)
                _color4 = Color.FromArgb(225, 157, 41)
                _color5 = Color.FromArgb(221, 95, 50)
                '_foreColor = Color.Black
            Case ColorPallet.Color19
                _color1 = Color.FromArgb(177, 235, 0)
                _color2 = Color.FromArgb(83, 187, 244)
                _color3 = Color.FromArgb(255, 133, 203)
                _color4 = Color.FromArgb(255, 67, 46)
                _color5 = Color.FromArgb(255, 172, 0)
                '_foreColor = Color.Black
            Case ColorPallet.Color20
                _color1 = Color.FromArgb(219, 51, 64)
                _color2 = Color.FromArgb(232, 183, 26)
                _color3 = Color.FromArgb(247, 234, 200)
                _color4 = Color.FromArgb(31, 218, 154)
                _color5 = Color.FromArgb(40, 171, 227)
                ''_foreColor = Color.Black
        End Select
    End Sub
End Module
