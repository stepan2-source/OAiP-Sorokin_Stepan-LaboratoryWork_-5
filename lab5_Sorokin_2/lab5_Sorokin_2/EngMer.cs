using System;

class EngMer
{
    private int feet;
    private int inches;

    public void Read()
    {
        Console.Write("Футы: ");
        feet = int.Parse(Console.ReadLine());
        Console.Write("Дюймы: ");
        inches = int.Parse(Console.ReadLine());
        if (inches >= 12)
            feet += inches / 12;
        inches %= 12;
    }

    public void Display()
    {
        Console.WriteLine($"{feet} футов {inches} дюймов");
    }

    public EngMer Add(EngMer other)
    {
        EngMer r = new EngMer();
        r.feet = feet + other.feet;
        r.inches = inches + other.inches;
        if (r.inches >= 12)
        {
            r.feet += r.inches / 12;
            r.inches %= 12;
        }
        return r;
    }

    public EngMer Subtract(EngMer other)
    {
        EngMer r = new EngMer();
        r.feet = feet - other.feet;
        r.inches = inches - other.inches;
        if (r.inches < 0)
        {
            r.feet -= 1;
            r.inches += 12;
        }
        return r;
    }

    public EngMer Multiply(int k)
    {
        EngMer r = new EngMer();
        int total = (feet * 12 + inches) * k;
        r.feet = total / 12;
        r.inches = total % 12;
        return r;
    }

    public EngMer Divide(int k)
    {
        EngMer r = new EngMer();
        int total = (feet * 12 + inches) / k;
        r.feet = total / 12;
        r.inches = total % 12;
        return r;
    }

    public bool IsGreater(EngMer other)
    {
        return (feet * 12 + inches) > (other.feet * 12 + other.inches);
    }
}
