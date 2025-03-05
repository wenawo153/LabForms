using System.Security.Cryptography;

namespace LabForms;

public partial class Lab1Form : Form
{
    private readonly Bitmap bitmap;
    private readonly Graphics graphics;

    private int x;
    private int y;

    public Lab1Form()
    {
        InitializeComponent();

        x = pictureBox1.Width;
        y = pictureBox1.Height;

        bitmap = new(x, y);
        pictureBox1.Image = bitmap;

        graphics = Graphics.FromImage(bitmap);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(textBox1.Text, out int sectorsCount))
            return;

        graphics.Clear(Color.White);

        int sectorsSum = 0;
        List<int> sectors = [];
        float ratio = 0;
        var rentangle = new Rectangle(5, 5, x - 10, y - 10);

        for (int i = 0; i < sectorsCount; i++)
        {
            int rnd = RandomNumberGenerator.GetInt32(10, 100);
            sectors.Add(rnd);

            sectorsSum += rnd;
        }

        ratio = 360f / sectorsSum;

        var conturPen = new Pen(Color.Black, 4);
        graphics.DrawPie(conturPen, rentangle, 0, 360);

        int color = 0;
        float lastAngle = 0;
        foreach (int sector in sectors)
        {
            color++;
            if (color == 8) color = 0;

            float angle = sector * ratio;
            graphics.FillPie(GetRandBrush(), rentangle, lastAngle, angle);
            lastAngle += angle;
        }

        Refresh();
    }

    private static Brush GetRandBrush()
    {
        int r = RandomNumberGenerator.GetInt32(0, 256);
        int g = RandomNumberGenerator.GetInt32(0, 256);
        int b = RandomNumberGenerator.GetInt32(0, 256);

        var color = Color.FromArgb(r, g, b);

        return new SolidBrush(color);
    }
}
