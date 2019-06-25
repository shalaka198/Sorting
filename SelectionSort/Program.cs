using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 15, 6, 6, 2, 10};
            arr = SelectionSort(arr);
            foreach(var i in arr)
            {
                Console.WriteLine($"{i}");
            }
        }

        static int[] SelectionSort(int[] arr)
        {
            int iMin=0;
            int temp = 0;
            for(var i=0; i<arr.Length-2; i++)
            {
                iMin = i;
                for(var j=i+1; j<arr.Length-1; j++)
                {
                    if(arr[j]<arr[iMin])
                    {
                        iMin = j;
                    }
                }
                temp = arr[i];
                arr[i] = arr[iMin];
                arr[iMin] = temp;
            }

            return arr;
        }
    }
}
