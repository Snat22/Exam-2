namespace Task2;

public class BigDog : Dog
{
    public BigDog(string name) : base(name)
    {
    }
    protected override void greets()
    {
        System.Console.WriteLine("Woooow");
    }
    protected override void Greets2()
    {
        System.Console.WriteLine("Wooooooooooow");
    }
    public void Greets3(BigDog another)
    {
        System.Console.WriteLine("WOOOOOOOOOOOOOOOO00000W");
    }
}
