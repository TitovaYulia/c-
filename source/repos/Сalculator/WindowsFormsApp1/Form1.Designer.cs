namespace WindowsFormsApp1
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
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.bEqually = new System.Windows.Forms.Button();
            this.bMinus = new System.Windows.Forms.Button();
            this.bPlus = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.bPr = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bT = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.AccessibleDescription = "1";
            this.b1.Location = new System.Drawing.Point(336, 159);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(34, 32);
            this.b1.TabIndex = 3;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.procNumericButton);
            // 
            // b2
            // 
            this.b2.AccessibleDescription = "2";
            this.b2.Location = new System.Drawing.Point(376, 159);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(34, 32);
            this.b2.TabIndex = 4;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.procNumericButton);
            // 
            // b3
            // 
            this.b3.AccessibleDescription = "3";
            this.b3.Location = new System.Drawing.Point(416, 159);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(34, 32);
            this.b3.TabIndex = 5;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.procNumericButton);
            // 
            // bEqually
            // 
            this.bEqually.AccessibleDescription = "=";
            this.bEqually.Location = new System.Drawing.Point(497, 159);
            this.bEqually.Name = "bEqually";
            this.bEqually.Size = new System.Drawing.Size(34, 70);
            this.bEqually.TabIndex = 8;
            this.bEqually.Text = "=";
            this.bEqually.UseVisualStyleBackColor = true;
            this.bEqually.Click += new System.EventHandler(this.bEqually_Click);
            // 
            // bMinus
            // 
            this.bMinus.AccessibleDescription = "-";
            this.bMinus.Location = new System.Drawing.Point(455, 122);
            this.bMinus.Name = "bMinus";
            this.bMinus.Size = new System.Drawing.Size(34, 32);
            this.bMinus.TabIndex = 7;
            this.bMinus.Text = "-";
            this.bMinus.UseVisualStyleBackColor = true;
            this.bMinus.Click += new System.EventHandler(this.actNumericButton);
            // 
            // bPlus
            // 
            this.bPlus.AccessibleDescription = "+";
            this.bPlus.Location = new System.Drawing.Point(455, 85);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(34, 31);
            this.bPlus.TabIndex = 6;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = true;
            this.bPlus.Click += new System.EventHandler(this.actNumericButton);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(336, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 20);
            this.textBox3.TabIndex = 9;
            // 
            // b4
            // 
            this.b4.AccessibleDescription = "4";
            this.b4.Location = new System.Drawing.Point(336, 122);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(34, 32);
            this.b4.TabIndex = 10;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.procNumericButton);
            // 
            // b5
            // 
            this.b5.AccessibleDescription = "5";
            this.b5.Location = new System.Drawing.Point(376, 122);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(34, 32);
            this.b5.TabIndex = 11;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.procNumericButton);
            // 
            // b6
            // 
            this.b6.AccessibleDescription = "6";
            this.b6.Location = new System.Drawing.Point(416, 122);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(34, 32);
            this.b6.TabIndex = 12;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.procNumericButton);
            // 
            // b9
            // 
            this.b9.AccessibleDescription = "9";
            this.b9.Location = new System.Drawing.Point(416, 84);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(34, 32);
            this.b9.TabIndex = 15;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.procNumericButton);
            // 
            // b8
            // 
            this.b8.AccessibleDescription = "8";
            this.b8.Location = new System.Drawing.Point(376, 84);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(34, 32);
            this.b8.TabIndex = 14;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.procNumericButton);
            // 
            // b7
            // 
            this.b7.AccessibleDescription = "7";
            this.b7.Location = new System.Drawing.Point(336, 84);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(34, 32);
            this.b7.TabIndex = 13;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.procNumericButton);
            // 
            // bPr
            // 
            this.bPr.AccessibleDescription = "*";
            this.bPr.Location = new System.Drawing.Point(456, 159);
            this.bPr.Name = "bPr";
            this.bPr.Size = new System.Drawing.Size(33, 32);
            this.bPr.TabIndex = 16;
            this.bPr.Text = "*";
            this.bPr.UseVisualStyleBackColor = true;
            this.bPr.Click += new System.EventHandler(this.actNumericButton);
            // 
            // bDiv
            // 
            this.bDiv.AccessibleDescription = "/";
            this.bDiv.Location = new System.Drawing.Point(456, 197);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(33, 32);
            this.bDiv.TabIndex = 17;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = true;
            this.bDiv.Click += new System.EventHandler(this.actNumericButton);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(376, 197);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(34, 32);
            this.b0.TabIndex = 18;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.procNumericButton);
            // 
            // bT
            // 
            this.bT.Location = new System.Drawing.Point(416, 197);
            this.bT.Name = "bT";
            this.bT.Size = new System.Drawing.Size(33, 32);
            this.bT.TabIndex = 18;
            this.bT.Text = ",";
            this.bT.UseVisualStyleBackColor = true;
            this.bT.Click += new System.EventHandler(this.procNumericButton);
            // 
            // bC
            // 
            this.bC.Location = new System.Drawing.Point(496, 84);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(34, 32);
            this.bC.TabIndex = 19;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 314);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bT);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.bPr);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.bEqually);
            this.Controls.Add(this.bMinus);
            this.Controls.Add(this.bPlus);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bEqually;
        private System.Windows.Forms.Button bMinus;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button bPr;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bT;
        private System.Windows.Forms.Button bC;
    }
}

