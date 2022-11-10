namespace FCFS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LJlhProses = new System.Windows.Forms.Label();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.LV = new System.Windows.Forms.ListView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LJlhProses
            // 
            this.LJlhProses.AutoSize = true;
            this.LJlhProses.Location = new System.Drawing.Point(16, 40);
            this.LJlhProses.Name = "LJlhProses";
            this.LJlhProses.Size = new System.Drawing.Size(103, 18);
            this.LJlhProses.TabIndex = 0;
            this.LJlhProses.Text = "Num of process";
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(177, 40);
            this.textbox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox1.Multiline = true;
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(78, 26);
            this.textbox1.TabIndex = 1;
            // 
            // LV
            // 
            this.LV.HideSelection = false;
            this.LV.Location = new System.Drawing.Point(12, 114);
            this.LV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(618, 280);
            this.LV.TabIndex = 2;
            this.LV.UseCompatibleStateImageBehavior = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGenerate.Location = new System.Drawing.Point(83, 74);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(99, 32);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReset.Location = new System.Drawing.Point(177, 431);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 32);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total TA";
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(438, 412);
            this.textbox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(101, 23);
            this.textbox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Average TA";
            // 
            // textbox3
            // 
            this.textbox3.Location = new System.Drawing.Point(438, 469);
            this.textbox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox3.Name = "textbox3";
            this.textbox3.Size = new System.Drawing.Size(101, 23);
            this.textbox3.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(39, 431);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "FCFS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total WT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Average WT";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(649, 412);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(101, 23);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(649, 469);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(101, 23);
            this.textBox5.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(62, 482);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "Explanation of the algorithm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(752, 517);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textbox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.LV);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.LJlhProses);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "FCFS Scheduling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LJlhProses;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.ListView LV;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
    }
}

