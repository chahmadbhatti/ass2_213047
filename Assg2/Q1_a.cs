//213047
using System;
public class Telephone
{
    protected string phonetype;

    public Telephone()
    {
        phonetype = "Analog";
    }

    public void Ring()
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
}
class Program
{
    static void Main(string[] args)
    {
        ElectronicPhone electronicPhone = new ElectronicPhone();
        electronicPhone.Run();
    }
}
