
string formula = Console.ReadLine();//входные данные

Proverka(formula);

static void Proverka(string str)//статичный метод, который не возвращает никаких значений и определяет формулу
{
    char[] strings = str.ToCharArray();
    int count1 = 0;
    int count2 = 0;
    foreach (char c in strings)
    {
        if (c == ')')
        {
            count1++;
        }
        else if (c == '(')
        {
            count2++;
        }
    }

    if(count1 == count2 && count2 + count1 != strings.Length)
    {
        Console.WriteLine(true); ;
    }
    else
    {
        Console.WriteLine(false);
    }
}
