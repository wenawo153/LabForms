using LabForms.Lab3.Interfaces;

namespace LabForms.Lab3.Models;

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
