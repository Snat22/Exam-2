namespace Task2;

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    protected override void greets()
    {
        System.Console.WriteLine("Woof");
    }
    protected virtual void Greets2()
    {
        System.Console.WriteLine("Wooooooof");
    }
}
