/*Задача *: Напишите программу, которая из массива случайных чисел. 
Ищет разницу между максимумом и средним значением
[1, 3, 5, 6, 6, 4] -> 5*/
int[] CreateArray(int length, int min, int max)
{
    int[] Arrrayone = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < Arrrayone.Length; i++)
    {
        Arrrayone[i] = rnd.Next(min, max+1);
    }
    return Arrrayone;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       System.Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int [] arraytwo = CreateArray(6, 0, 10);
int max = arraytwo[0];
for (int i = 1; i < arraytwo.Length; i++)
{
    if (arraytwo[i] > max)
    {
        max = arraytwo[i];
    }
}
double aver = 0;
for (int i = 0; i < arraytwo.Length; i++)
{
    aver = aver + arraytwo[i];
}
aver = aver/arraytwo.Length;
double diff = max - aver;
PrintArray(arraytwo);
System.Console.WriteLine($"{max}, {aver}, {diff}");