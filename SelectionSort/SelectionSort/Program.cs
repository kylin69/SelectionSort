using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = { 6, 31, 72, 2, 53, 49, 66, 13, 83, 21, 15, 70 };
			Sort(array);
		}

		static void Sort(int[] array)
		{
			int min = 0;
			int temp = 0;

			int length = array.Length;
			for(int i = 0; i< length-1; i++)
			{
				min = i;
				for(int j = i+1; j<length; j++)
				{
					if(array[j] < array[min])
					{
						min = j;
					}
				}

				temp = array[min];
				array[min] = array[i];
				array[i] = temp;
			}
		}
	}
}
