//213047
using System;

public class Telephone
{
    protected string phonetype;

    public Telephone()
    {
        phonetype = "Analog";
    }

    public virtual void Ring()
    {
        Console.WriteLine($"Ringing the {phonetype}.");
    }
}

public class ElectronicPhone : Telephone
{
    public ElectronicPhone()
    {
        phonetype = "Digital";
    }

    public void Run()
    {
        Ring();
    }

    public override void Ring()
    {
        Console.WriteLine($"Ringing the {phonetype} Electronic Phone.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Telephone telephone = new ElectronicPhone();
        telephone.Ring(); // This will call the overridden Ring method in ElectronicPhone.
    }
}