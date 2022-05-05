
namespace ShellSort2
{
    public class ShellSort2
    {
        private static int randNum = 10;
        private static int[] arry = new int[randNum];


        static void Main(string[] args)
        {

            generateArry();

            Console.WriteLine("Before Sort:");
            for (int i = 0; i < arry.Length; i++)
                Console.Write(arry[i] + " ");

            sortArry();

            Console.WriteLine("\nAfter Sort");
            for (int i = 0; i < arry.Length; i++)
                Console.Write(arry[i] + " ");

        }



        public static void generateArry()
        {
            Random rand = new Random();

            int j = 1;
            for (int i = 0; i < randNum; i++)
            {

                int random = rand.Next(100);

                while (arry.Contains(random))
                {
                    random = rand.Next(100);
                }
                arry[i] = random;
            }
        }



        public static void sortArry()
        {

            for (int gap = randNum / 2; gap > 0; gap /= 2)
            {

                for (int ix = gap; ix < randNum; ix++)
                {
                    int temp = arry[ix];

                    int jx;
                    int changed = 0;

                    for (jx = ix; jx >= gap && arry[jx - gap] > temp; jx -= gap)
                    {
                        arry[jx] = arry[jx - gap];
                        changed = arry[jx];
                    }


                    arry[jx] = temp;
                }
            }
        }
    }
}




