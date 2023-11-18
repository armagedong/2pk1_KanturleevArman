Console.Write("Введите вашу строчку:\t");
string str = Console.ReadLine();
str = str.Replace(" ", "");//из строчки удаляются символы пунктуации
str = str.Replace(".", "");
str = str.Replace(",", "");
str = str.Replace(":", "");
str = str.Replace(";", "");
char[] array = str.ToCharArray();//в массив записываются отдельные символы строчки
char[] array2 = array;
if (array.Reverse().SequenceEqual(array2))//улсловны оператор, который переворацичвает массив и сравнивает с исходной строчкой
    Console.WriteLine("Слово палиндром");
else
    Console.WriteLine("Слово не палиндром");