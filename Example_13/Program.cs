/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int String_input(string note)
{
    System.Console.Write(note);
    string text = Console.ReadLine();
    int shunt = Convert.ToInt32(text);
    return shunt;
}

int GetSign3(int numb)
{
    while (numb > 999)
    {
        numb /= 10;
    }
    return numb % 10;
}

int num = String_input("Введите число  => ");
if (num < 100)
{
    Console.WriteLine("число меньше трех знаков");
    return;
}
Console.WriteLine($"Третья цифра {GetSign3(num)}");
