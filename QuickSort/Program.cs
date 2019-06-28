using System;

namespace QuickSort
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = {3,12, 10, 3, 6, 8, 7, 11};
			QuickSort(arr, 0, arr.Length-1);
			foreach(var i in arr)
			{
				Console.WriteLine($"{i}");
			}

		    Console.ReadKey();
		}
		
		static void QuickSort(int[] arr, int start_index, int end_index)
		{
			// exit condition
			if(start_index >= end_index)
				return;						

			var p_index = Partition(arr, start_index, end_index);
			QuickSort(arr, start_index, p_index-1);
			QuickSort(arr, p_index+1, end_index);
		}

		static int Partition(int[] arr, int start, int end)
		{
			int pivot = arr[end];
			int p_index = start;
			int temp = 0;
			for(var i=start; i<=end-1; i++)
			{
				if(arr[i]<=pivot)
				{
					// swap element at ith position with element at pivot index; and increment pivot index by 1
					temp = arr[i];
					arr[i] = arr[p_index];
					arr[p_index] = temp;
					
					p_index++; 
				}				
			}

			// swap pivot and element at pivot index
			arr[end] = arr[p_index];
			arr[p_index] = pivot;

			return p_index; 		
		}
	}
}