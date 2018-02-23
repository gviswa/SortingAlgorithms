using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Sorter
{
    public class SelectionSort : ISorter
    {
        public string AlgorithName
        {
            get
            {
                return "Selection Sort";
            }
        }

        public int[] Sort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < input.Length; j++)
                {
                    if(input[j] < input[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int x = input[i];
                input[i] = input[minIndex];
                input[minIndex] = x;
            }
            return input;
        }
    }
}
