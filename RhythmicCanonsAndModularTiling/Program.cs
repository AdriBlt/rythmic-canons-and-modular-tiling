using System;
using System.Collections.Generic;

namespace RhythmicCanonsAndModularTiling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private int[] GetRythmicPattern(int k)
        {
            return new int[3] { 0, 1, k };
        }

        private Tiling GenerateModularTiling(int[] pattern, int mod)
        {
            List<int> tiling = new List<int>();
            int size = 0;
            int firstEmpty = 0;

        }
    }
}
