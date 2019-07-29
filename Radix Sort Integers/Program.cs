using System;

namespace Radix_Sort_Integers
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] A = new int[] { -4, -1, 0, 3, 10 };

			int arrLen = A.Length;

			//Find Square Root of array
			for (int i = 0; i < A.Length; i++)
				A[i] = A[i] * A[i];

			//Get absolute max value of square value
			//--------------------------------------------

			int max = A[0];

			for (int i = 1; i < arrLen; i++)
				if (A[i] > max)
					max = A[i];

			//--------------------------------------------

			//Count Sort in for loop
			for (int exp = 1; max / exp > 0; exp *= 10)
			{
				int[] output = new int[arrLen];
				int i;
				int[] count = new int[10];

				//build array containing numbers 1 - 10
				for (i = 0; i < 10; i++)
					count[i] = 0;

				//store counts of occurrences
				for (i = 0; i < arrLen; i++)
					count[(A[i] / exp) % 10]++;

				//Make counts contain positions in array
				for (i = 1; i < 10; i++)
					count[i] += count[i - 1];

				//build output array
				for (i = arrLen - 1; i >= 0; i--)
				{
					output[count[(A[i] / exp) % 10] - 1] = A[i];
					count[(A[i] / exp) % 10]--;
				}

				//Copy output to array
				for (i = 0; i < arrLen; i++)
					A[i] = output[i];
			}

			//Display output
			for (int i = 0; i < A.Length; i++)
				Console.WriteLine(A[i]);

			Console.ReadLine();
		}
	}
}
