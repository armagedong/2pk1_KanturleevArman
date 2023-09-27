int count = 0;//счетчик отрицательных чисел
Console.Write("Введите кол-во элементов в массиве:\t");
int countArray = int.Parse(Console.ReadLine());//ввводим кол-во элементов в массиве
int[] array = new int[countArray];//объявляем новый массив array
for (int i = 0; i < countArray; i++)//заполняем массив числами
{
    Console.Write($"Запилните {i + 1} элемент:\t");
    array[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < countArray; i++)//считаем отрицательные числа
{
    if (array[i] < 0)
        count++;
}
Console.WriteLine($"Кол-во отрицательных чисел:\t{count}");
Array.Sort(array, (x, y) => y.CompareTo(x));//сортируем массив с помощью метода Sort
Console.WriteLine("Отрицательные числа в порядке уменьшения:");
foreach (int i in array)//выводим все отрицательные числа в порядке уменьшения
{
    if (i < 0) Console.WriteLine(i);
}