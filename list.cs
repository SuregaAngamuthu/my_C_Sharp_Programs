using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            Intern i1 = new Intern()
            {
                name = "Surega",
                account_no = 123,
                IFSC_CODE = "AB12C",
                Aadhaar_no = 123457890123,
                Salary = 25000
            };
            Intern i2 = new Intern()
            {
                name = "Poos",
                account_no = 456,
                IFSC_CODE = "AB13C",
                Aadhaar_no = 456789012345,
                Salary = 80000
            };
            Intern i3 = new Intern()
            {
                name = "Kavya",
                account_no = 789,
                IFSC_CODE = "AB14C",
                Aadhaar_no = 890123456789,
                Salary = 60000
            };
            Intern i4 = new Intern()
            {
                name = "Dharanipriya",
                account_no = 012,
                IFSC_CODE = "AB15C",
                Aadhaar_no = 234567890123,
                Salary = 90000
            };
            List<Intern> interns = new List<Intern>(3);
            interns.Add(i1);
            interns.Add(i2);
            interns.Add(i3);
            interns.Add(i4);
            interns.Sort();
            foreach(Intern i in interns)
            {
                Console.WriteLine(i.Salary);
            }
            Intern i11 = interns[0];
            Intern i12 = interns[1];
            Intern i13 = interns[2];
            Intern i14 = interns[3];
            Console.WriteLine($"NAME -->{i1.name}\nACCOUNT NUMBER -->{i1.account_no}\nIFSC CODE -->{i1.IFSC_CODE}\nAADHAAR NUMBER -->{i1.Aadhaar_no}");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"NAME -->{i2.name}\nACCOUNT NUMBER -->{i2.account_no}\nIFSC CODE -->{i2.IFSC_CODE}\nAADHAAR NUMBER -->{i2.Aadhaar_no}");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"NAME -->{i3.name}\nACCOUNT NUMBER -->{i3.account_no}\nIFSC CODE -->{i3.IFSC_CODE}\nAADHAAR NUMBER -->{i3.Aadhaar_no}");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"NAME -->{i4.name}\nACCOUNT NUMBER -->{i4.account_no}\nIFSC CODE -->{i4.IFSC_CODE}\nAADHAAR NUMBER -->{i4.Aadhaar_no}");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
    public class Intern : IComparable<Intern>
    {
        public string name;
        public int account_no;
        public string IFSC_CODE;
        public long Aadhaar_no;
        public int Salary;
        
        public int CompareTo(Intern other)
        {
            if (this.Salary > other.Salary)
                return 1;
            else if (this.Salary < other.Salary)
                return -1;
            else
                return 0;
        }

    }
}
