Console.WriteLine("ВНимание!Вам будет выдана стоимость 10 минутного разговора!");


while (true)
{
    string city = Console.ReadLine();

    Console.Write("Введите названи города или код города: ");

    switch (city)
    {
        case "Москва":
        case "905":
        case "москва":
            Console.WriteLine(4.5 * 10 + " рублей для Москвы");
            break;
        case "Ростов":
        case "194":
        case "ростов":
            Console.WriteLine(4.5 * 10 + " рублей для Ростова");
            break;
        case "Краснодар":
        case "491":
        case "краснодар":
            Console.WriteLine(4.5 * 10 + " рублей для Краснодара");
            break;
        case "Киров":
        case "800":
        case "киров":
            Console.WriteLine(4.5 * 10 + " рублей Кирова");
            break;
        default:
            Console.WriteLine("Некорректный ввод!\nПовторите попытку");
            break;
    }
}
