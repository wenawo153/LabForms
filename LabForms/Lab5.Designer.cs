namespace LabForms
{
    partial class Lab5
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ALabel = new Label();
            BLable = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(47, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
            // 
            // ALabel
            // 
            ALabel.AutoSize = true;
            ALabel.Location = new Point(17, 12);
            ALabel.Name = "ALabel";
            ALabel.Size = new Size(24, 25);
            ALabel.TabIndex = 2;
            ALabel.Text = "A";
            // 
            // BLable
            // 
            BLable.AutoSize = true;
            BLable.Location = new Point(17, 58);
            BLable.Name = "BLable";
            BLable.Size = new Size(22, 25);
            BLable.TabIndex = 3;
            BLable.Text = "B";
            // 
            // button1
            // 
            button1.Location = new Point(17, 112);
            button1.Name = "button1";
            button1.Size = new Size(180, 58);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // Lab5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(BLable);
            Controls.Add(ALabel);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Lab5";
            Text = "Lab5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label ALabel;
        private Label BLable;
        private Button button1;
    }
}