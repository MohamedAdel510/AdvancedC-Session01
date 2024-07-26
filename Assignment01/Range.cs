using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    internal class Range<T> where T : struct, IComparable
    {
        public T Minimum { get; set; }
        public T Maximum { get; set; }
        public Range(T minimum, T maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }

        public bool IsInRange(T value)
        {
            if(value.CompareTo(Minimum) == 1 && value.CompareTo(Maximum) == -1)
            { return true; }
            return false;
        }
        public static T Length(T maximum, T minimum)
        {
             return (dynamic)maximum - (dynamic)minimum;  
        }
        public static Range<T> operator -(Range<T> left, Range<T> right)
        {
            return new Range<T>(Length(left.Minimum, right.Minimum), Length(left.Maximum, right.Maximum));
        }
    }
}
