using System.Collections;
using System.Linq.Expressions;

namespace Assignment01
{
    internal class Program
    {
        #region Q1
        public static void Swap(ref int X, ref int Y)
        {
            int Tmp = X;
            X = Y;
            Y = Tmp;
        }
        public static void BubbleSort(ref int[] Array)
        {
            if (Array is not null)
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    for (int j = 0; j < Array.Length - i - 1; j++)
                    {
                        if (Array[j] > Array[j + 1])
                            Swap(ref Array[j], ref Array[j + 1]);
                    }
                }
            }
        }
        #endregion

        #region Q3
        public static void ReverseArrayLest(ref ArrayList arrayList)
        {
           if(arrayList is not null)
            {
                int arrayListSize = arrayList.Count;
                ArrayList reversed = new ArrayList();
                for(int i = 0;i < arrayListSize; i++)
                {
                    reversed.Add(arrayList[(arrayListSize - i - 1)]);
                }
                arrayList = reversed;
            }
        }
        #endregion

        #region Q4
        public static List<int> FindEven (List<int> list)
        {
            List<int> evenList = new List<int>();
            if(list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0)
                        evenList.Add(list[i]);
                }
            }
            return evenList;
        }
        #endregion

        static void Main(string[] args)
        {
            #region Q1
            //int[] Array = { 6, 4, 1, 7, 2, 9, 3, 0, 5, 8 };
            //BubbleSort(ref Array);
            //foreach (int x in Array)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion

            #region Q2
            //Range<int> range = new Range<int>(1, 10);

            //Console.WriteLine(range.IsInRange(12) ? "Yes" : "No");

            //Console.WriteLine(Range<int>.Length(range.Maximum, range.Minimum));
            #endregion

            #region Q3
            //ArrayList arrayList = new ArrayList();
            //for(int i = 1; i <= 10; i++)
            //{
            //    arrayList.Add(i);
            //}
            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}
            //ReverseArrayLest(ref arrayList);
            //Console.WriteLine("After reverse:");
            //foreach(int i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Q4
            //List<int> list = new List<int>();
            //for(int i = 1; i <= 10; i++)
            //{
            //    list.Add(i);
            //}
            //List<int> EvenList = FindEven(list);
            //foreach(int i in EvenList)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Q5
            //FixedSizeList<int> fixdList = new FixedSizeList<int>(4);
            //fixdList.Add(0);
            //fixdList.Add(1);
            //fixdList.Add(2);
            //fixdList.Add(3);

            //fixdList.Print();

            //fixdList.Add(4);

            //Console.WriteLine(fixdList.Get(0));
            //try
            //{
            //    fixdList.Get(4);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            #endregion
        }
    }
}
