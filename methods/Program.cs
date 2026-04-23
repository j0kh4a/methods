
//pirveli .. 1
using methods.models;


Person person = new Person();
Console.Write("Enter Age: ");
person.Age = int.Parse(Console.ReadLine()!);
Console.Write("Enter Name:");
person.Name = Console.ReadLine()!;

Console.WriteLine();
person.AgeName();

// meoree 2
Dog dog = new Dog("Rex", "German Shepherd");

Console.WriteLine();
dog.DogInfo();
Console.Write("Enter new dog name: ");
dog.Name = Console.ReadLine()!;
Console.Write("Enter new Breed of dog:");
dog.Breed = Console.ReadLine()!;
Console.WriteLine();
dog.DogInfo();


// measme 3
Rectangle rectangle = new Rectangle();
Console.Write("Enter Height: ");
rectangle.Height = double.Parse(Console.ReadLine()!);
Console.Write("Enter Width: ");
rectangle.Width = double.Parse(Console.ReadLine()!);
Console.WriteLine();
rectangle.DisplayInfo();

// meotxe444444

Circle circle = new Circle();
Console.Write("Enter Radius: ");
circle.Radius = double.Parse(Console.ReadLine()!);
Console.WriteLine();
circle.DisplayInfo();

//mexute 555
Library library = new Library();


for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"\nBook {i + 1}");

    Console.Write("Enter title: ");
    string title = Console.ReadLine()!;

    Console.Write("Enter author: ");
    string author = Console.ReadLine()!;

    Console.Write("Enter ISBN: ");
    string isbn = Console.ReadLine()!;

    library.Add(new Book(title, author, isbn));
}

Console.WriteLine("\nAll books:");
library.Show();


Console.Write("\nEnter ISBN to delete: ");
string deleteIsbn = Console.ReadLine()!;
library.Remove(deleteIsbn);

Console.WriteLine("\nAfter delete:");
library.Show();

// meeqvse 6666

Emploey emploey = new Emploey();
Console.Write("Enter Salary: ");
emploey.Salary = double.Parse(Console.ReadLine()!);
Console.Write("Enter Job Title: ");
emploey.JobTitle = Console.ReadLine()!;
Console.Write("Enter Name: ");
emploey.Name = Console.ReadLine()!;

Console.WriteLine();
emploey.DisplayInfo();
Console.Write("Enter new Salary: ");
double newSalary = double.Parse(Console.ReadLine()!);
emploey.ChangeJob(newSalary);
Console.WriteLine();
emploey.DisplayInfo();

// mesvide 777777

Bank bank = new Bank();


for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"\nAccount {i + 1}");

    Console.Write("Enter name: ");
    string name = Console.ReadLine()!;

    Console.Write("Enter account number: ");
    string accNum = Console.ReadLine()!;

    Console.Write("Enter balance: ");
    double balance = double.Parse(Console.ReadLine()!);

    bank.AddAccount(new Account(name, accNum, balance));
}

Console.WriteLine("\nAll accounts:");
bank.ShowAccounts();

// Deposit
Console.Write("\nEnter account number for deposit: ");
string depAcc = Console.ReadLine()!;
Console.Write("Enter amount: ");
double depAmount = double.Parse(Console.ReadLine()!);
bank.Deposit(depAcc, depAmount);

// Withdraw
Console.Write("\nEnter account number for withdraw: ");
string wdAcc = Console.ReadLine()!;
Console.Write("Enter amount: ");
double wdAmount = double.Parse(Console.ReadLine()!);
bank.Withdraw(wdAcc, wdAmount);

Console.WriteLine("\nAfter operations:");
bank.ShowAccounts();

// Remove
Console.Write("\nEnter account number to delete: ");
string delAcc = Console.ReadLine()!;
bank.RemoveAccount(delAcc);

Console.WriteLine("\nAfter delete:");
bank.ShowAccounts();

// mervee 888888888888888888&&&&&&&&&&&&&&


TrafficLight trafficLight = new TrafficLight();
Console.Write("Enter traffic light color (Red/Yellow/Green): ");
trafficLight.Color = Console.ReadLine()!;
Console.Write("Enter duration in seconds: ");
trafficLight.Duration = double.Parse(Console.ReadLine()!);
Console.WriteLine();
trafficLight.ChangeColor();

Console.WriteLine("Traffic light color changed.");Console.WriteLine("Traffic light color changed.");
Console.WriteLine("wtf");
Console.WriteLine("ts is realyy ez");