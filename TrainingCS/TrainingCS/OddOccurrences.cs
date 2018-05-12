using System;
using System.Collections;
using System.Text;

namespace TrainingCS
{
    class OddOccurrences
    {
        public int Solution(int[] A)
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
