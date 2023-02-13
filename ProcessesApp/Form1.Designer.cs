namespace ProcessesApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_startTime = new System.Windows.Forms.Label();
            this.label_processorTime = new System.Windows.Forms.Label();
            this.label_threadCount = new System.Windows.Forms.Label();
            this.label_copyProcess = new System.Windows.Forms.Label();
            this.btn_closeProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(319, 394);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "20";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Информация о процессе:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Process ID:";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(433, 58);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(0, 15);
            this.label_id.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "ProcessorTime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "ThreadCount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Process copy:";
            // 
            // label_startTime
            // 
            this.label_startTime.AutoSize = true;
            this.label_startTime.Location = new System.Drawing.Point(433, 88);
            this.label_startTime.Name = "label_startTime";
            this.label_startTime.Size = new System.Drawing.Size(0, 15);
            this.label_startTime.TabIndex = 10;
            // 
            // label_processorTime
            // 
            this.label_processorTime.AutoSize = true;
            this.label_processorTime.Location = new System.Drawing.Point(433, 121);
            this.label_processorTime.Name = "label_processorTime";
            this.label_processorTime.Size = new System.Drawing.Size(0, 15);
            this.label_processorTime.TabIndex = 11;
            // 
            // label_threadCount
            // 
            this.label_threadCount.AutoSize = true;
            this.label_threadCount.Location = new System.Drawing.Point(433, 152);
            this.label_threadCount.Name = "label_threadCount";
            this.label_threadCount.Size = new System.Drawing.Size(0, 15);
            this.label_threadCount.TabIndex = 12;
            // 
            // label_copyProcess
            // 
            this.label_copyProcess.AutoSize = true;
            this.label_copyProcess.Location = new System.Drawing.Point(433, 184);
            this.label_copyProcess.Name = "label_copyProcess";
            this.label_copyProcess.Size = new System.Drawing.Size(0, 15);
            this.label_copyProcess.TabIndex = 13;
            // 
            // btn_closeProcess
            // 
            this.btn_closeProcess.Location = new System.Drawing.Point(458, 398);
            this.btn_closeProcess.Name = "btn_closeProcess";
            this.btn_closeProcess.Size = new System.Drawing.Size(75, 23);
            this.btn_closeProcess.TabIndex = 14;
            this.btn_closeProcess.Text = "Закрыть";
            this.btn_closeProcess.UseVisualStyleBackColor = true;
            this.btn_closeProcess.Click += new System.EventHandler(this.btn_closeProcess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.btn_closeProcess);
            this.Controls.Add(this.label_copyProcess);
            this.Controls.Add(this.label_threadCount);
            this.Controls.Add(this.label_processorTime);
            this.Controls.Add(this.label_startTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label_id;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label_startTime;
        private Label label_processorTime;
        private Label label_threadCount;
        private Label label_copyProcess;
        private Button btn_closeProcess;
    }
}