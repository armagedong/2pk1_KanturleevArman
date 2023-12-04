//задание 1

//Задача 1
using System.Threading.Channels;

static int an(int a)//статический метод an, который вычисляет n-й член арифметической прогрессии с первым элементом a1 = -70 и шагом d = 6.
{
    return -70 + (a- 1) * 6;
}

Console.WriteLine("Арифеметическая прогрессия 5:\t" + an(5) + "\n");//как пример найдем 5 член арифметической прогрессии и в выводе у нас будет -46

static double bn(double a)//статический метод bn, который вычисляет n-й член геометрической прогрессии с первым элементом b1 = 9 и знаменатель прогрессии b = 6.
{
    if (a == 1) return 1;
    else
    {
       return 9 * Math.Pow(-0.3, a-1);
    }
}
Console.WriteLine("Геометрическая прогрессия 5:\t" + bn(5) + "\n");//как пример найдем 5 член арифметической прогрессии и в выводе у нас будет 0,07289999999999999

//Задание 3
/*статический метод zadanie3, который выводит все числа от A до B 
включительно, используя рекурсию, в порядке возрастания, если A < B, или в порядке 
убывания в противном случае.*/
static int zadanie3(int A, int B)
{
    if (A < B)
    {
        Console.Write(A + " ");
        if (A == B) return B;
        else return zadanie3(A + 1, B);
    }
    else
    {
        Console.Write(A + " ");
        if (A == B) return B;
        else return zadanie3(A - 1, B);
    }

}
Console.Write("Выыод чисел от 2 до 66:\t"); zadanie3(2, 66);//для примера возьмем числа 2 и 66
Console.WriteLine("\n");


//задание на 5
static int Summ(int a)
{
    if (a == 1) return 1;
    else
    {
        return a + Summ(a - 1);
    }
}
int a = 5;//можно сделать int a = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до {a}:\t" + Summ(a));//для примера возьмеем 5 и в выоде у нас будет число 15

