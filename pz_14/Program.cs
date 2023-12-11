using System.Reflection.PortableExecutable;

string path = "pz_04.txt";
using(FileStream File = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))// Открываем файл для записи
{
    using (StreamWriter Writer = new StreamWriter(File))// Создаем объект для записи в файл
    {
        // Здесь могут быть операции записи в файл, но в данном случае они отсутствуют
    }
}
using (FileStream File = new FileStream(path, FileMode.Open, FileAccess.Read))// Открываем файл для чтения
{

    using (StreamReader Reader = new StreamReader(File))  // Создаем объект для чтения из файла
    {
        using (StreamReader Reader1 = new StreamReader(File))// Создаем объект для чтения из файла
        {
            string[] print = Reader1.ReadToEnd().Split('\n');
            foreach (string str in print)
            {
                Console.WriteLine(str);
            }
        }
    }

}
using (FileStream File = new FileStream(path, FileMode.Open, FileAccess.Read))// Открываем файл для чтения
{

    using (StreamReader Reader = new StreamReader(File))  // Создаем объект для чтения из файла
    {
        // Читаем содержимое файла и анализируем даты рождения
        string[]txt = Reader.ReadToEnd().Split(' ','-','\n');
        string[]year = new string[txt.Length/4];
        string[]month = new string[txt.Length/4];
        string[]day = new string[txt.Length/4];
        string[]f = new string[txt.Length/4];
        int a = 0; int b = 0; int c = 0; int d = 0;
        for (int i = 0; i < txt.Length; i++)//заполняем массив с фамилиями и годами
        {
            if (txt[i].All(Char.IsDigit))
            {
                if (txt[i].Length > 4)//проверяем корректность даты
                {
                    Console.WriteLine($"{txt[i]} не может существовать такой даты рождения");
                }

                if (txt[i].Length == 4)//заполняем массив с годами
                {
                    year[b] = txt[i];
                    b++;
                }
            }
            else//заполняем массив с фамилиями
            {
                f[a] = txt[i];
                a++;
            }
        }
        for (int i = 1;i < txt.Length; i +=4)//заполняем массив с месяцами
        {
            month[c] = txt[i];
            c++;
        }
        for (int i = 2; i < txt.Length; i += 4)//заполняем массив со днями
        {
            day[d] = txt[i];
            d++;
        }
        // год(самый страший)
        string older = year.Min();


        // месяц(самый страший)
        List<string> array = new List<string>();
        for (int i = 0; i < year.Length; i++)
        {
            if (year[i] == older)
            {
                array.Add(month[i]);
                

            }
        }
        int indexminmont = 0;
        string olderMonth = array.Min();
        // день(самый страший)
        List<string> array1 = new List<string>();//создаем лист, который будет хранить в себе информаци
        for (int i = 0; i < year.Length; i++)
        {
            if (year[i] == older)
            {
                array1.Add(day[i]);


            }
        }
        
        string olderDAy = array1.Min();
        // Находим индекс в массиве, который соответствует самой старшей дате рождения с тремя условиями
        for (int i = 0; i < year.Length; i++)
        {
            if (year[i] == older && month[i] == olderMonth && day[i] == olderDAy)
            {
                indexminmont = i;
            }
        }


        

        Console.WriteLine($"\nСамый старший {txt[indexminmont * 4 + 3]}"); // Выводим информацию о самом старшем человеке на экран
    }

}
