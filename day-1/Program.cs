using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            employee o1 = new employee();
            employee o2 = new employee();
            employee o3 = new employee();
            Console.WriteLine(o1.EMPNO);
            Console.WriteLine(o2.EMPNO);
            Console.WriteLine(o3.EMPNO);
            Console.ReadLine();
        }
    }

    class employee {

        private static int id = 0;

        private String Name;
        public String NAME {
            set {
                if (value == "")
                    Console.WriteLine("invalid name");
                else
                    Name = value;
            }
            get {
                return Name;
            }
        }

        private int EmpNo=0;
        public int EMPNO {
            get {
                return EmpNo;
            }
        }

        private decimal Basic;
        public decimal BASIC {
            set {
                if (value > 10 && value < 40)
                    Basic = value;
                else
                    Console.WriteLine("invalid Basic");
            }
            get {
                return Basic;
            }
        }

        private short DeptNo;
        public short DEPTNO {
            set {
                if (value > 0)
                {
                    DeptNo = value;
                }
                else {
                    Console.WriteLine("invalid DeptNo");
                }
            }
            get {
                return DeptNo;
            }
        }

        public decimal GetNetSalary(decimal Basic ) {
            decimal net = 2400 + 420 + Basic - ((decimal)0.10 * Basic);
            return net;
        }

        public employee(String Name,decimal Basic,short DeptNo) {
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }

        public employee(String Name, decimal Basic)
        {
            this.Name = Name;
            this.Basic = Basic;
        }

        public employee(String Name)
        {
            this.Name = Name;
        }

        public employee()
        {
            id++;
            this.EmpNo = id;
        }
    }
}
