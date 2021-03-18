namespace HospitalChargesApplication
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
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.medTextBox = new System.Windows.Forms.TextBox();
            this.surgTextBox = new System.Windows.Forms.TextBox();
            this.labTextBox = new System.Windows.Forms.TextBox();
            this.physTextBox = new System.Windows.Forms.TextBox();
            this.stayButton = new System.Windows.Forms.Button();
            this.miscButton = new System.Windows.Forms.Button();
            this.totalButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stayTextBox = new System.Windows.Forms.TextBox();
            this.miscTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // daysTextBox
            // 
            this.daysTextBox.Location = new System.Drawing.Point(522, 33);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.Size = new System.Drawing.Size(100, 20);
            this.daysTextBox.TabIndex = 0;
            this.daysTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // medTextBox
            // 
            this.medTextBox.Location = new System.Drawing.Point(522, 72);
            this.medTextBox.Name = "medTextBox";
            this.medTextBox.Size = new System.Drawing.Size(100, 20);
            this.medTextBox.TabIndex = 1;
            // 
            // surgTextBox
            // 
            this.surgTextBox.Location = new System.Drawing.Point(522, 111);
            this.surgTextBox.Name = "surgTextBox";
            this.surgTextBox.Size = new System.Drawing.Size(100, 20);
            this.surgTextBox.TabIndex = 2;
            // 
            // labTextBox
            // 
            this.labTextBox.Location = new System.Drawing.Point(522, 150);
            this.labTextBox.Name = "labTextBox";
            this.labTextBox.Size = new System.Drawing.Size(100, 20);
            this.labTextBox.TabIndex = 3;
            // 
            // physTextBox
            // 
            this.physTextBox.Location = new System.Drawing.Point(522, 189);
            this.physTextBox.Name = "physTextBox";
            this.physTextBox.Size = new System.Drawing.Size(100, 20);
            this.physTextBox.TabIndex = 4;
            // 
            // stayButton
            // 
            this.stayButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.stayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.stayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stayButton.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stayButton.Location = new System.Drawing.Point(259, 345);
            this.stayButton.Name = "stayButton";
            this.stayButton.Size = new System.Drawing.Size(152, 30);
            this.stayButton.TabIndex = 5;
            this.stayButton.Text = "Calculate Stay Charges";
            this.stayButton.UseVisualStyleBackColor = false;
            this.stayButton.Click += new System.EventHandler(this.stayButton_Click);
            // 
            // miscButton
            // 
            this.miscButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.miscButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miscButton.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscButton.Location = new System.Drawing.Point(259, 395);
            this.miscButton.Name = "miscButton";
            this.miscButton.Size = new System.Drawing.Size(152, 30);
            this.miscButton.TabIndex = 6;
            this.miscButton.Text = "Calculate Misc Charges";
            this.miscButton.UseVisualStyleBackColor = false;
            this.miscButton.Click += new System.EventHandler(this.miscButton_Click);
            // 
            // totalButton
            // 
            this.totalButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.totalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalButton.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.Location = new System.Drawing.Point(522, 345);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(100, 80);
            this.totalButton.TabIndex = 7;
            this.totalButton.Text = "Calculate Total Charges";
            this.totalButton.UseVisualStyleBackColor = false;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Days In Hospital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Medication Charges";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Surgical Charges";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lab Fees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Physical Rehabilitation Charges";
            // 
            // stayTextBox
            // 
            this.stayTextBox.BackColor = System.Drawing.Color.LightPink;
            this.stayTextBox.Location = new System.Drawing.Point(522, 228);
            this.stayTextBox.Name = "stayTextBox";
            this.stayTextBox.ReadOnly = true;
            this.stayTextBox.Size = new System.Drawing.Size(100, 20);
            this.stayTextBox.TabIndex = 13;
            // 
            // miscTextBox
            // 
            this.miscTextBox.BackColor = System.Drawing.Color.LightPink;
            this.miscTextBox.Location = new System.Drawing.Point(522, 267);
            this.miscTextBox.Name = "miscTextBox";
            this.miscTextBox.ReadOnly = true;
            this.miscTextBox.Size = new System.Drawing.Size(100, 20);
            this.miscTextBox.TabIndex = 14;
            // 
            // totalTextBox
            // 
            this.totalTextBox.BackColor = System.Drawing.Color.LightPink;
            this.totalTextBox.Location = new System.Drawing.Point(522, 306);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Stay Charges";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(238, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Miscellaneous Charges";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(305, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Total Charges";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.miscTextBox);
            this.Controls.Add(this.stayTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.miscButton);
            this.Controls.Add(this.stayButton);
            this.Controls.Add(this.physTextBox);
            this.Controls.Add(this.labTextBox);
            this.Controls.Add(this.surgTextBox);
            this.Controls.Add(this.medTextBox);
            this.Controls.Add(this.daysTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.TextBox medTextBox;
        private System.Windows.Forms.TextBox surgTextBox;
        private System.Windows.Forms.TextBox labTextBox;
        private System.Windows.Forms.TextBox physTextBox;
        private System.Windows.Forms.Button stayButton;
        private System.Windows.Forms.Button miscButton;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stayTextBox;
        private System.Windows.Forms.TextBox miscTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

