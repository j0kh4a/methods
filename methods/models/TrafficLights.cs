

namespace methods.models;

internal class TrafficLight
{
    public string Color { get; set; }

    public double Duration { get; set; }

    public void ChangeColor()
    {
        if (Color == "Red" || Color == "red")
        {
            Color = "Green";

        }
        else if (Color == "Green" || Color == "green")
        {
            Color = "Yellow";

        }
        else if (Color == "Yellow" || Color == "yellow")
        {
            Color = "Red";
        }
        else
        {
            Console.WriteLine("Invalid color. Please enter Red, Yellow, or Green.");
            return;
        }
        Console.WriteLine(Color);
    }

}
