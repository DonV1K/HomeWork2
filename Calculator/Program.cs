Console.WriteLine("Введите первое число");
var firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите знак операции");
var sign = Console.ReadLine();
Console.WriteLine("Введите второе число");
var secondNumber = Convert.ToInt32(Console.ReadLine());

switch (sign)
{
    case "+":
        Console.WriteLine(firstNumber + secondNumber);
        break;

    case "-":
        Console.WriteLine(firstNumber - secondNumber);
        break;

    case "/":
            Console.WriteLine(firstNumber / secondNumber);
        break;

    case "*":
        Console.WriteLine(firstNumber * secondNumber);
        break;

    case "%":
        Console.WriteLine(firstNumber % secondNumber);
        break;

        default:
        Console.WriteLine("null");
        break;

}

