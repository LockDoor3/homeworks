using System;
using System.Collections.Generic;

namespace urok_8
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] a = new int[100];
			RND(a, 100);
			IU.Print(a);
			IU.space();
			Bucket(a);
			IU.Print(a);
		}
		public static void Bucket(int[] data)
		{
			int minValue = data[0];
			int maxValue = data[0];

			for (int i = 1; i < data.Length; i++)
			{
				if (data[i] > maxValue)
					maxValue = data[i];
				if (data[i] < minValue)
					minValue = data[i];
			}

			List<int>[] bucket = new List<int>[maxValue - minValue + 1];

			for (int i = 0; i < bucket.Length; i++)
			{
				bucket[i] = new List<int>();
			}

			for (int i = 0; i < data.Length; i++)
			{
				bucket[data[i] - minValue].Add(data[i]);
			}

			int k = 0;
			for (int i = 0; i < bucket.Length; i++)
			{
				if (bucket[i].Count > 0)
				{
					for (int j = 0; j < bucket[i].Count; j++)
					{
						data[k] = bucket[i][j];
						k++;
					}
				}
			}
		}
		static void RND(int[] a, int lenght)
		{
			Random rn = new Random();
			for (int i = 0; i < lenght; i++)
			{
				a[i] += rn.Next(0, 1000);
			}
		}
	}
	public class IU
	{
		public static void Print(int[] a)
		{
			foreach (var item in a)
				Console.WriteLine(item);
		}
		public static void space()
		{
			Console.WriteLine("\f");
			for (int i = 0; i < 10; i++)
				Console.Write("SPACE  ");
			Console.WriteLine("\f");
		}
	}
}