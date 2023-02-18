// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день 
// недели, и проверяет, является ли этот день выходным.

System.Console.Write("Enter number day of the week: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1)
    {
        System.Console.WriteLine("No");
    }
else if (day == 2)
    {
        System.Console.WriteLine("No");
    }
else if (day == 3)
    {
        System.Console.WriteLine("No");
    }
else if (day == 4)
    {
        System.Console.WriteLine("No");
    }
else if (day == 5)
    {
        System.Console.WriteLine("No");
    }
else if (day == 6)
    {
        System.Console.WriteLine("Yes");
    }
else if (day == 7)
    {
        System.Console.WriteLine("Yes");
    }
else
    {
        System.Console.WriteLine("There is no such day");
    }
    