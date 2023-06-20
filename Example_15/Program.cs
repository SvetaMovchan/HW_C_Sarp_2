/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
int String_input(string note)
{
    System.Console.Write(note);
    string text = Console.ReadLine();
    int shunt = Convert.ToInt32(text);
    return shunt;
}

bool CheckDayWeek(int num)
{
    if (num > 0 && num < 8)
    {
        return true;
    }
    Console.WriteLine("это не день недели!");
    return false;
}

int wday = String_input("Введите номер дня недели => ");
if (CheckDayWeek(wday))
{
    if (wday > 5)
    {
        Console.WriteLine("Да, это выходной");
    }
    else
    {
        Console.WriteLine("Нет, это рабочий день");
    }
}