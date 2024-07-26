using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_Session01.Genarics
{
    internal class Point:IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }
     
        public Point(int x, int y)
        {
            this.X= x;
            this.Y = y;
        }

        public override string ToString()
        {
            return $"{X}, {Y}";
        }

        #region Genaric IComparable
        public int CompareTo(Point? other)
        {
            if (other is null) return 1;
            if (this.X == other.X)
                return this.Y.CompareTo(other.Y);
            else
                return this.X.CompareTo(other.Y);

        }
        #endregion

        #region IComparable
        //public int CompareTo(object? obj)
        //{
        //    ////Point? other = (Point?)obj; // exciplict casting unsafe casting
        //    // is operator returns true in 3 cases
        //    //1 - obj is object of type Point
        //    //2 - obj is another object inherit from Point
        //    //3 - obj is null
        //    //if (obj is Point other02)
        //    //{
        //    //    if (other02 is null) return 1;
        //    //    if (this.X == other02.X)
        //    //        return this.Y.CompareTo(other02.Y);
        //    //    else
        //    //        return this.X.CompareTo(other02.Y);
        //    //}
        //    //return 1;

        //    //or using (as) operator
        //    // as operator will return true if an only if the obj is Point
        //    //if casting fail will retun null

        //    Point? other03 = obj as Point;
        //    if (other03 is null) return 1;
        //    if (this.X == other03.X)
        //        return this.Y.CompareTo(other03.Y);
        //    else
        //        return this.X.CompareTo(other03.X);
        //}
        #endregion
    }
}
