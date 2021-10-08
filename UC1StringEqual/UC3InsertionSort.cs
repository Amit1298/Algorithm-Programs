using System;

namespace UC3InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortarray = new int[10] { 23, 45, 22, 67, 8, 5, 98, 0, 12, 5 };
            int n = 10, value, flag, j;
            Console.WriteLine("Before Sorting");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(sortarray[i] + " ");
            }
            for (int i = 0; i < n; i++)
            {
                value = sortarray[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (value < sortarray[j])
                    {
                        sortarray[j + 1] = sortarray[j];
                        j--;
                        sortarray[j + 1] = value;
                    }
                    else flag = 1;
                }

            }
            Console.WriteLine("After Sorting");
            for (int k = 0; k < n; k++)
            {
                Console.WriteLine(sortarray[k] + " ");
            }
        }
    }
}
