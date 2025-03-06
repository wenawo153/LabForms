namespace LabForms.Lab2.DialogForms
{
    partial class EditRowTableDialog
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
            EditButton = new Button();
            DateLabel = new Label();
            CostLabel = new Label();
            ValueLabel = new Label();
            CountLabel = new Label();
            DatePicker1 = new DateTimePicker();
            CostBox = new TextBox();
            ValueBox = new TextBox();
            CountBox = new TextBox();
            SuspendLayout();
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.Orange;
            EditButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditButton.ForeColor = SystemColors.Control;
            EditButton.Location = new Point(172, 135);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(152, 53);
            EditButton.TabIndex = 19;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(17, 96);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(163, 15);
            DateLabel.TabIndex = 18;
            DateLabel.Text = "Дата выписки счет-фактуры";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(31, 67);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(149, 15);
            CostLabel.TabIndex = 17;
            CostLabel.Text = "Стоимость приобретения";
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Location = new Point(86, 38);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(94, 15);
            ValueLabel.TabIndex = 16;
            ValueLabel.Text = "Сумма к уплате";
            // 
            // CountLabel
            // 
            CountLabel.AutoSize = true;
            CountLabel.Location = new Point(55, 9);
            CountLabel.Name = "CountLabel";
            CountLabel.Size = new Size(125, 15);
            CountLabel.TabIndex = 15;
            CountLabel.Text = "Номер счет-фактуры";
            // 
            // DatePicker1
            // 
            DatePicker1.Location = new Point(186, 96);
            DatePicker1.Name = "DatePicker1";
            DatePicker1.Size = new Size(138, 23);
            DatePicker1.TabIndex = 14;
            // 
            // CostBox
            // 
            CostBox.Location = new Point(186, 67);
            CostBox.Name = "CostBox";
            CostBox.Size = new Size(138, 23);
            CostBox.TabIndex = 13;
            // 
            // ValueBox
            // 
            ValueBox.Location = new Point(186, 38);
            ValueBox.Name = "ValueBox";
            ValueBox.Size = new Size(138, 23);
            ValueBox.TabIndex = 12;
            // 
            // CountBox
            // 
            CountBox.Location = new Point(186, 9);
            CountBox.Name = "CountBox";
            CountBox.Size = new Size(138, 23);
            CountBox.TabIndex = 11;
            // 
            // EditRowTableDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 202);
            Controls.Add(EditButton);
            Controls.Add(DateLabel);
            Controls.Add(CostLabel);
            Controls.Add(ValueLabel);
            Controls.Add(CountLabel);
            Controls.Add(DatePicker1);
            Controls.Add(CostBox);
            Controls.Add(ValueBox);
            Controls.Add(CountBox);
            Name = "EditRowTableDialog";
            Text = "EditRowTableDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EditButton;
        private Label DateLabel;
        private Label CostLabel;
        private Label ValueLabel;
        private Label CountLabel;
        private DateTimePicker DatePicker1;
        private TextBox CostBox;
        private TextBox ValueBox;
        private TextBox CountBox;
    }
}