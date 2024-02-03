namespace Task2;

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    protected override void greets()
    {
        System.Console.WriteLine("Meow");
    }
}
