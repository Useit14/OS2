using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class ProcessManager
    {
        List processes = new List();
        Process activeProcess;
        DateTime currentTime;

        public void processAdd(Process process)
        {
            processes.Add(process);
        }

        public void processRemove(int idProcess)
        {
            processes.RemoveByIndex(idProcess);
        }

        public void verifyForTerminated()
        {
        }

        public void nextTime(int idProcess)
        {

        }
    }

}
