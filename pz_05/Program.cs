double a = double.Parse(Console.ReadLine());//вводим переменные
double b = double.Parse(Console.ReadLine());
double i = a;

while (i >= b) //цикл while
{
    i = i - b;
}
Console.WriteLine($"Незанятая часть отрезка: {i}");//выводим ответ

