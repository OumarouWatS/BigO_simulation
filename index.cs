namespace DSA_Homework2
{
    using System;
    using System.Diagnostics;
    using System.Threading;
    internal class Program
    {

        public static bool disjoint1(int[] groupA, int[] groupB, int[] groupC)
        {
            foreach (int a in groupA)
                foreach (int b in groupB)
                    foreach (int c in groupC)
                        if ((a == b) && (b == c))
                            return false;
            return true;
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            Stopwatch stopWatch = new Stopwatch();
            

            int max1=400, max2=342, max3=201, max4=544, max5=1000;
            int[] array_one = new int[max1];
            int[] array_two = new int[max2];
            int[] array_three = new int[max3];
            int[] array_four = new int[max4];
            int[] array_five = new int[max5];


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
    }
}
