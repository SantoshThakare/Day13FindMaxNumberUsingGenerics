using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumProblem
{
    public class FindMax<T> where T : IComparable
    {
        public T ReturnMax(T v1, T v2, T v3, T v4)
        {
            if (v1.CompareTo(v2) > 0 && v1.CompareTo(v3) > 0 && v1.CompareTo(v4) > 0)
            {
                return v1;

            }
            if (v2.CompareTo(v3) > 0 && v2.CompareTo(v1) > 0 && v2.CompareTo(v4) > 0)
            {
                return v2;
            }
            if (v3.CompareTo(v1) > 0 && v3.CompareTo(v2) > 0 && v3.CompareTo(v4) > 0)
            {
                return v3;
            }
            else
            {
                return v4;
            }


        }
        public T[] value;
        public FindMax(T[] value)
        {
            this.value = value;
        }
        public T[] Sort(T[] value)
        {
            Array.Sort(value);
            return value;
        }
        public T MaxValue(params T[] value)
        {
            var Sorted_Values = Sort(value);
            return Sorted_Values[1];
        }
       
    }
}