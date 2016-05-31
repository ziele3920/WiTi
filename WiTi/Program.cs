
using System;

namespace WiTi
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskService TS = new TaskService();
            ByteService BS = new ByteService();
            while(true)
            {

                Console.WriteLine("podaj nazwę pliku");
                //string fileName = Console.ReadLine();
                //Task[] tasksList = TS.ReadData(fileName);
                //WiTiAlg(tasksList);
                int k = int.Parse(Console.ReadLine());
                //[] b = BS.IntToByte(k, 8);
                //Console.WriteLine(BS.ByteToInt(b));
                var l = BS.GetPermutationsIndex(k, 4);
                for (int i = 0; i < l.Length/2; ++i)
                {
                    for (int j = 0; j < 2; ++j)
                        Console.Write(l[i,j] + " ");
                    Console.WriteLine(" ");
                }

            }

        }

        private static void WiTiAlg(Task[] tasksList)
        {
            int dataCount = tasksList.Length - 1;
            byte[] currentTasksSet = new byte[dataCount];
            int[] punishmentCost = new int[TwoPowX(dataCount)];

        }

        public static int TwoPowX(int power)
        {
            return (1 << power);
        }
    }
}
