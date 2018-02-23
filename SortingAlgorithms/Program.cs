using SortingAlgorithms.Sorter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        private static List<ISorter> _sorters;

        static void Main(string[] args)
        {
            RegisterSorters();
            int[] arrayOfTen = GetRandomNumbers(10);
            int[] arrayOfHundred = GetRandomNumbers(100);
            int[] arrayOfSampleNumbers = { 9, 5, 6, 2, 4, 1, 3 }; 
            RunSorters(arrayOfSampleNumbers);
            RunSorters(arrayOfTen);
            RunSorters(arrayOfHundred);
            Console.Read();
        }

        private static void RunSorters(int[] arrayOfTen)
        {
            Console.WriteLine($"Input array : {string.Join(",", arrayOfTen)}");
            foreach (var sorter in _sorters)
            {
                Console.WriteLine($"Using {sorter.AlgorithName}");
                var sortedArray = sorter.Sort(arrayOfTen);
                Console.WriteLine($"Sorted array : {string.Join(",", sortedArray)}");
            }
        }

        private static void RegisterSorters()
        {
            _sorters = new List<ISorter>();
            //_sorters.Add(new InsertionSort())
            _sorters.Add(new SelectionSort());
        }

        private static int[] GetRandomNumbers(int count)
        {
            var randomGenerator = new Random();
            var array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = randomGenerator.Next(1, 1000);
            }
            return array;
        }
    }
}
