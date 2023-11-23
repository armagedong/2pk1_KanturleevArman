Console.Write("Введите первую строчку:\t");
string str1 = Console.ReadLine();
Console.Write("Введите вторую строчку:\t");
string str2 = Console.ReadLine();
string[] text1 = str1.Split();
string[] text2 = str2.Split();
string end = "";

if (text1.Length < text2.Length)
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

if (text1.Length > text2.Length)
{
    for (int i = text2.Length; i < text1.Length; i++)
    {
        end += text1[i] + " ";
    }
}
else
{
    for (int i = text1.Length; i < text2.Length; i++)
    {
        end += text2[i] + " ";
    }
}
Console.WriteLine(end);