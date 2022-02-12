using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumProblem
{
    public class FindMax<T> where T : IComparable
    {
        public T ReturnMax (T v1, T v2, T v3) 
        {
            if (v1.CompareTo(v2) > 0 &&  v1 .CompareTo(v3) > 0)
            {
                return v1;

            }
            if (v2.CompareTo (v3) > 0  && v2 .CompareTo(v1) >0)
            {
                return v2;
            }
            else
            {
                return v3;
            }


        }
    }
}
