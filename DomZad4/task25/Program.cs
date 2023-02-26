// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B.

int number1 = ReadInt("Введите число A: ");
int number2 = ReadInt("Введите число B: ");
Degree(number1, number2);


void Degree(int a, int b) // функция нахождения степени
{
 int result = 1;
 for (int i = 1; i <= b; i++)
    {
 result = result * a;
    }
 Console.WriteLine(result);
}


int ReadInt(string text) // функция ввода
{
 Console.WriteLine(text);
 return Convert.ToInt32(Console.ReadLine());
}
