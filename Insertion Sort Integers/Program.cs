using System;

namespace Insertion_Sort_Integers
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] heights = new int[] { 1, 1, 4, 2, 1, 3 };

			for (int i = 1; i < heights.Length; ++i)
			{
				int val = heights[i];
				int j = i - 1;

				while (j >= 0 && val < heights[j])
				{
					heights[j + 1] = heights[j];
					j--;
				}
				heights[j + 1] = val;
			}

			foreach (int h in heights)
				Console.WriteLine(h);

			Console.ReadLine();
		}
	}
}
