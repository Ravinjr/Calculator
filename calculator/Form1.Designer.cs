namespace calculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.additionbtn = new System.Windows.Forms.Button();
            this.substractionbtn = new System.Windows.Forms.Button();
            this.multiplicationbtn = new System.Windows.Forms.Button();
            this.divisionbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Claculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(355, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(355, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 22);
            this.textBox2.TabIndex = 4;
            // 
            // additionbtn
            // 
            this.additionbtn.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionbtn.Location = new System.Drawing.Point(91, 307);
            this.additionbtn.Name = "additionbtn";
            this.additionbtn.Size = new System.Drawing.Size(146, 30);
            this.additionbtn.TabIndex = 5;
            this.additionbtn.Text = "Addition";
            this.additionbtn.UseVisualStyleBackColor = true;
            this.additionbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // substractionbtn
            // 
            this.substractionbtn.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.substractionbtn.Location = new System.Drawing.Point(263, 307);
            this.substractionbtn.Name = "substractionbtn";
            this.substractionbtn.Size = new System.Drawing.Size(139, 30);
            this.substractionbtn.TabIndex = 6;
            this.substractionbtn.Text = "Substraction";
            this.substractionbtn.UseVisualStyleBackColor = true;
            this.substractionbtn.Click += new System.EventHandler(this.substractionbtn_Click);
            // 
            // multiplicationbtn
            // 
            this.multiplicationbtn.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicationbtn.Location = new System.Drawing.Point(426, 307);
            this.multiplicationbtn.Name = "multiplicationbtn";
            this.multiplicationbtn.Size = new System.Drawing.Size(167, 30);
            this.multiplicationbtn.TabIndex = 7;
            this.multiplicationbtn.Text = "Multiplication";
            this.multiplicationbtn.UseVisualStyleBackColor = true;
            this.multiplicationbtn.Click += new System.EventHandler(this.multiplicationbtn_Click);
            // 
            // divisionbtn
            // 
            this.divisionbtn.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionbtn.Location = new System.Drawing.Point(615, 307);
            this.divisionbtn.Name = "divisionbtn";
            this.divisionbtn.Size = new System.Drawing.Size(124, 30);
            this.divisionbtn.TabIndex = 8;
            this.divisionbtn.Text = "Division";
            this.divisionbtn.UseVisualStyleBackColor = true;
            this.divisionbtn.Click += new System.EventHandler(this.divisionbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(359, 382);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(134, 32);
            this.clearbtn.TabIndex = 9;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 494);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.divisionbtn);
            this.Controls.Add(this.multiplicationbtn);
            this.Controls.Add(this.substractionbtn);
            this.Controls.Add(this.additionbtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button additionbtn;
        private System.Windows.Forms.Button substractionbtn;
        private System.Windows.Forms.Button multiplicationbtn;
        private System.Windows.Forms.Button divisionbtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Label label4;
    }
}

