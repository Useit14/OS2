using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace List
{
    class List
    {
        int count;
        List<Process> list = new List<Process>();

        public List()
        {
            count = 0;
        }

        public void Prepend(Process elementValue)
        {

            list.Insert(0, elementValue);
        }
        public void Append(Process elementValue)
        {
            list.Insert(list.Count, elementValue);
        }
        public void Add(Process process)
        {
            list.Add(process);
        }
        public void RemoveByIndex(int index)
        {
            int count = 0;
            foreach (var item in list)
            {
                if (count == index)
                {
                    list.Remove(item);
                }
                count++;
            }
        }
        public void RemoveByKey(Process value)
        {
            list.Remove(value);
        }
        public Process FindByIndex(int index)
        {

          var result = list.Find(x => x.idProcess == index);
          return result;
 
        }
        public Process FindByKey(string name)
        {
            return list.Find(x => x.name == name);
        }
        public void Sort()
        {
            list.Sort();
        }

        public List<Process> GetList()
        {
            return list;
        }
        public void Draw(ListBox listBox, Series series)
        {
            Process [] currentArray = ToArray();
            series.Points.Clear();
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                series.Points.Add(currentArray[i].timeUsed);
            }
        }

        public int getLastId()
        {
            return list.Find(x => x.timeUsed == list.Count - 1).idProcess;
        }
    }
}