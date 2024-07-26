using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_Session01.Genarics
{
    internal class Helper <T> where T :class, IComparable<T>, ICloneable, new()
    {
        #region Before Genarics
        //public static void Swap(ref int x,ref int y)
        //{
        //    int tmp = x;
        //    x = y;
        //    y = tmp;
        //}

        //// If you want to swap two double numbers or Points whats is your code?

        //public static void Swap(ref double x, ref double y)
        //{
        //    double tmp = x;
        //    x = y;
        //    y = tmp;
        //}

        //public static void Swap(ref Point x, ref Point y)
        //{
        //    Point tmp = x;
        //    x = y;
        //    y = tmp;
        //}

        //// Wrong use of method overloading you do not chang in brhaviour
        #endregion

        // public static T Sum(T X, T Y) { return X + Y; } invalid

        #region Genarics Constraint
        #region 1-Primary Constarant
        //  1.General Primary[0:1]
        //      class => T must be a class
        //      struct => T must be a struct
        //      Enum => T must be Enum
        //      Not Null => T must be not nullable C#8
        //  2.Special Primary Constrant
        //      (user-Defind class)  except sealed class
        //      Point => T Must be a Point or object from another class inherit from Point
        #endregion
        
        #region Secondery Constrant
        // interface Constrant [0:M]
        #endregion

        #region Constructor Constrant [0:1]
        // new()
        // T must be dattype having non-private prameterless consstructor
        // 
        #endregion
        #endregion
        public static void Swap(ref T x,ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public static int SearchArray(T[] Array, T Value)
        {
            if(Array is not null )
            {
                for(int i = 0; i < Array.Length; i++)
                {
                    if (Value.Equals(Array[i]))
                        return i;
                }
            }
            return -1;
        }
        public static void BubbleSort(ref T[] Array)
        {
            if(Array is not null)
            {
                for(int i = 0; i < Array.Length; i++)
                {
                    for(int j = 0; j < Array.Length - i - 1; j++)
                    {
                        if (Array[j].CompareTo( Array[j+1]) == 1)
                        {
                            Swap(ref Array[j], ref Array[j +1]);
                        }
                    }
                }
            }
        }
    }
}
