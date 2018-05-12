using System;
using System.Collections;
using System.Text;

namespace TrainingCS
{
    class OddOccurrences
    {
        // This is the perfect solution.
        // The reason is that when you do result ^= Val; you perform an XOR operation.
        // And if you perform 'a XOR a' you get 0, which basically eliminates all values but the single odd one left.
        public int Solution(int[] A)
        {
            int result = 0;
            foreach (int Val in A)
            {
                result ^= Val;
                Console.WriteLine(result);
            }
            return result;
        }

        public int SolutionWorksButNotOptimized(int[] A)
        {
            if (A.Length == 1)
            {
                return A[0];
            }
            ArrayList CheckedInts = new ArrayList();
            for(int j = 0; j < A.Length; j++)
            {
                if (CheckedInts.Contains(A[j]))
                {
                    continue;
                }
                CheckedInts.Add(A[j]);
                int Count = 0;
                for (int i = j; i < A.Length; i++)
                {
                    if (A[i] == A[j])
                    {
                        Count++;
                    }
                }
                if (Count % 2 != 0)
                {
                    return A[j];
                }
            }
            return A[0];
        }
    }
}
