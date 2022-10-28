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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(248, 6);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1045, 394);
            this.listBox1.TabIndex = 0;
            // 
            // TBIdProcess
            // 
            this.TBIdProcess.Location = new System.Drawing.Point(130, 32);
            this.TBIdProcess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBIdProcess.Name = "TBIdProcess";
            this.TBIdProcess.ReadOnly = true;
            this.TBIdProcess.Size = new System.Drawing.Size(90, 20);
            this.TBIdProcess.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(796, 11);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(332, 379);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // TBNameProcess
            // 
            this.TBNameProcess.Location = new System.Drawing.Point(130, 62);
            this.TBNameProcess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBNameProcess.Name = "TBNameProcess";
            this.TBNameProcess.Size = new System.Drawing.Size(90, 20);
            this.TBNameProcess.TabIndex = 11;
            // 
            // TBCurrentPriority
            // 
            this.TBCurrentPriority.Location = new System.Drawing.Point(130, 94);
            this.TBCurrentPriority.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBCurrentPriority.Name = "TBCurrentPriority";
            this.TBCurrentPriority.ReadOnly = true;
            this.TBCurrentPriority.Size = new System.Drawing.Size(90, 20);
            this.TBCurrentPriority.TabIndex = 12;
            // 
            // TBTime
            // 
            this.TBTime.Location = new System.Drawing.Point(130, 153);
            this.TBTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBTime.Name = "TBTime";
            this.TBTime.Size = new System.Drawing.Size(90, 20);
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
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 215);
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
            this.comboBasePriority.Location = new System.Drawing.Point(130, 123);
            this.comboBasePriority.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBasePriority.Name = "comboBasePriority";
            this.comboBasePriority.Size = new System.Drawing.Size(92, 21);
            this.comboBasePriority.TabIndex = 22;
            // 
            // labelBasePriority
            // 
            this.labelBasePriority.AutoSize = true;
            this.labelBasePriority.Location = new System.Drawing.Point(19, 125);
            this.labelBasePriority.Name = "labelBasePriority";
            this.labelBasePriority.Size = new System.Drawing.Size(107, 13);
            this.labelBasePriority.TabIndex = 18;
            this.labelBasePriority.Text = "Базовый приоритет";
            // 
            // labelTimeUsed
            // 
            this.labelTimeUsed.AutoSize = true;
            this.labelTimeUsed.Location = new System.Drawing.Point(23, 155);
            this.labelTimeUsed.Name = "labelTimeUsed";
            this.labelTimeUsed.Size = new System.Drawing.Size(103, 13);
            this.labelTimeUsed.TabIndex = 17;
            this.labelTimeUsed.Text = "Время исполнения";
            // 
            // labelCurrentPriority
            // 
            this.labelCurrentPriority.AutoSize = true;
            this.labelCurrentPriority.Location = new System.Drawing.Point(19, 101);
            this.labelCurrentPriority.Name = "labelCurrentPriority";
            this.labelCurrentPriority.Size = new System.Drawing.Size(107, 13);
            this.labelCurrentPriority.TabIndex = 16;
            this.labelCurrentPriority.Text = "Текущий приоритет";
            // 
            // labelNameProcess
            // 
            this.labelNameProcess.AutoSize = true;
            this.labelNameProcess.Location = new System.Drawing.Point(18, 69);
            this.labelNameProcess.Name = "labelNameProcess";
            this.labelNameProcess.Size = new System.Drawing.Size(108, 13);
            this.labelNameProcess.TabIndex = 15;
            this.labelNameProcess.Text = "Название процесса";
            // 
            // labeldProcess
            // 
            this.labeldProcess.AutoSize = true;
            this.labeldProcess.Location = new System.Drawing.Point(56, 39);
            this.labeldProcess.Name = "labeldProcess";
            this.labeldProcess.Size = new System.Drawing.Size(69, 13);
            this.labeldProcess.TabIndex = 14;
            this.labeldProcess.Text = "ID процесса";
            // 
            // buttonCreateNewProcess
            // 
            this.buttonCreateNewProcess.Location = new System.Drawing.Point(12, 238);
            this.buttonCreateNewProcess.Name = "buttonCreateNewProcess";
            this.buttonCreateNewProcess.Size = new System.Drawing.Size(231, 37);
            this.buttonCreateNewProcess.TabIndex = 15;
            this.buttonCreateNewProcess.Text = "Создать новый процесс";
            this.buttonCreateNewProcess.UseVisualStyleBackColor = true;
            this.buttonCreateNewProcess.Click += new System.EventHandler(this.buttonCreateNewProcess_Click);
            // 
            // buttonDeleteNewProcess
            // 
            this.buttonDeleteNewProcess.Location = new System.Drawing.Point(12, 281);
            this.buttonDeleteNewProcess.Name = "buttonDeleteNewProcess";
            this.buttonDeleteNewProcess.Size = new System.Drawing.Size(231, 37);
            this.buttonDeleteNewProcess.TabIndex = 16;
            this.buttonDeleteNewProcess.Text = "Удалить процесс из списка";
            this.buttonDeleteNewProcess.UseVisualStyleBackColor = true;
            this.buttonDeleteNewProcess.Click += new System.EventHandler(this.buttonDeleteNewProcess_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(12, 323);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(231, 37);
            this.buttonGo.TabIndex = 17;
            this.buttonGo.Text = "Запуск";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(12, 366);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(231, 37);
            this.buttonStop.TabIndex = 18;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelMainTimer
            // 
            this.labelMainTimer.AutoSize = true;
            this.labelMainTimer.Location = new System.Drawing.Point(12, 410);
            this.labelMainTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMainTimer.Name = "labelMainTimer";
            this.labelMainTimer.Size = new System.Drawing.Size(13, 13);
            this.labelMainTimer.TabIndex = 19;
            this.labelMainTimer.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 455);
            this.Controls.Add(this.labelMainTimer);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.buttonDeleteNewProcess);
            this.Controls.Add(this.buttonCreateNewProcess);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}