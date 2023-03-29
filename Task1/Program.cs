//Напишите программу, которая принимает на вход 
//трехзначное число и на выходе показывает
//вторую цифру этого числа
// 456 => 5
// 782 => 8
// 918 => 1

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
    Console.WriteLine("Введите трехзначное число: ");
    int number = int.Parse(Console.ReadLine());

    int digit = SecondDigit(number);
    Console.WriteLine($"В числе {number} вторая цифра равна - {digit}");
}

int SecondDigit(int number) 
{
    int a = number / 10;
    int b = a % 10;
    
    return b;
}
