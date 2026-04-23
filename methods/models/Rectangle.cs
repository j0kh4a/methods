

namespace methods.models;

internal class Rectangle 
{
    public double Height { get; set; }
    public double Width { get; set; }

    public double Area { get => Height * Width; }

    public double Perimeter { get => 2 * (Height + Width); }

    public void DisplayInfo()
    {
        Console.WriteLine($"Height: {Height}, Width: {Width}, Area: {Area}, Perimeter: {Perimeter}");
    }
}

