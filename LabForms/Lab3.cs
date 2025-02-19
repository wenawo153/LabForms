namespace LabForms
{
    public partial class Lab3 : Form
    {
        private Bitmap bitmap;
        private Graphics graphics;

        private int x;
        private int y;

        private Quadrilateral? quadrilateral;

        private readonly List<Color> colors = [
            Color.Black,
            Color.AliceBlue,
            Color.Brown,
            Color.CadetBlue,
            Color.DarkOrchid,
            Color.Red
            ];
        private Color selectColor;

        public Lab3()
        {
            InitializeComponent();

            x = pictureBox1.Width;
            y = pictureBox1.Height;
            bitmap = new(x, y);
            pictureBox1.Image = bitmap;

            graphics = Graphics.FromImage(bitmap);

            InitForm();
        }

        private Quadrilateral? InitQuadrilateral()
        {
            try
            {
                var x0 = int.Parse(X0box.Text);
                var x1 = int.Parse(X1box.Text);
                var x2 = int.Parse(X2box.Text);
                var x3 = int.Parse(X3box.Text);

                var y0 = int.Parse(Y0box.Text);
                var y1 = int.Parse(Y1box.Text);
                var y2 = int.Parse(Y2box.Text);
                var y3 = int.Parse(Y3box.Text);

                if (selectColor == Color.Black)
                {
                    Quadrilateral quadrilateral = new(x0, y0, x1, y1, x2, y2, x3, y3);
                    return quadrilateral;
                }
                else
                {
                    ColorQuadrilateral colorQuadrilateral = new(selectColor, x0, y0, x1, y1, x2, y2, x3, y3);
                    return colorQuadrilateral;
                }
            }
            catch
            {
                return null;
            }

        }

        private void InitForm()
        {
            X0box.Text = "0";
            X1box.Text = "0";
            X2box.Text = "0";
            X3box.Text = "0";

            Y0box.Text = "0";
            Y1box.Text = "0";
            Y2box.Text = "0";
            Y3box.Text = "0";

            selectColor = colors.First();
            ColorLabel.Text = selectColor.Name;
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);

            quadrilateral = InitQuadrilateral();
            if (quadrilateral == null) return;

            if (quadrilateral is ColorQuadrilateral colorQuadrilateral)
            {
                colorQuadrilateral.Draw(graphics);
                Refresh();
                return;
            }

            quadrilateral.Draw(graphics);
            Refresh();
        }

        private void SwithColor_Click(object sender, EventArgs e)
        {
            var index = colors.IndexOf(selectColor) + 1;
            if (index >= colors.Count) index = 0;
            Color newColor = colors[index];

            ColorLabel.Text = newColor.Name;
            selectColor = newColor;
            Refresh();
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            if (quadrilateral != null)
                SquareLabel.Text = quadrilateral.Square().ToString();
        }

        private void PerimeterButton_Click(object sender, EventArgs e)
        {
            if (quadrilateral != null)
                PerimeterLaber.Text = quadrilateral.Perimeter().ToString();
        }
    }

    public interface IShapeFormuls
    {
        double Square();
        double Perimeter();
    }

    public interface IDraw
    {
        void Draw(Graphics graphics);
    }

    public abstract class Shape : IShapeFormuls, IDraw
    {
        public string Name { get; set; } = string.Empty;

        public CordsPair Cords0 { get; set; } = new();

        public abstract double Square();

        public abstract double Perimeter();

        public abstract void Draw(Graphics graphics);

        public Shape() { }

        public Shape(string name, int x, int y)
        {
            Name = name;
            Cords0 = new()
            {
                X = x,
                Y = y
            };
        }
    }

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

            var diag = Hypotenuse(Cords0, Cords2);

            var p1 = (a + b + diag) / 2;
            var p2 = (c + d + diag) / 2;

            return Math.Round(Math.Sqrt(p1 * (p1 - a) * (p1 - b) * (p1 - c))
                 + Math.Sqrt(p2 * (p2 - a) * (p2 - b) * (p2 - c)), 4);
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

    public struct CordsPair(int x, int y)
    {
        public int X { get; set; } = x;
        public int Y { get; set; } = y;
    }
}