﻿namespace CashierApp
{
    partial class Calculator
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            button2 = new Button();
            label8 = new Label();
            label9 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 34);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "Item:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(109, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(109, 23);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 78);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Price:";
            label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(175, 96);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(109, 23);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 78);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Quantity:";
            label3.Click += label3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(175, 52);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(109, 23);
            textBox4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 34);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 7;
            label4.Text = "Discount(%):";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(103, 125);
            button1.Name = "button1";
            button1.Size = new Size(89, 23);
            button1.TabIndex = 9;
            button1.Text = "Compute";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 183);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 11;
            label6.Text = "Total Amount:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(146, 183);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(125, 209);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(136, 23);
            textBox5.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 212);
            label7.Name = "label7";
            label7.Size = new Size(107, 15);
            label7.TabIndex = 13;
            label7.Text = "Payment Received:";
            // 
            // button2
            // 
            button2.Location = new Point(175, 238);
            button2.Name = "button2";
            button2.Size = new Size(65, 23);
            button2.TabIndex = 15;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 246);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 16;
            label8.Text = "Change:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(67, 246);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 17;
            // 
            // button3
            // 
            button3.Location = new Point(103, 286);
            button3.Name = "button3";
            button3.Size = new Size(89, 23);
            button3.TabIndex = 18;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 321);
            Controls.Add(button3);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Button button1;
        private Label label6;
        private Label label5;
        private TextBox textBox5;
        private Label label7;
        private Button button2;
        private Label label8;
        private Label label9;
        private Button button3;
    }
}