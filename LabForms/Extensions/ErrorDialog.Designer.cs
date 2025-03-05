namespace LabForms.Extensions
{
    partial class ErrorDialog
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
            ErrorLabel = new Label();
            ErrorMessegaLabel = new Label();
            SuspendLayout();
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.BackColor = Color.OrangeRed;
            ErrorLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ErrorLabel.ForeColor = SystemColors.ButtonHighlight;
            ErrorLabel.Location = new Point(this.Width / 2 , 20);
            //ErrorLabel.Left = ;
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(45, 21);
            ErrorLabel.TabIndex = 0;
            ErrorLabel.Text = "Error";
            // 
            // ErrorMessegaLabel
            // 
            ErrorMessegaLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ErrorMessegaLabel.Location = new Point(10, 50);
            ErrorMessegaLabel.Name = "ErrorMessegaLabel";
            ErrorMessegaLabel.Size = new Size(364, 40);
            ErrorMessegaLabel.TabIndex = 1;
            // 
            // ErrorDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 161);
            Controls.Add(ErrorMessegaLabel);
            Controls.Add(ErrorLabel);
            Name = "ErrorDialog";
            Text = "ErrorDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ErrorLabel;
        private Label ErrorMessegaLabel;
    }
}