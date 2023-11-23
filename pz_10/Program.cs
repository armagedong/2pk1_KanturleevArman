Console.Write("Введите первую строчку:\t");
string str1 = Console.ReadLine();
Console.Write("Введите вторую строчку:\t");
string str2 = Console.ReadLine();
string[] text1 = str1.Split(); //разбивание строчек на массивы
string[] text2 = str2.Split();
string end = "";//результирующая строка

if (text1.Length < text2.Length)//попарно заносим в результирующую строку слова
{
    for (int i = 0; i < text1.Length; i++)
    {
        end += text1[i] + " " + text2[i] + " ";
    }
}
else
{
    for (int i = 0; i < text2.Length; i++)
    {
        end += text1[i] + " " + text2[i] + " ";
    }
}

if (text1.Length > text2.Length)//условие если первая строка больше, то выводим оставшиеся слова
{
    for (int i = text2.Length; i < text1.Length; i++)
    {
        end += text1[i] + " ";
    }
}
else                              //противоположное условие
{
    for (int i = text1.Length; i < text2.Length; i++)
    {
        end += text2[i] + " ";
    }
}
Console.WriteLine(end);//выводим результат
