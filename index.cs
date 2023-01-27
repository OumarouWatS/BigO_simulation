namespace Homework2
{
    using System;
    using System.Diagnostics;
    internal class Program
    {
        public static int N1 =500;

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
                            {
                                Console.WriteLine("Found" + a + b + c);
                                return false;
                            }
            return true;
        }


        static void Main(string[] args)
        {
            int[] group1 = new int[N1];
            int[] group2 = new int[N1];
            int[] group3 = new int[N1];


            for (int i = 0; i < N1; i++) {
                group1[i] = i+1;
            }

            for (int i = 0; i < N1; i++)
            {
                group2[i] = i + 1 + N1;
            }

            for (int i = 0; i < N1; i++)
            {
                group3[i] = i + 1 + 2*N1;
            }

            for (int i = 0; i < N1; i++)
            {
                Console.WriteLine("Group1: " + group1[i]);
            }
            for (int i = 0; i < N1; i++)
            {
                Console.WriteLine("Group2: " + group2[i]);
            }
            for (int i = 0; i < N1; i++)
            {
                Console.WriteLine("Group3: " + group3[i]);
            }


            Stopwatch stopWatch = new Stopwatch();

           
            // a != b & b != c
            stopWatch.Start();
            disjoint1(group1, group2, group3);
            stopWatch.Stop();

            
            // a == b & b != c
            stopWatch.Start();
            disjoint1(group1, group1, group3);
            stopWatch.Stop();
            
            // a != b & b != c
            stopWatch.Start();
            disjoint2(group1, group2, group3);
            stopWatch.Stop();

            
            // a == b & b != c
            stopWatch.Start();
            disjoint2(group1, group1, group3);
            stopWatch.Stop(); 

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime1);

        }
    }

}
