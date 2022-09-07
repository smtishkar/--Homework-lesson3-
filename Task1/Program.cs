// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write ("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());


while (number < 9999 || number > 99999)
{
    if (number < 9999 || number > 99999)
    {
        Console.WriteLine ("Введите корректное ПЯТИЗНАЧНОЕ число: ");
        number = int.Parse(Console.ReadLine());
    } 
}
string values = number.ToString();
    if (values[0] == values[4] && values[1] == values[3])
    {
        Console.WriteLine ("Да, это число является палиндромом");
    }
    else
    {
        Console.WriteLine ("Нет, это число не является палиндромом");
    }

