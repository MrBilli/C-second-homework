//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.

int secondNum (int num)
{
    int newNum = num / 10 % 10;
    return newNum;
}

Console.WriteLine("Введите трёхзначное целоe число");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Второй цифрой из числа {number} является {secondNum(number)}");
