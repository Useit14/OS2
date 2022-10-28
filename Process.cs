using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Process
    {
        public int idProcess;
        public string name;
        public enum Status
        {
            Ready,
            Active,
            Waiting,
            Zombie
        }
        public enum Priority
        {
            Low,
            Medium,
            Height
        }
        public int timeUsed=0;
        public int timeResource=0;
        public Priority basePriority;
        public Priority currentPriority;
        public Status currentStatus;

        public Process(int idProcess, string name, int timeResorce,Priority basePriority=Priority.Low)
        {
            this.idProcess = idProcess;
            this.basePriority = basePriority;
            this.currentPriority = basePriority;
            this.name = name;
            this.currentStatus = Status.Waiting;
            this.timeResource = timeResorce;
        }

        public void Go () {
            timeUsed++; 
        }
    }
}
