string personName;
string personJob;
string[] zodiacSigns = new string[] {"овен","телец","близнецы","рак","лев","дева","весы","скорпион","стрелец","козерог","водолей","рыбы"};

Console.WriteLine("Добро пожаловать на курсы IJunior!\nЗаполните следующие поля:");
Console.WriteLine("\n1. Введите ваш возраст: ");

if (byte.TryParse(Console.ReadLine(), out byte personAge))
{
    Console.WriteLine("\n2. Введите ваше имя");
    personName = Console.ReadLine();

    Console.WriteLine("\n3. Где вы работаете? (используйте предложный прадеж [О ком? О чём?])");
    personJob = Console.ReadLine();

    Console.WriteLine($"\n Выберите ваш знак зодиака от 1 до {zodiacSigns.Length}:\n");

    for(int i = 0; i < zodiacSigns.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {zodiacSigns[i]}.");
    }

    if (int.TryParse(Console.ReadLine(), out int personZodiacSignIdInput))
    {
        int personZodiacSignId = personZodiacSignIdInput - 1;

        if (personZodiacSignId > 0 && personZodiacSignId < zodiacSigns.Length)
        {
            Console.Clear();
            Console.WriteLine($"Вас зовут {personName}, вам {personAge} год, вы {zodiacSigns[personZodiacSignId]} и работаете на {personJob}.");
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"{personZodiacSignId} не входит в номера знаков зодиака от 1 до {zodiacSigns.Length}");
        }
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