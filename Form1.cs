using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List list = new List();
        Series series;
        ProcessManager processManager = new ProcessManager();
        private int totalTimeCount=0;

        private void ToList()
        {
            List<Process> processes = list.GetList();
            listBox1.Items.Clear();
            foreach(var process in processes)
            {
                listBox1.Items.Add(process.name);
            }
            series = chart1.Series["Series1"];
            list.Draw(listBox1, series);
        }

        private void buttonCreateNewProcess_Click(object sender, EventArgs e)
        {
            processManager.processAdd(new Process(list.getLastId() + 1, TBNameProcess.Text, TBBasePriority.Text));
            listBox1.Items.Clear();
            ToList();
        }

        private void buttonDeleteNewProcess_Click(object sender, EventArgs e)
        {
            int idProcess = listBox1.SelectedIndex;
            processManager.processRemove(idProcess);
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {

        }
    }
}