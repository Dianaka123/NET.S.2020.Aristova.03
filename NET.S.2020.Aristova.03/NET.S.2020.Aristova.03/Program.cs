using System;
using System.Collections.Generic;
using System.Text;

namespace NET.S._2020.Aristova._03
{
    class Program
    {
        public static void Main(string[] args)
        {
            NOD nod = new NOD(new [] { 12, 69, 27 });
            
            Console.WriteLine($"NOD Evklid: {nod.EvklidNOD()}\n" +
                              $"Bin Time: {nod.GetEvklidTime()} ml\n" +
                              $"Binary Evklid: {nod.BinaryGCD()}\n" +
                              $"Time: {nod.GetBinTime()} ml" );

        }
    }
}
