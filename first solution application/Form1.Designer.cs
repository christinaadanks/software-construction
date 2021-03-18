namespace FirstFormsApplication
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
            this.firstNumBox = new System.Windows.Forms.TextBox();
            this.secNumBox = new System.Windows.Forms.TextBox();
            this.opBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.firstNumLabel = new System.Windows.Forms.Label();
            this.secNumLabel = new System.Windows.Forms.Label();
            this.operationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNumBox
            // 
            this.firstNumBox.Location = new System.Drawing.Point(358, 76);
            this.firstNumBox.Name = "firstNumBox";
            this.firstNumBox.Size = new System.Drawing.Size(109, 20);
            this.firstNumBox.TabIndex = 0;
            this.firstNumBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // secNumBox
            // 
            this.secNumBox.Location = new System.Drawing.Point(358, 126);
            this.secNumBox.Name = "secNumBox";
            this.secNumBox.Size = new System.Drawing.Size(109, 20);
            this.secNumBox.TabIndex = 1;
            this.secNumBox.TextChanged += new System.EventHandler(this.secNumBox_TextChanged);
            // 
            // opBox
            // 
            this.opBox.Location = new System.Drawing.Point(358, 183);
            this.opBox.Name = "opBox";
            this.opBox.Size = new System.Drawing.Size(109, 20);
            this.opBox.TabIndex = 2;
            this.opBox.TextChanged += new System.EventHandler(this.opBox_TextChanged);
            // 
            // calcButton
            // 
            this.calcButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.calcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcButton.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(358, 242);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(109, 34);
            this.calcButton.TabIndex = 3;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(263, 315);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resultLabel.Size = new System.Drawing.Size(53, 19);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Result";
            this.resultLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstNumLabel
            // 
            this.firstNumLabel.AutoSize = true;
            this.firstNumLabel.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNumLabel.Location = new System.Drawing.Point(158, 73);
            this.firstNumLabel.Name = "firstNumLabel";
            this.firstNumLabel.Size = new System.Drawing.Size(154, 19);
            this.firstNumLabel.TabIndex = 5;
            this.firstNumLabel.Text = "Enter First Number:";
            this.firstNumLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // secNumLabel
            // 
            this.secNumLabel.AutoSize = true;
            this.secNumLabel.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secNumLabel.Location = new System.Drawing.Point(136, 127);
            this.secNumLabel.Name = "secNumLabel";
            this.secNumLabel.Size = new System.Drawing.Size(176, 19);
            this.secNumLabel.TabIndex = 6;
            this.secNumLabel.Text = "Enter Second Number:";
            // 
            // operationLabel
            // 
            this.operationLabel.AutoSize = true;
            this.operationLabel.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationLabel.Location = new System.Drawing.Point(180, 184);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(132, 19);
            this.operationLabel.TabIndex = 7;
            this.operationLabel.Text = "Enter Operation:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.operationLabel);
            this.Controls.Add(this.secNumLabel);
            this.Controls.Add(this.firstNumLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.opBox);
            this.Controls.Add(this.secNumBox);
            this.Controls.Add(this.firstNumBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNumBox;
        private System.Windows.Forms.TextBox secNumBox;
        private System.Windows.Forms.TextBox opBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label firstNumLabel;
        private System.Windows.Forms.Label secNumLabel;
        private System.Windows.Forms.Label operationLabel;
    }
}

