/*Задача 2: Напишите программу, которая принимает на вход число 
N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120*/
int ReadInt(string message)
{
    System.Console.Write(message);              // Подсказка
    return Convert.ToInt32(Console.ReadLine()); // Преобразование введенной пользователем строки в число
}
int Fakt(int N)
{
    int sum = 1;
    int i = 1;
    while (i <= N)
    {
        sum = sum * i;
        i++;
    }
    return sum;
}
int N = ReadInt("Введите число => ");
System.Console.WriteLine(Fakt(N));