Public Class Ngon
    Public Property Pen As Pen
    Public Property Sides As Integer
    Public Property Radius As Integer
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
        Dim points(Sides - 1) As Point

        For index = 0 To Sides - 1
            Dim X As Integer
            Dim Y As Integer

            X = Math.Cos(index * 2 * Math.PI / Sides) * Radius
            Y = Math.Sin(index * 2 * Math.PI / Sides) * Radius
            points(index) = New Point(m_a.X + X, m_a.Y + Y)
        Next
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

                g.FillPolygon(lingrBrush, points)
            Else

                g.DrawPolygon(Pen, points)
            End If

        End Using

    End Sub
End Class
