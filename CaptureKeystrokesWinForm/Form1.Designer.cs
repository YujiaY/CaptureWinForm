namespace CaptureKeystrokesWinForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelDuplicate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.LeftClick_Count = new System.Windows.Forms.Label();
            this.RightClick_Count = new System.Windows.Forms.Label();
            this.ClickBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ignored text:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(357, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // labelDuplicate
            // 
            this.labelDuplicate.AutoSize = true;
            this.labelDuplicate.Location = new System.Drawing.Point(26, 167);
            this.labelDuplicate.Name = "labelDuplicate";
            this.labelDuplicate.Size = new System.Drawing.Size(137, 13);
            this.labelDuplicate.TabIndex = 2;
            this.labelDuplicate.Text = "Duplicate text appears here";

            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type in some text here:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(354, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(26, 144);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(125, 13);
            this.labelCount.TabIndex = 5;
            this.labelCount.Text = "Number of keystokes = 0";
            // 
            // LeftClick_Count
            // 
            this.LeftClick_Count.AutoSize = true;
            this.LeftClick_Count.Location = new System.Drawing.Point(26, 195);
            this.LeftClick_Count.Name = "LeftClick_Count";
            this.LeftClick_Count.Size = new System.Drawing.Size(153, 13);
            this.LeftClick_Count.TabIndex = 6;
            this.LeftClick_Count.Text = "Number of Mouse LeftClick = 0";
            // 
            // RightClick_Count
            // 
            this.RightClick_Count.AutoSize = true;
            this.RightClick_Count.Location = new System.Drawing.Point(26, 226);
            this.RightClick_Count.Name = "RightClick_Count";
            this.RightClick_Count.Size = new System.Drawing.Size(160, 13);
            this.RightClick_Count.TabIndex = 7;
            this.RightClick_Count.Text = "Number of Mouse RightClick = 0";
            // 
            // ClickBtn
            // 
            this.ClickBtn.Location = new System.Drawing.Point(245, 195);
            this.ClickBtn.Name = "ClickBtn";
            this.ClickBtn.Size = new System.Drawing.Size(138, 75);
            this.ClickBtn.TabIndex = 8;
            this.ClickBtn.Text = "Click Here!";
            this.ClickBtn.UseVisualStyleBackColor = true;
            this.ClickBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickBtn_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 282);
            this.Controls.Add(this.ClickBtn);
            this.Controls.Add(this.RightClick_Count);
            this.Controls.Add(this.LeftClick_Count);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDuplicate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Keystokes & Mouseclick Capture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelDuplicate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label LeftClick_Count;
        private System.Windows.Forms.Label RightClick_Count;
        private System.Windows.Forms.Button ClickBtn;
    }
}

