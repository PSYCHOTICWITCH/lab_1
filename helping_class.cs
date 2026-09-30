using System;

internal class features
{
    public int[] makeArray(int n)
    {
        int[] array = new int[n];
        Console.WriteLine("Введите " + n + " целых чисел: ");
        for (int i = 0; i < n; i++) 
        { 
            array[i] = int.Parse(Console.ReadLine());
        }   
        return array;
    }

    public void printArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        return;
    }
}