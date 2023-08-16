string personName = "";
byte personAge;
string personJob;
byte personZodiacSignId;
string[] zodiacSigns = new string[12] {"овен","телец","близнецы","рак","лев","дева","весы","скорпион","стрелец","козерог","водолей","рыбы"};

Console.WriteLine("Добро пожаловать на курсы IJunior!\nЗаполните следующие поля:");
Console.WriteLine("\n1. Введите ваш возраст: ");
if (byte.TryParse(Console.ReadLine(), out byte _age))
{
    personAge = _age;
    Console.WriteLine("\n2. Введите ваше имя");
    personName = Console.ReadLine();
    Console.WriteLine("\n3. Где вы работаете? (используйте предложный прадеж [О ком? О чём?])");
    personJob = Console.ReadLine();
    Console.WriteLine("\nВыберите ваш знак зодиака от 1 до 12:" +
        "\n1. Овен.\t2. Телец.\t3. Близнецы.\n4. Рак.    " +
        "\t5. Лев.   \t6. Дева.\n7. Весы.\t8. Скорпион.\t9. Стрелец.\n10. Козерог.\t11. Водолей.\t12. Рыбы.");

    if (byte.TryParse(Console.ReadLine(), out byte _zodiacSignId))
        if (_zodiacSignId >= 1 && _zodiacSignId <= 12)
        {
            personZodiacSignId = _zodiacSignId;
            Console.Clear();
            Console.WriteLine($"Вас зовут {personName}, вам {personAge} год, вы {zodiacSigns[--personZodiacSignId]} и работаете на {personJob}.");
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"{_zodiacSignId} не входит в номера знаков зодиака от 1 до 12");
        }
    else
    {
        Console.Clear();
        Console.WriteLine("String could not be parsed");
    }
}
else
{
    Console.Clear();
    Console.WriteLine("String could not be parsed");
}