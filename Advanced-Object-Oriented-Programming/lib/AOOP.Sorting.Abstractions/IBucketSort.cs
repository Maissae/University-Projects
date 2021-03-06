using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AOOP.Sorting.Models;

namespace AOOP.Sorting.Abstractions
{
    public interface IBucketSort<T> where T : IComparable<T>
    {
        IList<T> Sort(IList<T> values, ISorter<T> algorithm);
    }
}