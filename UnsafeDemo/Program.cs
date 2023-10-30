using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsafeDemo
{
    internal class Program
    {
        unsafe static  void M1()
        {

            int ab = 32;
            int* p = &ab;
            Console.WriteLine("Value of ab= " + *p);
        }


 static void Main(string[] args)
        {
            unsafe
            {
                int[] arr = {10,203,123,21 };
                fixed (int* p = arr) 
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine("Address of arr [{0}] ={1}", i,(int)(p+i));
                        Console.WriteLine("Value of arr [{0}] ={1}", i, *(p + i));
                    }
                }

            }
            M1();
            int a1 = 90;
            Console.WriteLine(a1);
            Console.ReadLine();

        }
    }
}
