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
            foreach(var item in processes)
            {
                if (item == activeProcess)
                {
                   item.currentPriority=item.basePriority;
                }
                item.currentPriority++;
            }

            int max = -100000000;
            foreach (var item in processes)
            
            {
                if(item.currentPriority > max)
                {
                    max = item.currentPriority;
                }
            }
            foreach (var item in processes)

            {
                if (item.currentPriority == max)
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
