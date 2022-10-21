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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TBIdProcess = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TBNameProcess = new System.Windows.Forms.TextBox();
            this.TBCurrentPriority = new System.Windows.Forms.TextBox();
            this.TB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBResouceTime = new System.Windows.Forms.TextBox();
            this.labelResourceTime = new System.Windows.Forms.Label();
            this.TBBasePriority = new System.Windows.Forms.TextBox();
            this.labelBasePriority = new System.Windows.Forms.Label();
            this.labelTimeUsed = new System.Windows.Forms.Label();
            this.labelCurrentPriority = new System.Windows.Forms.Label();
            this.labelNameProcess = new System.Windows.Forms.Label();
            this.labeldProcess = new System.Windows.Forms.Label();
            this.buttonCreateNewProcess = new System.Windows.Forms.Button();
            this.buttonDeleteNewProcess = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(312, 49);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 407);
            this.listBox1.TabIndex = 0;
            // 
            // TBIdProcess
            // 
            this.TBIdProcess.Location = new System.Drawing.Point(130, 32);
            this.TBIdProcess.Margin = new System.Windows.Forms.Padding(2);
            this.TBIdProcess.Name = "TBIdProcess";
            this.TBIdProcess.ReadOnly = true;
            this.TBIdProcess.Size = new System.Drawing.Size(90, 20);
            this.TBIdProcess.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(508, 82);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(332, 398);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // TBNameProcess
            // 
            this.TBNameProcess.Location = new System.Drawing.Point(130, 62);
            this.TBNameProcess.Margin = new System.Windows.Forms.Padding(2);
            this.TBNameProcess.Name = "TBNameProcess";
            this.TBNameProcess.Size = new System.Drawing.Size(90, 20);
            this.TBNameProcess.TabIndex = 11;
            // 
            // TBCurrentPriority
            // 
            this.TBCurrentPriority.Location = new System.Drawing.Point(130, 94);
            this.TBCurrentPriority.Margin = new System.Windows.Forms.Padding(2);
            this.TBCurrentPriority.Name = "TBCurrentPriority";
            this.TBCurrentPriority.ReadOnly = true;
            this.TBCurrentPriority.Size = new System.Drawing.Size(90, 20);
            this.TBCurrentPriority.TabIndex = 12;
            // 
            // TB
            // 
            this.TB.Location = new System.Drawing.Point(130, 148);
            this.TB.Margin = new System.Windows.Forms.Padding(2);
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(90, 20);
            this.TB.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TBResouceTime);
            this.panel1.Controls.Add(this.labelResourceTime);
            this.panel1.Controls.Add(this.TBBasePriority);
            this.panel1.Controls.Add(this.labelBasePriority);
            this.panel1.Controls.Add(this.labelTimeUsed);
            this.panel1.Controls.Add(this.labelCurrentPriority);
            this.panel1.Controls.Add(this.labelNameProcess);
            this.panel1.Controls.Add(this.labeldProcess);
            this.panel1.Controls.Add(this.TB);
            this.panel1.Controls.Add(this.TBCurrentPriority);
            this.panel1.Controls.Add(this.TBNameProcess);
            this.panel1.Controls.Add(this.TBIdProcess);
            this.panel1.Location = new System.Drawing.Point(15, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 215);
            this.panel1.TabIndex = 14;
            // 
            // TBResouceTime
            // 
            this.TBResouceTime.Location = new System.Drawing.Point(130, 172);
            this.TBResouceTime.Margin = new System.Windows.Forms.Padding(2);
            this.TBResouceTime.Name = "TBResouceTime";
            this.TBResouceTime.ReadOnly = true;
            this.TBResouceTime.Size = new System.Drawing.Size(90, 20);
            this.TBResouceTime.TabIndex = 21;
            // 
            // labelResourceTime
            // 
            this.labelResourceTime.AutoSize = true;
            this.labelResourceTime.Location = new System.Drawing.Point(29, 179);
            this.labelResourceTime.Name = "labelResourceTime";
            this.labelResourceTime.Size = new System.Drawing.Size(96, 13);
            this.labelResourceTime.TabIndex = 20;
            this.labelResourceTime.Text = "Ресурсное время";
            // 
            // TBBasePriority
            // 
            this.TBBasePriority.Location = new System.Drawing.Point(129, 118);
            this.TBBasePriority.Margin = new System.Windows.Forms.Padding(2);
            this.TBBasePriority.Name = "TBBasePriority";
            this.TBBasePriority.Size = new System.Drawing.Size(90, 20);
            this.TBBasePriority.TabIndex = 19;
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
            this.buttonCreateNewProcess.Location = new System.Drawing.Point(15, 280);
            this.buttonCreateNewProcess.Name = "buttonCreateNewProcess";
            this.buttonCreateNewProcess.Size = new System.Drawing.Size(279, 37);
            this.buttonCreateNewProcess.TabIndex = 15;
            this.buttonCreateNewProcess.Text = "Создать новый процесс";
            this.buttonCreateNewProcess.UseVisualStyleBackColor = true;
            this.buttonCreateNewProcess.Click += new System.EventHandler(this.buttonCreateNewProcess_Click);
            // 
            // buttonDeleteNewProcess
            // 
            this.buttonDeleteNewProcess.Location = new System.Drawing.Point(15, 323);
            this.buttonDeleteNewProcess.Name = "buttonDeleteNewProcess";
            this.buttonDeleteNewProcess.Size = new System.Drawing.Size(279, 37);
            this.buttonDeleteNewProcess.TabIndex = 16;
            this.buttonDeleteNewProcess.Text = "Удалить процесс из списка";
            this.buttonDeleteNewProcess.UseVisualStyleBackColor = true;
            this.buttonDeleteNewProcess.Click += new System.EventHandler(this.buttonDeleteNewProcess_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(15, 366);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(279, 37);
            this.buttonGo.TabIndex = 17;
            this.buttonGo.Text = "Запуск";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(15, 409);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(279, 37);
            this.buttonStop.TabIndex = 18;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 493);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.buttonDeleteNewProcess);
            this.Controls.Add(this.buttonCreateNewProcess);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox TBIdProcess;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox TBNameProcess;
        private System.Windows.Forms.TextBox TBCurrentPriority;
        private System.Windows.Forms.TextBox TB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labeldProcess;
        private System.Windows.Forms.Label labelTimeUsed;
        private System.Windows.Forms.Label labelCurrentPriority;
        private System.Windows.Forms.Label labelNameProcess;
        private System.Windows.Forms.Button buttonCreateNewProcess;
        private System.Windows.Forms.TextBox TBResouceTime;
        private System.Windows.Forms.Label labelResourceTime;
        private System.Windows.Forms.TextBox TBBasePriority;
        private System.Windows.Forms.Label labelBasePriority;
        private System.Windows.Forms.Button buttonDeleteNewProcess;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonStop;
    }
}