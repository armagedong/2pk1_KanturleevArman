Console.Write("Введите первую сторону первого треугольника:\t");//вводятся входные данные
double a = int.Parse(Console.ReadLine());
Console.Write("Введите вторую сторону первого треугольника:\t");
double b = int.Parse(Console.ReadLine());


Console.Write("Введите первую сторону второго треугольника:\t");
double a1 = int.Parse(Console.ReadLine());
Console.Write("Введите вторую сторону второго треугольника:\t");
double b1 = int.Parse(Console.ReadLine());

double S, S1, P, P1;//переменные для площадей и периметров

P = Perimeter(a, b);
P1 = Perimeter(a1, b1);

S = Square(a, b);
S1 = Square(a1, b1);

Console.WriteLine($"Периметр и площадь первого треугольника равны {P} и {S} соотвественно");
Console.WriteLine($"Периметр и площадь второго треугольника равны {P1} и {S1} соотвественно");

if (P == P1)//условный оператор, который сравнивает периметр первого и второго треугольника                                                
    Console.WriteLine("Периметр первого и второго треугольника равны");
else if (P > P1)
    Console.WriteLine("Периметр первого треугольника больше второго");
else
    Console.WriteLine("Периметр второго треугольника больше первого");

if (S == S1)//условный оператор, который сравнивает площадь первого и второго треугольника   
    Console.WriteLine("Площадь первого и второго треугольника равны");
else if (S > S1)
    Console.WriteLine("Площадь первого треугольника больше второго");
else
    Console.WriteLine("Площадь второго треугольника больше первого");

static double Perimeter(double a, double b)//статический метод который принимает 2 переменные типа double и возвращает периметр 
{
    return a * 2 + b * 2;
}
static double Square(double a, double b)//статический метод который принимает 2 переменные типа double и возвращает площадь 
{ 
    return a * b / 2;
}


