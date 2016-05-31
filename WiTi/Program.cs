
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
                string fileName = Console.ReadLine();
                Task[] tasksList = TS.ReadData(fileName);
                Console.WriteLine(WiTiAlg(tasksList));
                
                //int k = int.Parse(Console.ReadLine());
                //[] b = BS.IntToByte(k, 8);
                //Console.WriteLine(BS.ByteToInt(b));
                //var l = BS.GetPermutationsIndex(k, 4);
                //for (int i = 0; i < l.Length/2; ++i)
                //{
                //    for (int j = 0; j < 2; ++j)
                //        Console.Write(l[i,j] + " ");
                //    Console.WriteLine(" ");
                //}

            }

        }

        private static int WiTiAlg(Task[] tasksList)
        {
            ByteService BS = new ByteService();
            int byteCount = tasksList.Length - 1;
            int steps = TwoPowX(byteCount);
            byte[] currentTasksSet = new byte[byteCount];
            int[] punishmentCost = new int[steps];
            for (int i = 1; i < steps; ++i)
                punishmentCost[i] = int.MaxValue;
            int currentTime = 0;

            for(int i = 1; i < steps; ++i)
            {
                int[,] indexes = BS.GetPermutationsIndex(i, byteCount);
                if (indexes[0, 0] == 0) {
                    Task currentTask = tasksList[indexes[0, 1]];
                    currentTime += currentTask.p;
                    punishmentCost[i] = Math.Max(0, (currentTime - currentTask.d) * currentTask.w);
                    continue;
                }
                for(int j = 0; j < indexes.GetLength(0); ++j)
                {
                    int newPunishment = punishmentCost[indexes[j, 1]] + punishmentCost[indexes[j, 0]];
                    if (newPunishment < punishmentCost[i])
                        punishmentCost[i] = newPunishment;
                }
            }
            
            return punishmentCost[steps-1];
        }

        static int GetMinPunishmentFor(int taskNumber)
        {

        }

        public static int TwoPowX(int power)
        {
            return (1 << power);
        }
    }
}
