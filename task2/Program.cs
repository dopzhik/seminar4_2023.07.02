/*Задача 1: Напишите программу, которая принимает 
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/
long ReadInt(string message)
{
    System.Console.Write(message);              // Подсказка
    return Convert.ToInt64(Console.ReadLine()); // Преобразование введенной пользователем строки в число
}
int Podschet(long A)
{
    int cnt = 0;
    while (A > 0)
    {
        A /= 10;
        cnt++;
    }
    return cnt;
}

long A = ReadInt("Введите число = > ");
System.Console.WriteLine(Podschet(A));