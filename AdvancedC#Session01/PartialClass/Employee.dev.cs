using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_Session01.PartialClass
{
    internal partial class Employee : IComparable<Employee>
    {
        public double Salary {  get; set; }

        public int CompareTo(Employee? e)
        {
            if (this.Id > e?.Id) return 1;
            else if (this.Id < e?.Id) return -1;
            return 0;
        }

        //public int CompareTo(object? obj)
        //{
        //    Employee? e = (Employee?) obj;
        //    if (this.Id > e?.Id) return 1;
        //    else if (this.Id < e?.Id) return -1;
        //    return 0;
        //}

        public override string ToString()
        {
            return $"ID: {Id}\nName: {Name}\nSalary:{Salary}";
        }
    }
}
