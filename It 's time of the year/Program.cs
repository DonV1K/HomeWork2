Console.WriteLine("Введите текущий месяц");

var month = Console.ReadLine();

switch (month)
{
    case ("Декабрь") or ("Январь") or ("Февраль"):
        Console.WriteLine("Зима");
        break;

    case ("Март") or ("Апрель") or ("Май"):
        Console.WriteLine("Весна");
        break;

    case ("Июнь") or ("Июль") or ("Август"):
        Console.WriteLine("Лето");
        break;

    case ("Сентябрь") or ("Октябрь") or ("Ноябрь"):
        Console.WriteLine("Осень");
        break;

        default:
        Console.WriteLine("null");
        break;

}