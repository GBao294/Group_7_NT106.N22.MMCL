﻿namespace Lab4
{
    partial class Menu
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            Bai4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(32, 35);
            button1.Name = "button1";
            button1.Size = new Size(314, 120);
            button1.TabIndex = 0;
            button1.Text = "Bai1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(434, 35);
            button2.Name = "button2";
            button2.Size = new Size(314, 120);
            button2.TabIndex = 1;
            button2.Text = "Bai2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(32, 225);
            button3.Name = "button3";
            button3.Size = new Size(314, 120);
            button3.TabIndex = 2;
            button3.Text = "Bai3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(434, 230);
            button4.Name = "button4";
            button4.Size = new Size(314, 115);
            button4.TabIndex = 3;
            button4.Text = "Bai5";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Bai4
            // 
            Bai4.Location = new Point(827, 35);
            Bai4.Name = "Bai4";
            Bai4.Size = new Size(314, 120);
            Bai4.TabIndex = 4;
            Bai4.Text = "Bai4";
            Bai4.UseVisualStyleBackColor = true;
            Bai4.Click += Bai4_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 463);
            Controls.Add(Bai4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button Bai4;
    }
}