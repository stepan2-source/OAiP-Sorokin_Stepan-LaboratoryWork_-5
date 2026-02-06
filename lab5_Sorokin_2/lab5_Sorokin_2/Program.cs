using System;
class Program
{
    static void Main()
    {
        EngMer a = new EngMer();
        EngMer b = new EngMer();

        Console.WriteLine("Введите первую длину:");
        a.Read();
        Console.WriteLine("Введите вторую длину:");
        b.Read();

        Console.WriteLine("Сумма:");
        a.Add(b).Display();

        Console.WriteLine("Разность:");
        a.Subtract(b).Display();

        Console.WriteLine("Умножение первой длины на 2:");
        a.Multiply(2).Display();

        Console.WriteLine("Деление первой длины на 2:");
        a.Divide(2).Display();

        Console.WriteLine(a.IsGreater(b) ? "Первая длина больше второй" : "Первая длина меньше или равна второй");
    }
}