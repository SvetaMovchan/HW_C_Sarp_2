/* Задача 10: Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
int string_input(string note)
{
    System.Console.Write(note);
    string text = Console.ReadLine();
    int shunt = Convert.ToInt32(text);
    return shunt;
}
int num = string_input("Введите число, трехзначное => ");
if (num < 100 || num >=1000)
{
    Console.WriteLine("это не трехзначное число");
    return;
}
int result = num / 10 % 10;
Console.WriteLine($"Вторая цифра {result}");
