
string formula = Console.ReadLine();

Proverka(formula);

static void Proverka(string str)
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