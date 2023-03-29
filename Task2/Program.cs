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
    Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine());

    int digit = ThirdDigit(number);
    Console.WriteLine($"В числе {number} третья цифра равна - {digit}");

}

int ThirdDigit(int number) 
{
    string a = number.ToString(); //преобразовать число в строку
    string b = a.Substring(2, 1); //из строки извлечь подстроку 
    int c = Convert.ToInt32(b); //преобразовать строку в число
    return c;
}

