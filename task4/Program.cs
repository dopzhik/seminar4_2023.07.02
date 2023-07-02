/*Задача 3: Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/
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
int [] arraytwo = CreateArray(8, 0, 1);
PrintArray(arraytwo);