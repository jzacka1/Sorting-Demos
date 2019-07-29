using System;

namespace Couting_Sort_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			//list of string value in array
			string[] items = { "bleach",
								"beer",
								"zebra",
								"butterfly",
								"bummer",
								"cow",
								"corn",
								"clown",
								"reef",
								"germ",
								"Czechoslovakia",
								"Martin",
								"Homer",
								"red",
								"zang",
								"1y9",
								"1264"
								};

			//Run Count Sorting for string array, and get new sorted string array.
			string[] newArr = CountSortString(items);

			for (int i = 0; i < newArr.Length; i++)
			{
				Console.WriteLine(newArr[i]);
			}

		}

		static string[] CountSortString(string[] arr)
		{
			//Get length of array, or number of elements in the array
			int arrayLength = arr.Length;

			//Output array to store elements in new order
			string[] output = new string[arrayLength];

			//Number of characters in ASCII table
			int[] count = new int[256];

			//Count the number of times a first character of every element appears
			for (int i = 0; i < arr.Length; i++)
			{

				//Get index of characrter on ASCII table
				int characterIndex = arr[i][0];

				//If capital characters are found, add 32 in the ASCII table
				if (arr[i][0] >= 65 && arr[i][0] <= 90)
					count[characterIndex + 32]++;
				else
					count[characterIndex]++;
			}

			//Add the numbers by values of preceding elements
			for (int i = 1; i < 256; i++)
				count[i] += count[i - 1];

			// Build the output array  
			for (int i = 0; i < arr.Length; i++)
			{
				int characterIndex = arr[i][0];

				//If capital characters are found, add 32 in the ASCII table
				if (arr[i][0] >= 65 && arr[i][0] <= 90)
				{
					//Get index of characrter on ASCII table
					characterIndex += 32;
					output[count[characterIndex] - 1] = arr[i];
					count[characterIndex]--;
				}
				else
				{
					output[count[characterIndex] - 1] = arr[i];
					count[arr[i][0]]--;
				}

			}

			//return output
			return output;
		}
	}
}
