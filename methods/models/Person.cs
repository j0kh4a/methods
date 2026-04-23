
namespace methods.models;
internal class Person
{
    public string Name { get; set; }

    public int Age { get; set; }

    public void AgeName()
    {
        Console.WriteLine($"age: {Age} name: {Name}");
    }

}
