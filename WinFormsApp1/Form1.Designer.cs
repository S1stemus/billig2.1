namespace WinFormsApp1
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
            this.Result = new System.Windows.Forms.TextBox();
            this.MaxNum = new System.Windows.Forms.TextBox();
            this.MinNum = new System.Windows.Forms.TextBox();
            this.MaxCount = new System.Windows.Forms.TextBox();
            this.MinCount = new System.Windows.Forms.TextBox();
            this.MaxDiff = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(59, 54);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Result.Size = new System.Drawing.Size(399, 228);
            this.Result.TabIndex = 0;
            // 
            // MaxNum
            // 
            this.MaxNum.Location = new System.Drawing.Point(490, 106);
            this.MaxNum.Name = "MaxNum";
            this.MaxNum.Size = new System.Drawing.Size(100, 23);
            this.MaxNum.TabIndex = 1;
            this.MaxNum.TextChanged += new System.EventHandler(this.MaxNum_TextChanged);
            // 
            // MinNum
            // 
            this.MinNum.Location = new System.Drawing.Point(490, 174);
            this.MinNum.Name = "MinNum";
            this.MinNum.Size = new System.Drawing.Size(100, 23);
            this.MinNum.TabIndex = 2;
            this.MinNum.TextChanged += new System.EventHandler(this.MinNum_TextChanged);
            // 
            // MaxCount
            // 
            this.MaxCount.Location = new System.Drawing.Point(59, 344);
            this.MaxCount.Name = "MaxCount";
            this.MaxCount.ReadOnly = true;
            this.MaxCount.Size = new System.Drawing.Size(100, 23);
            this.MaxCount.TabIndex = 3;
            // 
            // MinCount
            // 
            this.MinCount.Location = new System.Drawing.Point(205, 344);
            this.MinCount.Name = "MinCount";
            this.MinCount.ReadOnly = true;
            this.MinCount.Size = new System.Drawing.Size(100, 23);
            this.MinCount.TabIndex = 4;
            // 
            // MaxDiff
            // 
            this.MaxDiff.Location = new System.Drawing.Point(358, 344);
            this.MaxDiff.Name = "MaxDiff";
            this.MaxDiff.ReadOnly = true;
            this.MaxDiff.Size = new System.Drawing.Size(100, 23);
            this.MaxDiff.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 62);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Максимальное число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Минимальное число";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MaxDiff);
            this.Controls.Add(this.MinCount);
            this.Controls.Add(this.MaxCount);
            this.Controls.Add(this.MinNum);
            this.Controls.Add(this.MaxNum);
            this.Controls.Add(this.Result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.TextBox MaxNum;
        private System.Windows.Forms.TextBox MinNum;
        private System.Windows.Forms.TextBox MaxCount;
        private System.Windows.Forms.TextBox MinCount;
        private System.Windows.Forms.TextBox MaxDiff;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
