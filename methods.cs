
using System;
using System.Diagnostics.SymbolStore;
using System.Runtime.InteropServices;
using System.Xml.Schema;

internal class NumOperation
{
    public double Fraction(double x)
    {
        return x - (int)x;
    }

    public int CharToNum(char x)
    {
        return (int)x;
    }

    public bool is2Digits(int x)
    {
        return (x / 100 == 0 && x / 10 != 0);
    }

    public bool isInRange(int a, int b, int num)
    {
        if (a > b) {
            (a, b) = (b, a);
        }
        return ((a <= num) && (num <= b));
    }

    public bool isEqual(int a, int b, int c) 
    { 
        return (a == b) && (b == c);
    }

    public int abs(int x)
    {
        if (x < 0)
        {
            return -x;
        }
        return x;
    }

    public bool is35(int x)
    {
        if ((x % 3 == 0) ^ (x % 5 == 0)) {
            return true;
        }
        return false;
    }

    public int max3(int x, int y, int z) 
    {
        int max_num;
        if (x > y)
        {
            max_num = x;
        }
        else
        {
            max_num = y;
        }

        if (z > max_num)
        {
            max_num = z;
        }
        return max_num;
    }

    public int sum2(int x, int y)
    {
        int sum = x + y;
        if ((sum >= 10) && (sum <= 19))
        {
            return 20;
        }
        return sum;
    }

    public string day(int x)
    {
        switch (x)
        {
            case 1: return "Понедельник";
            case 2: return "Вторник";
            case 3: return "Среда";
            case 4: return "Четверг";
            case 5: return "Пятница";
            case 6: return "Суббота";
            case 7: return "Воскресенье";
            default: return "Это не день недели";
        }
    }

    public string listNums(int x)
    {
        string out_string = "";

        for (int i = 0; i <= x; i++)
        {
            out_string += Convert.ToString(i) + " ";
        }
        return out_string;
    }

    public string chet(int x)
    {
        string out_string = "";
        for (int i = 0; i <= x; i+=2)
        {
            out_string += Convert.ToString(i) + " ";
        }
        return out_string;
    }

    public int numLen(long x)
    {
        int length = 0;
        while (x > 0)
        {
            x = x / 10;
            length++;
        }
        return length;
    }

    public void square(int x)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
        return;
    }

    public void rightTriangle(int x)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                if (j < x - i - 1)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }

    public int findFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }
        return -1;
    }

    public int maxAbs(int[] arr)
    {
        int max_val = 0;
        for (int i = 0;i < arr.Length; i++)
        {
            if (abs(arr[i]) > abs(max_val))
            {
                max_val = arr[i];
            }
        }
        return max_val;
    }

    public int[] add(int[] arr, int[] ins, int pos)
    {
        int new_length = ins.Length + arr.Length;
        int[] new_arr = new int[new_length];

        int new_index = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (new_index == pos) {
                for (int j = 0; j < ins.Length; j++)
                {
                    new_arr[new_index++] = ins[j];
                }
            } 
            new_arr[new_index++] = arr[i];
            
                
        }
        return new_arr;

    }

    public int[] reverseBack(int[] arr)
    {
        int[] new_array = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            new_array[i] = arr[arr.Length - i - 1];
        }
        return new_array;
    }

    public int[] findAll(int[] arr, int x)
    {
        int amount = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                amount++;
            }
        }

        int[] index_array = new int[amount];
        int index = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                index_array[index++] = i;
            }
        }
        return index_array; 
    }
}


