using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {   //1
            float a = 52.130f;
            sbyte b = -115;
            uint c = 4825932;
            byte d = 97;
            short e = -1000;
            ushort f = 20000;
            byte g = 224;
            uint h = 970700000;
            byte i = 112;
            sbyte j = -44;
            int k = -1000000;
            ushort l = 1990;
            ulong m = 123456789123456789;
            //3
            float firtToCompare = 5.000001f;
            float secondToCompare = 5.000011f;
            if (firtToCompare < secondToCompare)
                Console.WriteLine("{0} is smaller than {1}", firtToCompare, secondToCompare);
            //4
            int hexadecimal = 0x100;
            //5
            char unicode = '\u0048';
            //6
            bool isMale = true;
            //7&8
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + ' ' + world;
            string fromObject = (string)helloWorld;
            //9
            string text = "The \"use\" of quotations causes difficulties.";
            string text2 = @"The ""use"" of quotations causes difficulties.";
            //10
            Console.WriteLine("\n   {0}{0} {0}{0}", 'o');
            Console.WriteLine("   {0} {0} {0}", 'o');
            Console.WriteLine("    {0} {0}", 'o');
            Console.WriteLine("     {0}", 'o');
            //11
            Console.WriteLine("\n     {0}",'\u00A9');
            Console.WriteLine("    {0} {0}", '\u00A9');
            Console.WriteLine("  {0}     {0}", '\u00A9');
            Console.WriteLine("{0}  {0} {0} {0}  {0}", '\u00A9');
            //12
            string firstName;
            string lastName;
            sbyte age;
            char gender;
            int employeeNumber;
            //13
            int firstToSwap = 5;
            int secondToSwap = 10;
            int buffor=firstToSwap;
            firstToSwap = secondToSwap;
            secondToSwap = buffor;
            Console.WriteLine("First: {0}; Second: {1}", firstToSwap, secondToSwap);
            



        }
    }
}


