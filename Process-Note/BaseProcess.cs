using System;
using System.Diagnostics;

namespace Process_Note
{
    public class BaseProcess
    {
        public string PID { get; set; }
        public string Name { get; set; }
        public string CPUUsage { get; set; }
        public string MemoryUsage { get; set; }
        public string RunningTime { get; set; }
        public string StartTime { get; set; }
        public string Comment { get; set; }

        public BaseProcess() { }

        public BaseProcess(string pID, string name, string cpuUsage, string memoryUsage, string runningTime, string startTime, string comment)
        {
            this.PID = pID;
            this.Name = name;
            this.CPUUsage = cpuUsage;
            this.MemoryUsage = memoryUsage;
            this.RunningTime = runningTime;
            this.StartTime = startTime;
            this.Comment = comment;
        }


        public BaseProcess(Process process)
        {
            this.PID = process.Id.ToString();
            this.Name = process.ProcessName;
            this.CPUUsage = (new PerformanceCounter("Process", "% Processor Time", process.ProcessName).NextValue()).ToString() + " %";
            this.MemoryUsage = (process.PrivateMemorySize64 / 1024.0 / 1024.0).ToString("#,##0") + " MB";

            this.RunningTime = (DateTime.Now - process.StartTime).ToString(@"hh\:mm\:ss");
            this.StartTime = process.StartTime.ToString();
            this.Comment = "";
        }
    }
}
