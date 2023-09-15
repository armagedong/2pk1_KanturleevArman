int b; double f;//заводим переменные

Console.Write("Введите b: ");//выводим на консоль сообщение
b = int.Parse(Console.ReadLine());
Console.Write("Введите f: ");
f = double.Parse(Console.ReadLine());

double p, t, r;//заводим переменные

if (b > 0) //если условие истина
{
    p  = f * Math.Cos(b) / Math.Sqrt(b*b - f*f);//выполняется это действие
}
else//иначе
{
   p = 2 * f - Math.Sin(b);//выполняется это действие
}

if (p <= 0)//если условие истина
{
    t = Math.Pow(Math.Sin(b * f), 2) - Math.Pow(Math.Cos(b + p), 2);//выполняется это действие
}
else//иначе
{
    t = Math.Pow(Math.Sin(b * p), 2) - Math.Pow(Math.Cos(b - p), 2);//выполняется это действие
}

r = (int)(12 *b + 3*p*Math.Pow(t, 2) + f / 3);
Console.WriteLine($"Результат: {r}"); // выводим на консоль результат