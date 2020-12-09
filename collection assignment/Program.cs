using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_assign
{
    class Program
    {
        static void Main(string[] args)
        {
            String option = "yes";
            SortedList<int, employee> e = new SortedList<int, employee>();
            
            while (true)
            {
                Console.WriteLine("Select An Option!!!");
            Console.WriteLine("a) insert the details of employee");
            Console.WriteLine("b) Display the Employee with highest Salary");
            Console.WriteLine("c) Search for an employee");
            Console.WriteLine("d) Display the details of nth employee");
            Console.WriteLine("e) exit");

           
                switch (Console.ReadLine())
                {
                    case "a":

                        for (int i = 1; option == "yes" || option == "Yes" || option == "YES"; i++)
                        {
                            Console.WriteLine("enter the details");
                            e.Add(i, new employee());
                            e[i].NAME = Console.ReadLine();
                            e[i].BASIC = Convert.ToDecimal(Console.ReadLine());
                            e[i].DEPTNO = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("to insert more employee details type yes otherwise no");
                            option = Console.ReadLine();
                        }
                        break;

                    case "b":
                        decimal max = e[1].BASIC;
                        for (int i = 2; i <= e.Count; i++)
                        {
                            if (max < e[i].BASIC)
                                max = e[i].BASIC;
                        }
                        Console.WriteLine("Highest salary= " + max);
                        break;

                    case "c":
                        Console.WriteLine("enter the employee number!!");
                        int j = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= e.Count; i++)
                        {
                            if (e[i].EMPNO == j)
                            {
                                Console.WriteLine("employee name= " + e[i].NAME + " employee salary= " + e[i].BASIC + " depart number = " + e[i].DEPTNO);
                            }
                            else
                            {
                                Console.WriteLine("invalid choice!!!");
                            }
                        }
                        break;

                    case "d":
                        Console.WriteLine("enter the number!!");
                        int k = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= e.Count; i++)
                        {
                            if (i == k)
                            {
                                Console.WriteLine("employee name= " + e[i].NAME + " employee salary= " + e[i].BASIC + " depart number = " + e[i].DEPTNO);
                            }
                            else
                            {
                                Console.WriteLine("invalid choice!!!");
                            }
                        }
                        break;

                    case "e":
                        return;

                    default:
                        Console.WriteLine("invalid choice!!");
                        break;
                }
            }
            Console.ReadLine();

        }
    }

    public class employee
    {

        private static int id = 0;

        private String Name;
        public String NAME
        {
            set
            {
                if (value == "")
                    Console.WriteLine("invalid name");
                else
                    Name = value;
            }
            get
            {
                return Name;
            }
        }

        private int EmpNo = 0;
        public int EMPNO
        {
            get
            {
                return EmpNo;
            }
        }

        private decimal Basic;
        public decimal BASIC
        {
            set
            {
                if (value >= 10000 && value <= 80000)
                    Basic = value;
                else
                    Console.WriteLine("invalid Basic");
                    
            }
            get
            {
                return Basic;
            }
        }

        private short DeptNo;
        public short DEPTNO
        {
            set
            {
                if (value > 0)
                {
                    DeptNo = value;
                }
                else
                {
                    Console.WriteLine("invalid DeptNo");
                }
            }
            get
            {
                return DeptNo;
            }
        }

        

        public employee(String Name = "", decimal Basic = 10000, short DeptNo = 1)
        {
            id++;
            this.EmpNo = id;
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }

        public virtual void display()
        {
            Console.WriteLine("EmpNo= " + EmpNo + "Name= " + Name + "Basic= " + Basic + "DeptNo= " + DeptNo);
        }

        
    }
}
