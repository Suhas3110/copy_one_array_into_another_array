using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy_one_array_into_another_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]a=new int[3];
            int[]b=new int[3];
            Console.WriteLine("Enter the first array element");
            for(int i=0;i<3;i++)
            {
                a[i]=int.Parse(Console.ReadLine());
            }
            //Console.WriteLine("Enter the Second array element");
            //for (int i = 0; i < 3; i++)
            //{
            //    b[i] = int.Parse(Console.ReadLine());
            //}
            for (int i = 0;i < 3;i++)
            {
                b[i]=a[i];
            }
            Console.WriteLine("cpopy array element");
            for( int i = 0;i<3 ; i++)
            {
                Console.WriteLine(b[i]);
            }
            Console.ReadKey (); 
        }
    }
}
