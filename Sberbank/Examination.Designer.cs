namespace Sberbank
{
    partial class ExaminationForm
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
            this.InputLabel = new System.Windows.Forms.Label();
            this.RandomTextLabel = new System.Windows.Forms.Label();
            this.RandomTextBox = new System.Windows.Forms.TextBox();
            this.ExaminationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(108, 47);
            this.InputLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(175, 31);
            this.InputLabel.TabIndex = 0;
            this.InputLabel.Text = "Введите текст";
            // 
            // RandomTextLabel
            // 
            this.RandomTextLabel.AutoSize = true;
            this.RandomTextLabel.Location = new System.Drawing.Point(92, 96);
            this.RandomTextLabel.Name = "RandomTextLabel";
            this.RandomTextLabel.Size = new System.Drawing.Size(250, 31);
            this.RandomTextLabel.TabIndex = 1;
            this.RandomTextLabel.Text = "Рандомные символы";
            this.RandomTextLabel.Layout += new System.Windows.Forms.LayoutEventHandler(this.RandomTextLabel_Layout);
            // 
            // RandomTextBox
            // 
            this.RandomTextBox.Location = new System.Drawing.Point(114, 147);
            this.RandomTextBox.Name = "RandomTextBox";
            this.RandomTextBox.Size = new System.Drawing.Size(169, 39);
            this.RandomTextBox.TabIndex = 2;
            // 
            // ExaminationButton
            // 
            this.ExaminationButton.Location = new System.Drawing.Point(130, 202);
            this.ExaminationButton.Name = "ExaminationButton";
            this.ExaminationButton.Size = new System.Drawing.Size(137, 40);
            this.ExaminationButton.TabIndex = 3;
            this.ExaminationButton.Text = "Ввод";
            this.ExaminationButton.UseVisualStyleBackColor = true;
            this.ExaminationButton.Click += new System.EventHandler(this.ExaminationButton_Click);
            // 
            // ExaminationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(421, 319);
            this.Controls.Add(this.ExaminationButton);
            this.Controls.Add(this.RandomTextBox);
            this.Controls.Add(this.RandomTextLabel);
            this.Controls.Add(this.InputLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ExaminationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проверка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label RandomTextLabel;
        private System.Windows.Forms.TextBox RandomTextBox;
        private System.Windows.Forms.Button ExaminationButton;
    }
}