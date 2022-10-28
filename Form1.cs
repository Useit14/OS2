using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Timer = System.Threading.Timer;

namespace List
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        public delegate void SomeDelegat();
        static ProcessManager processManager = new ProcessManager();
        static TimerCallback tm = new TimerCallback(nextTime);
        Timer timer;
        Obj obj;

        class Obj
        {
           public Label _labelMainTimer;
           public ListBox _listBox1;
           public Chart _chart1;
            public Obj(Label labelMainTimer,ListBox listBox1,Chart chart1)
            {
                this._labelMainTimer = labelMainTimer;
                this._listBox1 = listBox1;
                this._chart1 = chart1;
            }

            public Label getLabel()
            {
                return _labelMainTimer;
            }
        }

        public static void ToList(ListBox listBox1, Chart chart1)
        {
            List<Process> processes = processManager.GetList();
            listBox1.Items.Clear();
            foreach(var process in processes)
            {
                listBox1.Items.Add($"Идентификатор: {process.idProcess}; Имя: { process.name}; Время использования: {process.timeUsed}; Ресурсное время: {process.timeResource}; Приоритет: {process.basePriority}") ;
            }
            processManager.Draw(listBox1, chart1.Series["Series1"]);
            
        }

        private void buttonCreateNewProcess_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Priority priority;
                Enum.TryParse(comboBasePriority.SelectedItem.ToString(), out priority);
                processManager.processAdd(new Process(processManager.getLastId() + 1, TBNameProcess.Text, int.Parse(TBTime.Text), priority));
                ToList(listBox1, chart1);
                TBNameProcess.Text = "";
                comboBasePriority.SelectedItem = null;
                TBTime.Text = "";
            }
            catch 
            {
                MessageBox.Show("Создайте процессы");
            };
        }

        private void buttonDeleteNewProcess_Click(object sender, EventArgs e)
        {
            int idProcess = listBox1.SelectedIndex;
            processManager.processRemove(idProcess);
            ToList(listBox1, chart1);
            TBNameProcess.Text = "";
            comboBasePriority.SelectedItem=null;
            TBTime.Text = "";
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            obj = new Obj(labelMainTimer, listBox1, chart1);
            timer = new Timer(tm, obj,0,1000);
            Process activeProcess = Scheduler.getNextActive(processManager.GetList());
            TBNameProcess.Text = activeProcess.name;
            comboBasePriority.SelectedText = Enum.GetName(typeof(Process.Priority), activeProcess.currentPriority);
            TBTime.Text = activeProcess.timeUsed.ToString();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Dispose();
        }

        private static void nextTime(object obj)
        {
            Label labelMainTimer = ((List.Form1.Obj)obj)._labelMainTimer;
            ListBox listBox1 = ((List.Form1.Obj)obj)._listBox1;
            Chart chart1 = ((List.Form1.Obj)obj)._chart1;

            processManager.nextTime(labelMainTimer);
            ToList(listBox1, chart1);
        }

    }
}