using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] arr = new Employee[10];
            for (int i = 0; i < 10; i++) {
                arr[i] = new Employee();
                Console.WriteLine("enter Employee no {0} details",i);
                arr[i].NAME = Console.ReadLine();
                arr[i].SALARY = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter Employee number for Details");
            int E = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Details of Employee no {0} : ",E);
            for (int i = 0; i < 10; i++)
            {
                if (arr[i].EMPNO == E)
                {
                    Console.WriteLine("name : {0}", arr[i].NAME);
                    Console.WriteLine("salary : {0}", arr[i].SALARY);
                }
                
            }
            Console.ReadLine();
        }
    }

    public class Employee {
        private static int increment=0;
        private int Empno;
        public int EMPNO {
            get {
                return Empno; 
            }
        }

        private String name;
        public String NAME {
            set {
                if (value == "")
                    Console.WriteLine("invalid name");
                else
                    name = value;
            }
            get {
                return name;
            }
        }

        private decimal salary;
        public decimal SALARY {
            set {
                if (value > 10000)
                    salary = value;
                else
                    Console.WriteLine("salary can not be less than 10000");
            }
            get {
                return salary;
            }
        }

        public Employee(String name="",decimal salary=11000) {
            ++increment;
            Empno = increment;
            this.name = name;
            this.salary = salary;
        }

    }
}
