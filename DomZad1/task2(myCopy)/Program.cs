// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.

System.Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 < number2)
{
    System.Console.Write("a = " + number2 +";" + " b = " + number1 + " -> max = " + number2);
}
else
{
    System.Console.Write("a = " + number1 +";" + " b = " + number2 + " -> max = " + number1);
}
