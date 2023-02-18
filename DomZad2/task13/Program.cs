// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или  
// сообщает, что третьей цифры нет.

System.Console.Write("Введите число: ");
int number1 = Convert.ToInt32(System.Console.ReadLine());
if (number1 > 99 && number1 < 999)
{
    number1 = number1 % 10;
    Console.WriteLine($"Третья цифра введённого числа: {number1}");
}
else if (number1 > 999 && number1 < 9999)
{
    number1 = number1 % 100 / 10;
    Console.WriteLine($"Третья цифра введённого числа: {number1}");
}
else if (number1 > 9999 && number1 < 99999)
{
    number1 = number1 % 1000 / 100;
    Console.WriteLine($"Третья цифра введённого числа: {number1}");
}
else if (number1 > 99999 && number1 < 999999)
{
    number1 = number1 % 10000 / 1000;
    Console.WriteLine($"Третья цифра введённого числа: {number1}");
}
else if (number1 > 999999 && number1 < 9999999)
{
    number1 = number1 % 100000 / 10000;
    Console.WriteLine($"Третья цифра введённого числа: {number1}");
}
else if (number1 > 9999999 && number1 < 99999999)
{
    number1 = number1 % 1000000 / 100000;
    Console.WriteLine($"Третья цифра введённого числа: {number1}");
}
else if (number1 > 99999999 && number1 < 999999999)
{
    number1 = number1 % 10000000 / 1000000;
    Console.WriteLine($"Третья цифра введённого числа: {number1}");
}
else
{
    System.Console.Write("Третьей цифры нет");
}

// Не удалось сделать универсальный алгоритм, только с костылями, я понял, что
// надо использовать счётчик, чтобы плюсовать к исходному значению, это всё решает,
// но я так и не смог полноценно понять, как это реализовать на практике.