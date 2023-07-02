/*Задача 1: Напишите программу, которая принимает 
на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36*/
// Функция ввода целого числа
int ReadInt(string message)
{
    System.Console.Write(message);              // Подсказка
    return Convert.ToInt32(Console.ReadLine()); // Преобразование введенной пользователем строки в число
}
int A = ReadInt("Введите число = > ");
int SumN(int A)
{
    int sum = 0;
    while (A > 0)
    {
        sum = sum + A;
        A--;
    }
return sum;
}
int Sum2(int A)
{
    int sum = 0;
    for(int i = 0; i <= A; i++)
    {
        sum += i;
    }
    return sum;
}
int SumGauss(int A)
{
    return (int) ((A+1)*A/2);
}
System.Console.WriteLine(SumN(A));
System.Console.WriteLine(Sum2(A));
System.Console.WriteLine(SumGauss(A));