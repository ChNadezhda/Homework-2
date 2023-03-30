//Напишите программу, которая принимает на вход цифру,
//обозначающую день недели
//и проверяет, является ли этот день выходным
// 6 => да
// 7 => да
// 1 => нет

Main();

void Main() 
{
    bool Work = true;

    while(Work)
    {
        Console.WriteLine("Для начала работы введите - start. Для окончания - stop");

        string a = Console.ReadLine();
        switch (a)
        {
            case "start": Task(); break;
            case "stop": Work = false; break;
        }
    }
}

void Task()
{
    Console.WriteLine("Введите число, указывающее день недели: ");

    int number = int.Parse(Console.ReadLine());

    bool weekend = DayOfTheWeek(number);
    bool range = FromTo(number);

    if (range) 
    {
        if (weekend) Console.WriteLine("Выходной день");
        else Console.WriteLine("Будний день");
    }

    else Console.WriteLine("Введите число от 1 до 7");
}

bool DayOfTheWeek (int number) 
{
    return number == 6 || number == 7;
}

bool FromTo (int number) 
{
    return number == 1 || number == 2 || number == 3 || number == 4 || number == 5 || number == 6 || number == 7;
}