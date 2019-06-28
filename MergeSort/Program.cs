using System;

namespace Sorting
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] arr = {3, 10, 9, 15, 5, 7, 3, 8, 12};
			MergeSort(arr);
			foreach(var i in arr)
			{
				Console.WriteLine($"{i}");			
			}
		}
		
		//Divide and sort
		static void MergeSort(int[] arr)
		{
			if(arr != null && arr.Length > 0)
			{
				var n = arr.Length;
				if(n < 2)
				{
					return;
				}
				int mid = n/2;
				int n_left = mid;
				int n_right = n - n_left;
				
				int[] left_arr = new int[n_left];
				for(var i=0; i<n_left; i++)
				{
					left_arr[i] = arr[i];
				}	

				int[] right_arr = new int[n_right];
				for(int i=mid,j=0; i<n; i++,j++)
				{
					right_arr[j] = arr[i];
				}	

				MergeSort(left_arr);
				MergeSort(right_arr);
				Merge(left_arr, right_arr, arr);				
			}
		}

		// Combine
		static void Merge(int[] left_arr, int[] right_arr, int[] arr)
		{
			var n_left = left_arr.Length;
			var n_right = right_arr.Length;

			var i = 0;
			var j = 0;
			var k = 0;
			
			while(i<n_left && j<n_right)
			{
				if(left_arr[i] < right_arr[j])
				{
					arr[k] = left_arr[i];
					i++;
				}
				else
				{
					arr[k] = right_arr[j];
					j++;
				}
				k++;
			}
			
			while(i<n_left){ arr[k] = left_arr[i]; i++; k++;}
			
			while(j<n_right){ arr[k] = right_arr[j]; j++; k++;}
		}
	}
}