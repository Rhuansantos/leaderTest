namespace leaderTest
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
            this.Q1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Q2_yes = new System.Windows.Forms.RadioButton();
            this.Q2_no = new System.Windows.Forms.RadioButton();
            this.Q2_notSure = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Q1
            // 
            this.Q1.Location = new System.Drawing.Point(373, 218);
            this.Q1.Name = "Q1";
            this.Q1.Size = new System.Drawing.Size(469, 26);
            this.Q1.TabIndex = 0;
            this.Q1.TextChanged += new System.EventHandler(this.Q1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "What is your name?:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "I\'m good at making \\\"small talk\\";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 821);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Q2_yes
            // 
            this.Q2_yes.AutoSize = true;
            this.Q2_yes.Location = new System.Drawing.Point(338, 361);
            this.Q2_yes.Name = "Q2_yes";
            this.Q2_yes.Size = new System.Drawing.Size(126, 24);
            this.Q2_yes.TabIndex = 7;
            this.Q2_yes.TabStop = true;
            this.Q2_yes.Text = "radioButton1";
            this.Q2_yes.UseVisualStyleBackColor = true;
            this.Q2_yes.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Q2_no
            // 
            this.Q2_no.AutoSize = true;
            this.Q2_no.Location = new System.Drawing.Point(506, 361);
            this.Q2_no.Name = "Q2_no";
            this.Q2_no.Size = new System.Drawing.Size(126, 24);
            this.Q2_no.TabIndex = 8;
            this.Q2_no.TabStop = true;
            this.Q2_no.Text = "radioButton1";
            this.Q2_no.UseVisualStyleBackColor = true;
            // 
            // Q2_notSure
            // 
            this.Q2_notSure.AutoSize = true;
            this.Q2_notSure.Location = new System.Drawing.Point(699, 361);
            this.Q2_notSure.Name = "Q2_notSure";
            this.Q2_notSure.Size = new System.Drawing.Size(126, 24);
            this.Q2_notSure.TabIndex = 9;
            this.Q2_notSure.TabStop = true;
            this.Q2_notSure.Text = "radioButton1";
            this.Q2_notSure.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(373, 463);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(32, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1719, 1044);
            this.Controls.Add(this.Q2_yes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Q2_no);
            this.Controls.Add(this.Q2_notSure);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Q1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Q1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Q2_yes;
        private System.Windows.Forms.RadioButton Q2_no;
        private System.Windows.Forms.RadioButton Q2_notSure;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

