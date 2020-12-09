using System;

namespace day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i =5;
            //const int k = 2;
            //const int p = k / 2;
            //Console.WriteLine(p);
            //Console.ReadLine();

            char d = 'k';
            int c;
            c = d;
            Console.WriteLine(c);
            // i=int.Parse(Console.ReadLine());

            //int j;
            //j = Convert.ToInt32(Console.ReadLine());
        }
    }
}

namespace inheritance {
    class Program
    {
        static void Main2(string[] args)
        {
            //Base o1 = new derived();
            //o1.display();

            Base o2 = new Base();
            o2.display();

            derived o3 = new derived();
            o3.display();

            derived2 o4 = new derived2();
            o4.display();

            derived2 o5 = new derived3();
            o5.display();
        }
    }

    public class Base {
        public virtual void display()
        {
            Console.WriteLine("Base class");
        }
    }

    public class derived : Base
    {
       
        public override void display() {
            Console.WriteLine("derived class");
        }
    }

    public class derived2 : derived
    {

        public sealed override void display()
        {
            Console.WriteLine("derived2 class");
        }
    }

    public class derived3 : derived2
    {

        public new void display()
        {
            Console.WriteLine("derived3 class");
        }
    }
}

namespace Abstract{
    class Program
    {
        static void Main3(string[] args)
        {
            hello h = new hello();
            h.display();
        }
    }

    public sealed class hello {
        int i=3;

        public void display() {
            Console.WriteLine(this.i);
        }
    }

}
