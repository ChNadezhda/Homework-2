//Напишите программу, которая выводит
//третью цифру заданного числа
//или сообщает, что третьей цифры нет
// 645 => 5
// 78 => третьей цифры нет
// 32679 => 6

Main();

void Main() 
{
    bool Work = true;
    while(Work)
    {
        Console.WriteLine("Для начала работы введите - start. Для окончания - stop");
        string Text = Console.ReadLine();
        switch (Text)
        {
            case "start": Task(); break;
            case "stop": Work = false; break;
        }
    }
}

void Task()
{
    Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine());
      
    bool thirdCharIs = ThirdCharThereOrNot(number);
    
    if (thirdCharIs) 
    {
        int digit = ThirdDigit(number);
        Console.WriteLine($"В числе {number} третья цифра равна - {digit}");
    }

    else Console.WriteLine("Третьей цифры нет");
}

bool ThirdCharThereOrNot(int number)
{
    string IntToString = number.ToString(); 
    var StringLength = IntToString.Length;

    int a = Convert.ToInt32(StringLength);

    return a > 2;
}

int ThirdDigit(int number) 
{
    string IntToString = number.ToString(); 
    string ThirdCharString = IntToString.Substring(2, 1);
    int StringToInt = Convert.ToInt32(ThirdCharString); 
    
    return StringToInt;
}

