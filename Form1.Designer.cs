namespace List
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TBIdProcess = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TBNameProcess = new System.Windows.Forms.TextBox();
            this.TBCurrentPriority = new System.Windows.Forms.TextBox();
            this.TBTime = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBasePriority = new System.Windows.Forms.ComboBox();
            this.labelBasePriority = new System.Windows.Forms.Label();
            this.labelTimeUsed = new System.Windows.Forms.Label();
            this.labelCurrentPriority = new System.Windows.Forms.Label();
            this.labelNameProcess = new System.Windows.Forms.Label();
            this.labeldProcess = new System.Windows.Forms.Label();
            this.buttonCreateNewProcess = new System.Windows.Forms.Button();
            this.buttonDeleteNewProcess = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelMainTimer = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(331, 7);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1392, 996);
            this.listBox1.TabIndex = 0;
            // 
            // TBIdProcess
            // 
            this.TBIdProcess.Location = new System.Drawing.Point(173, 39);
            this.TBIdProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBIdProcess.Name = "TBIdProcess";
            this.TBIdProcess.ReadOnly = true;
            this.TBIdProcess.Size = new System.Drawing.Size(119, 22);
            this.TBIdProcess.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(611, 475);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(443, 466);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            title1.Name = "titleTime";
            title1.Text = "Время использования каждого процесса";
            this.chart1.Titles.Add(title1);
            // 
            // TBNameProcess
            // 
            this.TBNameProcess.Location = new System.Drawing.Point(173, 76);
            this.TBNameProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBNameProcess.Name = "TBNameProcess";
            this.TBNameProcess.Size = new System.Drawing.Size(119, 22);
            this.TBNameProcess.TabIndex = 11;
            // 
            // TBCurrentPriority
            // 
            this.TBCurrentPriority.Location = new System.Drawing.Point(173, 116);
            this.TBCurrentPriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBCurrentPriority.Name = "TBCurrentPriority";
            this.TBCurrentPriority.ReadOnly = true;
            this.TBCurrentPriority.Size = new System.Drawing.Size(119, 22);
            this.TBCurrentPriority.TabIndex = 12;
            // 
            // TBTime
            // 
            this.TBTime.Location = new System.Drawing.Point(173, 188);
            this.TBTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBTime.Name = "TBTime";
            this.TBTime.Size = new System.Drawing.Size(119, 22);
            this.TBTime.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBasePriority);
            this.panel1.Controls.Add(this.labelBasePriority);
            this.panel1.Controls.Add(this.labelTimeUsed);
            this.panel1.Controls.Add(this.labelCurrentPriority);
            this.panel1.Controls.Add(this.labelNameProcess);
            this.panel1.Controls.Add(this.labeldProcess);
            this.panel1.Controls.Add(this.TBTime);
            this.panel1.Controls.Add(this.TBCurrentPriority);
            this.panel1.Controls.Add(this.TBNameProcess);
            this.panel1.Controls.Add(this.TBIdProcess);
            this.panel1.Location = new System.Drawing.Point(16, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 264);
            this.panel1.TabIndex = 14;
            // 
            // comboBasePriority
            // 
            this.comboBasePriority.FormattingEnabled = true;
            this.comboBasePriority.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBasePriority.Location = new System.Drawing.Point(173, 151);
            this.comboBasePriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBasePriority.Name = "comboBasePriority";
            this.comboBasePriority.Size = new System.Drawing.Size(121, 24);
            this.comboBasePriority.TabIndex = 22;
            // 
            // labelBasePriority
            // 
            this.labelBasePriority.AutoSize = true;
            this.labelBasePriority.Location = new System.Drawing.Point(25, 154);
            this.labelBasePriority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBasePriority.Name = "labelBasePriority";
            this.labelBasePriority.Size = new System.Drawing.Size(139, 17);
            this.labelBasePriority.TabIndex = 18;
            this.labelBasePriority.Text = "Базовый приоритет";
            // 
            // labelTimeUsed
            // 
            this.labelTimeUsed.AutoSize = true;
            this.labelTimeUsed.Location = new System.Drawing.Point(31, 191);
            this.labelTimeUsed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimeUsed.Name = "labelTimeUsed";
            this.labelTimeUsed.Size = new System.Drawing.Size(133, 17);
            this.labelTimeUsed.TabIndex = 17;
            this.labelTimeUsed.Text = "Время исполнения";
            // 
            // labelCurrentPriority
            // 
            this.labelCurrentPriority.AutoSize = true;
            this.labelCurrentPriority.Location = new System.Drawing.Point(25, 124);
            this.labelCurrentPriority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentPriority.Name = "labelCurrentPriority";
            this.labelCurrentPriority.Size = new System.Drawing.Size(140, 17);
            this.labelCurrentPriority.TabIndex = 16;
            this.labelCurrentPriority.Text = "Текущий приоритет";
            // 
            // labelNameProcess
            // 
            this.labelNameProcess.AutoSize = true;
            this.labelNameProcess.Location = new System.Drawing.Point(24, 85);
            this.labelNameProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameProcess.Name = "labelNameProcess";
            this.labelNameProcess.Size = new System.Drawing.Size(138, 17);
            this.labelNameProcess.TabIndex = 15;
            this.labelNameProcess.Text = "Название процесса";
            // 
            // labeldProcess
            // 
            this.labeldProcess.AutoSize = true;
            this.labeldProcess.Location = new System.Drawing.Point(75, 48);
            this.labeldProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeldProcess.Name = "labeldProcess";
            this.labeldProcess.Size = new System.Drawing.Size(87, 17);
            this.labeldProcess.TabIndex = 14;
            this.labeldProcess.Text = "ID процесса";
            // 
            // buttonCreateNewProcess
            // 
            this.buttonCreateNewProcess.Location = new System.Drawing.Point(16, 293);
            this.buttonCreateNewProcess.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateNewProcess.Name = "buttonCreateNewProcess";
            this.buttonCreateNewProcess.Size = new System.Drawing.Size(308, 46);
            this.buttonCreateNewProcess.TabIndex = 15;
            this.buttonCreateNewProcess.Text = "Создать новый процесс";
            this.buttonCreateNewProcess.UseVisualStyleBackColor = true;
            this.buttonCreateNewProcess.Click += new System.EventHandler(this.buttonCreateNewProcess_Click);
            // 
            // buttonDeleteNewProcess
            // 
            this.buttonDeleteNewProcess.Location = new System.Drawing.Point(16, 346);
            this.buttonDeleteNewProcess.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteNewProcess.Name = "buttonDeleteNewProcess";
            this.buttonDeleteNewProcess.Size = new System.Drawing.Size(308, 46);
            this.buttonDeleteNewProcess.TabIndex = 16;
            this.buttonDeleteNewProcess.Text = "Удалить процесс из списка";
            this.buttonDeleteNewProcess.UseVisualStyleBackColor = true;
            this.buttonDeleteNewProcess.Click += new System.EventHandler(this.buttonDeleteNewProcess_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(16, 398);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(308, 46);
            this.buttonGo.TabIndex = 17;
            this.buttonGo.Text = "Запуск";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(16, 450);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(308, 46);
            this.buttonStop.TabIndex = 18;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelMainTimer
            // 
            this.labelMainTimer.AutoSize = true;
            this.labelMainTimer.Location = new System.Drawing.Point(16, 505);
            this.labelMainTimer.Name = "labelMainTimer";
            this.labelMainTimer.Size = new System.Drawing.Size(16, 17);
            this.labelMainTimer.TabIndex = 19;
            this.labelMainTimer.Text = "0";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(1062, 477);
            this.chart2.Margin = new System.Windows.Forms.Padding(4);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(443, 466);
            this.chart2.TabIndex = 20;
            this.chart2.Text = "chart2";
            title2.Name = "titlePriority";
            title2.Text = "Приоритезация процессов";
            this.chart2.Titles.Add(title2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1763, 560);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.labelMainTimer);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.buttonDeleteNewProcess);
            this.Controls.Add(this.buttonCreateNewProcess);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox TBIdProcess;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox TBNameProcess;
        private System.Windows.Forms.TextBox TBCurrentPriority;
        private System.Windows.Forms.TextBox TBTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labeldProcess;
        private System.Windows.Forms.Label labelTimeUsed;
        private System.Windows.Forms.Label labelCurrentPriority;
        private System.Windows.Forms.Label labelNameProcess;
        private System.Windows.Forms.Button buttonCreateNewProcess;
        private System.Windows.Forms.Label labelBasePriority;
        private System.Windows.Forms.Button buttonDeleteNewProcess;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelMainTimer;
        private System.Windows.Forms.ComboBox comboBasePriority;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}