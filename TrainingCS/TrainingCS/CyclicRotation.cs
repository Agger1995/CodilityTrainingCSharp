using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace TrainingCS
{
    class CyclicRotation
    {
        public int[] solution(int[] A, int K)
        {
            int[] CycledArray = A;

            // Check for empty Array
            if (A.Length == 0)
            {
                return A;
            }

            for (int i = 0; i < K; i++)
            {
                // Store last element in temp variable
                int Temp = CycledArray[CycledArray.Length - 1];
                
                for(int j = CycledArray.Length - 1; j >= 0; j--)
                {
                    // Move j-1's element into index j
                    if(j == 0)
                    {
                        CycledArray[j] = Temp;
                        break;
                    }
                    CycledArray[j] = CycledArray[j - 1];
                }
            }
            return CycledArray;
        }
    }
}
