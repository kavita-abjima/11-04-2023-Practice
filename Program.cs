using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class DevideByZero
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter First Number :-");
            //int num1=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second Number :-");
            //int num2 = int.Parse(Console.ReadLine());
            //try
            //{
            //    int result = num1 / num2;
            //    Console.WriteLine("Devision Result is :", result);
            //}
            //catch(DivideByZeroException ex) {
            //    Console.WriteLine("You cannot devide a Number by Zero: {0}", ex);
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine("Remaining statement one");
            //Console.WriteLine("Remaining statement Two");
            //Console.WriteLine("Remaining statement Three");

            //Index out of range Exception
            //int[] arr = new int[3];
            //try {
            //    arr[0] = 11;
            //    arr[1] = 22;
            //    arr[2] = 33;
            //    arr[3] = 44;
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Array's range is exceeded");
            //    Console.WriteLine(ex.Message);
            //}
            
            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            ////Handling Null Reference Exception
            //try {
            //    string name = null;
            //    Console.WriteLine(name.Length);
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine("String value is null");
            //    Console.WriteLine(ex.Message);
            //}

            //Format Exception
            Console.WriteLine("Enter a Number :-");
            string Number= Console.ReadLine();
            try {
                int num = int.Parse(Number);
                Console.WriteLine("Number is :" + num);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("String format is invalid");
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadLine();
        }
    }
}
