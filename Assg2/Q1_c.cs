//213047
using System;
public abstract class Telephone
{
    protected string phonetype;

    public Telephone(string type)
    {
        phonetype = type;
    }

    public abstract void Ring();
}
public class DigitalPhone : Telephone
{
    public DigitalPhone() : base("Digital")
    {
    }
    public override void Ring()
    {
        Console.WriteLine($"Ringing the {phonetype} Phone.");
    }
}
public class TalkingPhone : Telephone
{
    public TalkingPhone() : base("Talking")
    {
    }
    public override void Ring()
    {
        Console.WriteLine($"Ringing the {phonetype} Phone.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Telephone digitalPhone = new DigitalPhone();
        Telephone talkingPhone = new TalkingPhone();
        digitalPhone.Ring();
        talkingPhone.Ring();
    }
}
