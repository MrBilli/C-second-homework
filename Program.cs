//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.

/*
int secondNum (int num)
{
    int newNum = num / 10 % 10;
    return newNum;
}

Console.WriteLine("Введите трёхзначное целоe положительное число");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Второй цифрой из числа {number} является {secondNum(number)}");
*/

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int thirdNum (int num)
{
    while(num > 999)
    {
        num = num / 10;
    }
    num = num % 10;
    return num;
}

Console.WriteLine("Введите целое положительное число");

int number = Convert.ToInt32(Console.ReadLine());

if(number < 100)
{
    Console.WriteLine($"У числа {number} нет третьей цифры.");
}
else
{
    Console.WriteLine($"У числа {number} третья цифра - {thirdNum(number)}");
}
*/

//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

bool weekend(int num)
{
    if(num ==6 || num == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Введите номер дня недели от 1 до 7");

int day = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"День номер {day} является выходным - {weekend(day)}");