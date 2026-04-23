

namespace methods.models;
internal class Dog
{
    public string Name { get; set; }

    public string Breed { get; set; }

    public Dog(string name, string breed)
    {
        Name = name;
        Breed = breed;
    }

    public void DogInfo()
    {
        Console.WriteLine($"Dog Name: {Name}, Breed: {Breed}");
    }
}

