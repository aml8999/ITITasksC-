




/// <summary>
/// ///////////////Day5task
/// 
/// </summary>
//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using tasks;
public class Zoo
{
    private List<Animal> _animals = new List<Animal>();
    private List<Animal> _memmals = new List<Animal>();
    private List<Animal> _birds = new List<Animal>();

    public IReadOnlyList<Animal> Animals => _animals.AsReadOnly();
    public IReadOnlyList<Animal> Memmmals => _memmals.AsReadOnly();
    public IReadOnlyList<Animal> Bird => _birds.AsReadOnly();

    public void ADD(Animal animal)
    {
        if (animal.Age > 10)
        {
            Console.WriteLine($"{animal.Name} too old, not accepted.");
            return;
        }

        _animals.Add(animal);

        if (animal is Mammal) _memmals.Add(animal);
        else if (animal is Bird) _birds.Add(animal);

        animal.Died += OnAnimalDied;





    }

    private void OnAnimalDied(Object sender, EventArgs e)
    {

        Animal animal = sender as Animal;
        Remove(animal);

        Console.WriteLine($"{animal.Name} has died and was removed from the zoo.");

    }
    public void Remove(Animal animal)
    {
        _animals.Remove(animal);
        _memmals.Remove(animal);
        _birds.Remove(animal);
    }





}

public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public bool IsAlive { get; set; } = true;

    public event EventHandler Died;


    public virtual void Die()
    {
        if (!IsAlive)
            return;
        IsAlive = false;
        Died?.Invoke(this, EventArgs.Empty);


    }

    public override string ToString()
    {
        return $"{GetType().Name} - Name: {Name}, Age: {Age}";
    }

}
public abstract class Mammal : Animal { }
public abstract class Bird : Animal { }

public class Lion : Mammal { }
public class Elphant : Mammal { }
public class Sparrow : Bird { }
public class Pigeon : Bird { }



internal class Program
{
    static void Main(string[] args)
    {

        PhoneBook phoneBook = new PhoneBook();
        PhoneBook phoneBook2 = new PhoneBook();
        phoneBook[123] = "Ali";
        phoneBook["Hosam"] = 456;
        int phone = phoneBook["Ali"];

        Console.WriteLine(phone);
        phoneBook2[123] = "Ali";
        phoneBook2["Hosam"] = 456;
        int phone2 = phoneBook2["Ali"];

        Console.WriteLine(phone2);






        /////////////////////////////////////////////////////////
        /*
        Zoo zoo = new Zoo();

        Lion simba = new Lion { Name = "Simba", Age = 5 };
        zoo.ADD(simba);
        zoo.ADD(new Lion { Name = "Skar", Age = 5 });

        zoo.ADD(new Sparrow { Name = "Tweety", Age = 2 });
        zoo.ADD(new Elphant { Name = "Dumbo", Age = 12 }); // مش هيتقبل - أكبر من 10
        zoo.ADD(new Pigeon { Name = "Coco", Age = 1 });

        Console.WriteLine("=== Animals BEFORE Simba dies ===");
        foreach (Animal animal in zoo.Animals)
            Console.WriteLine(animal);

        Console.WriteLine();
        Console.WriteLine(">>> Simba is dying now...");
        simba.Die();   // هنا بيتدق الجرس، والزو هيسمعه لوحده ويشيله

        Console.WriteLine();
        Console.WriteLine("=== Animals AFTER Simba dies ===");
        foreach (Animal animal in zoo.Animals)
            Console.WriteLine(animal);

        Console.WriteLine();
        Console.WriteLine("=== Mammals AFTER Simba dies ===");
        foreach (Animal mammal in zoo.Memmmals)
            Console.WriteLine(mammal);




        */






    }
}






