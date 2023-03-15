/*  Pequeno programa para achar e verificar números primos.
 *  inspirado no Algoritmo de Eratóstenes(também conhecido como Crivo de Eratóstenees)
 *  para encontrá-los aritmeticamente.
 *
 *  Written by Caio Cezar, 2023
 *      PrimeSeeker
 *       v0.9a
 *       
 *      *GPLv2
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PrimeSeeker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Elemento para verificação
            long elementN;
            // Versão String do Elemento
            string strElementN;
            //


            Console.WriteLine("Inicio...");
            Console.WriteLine("Insira um número natural: ");
            strElementN = Console.ReadLine();
            elementN = long.Parse(strElementN);
            Console.WriteLine(elementN);
            MultN n2a3 = new MultN();
            n2a3.CheckPrimeA(elementN);
            Console.WriteLine("...");
            Console.WriteLine();
            Console.WriteLine("Fim...");


            Console.ReadLine();
        }
    }
}