string[][] stairArray = new string[9][];// Создание двумерного массива

Random random = new Random();// Создание Random

for (int i = 0; i < stairArray.Length; i++)// Заполнение ступенчатого массива
{
    int length = random.Next(6, 20);// Генерация случайной длины второго измерения

    stairArray[i] = new string[length]; // Создание массива для текущей ступени

    for (int j = 0; j < length; j++)// Заполнение текущей ступени случайными значениями
    {
        stairArray[i][j] = RandomString(5);
    }
}


for (int i = 0; i < stairArray.Length; i++)// Вывод массива
{
    Console.WriteLine("Ступень {0}:", i + 1);
    for (int j = 0; j < stairArray[i].Length; j++)
    {
        Console.Write(stairArray[i][j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < stairArray.Length; i++)// Вывод массива
{
    Console.WriteLine("Ступень {0}:", i + 1);
    for (int j = 0; j < stairArray[i].Length; j++)
    {
        Console.WriteLine(stairArray.Max());
    }
    Console.WriteLine();
}
string RandomString(int length)//создание метода для рандомного заполнения массива строками
{
    const string chars = "abcdefghijklmnopqrstuvwxyz";
    Random Random = new Random();
    return new string(Enumerable.Repeat(chars, length)
      .Select(s => s[random.Next(s.Length)]).ToArray());
}