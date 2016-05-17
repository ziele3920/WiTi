using System.Collections.Generic;

namespace WiTi
{
    class TaskService
    {
        public Task[] ReadData(string filename)
        {
            string directory = System.IO.Directory.GetCurrentDirectory();
            string[] lines = System.IO.File.ReadAllLines(directory + "\\" + filename);
            int tasksCount = int.Parse(lines[0]);
            Task[] data = new Task[tasksCount + 1];

            for (int i = 1; i < lines.Length; ++i)
            {
                Task currentTask = new Task();
                string[] line = lines[i].Split(' ');
                currentTask.t = int.Parse(line[0]);
                currentTask.p = int.Parse(line[1]);
                currentTask.f = int.Parse(line[2]);
                data[i] = currentTask;
            }
            return data;
        }
    }
}
