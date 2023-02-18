// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

System.Console.Write("Введите число: ");
int number1 = Convert.ToInt32(System.Console.ReadLine());
int number2 = number1 / 10 % 10;
if (number1 > 99 && number1 < 1000)
{
    System.Console.Write(number2);
}
else
{
    System.Console.Write("Число не трёхзначное");
}
