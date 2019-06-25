using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 15, 6, 6, 2, 10};
            arr = BubbleSort(arr);
            foreach(var i in arr)
            {
                Console.WriteLine($"{i}");
            }
        }

        static int[] BubbleSort(int[] arr)
        {
            int temp = 0;
            bool swap = false;
            for(var k=1; k<=arr.Length-1; k++)
            {
                swap = false;
                for(var i=0; i<=arr.Length-2; i++)
                {
                    if(arr[i] > arr[i+1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i+1];
                        arr[i+1] = temp;

                        swap = true;
                    }
                }
                if(!swap)
                {
                    break;
                }
            }

            return arr;
        }
    }
}
