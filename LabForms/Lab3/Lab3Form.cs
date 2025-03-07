﻿using LabForms.Lab3.Models;

namespace LabForms
{
    public partial class Lab3Form : Form
    {
        private readonly Bitmap bitmap;
        private readonly Graphics graphics;

        private int x;
        private int y;

        private Quadrilateral? quadrilateral;

        private readonly List<Color> colors = [
            Color.Black,
            Color.AliceBlue,
            Color.Brown,
            Color.CadetBlue,
            Color.DarkOrchid,
            Color.Red,
            Color.Green,
            Color.Yellow,
            Color.SandyBrown,
            ];
        private Color selectColor;

        public Lab3Form()
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
                var x0 = ParseAndCheckBoxX(X0box.Text);
                var x1 = ParseAndCheckBoxX(X1box.Text);
                var x2 = ParseAndCheckBoxX(X2box.Text);
                var x3 = ParseAndCheckBoxX(X3box.Text);

                var y0 = ParseAndCheckBoxY(Y0box.Text);
                var y1 = ParseAndCheckBoxY(Y1box.Text);
                var y2 = ParseAndCheckBoxY(Y2box.Text);
                var y3 = ParseAndCheckBoxY(Y3box.Text);

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

        private int ParseAndCheckBoxX(string box)
        {
            try
            {
                var x = int.Parse(box);

                if (x >= 1 && x <= this.x - 1)
                {
                    return x;
                }
                throw new Exception();
            }
            catch (ArgumentException)
            {
                throw new Exception();
            }
        }
        private int ParseAndCheckBoxY(string box)
        {
            try
            {
                var x = int.Parse(box);

                if (x >= 1 && x <= this.y - 1)
                {
                    return x;
                }
                throw new Exception();
            }
            catch (ArgumentException)
            {
                throw new Exception();
            }
        }

        private void InitForm()
        {
            X0box.Text = "1";
            X1box.Text = "1";
            X2box.Text = "1";
            X3box.Text = "1";

            Y0box.Text = "1";
            Y1box.Text = "1";
            Y2box.Text = "1";
            Y3box.Text = "1";

            selectColor = colors.First();
            colors.ForEach(_ => comboBox1.Items.Add(_));
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);

            quadrilateral = InitQuadrilateral();
            if (quadrilateral == null) 
            {
                MessageBox.Show("Проверьте правильность введённых координат, " +
                    $"а также удостоверьтесь, что они лежат в интервале 1<=x<={this.x - 1} и 1<=y<={this.y - 1}",
                    "Ошибка ввода!");
                return;
            }

            if (quadrilateral is ColorQuadrilateral colorQuadrilateral)
            {
                colorQuadrilateral.Draw(graphics);
                Refresh();
                return;
            }

            quadrilateral.Draw(graphics);
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

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectColor = (Color)comboBox1.SelectedItem!;
        }
    }
}