Console.WriteLine("Введите ваш возраст");

var age = Convert.ToInt32(Console.ReadLine());

var isAdult = age >= 18;

if (isAdult == true)
{
    Console.WriteLine("Совершеннолетний");
}
else
{
    Console.WriteLine("Не совершеннолетний");
}
