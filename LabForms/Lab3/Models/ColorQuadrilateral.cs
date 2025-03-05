namespace LabForms.Lab3.Models;

public class ColorQuadrilateral : Quadrilateral
{
    public Color Color { get; set; }

    public ColorQuadrilateral(
        Color color,
        int x0, int y0,
        int x1, int y1,
        int x2, int y2,
        int x3, int y3) : base(x0, y0, x1, y1, x2, y2, x3, y3)
    {
        Color = color;
    }

    public ColorQuadrilateral(
        Color color,
        CordsPair cords0,
        CordsPair cords1,
        CordsPair cords2,
        CordsPair cords3) : base(cords0, cords1, cords2, cords3)
    {
        Color = color;
    }

    public override void Draw(Graphics graphics)
    {
        graphics.FillPolygon(
            new SolidBrush(Color),
            [
                new Point(Cords0.X, Cords0.Y),
                new Point(Cords1.X, Cords1.Y),
                new Point(Cords2.X, Cords2.Y),
                new Point(Cords3.X, Cords3.Y)
            ]);
    }
}
