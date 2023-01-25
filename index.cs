namespace Homework2
{
    using System;
    using System.Diagnostics;
    internal class Program
    {
        public static int start = 10000, N2 = 100000, N3 = 1000000, N4 = 10000000, N5 = 100000000, N6 = 1000000000;

        // Disjoint array filler
        public static int[] arrayFiller(int[] myArray, int start, int N)
        {
            for(int i=start; i <= N; i++)
            {
                myArray[i] = i+1;
            }

            return myArray;
        }

        // generates total_Ns number of Ns in the powers of 10 from start
        public static int[] N_generator(int start, int total_Ns)
        {
            int[] myArray = new int[total_Ns];
            for (int i=0; i<total_Ns; i++)
            {
                myArray[i] = start;
                start *= 10;
            }
            return myArray;
        }

        public static bool disjoint1(int[] groupA, int[] groupB, int[] groupC)
        {
            foreach (int a in groupA)
                foreach (int b in groupB)
                    foreach (int c in groupC)
                        if ((a == b) && (b == c))
                            return false;
            return true;
        }

        public static bool disjoint2(int[] groupA, int[] groupB, int[] groupC)
        {
            foreach (int a in groupA)
                foreach (int b in groupB)
                    if (a == b)
                        foreach (int c in groupC)
                            if (a == c)
                                return false;
            return true;
        }


        static void Main(string[] args)
        {
            int N = 5;

            int[] arrayOfNs = new int[N];
            arrayOfNs = N_generator(start, N);;

            int[][] group1 = new int[3][];

            // creates and initializes 3 groups of size arrayOfNs[0]
            int j = 0;
            int z = arrayOfNs[0];
            for (int i = 0; i < group1.Length; i++)
            {
                group1[i] = new int[arrayOfNs[0]];
                group1[i] = arrayFiller(group1[i], j, z);
                j += arrayOfNs[0];
                z += arrayOfNs[0];
            }


            Stopwatch stopWatch = new Stopwatch();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime1, elapsedTime2;


            stopWatch.Start();
            disjoint1(group1[0], group1[1], group1[2]);
            stopWatch.Stop();

            elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime1);


            stopWatch.Start();
            disjoint1(group1[0], group1[1], group1[2]);
            stopWatch.Stop();

            elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime2);

        }
    }

}
