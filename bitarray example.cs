using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
 {
    class Program
    {
        // Printing BitArray
        public static void PrintBarr(string name, BitArray ba)
        {
            Console.Write(name + " : ");
            for (int x = 0; x < ba.Length; x++)
                Console.Write(ba.Get(x) + " ");
            Console.WriteLine();
        }
        
        public static void Main(string[] args)
        {
            BitArray ba1 = new BitArray(4);
            BitArray ba2 = new BitArray(4);
            
            ba1.SetAll(true);
            ba2.SetAll(false);
            
            ba1.Set(2, false);
            ba2.Set(3, true);
            
            PrintBarr("ba1", ba1);
            PrintBarr("ba2", ba2);
            Console.WriteLine();
            
            PrintBarr("ba1 AND ba2", ba1.And(ba2));
            PrintBarr("    NOT ba2", ba2.Not());
        }
    }
}