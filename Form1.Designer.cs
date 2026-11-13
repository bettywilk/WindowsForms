namespace WinFormsApp2
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            t2 = new TextBox();
            t1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(t2);
            panel1.Controls.Add(t1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(181, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 178);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(233, 133);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(35, 133);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // t2
            // 
            t2.Location = new Point(233, 71);
            t2.Name = "t2";
            t2.Size = new Size(125, 27);
            t2.TabIndex = 2;
            t2.Text = "Team 2: 0";
            // 
            // t1
            // 
            t1.Location = new Point(35, 71);
            t1.Name = "t1";
            t1.Size = new Size(125, 27);
            t1.TabIndex = 1;
            t1.Text = "Team 1: 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 25);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Score";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private TextBox t2;
        private TextBox t1;
        private Label label1;
    }
}
