
string[] services = new string[] {  "1{Интернет Отдых 100 Мбит/с 500 руб./мес}","2{#ДляДома ПлюсТВ100 Мбит/с 495 руб./мес}" , "3{Интернет Жара 100100 Мбит/с 720 руб./мес}" };// массив для хранения услуг

foreach (string service in services)//перебираем массив им выводим каждый его элемент на консоль
  Console.WriteLine(service);

Console.Write("Выберите услугу (Номер услуги): ");
string pro = Console.ReadLine();//выбор услуги
double count;//итоговая стоимость\
Console.Write("Веберите вам нужно интерактивное тв (+200 рублей в месяц)(y - да | любая клавиша - нет): ");
string yesno = Console.ReadLine();
if (pro == "1")
{
    count = 500;
    if (yesno == "y" || yesno == "у")//кириллица//условие на дополнительную услугу
        count = count + 200;
}
else if (pro == "2")
{
    count = 495;
    if (yesno == "y" || yesno == "у")//кириллица//условие на дополнительную услугу
        count = count + 200;
}
else 
{
    count = 700;
    if (yesno == "y" || yesno == "у")//кириллица//условие на дополнительную услугу
        count = count + 200;
}
Console.WriteLine(count + "рублей");// стомость за месяц
