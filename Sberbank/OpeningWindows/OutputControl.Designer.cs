namespace Sberbank.OpeningWindows
{
    partial class OutputControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.OutputBalanceBox = new System.Windows.Forms.MaskedTextBox();
            this.OutputBalanceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Снять";
            // 
            // OutputBalanceBox
            // 
            this.OutputBalanceBox.BackColor = System.Drawing.SystemColors.Window;
            this.OutputBalanceBox.Font = new System.Drawing.Font("Times New Roman", 27.75F);
            this.OutputBalanceBox.ForeColor = System.Drawing.Color.Green;
            this.OutputBalanceBox.Location = new System.Drawing.Point(122, 240);
            this.OutputBalanceBox.Mask = "000000";
            this.OutputBalanceBox.Name = "OutputBalanceBox";
            this.OutputBalanceBox.Size = new System.Drawing.Size(187, 50);
            this.OutputBalanceBox.TabIndex = 1;
            // 
            // OutputBalanceButton
            // 
            this.OutputBalanceButton.BackColor = System.Drawing.Color.Green;
            this.OutputBalanceButton.Font = new System.Drawing.Font("Times New Roman", 36F);
            this.OutputBalanceButton.ForeColor = System.Drawing.Color.White;
            this.OutputBalanceButton.Location = new System.Drawing.Point(350, 232);
            this.OutputBalanceButton.Name = "OutputBalanceButton";
            this.OutputBalanceButton.Size = new System.Drawing.Size(252, 73);
            this.OutputBalanceButton.TabIndex = 2;
            this.OutputBalanceButton.Text = "Снять";
            this.OutputBalanceButton.UseVisualStyleBackColor = false;
            this.OutputBalanceButton.Click += new System.EventHandler(this.OutputBalanceButton_Click);
            // 
            // OutputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.OutputBalanceButton);
            this.Controls.Add(this.OutputBalanceBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Green;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "OutputControl";
            this.Size = new System.Drawing.Size(801, 544);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox OutputBalanceBox;
        private System.Windows.Forms.Button OutputBalanceButton;
    }
}
