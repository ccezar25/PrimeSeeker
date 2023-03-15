using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeSeeker
{
    public class MultN
    {
        //Values
        long element0;

        //Methods

        public bool CheckPrimeA(long a)
        {
            long b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13;
            b2 = a % 2;
            b3 = a % 3;
            b4 = a % 4;
            b5 = a % 5;
            b6 = a % 6;
            b7 = a % 7;
            b8 = a % 8;
            b9 = a % 9;
            b10 = a % 10;
            b11 = a % 11;
            b12 = a % 12;
            b13 = a % 13;
            if (b2 == 0 && b2 != a)
            {
                Console.WriteLine("Não é primo!");
                return false;
            }
            if (b3 == 0 && b3 != a)
            {
                Console.WriteLine("Não é primo!");
                return false;
            }
            if (b4 == 0 && b4 != a)
            {
                Console.WriteLine("Não é primo!");
                return false;

            }
            if (b5 == 0 && b5 != a)
            {
                Console.WriteLine("Não é primo!");
                return false;

            }
            if (b6 == 0 && b6 != a)
            {
                Console.WriteLine("Não é primo!");
                return false;
            }
            if (b7 == 0 && b7 != a)
            {
                Console.WriteLine("Não é primo!");
                return false;

            }
            if (b8 == 0 && b8 != a)
            {
                Console.WriteLine("Não é primo!");
                return false;

            }
            if (b9 == 0 && b9 != a)
            {
                Console.WriteLine("Não é primo!");
                return false;

            }
            if (b10 == 0 && b10 != a)
            {
                Console.WriteLine("Não é primo!");
                return false;

            }
            if (b11 == 0 && b11 != a)
            {
                Console.WriteLine("Não é primo!");
                return false;

            }


            if (b12 == 0 && b12 != a)
            {
                Console.WriteLine("Não é primo!");
                return false;

            }

            if (b13 == 0 && b13 != a)
            {
                Console.WriteLine("Não é primo!");
                return false;

            }
            else
            {
                Console.WriteLine("Pode ser primo!");
                return true;
            }
        }
    }     
}
    