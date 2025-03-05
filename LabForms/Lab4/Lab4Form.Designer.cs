namespace LabForms
{
    partial class Lab4Form
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
            dTextBox = new TextBox();
            d1TextBox = new TextBox();
            d2TextBox = new TextBox();
            dLabel = new Label();
            d1Labek = new Label();
            d2Label = new Label();
            numberListBox = new TextBox();
            numberLabel = new Label();
            enterNumberButton = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            resultLabel = new Label();
            sourceLabel = new Label();
            d1Count = new Label();
            label1 = new Label();
            EnterButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dTextBox
            // 
            dTextBox.Location = new Point(56, 6);
            dTextBox.Name = "dTextBox";
            dTextBox.Size = new Size(100, 23);
            dTextBox.TabIndex = 0;
            // 
            // d1TextBox
            // 
            d1TextBox.Location = new Point(56, 35);
            d1TextBox.Name = "d1TextBox";
            d1TextBox.Size = new Size(100, 23);
            d1TextBox.TabIndex = 1;
            // 
            // d2TextBox
            // 
            d2TextBox.Location = new Point(56, 64);
            d2TextBox.Name = "d2TextBox";
            d2TextBox.Size = new Size(100, 23);
            d2TextBox.TabIndex = 2;
            // 
            // dLabel
            // 
            dLabel.AutoSize = true;
            dLabel.Location = new Point(12, 9);
            dLabel.Name = "dLabel";
            dLabel.Size = new Size(15, 15);
            dLabel.TabIndex = 3;
            dLabel.Text = "D";
            // 
            // d1Labek
            // 
            d1Labek.AutoSize = true;
            d1Labek.Location = new Point(12, 38);
            d1Labek.Name = "d1Labek";
            d1Labek.Size = new Size(21, 15);
            d1Labek.TabIndex = 4;
            d1Labek.Text = "D1";
            // 
            // d2Label
            // 
            d2Label.AutoSize = true;
            d2Label.Location = new Point(12, 67);
            d2Label.Name = "d2Label";
            d2Label.Size = new Size(21, 15);
            d2Label.TabIndex = 5;
            d2Label.Text = "D2";
            // 
            // numberListBox
            // 
            numberListBox.Location = new Point(12, 139);
            numberListBox.Name = "numberListBox";
            numberListBox.Size = new Size(99, 23);
            numberListBox.TabIndex = 6;
            // 
            // numberLabel
            // 
            numberLabel.Location = new Point(12, 102);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(158, 34);
            numberLabel.TabIndex = 7;
            numberLabel.Text = "Введите следующий элемент списка";
            numberLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // enterNumberButton
            // 
            enterNumberButton.Location = new Point(117, 139);
            enterNumberButton.Name = "enterNumberButton";
            enterNumberButton.Size = new Size(53, 23);
            enterNumberButton.TabIndex = 8;
            enterNumberButton.Text = "Enter";
            enterNumberButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(158, 444);
            dataGridView1.TabIndex = 9;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(179, 102);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(159, 446);
            dataGridView2.TabIndex = 10;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(179, 72);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(146, 15);
            resultLabel.TabIndex = 11;
            resultLabel.Text = "Результирующий список";
            // 
            // sourceLabel
            // 
            sourceLabel.AutoSize = true;
            sourceLabel.Location = new Point(12, 182);
            sourceLabel.Name = "sourceLabel";
            sourceLabel.Size = new Size(106, 15);
            sourceLabel.TabIndex = 12;
            sourceLabel.Text = "Исходный список";
            // 
            // d1Count
            // 
            d1Count.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            d1Count.Location = new Point(179, 551);
            d1Count.Name = "d1Count";
            d1Count.Size = new Size(159, 43);
            d1Count.TabIndex = 13;
            d1Count.Text = "Количество повтроряющихся D1:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 594);
            label1.Name = "label1";
            label1.Size = new Size(19, 21);
            label1.TabIndex = 14;
            label1.Text = "0";
            // 
            // EnterButton
            // 
            EnterButton.Location = new Point(179, 12);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(159, 46);
            EnterButton.TabIndex = 15;
            EnterButton.Text = "Преобразовать";
            EnterButton.UseVisualStyleBackColor = true;
            // 
            // Lab4Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 656);
            Controls.Add(EnterButton);
            Controls.Add(label1);
            Controls.Add(d1Count);
            Controls.Add(sourceLabel);
            Controls.Add(resultLabel);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(enterNumberButton);
            Controls.Add(numberLabel);
            Controls.Add(numberListBox);
            Controls.Add(d2Label);
            Controls.Add(d1Labek);
            Controls.Add(dLabel);
            Controls.Add(d2TextBox);
            Controls.Add(d1TextBox);
            Controls.Add(dTextBox);
            Name = "Lab4Form";
            Text = "Lab4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dTextBox;
        private TextBox d1TextBox;
        private TextBox d2TextBox;
        private Label dLabel;
        private Label d1Labek;
        private Label d2Label;
        private TextBox numberListBox;
        private Label numberLabel;
        private Button enterNumberButton;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label resultLabel;
        private Label sourceLabel;
        private Label d1Count;
        private Label label1;
        private Button EnterButton;
    }
}