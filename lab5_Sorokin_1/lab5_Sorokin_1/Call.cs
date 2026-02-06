using System;

public class Call
{
    private int first;      
    private double second;  

    public void Read()
    {
        Console.Write("Введите продолжительность (мин): ");
        first = int.Parse(Console.ReadLine());

        Console.Write("Введите цену за минуту: ");
        second = double.Parse(Console.ReadLine());
    }

    public void Display()
    {
        Console.WriteLine($"Минуты: {first}");
        Console.WriteLine($"Цена за минуту: {second}");
        Console.WriteLine($"Стоимость разговора: {Cost()} руб.");
    }

    public double Cost()
    {
        return first * second;
    }
}
