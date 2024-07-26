using AdvancedC_Session01.Genarics;
using AdvancedC_Session01.PartialClass;

namespace AdvancedC_Session01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Partial Class
            //Employee employee = new Employee()
            //{
            //    Id = 1,
            //    Name = "Mohamed",
            //    Salary = 5500
            //};
            //Console.WriteLine(employee);
            #endregion

            #region Genarics
            #region Befor Genarics

            //int A = 2, B = 3;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Console.WriteLine("After Swaping:");
            //Helper.Swap(ref A,ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            //double X = 2.5, Y = 3.5;
            //Console.WriteLine($"X: {X}");
            //Console.WriteLine($"Y: {Y}");
            //Console.WriteLine("After Swaping:");
            //Helper.Swap(ref X, ref Y);
            //Console.WriteLine($"X: {X}");
            //Console.WriteLine($"Y: {Y}");

            //Point P1 = new Point(1, 2);
            //Point P2 = new Point(3, 4);
            //Console.WriteLine($"P1: {P1}");
            //Console.WriteLine($"P2: {P2}");
            //Console.WriteLine("After Swaping:");
            //Helper.Swap(ref P1, ref P2);
            //Console.WriteLine($"P1: {P1}");
            //Console.WriteLine($"P2: {P2}");
            #endregion

            #region After Genarics
            //int A = 1, B = 2;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Console.WriteLine("After Swaping:");
            //Helper.Swap<int>(ref A, ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            //double A = 1.5,  B = 2.5;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Console.WriteLine("After Swaping:");
            //Helper.Swap(ref A, ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            //Point P1 = new Point(1, 2);
            //Point P2 = new Point(3, 4);
            //Console.WriteLine($"P1: {P1}");
            //Console.WriteLine($"P2: {P2}");
            //Console.WriteLine("After Swaping:");
            //Helper.Swap(ref P1, ref P2);
            //Console.WriteLine($"P1: {P1}");
            //Console.WriteLine($"P2: {P2}");

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, };
            //int pos = Helper.SearchArray(numbers, 5);
            //Console.WriteLine(pos);

            //int[] Numbers = { 3, 7, 9, 1, 5, 4, 2, 0, 8, 6 };
            //Helper<int>.BubbleSort(ref Numbers);
            //foreach (int i in Numbers)
            //{
            //    Console.WriteLine(i);
            //}

            Employee e1 = new Employee() { Id = 1, Name = "Mohamed", Salary = 10000 };
            Employee e2 = new Employee() { Id = 4, Name = "Adel", Salary = 60000 };
            Employee e3 = new Employee() { Id = 2, Name = "sara", Salary = 40000 };
            Employee e4 = new Employee() { Id = 3, Name = "Nourhan", Salary = 50000 };
            Employee[] employees = new Employee[] { e1, e2, e3, e4 };

            Helper<Employee>.BubbleSort(ref employees);
            foreach (Employee e in employees)
            {
                Console.WriteLine(e);
            }

            #endregion
            #endregion


        }
    }
}
