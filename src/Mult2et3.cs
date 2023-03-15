using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeSeeker
{
    public class Mult2et3
    {
        //Values
        int element0;

        //Methods


        public bool CheckPrimeA(int a)
        {
            int b2;
            int b3;
            b2 = a % 2;
            b3 = a % 3;
            if (b2 == 0 && b2 != a)
            {
                Console.WriteLine("Não é primo!");
                return false;
            }
            if(b3 == 0 && b3 != a) {
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
