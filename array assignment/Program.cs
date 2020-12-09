using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of batches in cdac and the number of student in every batch");
            int b = Convert.ToInt32(Console.ReadLine());
            int[][] cdac = new int[b][];
            for (int i = 0; i < b; i++) { 
                cdac[i] = new int[Convert.ToInt32(Console.ReadLine())];
            }
            for (int i = 0; i < b; i++) {
                Console.WriteLine("Enter the marks for bathc {0}",i);
                for (int j = 0; j < cdac[i].Length; j++) { 
                    cdac[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < cdac.Length; i++)
            {
                for (int j = 0; j < cdac[i].Length; j++)
                {
                    Console.WriteLine("value for subscript {0},{1} is {2}  ", i, j, cdac[i][j]);

                }
            }
            Console.ReadLine();
        }
    }

    
}
