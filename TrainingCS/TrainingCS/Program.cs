using System;

namespace TrainingCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.BinaryGap();
            //program.CyclicRotation();
            program.OddOccurrences();
        }

        public void BinaryGap()
        {
            BinaryGap CodilityOne = new BinaryGap();
            int N = 1041;
            Console.WriteLine(CodilityOne.Solution(N));
            Console.ReadLine();
        }

        public void CyclicRotation()
        {
            CyclicRotation CodilityTwo = new CyclicRotation();
            int[] A = {3, 8, 9, 7, 6 };
            
            int[] CycledArray = CodilityTwo.solution(A, 3);
            foreach (int val in CycledArray)
            {
                Console.Write(val);
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        public void OddOccurrences()
        {
            OddOccurrences CodilityTwo = new OddOccurrences();
            int[] A = { 9, 3, 9, 3, 9, 7, 9 };
            Console.WriteLine(CodilityTwo.Solution(A));
            Console.ReadLine();
        }
    }
}
