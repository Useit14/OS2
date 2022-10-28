using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Scheduler
    {
       public static Process getNextActive(List<Process> processes)
        {
            Process activeProcess = getActive(processes);
            if (activeProcess != null)
            {
                return activeProcess;
            }
            foreach(var item in processes)
            {
                if (item.currentPriority==Process.Priority.Height)
                {
                    return item;
                }
            }
            
                foreach (var item in processes)
                {
                    if (item.currentPriority == Process.Priority.Medium)
                    {
                        return item;
                    }
                }
            foreach (var item in processes)
            {
                if (item.currentPriority == Process.Priority.Low)
                {
                    return item;
                }
            }
            return null;
        }

        private static Process getActive(List<Process> processes)
        {
            foreach (var item in processes)
            {
                if (item.currentStatus == Process.Status.Active)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
