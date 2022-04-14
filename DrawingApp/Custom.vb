Public Class Custom
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
            Dim points(2) As Point
            points(0) = New Point(m_a.X, m_a.Y + 75)
            points(1) = New Point(m_a.X + 50, m_a.Y)
            points(2) = New Point(m_a.X - 50, m_a.Y)
            xOffset += xSpeed
            yOffset += ySpeed
            If fill Then
                Dim lingrBrush As Drawing.Drawing2D.LinearGradientBrush
                lingrBrush = New Drawing.Drawing2D.LinearGradientBrush(
                                New Point(0, 10),
                                New Point(20, 10),
                                color1,
                                color2)

                g.FillPolygon(lingrBrush, points)
                g.FillPie(lingrBrush, m_a.X - 50, m_a.Y - 25, 100, 50, 0, -180)
            Else

                g.DrawPolygon(Pen, points)
                g.DrawArc(Pen, m_a.X - 50, m_a.Y - 25, 100, 50, 0, -180)
            End If


        End Using

    End Sub
End Class
