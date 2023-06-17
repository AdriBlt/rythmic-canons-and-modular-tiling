using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RhythmicCanonsAndModularTiling.utils;

namespace RhythmicCanonsAndModularTiling
{
    class TilingGenerator
    {
        List<int> tiling = new List<int>();
        List<int> bits = new List<int>();
        int firstEmpty = 0;

        public TilingGenerator()
        {
        }

        public Tiling GenerateModularTiling(int[] pattern, int mod)
        {
            this.tiling.Clear();
            this.bits.Clear();
            this.firstEmpty = 0;
            this.AddPattern(pattern, mod, 0);
        }

        private void AddPattern(int[] pattern, int mod, int offset)
        {
            this.tiling.Add(offset);
            foreach (int bit in pattern)
            {
                int index = bit + offset;
                int value = this.bits.GetOrDefault(index);
                int newValue = (value + 1) % mod;
                this.bits[index] = newValue;


                // last bit
                int size = this.bits.Select((b, i) => (b, i)).LastOrDefault(p => p.b > 0).i;
                // first empty


                if (newValue > 0)
                {
                    if (this.firstEmpty == index)
                    {
                        int i = index + 1;
                        for (; i < this.bits.Count; i++)
                        {
                            if (this.bits[i] == 0)
                            {
                                this.firstEmpty = i;
                                break;
                            }
                        }

                        if (this.firstEmpty == index)
                        {
                            this.firstEmpty = i;
                        }
                    }
                }
                else
                {
                    if (index == )
                }
            }
        }

    }

    struct Tiling
    {
        int[] pattern;
        int[] tiling;
        int size;

        public Tiling(int[] pattern, int[] tiling, int size)
        {
            this.pattern = pattern;
            this.tiling = tiling;
            this.size = size;
        }
    }
}
