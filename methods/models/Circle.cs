

namespace methods.models;
internal class Circle
{
    public double Radius { get; set; }

    public double Area { get => Math.PI * Radius * Radius; }

    public double Length { get => 2 * Math.PI * Radius; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Radius: {Radius}, Area: {Area}, Length: {Length}");
    }
}
