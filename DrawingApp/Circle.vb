Public Class Circle
    Public Property Pen As Pen
    Public Property W As Integer
    Public Property H As Integer
    Public Property fill As Boolean
    Public Property color1 As Color
    Public Property color2 As Color
    Public Property xSpeed As Integer
    Public Property ySpeed As Integer
    Dim xOffset As Integer
    Dim yOffset As Integer
    Dim m_image As Image
    Dim m_a As Point
    Dim m_b As Point

    Public Sub New(i As Image, a As Point, b As Point)
        Pen = Pens.Red
        m_image = i
        m_a = a
        m_b = b
    End Sub
    Public Sub Draw()
        Using g As Graphics = Graphics.FromImage(m_image)
            xOffset += xSpeed
            yOffset += ySpeed
            If fill Then
                Dim lingrBrush As Drawing.Drawing2D.LinearGradientBrush
                lingrBrush = New Drawing.Drawing2D.LinearGradientBrush(
                                New Point(0, 10),
                                New Point(20, 10),
                                color1,
                                color2)

                g.FillEllipse(lingrBrush, m_a.X + xOffset, m_a.Y + yOffset, m_b.X + xOffset, m_b.Y + yOffset)
            Else
                g.DrawEllipse(Pen, m_a.X + xOffset, m_a.Y + yOffset, m_b.X + xOffset, m_b.Y + yOffset)
            End If

        End Using

    End Sub
End Class
