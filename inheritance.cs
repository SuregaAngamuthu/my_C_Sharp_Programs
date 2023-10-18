using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace inheritance
{
    class Program
    {
        static void Main()
        {
            CSE cse = new CSE();
            cse.name = "Surega";
            cse.college_name = "JSREC";
            cse.batch = "2024";
            cse.team_name = "C#";
            cse.skills_in_Computer = "C programming and Web Development";
            cse.Print();
            ECE ece = new ECE();
            ece.name = "Uma";
            ece.college_name = "JSREC";
            ece.batch = "2024";
            ece.team_name = "Ruby";
            ece.skills_in_Electronics = "CAD skills";
            ((Student)ece).Print();
            Console.ReadKey();

        }
    }
    public class Student
    {
        public string name;
        public string college_name;
        public string batch;
        public string team_name;
        public void Print()
        {
            Console.WriteLine("My Name is " + name + " and I'm from " + college_name + " " + batch + " currently I'm in the team of " 
                + team_name+" I have a strong knowledge in ");
            //Console.ReadKey();
        }

    }
    public class CSE : Student
    {
        public string skills_in_Computer;
        public new void Print()
        {
            Console.WriteLine("My Name is " + name + " and I'm from " + college_name + " " + batch + " currently I'm in the team of "
                + team_name + " I have a strong knowledge in "+skills_in_Computer);
            //Console.ReadKey();
        }

        //Console.ReadKey();


    }
    public class ECE : Student
    {
        public string skills_in_Electronics;
        public new void Print()
        {
            Console.WriteLine("My Name is " + name + " and I'm from " + college_name + " " + batch + " currently I'm in the team of "
                + team_name + " I have a strong knowledge in " + skills_in_Electronics);
        }
    }
}
