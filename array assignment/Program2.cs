using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_class_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] stu = new Student[5];
            

            for (int i=0;i<stu.Length;i++) {

                    stu[i] = new Student();
                    stu[i].ROLLNO = Convert.ToInt32(Console.ReadLine());
                    stu[i].NAME = Console.ReadLine();
                    stu[i].MARKS = Convert.ToDecimal(Console.ReadLine());
                
            }

            for (int i = 0; i < stu.Length; i++)
            {
                
                
                    Console.WriteLine("rollnumber= "+ stu[i].ROLLNO+" Name = "+ stu[i].NAME +" Marks = "+ stu[i].MARKS);
                
            }
            Console.ReadLine();
        }
    }

    struct Student {
        private string Name;
        public string NAME {
            set {
                if (value == "")
                    Console.WriteLine("Invalid Value!!!");
                else
                    Name = value;
            }
            get {
                return Name;
            }
        }
        private int RollNo;
        public int ROLLNO {
            set {
                if (value >= 1 && value < 10)
                    RollNo = value;
                else
                    Console.WriteLine("invalid roll number!!!");
            }
            get
            {
                return RollNo;
            }
        }
        private decimal Marks;
        public decimal MARKS {
            set {
                if (value >= 1 && value <= 100)
                    Marks = value;
                else
                   Console.WriteLine("invalid Marks!!!");
            }
            get
            {
                return Marks;
            }
        }

        public Student(String Name="", int RollNo=2, decimal Marks=33)
        {
            this.Name = Name;
            this.RollNo = RollNo;
            this.Marks = Marks;
        }
    }
}
