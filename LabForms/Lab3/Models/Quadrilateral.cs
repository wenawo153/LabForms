namespace LabForms.Lab3.Models;

public class Quadrilateral : Shape
{
    public CordsPair Cords1 { get; set; } = new();
    public CordsPair Cords2 { get; set; } = new();
    public CordsPair Cords3 { get; set; } = new();

    public Quadrilateral(
        int x0, int y0,
        int x1, int y1,
        int x2, int y2,
        int x3, int y3)
    {
        Cords0 = new(x0, y0);
        Cords1 = new(x1, y1);
        Cords2 = new(x2, y2);
        Cords3 = new(x3, y3);
    }

    public Quadrilateral(
        CordsPair cords0,
        CordsPair cords1,
        CordsPair cords2,
        CordsPair cords3)
    {
        Cords0 = cords0;
        Cords1 = cords1;
        Cords2 = cords2;
        Cords3 = cords3;
    }

    public override double Square()
    {
        var a = Hypotenuse(Cords0, Cords1);
        var b = Hypotenuse(Cords1, Cords2);
        var c = Hypotenuse(Cords2, Cords3);
        var d = Hypotenuse(Cords3, Cords0);

        var p = Perimeter() / 2;

        return Math.Round(Math.Sqrt((p - a) * (p - b) * (p - c) * (p - d)), 4);
    }

    public override double Perimeter()
    {
        return Hypotenuse(Cords0, Cords1)
                + Hypotenuse(Cords1, Cords2)
                + Hypotenuse(Cords2, Cords3)
                + Hypotenuse(Cords3, Cords0);
    }

    public static double Hypotenuse(CordsPair cords1, CordsPair cords2)
    {
        int x = Math.Abs(cords1.X - cords2.X);
        int y = Math.Abs(cords1.Y - cords2.Y);

        return (int)(Math.Sqrt(x * x + y * y));
    }

    public override void Draw(Graphics graphics)
    {
        graphics.DrawPolygon(
            new Pen(new SolidBrush(Color.Black)),
            [
                new Point(Cords0.X, Cords0.Y),
                    new Point(Cords1.X, Cords1.Y),
                    new Point(Cords2.X, Cords2.Y),
                    new Point(Cords3.X, Cords3.Y)
            ]);
    }
}
