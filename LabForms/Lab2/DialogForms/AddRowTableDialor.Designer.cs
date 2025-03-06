namespace LabForms.Lab2.DialogForms
{
    partial class AddRowTableDialor
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
            CountBox = new TextBox();
            ValueBox = new TextBox();
            CostBox = new TextBox();
            DatePicker1 = new DateTimePicker();
            CountLabel = new Label();
            ValueLabel = new Label();
            CostLabel = new Label();
            DateLabel = new Label();
            AddButton = new Button();
            SuspendLayout();
            // 
            // CountBox
            // 
            CountBox.Location = new Point(189, 9);
            CountBox.Name = "CountBox";
            CountBox.Size = new Size(138, 23);
            CountBox.TabIndex = 0;
            // 
            // ValueBox
            // 
            ValueBox.Location = new Point(189, 38);
            ValueBox.Name = "ValueBox";
            ValueBox.Size = new Size(138, 23);
            ValueBox.TabIndex = 1;
            // 
            // CostBox
            // 
            CostBox.Location = new Point(189, 67);
            CostBox.Name = "CostBox";
            CostBox.Size = new Size(138, 23);
            CostBox.TabIndex = 2;
            // 
            // DatePicker1
            // 
            DatePicker1.Location = new Point(189, 96);
            DatePicker1.Name = "DatePicker1";
            DatePicker1.Size = new Size(138, 23);
            DatePicker1.TabIndex = 5;
            // 
            // CountLabel
            // 
            CountLabel.AutoSize = true;
            CountLabel.Location = new Point(58, 9);
            CountLabel.Name = "CountLabel";
            CountLabel.Size = new Size(125, 15);
            CountLabel.TabIndex = 6;
            CountLabel.Text = "Номер счет-фактуры";
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Location = new Point(89, 38);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(94, 15);
            ValueLabel.TabIndex = 7;
            ValueLabel.Text = "Сумма к уплате";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(34, 67);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(149, 15);
            CostLabel.TabIndex = 8;
            CostLabel.Text = "Стоимость приобретения";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(20, 96);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(163, 15);
            DateLabel.TabIndex = 9;
            DateLabel.Text = "Дата выписки счет-фактуры";
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.LimeGreen;
            AddButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddButton.ForeColor = SystemColors.Control;
            AddButton.Location = new Point(175, 135);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(152, 53);
            AddButton.TabIndex = 10;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // AddRowTableDialor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 200);
            Controls.Add(AddButton);
            Controls.Add(DateLabel);
            Controls.Add(CostLabel);
            Controls.Add(ValueLabel);
            Controls.Add(CountLabel);
            Controls.Add(DatePicker1);
            Controls.Add(CostBox);
            Controls.Add(ValueBox);
            Controls.Add(CountBox);
            Name = "AddRowTableDialor";
            Text = "NewRowTableDialor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CountBox;
        private TextBox ValueBox;
        private TextBox CostBox;
        private DateTimePicker DatePicker1;
        private Label CountLabel;
        private Label ValueLabel;
        private Label CostLabel;
        private Label DateLabel;
        private Button AddButton;
    }
}