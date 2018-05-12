using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace TrainingCS
{
    class BinaryGap : ISolution
    {
        /**
         * This solution takes N as input, and finds the longest gap between 1's in that integers row of bits
         * 
         * Example: N = 1041
         * Longest gap between 1's = 5
         * */
        public int Solution(int N)
        {
            // BitArray is an array of true/false values based on a ByteArray input
            BitArray Bits = new BitArray(BitConverter.GetBytes(N));

            byte HighestZeroCount = 0;
            byte ZeroCount = 0;
            bool Counting = false;

            foreach(bool Bit in Bits)
            {
                if (Counting && Bit == false)
                {
                    ZeroCount++;
                }

                if (Bit == true && Counting)
                {
                    Counting = false;
                    if(ZeroCount > HighestZeroCount)
                    {
                        HighestZeroCount = ZeroCount;
                    }
                    ZeroCount = 0;
                }

                if (Bit == true)
                {
                    Counting = true;
                }
            }

            return HighestZeroCount;
        }
    }
}
