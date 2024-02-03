namespace Task2;

public abstract class Animal
{
    string _name;

    public Animal(string name)
    {
        _name = name;
    }

    protected abstract void  greets();
}
