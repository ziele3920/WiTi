
using System;

namespace WiTi
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskService TS = new TaskService();
            while(true)
            {

                Console.WriteLine("podaj nazwę pliku");
                string fileName = Console.ReadLine();
                Task[] tasksList = TS.ReadData(fileName);
                WiTiAlg(tasksList);

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
