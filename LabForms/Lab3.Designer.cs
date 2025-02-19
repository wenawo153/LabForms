namespace LabForms
{
    partial class Lab3
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
            pictureBox1 = new PictureBox();
            X0box = new TextBox();
            X1box = new TextBox();
            X2box = new TextBox();
            X3box = new TextBox();
            Y3box = new TextBox();
            Y2box = new TextBox();
            Y1box = new TextBox();
            Y0box = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SwithColor = new Button();
            ColorLabel = new Label();
            DrawButton = new Button();
            SquareButton = new Button();
            PerimeterButton = new Button();
            PerimeterLaber = new Label();
            SquareLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(153, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(635, 426);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // X0box
            // 
            X0box.Location = new Point(51, 100);
            X0box.Name = "X0box";
            X0box.Size = new Size(41, 23);
            X0box.TabIndex = 1;
            // 
            // X1box
            // 
            X1box.Location = new Point(51, 129);
            X1box.Name = "X1box";
            X1box.Size = new Size(41, 23);
            X1box.TabIndex = 2;
            // 
            // X2box
            // 
            X2box.Location = new Point(51, 158);
            X2box.Name = "X2box";
            X2box.Size = new Size(41, 23);
            X2box.TabIndex = 3;
            // 
            // X3box
            // 
            X3box.Location = new Point(51, 187);
            X3box.Name = "X3box";
            X3box.Size = new Size(41, 23);
            X3box.TabIndex = 4;
            // 
            // Y3box
            // 
            Y3box.Location = new Point(98, 187);
            Y3box.Name = "Y3box";
            Y3box.Size = new Size(41, 23);
            Y3box.TabIndex = 8;
            // 
            // Y2box
            // 
            Y2box.Location = new Point(98, 158);
            Y2box.Name = "Y2box";
            Y2box.Size = new Size(41, 23);
            Y2box.TabIndex = 7;
            // 
            // Y1box
            // 
            Y1box.Location = new Point(98, 129);
            Y1box.Name = "Y1box";
            Y1box.Size = new Size(41, 23);
            Y1box.TabIndex = 6;
            // 
            // Y0box
            // 
            Y0box.Location = new Point(98, 100);
            Y0box.Name = "Y0box";
            Y0box.Size = new Size(41, 23);
            Y0box.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 103);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 9;
            label1.Text = "Cords0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 132);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 10;
            label2.Text = "Cords1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 161);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 11;
            label3.Text = "Cords2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 190);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 12;
            label4.Text = "Cords3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 82);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 13;
            label5.Text = "X";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(110, 82);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 14;
            label6.Text = "Y";
            // 
            // SwithColor
            // 
            SwithColor.Location = new Point(12, 243);
            SwithColor.Name = "SwithColor";
            SwithColor.Size = new Size(129, 34);
            SwithColor.TabIndex = 15;
            SwithColor.Text = "Next Color";
            SwithColor.UseVisualStyleBackColor = true;
            SwithColor.Click += SwithColor_Click;
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(44, 225);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(36, 15);
            ColorLabel.TabIndex = 16;
            ColorLabel.Text = "Color";
            // 
            // DrawButton
            // 
            DrawButton.Location = new Point(12, 12);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(129, 67);
            DrawButton.TabIndex = 17;
            DrawButton.Text = "DRAW";
            DrawButton.UseVisualStyleBackColor = true;
            DrawButton.Click += DrawButton_Click;
            // 
            // SquareButton
            // 
            SquareButton.Location = new Point(7, 335);
            SquareButton.Name = "SquareButton";
            SquareButton.Size = new Size(140, 32);
            SquareButton.TabIndex = 18;
            SquareButton.Text = "Square";
            SquareButton.UseVisualStyleBackColor = true;
            SquareButton.Click += SquareButton_Click;
            // 
            // PerimeterButton
            // 
            PerimeterButton.Location = new Point(7, 406);
            PerimeterButton.Name = "PerimeterButton";
            PerimeterButton.Size = new Size(140, 32);
            PerimeterButton.TabIndex = 19;
            PerimeterButton.Text = "Perimeter";
            PerimeterButton.UseVisualStyleBackColor = true;
            PerimeterButton.Click += PerimeterButton_Click;
            // 
            // PerimeterLaber
            // 
            PerimeterLaber.AutoSize = true;
            PerimeterLaber.Location = new Point(51, 388);
            PerimeterLaber.Name = "PerimeterLaber";
            PerimeterLaber.Size = new Size(58, 15);
            PerimeterLaber.TabIndex = 20;
            PerimeterLaber.Text = "Perimeter";
            // 
            // SquareLabel
            // 
            SquareLabel.AutoSize = true;
            SquareLabel.Location = new Point(51, 317);
            SquareLabel.Name = "SquareLabel";
            SquareLabel.Size = new Size(43, 15);
            SquareLabel.TabIndex = 21;
            SquareLabel.Text = "Square";
            // 
            // Lab3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SquareLabel);
            Controls.Add(PerimeterLaber);
            Controls.Add(PerimeterButton);
            Controls.Add(SquareButton);
            Controls.Add(DrawButton);
            Controls.Add(ColorLabel);
            Controls.Add(SwithColor);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Y3box);
            Controls.Add(Y2box);
            Controls.Add(Y1box);
            Controls.Add(Y0box);
            Controls.Add(X3box);
            Controls.Add(X2box);
            Controls.Add(X1box);
            Controls.Add(X0box);
            Controls.Add(pictureBox1);
            Name = "Lab3";
            Text = "Lab3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox X0box;
        private TextBox X1box;
        private TextBox X2box;
        private TextBox X3box;
        private TextBox Y3box;
        private TextBox Y2box;
        private TextBox Y1box;
        private TextBox Y0box;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button SwithColor;
        private Label ColorLabel;
        private Button DrawButton;
        private Button SquareButton;
        private Button PerimeterButton;
        private Label PerimeterLaber;
        private Label SquareLabel;
    }
}