using System.Globalization;
using System.Net.WebSockets;

Console.WriteLine("Задание 1,вариант 10");//задание 1 
for (int i = 30; i < 100; i += 7)
{
    Console.Write(i + " ");
}
Console.WriteLine("\n\nЗадание 2,вариант 10");//задание 2 
for (char  c = 'K'; c <= 'Q'; c++)
{
    Console.Write(c + " ");
}
Console.WriteLine("\n\nЗадание 3,вариант 10");//задание 3
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("####");
}
Console.WriteLine("\nЗадание 4,вариант 10");//задание 4 
int count = 1;
for (int i = 90; i < 900; i++)
{
    if (i % 9 == 0)
    {
        count += 1;
    }
}
Console.Write(count);
Console.WriteLine("\n\nЗадание 5,вариант 10");//задание 5
int j = 50;
int count2 = 1;
int count3 = 0;
for (int i = 4; j - i > 11; i++, j-- )
{
    count2 = i;
    count3 = j;
}
Console.Write($"{count2} и {count3}\n\n");