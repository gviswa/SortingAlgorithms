using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Sorter
{
    public interface ISorter
    {
        string AlgorithName { get; }
        int[] Sort(int[] input);
    }
}
