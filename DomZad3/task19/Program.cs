// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.Write("Введите число: ");
string? number = Console.ReadLine();
int lenght = number!.Length;
if (lenght == 5)
    if (number[0] == number[4] && number[1] == number[3])
    {
        System.Console.WriteLine("Является палиндромом");
    }
    else
    {
        System.Console.WriteLine("Не является палиндромом");
    }
else
{
    System.Console.WriteLine($"{number} - число не пятизначное");
}
