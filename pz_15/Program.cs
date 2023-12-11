using System;
using System.IO;

class Program
{
    static void Main()
    {
        static void pz_16()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("brom и log идентичен, brom отличается");
                Console.Write("Введите полный путь к каталогу: ");
                string directoryPath = Console.ReadLine();

                if (Directory.Exists(directoryPath))
                {
                    string[] files = Directory.GetFiles(directoryPath);

                    Console.WriteLine("Список файлов:");
                    foreach (string file in files)
                    {
                        Console.WriteLine(Path.GetFileName(file));
                    }

                    Console.WriteLine();

                    Console.Write("Введите имя первого файла (без расширения): ");
                    string fileName1 = Console.ReadLine();

                    Console.Write("Введите имя второго файла (без расширения): ");
                    string fileName2 = Console.ReadLine();

                    string filePath1 = Path.Combine(directoryPath, fileName1 + ".txt");
                    string filePath2 = Path.Combine(directoryPath, fileName2 + ".txt");

                    if (File.Exists(filePath1) && File.Exists(filePath2))
                    {
                        string content1 = File.ReadAllText(filePath1);
                        string content2 = File.ReadAllText(filePath2);

                        if (content1 == content2)
                        {
                            Console.WriteLine("Содержимое файлов идентично.");
                            Console.WriteLine("Нажмите С, чтобы продолжить...");
                        }
                        else
                        {
                            Console.WriteLine("Содержимое файлов различно.");
                            Console.WriteLine("Нажмите С, чтобы продолжить...");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Один из файлов не найден.");
                    }
                }
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.C:
                        pz_16();
                        break;
                }
            }
        }
        try
        {
            pz_16();
        }
        catch
        {
            Console.WriteLine("Что-то пошло не так...(\nПоробуйте снова");
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить...");
            switch (Console.ReadKey().Key)
            {
                default:
                    pz_16();
                    break;
            }

        }
    }
}