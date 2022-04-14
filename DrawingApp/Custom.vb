Public Class Custom
    Public Property Pen As Pen
    Public Property W As Integer
    Public Property H As Integer


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
            g.DrawPolygon(Pen, points)

            g.DrawArc(Pen, m_a.X - 50, m_a.Y - 25, 100, 50, 0, -180)

        End Using

    End Sub
End Class
