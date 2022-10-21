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
        enum status
        {
            Ready,
            Active,
            Waiting,
            Zombie
        }
        public int timeUsed=0;
        int timeResults=0;
        string basePriority;
        string currentPriority="hight";

        public Process(int idProcess, string name,string basePriority="low")
        {
            this.idProcess = idProcess;
            this.basePriority = basePriority;
            this.name = name;
        }

        private void Go () {
            timeUsed++; 
        }
    }
}
