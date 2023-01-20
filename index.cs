namespace DSA_Homework2
{
    using System;
    using System.Diagnostics;
    internal class Program
    {
        public static int max1 = 100000, max2 = 1000000, max3 = 10000000, max4 = 100000000, max5 = 1000000000;

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

        public static void random_arrays(int[] array_one, int[] array_two, int[] array_three, int[] array_four, int[] array_five)
        {
            Random rand = new Random();
            for (int i = 0; i < max1; i++)
            {
                int a = rand.Next(500);
                array_one[i] = a;
            }
            for (int i = 0; i < max2; i++)
            {
                int a = rand.Next(500);
                array_two[i] = a;
            }
            for (int i = 0; i < max3; i++)
            {
                int a = rand.Next(500);
                array_three[i] = a;
            }
            for (int i = 0; i < max4; i++)
            {
                int a = rand.Next(500);
                array_four[i] = a;
            }
            for (int i = 0; i < max5; i++)
            {
                int a = rand.Next(500);
                array_five[i] = a;
            }
        }

        static void Main(string[] args)
        {
            int[] array_one = new int[max1];
            int[] array_two = new int[max2];
            int[] array_three = new int[max3];
            int[] array_four = new int[max4];
            int[] array_five = new int[max5];
            Stopwatch stopWatch = new Stopwatch();

            random_arrays(array_one, array_two, array_three, array_four, array_five);


            stopWatch.Start();
            disjoint1(array_four, array_five, array_three);
            stopWatch.Stop();

            
            stopWatch.Start();
            disjoint2(array_four, array_five, array_three);
            stopWatch.Stop();
            

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime;

            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            Console.WriteLine("RunTime " + elapsedTime);

        }
    }
    
}
