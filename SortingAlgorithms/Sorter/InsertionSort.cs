using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Sorter
{
    public class InsertionSort : ISorter
    {
        public string AlgorithName
        {
            get
            {
                return "Insertion Sort";
            }
        }

        public int[] Sort(int[] input)
        {
            return Sort1(input);
            //for (int i = 1; i < input.Length; i++)
            //{
            //    int x = input[i];
            //    for (int j = i-1; j >= -1; j--)
            //    {
            //        if(j == -1 || x > input[j])
            //        {
            //            input[j + 1] = x;
            //            break;
            //        }
            //        else
            //        {
            //            input[j + 1] = input[j];
            //            continue;
            //        }
            //    }
            //}
            //return input;
        }

        public int[] Sort1(int[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                int x = input[i];
                int j = i-1;
                for (;j >= 0; j--)
                {
                    if (x > input[j])
                    {
                        break;
                    }
                    else
                    {
                        input[j + 1] = input[j];
                    }
                }
                input[j + 1] = x;
            }
            return input;
        }
    }
}
